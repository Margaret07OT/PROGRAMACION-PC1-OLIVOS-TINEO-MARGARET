using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webappPC1.Models;

namespace webappPC1.Controllers
{

    public class AlumnoController : Controller
    {
        private readonly ILogger<AlumnoController> _logger;

        public AlumnoController(ILogger<AlumnoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

          [HttpPost]

         public IActionResult create(Alumno objAlumno)
        {

         double subtotal=0.0;
         double total=0.0;
         double igv=0.0;
 
         subtotal=objAlumno.creditos*100;
         total=subtotal*1.18;
         igv=total-subtotal;

            ViewData["Message"] = "Gracias por registrarte!";
            ViewData["Message00"] = "DNI DEL ALUMNO:"+ objAlumno.dni;
            ViewData["Message01"] = "NOMBRES COMPLETOS:"+ objAlumno.nombres;
            ViewData["Message02"] = "APELLIDOS COMPLETOS:"+ objAlumno.apellidos;
            ViewData["Message03"] = "CURSOS MATRICULADOS:"+ objAlumno.cursos;
            ViewData["Message04"] = "N° CRÉDITOS:"+ objAlumno.creditos;
            ViewData["Message05"] = "SUBTOTAL: "+ subtotal;
            ViewData["Message06"] = "IGV: "+ igv;
            ViewData["Message07"] = "TOTAL A PAGAR: "+ total ;
        return View("confirmado");
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}