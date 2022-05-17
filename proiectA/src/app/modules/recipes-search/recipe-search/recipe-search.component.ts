import { Component, OnInit, ViewChild } from '@angular/core';
import { Router }from '@angular/router';
import { RecipesSearchService } from 'src/app/services/recipes-search.service';
import { AbstractControl, AbstractFormGroupDirective, FormControl, FormGroup } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
@Component({
  selector: 'app-recipe-search',
  templateUrl: './recipe-search.component.html',
  styleUrls: ['scss/animate.scss', 'scss/main.scss']
})

export class RecipeSearchComponent implements OnInit {

  public displayedColumns_recipe = ['name', 'recipeFinal', 'creationDate', 'idUser'];
  public id = localStorage.getItem('link_id')||'1'
  

  constructor(
    private router: Router,
    private recipeService: RecipesSearchService,
  ) { }

  dataSource = new MatTableDataSource<Element>(ELEMENT_DATA);

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;

  /**
   * Set the paginator after the view init since this component will
   * be able to query its view for the initialized paginator.
   */
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }
  ngOnInit() {
    this.recipeService.GetAllRecipes().subscribe(
      (result) => {
        this.dataSource.data = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  public search(): void{
    console.log(this.searchForm.value.recipe_name);
    this.recipeService.GetAllRecipesByName(this.searchForm.value.recipe_name).subscribe(
      (result) => {
        this.dataSource.data = result;
      },
      (error) => {
        console.error(error);
      }
    );

  }

  public searchForm: FormGroup = new FormGroup({
    recipe_name: new FormControl(''),
  });

  get recipe_name(){
    return this.searchForm.get('recipe_name');
  }

  public logout(): void{
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }
  public save(id:string): void{
    localStorage.setItem('link_id',id);
  }

}

export interface Element {
  name: string;
  recipeFinal: string;
  creationDate: number;
  idUser: number;
}

const ELEMENT_DATA: Element[] = [];

