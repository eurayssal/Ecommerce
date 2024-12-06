using System.ComponentModel;

namespace Ecommerce.Models;

public class Usuario(string nome, string email, string cpf, string telefone, string password, DateTime dataNascimento)
{
    #region Enums

    public enum EStatus
    {
        [Description("Ativo")]
        Pendente = 1,
        [Description("Inativo")]
        Inativo = 2,
    }

    #endregion

    #region Campos

    public EStatus Status { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string Cpf { get; set; } = cpf;
    public string Telefone { get; set; } = telefone;
    public string Password { get; set; } = password;
    public DateTime DataNascimento { get; set; } = dataNascimento;
    public bool IsAdmin { get; set; } = false;

    #endregion

    #region Métodos

    public void UpdateDados()
    {

    }

    public void UpdateStatus(EStatus status)
    {
        Status = status;
    }

    #endregion


}
