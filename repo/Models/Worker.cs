using repo.Enums;
using System.Collections.Generic;

namespace repo.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public WorkerJobPosition JobPosition { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}