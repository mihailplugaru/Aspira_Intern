import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-sharer-one',
  templateUrl: './data-sharer-one.component.html',
  styleUrls: ['./data-sharer-one.component.css']
})
export class DataSharerOneComponent implements OnInit {
  oneInput: string;

  constructor() { }

  ngOnInit(): void {
  }

  twoInput($event) {
    this.oneInput = $event;
  }
}
