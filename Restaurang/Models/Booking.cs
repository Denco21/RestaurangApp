using System.ComponentModel.DataAnnotations;

namespace Restaurang.Models
{
    public class Booking
    {
        public Booking()
        {
            BookingDate = new DateTime(2023, 08, 1); //  standardvärdet för BookingDate till 1 januari 2023
        }
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Vänligen ange ett bokningsdatum.")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Vänligen ange en bokningstid.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan BookingTime { get; set; }
        [Range(1, 15 , ErrorMessage = "Antal gäster måste vara minst 1 max 15.")]
        public int NumberOfGuests { get; set; }
    }


}
