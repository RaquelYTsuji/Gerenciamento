namespace Aula29MVCDB.Models;

public class Pedido
{
    public int PedidoId { get; set; }
    public int EmpregadoId { get; set; }
    public string DataPedido { get; set; }
    public string Peso { get; set; }
    public int CodTransportadora { get; set; }
    public int PedidoClienteId { get; set; }

    public Pedido() { }

    public Pedido(int pedidoId, int empregadoId, string dataPedido, string peso, int codTransportadora, int pedidoClienteId)
    {
        PedidoId = pedidoId;
        EmpregadoId = empregadoId;
        DataPedido = dataPedido;
        Peso = peso;
        CodTransportadora = codTransportadora;
        PedidoClienteId = pedidoClienteId;
    }
}