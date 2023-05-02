using GestionMatériel.Models;
using GestionMatériel.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        //définition des DbSet pour chaque Models
        public DbSet <Client>  Client {get; set;}
        public DbSet <Materiel> Materiel { get; set;}
        public DbSet <Utilisateur> Utilisateur { get; set;} 
        public DbSet <Intervention > Intervention { get; set;}

        //configuration de la connexion à la base SQL
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=gestion_materiels;Trusted_Connection=True;");
        
        //injection des données lors de la création de la base
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Nom = "HERIQUE", Prenom = "Laurent", Adresse = "34, rue de Bellevue", CodePostal = "77340", Ville = "Pontault Combault", Email = "laurent.herique@laposte.net", Telephone = "0627495967" },
                new Client { Id = 2, Nom = "GOURDIN", Prenom = "Vincent", Adresse = "4, rue Charles Bras", CodePostal = "77230", Ville = "Emerainville", Email = "vincent.gourdin@gm.com", Telephone = "0627657889" }
                );

            modelBuilder.Entity<Materiel>().HasData(
                new Materiel { Id = 1, Type = "Ordinateur", Marque = "Dell", Num_Serie = "233986937902", Date_Install = DateTime.Now, ClientId = 1 },
                new Materiel { Id = 2, Type = "Ecran", Marque = "IIyama", Num_Serie = "56677887902", Date_Install = DateTime.Now, ClientId = 1 },
                new Materiel { Id = 3, Type = "Imprimante", Marque = "HP", Num_Serie = "87566777021", Date_Install = DateTime.Now, ClientId = 2 }
                );

            modelBuilder.Entity<Intervention>().HasData(
                new Intervention { Id = 1, Date = DateTime.Now, Commentaire = "Bourrage récurent", Technicien = "Adrien", MaterielId = 3, }
                );

            var Hash = new Password();
            byte[] salt;
            modelBuilder.Entity<Utilisateur>().HasData(
                new Utilisateur { Id = 1, Login = "thiefaine@gmail.com", Password = Hash.HashPasword("Toto/123", out salt), Role = "Admin" }
                );
        }
    }
}
