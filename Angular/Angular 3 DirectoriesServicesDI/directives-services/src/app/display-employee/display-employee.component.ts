import { Component, OnInit, Input } from '@angular/core';
import { RegisterEmployeesService } from '../services/registerEmployees.service';

@Component({
  selector: 'app-display-employee',
  templateUrl: './display-employee.component.html',
  styleUrls: ['./display-employee.component.css']
})
export class DisplayEmployeeComponent implements OnInit {
  @Input('empName') empName: string;
  @Input('empPosition') empPosition: string;

  constructor(private registerEmployees : RegisterEmployeesService) { }

  employeeList =  this.registerEmployees.employees;

  ngOnInit(): void {
  }
}

