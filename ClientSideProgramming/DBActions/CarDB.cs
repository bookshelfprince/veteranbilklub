using ClientSideProgramming.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClientSideProgramming.DBActions
{
    public class CarDB
    {
        private SqlConnection conn;
        private string connetionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-WebApplication1-20180918105458.mdf;Initial Catalog=aspnet-WebApplication1-20180918105458;Integrated Security=True";

        public void AddCar(Car car, string Username)
        {
            conn = new SqlConnection(connetionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Insert into dbo.Cars(Name,Year,Manufactor,Image,Username) Values('" + car.Name + "', '" + car.Year + "', '" + car.Manufactor + "', '" + car.Image + "', '" + Username + "')";
            SqlCommand command = new SqlCommand(sql, conn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }

        public void DeleteCar(Car car, string Username)
        {
            conn = new SqlConnection(connetionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Delete from dbo.Cars WHERE Username='" + Username.ToString() + "' AND Name='" + car.Name.ToString() + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }

        public List<Car> GetCars(string Username)
        {
            conn = new SqlConnection(connetionString);
            conn.Open();
            List<Car> cars = new List<Car>();
            string sql = "Select Name,Year,Manufactor,Image From dbo.Cars Where Username='" + Username + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var Car = new Car
                {
                    Name = dataReader.GetValue(0).ToString(),
                    Year = dataReader.GetValue(1).ToString(),
                    Manufactor = dataReader.GetValue(2).ToString(),
                    Image = dataReader.GetValue(3).ToString(),
                };

                cars.Add(Car);
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return cars;
        }

        public List<Car> GetAllCars()
        {
            conn = new SqlConnection(connetionString);
            conn.Open();
            List<Car> cars = new List<Car>();
            string sql = "Select Name,Year,Manufactor,Image From dbo.Cars";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var Car = new Car
                {
                    Name = dataReader.GetValue(0).ToString(),
                    Year = dataReader.GetValue(1).ToString(),
                    Manufactor = dataReader.GetValue(2).ToString(),
                    Image = dataReader.GetValue(3).ToString(),
                };

                cars.Add(Car);
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return cars;
        }
    }
}