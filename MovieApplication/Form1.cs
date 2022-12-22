using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApplication
{
    
    public partial class Form1 : Form
    {
        BusinessManager movie = new BusinessManager(10);
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie m = new Movie(dateTimePicker1.Value.Year, textBox1.Text);
            Desciption d = new Desciption(comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString(),textBox5.Text);
            bool check = movie.Add(textBox1.Text.ToUpper(), d, m);
            if (check)
            {
                MessageBox.Show("Successfully added!","Add",MessageBoxButtons.OKCancel);
                textBox1.Text = "";
                comboBox1.SelectedIndex = 1;
                dateTimePicker1.Value = DateTime.Today;
                textBox5.Text = "";
                comboBox2.Text = "";
                richTextBox2.Text = movie.listMovies();
            }
            else
                MessageBox.Show("Error!");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int inx = movie.searchMovie(textBox2.Text.ToUpper());
            if(inx == -1)
            {
                MessageBox.Show("There is no movie named this entity");
            }
            else
            {
                MessageBox.Show(movie.movies[inx].description.getCountry() + " "
                    + movie.movies[inx].description.getLanguage() + " "
                    + movie.movies[inx].movie.getProducerName() + " " +
                    movie.movies[inx].movie.getYear());

            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int flag = movie.deleteMovie(textBox4.Text.ToUpper());
            if (flag == -1)
            {
                MessageBox.Show("There is no movie named this entity");
            }
            else
            {
                MessageBox.Show("Successfully Deleted!!", "Delete", MessageBoxButtons.OK);
                richTextBox2.Text = movie.listMovies();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Turkey");
            comboBox1.Items.Add("France");
            comboBox1.Items.Add("ABD");
            comboBox1.Items.Add("Korean");
            comboBox1.Items.Add("Japan");
            comboBox1.Items.Add("Spain");

            comboBox2.Items.Add("Horror");
            comboBox2.Items.Add("Drama");
            comboBox2.Items.Add("Adventure");
            comboBox2.Items.Add("Sci-Fi");
            comboBox2.Items.Add("Comedy");
        }
    }
}
