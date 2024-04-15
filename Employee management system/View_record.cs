SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");
con.Open();
SqlCommand cnn = new SqlCommand("SELECT * FROM emptab", con);
SqlDataAdapter da = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
da.Fill(dt);
dataGridView1.DataSource = dt;
