import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/services/category.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

  public categories: Category[];

  constructor(private service: CategoryService, private router : Router) { }

  ngOnInit() {
    this.service.getAllCategories().subscribe((data: Category[]) => { 
      this.categories = data; 
    });
    
  }

  showCategory(id: number){
    this.router.navigate(["/show-category/"+id])
  }

  updateCategory(id: number){
    this.router.navigate(["/update-category/"+id])
  }

  deleteCategory(id: number){
    this.router.navigate(["/delete-category/"+id])
  }

}
