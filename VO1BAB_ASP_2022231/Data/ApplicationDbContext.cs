using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Cars> cars { get; set; }

        public DbSet<CarBrand> carbrand { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" }
                );
           
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            IdentityUser boss = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "katona@katona.com",
                EmailConfirmed = true,
                UserName = "katona@katona.com",
                NormalizedUserName = "KATONA@KATONA.COM"
            };

            boss.PasswordHash = ph.HashPassword(boss, "Katona11");
            builder.Entity<IdentityUser>().HasData(boss);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = boss.Id
            });


            builder.Entity<Cars>(x => x.HasOne(x => x.carbrand).WithMany(x => x.cars).HasForeignKey(x => x.CarBrandID).OnDelete(DeleteBehavior.Cascade));



            builder.Entity<CarBrand>().HasData(new CarBrand[]
            {
                new CarBrand("1,BMW"),
                new CarBrand("2,Mercedes-Benz"),
                new CarBrand("3,Ford"),
                new CarBrand("4,Skoda"),
                new CarBrand("5,Audi"),
                new CarBrand("6,Kia"),
                new CarBrand("7,Opel")
            });





            builder.Entity<Cars>().HasData(new Cars[]
            {
                //25 car 
                new Cars("1,1,E60,HFG-453,2004,310,https://www.netcarshow.com/Hamann-BMW_5er_E60_545i-2005-1280-01.jpg"),
                new Cars("2,2,CLS-63,SNK-955,2019,605,https://www.netcarshow.com/Mercedes-Benz-CLS63_AMG-2015-1280-07.jpg"),
                new Cars("3,3,Mondeo,JPK-245,2008,110,https://www.netcarshow.com/Ford-Mondeo-2011-1280-01.jpg"),
                new Cars("3,4,Mondeo,KLK-615,2009,130,https://www.netcarshow.com/Ford-Mondeo_Concept-2007-1280-03.jpg"),
                new Cars("4,5,Ocatavia,MIH-400,2014,150,https://www.netcarshow.com/Skoda-Octavia_Combi_RS-2014-1280-04.jpg"),
                new Cars("5,6,A3,P-55332,2016,150,https://www.netcarshow.com/Audi-A3_Sportback_e-tron-2017-1280-01.jpg"),
                new Cars("5,7,A3,P-55456,2016,150,https://www.netcarshow.com/Audi-A3_Sportback_e-tron-2017-1280-02.jpg"),
                new Cars("6,8,Ceed,SEZ-488,2016,190,https://www.netcarshow.com/Kia-Ceed_SW_GT-Line-2016-1280-01.jpg"),
                new Cars("4,9,Kodiaq,SBC-888,2018,200,https://www.netcarshow.com/Skoda-Kodiaq_Sportline-2018-1280-03.jpg"),
                new Cars("4,10,Superb,HCD-104,2010,200,https://www.netcarshow.com/Skoda-Superb_Combi_4x4-2010-1280-02.jpg"),
                new Cars("7,11,Astra,PET-555,2004,90,https://www.netcarshow.com/Vauxhall-Astra_VXR-2005-1280-02.jpg"),
                new Cars("4,12,Octavia,JKL-256,2004,80,https://www.netcarshow.com/Skoda-Octavia_Combi-2004-1280-12.jpg"),
                new Cars("1,13,530D,KCI-442,2011,190,https://www.netcarshow.com/BMW-M5_CS-2022-1280-01.jpg"),
                new Cars("2,14,CLA,ONS-875,2017,220,https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg"),
                new Cars("2,15,CLA,OCC-325,2017,220,https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg"),
                new Cars("2,16,CLA,OBS-432,2017,220,https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg"),
                new Cars("4,17,Octvia,PRS-564,2018,150,https://www.netcarshow.com/Skoda-Octavia_RS-2020-1280-01.jpg"),
                new Cars("5,18,E-TRON,AA-AA-343,2022,400,https://www.netcarshow.com/Audi-SQ8_e-tron_quattro-2024-1280-01.jpg"),
                new Cars("4,19,Kodiaq,AA-AY-789,2022,160,https://www.netcarshow.com/Skoda-Kodiaq-2017-1280-01.jpg"),
                new Cars("1,20,M5,AA-AV-121,2022,700,https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg"),
                new Cars("1,21,E60,HFG-453,2004,310,https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg"),//Szallitokocsik innentol
                new Cars("1,22,E60,HFG-453,2004,310,https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg")





            });

            base.OnModelCreating(builder);
        }
        
    }
}