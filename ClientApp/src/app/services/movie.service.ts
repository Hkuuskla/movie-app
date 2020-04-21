import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private http: HttpClient) { }

  getMovies() {
    return this.http.get('api/movies')
  }
  getMoviesById(id: number) {
    return this.http.get('api/movies/id')

  }
}
