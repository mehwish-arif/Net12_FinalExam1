using System;
using System.Collections.Generic;
using System.Text;

namespace Net12_FinalExam
{
	class FinalExam

	{
		public static void Main(string[] args)
		{
			Person[] arr = new Person[2];

			arr[0] = new Adult("Mehwish", "Arif");

			arr[1] = new Child("Eshaal", "Arif");

			foreach (Person person in arr)
			{
				Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
			}
		
		}


	}

	public class Person
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
	
		
	}

	public class Adult : Person
	{			
		public Adult (string FirstName, string LastName)

		{   this.FirstName = FirstName;
			this.LastName = LastName;
		}
	}

	public class Child : Person
	{
		public Child(string FirstName, string LastName)

		{
			this.FirstName = FirstName;
			this.LastName = LastName;
		}

	}

}