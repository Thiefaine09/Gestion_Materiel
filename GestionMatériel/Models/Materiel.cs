using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class Materiel
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Marque { get; set; }
        public string Num_Serie { get; set; }
        public DateTime Date_Install { get; set; }
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; } = null!;
    }
}
