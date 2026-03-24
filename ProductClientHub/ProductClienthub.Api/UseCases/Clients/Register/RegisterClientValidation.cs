using FluentValidation;

namespace ProductClientHub.Api.UseCases.Clients.Register;

// O VALIDATOR (Validador) define as REGRAS para os dados que chegam na API.
// Ele é puxado (instanciado) pelo UseCase.
public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
    // O Construtor é onde definimos as regras. 
    // "RuleFor" significa "Regra para o campo..."
    public RegisterClientValidator()
    {
        // Verifica se o Nome não está vazio, se estiver, manda a mensagem.
        RuleFor(client => client.Name)
            .NotEmpty()
            .WithMessage("Nome Vazio");  

        // Verifica se o Email não está vazio.
        RuleFor(client => client.Email)
            .NotEmpty()
            .WithMessage("Email Vazio");       
    }    
}