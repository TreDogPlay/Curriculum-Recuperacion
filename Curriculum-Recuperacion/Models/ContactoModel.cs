using System.ComponentModel.DataAnnotations;

namespace Curriculum_Recuperacion.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo correo es obligatorio")]
        public string? Correo { get; set; }

        public string? Email { get; set; }
        public string? Foto { get; set; }
        public IFormFile Imagen { get; set; }
        public string? Titulo { get; set; }
        public List<ExperienciaLaboralModel> ExperienciaLaboral { get; set; }
        public List<EstudioModel> Estudios { get; set; }
        public List<SkillModel> Skills { get; set; }

    }

    public class ExperienciaLaboralModel
    {
        public string Puesto { get; set; }
        public string Empresa { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }

    public class EstudioModel
    {
        public string Nivel { get; set; }
        public string Institucion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }

    public class SkillModel
    {
        public string Nombre { get; set; }
        public string Nivel { get; set; }
    }
}
