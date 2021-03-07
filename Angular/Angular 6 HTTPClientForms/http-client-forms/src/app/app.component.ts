import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MatTabChangeEvent } from '@angular/material/tabs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'http-client-forms';
  constructor(private router: Router) { }

  onTabChanged(event: MatTabChangeEvent): void {
    switch (event.index) {
      case 0:
        this.router.navigate(['/HttpStuff']);
        break;
      case 1:
        this.router.navigate(['/createUser']);
        break;
      case 2:
        this.router.navigate(['/usersDisplayer']);
        break;
    }
  }
}
