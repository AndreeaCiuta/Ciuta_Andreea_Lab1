using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciuta_Andreea_Lab11.Models;

namespace Ciuta_Andreea_Lab11.Data
{
    public class Ciuta_Andreea_Lab11Context : DbContext
    {
        public Ciuta_Andreea_Lab11Context (DbContextOptions<Ciuta_Andreea_Lab11Context> options)
            : base(options)
        {
        }

        public DbSet<Ciuta_Andreea_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
