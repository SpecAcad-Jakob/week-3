using MySql.Data;
using MySql.Data.MySqlClient;

namespace W3_REST_API {
    public static class DataBaseConnector {
        private static MySqlConnection connection;
        private static MySqlDataReader reader;
        private static MySqlCommand command;
        private static MySqlParameter[] parametres;

        public static String Server { get; set; }
        public static String DatabaseName { get; set; }
        public static String Username { get; set; }
        public static String Password { get; set; }
        public static String TableName { get; set; }

        public static void connect() {
            connection = new MySqlConnection();
            connection.ConnectionString = $"server={Server},uid={Username},pwd={Password},database={DatabaseName}";
            connection.Open();
        }

        public static Boolean create(Object[] tableRow) {
            throw new NotImplementedException();
        }

        public static List<Object[]> read() {
            command = new MySqlCommand();
            command.CommandText = $"SELECT * FROM {TableName}";
            command.Connection = connection;

            MySqlDataReader reader = command.ExecuteReader();
            List<Object[]> table = new List<object[]>();
            while (reader.Read()) {
                Console.WriteLine(reader);
                //  table.Add(reader);
            }

            return null;
        }

        public static Boolean update(Object primaryKeyOfDatabase) {
            throw new NotImplementedException();
        }

        public static Boolean delete(Object primaryKeyOfDatabase) {
            throw new NotImplementedException();
        }

    }
}
