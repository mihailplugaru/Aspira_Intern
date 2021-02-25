import { NgModule} from '@angular/core';
import { CommonModule } from '@angular/common';
import { PlacesComponent } from './places/places.component';
import { TicketsComponent } from './tickets/tickets.component';
import { EventsComponent } from './events/events.component';
import { RestAndPartyRoutingModule } from './rest-and-party-routing.module';
import { RestAndPartyComponent } from './rest-and-party.component';


@NgModule({
  declarations: [
    EventsComponent,
    PlacesComponent,
    TicketsComponent,
    RestAndPartyComponent,
  ],
  imports: [
    CommonModule,
    RestAndPartyRoutingModule
  ],
  exports: [
    EventsComponent,
    PlacesComponent,
    TicketsComponent,
    RestAndPartyComponent
  ]
})
export class RestAndPartyModule { }
