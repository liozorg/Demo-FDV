namespace Demo_FDV.Interfaces
{
    public interface IDocumentRepository
    {
        IEnumerable<Document> GetAll();
        Document? GetById(string id);
        void Add(Document document);
    }
}
