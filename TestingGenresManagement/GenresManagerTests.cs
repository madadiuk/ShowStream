using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;
using ClassLibrary;  // Replace with the correct namespace for GenresManager and clsDataConnection

namespace TestingGenresManagement
{
    [TestClass]
    public class GenresManagerTests
    {
        private GenresManager genresManager;
        private clsDataConnection connection;

        [TestInitialize]
        public void SetUp()
        {
            genresManager = new GenresManager();
            connection = new clsDataConnection();
            // Optionally, set up the database here if needed
        }

        [TestCleanup]
        public void TearDown()
        {
            // Clean up the database after each test if needed
        }

        [TestMethod]
        public void TestAddGenre()
        {
            // Arrange
            string name = "Test Genre";
            string description = "Test Description";

            // Act
            genresManager.AddGenre(name, description);

            // Assert
            var results = genresManager.GetAllGenres();
            Assert.IsTrue(results.AsEnumerable().Any(row =>
                (string)row["Name"] == name &&
                (string)row["Description"] == description),
                "Genre should be added in the database.");
        }

        [TestMethod]
        public void TestUpdateGenre()
        {
            // Arrange
            string originalName = "Original Genre";
            string originalDescription = "Original Description";
            genresManager.AddGenre(originalName, originalDescription);

            var genres = genresManager.GetAllGenres();
            var genreToUpdate = genres.AsEnumerable().FirstOrDefault(row => (string)row["Name"] == originalName);
            int genreId = (int)genreToUpdate["GenreID"];

            string updatedName = "Updated Genre";
            string updatedDescription = "Updated Description";

            // Act
            genresManager.UpdateGenre(genreId, updatedName, updatedDescription);

            // Assert
            var updatedGenres = genresManager.GetAllGenres();
            Assert.IsTrue(updatedGenres.AsEnumerable().Any(row =>
                (int)row["GenreID"] == genreId &&
                (string)row["Name"] == updatedName &&
                (string)row["Description"] == updatedDescription),
                "Genre should be updated in the database.");
        }

        [TestMethod]
        public void TestDeleteGenre()
        {
            // Arrange
            string name = "Genre to Delete";
            string description = "Description";
            genresManager.AddGenre(name, description);

            var genres = genresManager.GetAllGenres();
            var genreToDelete = genres.AsEnumerable().FirstOrDefault(row => (string)row["Name"] == name);
            int genreId = (int)genreToDelete["GenreID"];

            // Act
            genresManager.DeleteGenre(genreId);

            // Assert
            var remainingGenres = genresManager.GetAllGenres();
            Assert.IsFalse(remainingGenres.AsEnumerable().Any(row =>
                (int)row["GenreID"] == genreId),
                "Genre should be deleted from the database.");
        }

        [TestMethod]
        public void TestGetAllGenres()
        {
            // Act
            var results = genresManager.GetAllGenres();

            // Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Rows.Count > 0, "There should be at least one genre in the database.");
        }
    }
}
