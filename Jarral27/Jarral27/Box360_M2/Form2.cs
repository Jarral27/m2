using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box360_M2
{
    public partial class ManageClass : Form
    {
        public ManageClass()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBox360.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.dsBox360.Coach);
            // TODO: This line of code loads data into the 'dsBox360.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dsBox360.Class);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            cmbUpdateGroup.Text = dbClass.CurrentRow.Cells[2].Value.ToString();
            cmbUpdateClass.Text = dbClass.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker3.Text = dbClass.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker4.Text = dbClass.CurrentRow.Cells[5].Value.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsBox360.Class.Rows[dbClass.CurrentRow.Index].Delete();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            classTableAdapter.FillByClassType(dsBox360.Class, textBox4.Text); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan startTime = dateTimePicker3.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker4.Value.TimeOfDay;

            classTableAdapter.UpdateClassType(cmbUpdateClass.Text, dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            classTableAdapter.UpdateGroupType(cmbUpdateGroup.Text, dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            classTableAdapter.UpdateStartTime(startTime.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            classTableAdapter.UpdateEndTime(endTime.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString(), dbClass.CurrentRow.Cells[0].Value.ToString());
            this.classTableAdapter.Fill(this.dsBox360.Class);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ClassID = txtClassID.Text;
            string CoachID = txtCoachID.Text;
            string GroupType = cmbGroupType.Text;
            string ClassType = cmbClassType.Text;

            TimeSpan startTime = dateTimePicker1.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker2.Value.TimeOfDay;
            int MaxCap = (int)SpinMax.Value;
            int CurrentCap = (int)SpinCurrent.Value;
            bool PublicClass = chkPublic.Checked;

           

            classTableAdapter.Insert(ClassID, CoachID, GroupType, ClassType, startTime, endTime, MaxCap, CurrentCap, PublicClass);
            this.classTableAdapter.Fill(this.dsBox360.Class);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string id = "";

            int colIndex = 0;
            bool bFound = false;
            bool isFound = false;

            while (bFound == false)
            {
                isFound = false;
                id = (random.Next(10000, 99999)).ToString();
                foreach (DataGridViewRow row in dbClass.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == "CL" + id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            txtClassID.Text = "CL" + id;
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtCoachID.Text = Convert.ToString(dbCoach [0, row].Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
