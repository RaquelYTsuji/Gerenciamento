namespace Aula29MVCDB.Models;

public class Cliente
{
    public int ClienteId { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Regiao { get; set; }
    public string CodigoPostal { get; set; }
    public string Pais { get; set; }
    public string Telefone { get; set; }

    public Cliente() { }

    public Cliente(int clienteId, string endereco, string cidade, string regiao, string codigoPostal, string pais, string telefone)
    {
        ClienteId = clienteId;
        Endereco = endereco;
        Cidade = cidade;
        Regiao = regiao;
        CodigoPostal = codigoPostal;
        Pais = pais;
        Telefone = telefone;
    }
}