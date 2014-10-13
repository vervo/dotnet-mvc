using System.Collections.Generic;
using System.Web.UI.WebControls.Expressions;
using Website.Data.Entities;

namespace Website.Models
{
    public class IndexViewModel
    {
     
        public string Name { get; set; }
        public List<Users> Users { get; set; }
         
    }
}