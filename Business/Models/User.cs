using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; } = null!;
        public string PostalCode { get; set; }

        public string PlaceOfResidence { get; set; } = null!;

        public User(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string placeOfResidence)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            PlaceOfResidence = placeOfResidence;
        }
    }

}
