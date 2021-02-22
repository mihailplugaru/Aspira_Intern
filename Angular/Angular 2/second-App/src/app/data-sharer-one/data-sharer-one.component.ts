import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-sharer-one',
  templateUrl: './data-sharer-one.component.html',
  styleUrls: ['./data-sharer-one.component.css']
})
export class DataSharerOneComponent implements OnInit {
  @Input('oneInput') oneInput: string;

  constructor() { }

  ngOnInit(): void {
  }

  hearInput($event) {
    this.oneInput = $event;
  }
}
