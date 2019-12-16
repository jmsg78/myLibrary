import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthorService } from 'src/app/services/author.service';

@Component({
  selector: 'app-delete-author',
  templateUrl: './delete-author.component.html',
  styleUrls: ['./delete-author.component.css']
})
export class DeleteAuthorComponent implements OnInit {

  author: any;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private service: AuthorService) { }

  ngOnInit() {
    this.service.getAuthorById(this.route.snapshot.params.id).subscribe(data => {
      this.author = data;
    })
  }

  deleteAuthor(id: number){
    this.service.deleteAuthor(id).subscribe(data => {
      this.router.navigate(["/authors"]);
    })
  }

}
