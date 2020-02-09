using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieModel
    {
        private int _id;

        [Key]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private int _releaseYear;

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }



        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _origin_ethinicity;

        public string OriginEthinicity
        {
            get { return _origin_ethinicity; }
            set { _origin_ethinicity = value; }
        }

        private string _director;

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        private string _cast;

        public string Cast
        {
            get { return _cast; }
            set { _cast = value; }
        }

        private string _genre;

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private string _wiki_page;

        public string WikiPage
        {
            get { return _wiki_page; }
            set { _wiki_page = value; }
        }

        private string _plot;

        public string Plot
        {
            get { return _plot; }
            set { _plot = value; }
        }
    }
}
