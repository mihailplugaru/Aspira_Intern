import { Component, Input, OnInit } from '@angular/core';
 
@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

@Input() titleEvent : string;
 
  constructor() { }

  ngOnInit(): void {
  }

}
