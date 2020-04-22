import {Component} from '@angular/core';
import {MovieService} from "../services/movie.service";
import {Observable} from "rxjs";
import {Movie} from "../models/movie";

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html'
})

export class MovieListComponent {
  private movies$: Observable<Movie[]>;

  constructor(private movieService: MovieService) {
    this.movies$ = this.movieService.getMovies();
  }

}

