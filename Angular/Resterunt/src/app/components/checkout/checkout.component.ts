import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { RegisterdataService } from 'src/app/services/registerdata.service';
import { ActivatedRoute, Router } from '@angular/router';
import { SelectedItemsService } from 'src/app/services/selected-items.service';
import { Iitems } from 'src/interfaces/IItems';
import { ToastrService } from 'ngx-toastr';
import { ChecoutService } from 'src/app/services/checout.service';
import { ListService } from 'src/app/services/list.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {
  quantity: number = 0; 
  checkedItems: Iitems[] = [];
total:number=0;
  formdata:any={
    name:'',
  phone:'',
  email:'',
  address:'',
  }
  constructor(private registerdata:RegisterdataService,private list:ListService,private route: ActivatedRoute,private selecteditems:SelectedItemsService,private router:Router,private toastr:ToastrService,private checoutServise:ChecoutService){

  }
  ngOnInit(): void {
 this.formdata=this.registerdata.getFormData()
 this.checkedItems=this.selecteditems.getSelectedItems();

this.list.setSelectedItems([])


  }
 


  increaseQuantity(i:number) {
   
    this.checkedItems[i].quantity++;
  
  }

  decreaseQuantity(i:number) {
   

    if (this.checkedItems[i].quantity > 1) {
      this.checkedItems[i].quantity--;
    }
    if (this.checkedItems[i].quantity == 1){
      return;
    }
  }
  calculateTotalPrice(): number {
    let totalPrice = 0;
    for (let item of this.checkedItems) {
      totalPrice += (item.price * item.quantity);
    }
    this.total=totalPrice
    return totalPrice;
  }

 
  removeItem(index: number): void {
    this.checkedItems.splice(index, 1);
   this.selecteditems.setSelectedItems(this.checkedItems);

}
back(){
  
 
  this.router.navigateByUrl("/rigister")
  
  }
  finish(){
  if(this.checkedItems.length==0){
   
    this.toastr.warning("there is no items in card")
    return;
  }
  if(this.formdata.length==0){
    this.toastr.warning("your data is missing")
    return;
  }
  
  const data=[this.formdata,this.checkedItems]
 const  formdatas:any={
    name:this.formdata.name,
  phone:this.formdata.phone,
  email:this.formdata.email,
  address:this.formdata.address,
  subtotal:this.total
  }
  const all:any={
    order:formdatas,
    items:this.checkedItems
  }
 this.checoutServise.addOrder(all).subscribe((response)=>{

 })
    this.router.navigateByUrl("/sucess")
    this.toastr.success("order will arived as soon as  possible")
    this.list.setSelectedItems(this.checkedItems)
 
    
    }
}
