using Demo_FDV;
using Demo_FDV.Controllers;
using Microsoft.Extensions.Logging;
using Xunit;

namespace TestFDV
{
    public class TestDocumentController
    {
        [Fact]
        public void Get_ReturnsListOfDocuments()
        {
           
            // Arrange
            var loggerMock = new FakeLogger<DocumentsController>();
            var controller = new DocumentsController(loggerMock);

            // Act
            var result = controller.GetDocuments();

            // Assert
            Assert.NotNull(result);
            var documents = result.ToList();
            Assert.Equal(3, documents.Count);
            Assert.Contains(documents, d => d.Number == "001");
            Assert.Contains(documents, d => d.CustumerName == "Customer B");
            Assert.Contains(documents, d => d.CustumerName == "Customer C");
        }

        [Fact]
        public void Post_AddsDocumentToList()
        {
            // Arrange
            var loggerMock = new FakeLogger<DocumentsController>();
            var controller = new DocumentsController(loggerMock);
            var newDocument = new Document("004", DateTime.Now, "Customer D");

            // Act
            var postResult = controller.PostDocument(newDocument);
            var getResult = controller.GetDocuments();

            // Assert
            Assert.NotNull(postResult.Value);
            Assert.Equal(newDocument.Number, postResult.Value.Number);

            var documents = getResult.ToList();
            Assert.Equal(4, documents.Count);
            Assert.Contains(documents, d => d.Number == "004");
        }
    }
}
