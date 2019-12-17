import { Component, OnInit } from '@angular/core';
import { BookService } from 'src/app/services/book.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
    public books : Book[];

  constructor(private service: BookService, private router : Router) { }

  ngOnInit() {
    this.service.getAllBooks().subscribe((data: Book[]) => { 
      this.books = data; 
    });
    
  }
}

