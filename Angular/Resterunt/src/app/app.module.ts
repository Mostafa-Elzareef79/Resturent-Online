import { NgModule, OnInit } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HTTP_INTERCEPTORS, HttpClient, HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SearchPageComponent } from './components/search-page/search-page.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ItemsComponent } from './components/items/items.component';
import { RegisterComponent } from './components/register/register.component';
import { CheckoutComponent } from './components/checkout/checkout.component';
import { ToastrModule } from 'ngx-toastr';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgxPaginationModule } from 'ngx-pagination';
import { NgxSpinnerModule } from 'ngx-spinner';
import { SucessComponent } from './components/sucess/sucess.component';
import { Router, RouterModule } from '@angular/router';
import { ErorComponent } from './components/eror/eror.component';


@NgModule({
  declarations: [
    AppComponent,
    SearchPageComponent,
    ItemsComponent,
    RegisterComponent,
    CheckoutComponent,
    SucessComponent,
    ErorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
   ToastrModule.forRoot({
      timeOut: 3000, // Toast disappears after 3 seconds
      progressBar: true,
      positionClass: 'toast-bottom-right',
    })
     , BrowserAnimationsModule,
     NgxPaginationModule,
     NgxSpinnerModule.forRoot({
      type: 'line-scale-party',
    }),
    ReactiveFormsModule,
    RouterModule.forRoot([])
    

  ],
  providers: [
   
  ],
  bootstrap: [AppComponent]
})
export class AppModule implements OnInit {
  constructor(private router: Router) {
    console.log('Constructor executed'); 
  }
  ngOnInit(): void {
    console.log('ngOnInit executed'); 
    // this.router.navigate(['/search']);
  }
}
