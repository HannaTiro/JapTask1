import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Cook book';
  categories:any;

 constructor(private http:HttpClient)
 {

 }
  ngOnInit() {
this.http.get('https://localhost:5001/api/Category').subscribe(response=>{
  this.categories=response;
},error=>{
  console.log(error);
})
  }
}
