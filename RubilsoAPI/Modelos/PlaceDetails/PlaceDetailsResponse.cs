namespace RubilsoAPI.Modelos.PlaceDetails;

public class PlaceDetailsResponse
{
    public List<object> html_attributions { get; set; }
    public  PlaceDetailsResult result{ get; set; }
    public string status { get; set; }
}