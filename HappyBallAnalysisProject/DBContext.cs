using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyBallAnalysisProject.Data;

namespace HappyBallAnalysisProject
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
            // Debug.WriteLine($"{ContextId} context created.");
        }
        public DbSet<NumbersStatistics> NumbersStatistics { get; set; }
        public DbSet<WiningRecord> WiningRecords { get; set; }
        public DbSet<PrintParameter> PrintParameter { get; set; }

    }
}
