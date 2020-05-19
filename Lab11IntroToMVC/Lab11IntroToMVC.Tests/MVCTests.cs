using Lab11IntroToMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Lab11IntroToMVC.Tests
{
    public class MVCTests
    {
        [Fact (Skip = "need guidance here")]
        public void Can_populate_person_list()
        {
            // Arrange
            var person = File.ReadAllLines("app_data/personOfTheYear.csv");
            var expected = new Person()
            {
                1927,
                "Man of the Year",
                "Charles Lindbergh",
                "United States",
                1902,
                1974,
                "US Air Mail Pilot",
                "",
                "First Solo Transatlantic Flight",

            };

            // Act
            var actual = person
                            .Skip(1)
                            .Select(personLine => personLine.Split(","))
                            .Select(personCells => new Person
                            {
                                Year = int.Parse(personCells[0]),
                                Honor = personCells[1],
                                Name = personCells[2],
                                Country = personCells[3],
                                BirthYear = int.Parse(personCells[4]),
                                DeathYear = int.Parse(personCells[5]),
                                Title = personCells[6],
                                Category = personCells[7],
                                Context = personCells[8],
                            })
                            .ToList();


            // Assert
            Assert.Contains(expected.Name , actual[2].ToString());

        }
    }
}
