using Microsoft.AspNetCore.Mvc;

namespace ProductClientHub.Api.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ClientsController : ControllerBase

{

	[HttpPost]

	public IActionResult Register([FromBody]RequestClientJson request)
	{		

		
		return Ok();
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