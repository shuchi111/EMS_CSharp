SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=employeedb;Integrated Security=True");
con.Open();
SqlCommand cnn = new SqlCommand("UPDATE emptab SET employeename=@employeename,dob=@dob,email=@email,address=@address,salary=@salary WHERE empid=@empid", con);
cnn.Parameters.AddWithValue("@EmpId", int.Parse(textBox1.Text));
cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
cnn.Parameters.AddWithValue("@Email", textBox3.Text);
cnn.Parameters.AddWithValue("@Address", textBox4.Text);
cnn.Parameters.AddWithValue("@Salary", textBox5.Text);
cnn.ExecuteNonQuery();
con.Close();
MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
