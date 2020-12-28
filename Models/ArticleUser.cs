using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppAPI.Models
{
    public class ArticleUser
    {
        public int id { get; set; }
        public string ArticleName { get; set; }
        public string ArticleTitle{ get; set; }
        public string ArticleSubtitle { get; set; }
        public string ArticleDes { get; set; }
    }
}