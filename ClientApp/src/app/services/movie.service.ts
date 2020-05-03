import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import { catchError, map, tap } from "rxjs/operators";
import {Observable, of} from "rxjs";
import {Movie} from "../models/movie";


@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private moviesUrl = 'api/movies';
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json'})
  };

  constructor(private http: HttpClient) { }

  getMovies(query?: string) {
    let url;
    if (query) {
      url = `${this.moviesUrl}?query=${query}`;
    } else {
      url = this.moviesUrl;
    }

    return this.http.get<Movie[]>(url);
  }

  getMoviesByTitle(title: string) {
    const url = `${this.moviesUrl}/title/?title=${title}`;
    return this.http.get<Movie>(url);
  }

  getCategories(title:string){

  }


  getMoviesById(id: number) {
    const url = `${this.moviesUrl}/${id}`;
    return this.http.get<Movie>(url);
  }
}
