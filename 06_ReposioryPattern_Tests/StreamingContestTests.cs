using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_ReposioryPattern_Tests
{
    [TestClass]
    public class StreamingContestTests
    {
        [TestMethod]
        public void StreamingContent_TitleProperty_ShouldSetCorrectString()
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }





        [TestMethod]
        public void StreamingContent_Constructor_ShouldSetProperties()
        {
            // Arrange
            StreamingContent content = new StreamingContent("Rubber", "A car tire comes too life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "R", 5.8, false, GenreType.Drama);

            // Act
            string expectedTitle = "Rubber";
            string actualTitle = content.Title;

            string expectedDesc = "A car tire comes too life with the power to make people explode and goes on a murderous rampage through the Californian desert.";
            string actualDesc = content.Description;

            string expectedMaturityRating = "R";
            string actualMaturityRating = content.MaturityRating;

            // Assert
            Assert.AreEqual(expectedTitle, actualTitle);
            Assert.AreEqual(expectedDesc, actualDesc);
            Assert.AreEqual(expectedMaturityRating, actualMaturityRating);
            Assert.AreEqual(5.8, content.StarRating);           //-- cleaner code so you don't have to declare, then use. (e.g. line 37 - 44)
            Assert.IsFalse(content.IsFamilyFriendly);           //-- instead of Assert.AreEqual(false, content.IsFamilyFriendly)
        }
    }
}
