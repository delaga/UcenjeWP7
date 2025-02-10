using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {
        public string Naziv { get; set; } = "";
        public int? Trajanje { get; set; }

        [Column("cijena")]
        public decimal? CijenaSmijera { get; set; }

        public bool? Vaucer { get; set; }

        public DateTime? IzvodiSeOd { get; set; }


    }
}
