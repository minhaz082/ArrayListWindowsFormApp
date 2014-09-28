using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppArraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList nameArrayList = new ArrayList();
        string employeeName;
        
        private void addButton_Click(object sender, EventArgs e)
        {
            employeeName = nameTextBox.Text;           
            nameArrayList.Add(employeeName);
            nameTextBox.Clear();
            //MessageBox.Show("Data Successfully Added");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            int nameSerial = 1; 
            foreach (var item in nameArrayList)
            {               
                nameListBox.Items.Add(nameSerial + ". " + item);
                ++nameSerial;

            }
            totalTextBox.Text = nameListBox.Items.Count.ToString();
            
        }

        
    }
}
