import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from  '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class RecipesSearchService {

  public url_recipe = 'https://localhost:44356/api/Recipe';
  public url_recipe_id = 'https://localhost:44356/api/Recipe';
  public url_recipe_name = 'https://localhost:44356/api/Recipe'

  constructor(
    public http: HttpClient,
  ) { }

  public GetAllRecipes(): Observable<any> {
    return this.http.get(`${this.url_recipe}`);
  }

  public GetRecipeById(id:string): Observable<any> {
    return this.http.get(`${this.url_recipe}/${id}`);
  }

  public GetAllRecipesByName(name:string): Observable<any> {
    return this.http.get(`${this.url_recipe}/${name}`);
  }

}
