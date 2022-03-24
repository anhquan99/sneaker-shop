namespace WebApplication1.Infrastructure.Exceptions
{
    public class RecodNotFoundException : Exception
    {
        public string recordID { get; set; }
        public RecodNotFoundException(String recordID)
        {
            this.recordID = recordID;
        }
    }
}
