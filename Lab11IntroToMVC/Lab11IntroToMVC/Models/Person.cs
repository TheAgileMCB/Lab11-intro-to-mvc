using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace Lab11IntroToMVC.Models
{
    public class Person
    {
		public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }

		public static List<Person> GetPOTY()
		{
			var person = File.ReadAllLines("app_data/personOfTheYear.csv");

			return person
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
		}
	}
}
