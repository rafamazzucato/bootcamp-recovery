using JWTTeste.Dto;
using JWTTeste.Models;
using JWTTeste.Services;
using JWTTeste.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly JWTTesteDbContext _context;

        public LoginController(JWTTesteDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginDto dto)
        {
            try 
            { 
                if(string.IsNullOrEmpty(dto.Login) || string.IsNullOrWhiteSpace(dto.Login)
                    || string.IsNullOrEmpty(dto.Senha) || string.IsNullOrWhiteSpace(dto.Senha))
                {
                    return BadRequest("Parametros de entrada invalidos");
                }

                var usuario = await _context.Usuario.FirstOrDefaultAsync(u => u.Email.ToLower() == dto.Login.Trim().ToLower()
                        || u.Senha == PasswordUtil.GeneratePassword(dto.Senha));

                if(usuario == null)
                {
                    return BadRequest("Parametros de entrada invalidos");
                }

                var token = TokenService.GenerateToken(usuario);
                return Ok(new {
                    Email = usuario.Email,
                    Token = token
                });
            }
            catch( Exception)
            {
                return BadRequest("Nao foi possivel autenticar, tente novamente");
            }
        }
    }
}
