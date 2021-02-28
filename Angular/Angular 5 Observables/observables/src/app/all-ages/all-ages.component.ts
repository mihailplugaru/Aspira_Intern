import { Component, OnInit } from '@angular/core';
import { SavePersonsToObservableService } from '../services/save-persons-to-observable.service';

@Component({
  selector: 'app-all-ages',
  templateUrl: './all-ages.component.html',
  styleUrls: ['./all-ages.component.css']
})
export class AllAgesComponent implements OnInit {

  persons$ = [];

  constructor( private savePersonsToObservable : SavePersonsToObservableService) { }

  ngOnInit(): void {
    this.savePersonsToObservable.getPerson$.subscribe(p => {
      this.persons$ = (p);
    });
  }

}
