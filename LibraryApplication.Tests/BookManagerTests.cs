using FluentAssertions;
using LibraryApplication.Data;
using LibraryApplication.Utility;
using Moq;

namespace LibraryApplication.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BookManagerConstructor_LoadsBooks_UsingIFileHandler()
        {
            // Arrange
            var fileHandlerMock = new Mock<IFileHandler>();

            var mockData = new List<Book>
            {
                new Book("Test Book","Test Description","Test Author",new DateOnly(2021, 1, 1),100),
                new Book("Test Book 2", "Test Description 2", "Test Author 2", new DateOnly(2021, 1, 1), 100),
                new Book("Test Book 3", "Test Description 3", "Test Author 3", new DateOnly(2021, 1, 1), 100),
                new Book("Test Book 4", "Test Description 4", "Test Author 4", new DateOnly(2021, 1, 1), 100),
            };

            fileHandlerMock.Setup(m => m.ReadBooksFromFile()).Returns(mockData);

            // Act
            var bookManager = new BookManager(fileHandlerMock.Object);

            // Assert
            fileHandlerMock.Verify(m => m.ReadBooksFromFile(), Times.Once);
            bookManager.GetAllBookInfo().Should().HaveCount(4);
        }
    }
}