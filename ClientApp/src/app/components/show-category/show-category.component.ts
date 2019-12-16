import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/services/category.service';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-show-category',
  templateUrl: './show-category.component.html',
  styleUrls: ['./show-category.component.css']
})
export class ShowCategoryComponent implements OnInit {

  category: Category;
  
  constructor(private service: CategoryService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.service.getCategoryById(this.route.snapshot.params.id).subscribe(data => {
      this.category = data;
    })
  }
}
