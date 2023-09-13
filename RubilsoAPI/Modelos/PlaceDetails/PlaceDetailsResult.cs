﻿namespace RubilsoAPI.Modelos.PlaceDetails;

public class PlaceDetailsResult
{
    public List<AddressComponent> address_components { get; set; }
    public string adr_address { get; set; }
    public string business_status { get; set; }
    public CurrentOpeningHours current_opening_hours { get; set; }
    public bool delivery { get; set; }
    public bool dine_in { get; set; }
    public EditorialSummary editorial_summary { get; set; }
    public string formatted_address { get; set; }
    public string formatted_phone_number { get; set; }
    public Geometry geometry { get; set; }
    public string icon { get; set; }
    public string icon_background_color { get; set; }
    public string icon_mask_base_uri { get; set; }
    public string international_phone_number { get; set; }
    public string name { get; set; }
    public OpeningHours opening_hours { get; set; }
    public List<Photo> photos { get; set; }
    public string place_id { get; set; }
    public PlusCode plus_code { get; set; }
    public int price_level { get; set; }
    public double rating { get; set; }
    public string reference { get; set; }
    public bool reservable { get; set; }
    public List<Review> reviews { get; set; }
    public bool serves_beer { get; set; }
    public bool serves_breakfast { get; set; }
    public bool serves_brunch { get; set; }
    public bool serves_dinner { get; set; }
    public bool serves_lunch { get; set; }
    public bool serves_vegetarian_food { get; set; }
    public bool serves_wine { get; set; }
    public bool takeout { get; set; }
    public List<string> types { get; set; }
    public string url { get; set; }
    public int user_ratings_total { get; set; }
    public int utc_offset { get; set; }
    public string vicinity { get; set; }
    public string website { get; set; }
    public bool wheelchair_accessible_entrance { get; set; }
}