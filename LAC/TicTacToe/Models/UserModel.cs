using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        [Required()]
        public String FirstName { get; set; }
    
        [Required()]
        public string LastName { get; set; }

        [Required(), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(), DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsEmailConfirmed { get; set; }
        public DateTime? EmailConfigmationDate { get; set; }
        public int Score { get; set; }
    }
}
