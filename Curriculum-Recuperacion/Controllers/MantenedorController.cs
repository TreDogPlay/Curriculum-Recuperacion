using Microsoft.AspNetCore.Mvc;
using Curriculum_Recuperacion.Datos;
using Curriculum_Recuperacion.Models;

namespace Curriculum_Recuperacion.Controllers
{
    public class MantenedorController : Controller
    {

        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            //La vista mostrara una lista de los contactos
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }

        public IActionResult Detalle(int IdContacto)
        {
            var contacto = _ContactoDatos.Obtener(IdContacto);

            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }



        public IActionResult Guardar()
        {
            //Metodo solo devuelve la vista
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //Metodo recibe el objeto para guardarlo en la BD
            //if (!ModelState.IsValid)
            //    return View();

            var respuesta = _ContactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Editar(int IdContacto)
        {
            //Metodo solo devuelve la vista
            var ocontacto = _ContactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            //Metodo solo devuelve la vista

            if (!ModelState.IsValid)
                return View();

            var respuesta = _ContactoDatos.Editar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdContacto)
        {
            //Metodo solo devuelve la vista
            var ocontacto = _ContactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {

            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View("Listar");
        }


        public IActionResult Ver(int IdContacto)
        {
            var contacto = _ContactoDatos.Obtener(IdContacto);

            if (contacto == null)
            {
                // Si no se encuentra el contacto, puedes redirigir a una página de error o mostrar un mensaje
                return RedirectToAction("Error");
            }

            // Convertir la imagen a una representación base64
            

            return View(contacto);
        }
    }


    //public IActionResult VerCurriculum()
    //{

    //}
}

