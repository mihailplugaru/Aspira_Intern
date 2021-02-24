import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataSharerOneComponent } from './data-sharer-one/data-sharer-one.component';
import { DataSharerTwoComponent } from './data-sharer-two/data-sharer-two.component';

@NgModule({
  declarations: [
    AppComponent,
    DataSharerOneComponent,
    DataSharerTwoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
