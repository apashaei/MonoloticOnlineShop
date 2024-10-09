namespace Project.Application.UserServices
{
    public class AddUserAddressDto
    {
        public string UserId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PostalAddress { get; set; }
        public string RecieverName { get; set; }
    }
}
