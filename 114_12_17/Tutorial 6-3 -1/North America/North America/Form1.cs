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

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
              string fileName; // To hold the filename
            // Get the filename from the user.
             fileName = GetFileName();
            // Get and display the countries.
            GetCountries(fileName);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
        // 將 GetFileName 方法的回傳型別由 void 改為 string，並回傳 fileName
        private string GetFileName()
        {
            string fileName; // To hold the filename
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get the filename.
                fileName = openFile.FileName;
            }
            else
            {
                // Set filename to an empty string.
                fileName = string.Empty;
            }
            return fileName;
        }

        private void GetCountries(string filename)
        {
            string country; // To hold a country name
           
            // Clear the list box.
            countriesListBox.Items.Clear();
            // Check if a filename was provided.
            if (filename != string.Empty)
            {
                StreamReader inputFile = File.OpenText(filename);
                
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
                // Close the file.
                inputFile.Close();
            }
            else
            {
                // Open the file.
                
                MessageBox.Show("未選取任何檔案。","錯誤");

            }
        }
    }
}
