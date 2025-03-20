using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            if (usuario != null && usuario.senha == senha)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email e senha inválidos.");

            return View();
        }
    }
}
