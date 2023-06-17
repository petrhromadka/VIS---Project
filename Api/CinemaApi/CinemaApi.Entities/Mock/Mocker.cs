using System;
using System.Collections.ObjectModel;
using System.Globalization;
using CinemaApi.Entities.Entities;
using CinemaApi.Entities.Enums;

namespace CinemaApi.Entities.Mock
{
    public class Mocker
    {
        public static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new()
                {
                    Title = "ANT-MAN A WASP: QUANTUMANIA",
                    Rating = 12,
                    Genre = Genre.Action,
                    Duration = 125,
                    Director = "Peyton Reed",
                    Thumbnail = "https://image.pmgstatic.com/cache/resized/w1989/files/images/film/posters/167/104/167104672_124085.jpg",
                    Description = "Scott Lang (Paul Rudd) a Hope Van Dyne (Evangeline Lilly) spolu s Hankem Pymem (Michael Douglas) a Janet Van Dyne (Michelle Pfeiffer) prozkoumávají Quantum Realm, kde interagují s podivnými tvory a vydávají se na dobrodružství, které přesahuje hranice toho, co považovali za možné.",
                    Events = new List<Event>
                    {
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 13, 14, 20, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 13, 17, 10, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 13, 20, 30, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 14, 14, 20, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 14, 17, 10, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 14, 20, 30, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 15, 14, 20, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 15, 17, 10, 0)),
                        new(new Hall("Sál 01") {Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 15, 21, 40, 0))
                    }
                },
                new()
                {
                    Title = "ASTERIX A OBELIX: ŘÍŠE STŘEDU",
                    Rating = 0,
                    Genre = Genre.Comedy,
                    Duration = 114,
                    Director = "Guillaume Canet",
                    Thumbnail = "https://image.pmgstatic.com/cache/resized/w663/files/images/film/posters/166/707/166707979_0c329c.jpg",
                    Description = "Píše se rok 50 př. n. l. Za devatero horami a devatero řekami… Tedy velmi, velmi daleko od malé galské vesnice, kterou tak dobře známe, leží země zvaná Čína. Zde proradný generál, bažící po moci, právě zajal a uvěznil čínskou císařovnu. A protože věhlas nepřemožitelných Galů překvapivě sahá až do Asie, princezna Fu Yi neomylně ví, na koho se obrátit. Se svou věrnou strážkyní Na Ban Čim a synovcem fénického kupce Popkornise prchá ze země. Samozřejmě požádá o pomoc ty nejlepší z nejlepších, udatné válečníky, Asterixe a Obelixe. Naši dva nerozluční hrdinové se s princeznou vydávají na dobrodružnou výpravu za záchranou císařovny i celé Číny…",
                    Events = new List<Event>()
                    {
                        new(new Hall("Sál 02") {Seats = GetSeatingPlan()}, 160, new DateTime(2023, 3, 13, 15, 10, 0)),
                        new(new Hall("Sál 02") {Seats = GetSeatingPlan()}, 160, new DateTime(2023, 3, 14, 15, 10, 0)),
                        new(new Hall("Sál 02") {Seats = GetSeatingPlan()}, 160, new DateTime(2023, 3, 15, 15, 10, 0)),
                    }
                    
                },
                new()
                {
                    Title = "John Wick: Kapitola 4",
                    Rating = 15,
                    Genre = Genre.Action,
                    Duration = 169,
                    Director = "Chad Stahelski",
                    Thumbnail = "https://image.pmgstatic.com/cache/resized/w663/files/images/film/posters/167/176/167176646_25e339.jpg",
                    Description = "John Wick (Keanu Reeves) odhalí cestu, jak porazit Nejvyšší radu. Než se mu však podaří získat svobodu, musí čelit novému nepříteli, který má mocné spojence po celém světě. Bude to o to težší, že nová spojenectví mění staré přátele v nepřátele...",
                    Events = new List<Event>()
                    {
                        new(new Hall("Sál 01"){Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 16, 15, 0, 0)),
                        new(new Hall("Sál 01"){Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 17, 15, 0, 0)),
                        new(new Hall("Sál 01"){Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 18, 17, 0, 0)),
                        new(new Hall("Sál 01"){Seats = GetSeatingPlan()}, 180, new DateTime(2023, 3, 19, 20, 0, 0)),
                    }
                },

                new()
                {
                    Title = "Buď chlap!",
                    Rating = 0,
                    Genre = Genre.Romance,
                    Duration = 96,
                    Director = "Michal Samir",
                    Thumbnail = "https://image.pmgstatic.com/cache/resized/w663/files/images/film/posters/167/079/167079369_57f236.jpg",
                    Description = "Pavlovi (Jakub Prachař) sice táhne na čtyřicet, ale stále ještě úplně nedospěl. Bydlí s mámou a chybí mu odvaha dělat v životě to, co by ho skutečně naplňovalo. Tu získá až ve chvíli, kdy potká svou dětskou lásku Terezu (Tereza Ramba) a prožije s ní dobrodružnou noc. Tereza však není připravena opustit svůj dosavadní život pro někoho, kdo podle ní není opravdový chlap. Pavel se tedy rozhodne se přesně takovým chlapem stát. Přihlásí se na výcvikový tábor v Tatrách vedený Weisnerem (Ondřej Sokol), který vyučuje vše od sekání dříví po svádění žen. Podaří se Pavlovi překonat sama sebe a stát se chlapem, po kterém Tereza touží?",
                    Events = new List<Event>()
                    {
                        new(new Hall("Sál 02") { Seats = GetSeatingPlan() }, 180, new DateTime(2023, 3, 16, 18, 0, 0)),
                        new(new Hall("Sál 02") { Seats = GetSeatingPlan() }, 180, new DateTime(2023, 3, 17, 18, 0, 0)),
                        new(new Hall("Sál 02") { Seats = GetSeatingPlan() }, 180, new DateTime(2023, 3, 18, 20, 0, 0)),
                        new(new Hall("Sál 02"), 180, new DateTime(2023, 3, 19, 18, 0, 0)),
                        new(new Hall("Sál 02") { Seats = GetSeatingPlan() }, 180, new DateTime(2023, 3, 20, 16, 0, 0)),
                    }
                }
            };
        }

        public static ICollection<Seat> GetSeatingPlan()
        {
            return new Collection<Seat>()
            {
                new(){Row = 1,SeatNumber = 1},
                new(){Row = 1,SeatNumber = 2},
                new(){Row = 1,SeatNumber = 3},
                new(){Row = 1,SeatNumber = 4},
                new(){Row = 1,SeatNumber = 5},
                new(){Row = 1,SeatNumber = 6},
                new(){Row = 1,SeatNumber = 7},
                new(){Row = 1,SeatNumber = 8},
                new(){Row = 1,SeatNumber = 9},
                new(){Row = 1,SeatNumber = 1},
                new(){Row = 2,SeatNumber = 1},
                new(){Row = 2,SeatNumber = 2},
                new(){Row = 2,SeatNumber = 3},
                new(){Row = 2,SeatNumber = 4},
                new(){Row = 2,SeatNumber = 5},
                new(){Row = 2,SeatNumber = 6},
                new(){Row = 2,SeatNumber = 7},
                new(){Row = 2,SeatNumber = 8},
                new(){Row = 2,SeatNumber = 9},
                new(){Row = 2,SeatNumber = 10},
                new(){Row = 3,SeatNumber = 1},
                new(){Row = 3,SeatNumber = 2},
                new(){Row = 3,SeatNumber = 3},
                new(){Row = 3,SeatNumber = 4},
                new(){Row = 3,SeatNumber = 5},
                new(){Row = 3,SeatNumber = 6},
                new(){Row = 3,SeatNumber = 7},
                new(){Row = 3,SeatNumber = 8},
                new(){Row = 3,SeatNumber = 9},
                new(){Row = 3,SeatNumber = 10},
                new(){Row = 4,SeatNumber = 1 },
                new(){Row = 4,SeatNumber = 2},
                new(){Row = 4,SeatNumber = 3},
                new(){Row = 4,SeatNumber = 4},
                new(){Row = 4,SeatNumber = 5},
                new(){Row = 4,SeatNumber = 6},
                new(){Row = 4,SeatNumber = 7},
                new(){Row = 4,SeatNumber = 8},
                new(){Row = 4,SeatNumber = 9},
                new(){Row = 4,SeatNumber = 10},
                new(){Row = 5,SeatNumber = 1},
                new(){Row = 5,SeatNumber = 2},
                new(){Row = 5,SeatNumber = 3},
                new(){Row = 5,SeatNumber = 4},
                new(){Row = 5,SeatNumber = 5},
                new(){Row = 5,SeatNumber = 6},
                new(){Row = 5,SeatNumber = 7},
                new(){Row = 5,SeatNumber = 8},
                new(){Row = 5,SeatNumber = 9},
                new(){Row = 5,SeatNumber = 10},
                new(){Row = 6,SeatNumber = 1},
                new(){Row = 6,SeatNumber = 2},
                new(){Row = 6,SeatNumber = 3},
                new(){Row = 6,SeatNumber = 4},
                new(){Row = 6,SeatNumber = 5},
                new(){Row = 6,SeatNumber = 6},
                new(){Row = 6,SeatNumber = 7},
                new(){Row = 6,SeatNumber = 8},
                new(){Row = 6,SeatNumber = 9},
                new(){Row = 6,SeatNumber = 10},
                new(){Row = 7,SeatNumber = 1},
                new(){Row = 7,SeatNumber = 2},
                new(){Row = 7,SeatNumber = 3},
                new(){Row = 7,SeatNumber = 4},
                new(){Row = 7,SeatNumber = 5},
                new(){Row = 7,SeatNumber = 6},
                new(){Row = 7,SeatNumber = 7},
                new(){Row = 7,SeatNumber = 8},
                new(){Row = 7,SeatNumber = 9} ,
                new(){Row = 7,SeatNumber = 1},
                new(){Row = 8,SeatNumber = 1},
                new(){Row = 8,SeatNumber = 2},
                new(){Row = 8,SeatNumber = 3},
                new(){Row = 8,SeatNumber = 4},
                new(){Row = 8,SeatNumber = 5},
                new(){Row = 8,SeatNumber = 6},
                new(){Row = 8,SeatNumber = 7},
                new(){Row = 8,SeatNumber = 8},
                new(){Row = 8,SeatNumber = 9 },
                new(){Row = 8,SeatNumber = 10},
                new(){Row = 9,SeatNumber = 1},
                new(){Row = 9,SeatNumber = 2},
                new(){Row = 9,SeatNumber = 3},
                new(){Row = 9,SeatNumber = 4},
                new(){Row = 9,SeatNumber = 5},
                new(){Row = 9,SeatNumber = 6},
                new(){Row = 9,SeatNumber = 7},
                new(){Row = 9,SeatNumber = 8},
                new(){Row = 9,SeatNumber = 9 },
                new(){Row = 9,SeatNumber = 10},
                new(){Row = 10, SeatNumber = 1},
                new(){Row = 10, SeatNumber = 2},
                new(){Row = 10, SeatNumber = 3},
                new(){Row = 10, SeatNumber = 4},
                new(){Row = 10, SeatNumber = 5},
                new(){Row = 10, SeatNumber = 6},
                new(){Row = 10, SeatNumber = 7},
                new(){Row = 10, SeatNumber = 8},
                new(){Row = 10, SeatNumber = 9 },
                new(){Row = 10, SeatNumber = 10}
            };

        }
    }
}
