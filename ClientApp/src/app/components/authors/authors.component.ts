import { Component, OnInit } from '@angular/core';
import { AuthorService } from 'src/app/services/author.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-authors',
  templateUrl: './authors.component.html',
  styleUrls: ['./authors.component.css']
})
export class AuthorsComponent implements OnInit {

  public authors: Author[];

  constructor(private service: AuthorService, private router : Router) { }

  ngOnInit() {
    this.service.getAllAuthors().subscribe((data: Author[]) => { 
      this.authors = data; 
    });
    
  }

  showAuthor(id: number){
    this.router.navigate(["/show-author/"+id])
  }

  updateAuthor(id: number){
    this.router.navigate(["/update-author/"+id])
  }

  deleteAuthor(id: number){
    this.router.navigate(["/delete-author/"+id])
  }

}
