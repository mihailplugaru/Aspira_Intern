import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-data-sharer-two',
  templateUrl: './data-sharer-two.component.html',
  styleUrls: ['./data-sharer-two.component.css']
})
export class DataSharerTwoComponent implements OnInit {
  @Input() twoInput: string;
  @Output() twoInputChange = new EventEmitter<string>();

    constructor() { }

  ngOnInit(): void {
  }

  tellInput(param : string){
    this.twoInput = param;
    this.twoInputChange.emit(this.twoInput);
  }
}
