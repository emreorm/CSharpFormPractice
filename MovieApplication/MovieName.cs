using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    internal class MovieName
    {
        private string name;
        public Desciption description;
        public Movie movie;

        public MovieName(string name, Desciption description, Movie movie)
        {
            this.name = name;
            this.description = description;
            this.movie = movie;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

    }
}
