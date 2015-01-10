namespace NotificationHubsSample
{
    /// <summary>
    /// Define the Constants.
    /// </summary>
    public class Constants
    {
        // ------- Google API Project Number
        // This is used in all Xamarin Android Projects
        public const string SenderID = "<to define>";

        // -------  Azure app specific connection string and hub name
		// This is only used in Case 1 and Case 2
	    public const string HubName  = "<to define>";
		  
        // This is only used in Case 1
        public const string ConnectionString  = "<to define>";
      
		
        // This is only used in Case 2 (WebAPI)
        public const string BackEndConnectionString  = "<to define>";
		
		// ------- This is only used in Case 2 - Azure Mobile Services
        public const string AMSEndpoint = "<to define>";
        public const string AMSKey  = "<to define>";
    }
}