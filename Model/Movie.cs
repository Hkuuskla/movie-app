namespace movie_app.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        
        //public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}