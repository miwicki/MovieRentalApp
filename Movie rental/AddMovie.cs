using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_rental
{
    public partial class AddMovie : Form
    {
        customerSearch c1;
        DBconnection db;
        public AddMovie(String mName)
        {
            InitializeComponent();
            txt_movieName.Text = mName;
            
        }

        private void txt_movieName_Click(object sender, EventArgs e)
        {
            txt_movieName.Text = "";
            txt_movieName.ForeColor = System.Drawing.Color.Black;

        }

        private void txt_genre_Click(object sender, EventArgs e)
        {
            cmb_genre.Text = "";
            cmb_genre.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_price_Click(object sender, EventArgs e)
        {          
            txt_price.Text = "";
            txt_price.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_noCopies_Click(object sender, EventArgs e)
        {           
            txt_noCopies.Text = "";
            txt_noCopies.ForeColor = System.Drawing.Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MovieRental m1 = new MovieRental();
            m1.Show();
            this.Hide();
        }

        private void txt_movieName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                foreach (String s in txt_movieName.AutoCompleteCustomSource)
                {
                    if (s.Equals(txt_movieName.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Movie name you entered is already exists", "Warnning");
                    }
                }

            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_movieName.Text != "")
            {
                if (cmb_genre.SelectedIndex != -1)
                {
                    if ( txt_price.Text != "")
                    {
                        if (Convert.ToDouble(txt_price.Text) > 0)
                        {
                            if (txt_noCopies.Text != "")
                            {
                                if (Convert.ToDouble(txt_noCopies.Text) > 0)
                                {
                                    Movie movie = new Movie();
                                    movie.Movie_Name = txt_movieName.Text;
                                    movie.Genre = cmb_genre.SelectedItem.ToString();
                                    movie.Price = Convert.ToDouble(txt_price.Text);
                                    movie.No_Of_Copies = Convert.ToInt32(txt_noCopies.Text);

                                    int addReturn = movie.addMovie();


                                    if (addReturn != 0)
                                    {
                                        MessageBox.Show("Movie details added Succesfully", "Registered");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error", "Error");
                                        c1 = new customerSearch();
                                        c1.Show();
                                        this.Hide();
                                    }
                                }
                                
                            }
                        }
                        

                        else
                        {
                            txt_noCopies.Text = "Invalid no of copies";
                            txt_noCopies.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else
                    {
                        txt_price.Text = "Invalid Price";
                        txt_price.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Please select movie genre");

                }
            }
            else
            {
                txt_movieName.Text = "Please enter movie name";
                txt_movieName.ForeColor = System.Drawing.Color.Red;
            }
        

        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

            
            db = new DBconnection();
            AutoCompleteStringCollection at1 = db.dataLoadToSuggestion("movie_name", "movie");//Autocomplete movie input text box with all existing movies
            txt_movieName.AutoCompleteCustomSource = at1;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {

            txt_movieName.Text = "";
            cmb_genre.SelectedIndex = -1;
            txt_price.Text = "";
            txt_noCopies.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
