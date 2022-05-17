import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RecipesSearchRoutingModule } from './recipes-search-routing.module';
import { RecipeSearchComponent } from './recipe-search/recipe-search.component';
import { MatTable } from '@angular/material/table';
import { MaterialModule } from '../material/material.module';
import { MatPaginator } from '@angular/material/paginator';

@NgModule({
  declarations: [
    RecipeSearchComponent
  ],
  imports: [
    CommonModule,
    RecipesSearchRoutingModule,
    MaterialModule,
  ]
})
export class RecipesSearchModule { }
