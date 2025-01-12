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

        /*
         Minor refactoring with help from Chat GPT 4o here.
         Previously i used Guid.NewGuid() both in the ield declaration and in the constructor.
         It was unecessary use since the field declaration already had the Guid initialized.
         Removed it so it didn't call it two times, just to overwrite the field declarations Guid. 
         I didn't quite think that part through when i wrote the code.
        */
        
        public User(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string placeOfResidence)
        {
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
