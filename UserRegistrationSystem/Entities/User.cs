using System.ComponentModel.DataAnnotations.Schema;

namespace UserRegistrationSystem.Entities
{
    public class User
    {
        public int Id { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        
        public Address Address { get; set; }
        [ForeignKey("Login")]
        public int LoginId { get; set; }
        
        public Login Login { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdNo { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}
