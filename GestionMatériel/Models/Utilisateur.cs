using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Models
{
    public class Utilisateur
    {
        public int Id{ get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


    }
}
