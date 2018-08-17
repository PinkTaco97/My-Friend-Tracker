using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace My_Friend_Tracker
{
    /// <summary>
    /// The Upcoming Birthdays Form Class
    /// </summary>
    public partial class Form3 : Form
    {
        /// <summary>
        /// Referance to the main form.
        /// </summary>
        private Form1 form;

        /// <summary>
        /// A List to hold all the months
        /// </summary>
        private List<Month> months = new List<Month>();

        /// <summary>
        /// The current Month
        /// </summary>
        private int currentmonth = 0;

        /// <summary>
        /// The DataTable
        /// </summary>
        DataTable dataTable = new DataTable();

        /// <summary>
        /// Constructor
        /// </summary>
        public Form3(Form1 form)
        {
            //Initialize the form.
            InitializeComponent();

            //Set the form.
            this.form = form;

            //Hide the form.
            form.Hide();

            //Initialize the months.
            InitializeMonths();

            //For each of the columns in the Data View
            foreach (DataGridViewColumn column in data.Columns)
            {
                //Make them not sortable.
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 172;
            }

        }

        /// <summary>
        /// Setup the List of months.
        /// </summary>
        private void InitializeMonths()
        {
            //Add the months to the list.
            months.Add(new Month("January"));
            months.Add(new Month("Febuary"));
            months.Add(new Month("March"));
            months.Add(new Month("April"));
            months.Add(new Month("May"));
            months.Add(new Month("June"));
            months.Add(new Month("July"));
            months.Add(new Month("August"));
            months.Add(new Month("September"));
            months.Add(new Month("October"));
            months.Add(new Month("November"));
            months.Add(new Month("December"));

            //For each of the friends.
            for (int i = 0; i < form.friends.Count; i++)
            {
                string[] date = form.friends[i].dob.Split('/');
                int month = Convert.ToInt32(date[1]);
                months[(month - 1)].friends.Add(form.friends[i]);
            }

            //months[8].PrintAll();
            CreateTable();
        }

        /// <summary>
        /// Called when the form is closing.
        /// </summary>
        private void Form3_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the form.
            form.Show();
        }

        /// <summary>
        /// Create the DataTable.
        /// </summary>
        private void CreateTable()
        {
            //Add the columns.
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Likes");
            dataTable.Columns.Add("Dislikes");
            dataTable.Columns.Add("Date of Birth");

            //Set the datagrids datasource.
            data.DataSource = dataTable;

            //Load the friends into the table.
            LoadTable(currentmonth);
        }

        /// <summary>
        /// Load the friends into the table.
        /// </summary>
        private void LoadTable(int month)
        {
            //Clear the datatable.
            dataTable.Clear();

            //Show the name of the month.
            Month_Text.Text = months[month].name;

            //The row for the datatable.
            DataRow row;

            //For each of friends
            for (int i = 0; i < months[month].friends.Count; i++)
            {
                //Create a new row.
                row = dataTable.NewRow();

                //Add the data to the row.
                row[0] = months[month].friends[i].name;
                row[1] = months[month].friends[i].likes;
                row[2] = months[month].friends[i].dislikes;
                row[3] = months[month].friends[i].dob;

                //Add the row to the datatable.
                dataTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Called when the next button is clicked
        /// </summary>
        private void Next_Btn_Click(object sender, EventArgs e)
        {
            //Update the currentmonth.
            if (currentmonth <= 10)
            {
                currentmonth++;
            }
            else
            {
                currentmonth = 0;
            }

            //Load the table.
            LoadTable(currentmonth);
        }

        /// <summary>
        /// Called when the previous button is clicked
        /// </summary>
        private void Previous_Btn_Click(object sender, EventArgs e)
        {
            //Update the currentmonth.
            if (currentmonth >= 1)
            {
                currentmonth--;
            }
            else
            {
                currentmonth = 11;
            }

            //Load the table.
            LoadTable(currentmonth);
        }
    }
}
