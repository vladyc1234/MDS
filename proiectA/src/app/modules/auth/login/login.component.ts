import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup,  } from '@angular/forms';
import { Router }from '@angular/router';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  
  constructor(
    private router: Router,
    private dataService: DataService,
  ) { 
    
  }

  ngOnInit(): void {
  }

  public login(): void{
    console.log(this.loginForm.value.username);
    this.dataService.changeUserData(this.loginForm.value);
    if(this.loginForm.value.username == "Vlad" && this.loginForm.value.password == "1234")
    localStorage.setItem('Role', 'Admin');
    else
    localStorage.setItem('Role', 'User');
    this.router.navigate(['/home']);
  }

  public loginForm: FormGroup = new FormGroup({
    username: new FormControl(''),
    password: new FormControl(''),
  });

  get username(){
    return this.loginForm.get('username');
  }
  get password(){
    return this.loginForm.get('password');
  }

}
