import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { BooksComponent } from './components/books/books.component';
import { DeleteBookComponent } from './components/delete-book/delete-book.component';
import { NewBookComponent } from './components/new-book/new-book.component';
import { ShowBookComponent } from './components/show-book/show-book.component';
import { UpdateBookComponent } from './components/update-book/update-book.component';
import { BookService } from './services/book.service';
import { AuthorService } from './services/author.service';
import { AuthService } from './services/auth.service';
import { AuthGuard } from './auth.guard';
import { CategoryService } from './services/category.service';
import { CategoriesComponent } from './components/categories/categories.component';
import { DeleteCategoryComponent } from './components/delete-category/delete-category.component';
import { UpdateCategoryComponent } from './components/update-category/update-category.component';
import { ShowCategoryComponent } from './components/show-category/show-category.component';
import { NewCategoryComponent } from './components/new-category/new-category.component';
import { AuthorsComponent } from './components/authors/authors.component';
import { DeleteAuthorComponent } from './components/delete-author/delete-author.component';
import { UpdateAuthorComponent } from './components/update-author/update-author.component';
import { NewAuthorComponent } from './components/new-author/new-author.component';
import { ShowAuthorComponent } from './components/show-author/show-author.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    BooksComponent,
    DeleteBookComponent,
    NewBookComponent,
    ShowBookComponent,
    UpdateBookComponent,
    CategoriesComponent,
    DeleteCategoryComponent,
    UpdateCategoryComponent,
    ShowCategoryComponent,
    NewCategoryComponent,
    AuthorsComponent,
    DeleteAuthorComponent,
    UpdateAuthorComponent,
    NewAuthorComponent,
    ShowAuthorComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'books', component: BooksComponent, canActivate : [AuthGuard]},
      { path: 'new-book', component: NewBookComponent},
      { path: 'update-book/:id', component: UpdateBookComponent},
      { path: 'delete-book/:id', component: DeleteBookComponent},
      { path: 'show-book/:id', component: ShowBookComponent},
      { path: 'categories', component: CategoriesComponent},
      { path: 'new-category', component: NewCategoryComponent},
      { path: 'update-category/:id', component: UpdateCategoryComponent},
      { path: 'delete-category/:id', component: DeleteCategoryComponent},
      { path: 'show-category/:id', component: ShowCategoryComponent},
      { path: 'authors', component: AuthorsComponent},
      { path: 'new-author', component: NewAuthorComponent},
      { path: 'update-author/:id', component: UpdateAuthorComponent},
      { path: 'delete-author/:id', component: DeleteAuthorComponent},
      { path: 'show-author/:id', component: ShowAuthorComponent},
    ])
  ],
  providers: [BookService, AuthorService, CategoryService, AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
