import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  _baseURL: string = "api/Authors";

  constructor(private http: HttpClient) { }

  getAllAuthors(){
    return this.http.get<Author[]>(this._baseURL+"/GetAuthors");
  }

  AddAuthor(author: Author){
    return this.http.post(this._baseURL+"/AddAuthor/", author);
  }

  getAuthorById(id: number){
    return this.http.get<Author>(this._baseURL+"/SingleAuthor/"+id);
  }

  updateAuthor(author: Author){
    return this.http.put(this._baseURL+"/UpdateAuthor/"+author.id, author);
  }

  deleteAuthor(id: number){
    return this.http.delete(this._baseURL+"/DeleteAuthor/"+id);
  }

}