using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4DesignPatterns.Adapter
{
    public class AdapterExample
    {
        public static DataSet GetDataset()
        {
            var connection = new SqlConnection("[cnn string]");
            
            var command = new SqlCommand("[SQL Query]", connection);
            command.CommandType = CommandType.Text;
            
            var adapter = new SqlDataAdapter(command);

            var dataSet = new DataSet();
            adapter.Fill(dataSet);

            return dataSet;
        }
    }
}
