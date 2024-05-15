import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RegisterdataService } from './../../services/registerdata.service';
import { UndoItemsService } from 'src/app/services/undo-items.service';
import { emailValidator } from 'src/app/emailValidator';

import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Toast, ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  form:FormGroup;
  undoToItemsByRestruntId:number=this.undo.getSelectedRestrunt()
  formdata:any={
    name:'',
  phone:'',
  email:'',
  address:'',
  }
  constructor(private router:Router,private registerdata:RegisterdataService,private undo:UndoItemsService,private formBuilder: FormBuilder,private toastr:ToastrService){this.form = this.formBuilder.group({
    name: ['',[Validators.required]],
    phone: ['', [Validators.required, Validators.pattern(/^\d{11}$/)]],
    email: ['', [Validators.required, Validators.email,emailValidator()]],
    address: ['', Validators.required]
  });}
 

  get name() {
    return this.form.get("name")
  }
  get email() {
    return this.form.get("email")
  }
  get phone() {
    return this.form.get("phone")
  }
  get address() {
    return this.form.get("address")
  }
  
  ngOnInit(): void {
   this.formdata=this.registerdata.getFormData()
     
  
  }

back(){
  
 
this.router.navigateByUrl("/items/"+this.undoToItemsByRestruntId)

}
onSubmit() {
  if (this.form?.invalid) {
    this.toastr.warning('Please enter a valid data');
    return;
  }
this.formdata=this.form.value

  this.registerdata.setFormData(this.formdata)
 
  this.router.navigateByUrl("/checkout")
  
}
}
