using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Movie_rental
{
    
    public partial class movieNameMsgBox : Form
    {
        DBconnection dbc1;
        EditMovie m1;
        ArrayList l1;
        AddMovie am1;
        MovieRental mr1;
        string mName;
        public movieNameMsgBox()
        {
            InitializeComponent();
        }

        private void movieNameMsgBox_Load(object sender, EventArgs e)
        {
            dbc1 = new DBconnection();
            AutoCompleteStringCollection at1 = dbc1.dataLoadToSuggestion("movie_name","movie");//Autocomplete movie input text box with all existing movies
            movieI.AutoCompleteCustomSource = at1;
        }

        private void movieI_Click(object sender, EventArgs e)
        {
            movieI.Text = "";
            movieI.TextAlign = HorizontalAlignment.Left;
            movieI.ForeColor = System.Drawing.Color.Black;
        }


        private void movieI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mName = movieI.Text;
                int bol = 0;
                string dbFilmName = "film";
                foreach (string s in movieI.AutoCompleteCustomSource)
                {
                    if (s.Equals(movieI.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        dbFilmName = s;
                        bol = 1;
                    }
                }
                if (bol == 1)//if movie existing in db
                {
                    dbc1 = new DBconnection();
                    l1 = dbc1.searchMovieDetaills(dbFilmName, "movie_data");
                    int val = Convert.ToInt32(l1[0].ToString());
                    if (val == 1)
                    {
                        label_movie.Text = movieI.Text;
                        label_genre.Text=l1[1].ToString();
                        label_copies.Text = "No of copies remaining : "+ l1[2].ToString();
                        label_price.Text  = "Price(Rs.)                  : "+ l1[3].ToString();
                        this.Height = 500;
                        button_del.Visible = true;//set on button's visibility
                        button_edit.Visible = true;//set on button's visibility
                        button_add.Visible = true;//set on button's visibility
                    }
                }
                else //if an unexisting movie
                {
                    
                    movieI.Text = "Unknown movie";
                    button_del.Visible = false;
                    button_edit.Visible = false;
                    movieI.TextAlign = HorizontalAlignment.Center;
                    movieI.ForeColor = System.Drawing.Color.Red;
                    this.Height = 300;
                    DialogResult s1 = MessageBox.Show("Do you want to add this movie into movie stock?", "Unknown movie", MessageBoxButtons.YesNo);
                    if (s1 == DialogResult.Yes)
                    {
                        am1 = new AddMovie(mName);
                        this.Hide();
                        am1.Show();
                    }
                }
                
            }
        }

        private void button_del_Click(object sender, EventArgs e)//Delete a movie
        {
            if (movieI.Text == "")
            {
                movieI.Text = "Enter a movie";
                movieI.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                DialogResult r1 = MessageBox.Show("Do you sure about this movie deletion?", "Warning", MessageBoxButtons.YesNo);
                if(r1== DialogResult.Yes){
                    dbc1 = new DBconnection();
                    dbc1.deleteMovie(movieI.Text);
                    movieNameMsgBox_Load(this, null);//reload form again to refresh auto complete 
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (movieI.Text == "")
            {
                movieI.Text = "Enter a movie";
                movieI.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                m1 = new EditMovie(movieI.Text);
                this.Hide();
                m1.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mr1 = new MovieRental();
            this.Hide();
            mr1.Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            am1 = new AddMovie(mName);
            this.Hide();
            am1.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "Back");
        }

       

    }
}
