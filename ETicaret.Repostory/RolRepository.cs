using ETicaret.Model;
using ETicaret.Repsitory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class RolRepository : RepositoryBase <Rol>
    {
        public RolRepository(RepositoryContext context) : base (context)
        {
        }
    }
}
