import { Component, OnInit } from '@angular/core';

import { ItemsService } from '../../services/items.service';

import {Item} from '../../classes/item';

import { LoggerService } from '../../services/logger.service';

import {ValidationService} from '../../services/validation.service';

@Component({
  selector: 'app-main-component',
  templateUrl: './main-component.component.html',
  styleUrls: ['./main-component.component.scss']
})
export class MainComponentComponent implements OnInit {

  validationMessage: string = "";

  constructor(private itemServise: ItemsService, private logger: LoggerService,
    private validator: ValidationService) { }

  Items: Array<any> = [];
  ItemToEdit: any = {};

  addItem(Name: string, Price: string){

  
    if(this.validateFromData(Name, parseInt(Price))){
      let defaultID: number = 0;
      let newItem = new Item(defaultID, Name, parseInt(Price));
      this.itemServise.addItem(newItem).subscribe(item=>this.Items.push(item));
    }
    else{
      this.validationMessage += "Данные не валидны!";
      this.logger.logError(this.validationMessage, "Items info");
    }

    
  }

  editItem(itemID: number){

    let saveBtnVisible = document.getElementById('saveBtn');
    
    if(saveBtnVisible){
      saveBtnVisible.style.display = "block";
    }
    
    this.itemServise.getById(itemID).subscribe((data)=>{
      this.ItemToEdit = data;
    },
    (err)=>{
      console.log(err);
    })
  }

  saveItem(itemID: string, Name: string, Price: string){

    let ItemToSave = new Item(parseInt(itemID), Name, parseInt(Price))
    
    this.itemServise.saveItem(ItemToSave).subscribe((data)=>{console.log(data);
    this.getItems();}, (err)=>{
      console.log(err);
    })
    
  }

  deleteItem(itemID: number): boolean{
    
    let result: boolean = false;

    this.itemServise.deleteItem(itemID).subscribe(
      (data)=>{
        console.log(data);
        this.getItems();
        result = data;
      },
      (err)=>{
        console.log(err);
        return false;
      }
    );
    return result;
  }

  

  ngOnInit(): void {
    this.getItems();
  }

  private getItems(){
    this.itemServise.getItemsList().subscribe((data)=>{
      if(data){
        this.Items = data;
        console.log(this.Items);
      }
    }, (err)=>{
      console.log(err);
    })
  }

  validateFromData(str: string, value: number):boolean{

    let validationResult: boolean = true;
    this.validationMessage = "";

    if(!this.validator.assureNotEmpty(str)){
      this.validationMessage += "Itemname is empty!";
      validationResult = false;
    }

    if(!this.validator.assureNotNull(value)){
      this.validationMessage += "Price must be bigger then 0!";
      validationResult = false;
    }

    return validationResult;

  }
}
