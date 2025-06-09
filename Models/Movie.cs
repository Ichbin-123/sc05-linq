namespace sc_linq.Models;


public class Movie
{
    public IMDbApiLib.Models.Top250DataDetail Preview { get; set; } = new IMDbApiLib.Models.Top250DataDetail();
    public IMDbApiLib.Models.TitleData Full { get; set; } = new IMDbApiLib.Models.TitleData();

}