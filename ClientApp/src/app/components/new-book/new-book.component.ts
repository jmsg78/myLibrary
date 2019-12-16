import { Component, OnInit } from '@angular/core';
import { BookService } from 'src/app/services/book.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-book',
  templateUrl: './new-book.component.html',
  styleUrls: ['./new-book.component.css']
})
export class NewBookComponent implements OnInit {

  addBookForm: FormGroup;
  showError: boolean = false;

  constructor(private service: BookService, private fb: FormBuilder, private router: Router) { }

  ngOnInit() {
    this.addBookForm = this.fb.group({
      id:[Math.floor(Math.random()*1000)],
      title:["New Book", Validators.required],
      description:[null, Validators.compose([Validators.required, Validators.minLength(10)])],
      author:[null, Validators.required],
      category:[null, Validators.required],
      isbn:[null, Validators.required],
    });
  }

  onSubmit(){
    console.log(this.addBookForm.value);
    this.service.addBook(this.addBookForm.value).subscribe(data => {
      this.router.navigate(["/books"]);
    }, error => { this.showError = true;} ) 
  }

}