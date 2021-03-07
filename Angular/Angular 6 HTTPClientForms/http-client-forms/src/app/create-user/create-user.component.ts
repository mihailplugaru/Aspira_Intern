import { Component, NgModule, OnInit } from '@angular/core';
import {FormControl, FormGroup, NgForm, Validators} from '@angular/forms'
import { Router } from '@angular/router';
import { User } from '../interfaces/User';
import { UsersService } from '../services/users.service';

@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.css']
})
export class CreateUserComponent implements OnInit {

  form : FormGroup;
  submitted = false;

  constructor(private usersService : UsersService, private router: Router) { }

  ngOnInit(): void {
    this.initForm();
  }

  onSubmit(f : NgForm){
    this.submitted = true;
    const user = new User();
    user.fName = this.fname.value;
    user.lName = this.lname.value;
    user.age = this.age.value;
    user.email = this.email.value;
    user.phone = this.phone.value;

    this.usersService.getUsers$.next(user);
  }

  initForm(){
    this.form = new FormGroup({
      fname : new FormControl('', [Validators.required, Validators.maxLength(23),Validators.minLength(2)]),
      lname : new FormControl('', [Validators.required, Validators.maxLength(23),Validators.minLength(2)]),
      age : new FormControl('', [Validators.required, Validators.max(111),Validators.min(18),Validators.pattern('^[0-9]*$')]),
      email : new FormControl('', [Validators.required, Validators.email]),
      phone : new FormControl('', [Validators.required, Validators.pattern('^([0-9\(\)\/\+ \-]*)$')])
    })
  }

  get fname() {return this.form.get('fname')}
  get lname() {return this.form.get('lname')}
  get age() {return this.form.get('age')}
  get email() {return this.form.get('email')}
  get phone() {return this.form.get('phone')}

  submitUser(){
    // const user = new User();
    // user.fName = this.fname.value;
    // user.lName = this.lname.value;
    // user.age = this.age.value;
    // user.email = this.email.value;
    // user.phone = this.phone.value;


    // this.usersService.getUsers$.next(user);
    //this.usersService.listOfUsers.push(user);

    this.router.navigate(['/usersDisplayer']);
  }

  goToUsersTable(){
    this.router.navigate(['/usersDisplayer']);
  }
}
