using ProductClientHub.Communication.Responses;

namespace ProductClientHub.Api.UseCases.Clients.Register;

// O USE CASE (Caso de Uso) representa uma ação específica do sistema (ex: Registrar Cliente).
// Ele é puxado (instanciado) pelo Controller.
public class RegisterClientUseCase
{
    // O método Execute é onde a ação acontece de fato.
    public ResponseClientJson Execute(RequestClientJson request)
    {
        // 1. Ele puxa o VALIDATOR para conferir se os dados que o usuário enviou estão corretos.
        var validator = new RegisterClientValidator();

        // 2. Aqui ele executa a validação usando os dados do 'request' (que vieram do Controller).
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            throw new ArgumentException("Dados inválidos");
        }

        // Se a validação não for válida (result.IsValid == false), você trataria isso aqui.

        // Por enquanto, ele apenas retorna um objeto de resposta vazio.
        return new ResponseClientJson();
    }
}

