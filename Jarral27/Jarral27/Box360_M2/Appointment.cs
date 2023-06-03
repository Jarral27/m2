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
    public partial class Appointment : Form
    {
        private string bookingID,clientID, classID, bookingDate, status, type, venue;
        public Appointment()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBox360.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dsBox360.Class);
            // TODO: This line of code loads data into the 'dsBox360.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dsBox360.Client);
            // TODO: This line of code loads data into the 'dsBox360.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.dsBox360.Booking);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            bookingTableAdapter.FillByDate(dsBox360.Booking, monthCalendar1.SelectionRange.Start.ToString());
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByLastName(dsBox360.Client, txtSearchClient.Text);
        }

        private void txtSearchClient2_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByLastName(dsBox360.Client, txtSearchClient.Text);
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            dsBox360.Booking.Rows[dgvBooking2.CurrentRow.Index].Delete();
            this.bookingTableAdapter.Fill(this.dsBox360.Booking);
        }

        private void dgvClient2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            classTableAdapter.FillByClassType(dsBox360.Class, txtSearchClass.Text);
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            bookingID = generateBookID();
            bookingDate = monthCalendar1.SelectionRange.Start.ToString();
            status = cmbStatus.Text;
            venue = txtVenue.Text;

            bookingTableAdapter.InsertBooking(bookingID, clientID, classID, bookingDate, status, type, venue);
            this.bookingTableAdapter.Fill(this.dsBox360.Booking);
        }

        private void dgvClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            clientID = Convert.ToString(dgvClient[0, row].Value);
        }

        private void dgvClass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            classID = Convert.ToString(dgvClass[0, row].Value);
            type = Convert.ToString(dgvClass[3, row].Value);
        }

        private string generateBookID()
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
                foreach (DataGridViewRow row in dgvBooking.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            return "BK" + id;
        }

        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }


    }
}
