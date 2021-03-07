import { Injectable } from '@angular/core';
import { Employee } from '../Classes/Employee';

@Injectable({
  providedIn: 'root'
})
export class RegisterEmployeesService {

  employees : Employee[] =[];

  constructor() { }

  addEmployee(emp: Employee) {
    this.employees.push(emp);
  }
}
