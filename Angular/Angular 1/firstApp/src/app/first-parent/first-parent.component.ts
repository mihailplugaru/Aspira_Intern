import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-first-parent',
  templateUrl: './first-parent.component.html',
  styleUrls: ['./first-parent.component.css']
})
export class FirstParentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  parentInputs = [];
  onClickSubmit(inputValue: string) {
    if (inputValue) {
      this.parentInputs.push(inputValue);
    }
  }
}
