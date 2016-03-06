using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo.Models
{
	class Todo
	{
		public int ID { get; set; }
		public bool Completed { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
