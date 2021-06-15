﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursosCrudRazor.Models
{
    public class Curso
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Nombre del Curso")]
        public string NombreCurso { get; set; }
        [Display(Name ="Cantidad de Clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
    }
}