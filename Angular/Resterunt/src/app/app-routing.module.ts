import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SearchPageComponent } from './components/search-page/search-page.component';
import { ItemsComponent } from './components/items/items.component';
import { RegisterComponent } from './components/register/register.component';
import { CheckoutComponent } from './components/checkout/checkout.component';
import { SucessComponent } from './components/sucess/sucess.component';
import { ErorComponent } from './components/eror/eror.component';

const routes: Routes = [

  { path: '', redirectTo: '/search', pathMatch: 'full' },
  
  
      { path: 'search', component: SearchPageComponent },
      { path: 'items/:id', component: ItemsComponent },
      { path: 'rigister', component: RegisterComponent },
      { path: 'checkout', component: CheckoutComponent },
      { path: 'sucess', component: SucessComponent },
      { path: 'error', component: ErorComponent },
      { path: '**', redirectTo: 'error' }



      
    
  
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
