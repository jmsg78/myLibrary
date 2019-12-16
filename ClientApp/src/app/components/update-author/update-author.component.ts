import { Component, OnInit } from '@angular/core';
import { AuthorService } from 'src/app/services/author.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-update-author',
  templateUrl: './update-author.component.html',
  styleUrls: ['./update-author.component.css']
})
export class UpdateAuthorComponent implements OnInit {

  author: any;
  updateAuthorForm: FormGroup;

  constructor(private service: AuthorService,
    private route: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder) { }

  ngOnInit() {
    this.service.getAuthorById(this.route.snapshot.params.id).subscribe(data => {
      this.author = data;

      this.updateAuthorForm = this.fb.group({
        id:[data.id],
        firstName:[data.firstName, Validators.required],
        lastName:[data.lastName, Validators.required],
        birthDate:[data.birthDate]
      })

    })
  }

  formatDate(date: Date){
    if(date){
      return new Date(date).toISOString().substring(0,10);
    }
  }

  onSubmit(){
    this.service.updateAuthor(this.updateAuthorForm.value).subscribe(data => {
      this.router.navigate(["/authors"]);
    })
  }

}
