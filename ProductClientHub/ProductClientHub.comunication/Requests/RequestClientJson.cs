namespace ProductClientHub.Communication.Requests;

// O REQUEST (Requisição) é o pacote de dados que o usuário ENVIA para a API.
// Ele é recebido pelo Controller e passado para o UseCase e o Validator.
public class RequestClientJson
{
    // Propriedade para armazenar o nome que o usuário enviou.
    public string Name { get; set; } = string.Empty;

    // Propriedade para armazenar o email que o usuário enviou.
    public string Email { get; set; } = string.Empty;
}

