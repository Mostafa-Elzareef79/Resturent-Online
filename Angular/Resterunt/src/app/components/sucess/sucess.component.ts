import { Component, OnInit } from '@angular/core';
import { ListService } from 'src/app/services/list.service';
import { SelectedItemsService } from 'src/app/services/selected-items.service';

@Component({
  selector: 'app-sucess',
  templateUrl: './sucess.component.html',
  styleUrls: ['./sucess.component.css']
})
export class SucessComponent implements OnInit {
  data:any;
  totalPrice:number=0;
  constructor(private selectedData:ListService){}
  ngOnInit(): void {
  this.data=this.selectedData.getSelectedItems();
  
  for (let item of this.data) {
    this.totalPrice += (item.price * item.quantity);
  }

  }
  

}
