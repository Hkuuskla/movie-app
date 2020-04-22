import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import {MovieService} from "./services/movie.service";
import { MovieDetailComponent } from './movie-detail/movie-detail.component';
import {MovieListComponent} from "./movie-list/movie-list.component";

@NgModule({
  declarations: [
    AppComponent,
    MovieListComponent,
    MovieDetailComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: MovieListComponent },
    ])
  ],
  providers: [MovieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
