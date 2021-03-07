import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Person } from '../classes/Person';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class SavePersonsToObservableService {

  listOfPersons : Person[] = [];

  getPerson$: Observable<Person[]> = of(this.listOfPersons);

  getNames$ = of(this.listOfPersons.map(x=> x.name));// does not  work properly

  constructor() { }
}
