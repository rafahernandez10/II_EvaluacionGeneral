using Evaluacion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Evaluacion2.Data.Usuario;
namespace Evaluacion2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            var usuarios = _usuarioRepository.GetAll();
            return View(usuarios);
        }

        public IActionResult Details(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Add(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        public IActionResult Edit(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Update(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        public IActionResult Delete(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _usuarioRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
