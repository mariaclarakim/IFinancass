namespace IFinancas.Models;

public class Conta
{
    public int Id  { get; set;}
    public string Nome  { get; set;} = string.Empty;
    public decimal SaldoInicial { get; set;}
    public string Tipo  { get; set;} = string.Empty;
    public int IdUsuario  { get; set;}
    public Usuario Usuario  { get; set;} = null!;
    public ICollection<Lancamento> Lancamentos  { get; set;} = new List<Lancamento>();

}