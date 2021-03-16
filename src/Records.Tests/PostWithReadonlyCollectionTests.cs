using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;

namespace Records.Tests
{
    public class PostWithReadonlyCollectionTests
    {
        [Test]
        public void PostNegativesWithSameContentDiffer()
        {
            // Arrange
            var initial = new PostWithReadonlyCollection("test body",
                new ReadOnlyCollection<string>(new List<string> {"#education", "#help"}));

            var copy = new PostWithReadonlyCollection("test body",
                new ReadOnlyCollection<string>(new List<string> {"#education", "#help"}));

            // Assert
            Assert.AreNotEqual(initial, copy);
        }
    }
}