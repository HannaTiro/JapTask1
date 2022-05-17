import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model:any={};
  constructor() { }

  ngOnInit(): void {
    
  }
  /*   login(){
    this.accountService.login(this.model).subscribe(response=>{
      this.router.navigateByUrl('/members');
      
    })
  } 

 logout()
  {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  
  } */
}
