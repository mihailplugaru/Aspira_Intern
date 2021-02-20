import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FirstParentComponent } from './first-parent/first-parent.component';
import { FirstChildComponent } from './first-child/first-child.component';

@NgModule({
  declarations: [
    AppComponent,
    FirstParentComponent,
    FirstChildComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
