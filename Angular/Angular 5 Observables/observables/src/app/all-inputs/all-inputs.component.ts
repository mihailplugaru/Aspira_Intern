import { Component, OnInit } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Person } from '../classes/Person';
import { SaveNamesToSubjectService } from '../services/save-names-to-subject.service';
import { SavePersonsToObservableService } from '../services/save-persons-to-observable.service';

@Component({
  selector: 'app-all-inputs',
  templateUrl: './all-inputs.component.html',
  styleUrls: ['./all-inputs.component.css']
})
export class AllInputsComponent implements OnInit {

  constructor(private saveNamesToSubject: SaveNamesToSubjectService, private savePersonsToObservable : SavePersonsToObservableService) { }

  ngOnInit(): void {
  }

  namesToSubject(name: string) {
    if (name) {
      this.saveNamesToSubject.names.next(name);
    }
  }

  personToObservable(name: string, age: number){
    if (name && age) {
      this.savePersonsToObservable.listOfPersons.push(new Person(name,age))
    }
  }
}
