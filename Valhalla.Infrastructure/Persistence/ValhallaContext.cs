using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Valhalla.Domain.Entities;

namespace Valhalla.Infrastructure.Persistence
{
    public partial class ValhallaContext : DbContext
    {
        public ValhallaContext()
        {
        }

        public ValhallaContext(DbContextOptions<ValhallaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Favorite> Favorites { get; set; } = null!;
        public virtual DbSet<JwtAuthentication> JwtAuthentications { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Urus> Urus { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<VehicleColor> VehicleColors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.Idbrand)
                    .HasName("PK__brands__A8EBD9B76BE8D3AA");

                entity.ToTable("brands");

                entity.Property(e => e.Idbrand).HasColumnName("IDBrand");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("brandName");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("imageURL");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasKey(e => e.Idfavorite)
                    .HasName("PK__favorite__32FAC67A3E6B8AFF");

                entity.ToTable("favorites");

                entity.Property(e => e.Idfavorite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDFavorite");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUser");

                entity.Property(e => e.Idvehicle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDVehicle");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__favorites__IDUse__6754599E");

                entity.HasOne(d => d.IdvehicleNavigation)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.Idvehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__favorites__IDVeh__68487DD7");
            });

            modelBuilder.Entity<JwtAuthentication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jwtAuthentication");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Idorder)
                    .HasName("PK__orders__5CBBCADB620B709A");

                entity.ToTable("orders");

                entity.Property(e => e.Idorder)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDOrder");

                entity.Property(e => e.Idurus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUrus");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUser");

                entity.Property(e => e.Idvehicle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDVehicle");

                entity.Property(e => e.OrderedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("orderedAt");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("userAddress");

                entity.Property(e => e.UserPhone).HasColumnName("userPhone");

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");

                entity.HasOne(d => d.IdurusNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Idurus)
                    .HasConstraintName("FK__orders__IDUrus__693CA210");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orders__IDUser__6A30C649");

                entity.HasOne(d => d.IdvehicleNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Idvehicle)
                    .HasConstraintName("FK__orders__IDVehicl__6B24EA82");
            });

            modelBuilder.Entity<Urus>(entity =>
            {
                entity.HasKey(e => e.Idurus)
                    .HasName("PK__urus__ED2261E3830FA28D");

                entity.ToTable("urus");

                entity.Property(e => e.Idurus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUrus");

                entity.Property(e => e.AperturaTraseraSmart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("aperturaTraseraSmart");

                entity.Property(e => e.AsientosElectricos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("asientosElectricos");

                entity.Property(e => e.AsistenciaAutopista)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("asistenciaAutopista");

                entity.Property(e => e.Bordado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bordado");

                entity.Property(e => e.Cinturones)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cinturones");

                entity.Property(e => e.Frenos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("frenos");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUser");

                entity.Property(e => e.Llantas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("llantas");

                entity.Property(e => e.Pintura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pintura");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.VisionNocturna)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("visionNocturna");

                entity.Property(e => e.Vista)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("vista");

                entity.Property(e => e.WashingPackage)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("washingPackage");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Urus)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__urus__IDUser__6C190EBB");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PK__users__EAE6D9DF8DDA6F5D");

                entity.ToTable("users");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUser");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("birthdate");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.FirstSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstSurname");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.Property(e => e.SecondName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("secondName");

                entity.Property(e => e.SecondSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("secondSurname");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("userAddress");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.Idvehicle)
                    .HasName("PK__vehicles__964C37C0D9942B88");

                entity.ToTable("vehicles");

                entity.Property(e => e.Idvehicle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDVehicle");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("brandName");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Idbrand).HasColumnName("IDBrand");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("imgURL");

                entity.Property(e => e.IsNew).HasColumnName("isNew");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vehicleName");

                entity.HasOne(d => d.IdbrandNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.Idbrand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__vehicles__IDBran__6E01572D");
            });

            modelBuilder.Entity<VehicleColor>(entity =>
            {
                entity.HasKey(e => e.Idcolor)
                    .HasName("PK__vehicleC__E424D9361387593D");

                entity.ToTable("vehicleColors");

                entity.Property(e => e.Idcolor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDColor");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Idvehicle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDVehicle");

                entity.HasOne(d => d.IdvehicleNavigation)
                    .WithMany(p => p.VehicleColors)
                    .HasForeignKey(d => d.Idvehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__vehicleCo__IDVeh__6D0D32F4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
