using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gogglemaps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = streetTextbox.Text;
            string city = cityTextbox.Text;
            string state = stateTextbox.Text;
            string zipcode = zipcodeTextbox.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("https://www.google.com/maps/");

                if (street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }

                if (city != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }

                if (state != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }

                if (zipcode != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }

                webBrowser1.Navigate(queryData.ToString());

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
