import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../interfaces/User';
import { UsersService } from '../services/users.service';

@Component({
  selector: 'app-users-displayer',
  templateUrl: './users-displayer.component.html',
  styleUrls: ['./users-displayer.component.css']
})
export class UsersDisplayerComponent implements OnInit {

  listOfUsers : User[] = [];
  p: number = 1;

  constructor(public usersService : UsersService, private router: Router) { }

  ngOnInit(): void {
      this.usersService.getUsers$.subscribe((user)=>{
        this.listOfUsers.push(user);
        console.log(this.listOfUsers);
      })
  }

  

  goToRegForm(){
    this.router.navigate(['/createUser']);
  }
}
