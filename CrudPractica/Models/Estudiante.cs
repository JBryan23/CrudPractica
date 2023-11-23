using System;
using System.Collections.Generic;

namespace CrudPractica.Models
{
    public partial class Estudiante
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Edad { get; set; }
        public string? Sexo { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Contraseña { get; set; }
    }
}
