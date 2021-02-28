import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllInputsComponent } from './all-inputs/all-inputs.component';
import { AllNamesComponent } from './all-names/all-names.component';
import { AllAgesComponent } from './all-ages/all-ages.component';

@NgModule({
  declarations: [
    AppComponent,
    AllInputsComponent,
    AllNamesComponent,
    AllAgesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
