import { Component, OnInit } from '@angular/core';
import { SLA } from '../fetch-data/fetch-data.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public slas?: SLA
  constructor() { }

  ngOnInit(): void {
  }

}
