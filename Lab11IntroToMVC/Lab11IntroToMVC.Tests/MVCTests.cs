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
        [Fact]
        public void Can_populate_person_list()
        {
            // Arrange
            var person = File.ReadAllLines("app_data/personOfTheYear.csv");
            var expected = new Person()
            {
                Year = 1927,
                Honor = "Man of the Year",
                Name = "Charles Lindbergh",


            };

            // Act
            var actual = person
                            .Skip(1)
                            .Select(personLine => personLine.Split(","))
                            .Select(personCells => new Person
                            {
                                Year = SafeParse(personCells[0]),
                                Honor = personCells[1],
                                Name = personCells[2],
                                Country = personCells[3],
                                BirthYear = SafeParse(personCells[4]),
                                DeathYear = SafeParse(personCells[5]),
                                Title = personCells[6],
                                Category = personCells[7],
                                Context = personCells[8],
                            })
                            .ToList();


            // Assert
            Assert.Contains(expected.Name, actual[0].Name);

        }

        public static int SafeParse(string value)
        {
            if (value == "")
            {
                return 0;

            }
            else
            {
                return int.Parse(value);
            }
        }



    }
}
