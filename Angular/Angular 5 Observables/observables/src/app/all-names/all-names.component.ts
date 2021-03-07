import { Component, OnInit } from '@angular/core';
import { SaveNamesToSubjectService } from '../services/save-names-to-subject.service';
import { SavePersonsToObservableService } from '../services/save-persons-to-observable.service';

@Component({
  selector: 'app-all-names',
  templateUrl: './all-names.component.html',
  styleUrls: ['./all-names.component.css']
})
export class AllNamesComponent implements OnInit {

  namesFromSubject$ = [];
  persons = [];

  constructor(private saveNamesToSubject: SaveNamesToSubjectService, private savePersonsToObservable : SavePersonsToObservableService) { }

  ngOnInit(): void {
    this.saveNamesToSubject.names.subscribe(x => {
      this.namesFromSubject$.push(x);
    });

    this.savePersonsToObservable.getPerson$.subscribe(p => {
      this.persons = (p);
    });
  }
}
