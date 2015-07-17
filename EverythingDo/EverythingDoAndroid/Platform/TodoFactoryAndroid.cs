using System;
using System.Collections.Generic;
using System.Linq;

namespace EverythingDoAndroid
{
	public class TodoFactoryAndroid
	{
		public List<Todo> GetTodos() {
			var result = AppConfig.SqlConnectionFactory.Instance.CreateTable<Todo>();
			CreateTodo ("Give entrepeneurship presentation", "At Hilton Hotel");
			CreateTodo ("Finish Xamarin example", "With Luis Verduzco");
			CreateTodo ("Go to the Bank", "At Galerias");
			return AppConfig.SqlConnectionFactory.Instance.Table<Todo> ().ToList();
		}

		public int CreateTodo(string name, string description) {
			return AppConfig.SqlConnectionFactory.Instance.Insert (new Todo{ Id = Guid.NewGuid(), Name = name, Description = description });
		}
	}
}