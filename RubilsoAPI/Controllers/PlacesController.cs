using System.Text.Json.Nodes;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RubilsoAPI.Modelos;
using RubilsoAPI.Modelos.Detalhes;
using RubilsoAPI.Modelos.PlaceDetails;


namespace RubilsoAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class PlacesController : ControllerBase
{
    [HttpGet]
    [Route("GetPlacesInfoFromSearch")]
    public async Task<List<DetalhesEstabelecimento>> Get(string searchParams,string pagina)
    {

        var detalhesEstabelecimentos = new List<DetalhesEstabelecimento>();
        
        var treatedSearchParams = searchParams.Replace(" ", "%");
        var apiKey = "AIzaSyBLuSzMUrqPRxNMh4w4QBKxjLUab1EfZiQ";
        var urlTextSearch = $"https://maps.googleapis.com/maps/api/place/textsearch/json?query={treatedSearchParams}?pagetoken={pagina}&key={apiKey}";
     
        var cliente = new HttpClient();
        var responseTextSerach = await cliente.GetAsync(urlTextSearch);
        var responseContentString = await  responseTextSerach.Content.ReadAsStringAsync();
        var textSearchResult = JsonSerializer.Deserialize<TextSearchResult>(responseContentString);
        if (textSearchResult is null) return new List<DetalhesEstabelecimento>();
        
        foreach (var result in textSearchResult.results)
        {
            var urlPlaceDetails =$"https://maps.googleapis.com/maps/api/place/details/json?place_id={result.place_id}&key={apiKey}";
            var resultPlaceDetails = await cliente.GetAsync(urlPlaceDetails);
            var teste = await resultPlaceDetails.Content.ReadAsStringAsync();
            var textPlaceDetailsResult = JsonSerializer.Deserialize<PlaceDetailsResponse>(teste);
            detalhesEstabelecimentos.Add( new DetalhesEstabelecimento
            {
                telefoneContato = textPlaceDetailsResult.result.formatted_phone_number,
                site = textPlaceDetailsResult.result.website,
                endereco = textPlaceDetailsResult.result.formatted_address,
                nome = textPlaceDetailsResult.result.name
            });
        }

        return detalhesEstabelecimentos;
        
    }


    
}