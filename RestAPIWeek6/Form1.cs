using RestAPILibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPIWeek6
{
    public partial class Form1 : Form
    {   
        readonly IMethodImplementation AddImplementation;

        //Constructs the form with an instance of IMethodImplementation 
        public Form1(IMethodImplementation addImplementation)
        {
            InitializeComponent();
            AddImplementation = addImplementation;

        }

        private void Loaded(object sender, EventArgs e)
        {
            try
            {
                // await GetApiData.MergePage();
            }

            catch (Exception)
            {
                MessageBox.Show("");
            }

        }

        //This button clears the textBox that displays the result
        private void clearBtn_click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        /*This handles the event that occurs when the GetUserNameWithHighestCommentCount
         * Method is called. it returns the result (which is a string to the textBox)
         */

        private void BtnHighest_click(object sender, EventArgs e)
        {
            try
            {

            textBox.Text = "The user with the Highest Comment Count is: \r\n" + AddImplementation.GetUsernameWithHighestCommentCount();
            }
            catch (Exception)
            {
                //catches any exception thrown
                MessageBox.Show("error");
            }


        }

        private void BtnActiveUsers_Click(object sender, EventArgs e)
        {


        }

        /* This class is responsible for taking the value gotten from the
         * Set Threshold textBox, converts to an int,uses this value as
         * a threshold and compares it with the values gotten from the
         * GetUsernamesSortedByRecordDate Method and return The Authors that match the criteria
         */
        private void BtnActiveThreshHold_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
            try
            {
                var name = AddImplementation.GetUsernames(Convert.ToInt32(textBoxActiveUsers.Text));
                for (var i = 0; i < name.Count; i++)
                {
                    //  textBox.Text += $"\r\n{name[i]}";
                    textBox.Text += name[i] + Environment.NewLine;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input Threshold");
            }

        }

        private void textBoxActiveUsers_TextChanged(object sender, EventArgs e)
        {

        }

        /* This class is responsible for taking the value gotten from the
         * dateTimePicker, converts to the unixTimeseconds format,uses this value as
         * a threshold and compare it with the values gotten from the
         * GetUsernamesSortedByRecordDate Method then return a list of
         * the Authors that match the criteria
         */
        private void Btn_RecordDate_Click(object sender, EventArgs e)
        {
            var theTime = this.datePicker.Value;
            DateTimeOffset offset = new DateTimeOffset(theTime);
            int threshold = (int)offset.ToUnixTimeSeconds();

            textBox.Text = string.Empty;
            try
            {
                var name = AddImplementation.GetUsernamesSortedByRecordDate(threshold);
                for (var i = 0; i < name.Count; i++)
                {
                    // print values gotten to the textBox and arrange them in new Lines(list format)
                    textBox.Text += name[i] + Environment.NewLine;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Input Threshold");
            }
        }
    }
    }
