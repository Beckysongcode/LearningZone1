using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningZone1.Data.Base;
using LearningZone1.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningZone1.Data.Services
{
    public class TeachersService : EntityBaseRepository<Teacher>, ITeachersService
    {
        public TeachersService(AppDbContext context) : base(context) { }
    }
}
