using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookStore
{
    class services
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tsire\Desktop\BookStore\BookStore\DB.mdf;Integrated Security=True");
        SqlCommand sc;
        SqlDataAdapter DtAdapter;

        public DataTable getTable(string tableName)
        {
            connection.Open();
            DataTable DT = new DataTable();
            DtAdapter = new SqlDataAdapter($"select * from {tableName}", this.connection);
            DtAdapter.Fill(DT);
            connection.Close();
            return DT;
        }

        public void insertBooks(String[] row)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"insert into Books(Title, Author, ISBN, Price) Values(@title, @author, @isbn, @price) ", this.connection);
            AddValueBooks(command, row);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void updateBooks(String[] row, int Id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Books set  Title= @title, Author = @author, ISBN = @isbn, Price = @price WHERE Id = @Id; ", this.connection);
            AddValueBooks(command, row);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void AddValueBooks(SqlCommand command, String[] row)
        {
            command.Parameters.AddWithValue("@title", row[0]);
            command.Parameters.AddWithValue("@author", row[1]);
            command.Parameters.AddWithValue("@isbn", row[2]);
            command.Parameters.AddWithValue("@price", row[3]);
        }

        public void insertCustomers(String[] row)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"insert into Customers(FirstName, LastName, Address, City, State, Zip, Phone, Email) Values(@FirstName, @LastName, @Address, @City, @State, @Zip, @Phone, @Email) ", this.connection);
            AddValueCustomers(command, row);
            command.ExecuteNonQuery();
            connection.Close();
        }
        

        public void updateCustomers(String[] row, int Id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Customers set  FirstName= @FirstName, LastName = @LastName, Address = @Address, City = @City, State= @State, Zip = @Zip, Phone = @Phone, Email = @Email WHERE Id = @Id; ", this.connection);
            command.Parameters.AddWithValue("@Id", Id);
            AddValueCustomers(command, row);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void AddValueCustomers(SqlCommand command, String[] row)
        {
            command.Parameters.AddWithValue("@FirstName", row[0]);
            command.Parameters.AddWithValue("@LastName", row[1]);
            command.Parameters.AddWithValue("@Address", row[2]);
            command.Parameters.AddWithValue("@City", row[3]);
            command.Parameters.AddWithValue("@State", row[4]);
            command.Parameters.AddWithValue("@Zip", row[5]);
            command.Parameters.AddWithValue("@Phone", row[6]);
            command.Parameters.AddWithValue("@Email", row[7]);
        }

        public void InsertOrders(String[] row)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"insert into Orders(CustomerID, Subtotal, Tax, Total) Values(@CustomerID, @Subtotal, @Tax, @Total) ", this.connection);
            AddValueOrders(command, row);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void AddValueOrders(SqlCommand command, String[] row)
        {
            command.Parameters.AddWithValue("@CustomerID", row[0]);
            command.Parameters.AddWithValue("@Subtotal", row[1]);
            command.Parameters.AddWithValue("@Tax", row[2]);
            command.Parameters.AddWithValue("@Total", row[3]);
        }
        public void InsertOrderDetails(String[] row)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"insert into OrderDetails(BookID, Quantity, LineTotal) Values( @BookID, @Quantity, @LineTotal) ", this.connection);
            AddValueOrderDetails(command, row);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void AddValueOrderDetails(SqlCommand command, String[] row)
        {
            command.Parameters.AddWithValue("@BookID", row[0]);
            command.Parameters.AddWithValue("@Quantity", row[1]);
            command.Parameters.AddWithValue("@LineTotal", row[2]);
        }

    }
}
