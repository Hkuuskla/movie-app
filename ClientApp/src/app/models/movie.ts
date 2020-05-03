import {Category} from "./category";

export interface Movie {
  movieId: number;
  title: string;
  category: Category;
  year: number;
  rating: number;
  description: string;
}
