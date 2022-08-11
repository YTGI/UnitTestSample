using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RV4US.API.RV.PROC.Repository.Models;

namespace RV4US.API.RV.PROC.Repository.Context
{
    public partial class RVResearchContext : DbContext
    {
        public RVResearchContext()
        {
        }

        public RVResearchContext(DbContextOptions<RVResearchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<ClickOuts> ClickOuts { get; set; }
        public virtual DbSet<Features_Base> Features_Base { get; set; }
        public virtual DbSet<Features_Manufacturer> Features_Manufacturer { get; set; }
        public virtual DbSet<FunctionalBenefits> FunctionalBenefits { get; set; }
        public virtual DbSet<LuCategories> LuCategories { get; set; }
        public virtual DbSet<LuItems> LuItems { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Map_Features_RVTypes> Map_Features_RVTypes { get; set; }
        public virtual DbSet<Map_TopTen_RVTypes> Map_TopTen_RVTypes { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<RVModels> RVModels { get; set; }
        public virtual DbSet<RVModels_Specs> RVModels_Specs { get; set; }
        public virtual DbSet<TopTenItems> TopTenItems { get; set; }
        public virtual DbSet<TopTen_Filters> TopTen_Filters { get; set; }
        public virtual DbSet<TopTen_Results> TopTen_Results { get; set; }
        public virtual DbSet<TopTen_Selects> TopTen_Selects { get; set; }
        public virtual DbSet<Trad_Results> Trad_Results { get; set; }
        public virtual DbSet<Trad_Selects> Trad_Selects { get; set; }
        public virtual DbSet<URLs> URLs { get; set; }
        public virtual DbSet<Uploads> Uploads { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("Addresses", "rvs");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhoAdded).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhoMod).HasDefaultValueSql("((1))");

                entity.Property(e => e.ZipPlus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_AddressTypeId_LuItems");

                entity.HasMany(d => d.Manufacturers)
                    .WithMany(p => p.Addresses)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_Manufacturers_Addresses",
                        l => l.HasOne<Manufacturers>().WithMany().HasForeignKey("ManufacturersId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Manufacturers_Addresses_Manufacturers"),
                        r => r.HasOne<Addresses>().WithMany().HasForeignKey("AddressesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Manufacturers_Addresses_Addresses"),
                        j =>
                        {
                            j.HasKey("AddressesId", "ManufacturersId");

                            j.ToTable("Map_Manufacturers_Addresses", "rvs");
                        });
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.ToTable("Brands", "rvs");

                entity.HasIndex(e => e.ShortName, "IX_Brands_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_Brands_UniqueId")
                    .IsUnique();

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoURI)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.WhoAdded).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhoMod).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Manufacturers)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.ManufacturersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brands_Manufacturers");
            });

            modelBuilder.Entity<ClickOuts>(entity =>
            {
                entity.ToTable("ClickOuts", "tracking");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntireURI)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasMaxLength(900);
            });

            modelBuilder.Entity<Features_Base>(entity =>
            {
                entity.ToTable("Features_Base", "rvs");

                entity.HasIndex(e => e.ShortName, "IX_Features_Base_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_Features_Base_UniqueId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.HasMany(d => d.RVModels)
                    .WithMany(p => p.FeatureBase)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_RVModels_FeatureBase",
                        l => l.HasOne<RVModels>().WithMany().HasForeignKey("RVModelsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_RVModels_FeatureBase_RVModels"),
                        r => r.HasOne<Features_Base>().WithMany().HasForeignKey("FeatureBaseId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_RVModels_FeatureBase_FeatureBase"),
                        j =>
                        {
                            j.HasKey("FeatureBaseId", "RVModelsId");

                            j.ToTable("Map_RVModels_FeatureBase", "rvs");

                            j.HasIndex(new[] { "RVModelsId", "FeatureBaseId" }, "IX_Map_RVModels_FeatureBase_Ids");
                        });
            });

            modelBuilder.Entity<Features_Manufacturer>(entity =>
            {
                entity.ToTable("Features_Manufacturer", "rvs");

                entity.HasIndex(e => e.ShortName, "IX_Features_Manufacturer_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_Features_Manufacturer_UniqueId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.HasOne(d => d.FeaturesBase)
                    .WithMany(p => p.Features_Manufacturer)
                    .HasForeignKey(d => d.FeaturesBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Features_Manufacturer_FeatBase");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Features_Manufacturer)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Features_Manufacturer_Manufacturers");
            });

            modelBuilder.Entity<FunctionalBenefits>(entity =>
            {
                entity.ToTable("FunctionalBenefits", "rvs");

                entity.HasIndex(e => e.ShortName, "IX_FunctionalBenefits_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_FunctionalBenefits_UniqueId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.HasMany(d => d.RVModels)
                    .WithMany(p => p.FunctionalBenefit)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_RVModels_Functional",
                        l => l.HasOne<RVModels>().WithMany().HasForeignKey("RVModelsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_RVModels_Functional_RVModels"),
                        r => r.HasOne<FunctionalBenefits>().WithMany().HasForeignKey("FunctionalBenefitId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_RVModels_Functional"),
                        j =>
                        {
                            j.HasKey("FunctionalBenefitId", "RVModelsId");

                            j.ToTable("Map_RVModels_Functional", "rvs");

                            j.HasIndex(new[] { "RVModelsId", "FunctionalBenefitId" }, "IX_Map_RVModels_Functional_Ids");
                        });
            });

            modelBuilder.Entity<LuCategories>(entity =>
            {
                entity.ToTable("LuCategories", "lookups");

                entity.HasIndex(e => e.ShortName, "IX_LuCategories_ShortName")
                    .IsUnique();

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WhoAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WhoMod)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LuItems>(entity =>
            {
                entity.ToTable("LuItems", "lookups");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LuBoolean)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LuCode)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.LuItemDesc)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LuValue)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.LuValue2)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.WhoAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WhoMod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.LuCat)
                    .WithMany(p => p.LuItems)
                    .HasForeignKey(d => d.LuCatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LuItems_LuCat_Id");
            });

            modelBuilder.Entity<Manufacturers>(entity =>
            {
                entity.ToTable("Manufacturers", "rvs");

                entity.HasIndex(e => e.ShortName, "IX_Manufacturers_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_Manufacturers_UniqueId");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HomePageURL)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.LogoURI)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.WhoAdded).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhoMod).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Map_Features_RVTypes>(entity =>
            {
                entity.HasKey(e => new { e.FeaturesBaseId, e.RVTypeId });

                entity.ToTable("Map_Features_RVTypes", "rvs");

                entity.HasOne(d => d.FeaturesBase)
                    .WithMany(p => p.Map_Features_RVTypes)
                    .HasForeignKey(d => d.FeaturesBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Map_Features_RVTypes_Features");
            });

            modelBuilder.Entity<Map_TopTen_RVTypes>(entity =>
            {
                entity.HasKey(e => new { e.TopTenId, e.RVTypeId });

                entity.ToTable("Map_TopTen_RVTypes", "rvs");

                entity.HasOne(d => d.TopTen)
                    .WithMany(p => p.Map_TopTen_RVTypes)
                    .HasForeignKey(d => d.TopTenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Map_TopTen_RVTypes_TopTen");
            });

            modelBuilder.Entity<Phones>(entity =>
            {
                entity.ToTable("Phones", "rvs");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoAdded).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhoMod).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phones_LuItems");

                entity.HasMany(d => d.Manufacturers)
                    .WithMany(p => p.Phones)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_Manufacturers_Phones",
                        l => l.HasOne<Manufacturers>().WithMany().HasForeignKey("ManufacturersId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Manufacturers_Phones_Manufacturers"),
                        r => r.HasOne<Phones>().WithMany().HasForeignKey("PhonesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Manufacturers_Phones_Phones"),
                        j =>
                        {
                            j.HasKey("PhonesId", "ManufacturersId");

                            j.ToTable("Map_Manufacturers_Phones", "rvs");
                        });
            });

            modelBuilder.Entity<RVModels>(entity =>
            {
                entity.ToTable("RVModels", "rvs");

                entity.HasIndex(e => new { e.ModelYear, e.ShortName }, "IX_RVModels_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_RVModels_UniqueId")
                    .IsUnique();

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoURI)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PostSuffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RVTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.WhoAdded).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhoMod).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Brands)
                    .WithMany(p => p.RVModels)
                    .HasForeignKey(d => d.BrandsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RVModels_Brands");
            });

            modelBuilder.Entity<RVModels_Specs>(entity =>
            {
                entity.ToTable("RVModels_Specs", "rvs");

                entity.HasIndex(e => e.RVModelsId, "IX_RVModels_Specs_RVModelsId")
                    .IsUnique();

                entity.Property(e => e.MSRP).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.RVModels)
                    .WithOne(p => p.RVModels_Specs)
                    .HasForeignKey<RVModels_Specs>(d => d.RVModelsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RVModels_Specs_RVModels");
            });

            modelBuilder.Entity<TopTenItems>(entity =>
            {
                entity.ToTable("TopTenItems", "rvs");

                entity.HasIndex(e => e.ShortName, "IX_TopTenItems_ShortName")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_TopTenItems_UniqueId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.HasMany(d => d.FeatureBase)
                    .WithMany(p => p.TopTen)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_TopTen_Features",
                        l => l.HasOne<Features_Base>().WithMany().HasForeignKey("FeatureBaseId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_TopTen_Features_FeatureBase"),
                        r => r.HasOne<TopTenItems>().WithMany().HasForeignKey("TopTenId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_TopTen_Features_TopTen"),
                        j =>
                        {
                            j.HasKey("TopTenId", "FeatureBaseId");

                            j.ToTable("Map_TopTen_Features", "rvs");
                        });

                entity.HasMany(d => d.FunctionalBenefit)
                    .WithMany(p => p.TopTen)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_TopTen_Functional",
                        l => l.HasOne<FunctionalBenefits>().WithMany().HasForeignKey("FunctionalBenefitId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_TopTen_Functional_FuncBenefit"),
                        r => r.HasOne<TopTenItems>().WithMany().HasForeignKey("TopTenId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_TopTen_Functional_TopTen"),
                        j =>
                        {
                            j.HasKey("TopTenId", "FunctionalBenefitId");

                            j.ToTable("Map_TopTen_Functional", "rvs");
                        });
            });

            modelBuilder.Entity<TopTen_Filters>(entity =>
            {
                entity.ToTable("TopTen_Filters", "tracking");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SelectedRVTypes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasMaxLength(900);
            });

            modelBuilder.Entity<TopTen_Results>(entity =>
            {
                entity.ToTable("TopTen_Results", "tracking");

                entity.HasOne(d => d.TopTenFilters)
                    .WithMany(p => p.TopTen_Results)
                    .HasForeignKey(d => d.TopTenFiltersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopTen_Results_Filters");
            });

            modelBuilder.Entity<TopTen_Selects>(entity =>
            {
                entity.ToTable("TopTen_Selects", "tracking");

                entity.HasOne(d => d.TopTenFilters)
                    .WithMany(p => p.TopTen_Selects)
                    .HasForeignKey(d => d.TopTenFiltersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopTen_Selects_Filters");
            });

            modelBuilder.Entity<Trad_Results>(entity =>
            {
                entity.ToTable("Trad_Results", "tracking");

                entity.HasOne(d => d.TopTenFilters)
                    .WithMany(p => p.Trad_Results)
                    .HasForeignKey(d => d.TopTenFiltersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trad_Results_Filters");
            });

            modelBuilder.Entity<Trad_Selects>(entity =>
            {
                entity.ToTable("Trad_Selects", "tracking");

                entity.HasOne(d => d.TopTenFilters)
                    .WithMany(p => p.Trad_Selects)
                    .HasForeignKey(d => d.TopTenFiltersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trad_Selects_Filters");
            });

            modelBuilder.Entity<URLs>(entity =>
            {
                entity.ToTable("URLs", "rvs");

                entity.Property(e => e.EntireURI)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.HasMany(d => d.Brands)
                    .WithMany(p => p.URLs)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_Brands_URLs",
                        l => l.HasOne<Brands>().WithMany().HasForeignKey("BrandsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Brands_URLs_Brands"),
                        r => r.HasOne<URLs>().WithMany().HasForeignKey("URLsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Brands_URLs_URLs"),
                        j =>
                        {
                            j.HasKey("URLsId", "BrandsId");

                            j.ToTable("Map_Brands_URLs", "rvs");
                        });

                entity.HasMany(d => d.Manufacturers)
                    .WithMany(p => p.URLs)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_Manufacturers_URLs",
                        l => l.HasOne<Manufacturers>().WithMany().HasForeignKey("ManufacturersId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Manufacturers_URLs_Manufacturers"),
                        r => r.HasOne<URLs>().WithMany().HasForeignKey("URLsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_Manufacturers_URLs_URLs"),
                        j =>
                        {
                            j.HasKey("URLsId", "ManufacturersId");

                            j.ToTable("Map_Manufacturers_URLs", "rvs");
                        });

                entity.HasMany(d => d.RVModels)
                    .WithMany(p => p.URLs)
                    .UsingEntity<Dictionary<string, object>>(
                        "Map_RVModels_URLs",
                        l => l.HasOne<RVModels>().WithMany().HasForeignKey("RVModelsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_RVModels_URLs_RVModels"),
                        r => r.HasOne<URLs>().WithMany().HasForeignKey("URLsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Map_RVModels_URLs_URLs"),
                        j =>
                        {
                            j.HasKey("URLsId", "RVModelsId");

                            j.ToTable("Map_RVModels_URLs", "rvs");
                        });
            });

            modelBuilder.Entity<Uploads>(entity =>
            {
                entity.ToTable("Uploads", "rvs");

                entity.Property(e => e.StoragePath)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "rvs");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateMod).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WhoAdded).HasDefaultValueSql("((1))");

                entity.Property(e => e.WhoMod).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
