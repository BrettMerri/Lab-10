using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Movie
    {
        private string Title;
        private string Category;

        public string MovieTitle
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }

        public string MovieCategory
        {
            get
            {
                return Category;
            }
            set
            {
                Category = value;
            }
        }
        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }
    }
}
