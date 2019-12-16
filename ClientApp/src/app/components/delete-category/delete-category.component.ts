import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-delete-category',
  templateUrl: './delete-category.component.html',
  styleUrls: ['./delete-category.component.css']
})
export class DeleteCategoryComponent implements OnInit {

  category: any;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private service: CategoryService) { }

  ngOnInit() {
    this.service.getCategoryById(this.route.snapshot.params.id).subscribe(data => {
      this.category = data;
    })
  }

  deleteCategory(id: number){
    this.service.deleteCategory(id).subscribe(data => {
      this.router.navigate(["/categories"]);
    })
  }

}
