using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[ApiController]
[Route("api/emails")]
public class EmailController : ControllerBase
{
    private readonly List<string> _emailList = new List<string>();

    [HttpPost]
    [Route("register")]
    public IActionResult RegisterEmail([FromBody] string email)
    {
        if (string.IsNullOrEmpty(email) || !_IsValidEmail(email))
        {
            return BadRequest("E-mail inválido");
        }

        _emailList.Add(email);

      

        return Ok("E-mail registrado com sucesso");
    }

    private bool _IsValidEmail(string email)
    {
      
        return email.Contains("@");
    }
}
