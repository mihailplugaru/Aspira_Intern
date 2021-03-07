import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { User } from '../interfaces/User';
import { UsersService } from '../services/users.service';

@Component({
  selector: 'app-users-displayer',
  templateUrl: './users-displayer.component.html',
  styleUrls: ['./users-displayer.component.css']
})
export class UsersDisplayerComponent implements OnInit {

  loaded = false;

  listOfUsers: User[] = [];

  displayedColumns: string[] = ['fName', 'lName', 'age', 'email', 'phone'];

  dataSource: MatTableDataSource<User>;

  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private usersService: UsersService, private router: Router) { }

  ngOnInit(): void {
    this.usersService.getUsers$.subscribe((users) => {
      if (users) {
        this.listOfUsers = users;
        console.log(this.listOfUsers);
        this.dataSource = new MatTableDataSource<User>(this.listOfUsers);
        if (this.listOfUsers.length != 0){
          this.loaded = true;
        }
      }
    })
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  goToRegForm() {
    this.router.navigate(['/createUser']);
  }
}
