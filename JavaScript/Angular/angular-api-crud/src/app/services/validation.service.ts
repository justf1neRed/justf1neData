import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ValidationService {

  constructor() { }

  assureNotEmpty(str: string): boolean{

    if(str){
      if(str.trim().length>0){
        return true;
      }
      else return false;
    }
    else return false;

  }

  assureNotNull(value: number):boolean{

    if(value>0) return true;
    else return false;
  }
}
