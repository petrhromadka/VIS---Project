using CinemaApi.Entities.Enums;
// ReSharper disable CommentTypo

namespace CinemaApi.Entities.Entities
{
    /*
     *  Id - Identifikátor filmu
     *  Title - Název filmu
     *  Genre - Žánr filmu
     *  Duration - Doba trvání filmu
     *  Director - Režiser filmu
     *  Actors - Jména herců
     *  Description - Popis filmu
     *  Rating - Věková přístupnost (minimální povolený věk pro sledování filmu)
     */

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? Rating { get; set; }
    }
}
