import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-first-parent',
  templateUrl: './first-parent.component.html',
  styleUrls: ['./first-parent.component.css']
})
export class FirstParentComponent implements OnInit {

  parentInputs = [];
  
  constructor() { }

  ngOnInit(): void {
  }

  onClickSubmit(inputValue: string) {
    if (inputValue) {
      this.parentInputs.push(inputValue);
    }
  }
}
