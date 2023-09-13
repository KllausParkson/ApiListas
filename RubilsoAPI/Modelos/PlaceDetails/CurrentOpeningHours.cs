namespace RubilsoAPI.Modelos.PlaceDetails;

public class CurrentOpeningHours
{
    public bool open_now { get; set; }
    public List<Period> periods { get; set; }
    public List<string> weekday_text { get; set; }
}