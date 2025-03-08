using System;

namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            public string title;
            public string certificate;
            public int year;
            public bool beingShown;

            public Film(string title, string certificate, int year, bool beingShown)
            {
                this.title = title;
                this.certificate = certificate;
                this.year = year;
                this.beingShown = beingShown;
            }
        }

        static void Main(string[] args)
        {
            Film hulk = new Film("Hulk", "12A", 2005, false);
            Film ironMan = new Film("Iron Man", "12A", 2008, false);
            Film antMan = new Film("Ant-Man", "12A", 2015, false);
            Film[] filmCollection = new Film[] { hulk, ironMan, antMan };
            Film newestFilm = filmCollection[0];

            foreach (Film film in filmCollection)
            {
                if (film.year > newestFilm.year)
                {
                    newestFilm = film;
                }
            }
            Console.WriteLine($"The newest film is: {newestFilm.title} ({newestFilm.year})");
            for (int i = 0; i < filmCollection.Length; i++)
            {
                if (filmCollection[i].title == "Ant-Man")
                {
                    filmCollection[i] = new Film(filmCollection[i].title, filmCollection[i].certificate, filmCollection[i].year, true);
                    break;
                }
            }
            foreach (Film film in filmCollection)
            {
                Console.WriteLine($"{film.title} is currently being shown: {film.beingShown}");
            }
        }
    }
}
