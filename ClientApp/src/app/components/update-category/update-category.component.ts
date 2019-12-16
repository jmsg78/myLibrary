import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/services/category.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrls: ['./update-category.component.css']
})
export class UpdateCategoryComponent implements OnInit {

  category: any;
  updateCategoryForm: FormGroup;

  constructor(private service: CategoryService,
    private route: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder) { }

  ngOnInit() {
    this.service.getCategoryById(this.route.snapshot.params.id).subscribe(data => {
      this.category = data;

      this.updateCategoryForm = this.fb.group({
        id:[data.id],
        name:[data.name, Validators.required],
        description:[data.description, Validators.compose([Validators.required, Validators.minLength(10)])],
      })

    })
  }

  onSubmit(){
    this.service.updateCategory(this.updateCategoryForm.value).subscribe(data => {
      this.router.navigate(["/categories"]);
    })
  }

}
