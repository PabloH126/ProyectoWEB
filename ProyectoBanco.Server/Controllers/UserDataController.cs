using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoBanco.Server.Data;
using ProyectoBanco.Server.Models;
namespace ProyectoBanco.Server.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class UserDataController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Usuario> Get()
    {
        var userDataJson = HttpContext.Session.GetString("Usuario");
        if (!string.IsNullOrEmpty(userDataJson))
        {
            var userData = JsonSerializer.Deserialize<Usuario>(userDataJson);
            return userData!;
        }
        else
        {
            return NotFound();
        }
    }
    }
}