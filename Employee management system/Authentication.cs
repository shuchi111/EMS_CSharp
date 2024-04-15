SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=databasename;Integrated Security=True");
con.Open();
string username = txtUsername.Text;
string password = txtPassword.Text;
SqlCommand cnn = new SqlCommand("SELECT UserName,Password FROM logintab WHERE UserName='" + txtUsername.Text + "'AND Password='" + txtPassword.Text + "'", con);
SqlDataAdapter da = new SqlDataAdapter(cnn);
DataTable dt = new DataTable();
da.Fill(dt);
if (dt.Rows.Count > 0)
{
    // Authentication successful
    Main mn = new Main();
    mn.Show();
}
else
{
    MessageBox.Show("Invalid username and password");
}
con.Close();
