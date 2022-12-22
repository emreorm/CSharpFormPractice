using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    internal class Movie
    {
        
        private int year;
        private string producerName;

        public Movie( int year, string producerName)
        {
            
            
            this.year = year;
            this.producerName = producerName;
        }

       
        
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return this.year;
        }
        public void setProducerName(string producerName)
        {
            this.producerName = producerName;
        }
        public string getProducerName()
        {
            return this.producerName;
        }


    }
}
