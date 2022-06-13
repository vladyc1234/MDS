import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginRegisterService {


  public url_login = 'https://localhost:44356/api/Account/login'
  public url_register = 'https://localhost:44356/api/Account/register';

  constructor(
    public http: HttpClient,
  ) { }

  //POST FUNCTIONS

  public RegisterUser(register: Register): Observable<any>{
    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(register);
    console.log(body)
    return this.http.post(this.url_register, body,{'headers':headers})
  }

  public LoginUser(login: Login): Observable<any>{
    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(login);
    console.log(body)
    return this.http.post(this.url_login, body,{'headers':headers})
  }
}

export class Login{
  email: string;
  password: string;

  constructor(email: string, password: string){
    this.email = email;
    this.password = password;
  }
}

export class Register{
  creationDate: Date;
  name: string;
  username: string;
  email: string;
  password: string;

  constructor(name: string, username: string, email: string, password: string){
    this.creationDate = new Date();
    this.name = name;
    this.username = username;
    this.email = email;
    this.password = password;
  }
}
