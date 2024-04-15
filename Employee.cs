
          Save Code

          SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into emptab values(@empid,@employeename,@dob,@email,@address,@salary)", con);
            cnn.Parameters.AddWithValue("@EmpId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Email", textBox3.Text);
            cnn.Parameters.AddWithValue("@Address", textBox4.Text);
            cnn.Parameters.AddWithValue("@Salary", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);



          Add Code

          SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from emptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;





          Update Code


          SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("update emptab set employeename=@employeename,dob=@dob,email=@email,address=@address,salary=@salary where empid=@empid", con);
            cnn.Parameters.AddWithValue("@EmpId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
            cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Email", textBox3.Text);
            cnn.Parameters.AddWithValue("@Address", textBox4.Text);
            cnn.Parameters.AddWithValue("@Salary", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);





          Delete Code


          SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete emptab where empid=@empid", con);
            cnn.Parameters.AddWithValue("@EmpId", int.Parse(textBox1.Text));
            
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
