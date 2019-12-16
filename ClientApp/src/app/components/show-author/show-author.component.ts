import { Component, OnInit } from '@angular/core';
import { AuthorService } from 'src/app/services/author.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-show-author',
  templateUrl: './show-author.component.html',
  styleUrls: ['./show-author.component.css']
})
export class ShowAuthorComponent implements OnInit {

  author: Author;
  
  constructor(private service: AuthorService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.service.getAuthorById(this.route.snapshot.params.id).subscribe(data => {
      this.author = data;
    })
  }

}
