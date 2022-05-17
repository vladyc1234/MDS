import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';
import { Auth2Guard } from './auth2.guard';

const routes: Routes = [
  {
    path:'',
    canActivate: [AuthGuard],
    children: [
      {
        path:'',
        loadChildren: () => import('src/app/modules/home/home.module').then(a => a.HomeModule),
      },
      {
        path:'',
        loadChildren: () => import('src/app/modules/recipes-search/recipes-search.module').then(a => a.RecipesSearchModule),
      },
      {
        path:'',
        loadChildren: () => import('src/app/modules/recipe-template/recipe-template.module').then(a => a.RecipeTemplateModule),
      },
    ]
  },
  {
    path:'',
    canActivate: [Auth2Guard],
    children: [
    ]
  },
  {
    path:'login',
    loadChildren: () => import('src/app/modules/auth/auth.module').then(a => a.AuthModule),
  }

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
