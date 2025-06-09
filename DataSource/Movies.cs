using System.Text.Json;
using sc_linq.Models;

namespace sc_linq.DataSource;

public class Movies
{
    public static List<Movie> GetMovies() => JsonSerializer.Deserialize<List<Movie>>(File.ReadAllText(Path.Combine("DataSource", "movies_ugly.json")))!;

    public static List<Actor> GetActors()
    {
        List<Actor> retVal = new List<Actor>();
        foreach (var movie in GetMovies()!)
        {
            foreach (var a in movie.Full.ActorList)
            {
                if (!retVal.Any(x => x.Id == a.Id))
                {
                    retVal.Add(new Actor() { Id = a.Id, Name = a.Name });
                }
            }
        }

        return retVal;
    }

    public static List<Director> GetDirectors()
    {
        List<Director> retVal = new List<Director>();
        foreach (var movie in GetMovies()!)
        {
            foreach (var a in movie.Full.DirectorList)
            {
                if (!retVal.Any(x => x.Id == a.Id))
                {
                    retVal.Add(new Director() { Id = a.Id, Name = a.Name });
                }
            }
        }

        return retVal;
    }
}