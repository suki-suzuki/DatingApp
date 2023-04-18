using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDtos
    {
        public string UserName{get; set; }

        public string Password { get; set; }
    }
}