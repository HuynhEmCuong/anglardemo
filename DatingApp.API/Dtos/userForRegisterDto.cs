using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class userForRegisterDto
    {
        [Required]
        public string username { get; set; }

        public string password { get; set; }
        public string gender { get; set; }

        public string knowAs { get; set; }

        public DateTime dateOfBirth { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public DateTime created { get; set; }

        public DateTime lastActive { get; set; }

        public userForRegisterDto()
        {
            created = DateTime.Now;
            lastActive = DateTime.Now;
        }
    }
}