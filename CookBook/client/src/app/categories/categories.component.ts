import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {
  categories:any;
  constructor(private http:HttpClient)
 {

 }

  ngOnInit() {
   this.loadComponents();
      }
loadComponents()
{
  this.http.get('https://localhost:5001/api/Category').subscribe(response=>{
    this.categories=response;
  },error=>{
    console.log(error);
  })
}
}
