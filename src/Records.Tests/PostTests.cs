using NUnit.Framework;

namespace Records.Tests
{
    public class PostTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ObjectsWithSameContentEqual()
        {
            // Arrange
            var initial = new Post("test body",
                new RecordsCollection<string>("#education", "#help"));
            var copy = new Post("test body",
                new RecordsCollection<string>("#education", "#help"));

            // Assert
            Assert.AreEqual(initial, copy);
        }

        [Test]
        public void PostsWithDifferentTagsDiffer()
        {
            // Arrange
            var initial = new Post("test body",
                new RecordsCollection<string>("#education", "#learning", "#help"));
            var copy = new Post("test body",
                new RecordsCollection<string>("#education", "#help"));

            // Assert
            Assert.AreNotEqual(initial, copy);
        }

        [Test]
        public void PostsWithDifferentBodyDiffer()
        {
            // Arrange
            var initial = new Post("test body",
                new RecordsCollection<string>("#education", "#help"));
            var copy = new Post("different body",
                new RecordsCollection<string>("#education", "#help"));

            // Assert
            Assert.AreNotEqual(initial, copy);
        }

        [Test]
        public void TwoNullPostsEqual()
        {
            // Arrange
            Post initial = null;
            Post copy = null;

            // Assert
            Assert.AreEqual(initial, copy);
        }
    }
}