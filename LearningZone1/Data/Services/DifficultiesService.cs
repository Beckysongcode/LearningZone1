using LearningZone1.Data.Base;
using LearningZone1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningZone1.Data.Services
{
    public class DifficultiesService:EntityBaseRepository<Difficulty>, IDifficultiesService
    {
        public DifficultiesService(AppDbContext context) : base(context)
        {
        }
    }
}
