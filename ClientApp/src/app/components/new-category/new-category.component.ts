import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/services/category.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-new-category',
  templateUrl: './new-category.component.html',
  styleUrls: ['./new-category.component.css']
})
export class NewCategoryComponent implements OnInit {

  addCategoryForm: FormGroup;
  showError: boolean = false;

  constructor(private service: CategoryService, private fb: FormBuilder, private router: Router) { }

  ngOnInit() {
    this.addCategoryForm = this.fb.group({
      id:[Math.floor(Math.random()*1000)],
      name:["New Category", Validators.required],
      description:[null, Validators.compose([Validators.required, Validators.minLength(10)])],
    });
  }

  onSubmit(){
    console.log(this.addCategoryForm.value);
    this.service.addCategory(this.addCategoryForm.value).subscribe(data => {
      this.router.navigate(["/categories"]);
    }, error => { this.showError = true;} ) 
  }

}
