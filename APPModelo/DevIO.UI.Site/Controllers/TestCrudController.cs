using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DevIO.UI.Site.Controllers
{
    public class TestCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TestCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Renan",
                DataNascimento = DateTime.Now,
                Email = "renan@email.com.br"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);

            var aluno3 = _contexto.Alunos.FirstOrDefault(a=> a.Email == "renan@email.com.br");

            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}