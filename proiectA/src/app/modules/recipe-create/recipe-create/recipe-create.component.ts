import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router }from '@angular/router';
import { RecipesSearchService } from 'src/app/services/recipes-search.service';
@Component({
  selector: 'app-recipe-create',
  templateUrl: './recipe-create.component.html',
  styleUrls: ['scss/animate.scss', 'scss/main.scss']
})
export class RecipeCreateComponent implements OnInit {

  constructor(
    private router: Router,
    private recipeService: RecipesSearchService,
  ) { }

  ngOnInit(): void {
  }

  public createForm: FormGroup = new FormGroup({
    recipe_name: new FormControl(''),
    recipe_description: new FormControl('')
  });

  public logout(): void{
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

}
