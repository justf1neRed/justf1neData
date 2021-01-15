import { Component, OnInit } from '@angular/core';

import { ItemsService } from '../../services/items.service';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.scss']
})
export class ItemListComponent implements OnInit {

  constructor(private itemServise: ItemsService) { }

  Items: Array<any> = [];

  ngOnInit(): void {

    this.itemServise.getItemsList().subscribe((data)=>{

      if(data){
        this.Items = data;
        console.log(this.Items);
      }
    }, (err)=>{
      console.log(err);
    })
  }

}
