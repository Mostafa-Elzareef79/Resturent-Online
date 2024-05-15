import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RegisterdataService } from 'src/app/services/registerdata.service';
import { SearchService } from 'src/app/services/search.service';
import { SelectedItemsService } from 'src/app/services/selected-items.service';

@Component({
  selector: 'app-search-page',
  templateUrl: './search-page.component.html',
  styleUrls: ['./search-page.component.css']
})
export class SearchPageComponent implements OnInit {
  searchRestaurant: string = '';
  selectedCity: any='';
  allCities: any[] = [];
  allRestaurants: any[] = [];
NoRestruntHere:boolean=false;

  constructor(private service: SearchService, private router: Router,private registerdata:RegisterdataService,private selecteditems:SelectedItemsService,private toastr:ToastrService) {}

  ngOnInit(): void {
    
    this.selecteditems.setSelectedItems([]);
    this.registerdata.setFormData([]);
    this.service.getAllcities().subscribe((data) => {
      this.allCities = data;
    });

    this.service.getAllRestrunts().subscribe((data) => {
      this.allRestaurants = data;
    },
    (error) => {
      this.toastr.error('Error connecting to the server', 'Server Connection Error');
    }
  );
    if(this.allRestaurants.length==0){
      this.NoRestruntHere=true;
    }
    
  }

  search(): void {
   
    if (this.selectedCity) {
      this.service.getAllRestruntInCity(this.selectedCity).subscribe((data) => {
        this.allRestaurants = data;
        this.filterRestaurants();
      });
    } else {
      this.filterRestaurants();
    }
   
  }

  filterRestaurants(): void {

    if (this.searchRestaurant.trim() === '') {
      return;
    }

    const searchTerm = this.searchRestaurant.toLowerCase();


    
    this.allRestaurants = this.allRestaurants.filter((restaurant) => {
      return restaurant.name.toLowerCase().includes(searchTerm);
    });
   
    if(this.allRestaurants.length==0){
      this.NoRestruntHere=true;
    }
  }

  goToItems(id: number): void {
    this.router.navigate(['items/' + id]);
  }
  refresh(){
    this.searchRestaurant = '';
    this.selectedCity=''
    this.allCities = [];
    this.allRestaurants = [];
    this.ngOnInit();
    
  }
}
