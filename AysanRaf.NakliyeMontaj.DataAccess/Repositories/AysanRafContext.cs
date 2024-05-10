using AysanRaf.NakliyeMontaj.Entites.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.DataAccess.Repositories
{
    public class AysanRafContext : DbContext
    {
        public AysanRafContext(DbContextOptions<AysanRafContext> options) : base(options)
        {
        }

        // DbSet'ler buraya eklenecek
   
        public DbSet<PlannedOfferForm> PlannedOfferForms { get; set; }
        public DbSet<RealizedOfferForm> RealizedOfferForms { get; set; }
        public DbSet<RentedEquipment> RentedEquipments { get; set; }
    }
}


