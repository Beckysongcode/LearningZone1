using Microsoft.EntityFrameworkCore;
using s4587831Milestone3.Data.Base;
using s4587831Milestone3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Data.Services
{
    public class TeachersService : EntityBaseRepository<Teacher>, ITeachersService
    {
        public TeachersService(AppDbContext context) : base(context) { }
    }
}
