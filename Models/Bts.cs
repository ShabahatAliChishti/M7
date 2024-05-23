//Krupali Patel 
//CPT 231-S14
//Assignment 7 03/13/2022
using System.ComponentModel.DataAnnotations;

namespace M7.Models
{
    public class Bts
    {
        public int BtsId { get; set; }  //used by the database only. public key

        [Required(ErrorMessage ="Must enter a name")]
        public string Name{get; set; }

        [Required(ErrorMessage = "Must enter a rating")] 
        public string Ratings { get; set; }

    }
}