using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_rental
{
    class Movie
    {
        int movie_Id;
        String movie_Name;
        String genre;
        int no_Of_Copies;
        double price;

        public int Movie_Id
        {
            get { return movie_Id; }
            set { movie_Id = value; }
        }


        public String Movie_Name
        {
            get { return movie_Name; }
            set { movie_Name = value; }
        }

        public String Genre
        {
            get { return genre; }
            set { genre = value; }
        }


        public int No_Of_Copies
        {
            get { return no_Of_Copies; }
            set { no_Of_Copies = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int addMovie()
        {
            DBconnection db = new DBconnection();
            int addReturn = db.addMovie(this);
            return addReturn;
        }

        public int editMovie()
        {
            DBconnection db = new DBconnection();
            int editreturn = db.editMovie(this);
            return editreturn;
        } 

        public Movie searchMovie(String name)
        {
            DBconnection db = new DBconnection();
            return db.searchMovie(name);
        } 


    }
}
