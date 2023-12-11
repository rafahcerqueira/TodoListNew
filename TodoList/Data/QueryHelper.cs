namespace TodoList.Data
{
    public static class QueryHelper
    {
        // Queries relacionadas aos usuários
        public static string SelectUserCountByEmailAndPassword => "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Senha = @Senha";
        public static string SelectUserIdByEmail => "SELECT ID FROM Usuarios WHERE Email = @Email";
        public static string InsertUsuarios = "INSERT INTO Usuarios (ID, Email, Senha) VALUES (@ID, @Email, @Senha)";

        // Queries relacionadas às tarefas
        public static string SelectTasksByUserId => "SELECT ID, Description, Done FROM Todo WHERE UserID = @UserID";
        public static string DeleteTasksByUserId => "DELETE FROM Todo WHERE UserID = @UserID";
        public static string DeleteUserById => "DELETE FROM Usuarios WHERE ID = @UserID";
        public static string InsertTask => "INSERT INTO Todo (UserID, Description, Done) VALUES (@UserID, @Description, 0)";
    }
}
