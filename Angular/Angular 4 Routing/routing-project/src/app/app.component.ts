import { Component } from '@angular/core';
import { MatTabChangeEvent } from '@angular/material/tabs';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'routing-project';

  constructor(private router: Router, private route: ActivatedRoute) { }

  onTabChanged(event: MatTabChangeEvent): void {
    switch (event.index) {
      case 0:
        this.router.navigate(['/events']);
        console.log('Tab 0 clicked');
        break;
      case 1:
        break;
    }
  }

  ngOnInit(): void  { }
}

