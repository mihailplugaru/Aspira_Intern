import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateUserComponent } from './create-user/create-user.component';
import { DataDisplayerComponent } from './data-displayer/data-displayer.component';
import { UsersDisplayerComponent } from './users-displayer/users-displayer.component';

const routes: Routes = [
  {
    path: 'HttpStuff',
    component: DataDisplayerComponent
  },
  {
    path: 'createUser',
    component: CreateUserComponent
  },
  {
    path: 'usersDisplayer',
    component: UsersDisplayerComponent
  },
  {
    path: '',
    component: DataDisplayerComponent
  },
  {
    path: '**',
    component: DataDisplayerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
