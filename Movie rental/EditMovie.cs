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
    public partial class EditMovie : Form
    {
        int id;
        DBconnection dbc1;
        string movieNameCurrent;

        public EditMovie(string nameM)
        {
            movieNameCurrent = nameM;
            InitializeComponent();
        }

        private void txt_movieName_Click(object sender, EventArgs e)
        {
            txt_movieName.Text = "";
            txt_movieName.ForeColor = System.Drawing.Color.Black;
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

        private void EditMovie_Load(object sender, EventArgs e)
        {
            cmb_genre.Enabled = false;
            txt_movieName.Text = movieNameCurrent;
            dbc1 = new DBconnection();
            AutoCompleteStringCollection at1 = dbc1.dataLoadToSuggestion("movie_name", "movie");
            txt_movieName.AutoCompleteCustomSource = at1;


            Movie movie = new Movie();
            movie = movie.searchMovie(movieNameCurrent);

            id = movie.Movie_Id;
            txt_movieName.Text = movie.Movie_Name;
            cmb_genre.SelectedItem = movie.Genre;
            txt_price.Text = movie.Price.ToString();
            txt_noCopies.Text = movie.No_Of_Copies.ToString();


        }

        private void txt_movieName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                int bol = 0;
                foreach (String s in txt_movieName.AutoCompleteCustomSource)
                {
                    if (s.Equals(txt_movieName.Text))
                    {
                        bol = 1; break;
                    }
                }

                if (txt_movieName.Text == movieNameCurrent)
                    bol = 0;


                if (bol == 0)
                {
                    {
                        txt_movieName.Enabled = false;
                        cmb_genre.Enabled = true;
                        txt_price.Enabled = true;
                        txt_noCopies.Enabled = true;
                    }
                }
                else if (bol == 1)
                {

                    MessageBox.Show("Updated movie name already exists");
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (txt_movieName.Text != "")
            {
                if (cmb_genre.SelectedIndex != -1)
                {
                    if ( txt_price.Text != "")
                    {
                        if (Convert.ToDouble(txt_price.Text) > 0)
                        {
                            if ( txt_noCopies.Text != "")
                            {
                                if (Convert.ToDouble(txt_noCopies.Text) > 0)
                                {
                                    Movie movie = new Movie();
                                    movie.Movie_Id = id;
                                    movie.Movie_Name = txt_movieName.Text;
                                    movie.Genre = cmb_genre.SelectedItem.ToString();
                                    movie.Price = Convert.ToDouble(txt_price.Text);
                                    movie.No_Of_Copies = Convert.ToInt32(txt_noCopies.Text);

                                    int editReturn = movie.editMovie();
                                    //MessageBox.Show("" + editReturn);

                                    if (editReturn == 0)
                                    {
                                        MessageBox.Show("Wrong Information", "Warning");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Updated Succesfully", "Sucessful");
                                    }
                                }
                                
                            }

                            else
                            {
                                txt_noCopies.Text = "Invalid no of copies";
                                txt_noCopies.ForeColor = System.Drawing.Color.Red;
                            }
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

