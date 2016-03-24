using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DALNorthwind
    {
        string ConnectionString = "";
    
        public IEnumerable<Entities.Order> GetAll()
        {
            var result = new List<Entities.Order>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand("SELECT OrderID,OrderDate,ShippedDate from Orders");

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new Entities.Order
                            (
                                reader.GetInt32(0),
                                reader.GetDateTime(1),
                                reader.GetDateTime(2)
                            );
                        order.SetStatus();

                        result.Add(order);
                    }
                }

                return result;
            }
        }
    }
    }
