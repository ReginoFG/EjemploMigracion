using System.ComponentModel.DataAnnotations;


namespace entityBasicoDAL
{
    // Se definen, a través de clases, la estructura que tendrán
    // las entidades de la base de datos.
    // Estas clases se nombrarán en singular, ya que representan
    // un solo registro. ¡cuidado con los nombres!
    public class empleado
    {
        public int Id { get; set; }
        [Required]
        public string nombre_empleado { get; set; }
    }

    public class nivel_acc
    {
        
        public int Id { get; set; }
        [Required]
        public string nivel_acceso { get; set; }

        public string desc_acceso { get; set; }

        public List<empleado> empleados { get; set; }


    }
}
