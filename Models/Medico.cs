using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Required(ErrorMessage = "El nombre del médico es requerido.")]
        [StringLength(50, ErrorMessage = "El nombre del médico tiene un máximo de 50 caracteres")]
        [Display(Name = "Nombre(s)", Prompt = "Ingrese el nombre del médico")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del médico es requerido.")]
        [StringLength(50, ErrorMessage = "El apellido del médico tiene un máximo de 50 caracteres")]
        [Display(Name = "Apellido(s)", Prompt = "Ingrese el apellido del médico")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La dirección del médico es requerida.")]
        [StringLength(250, ErrorMessage = "La dirección del médico tiene un máximo de 250 caracteres")]
        [Display(Name = "Dirección", Prompt = "Ingrese una dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono del médico es requerido.")]
        [StringLength(20, ErrorMessage = "El teléfono del médico tiene un máximo de 20 caracteres")]
        [Display(Name = "Teléfono", Prompt = "Ingrese un teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electrónico del médico es requerido.")]
        [StringLength(100, ErrorMessage = "El correo electrónico del médico tiene un máximo de 100 caracteres")]
        [Display(Name = "Correo electrónico", Prompt = "Ingrese un correo electrónico")]
        [EmailAddress(ErrorMessage = "No es un correo electrónico válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El horario desde del médico es requerido.")]
        [Display(Name = "Horario desde", Prompt = "Ingrese un horario inicial")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionDesde { get; set; }

        [Required(ErrorMessage = "El horario hasta del médico es requerido.")]
        [Display(Name = "Horario hasta", Prompt = "Ingrese un horario final")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionHasta { get; set; }
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
    }
}