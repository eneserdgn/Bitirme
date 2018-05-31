namespace CheckCar.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CheckCarContext : DbContext
    {
        public CheckCarContext()
            : base("name=CheckCarContext")
        {
            Database.SetInitializer(new CheckCarInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mark ve Version arasýndaki bire çok iliþki
            modelBuilder.Entity<MarkVersion>()
               .HasRequired<Mark>(s => s.Mark)
               .WithMany(g => g.MarkVersions)
               .HasForeignKey<int>(s => s.MarkID);
            //Version ile Release arasýndaki bire çok iliþki
            modelBuilder.Entity<Release>()
              .HasRequired<MarkVersion>(s => s.MarkVersion)             
              .WithMany(g => g.Releases)
              .HasForeignKey<int>(s => s.MarkVersionID);             
            //Release ile CarDetail arasýndaki bire bir iliþki          
            modelBuilder.Entity<CarDetail>()
                .HasOptional(s => s.Release)
                .WithRequired(ad => ad.CarDetail);
            //CarDetail ile Security arasýndaki bire bir iliþki
            modelBuilder.Entity<CarDetail>()
                .HasOptional(s => s.Security)
                .WithRequired(ad => ad.CarDetail);
            //CarDetail ile TechnicalSpecification arasýndaki bire bir iliþki
            modelBuilder.Entity<CarDetail>()
                 .HasOptional(s => s.TechnicalSpecification)
                 .WithRequired(ad => ad.CarDetail);
            //CarDetail ile Technology arasýndaki bire bir iliþki
            modelBuilder.Entity<CarDetail>()
                 .HasOptional(s => s.Technology)
                 .WithRequired(ad => ad.CarDetail);


        }

        public System.Data.Entity.DbSet<CheckCar.Models.Mark> Marks { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.MarkVersion> MarkVersions { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.Release> Releases { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.CarDetail> CarDetails { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.Security> Securities { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.TechnicalSpecification> TechnicalSpecifications { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.Technology> Technologies { get; set; }

        public System.Data.Entity.DbSet<CheckCar.Models.News> News { get; set; }
    }
}
