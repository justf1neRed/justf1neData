import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ItemListComponent } from './components/item-list/item-list.component';
import { MainComponentComponent } from './components/main-component/main-component.component';

const routes: Routes = [
  {path: '', pathMatch: 'full', redirectTo: ''}, // для пустого маршрута
  {path: 'items', component: ItemListComponent},
  {path: 'catalog', component: MainComponentComponent},
  {path: '*', redirectTo: ''} // маршрут по умолчанию
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
