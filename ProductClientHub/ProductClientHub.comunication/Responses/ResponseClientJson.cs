namespace ProductClientHub.Communication.Responses;

// O RESPONSE (Resposta) é o pacote de dados que a API DEVOLVE para o usuário.
// Ele é criado no UseCase e devolvido pelo Controller.
public class ResponseClientJson
{
    // O ID único do cliente criado.
    public Guid Id { get; set; }

    // O Nome do cliente que foi processado.
    public string Name { get; set; } = string.Empty;
}

