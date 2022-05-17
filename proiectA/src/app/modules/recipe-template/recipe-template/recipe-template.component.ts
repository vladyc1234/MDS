import { Component, OnInit, ViewChild } from '@angular/core';
import { Router }from '@angular/router';
import { RecipesSearchService } from 'src/app/services/recipes-search.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-recipe-template',
  templateUrl: './recipe-template.component.html',
  styleUrls: ['scss/animate.scss', 'scss/main.scss']
})

export class RecipeTemplateComponent implements OnInit{

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
  ngOnInit() {
    this.recipeService.GetRecipeById(this.id).subscribe(
      (result) => {
        this.dataSource.paginator = this.paginator;
        const data = this.dataSource.data;
        data.push(result);
        this.dataSource.data = data;
        data.pop();

      },
      (error) => {
        console.error(error);
      }
    );
  }

  


  public logout(): void{
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

  

}

export interface Element {
  name: string;
  recipeFinal: string;
  creationDate: number;
  idUser: number;
}

const ELEMENT_DATA: Element[] = [];

  
  



