import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';
import { Book } from '../models/Book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private api = `${environment.ApiUrlBase}/Book`
  constructor(private http : HttpClient) {}

  Get(): Observable<Book[]>{
    return this.http.get<Book[]>(this.api);
  }
}
