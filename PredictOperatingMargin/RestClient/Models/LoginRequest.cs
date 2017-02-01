// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HotelOperatingMargin.Models
{
    using System.Linq;

    public partial class LoginRequest
    {
        /// <summary>
        /// Initializes a new instance of the LoginRequest class.
        /// </summary>
        public LoginRequest() { }

        /// <summary>
        /// Initializes a new instance of the LoginRequest class.
        /// </summary>
        /// <param name="username">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        public LoginRequest(string username = default(string), string password = default(string))
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
