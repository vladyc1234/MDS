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
  public url_utensil = 'https://localhost:44356/api/Utensil';
  public url_utensil_name = 'https://localhost:44356/api/Utensil';
  public url_ingredient = 'https://localhost:44356/api/Ingredient';
  public url_ingredient_name = 'https://localhost:44356/api/Ingredient';
  public url_tag = 'https://localhost:44356/api/Tag';
  public url_tag_name = 'https://localhost:44356/api/Tag';

  constructor(
    public http: HttpClient,
  ) { }
  

  //GET FUNCTIONS

  public GetAllRecipes(): Observable<any> {
    return this.http.get(`${this.url_recipe}`);
  }

  public GetRecipeById(id:string): Observable<any> {
    return this.http.get(`${this.url_recipe}/${id}`);
  }

  public GetAllRecipesByName(name:string): Observable<any> {
    return this.http.get(`${this.url_recipe}/${name}`);
  }

  public GetAllUtensils(): Observable<any> {
    return this.http.get(`${this.url_utensil}`);
  }

  public GetUtensilByName(name:string): Observable<any> {
    
    return this.http.get(`${this.url_utensil_name}/${name}`);
    
  }

  public GetAllIngredients(): Observable<any> {
    return this.http.get(`${this.url_ingredient}`);
  }

  public GetIngredientByName(name:string): Observable<any> {
    
    return this.http.get(`${this.url_ingredient_name}/${name}`);
    
  }

  public GetAllTags(): Observable<any> {
    return this.http.get(`${this.url_tag}`);
  }

  public GetTagByName(name:string): Observable<any> {
    
    return this.http.get(`${this.url_tag_name}/${name}`);
    
  }

  //POST FUNCTIONS

  public CreateRecipe(recipe: Recipe): Observable<any>{
    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(recipe);
    console.log(body)
    return this.http.post(this.url_recipe, body,{'headers':headers})
  }

  public CreateUtensil(utensil: Utensil): Observable<any>{
    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(utensil);
    console.log(body)
    return this.http.post(this.url_utensil, body,{'headers':headers})
  }

}

export class Recipe{
  name: string;
  recipeFinal: string;
  creationDate: Date;
  idUser: number;
  rating: number;

  constructor(name: string, recipeFinal: string, creationDate: Date, idUser: number){
    this.name = name;
    this.recipeFinal = recipeFinal;
    this.creationDate = creationDate;
    this.idUser = idUser;
    this.rating = 0;
  };

}

export class Utensil{
  name: string;
  description: string;

  constructor(name: string, description: string){
    this.name = name;
    this.description = description;
  };

}
