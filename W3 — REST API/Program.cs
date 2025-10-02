
namespace W3_REST_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            driver();

            /*var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();*/
        }

        private static void driver() {
            /*
            //  FileReader test: 
            Console.WriteLine("DEBUG: filereader, read cereal.csv");
            FileReader fileReader = new FileReader();
            Console.WriteLine("DEBUG: filereader, files counted: " + fileReader.discoveredFilesCount());
            fileReader.readTableFromFile(0);
            foreach (String[] row in fileReader.getTable()) {
                foreach (String column in row) {
                    Console.Write(column.PadLeft(8) + "|");
                }
                Console.WriteLine();
            }
            */


            //  Database connection test:
            DataBaseConnector.Server = "localhost";
            DataBaseConnector.DatabaseName = "cereal";
            DataBaseConnector.TableName = "cereal";
            DataBaseConnector.Username = "root";
            DataBaseConnector.Password = "12345";
            DataBaseConnector.connect();
            DataBaseConnector.read();
        }

    }
}
