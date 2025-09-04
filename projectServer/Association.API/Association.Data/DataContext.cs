using Association.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Cities> CitiesDb { get; set; }
        public DbSet<Donation> DonationDb { get; set; }
        public DbSet<DonationType> DonationTypeDb { get; set; }
        public DbSet<Donor> DonorDb { get; set; }
        public DbSet<keren> KerenDb { get; set; }


        //public List<Cities> Lessons { get; set; }
        //public List<Cities> Cities { get; }
        //public List<Donation> Donation { get; set; }
        //public List<DonationType> DonationTypes { get; set; }
        //public List<Donor> Donor { get; set; }
        //public List<keren> keren { get; set; }


       //public DataContext() {
       //     Cities = new List<Cities> { new Cities { Id = 0, CityName="holon" } };
       //     Donation = new List<Donation> { new Donation { Id = 0, Type = 1, NumberOfBeats = 1, Donor=1, AmountPerBeat = 2, Keren=2 } };
       //     DonationTypes = new List<DonationType> { new DonationType { Id=0, NameType = "אשראי" } };
       //     Donor = new List<Donor> { new Donor {Id=0, City="tel-aviv", Tz="22555", Email = "@gmail.com", FirstName = "ruti", LastName = "Aslan", PhoneMumber="0524670523" } };
       //     keren = new List<keren> { new keren { Id=0, CatalogNumber=12, Description="nice", Percent=25, Target=10000b } };
       // }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Association_db");
        }



    }
}
