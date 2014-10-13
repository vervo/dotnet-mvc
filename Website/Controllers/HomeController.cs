using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Dapper;
using Website.Connections;
using Website.Data.Entities;
using Website.Models;
using Website.Models.Home;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            using (var connection = new MyDbConnection().Open())
            {
                var users = connection.Query<Users>(
                    sql: @"SELECT * FROM Users;"
                ).ToList();

                var viewModel = new IndexViewModel
                {
                    Name = "Blah",
                    Users = users
                };

                return View(viewModel);
            }
        }
    }
}