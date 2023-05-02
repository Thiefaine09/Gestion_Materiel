using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class Intervention
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Commentaire { get; set; }
        public string Technicien { get; set; }
        [ForeignKey("materielId")]
        public int MaterielId { get; set; }
        public virtual Materiel Materiel { get; set; } = null!;


    }
}
