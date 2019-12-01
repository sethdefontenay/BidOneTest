using System;
using System.ComponentModel.DataAnnotations;

namespace TestBidone.Models
{
    public class UserModel: IModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public Guid Id { get; set; }
    }
}
