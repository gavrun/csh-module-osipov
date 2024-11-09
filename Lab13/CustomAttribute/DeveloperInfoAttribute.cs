namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
    public class DeveloperInfoAttribute : System.Attribute
    {
        private string developerName;

        private string dateCreated;

        // mandatory parameter
        public DeveloperInfoAttribute(string developerName)
        {
            this.developerName = developerName;
        }

        // property
        public string Developer
        {
            get
            {
                return developerName;
            }
        }

        // property, optional setter by external value 
        public string Date
        {
            get
            {
                return dateCreated;
            }

            set
            {
                dateCreated = value;
            }
        }
    }
}
