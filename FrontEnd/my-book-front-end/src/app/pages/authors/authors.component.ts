import { Component, OnInit } from '@angular/core';
import { Author } from '../../models/Author';
import { AuthorService } from '../../services/author.service';

@Component({
  selector: 'app-authors',
  templateUrl: './authors.component.html',
  styleUrl: './authors.component.css'
})
export class AuthorsComponent implements OnInit{
  authors : Author[] = [];

  constructor(private service : AuthorService) {}


  ngOnInit(): void {
    this.service.Get().subscribe(data=> {
      this.authors = data;
      data.map((item)=>{
        console.log(item)
      })
    })
  }
}
