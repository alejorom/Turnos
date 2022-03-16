using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }

        [StringLength(200, ErrorMessage = "La descripción de la especialidad tiene un máximo de 200 caracteres")]
        [Required(ErrorMessage = "La descripción de la especialidad es requerida.")]
        [Display(Name = "Descripción", Prompt = "Ingrese una descripción")]
        public string Descripcion { get; set; }
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }

    }
}