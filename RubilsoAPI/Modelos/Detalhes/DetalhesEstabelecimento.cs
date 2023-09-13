namespace RubilsoAPI.Modelos.Detalhes;

public class DetalhesEstabelecimento
{
    public string nome { get; set; }
    public string endereco { get; set; }
    public string telefoneContato { get; set; }
    public string site { get; set; }
   
    public DetalhesEstabelecimento(string Endereco,string Telefone,string Site ,string Nome)
    {
        this.endereco = Endereco;
        this.site = Site;
        this.telefoneContato = Telefone;
        this.nome = Nome;
    }
    public DetalhesEstabelecimento()
    {
        // default constructor logic here
    }
    
}