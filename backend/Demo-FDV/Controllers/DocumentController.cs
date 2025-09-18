using Microsoft.AspNetCore.Mvc;

namespace Demo_FDV.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentsController : ControllerBase
{
  
    private readonly ILogger<DocumentsController> _logger;
    private List<Document> _documents = [
        new Document("001", DateTime.Now, "Customer A"),
        new Document("002", DateTime.Now, "Customer B"),
        new Document("003", DateTime.Now, "Customer C")
    ];

    public DocumentsController(ILogger<DocumentsController> logger)
    {
        _logger = logger;
    }

    // GET api/Documents
    [HttpGet]
    public IEnumerable<Document> GetDocuments()
    {

        _logger.LogInformation($"Nombre de documents : { _documents.Count}");

        return _documents;
    }

    // GET api/Documents/{id}
    [HttpGet("{id}")]
    public ActionResult<Document> GetDocumentById(string id)
    {
        var document = _documents.FirstOrDefault(d => d.Number == id);

        if (document == null)
        {
            return NotFound($"Document with id {id} not found.");
        }

        return document;
    }

    // POST api/Documents
    [HttpPost]
    public ActionResult<Document> PostDocument(Document document)
    {
        _documents.Add(document);

        return document;
    }
}
