using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_ReposioryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void SCRepository_AddToList_GetShouldReturnCorrectCount()
        {
            // Arrange -- Set up the playing field
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToList(content);

            // Act -- Get/run the code we want to test
            List<StreamingContent> actualList = repo.GetContentList();

            int expected = 1;
            int actual = actualList.Count;

            //Assert -- Use the Assert class to verify the expected outcome
            Assert.AreEqual(expected, actual);
        }
    }
}
