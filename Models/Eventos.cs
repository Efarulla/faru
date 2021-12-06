using System;
using System.ComponentModel.DataAnnotations;

namespace PlantillaAppi.Models
{
    public class Eventos
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string email { get; set; }
        public string color { get; set; }

        public string tipo { get; set; }
    }
}
