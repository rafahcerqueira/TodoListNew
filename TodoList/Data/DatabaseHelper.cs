using System.Drawing;

namespace TodoList.Utils
{
    public static class DatabaseHelper
    {
        public static string ConnectionString { get; } = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ToDoListDB;Integrated Security=True;Encrypt=False;";
    }

}
