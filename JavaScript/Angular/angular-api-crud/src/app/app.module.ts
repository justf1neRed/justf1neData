import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ItemListComponent } from './components/item-list/item-list.component';
import {HttpClientModule} from '@angular/common/http';
import { MainComponentComponent } from './components/main-component/main-component.component';


@NgModule({
  declarations: [
    AppComponent,
    ItemListComponent,
    MainComponentComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
