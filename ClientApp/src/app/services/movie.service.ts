import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import { catchError, map, tap } from "rxjs/operators";
import {Observable} from "rxjs";
import {Movie} from "../models/movie";


@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private moviesUrl = 'api/movies';
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json'})
  };

  constructor(
    private http: HttpClient) { }

  getMovies() {
    return this.http.get<Movie[]>(this.moviesUrl);
  }
  /*
  getMoviesById(id: number) {
    const url = `${this.moviesUrl}/?id=${id}`;
    return this.http.get(url)
      .pipe(
        map(movies => movies[0]),
        tap(h => {
          const outcome = h ? `fetched` : `did not find`;
          this.log(`${outcome} hero id=${id}`);
        })
      )
    return this.http.get('api/movies/id')

  }*/
}
