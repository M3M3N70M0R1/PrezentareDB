using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //Permite folosirea bazei de date

namespace PrezentareDB
{
    public partial class Form1 : Form
    {
        SqlConnection conn; //Declararea conexiunii

        public Form1()
        {
            InitializeComponent();

            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;Integrated Security=True;Connect Timeout=30 "; //stringul de conexiune luat din proprietatile bazei de date
            conn = new SqlConnection(ConnectionString); //initializarea conexiunii

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string commnad = "INSERT INTO Users(Nume, Prenume, NrTel) VALUES( " + Nume.Text + "," + Prenume.Text + "," + NrTel.Text + ");"; // ASA NU
                string command = "INSERT INTO Users(Nume, Prenume, NrTel) VALUES (@nume, @prenume, @nrtel);"; // ASA DA
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@nume", Nume.Text);
                cmd.Parameters.AddWithValue("@prenume", Prenume.Text);
                cmd.Parameters.AddWithValue("@nrtel", NrTel.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AflaNume_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT Nume FROM Users WHERE Id = @id;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", Id.Text);

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Nume.Text = rdr.GetString(0);
                }

                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AflaPrenume_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT Prenume FROM Users WHERE Id = @id;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", Id.Text);

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Prenume.Text = rdr.GetString(0);
                }

                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AflaNumar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT NrTel FROM Users WHERE Id = @id;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", Id.Text);

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    NrTel.Text = rdr.GetInt64(0).ToString();
                }

                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stergere_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "DELETE FROM Users WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", Id.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succes!");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifNume_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "UPDATE Users SET Nume = @nume WHERE Id = @id;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@nume", Nume.Text);
                cmd.Parameters.AddWithValue("@id", Id.Text);
                cmd.ExecuteNonQuery ();

                MessageBox.Show("Succes!");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CautaId_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT * FROM Users WHERE Id = @id;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@id", IdCauta.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                DBView.DataSource = table;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CautaNume_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT * FROM Users WHERE Nume = @nume;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@nume", NumeCauta.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                DBView.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CautaPrenume_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT * FROM Users WHERE Prenume = @prenume;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@prenume", PrenumeCauta.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                DBView.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CautaTel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT * FROM Users WHERE NrTel = @tel;";
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@tel", TelCauta.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                DBView.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CautaTot_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string command = "SELECT * FROM Users;";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                DBView.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
