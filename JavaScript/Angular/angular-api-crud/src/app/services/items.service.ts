import { Injectable } from '@angular/core';

import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse
}from '@angular/common/http';

import {
  Observable,
  throwError
} from 'rxjs';

import {catchError} from 'rxjs/operators';

const apiBaseURL = 'http://localhost:55772/api/Items';

const httpOption = {
  headers: new HttpHeaders({Accept: 'application/json'})
}

import {Item} from '../classes/item';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(private httpClient: HttpClient) { }

  private processHttpError(error: HttpErrorResponse){

    return throwError(error);
  }

  public getItemsList(): Observable<any>{

    return this.httpClient
              .get(apiBaseURL, httpOption)
              .pipe(catchError(this.processHttpError));
  }

  public addItem(item: Item){

    return this.httpClient
              .post(apiBaseURL, item, httpOption)
              .pipe(catchError(this.processHttpError));
  }

  public deleteItem(itemID: number): Observable<any>{

    let itemDeleteUrl = `${apiBaseURL}/${itemID}`;

    return this.httpClient
              .delete(itemDeleteUrl, httpOption)
              .pipe(catchError(this.processHttpError));

}

public getById(itemID: number): Observable<any>{

  let itemUpdateUrl = `${apiBaseURL}/${itemID}`;

    return this.httpClient
              .get(itemUpdateUrl, httpOption)
              .pipe(catchError(this.processHttpError));
}

public saveItem(item: Item){
  
  return this.httpClient
              .put(apiBaseURL, item, httpOption)
              .pipe(catchError(this.processHttpError));

}


}
