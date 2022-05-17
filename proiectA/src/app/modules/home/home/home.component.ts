import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router }from '@angular/router';
import { Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit, OnDestroy{

  public subscription: Subscription = new Subscription;
  public loggedUser: { username: string; password: string; } | undefined;

  constructor(
    private router: Router,
    private dataService: DataService,
  ) { }

  ngOnInit(): void {
    this.subscription = this.dataService.currentUser.subscribe(user => this.loggedUser = user);
  }
  ngOnDestroy(): void {
      this.subscription.unsubscribe();
  }

  public logout(): void{
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

}
