using RubilsoAPI.Modelos.PlaceDetails;

namespace RubilsoAPI.Modelos;

public class TextSearchResult
{
    public List<object> html_attributions { get; set; }
    public string next_page_token { get; set; }
    public List<ResultDetails> results { get; set; }
    public string status { get; set; }
}