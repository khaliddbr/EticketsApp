using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EticketsApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
