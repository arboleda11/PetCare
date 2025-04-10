using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(15)]
        public string Telefono { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        // Relación con las mascotas del cliente (pero no se usa en el POST)
        public ICollection<Mascota> Mascotas { get; set; }
    }
}
