using repo.Models;
using System;
using System.Collections.Generic;

namespace repo.ViewModels
{
    public class VM_Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public int? WorkerId { get; set; }
        public virtual Worker Workers { get; set; }
        public List<Worker> ListOfWorkers { get; set; }
        public DateTime Date { get; set; }
    }
}