namespace Demo_FDV
{
    public class Document
    {
        public string Number { get; set; }
        public DateTime CreatedAt { get; }
        public string CustumerName { get; set; }

        public Document(string number, DateTime createdAt,string custumerName)
        {
            Number = number;
            CreatedAt = createdAt;
            CustumerName = custumerName;
        }
    
    }
}
