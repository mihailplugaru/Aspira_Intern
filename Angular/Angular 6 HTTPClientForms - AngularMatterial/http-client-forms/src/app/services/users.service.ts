import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { User } from '../interfaces/User';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  listOfUsers : User[] = [];

  getUsers$: Observable<User[]> = of(this.listOfUsers);

  constructor() { }
}
