import { Injectable } from '@angular/core';
import { Observable, of, Subject } from 'rxjs';
import { User } from '../interfaces/User';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  listOfUsers : User[] = [];

  getUsers$: Subject<User> = new Subject();

  constructor() { }
}
