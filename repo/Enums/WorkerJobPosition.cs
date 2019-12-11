using System.ComponentModel.DataAnnotations;

namespace repo.Enums
{
    public enum WorkerJobPosition
    {
        [Display(Name ="Prezes")]
        CEO=1,
        [Display(Name ="Kierownik ds. dystrybucji")]
        DistributionManager=2,
        [Display(Name ="Dyspozytor")]
        DepartureSpecialist=3,
        [Display(Name ="Dostawca")]
        DeliveryDriver=4

    }
}