using Microsoft.AspNetCore.Mvc;

namespace Demo_FDV.Controllers;

[ApiController]
[Route("[controller]")]
public class DocumentController : ControllerBase
{
  
    private readonly ILogger<DocumentController> _logger;

    public DocumentController(ILogger<DocumentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDocuments")]
    public IEnumerable<Document> Get()
    {


        Document doc1 = new("001", DateTime.Now, "Customer A");
        Document doc2 = new("002", DateTime.Now, "Customer B");
        Document doc3 = new("003", DateTime.Now, "Customer C");

        List<Document> listeDocument = [doc1, doc2, doc3];

        _logger.LogInformation("Nombre de documents " + listeDocument.Count);

        return listeDocument;
    }
}
