using System;
using SQLite;

namespace EverythingDoAndroid
{
	[Table("todos")]
	public class Todo
	{
		[PrimaryKey]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool Reminder { get; set; }
		public DateTime DueDate { get; set; }

		public override string ToString ()
		{
			return this.Name;
		}
	}
}
