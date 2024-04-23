using System.Text.Json.Serialization;
using Fornax.Domain.Validation;

namespace Fornax.Domain.Entities;

public sealed class User : EntityBase
{
    public string NomeCompleto { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public bool? Ativo { get; set; } = false;

    public User()
    {

    }

    public User(string nomeCompleto, string email, bool? ativo)
    {
        ValidateDomain(nomeCompleto, email, ativo);
    }

    [JsonConstructor]
    public User(int id, string nomeCompleto, string email, bool? ativo)
    {
        DomainValidation.Validate(id < 0, "Id inválido.");
        Id = id;
        ValidateDomain(nomeCompleto, email, ativo);
    }

    private void ValidateDomain(string nomeCompleto, string email, bool? ativo)
    {
        DomainValidation.Validate(string.IsNullOrEmpty(nomeCompleto), "Nome é um campo obrigatório.");
        DomainValidation.Validate(nomeCompleto.Length < 5, "Nome deve conter pelo menos 5 caracteres.");
        DomainValidation.Validate(nomeCompleto.Length > 150, "Nome deve conter no máximo 150 caracteres.");

        DomainValidation.Validate(string.IsNullOrEmpty(email), "E-mail é um campo obrigatório.");
        DomainValidation.Validate(email.Length < 10, "E-mail deve conter pelo menos 10 caracteres.");
        DomainValidation.Validate(email.Length > 100, "E-mail deve conter no máximo 100 caracteres.");

        NomeCompleto = nomeCompleto;
        Email = email;
        Ativo = ativo;
    }
}

