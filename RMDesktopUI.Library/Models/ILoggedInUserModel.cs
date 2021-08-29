using System;

namespace RMDesktopUI.Library.Models
{
    public interface ILoggedInUserModel
    {
        string Token { get; set; }
        string AuthUserId { get; set; }
        DateTime CreatedDate { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}