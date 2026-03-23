namespace ServerManagement.State
{
    public class ServerStateObserver
    {
        /*
            The event that Subscriber components will listen to
                Because this property is marked as an event, meaning outside classes can only
                subscribe to it using '=+' or unsiscribe using '-='. They cannot trigger the 
                event directly
         */
        public event Action? OnServerStateChanged;

        // Method called by Publisher components to Broadcast the change
        public void NotifyServerStateChanged()
        {
            OnServerStateChanged?.Invoke();
        }
    }
}
