using System.ComponentModel;

namespace IFinancas.Models;

public class Lancamento
{
    public int Id { get; set;}
    public string Descricao { get; set;} = string.Empty;
    public decimal Valor { get; set;}
    public DateTime DataVencimento { get; set;}
    public DateTime? DataPagamento { get; set;}
    public string Status { get; set;} = string.Empty;

    public int CategoriaId { get; set;} 
    public Categoria Categoria { get; set;} = null!;
    public int ContaId { get; set;}
    public Conta Conta  { get; set;} = null!;


    public int UsuarioId  { get; set;}
    public Usuario Usuario  { get; set;} = null!;


}