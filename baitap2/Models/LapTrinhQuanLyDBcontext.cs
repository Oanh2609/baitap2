using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace baitap2.Models
{
    public partial class LapTrinhQuanLyDBcontext : DbContext
    {
        public LapTrinhQuanLyDBcontext()
            : base("name=LapTrinhQuanLyDBcontext")
        {
        }

        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
   
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
