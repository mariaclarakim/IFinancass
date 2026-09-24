using IFinancas.Models;

namespace c_financas_pwii.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario? ObterPorEmail(string email);
        void Adicionar(Usuario usuario);
        void SalvarAlteracoes();
    }
}