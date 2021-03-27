using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata;
namespace WebAngularAPI.Models
{
    public partial class UsersContext : DbContext
    {
        public UsersContext()
        {
        }

        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-E3OD0JS8\\SQLEXPRESS;Initial Catalog=CarCenterDB;user id=desenv;password=desenv; MultipleActiveResultSets=true; Persist Security Info=True;");
         
                //Here we can configurate another conection string for other enviroment
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Clients_key);

                entity.ToTable("Clients");

                entity.Property(e => e.Clients_key)
                    .HasColumnName("Clients_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FullName)
                    .HasColumnName("FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasColumnName("DocumentType")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ID)
                    .HasColumnName("ID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cellphone)
                    .HasColumnName("Cellphone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Car_key);

                entity.ToTable("Cars");

                entity.Property(e => e.Car_key)
                    .HasColumnName("Car_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Clients_key)
                    .HasColumnName("Clients_key");

                entity.Property(e => e.Marca)
                    .HasColumnName("Marca")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasKey(e => e.Maintenance_key);

                entity.ToTable("Maintenance");

                entity.Property(e => e.Maintenance_key)
                    .HasColumnName("Maintenance_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Clients_key)
                    .HasColumnName("Clients_key");

                entity.Property(e => e.Description)
                    .HasColumnName("Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.initialDate)
                    .HasColumnName("initialDate")                    
                    .IsUnicode(false);
                entity.Property(e => e.endDate)
                    .HasColumnName("endDate")
                    .IsUnicode(false);
                entity.Property(e => e.State)
                    .HasColumnName("State")
                    .IsUnicode(false);
            });
        }
    }
}
