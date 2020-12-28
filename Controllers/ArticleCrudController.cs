using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppAPI.DBModel;
using WebAppAPI.Models;

namespace WebAppAPI.Controllers
{
    public class ArticleCrudController : ApiController
    {
        public IHttpActionResult getemp()
        {
            CyberDBEntities cm = new CyberDBEntities();
            var results = cm.tbl_ArticleUser.ToList();
            return Ok(results);
        }
    }
}
