using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace repo.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public int? WorkerId { get; set; }
        [ForeignKey("WorkerId")]
        public virtual Worker Workers { get; set; }
        public DateTime Date { get; set; }
    }
}