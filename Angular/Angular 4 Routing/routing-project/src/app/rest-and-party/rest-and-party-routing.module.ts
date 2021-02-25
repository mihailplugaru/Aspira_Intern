import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RestAndPartyComponent } from './rest-and-party.component';


const routes: Routes = [
  {
    path: '',
    component: RestAndPartyComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RestAndPartyRoutingModule { }
