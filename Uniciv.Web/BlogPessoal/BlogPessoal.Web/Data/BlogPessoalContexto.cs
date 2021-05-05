using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data
{
    public class BlogPessoalContexto : DbContext
    {
        public BlogPessoalContexto():base(typeof(BlogPessoalContexto).Name)
        {

        }
    }
}