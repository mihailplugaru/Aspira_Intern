import { Component, OnInit } from '@angular/core';
import { Employee } from '../Classes/Employee';
import { RegisterEmployeesService } from '../services/registerEmployees.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  nameInput: string;
  positionInput: string;

  constructor(private registerEmployees: RegisterEmployeesService) {
  }

  onClickSubmit(name: string, position: string) {
    if (name && position) {
      this.nameInput = name;
      this.positionInput = position;

      const newEmp = new Employee(this.nameInput, this.positionInput);

      this.registerEmployees.addEmployee(newEmp);
    }
  }

  ngOnInit(): void {
  }

}
