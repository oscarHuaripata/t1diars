using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using t1.DB;
using t1.Models;

namespace t1.Controllers
{
    public class PersonaController : Controller
    {
        private ExamenT1App conexion;

        public PersonaController(ExamenT1App conexion  )
        {
            this.conexion = conexion;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var conexion = new ExamenT1App();

            var lista = conexion.Personas.Include(o => o.Ciudad).ToList();

            return View(lista);

        }
        [HttpGet]
        public IActionResult Crear() {

           // var conexion = new ExamenT1App();

            ViewBag.personas = conexion.Personas.ToList();
            return View();
        }

        public IActionResult Crear(Persona persona)
        {

          //  var conexion = new ExamenT1App();

           
            
                if (persona.nombre !=null )
                {
                    ModelState.AddModelError("Nombre","llenar el campo");
                }
                if (persona.nombre != null)
                {
                    if (!Regex.IsMatch(persona.nombre, @"^[a-zA-Z ]*$"))
                    {
                        ModelState.AddModelError("Nombre", "el nombre solo acepta letras");
                    }
                    
                }
                if (persona.nombre != null)
                {
                    if (Regex.IsMatch(persona.nombre, @"^[a-zA-Z ]*$"))
                    {
                        if (persona.nombre.Length <=2)
                        {
                            ModelState.AddModelError("nombre","nombre solo acepta 2 caracteres");
                        }
                    }
                }

                if (persona.apellido != null)
                {
                    if (Regex.IsMatch(persona.apellido, @"^[a-zA-Z ]*$"))
                    {
                        if (persona.apellido.Length <= 2)
                        {
                            ModelState.AddModelError("nombre", "nombre solo acepta 2 caracteres");
                        }
                    }
                }

                if (persona.apellido != null)
                {
                    ModelState.AddModelError("Apellido", "llenar el campo");
                }

                if (persona.DNI !=null)
                {
                    if (Regex.IsMatch(persona.DNI, "^\\d+$"))
                    {
                        if (persona.DNI.Length !=8)
                        {
                            ModelState.AddModelError("DNI","el dni debe tenr 8 digitos");

                        }
                    }
                }

                if (persona.correo != null)
                {
                    if (!Regex.IsMatch(persona.correo, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
                        ModelState.AddModelError("Correo", "El formato debe ser de correo");
                }

            if (ModelState.IsValid)
            {
                conexion.Personas.Add(persona);
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Crear");
        }
    }
}
