using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    internal class Desciption
    {
        private string country;
        private string spicy;
        private string language;

        public Desciption(string country, string spicy, string language)
        {
            this.country = country;
            this.spicy = spicy;
            this.language = language;
        }
        public void setCountry(string country)
        {
            this.country = country;
        }
        public string getCountry()
        {
            return this.country;
        }
        public void setSpicy(string spicy)
        {
            this.spicy = spicy;
        }
        public string getSpicy()
        {
            return this.spicy;
        }
        public void setLanguage(string language)
        {
            this.language = language;
        }
        public string getLanguage()
        {
            return this.language;
        }
        
    }
}
