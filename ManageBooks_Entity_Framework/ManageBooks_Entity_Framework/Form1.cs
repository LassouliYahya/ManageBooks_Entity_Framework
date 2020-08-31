using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBooks_Entity_Framework
{
    public partial class Form1 : Form
    {
        BooksManagementEntities BME = new BooksManagementEntities();
        Category c = new Category();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BME.Category.ToList();
            BME.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            c.nameCategory = textBox1.Text;
            BME.Category.Add(c);
            BME.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = BME.Category.ToList();
            //BME.SaveChanges();
        }
    }
}
