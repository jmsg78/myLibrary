import { Component, OnInit } from '@angular/core';
import { AuthorService } from 'src/app/services/author.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-author',
  templateUrl: './new-author.component.html',
  styleUrls: ['./new-author.component.css']
})
export class NewAuthorComponent implements OnInit {

  addAuthorForm: FormGroup;
  showError: boolean = false;

  constructor(private service: AuthorService, private fb: FormBuilder, private router: Router) { }

  ngOnInit() {
    this.addAuthorForm = this.fb.group({
      id:[Math.floor(Math.random()*1000)],
      firstName:[null, Validators.required],
      lastName:[null, Validators.required],
      birthDate:[null]
    });
  }

  onSubmit(){
    console.log(this.addAuthorForm.value);
    this.service.AddAuthor(this.addAuthorForm.value).subscribe(data => {
      this.router.navigate(["/authors"]);
    }, error => { this.showError = true;} ) 
  }
}
