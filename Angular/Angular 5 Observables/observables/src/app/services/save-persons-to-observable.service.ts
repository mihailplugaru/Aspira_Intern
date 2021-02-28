import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Person } from '../classes/Person';

@Injectable({
  providedIn: 'root'
})
export class SavePersonsToObservableService {

  listOfPersons : Person[] = [];

  getPerson$: Observable<Person[]> = of(this.listOfPersons);

  constructor() { }
}
