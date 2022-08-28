using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webappPC1.Models
{
    public class Alumno
    {
         [Display(Name = "DNI:", Prompt = "Ingresar DNI del alumno")]
        public string? dni {get; set;}
        
        [Display(Name = "NOMBRES COMPLETOS:", Prompt = "Ingresar los nombres completos del alumno")]
        public string? nombres {get; set;}

        [Display(Name = "APELLIDOS COMPLETOS:", Prompt = "Ingresar los apellidos completos del alumno")]
        public string? apellidos {get; set;}   

        [Display(Name = "SELECCIONAR CURSO:")]
        public string? cursos {get; set;}
       
       [Display(Name = "N° DE CRÉDITOS TOTALES:", Prompt = "Ingresar el n° de créditos totales:")]
        public int creditos {get; set;}

       
    }
}