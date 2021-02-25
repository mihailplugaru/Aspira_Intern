import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { EventsComponent } from './rest-and-party/events/events.component';
import { PlacesComponent } from './rest-and-party/places/places.component';
import { TicketsComponent } from './rest-and-party/tickets/tickets.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'restparty',
    loadChildren: () => import('./rest-and-party/rest-and-party.module').then(e => e.RestAndPartyModule)
  },
  {
    path: 'work',
    loadChildren: () => import('./work/work.module').then(e => e.WorkModule)
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
  },
  {
    path: '',
    component: HomeComponent
  },
  {
    path: '**',
    component: NotFoundComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
