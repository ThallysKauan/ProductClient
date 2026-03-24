// O CONTROLLER é a "porta de entrada" da sua API. 
// Ele recebe as requisições que vêm da internet (via Postman, navegador, etc).
using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.Api.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ClientsController : ControllerBase

{
    // Este método é chamado quando o usuário faz um POST para /api/Clients
    [HttpPost]
    [ProducesResponseType(typeof(ResponseClientJson), StatusCode.Status201Created)]
    public IActionResult Register([FromBody]RequestClientJson request)
    {		
        // Aqui o Controller "puxa" (instancia) a Regra de Negócio (UseCase).
        // Ele delega a responsabilidade de registrar o cliente para outra classe.
        var useCase = new UseCases.Clients.Register.RegisterClientUseCase();

        // Ele executa a lógica e recebe a resposta.
        var response = useCase.Execute(request);

        // Retorna o status 201 (Criado) para quem chamou a API.
        return Created(string.Empty, response);
    }

    [HttpPut]
    public IActionResult Update()
    {		
        return Ok();
    }

    [HttpGet]
    public IActionResult getAll()
    {		
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {		
        return Ok();
    }
}