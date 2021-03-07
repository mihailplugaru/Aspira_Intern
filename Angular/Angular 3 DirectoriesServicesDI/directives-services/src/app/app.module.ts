import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { DisplayEmployeeComponent } from './display-employee/display-employee.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { NgForLoopDirective } from './Directives/ng-for-loop.directive';
import { RegisterEmployeesService } from './services/registerEmployees.service';
import { MatSelectModule } from '@angular/material/select';
import { IncreaseFontTwiceDirective } from './Directives/increase-font-twice.directive';
import { DecreaseFontTwiceDirective } from './Directives/decrease-font-twice.directive';

@NgModule({
  declarations: [
    AppComponent,
    AddEmployeeComponent,
    DisplayEmployeeComponent,
    NgForLoopDirective,
    IncreaseFontTwiceDirective,
    DecreaseFontTwiceDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    MatListModule,
    MatSelectModule
  ],
  providers: [RegisterEmployeesService],
  bootstrap: [AppComponent],
  exports: [NgForLoopDirective]
})

export class AppModule { }
