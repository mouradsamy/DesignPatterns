using System.ComponentModel.DataAnnotations;

namespace Common.Enums
{
    public enum ToppingTypes
    {
        [Display(Name = "Ham")]
        Ham,

        [Display(Name = "Pepperoni")]
        Pepperoni,

        [Display(Name = "Pineapple")]
        Pineapple,

        [Display(Name = "Salami")]
        Salami,

        [Display(Name = "Grated Reggiano Cheese")]
        GratedReggianoCheese,
    }
}
