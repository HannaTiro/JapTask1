import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { AppUser } from '../_models/appUser';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl=environment.apiUrl;

  constructor(private http:HttpClient) { }

/*    login()
   {
this.http.get<AppUser>


   } */
}
