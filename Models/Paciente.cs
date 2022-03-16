using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "El nombre del paciente es requerido.")]
        [StringLength(50, ErrorMessage = "El nombre del paciente tiene un máximo de 50 caracteres")]
        [Display(Name = "Nombre(s)", Prompt = "Ingrese el nombre del paciente")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del paciente es requerido.")]
        [StringLength(50, ErrorMessage = "El apellido del paciente tiene un máximo de 50 caracteres")]
        [Display(Name = "Apellido(s)", Prompt = "Ingrese el apellido del paciente")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La dirección del paciente es requerida.")]
        [StringLength(250, ErrorMessage = "La dirección del paciente tiene un máximo de 250 caracteres")]
        [Display(Name = "Dirección", Prompt = "Ingrese una dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono del paciente es requerido.")]
        [StringLength(20, ErrorMessage = "El teléfono del paciente tiene un máximo de 20 caracteres")]
        [Display(Name = "Teléfono", Prompt = "Ingrese un teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electrónico del paciente es requerido.")]
        [StringLength(100, ErrorMessage = "El correo electrónico del paciente tiene un máximo de 100 caracteres")]
        [Display(Name = "Correo electrónico", Prompt = "Ingrese un correo electrónico")]
        [EmailAddress(ErrorMessage = "No es un correo electrónico válido.")]
        public string Email { get; set; }

    }
}