import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-first-child',
  templateUrl: './first-child.component.html',
  styleUrls: ['./first-child.component.css']
})
export class FirstChildComponent implements OnInit {
@Input('childInput') childInput: string;

  constructor() { }

  ngOnInit(): void {
  }
}
