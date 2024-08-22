using Evaluacion2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Evaluacion2.Data.Rol;

namespace Evaluacion2.Controllers
{
    public class RolController : Controller
    {
        private readonly IRolRepository _rolRepository;

        public RolController(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public IActionResult Index()
        {
            var roles = _rolRepository.GetAll();
            return View(roles);
        }

        public IActionResult Details(int id)
        {
            var rol = _rolRepository.GetById(id);
            if (rol == null)
            {
                return NotFound();
            }
            return View(rol);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RolesModel rol)
        {
            if (ModelState.IsValid)
            {
                _rolRepository.Add(rol);
                return RedirectToAction(nameof(Index));
            }
            return View(rol);
        }

        public IActionResult Edit(int id)
        {
            var rol = _rolRepository.GetById(id);
            if (rol == null)
            {
                return NotFound();
            }
            return View(rol);
        }

        [HttpPost]
        public IActionResult Edit(RolesModel rol)
        {
            if (ModelState.IsValid)
            {
                _rolRepository.Update(rol);
                return RedirectToAction(nameof(Index));
            }
            return View(rol);
        }

        public IActionResult Delete(int id)
        {
            var rol = _rolRepository.GetById(id);
            if (rol == null)
            {
                return NotFound();
            }
            return View(rol);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _rolRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
