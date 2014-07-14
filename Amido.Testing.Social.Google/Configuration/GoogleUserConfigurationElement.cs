using System.Configuration;

namespace Amido.Testing.Social.Google.Configuration
{
    public class GoogleUserConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("email", IsKey = true, IsRequired = true)]
        public string Email
        {
            get
            {
                return this["email"].ToString();
            }
            set
            {
                this["email"] = value;
            }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get
            {
                return this["password"].ToString();
            }
            set
            {
                this["password"] = value;
            }
        }

        [ConfigurationProperty("dateOfBirth", IsRequired = false)]
        public string DateOfBirth
        {
            get
            {
                return this["dateOfBirth"].ToString();
            }
            set
            {
                this["dateOfBirth"] = value;
            }
        }
        [ConfigurationProperty("gender", IsRequired = false)]
        public string Gender
        {
            get
            {
                return this["gender"].ToString();
            }
            set
            {
                this["gender"] = value;
            }
        }
    }
}