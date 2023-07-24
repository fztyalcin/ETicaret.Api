using ETicaret.Api;
using ETicaret.Model;
using ETicaret.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Repository
{
    public class KullaniciRepository : RepositoryBase <Kullanici>
    {
        public KullaniciRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
