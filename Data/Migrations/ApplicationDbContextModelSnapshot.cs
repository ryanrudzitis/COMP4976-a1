﻿// <auto-generated />
using System;
using Assignment1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Assignment1.Models.ContactList", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNo");

                    b.ToTable("Contact List", (string)null);

                    b.HasData(
                        new
                        {
                            AccountNo = 1,
                            City = "Maple Ridge",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7700),
                            CreatedBy = "a@a.a",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7710),
                            ModifiedBy = "a@a.a",
                            PostalCode = "12345",
                            Street = "123 Main St"
                        },
                        new
                        {
                            AccountNo = 2,
                            City = "Dallas",
                            Country = "USA",
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720),
                            CreatedBy = "a@a.a",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720),
                            ModifiedBy = "a@a.a",
                            PostalCode = "67890",
                            Street = "456 Elm St"
                        },
                        new
                        {
                            AccountNo = 3,
                            City = "Oakville",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720),
                            CreatedBy = "a@a.a",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720),
                            ModifiedBy = "a@a.a",
                            PostalCode = "54321",
                            Street = "789 Oak St"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Donations", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountNo")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransId");

                    b.HasIndex("AccountNo");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            TransId = 1,
                            AccountNo = 1,
                            Amount = 100f,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7800),
                            CreatedBy = "a@a.a",
                            Date = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7790),
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7800),
                            ModifiedBy = "a@a.a",
                            Notes = "Donation 1",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 2,
                            Amount = 200f,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810),
                            CreatedBy = "a@a.a",
                            Date = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7800),
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810),
                            ModifiedBy = "a@a.a",
                            Notes = "Dontation 2",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 3,
                            Amount = 300f,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810),
                            CreatedBy = "a@a.a",
                            Date = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810),
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810),
                            ModifiedBy = "a@a.a",
                            Notes = "Donation 3",
                            PaymentMethodId = 3,
                            TransactionTypeId = 3
                        });
                });

            modelBuilder.Entity("Assignment1.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod");

                    b.HasData(
                        new
                        {
                            PaymentMethodId = 1,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7770),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7770),
                            ModifiedBy = "a@a.a",
                            Name = "Cash"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7770),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7780),
                            ModifiedBy = "a@a.a",
                            Name = "Credit Card"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7780),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7780),
                            ModifiedBy = "a@a.a",
                            Name = "PayPal"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionType");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750),
                            CreatedBy = "a@a.a",
                            Description = "Donation",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750),
                            ModifiedBy = "a@a.a",
                            Name = "Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750),
                            CreatedBy = "a@a.a",
                            Description = "Pledge",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750),
                            ModifiedBy = "a@a.a",
                            Name = "Pledge"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Created = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750),
                            CreatedBy = "a@a.a",
                            Description = "Event",
                            Modified = new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750),
                            ModifiedBy = "a@a.a",
                            Name = "Event"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.XRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "867eac6e-d939-4ae9-8a7b-c3c6d4868777",
                            CreatedDate = new DateTime(2023, 10, 12, 21, 21, 40, 828, DateTimeKind.Local).AddTicks(780),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ba1b347b-8a9b-4597-a057-9b28d2b26675",
                            CreatedDate = new DateTime(2023, 10, 12, 21, 21, 40, 828, DateTimeKind.Local).AddTicks(870),
                            Name = "Finance",
                            NormalizedName = "FINANCE"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.XUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ff725bcb-20dd-4ce8-ae35-519d4c418b27",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12fa0155-45bf-403e-b0c8-633c3d01082f",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEKQuu04n4u8l622b88C2ig0QRrxbDKGJJ/4X/OOvz6hh8H90pdr0gu0uEN/6SUKl2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "42ed5b83-bcb7-4402-af4e-7af23b2c87cb",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "1e54bc8f-e32e-4a63-b2db-c3d6eb6e6d62",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c9d19113-5a00-48f2-85c5-0aa5b73ad363",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAEI4UIyh0/pfV1fL7qUgOjTR2UFKVK0zu6is254E5LimFNTkJUeQcKTcf/Y/m8ft3Uw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "755b7bb6-1100-4b58-b1bc-559f15e0518a",
                            TwoFactorEnabled = false,
                            UserName = "f@f.f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "ff725bcb-20dd-4ce8-ae35-519d4c418b27",
                            RoleId = "867eac6e-d939-4ae9-8a7b-c3c6d4868777"
                        },
                        new
                        {
                            UserId = "1e54bc8f-e32e-4a63-b2db-c3d6eb6e6d62",
                            RoleId = "ba1b347b-8a9b-4597-a057-9b28d2b26675"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Assignment1.Models.Donations", b =>
                {
                    b.HasOne("Assignment1.Models.ContactList", "Account")
                        .WithMany()
                        .HasForeignKey("AccountNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("PaymentMethod");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Assignment1.Models.XRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Assignment1.Models.XUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Assignment1.Models.XUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Assignment1.Models.XRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.XUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Assignment1.Models.XUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
