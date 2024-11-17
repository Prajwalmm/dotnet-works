namespace webapiAndServices.Models
{
    public class AddUpdateOurPeople
    {
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public bool isActive { get; set; } = true;
    }
}
