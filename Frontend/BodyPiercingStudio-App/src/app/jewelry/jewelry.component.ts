import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-jewelry',
  templateUrl: './jewelry.component.html',
  styleUrl: './jewelry.component.scss',
})
export class JewelryComponent implements OnInit {
  public jewelry: any;
  public filteredJewelry: any;
  widthImg: number = 100;
  marginImg: number = 2;
  private _listFilter: string = '';

  public get listFilter(): string {
    return this._listFilter;
  }
  public set listFilter(value: string) {
    this._listFilter = value;
    this.filteredJewelry = this.listFilter
      ? this.filterJewelry(this.listFilter)
      : this.jewelry;
  }

  filterJewelry(filterBy: string): any {
    filterBy = filterBy.toLocaleLowerCase();
    return this.jewelry.filter(
      (jewelry: any) =>
        jewelry.name.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
        jewelry.material.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
        jewelry.bodyPart.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
        jewelry.category.toLocaleLowerCase().indexOf(filterBy) !== -1
    );
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getJewelry();
  }

  public getJewelry(): void {
    this.http.get('https://localhost:7008/api/jewelry').subscribe({
      next: (response) => {
        this.jewelry = response;
        this.filteredJewelry = this.jewelry;
      },
      error: (error) => {
        console.error('Error fetching jewelry data:', error);
      },
    });
  }
}
