import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  @Input() titleEvent: string;

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void { }

  onClick(): void {
    this.router.navigate(['/home']);
  }
}
