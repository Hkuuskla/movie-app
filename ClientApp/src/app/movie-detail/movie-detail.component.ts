import {Component, Input} from '@angular/core';
import {Movie} from "../models/movie";
import {MovieService} from "../services/movie.service";
import {Observable} from "rxjs";

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.css']
})
export class MovieDetailComponent {
  private movie$: Observable<Movie>;

  constructor(private _movieService: MovieService) { }

  @Input() set movie(movie: Movie) {
    if(movie){
      this.movie$ = this._movieService.getMoviesById(movie.movieId);
    }
  }

}
