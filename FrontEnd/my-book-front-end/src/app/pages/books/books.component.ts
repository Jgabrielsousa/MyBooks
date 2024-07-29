import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book.service';
import { Book } from '../../models/Book';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrl: './books.component.css'
})
export class BooksComponent implements OnInit{

  books : Book[] = [];
  constructor(private service: BookService){}


  ngOnInit(): void {
    this.GetBooks()
  }


  GetBooks(){

    this.service.Get().subscribe(data=> {
      this.books = data;
      console.log(this.books)
    })
  }



}


