using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_FDV;
using Demo_FDV.Interfaces;


namespace TestFDV
{
    class InMemoryDocumentRepository : IDocumentRepository
    {
  
        public InMemoryDocumentRepository() { }

        public IEnumerable<Document> GetAll()
        {
            throw new NotImplementedException();
        }

        public Document? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(Document document)
        {
            throw new NotImplementedException();
        }

        public void SeedData()
        {
            throw new NotImplementedException();
        }
    }
}
