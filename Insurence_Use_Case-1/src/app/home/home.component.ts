import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public image1="/assets/images/card1.jpg"
  public register="assets/images/register.jpg";
  constructor() { }

  ngOnInit(): void {
  }

}
