import {Component, OnInit} from '@angular/core';
import {MovieService} from "../services/movie.service";
import {Observable, Subject} from "rxjs";
import {Movie} from "../models/movie";
import {debounceTime, distinctUntilChanged, switchMap, tap} from "rxjs/operators";

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html'
})

export class MovieListComponent implements OnInit {
  selectedMovie: Movie;
  private movies$ = new Subject<Movie[]>();
  private searchQuery = new Subject<string>();

  constructor(private movieService: MovieService) {
  }

  search(query: string): void {
    this.searchQuery.next(query);
  }

  onSelect(movie: Movie): void {
    this.selectedMovie = movie;
  }

  ngOnInit(): void {
    this.searchQuery.pipe(
      // wait 300ms after each keystroke before considering the term
      debounceTime(300),

      // ignore new term if same as previous term
      distinctUntilChanged(),

      // switch to new search observable each time the term changes
      switchMap((query: string) => this.movieService.getMovies(query)),

      tap((movieList) => this.movies$.next(movieList))
    );
  }

}

