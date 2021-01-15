import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggerService {

  constructor() { }

  logError(msg: string, category: string){

    console.log(`An error ${msg} occured in category ${category}`);
  }
}
