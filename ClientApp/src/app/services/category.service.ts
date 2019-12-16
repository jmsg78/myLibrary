import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  _baseURL: string = "api/Categories";

  constructor(private http: HttpClient) { }

  getAllCategories(){
    return this.http.get<Category[]>(this._baseURL+"/GetCategories");
  }

  addCategory(category: Category){
    return this.http.post(this._baseURL+"/AddCategory/", category);
  }

  getCategoryById(id: number){
    return this.http.get<Category>(this._baseURL+"/SingleCategory/"+id);
  }

  updateCategory(category: Category){
    return this.http.put(this._baseURL+"/UpdateCategory/"+category.id, category);
  }

  deleteCategory(id: number){
    return this.http.delete(this._baseURL+"/DeleteCategory/"+id);
  }

}