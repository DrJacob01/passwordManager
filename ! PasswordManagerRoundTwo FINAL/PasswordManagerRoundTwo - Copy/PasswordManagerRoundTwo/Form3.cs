using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerRoundTwo
{
    public partial class Form3 : Form
    {

        DataSet1TableAdapters.TableTableAdapter passAdpt = new DataSet1TableAdapters.TableTableAdapter();


        String currentID;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataSet1.Table);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            passAdpt.AddData(appTxt.Text, userTxt.Text, passTxt.Text);

            appTxt.Clear();
            userTxt.Clear();
            passTxt.Clear();
            appTxt.Focus();


            gridUpdate();

        }

        private void gridUpdate()
        {
            dataGridView1.DataSource = passAdpt.GetData();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // new empty copy of the table data
            PasswordManagerRoundTwo.DataSet1.TableDataTable DT = new DataSet1.TableDataTable();



            //Data from search TextBox
            string input = txtSearch.Text;



            currentID = "";



            // If input is registered
            if (input.Length > 0)
            {
                // Calls Query
                passAdpt.FindData(DT, input);



                // Refers to the data received
                DataRow DR = DT.NewRow();



                // Checking data exists
                if (DT.Rows.Count > 0)
                {
                    // Set TextBox to column data
                    DR = DT.Rows[0];
                    currentID = DR["Id"].ToString();
                    appTxt.Text = DR["ApplicationName"].ToString();
                    userTxt.Text = DR["Username"].ToString();
                    passTxt.Text = DR["Password"].ToString();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (currentID.Length > 0)
            {
                //Update Query to change existing data.
                passAdpt.UpdateData(appTxt.Text, userTxt.Text, passTxt.Text, int.Parse(currentID));

                //Clears Text boxes
                appTxt.Clear();
                userTxt.Clear();
                passTxt.Clear();
                currentID = "";

                txtSearch.Focus();

                //Updates data view.
                gridUpdate();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (currentID.Length > 0)
            {
                // Deletes Query
                passAdpt.DeleteData(int.Parse(currentID));

                //Clear Text Boxes
                appTxt.Clear();
                userTxt.Clear();
                passTxt.Clear();
                currentID = "";

                txtSearch.Focus();

                //Updates data view.
                gridUpdate();
            }
        }
    }
}
