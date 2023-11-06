using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MPatel5655.Models
{
    public class Measurement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter systolic.")]
        [Range(20, 400, ErrorMessage = "Systolic should be between 20 and 400.")]
        public int Systolic { get; set; }

        [Required(ErrorMessage = "Please enter diastolic.")]
        [Range(10, 300, ErrorMessage = "Diastolic should be between 10 and 300.")]
        public int Diastolic { get; set; }

        [Required(ErrorMessage = "Please enter Date.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a position.")]
        public string PositionId { get; set; } = string.Empty;

        [ValidateNever]
        public Position Position { get; set; } = null!;

        public string Category()
        {
            if (Systolic < 120 && Diastolic < 80)
            {
                return "Normal";
            }
            else if (Systolic >= 120 && Systolic <= 129 && Diastolic < 80)
            {
                return "Elevated";
            }
            else if ((Systolic >= 130 && Systolic <= 139) || Diastolic >= 80 && Diastolic <= 89)
            {
                return "Hypertensive stage 1";
            }
            else if ((Systolic >= 140 && Systolic <=179) || (Diastolic >= 90 && Diastolic <= 119))
            {
                return "Hypertensive stage 2";
            }
            else if (Systolic > 180 || Diastolic > 120)
            {
                return "Hypertensive crisis";
            }
            else
            {
                return "Reading is not valid";
            }
        }
        public string Color()
        {
            string category = Category();

            switch (category)
            {
                case "Normal":
                    return "normal";

                case "Elevated":
                    return "elevated";

                case "Hypertensive stage 1":
                    return "stage1";

                case "Hypertensive stage 2":
                    return "stage2";

                case "Hypertensive crisis":
                    return "crisis";
                default:
                    return "invalid";
            }
        }
    }
}