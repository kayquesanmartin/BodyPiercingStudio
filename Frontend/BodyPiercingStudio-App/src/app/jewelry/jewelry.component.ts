import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-jewelry',
  templateUrl: './jewelry.component.html',
  styleUrl: './jewelry.component.scss',
})
export class JewelryComponent implements OnInit {
  public jewelry: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getJewelry();
  }

  public getJewelry(): void {
    this.http.get('https://localhost:7008/api/jewelry').subscribe({
      next: (response) => {
        this.jewelry = response;
      },
      error: (error) => {
        console.error('Error fetching jewelry data:', error);
      },
    });
  }
}
