import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Author } from '../models/Author';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  private api = `${environment.ApiUrlBase}/Author`
  constructor(private http : HttpClient) {}

  Get(): Observable<Author[]>{
    return this.http.get<Author[]>(this.api);
  }
}
