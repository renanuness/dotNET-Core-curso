using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using AspNetCoreIdentity.Extensions;
using KissLog;

namespace AspNetCoreIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.Trace("Usuário acessou a home");

            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            throw new Exception("Erro");
            return View();
        }

        [Authorize(Roles = "Admin, Gestor")]
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "PodeExcluir")]
        public IActionResult SecretClaim()
        {
            return View("Secret");
        }

        [Authorize(Policy = "PodeGravar")]
        public IActionResult SecretClaimGravar()
        {
            return View("Secret");
        }

        [ClaimsAuthorize("Produtos","Ler")]
        public IActionResult ClaimsCustom()
        {
            return View("Secret");
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if(id == 500 )
            {
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.ErrorCode = id;
            }
            else if(id == 404 )
            {
                modelErro.Mensagem = "A página que está procurando não existe!<br/>Em caso de dúvidas entre emcontato com nosso suporte";
                modelErro.Titulo = "Ops! Página não encontrada.";
                modelErro.ErrorCode = id;
            }
            else if(id == 403 )
            {
                modelErro.Mensagem = "Você não tem permissão para fazer isso.";
                modelErro.Titulo = "Acesso Negado.";
                modelErro.ErrorCode = id;
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelErro);
        }
    }
}
