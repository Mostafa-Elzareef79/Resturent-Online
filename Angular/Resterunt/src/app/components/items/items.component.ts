import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ItemsService } from 'src/app/services/items.service';
import { SelectedItemsService } from 'src/app/services/selected-items.service';
import { UndoItemsService } from 'src/app/services/undo-items.service';
import { Iitems } from 'src/interfaces/IItems';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemsComponent implements OnInit {
  pageSize:number=4;
  p:number=1;
  restruntId:number=0;
  allItems: any []= [];
  checkedItems: Iitems[] = [];
  constructor(private active:ActivatedRoute,private service:ItemsService,private toastr:ToastrService ,private Selecteditems:SelectedItemsService,private router:Router,private Undo:UndoItemsService){


  }
  ngOnInit(): void {
   this.restruntId=Number(this.active.snapshot.paramMap.get("id"))
   this.service.getitems(this.restruntId).subscribe((data) => {
    this.allItems=data
 

   const selectedItems = this.Selecteditems.getSelectedItems();
   this.checkedItems = selectedItems ? selectedItems : [];
  
 
  },
  (error) => {
    this.toastr.error('Error connecting to the server', 'Server Connection Error');
  }
);
 

  }

  onchange(event: any, itemSelected: any) {
    if (event && event.target instanceof HTMLInputElement) {
      const checked = event.target.checked;
      const item = itemSelected;
  
      if (checked) {
       
        const exists = this.checkedItems.some((checkedItem) => checkedItem.name === item.name);
  
        if (exists) {
          this.toastr.warning("This item is already added");
          return;
        }
  
        this.checkedItems.push(item);
      } else {
      
        const index = this.checkedItems.findIndex((checkedItem) => checkedItem.name === item.name);
  
        if (index !== -1) {
          this.checkedItems.splice(index, 1);
        }
      }
    }
  }
  isChecked(item: Iitems): boolean {
    return this.checkedItems.some((checkedItem) => checkedItem.name === item.name);
  }
  
  

  next() {

    if (this.checkedItems.length === 0) {
     
      this.toastr.warning('Please select at least one item.');
      return; 
    }
  
    
    this.Selecteditems.setSelectedItems(this.checkedItems);
    this.Undo.setSelectedRestrunt(this.restruntId);
    this.router.navigateByUrl("/rigister");
  }
  
  }



