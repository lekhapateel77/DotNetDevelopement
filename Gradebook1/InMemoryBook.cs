using System;
using System.Collections.Generic;
using System.IO;

namespace  Gradebook {

	public  delegate void GradeAddedDelegate(object sender, EventArgs args);
	public class NamedObject
	{  
		public NamedObject(string name)
		{
			Name = name;
		}
		public string Name
		{
			get;set;
		}
	}
	public interface Ibook
	{
		void Addgrade(double grade);
		Statistics Getstatistics();
		string Name { get; }
		event GradeAddedDelegate GradeAdded;


	}
	public abstract class Book : NamedObject, Ibook
	{
		public Book(string name) : base(name)
		{
		}

		public abstract	event GradeAddedDelegate GradeAdded;

		public abstract void Addgrade(Double grade);

		public abstract Statistics Getstatistics();

	}

	public class DiskBook : Book
	{
		public DiskBook(string name) : base(name)
		{
		}
		public override event GradeAddedDelegate GradeAdded;

		public override void Addgrade(double grade)
		{
			using (var writer = File.AppendText($"{Name}.txt"))
			{
				writer.WriteLine(grade);
				if (GradeAdded != null)
				{
					GradeAdded(this, new EventArgs());
				}
			}
		}

		public override Statistics Getstatistics()
		{
			var result = new Statistics();
			using (var reader = File.OpenText($"{Name}.txt"))
			{
				var line =reader.ReadLine();
				while(line!=null)
				{
					var number = double.Parse(line);
					result.add(number);
				    line = reader.ReadLine();
				}
			}
			return result;

		}
	}
	public class InMemoryBook : Book
	{		
		public InMemoryBook(string name) :base(name)
		{
			grades = new List<double>();
			Name =name;
		}
		public override void Addgrade(Double grade)
		{
			if (grade <= 100 && grade >=0.0)
			{ 
				grades.Add(grade);
				if (GradeAdded != null)
				{
					GradeAdded(this,new EventArgs());
				}
			}
			else
			{
				throw new ArgumentException($"Invalid {nameof(grade)}");
			}
		}
		public override event GradeAddedDelegate GradeAdded;
		public override Statistics Getstatistics()
		{
			var result = new Statistics();
			
			for (var Index=0; Index< grades.Count; Index++)
			{
				result.add(grades[Index]);
			}
			return result;
		}
		private List<double> grades;
	
    }

}