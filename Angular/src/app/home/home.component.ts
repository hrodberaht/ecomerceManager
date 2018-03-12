import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  count = 1;
  constructor() { }

  ngOnInit() {
  }


  create() {
    this.count +=1;
    console.log(this.count);
  }

}
