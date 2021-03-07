import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateUserComponent } from './create-user/create-user.component';
import { UsersDisplayerComponent } from './users-displayer/users-displayer.component';

const routes: Routes = [
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
    component: CreateUserComponent
  },
  {
    path: '**',
    component: CreateUserComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
