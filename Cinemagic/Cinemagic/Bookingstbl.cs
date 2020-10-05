using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Cinemagic
{   

    public partial class Bookingstbl : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Documents\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter ds;
        String sql;
        DataTable dt;

        public Bookingstbl()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {   

            SqlConnection con;
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Documents\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();

            MessageBox.Show("Connection Open!");

            con.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Documents\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");
           
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = ("INSERT INTO BOOKING(Movie_ID, Customer_ID, Total_TicketCost, NumberOfSeats, Tickets_SaleDate) VALUES('"+txtmovie.Text+"','"+txtcustomer.Text+"','" + txtcost.Text + "','" + txtseats.Text + "','" + sale.Value.ToShortDateString() + "'); ");
            command.ExecuteNonQuery();
          
            con.Close();

            MessageBox.Show("Data has been save to the database");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Documents\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM BOOKING  WHERE Booking_ID ='" + txtbookings.Text + "'"; 
            command.ExecuteNonQuery();
            
            con.Close();
            
            MessageBox.Show("Data has been deleted off the database");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Documents\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update BOOKING SET Movie_ID = '"+txtmovie.Text+"', Customer_ID '" +txtcustomer.Text+"',Total_TicketCost='" + txtcost.Text + "', NumberOfSeats='" + txtseats.Text + "', Tickets_SaleDate='" + sale.Value.ToShortDateString() + "' WHERE Booking_ID='"+txtbookings.Text+"'";
            command.ExecuteReader();
           
           
            con.Close();
            
            MessageBox.Show("The data you have selected has been updated.");


        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con;
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Derick\Documents\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf; Integrated Security = True";
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter ds = new SqlDataAdapter();

           
            con = new SqlConnection(connectionString);
 
            ds = new SqlDataAdapter("SELECT * FROM BOOKING", con);
            dt = new DataTable();
            ds.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
