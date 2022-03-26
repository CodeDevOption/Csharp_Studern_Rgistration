using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Student_Registation
{
    public partial class RegisterForm : MaterialForm
    {


        DBconnection con = new DBconnection();
        MySqlDataAdapter mad;
        MySqlCommand command;
        
        //Globle Variables
        int student_id ;
       
        public RegisterForm()
        {

            InitializeComponent();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            try
            {
                con.connect();
                con.cn.Open();
                TableLoad();
                con.cn.Close();
            }
            catch
            {
                MessageBox.Show("Datbase Connection Filead", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800,Primary.Blue900,Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);



        }


        // Save Data  in Database 

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Variables 
            string name = TextBoxName.Text;
            string course = TextBoxCourse.Text;
            string fee = TextBoxFee.Text;

            // Check Value is Not Empty

            if (!name.Equals("") && !course.Equals("") && !fee.Equals("")) 
            {


                try
                {
                    con.cn.Open();
                    string sqlquery = "INSERT INTO school.registeruser(Student_Name,Course,Fee) VALUES('" + name + "','" + course + "','" + fee + "')";
                   command = new MySqlCommand(sqlquery, con.cn);

                    mad = new MySqlDataAdapter(command);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Ditails Saved Sucsessfuly");
                        TextBoxName.Text = "";
                        TextBoxCourse.Text = "";
                        TextBoxFee.Text = "";
                    }

                    TableLoad();
                    con.cn.Close();
                }
                catch
                {
                    MessageBox.Show("Data Save  Filead", "error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

             

            }
            else
            {
                MessageBox.Show("Empty Values ReEnter Values");
            }

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["Student_ID"].Value.ToString();
                student_id = int.Parse(id);
                TextBoxName.Text = row.Cells["Student_Name"].Value.ToString();
                TextBoxCourse.Text = row.Cells["Course"].Value.ToString();
                TextBoxFee.Text = row.Cells["Fee"].Value.ToString();
             
        
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                
                if (!student_id.Equals(""))
                    {
                          string name = TextBoxName.Text;
                          string course = TextBoxCourse.Text;
                          string fee = TextBoxFee.Text;
                          con.cn.Open();
                          command = new MySqlCommand("UPDATE school.registeruser SET Student_Name= '" + name + "',Course='" + course + "',Fee='" + fee + "' WHERE Student_ID = '" + student_id + "' ", con.cn);
                          command.ExecuteNonQuery();
                          MessageBox.Show("Data Has Been Updated");
                          TableLoad();
                          con.cn.Close();
                    }
            }
                catch
                {
                    MessageBox.Show("Data Update  Filead ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
       
               
     


            
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

    
               
                if (!student_id.Equals(""))
                {
                 con.cn.Open();
                    if (MessageBox.Show("Do You Want To Delete This Data", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                    try
                    {


                        command = new MySqlCommand("DELETE FROM school.registeruser WHERE Student_ID = '" + student_id + "'", con.cn);
                                        command.ExecuteNonQuery();
                                        TableLoad();
                                        clean();
                                        con.cn.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Data Delete  Filead ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
             

            }

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            clean();
        }

        //============== My_Methods ==================================

       // Clean Method
        public void clean()
        {
            TextBoxName.Text = "";
            TextBoxCourse.Text = "";
            TextBoxFee.Text = "";
        }

        //============================================================

        //Table Load Method
        public void TableLoad()
        {
            mad = new MySqlDataAdapter("SELECT * FROM school.registeruser", con.cn);
            DataSet ds = new DataSet();
            mad.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"];
        }

    }
}
