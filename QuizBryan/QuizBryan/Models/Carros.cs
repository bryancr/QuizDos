using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuizBryan.Models
{
    public class Carros
    {   
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public string Color { get; set; }
    }
    
    class CarrosDbContext : DbContext
    {
        public DbSet<Carros> Carros { get; set;}
    }
}

