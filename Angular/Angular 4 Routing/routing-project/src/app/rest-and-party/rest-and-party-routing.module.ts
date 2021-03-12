import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventsComponent } from './events/events.component';
import { PlacesComponent } from './places/places.component';
import { RestAndPartyComponent } from './rest-and-party.component';
import { TicketsComponent } from './tickets/tickets.component';


const routes: Routes = [
  {
    path: '',
    component: RestAndPartyComponent,
    children: [
      {
        path: '',
        component: EventsComponent
      },
      {
        path: 'events',
        component: EventsComponent
      },
      {
        path: 'places',
        component: PlacesComponent
      },
      {
        path: 'tickets',
        component: TicketsComponent
      }]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RestAndPartyRoutingModule { }
