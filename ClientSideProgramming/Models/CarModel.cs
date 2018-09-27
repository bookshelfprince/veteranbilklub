using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientSideProgramming.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Manufactor { get; set; }
        public string Image { get; set; }
    }
}