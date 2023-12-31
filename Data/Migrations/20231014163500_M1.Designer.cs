﻿// <auto-generated />
using System;
using Assignment1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231014163500_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Assignment1.Models.ContactList", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNo");

                    b.ToTable("Contact List", (string)null);

                    b.HasData(
                        new
                        {
                            AccountNo = 1,
                            City = "Maple Ridge",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(5980),
                            CreatedBy = "a@a.a",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6030),
                            ModifiedBy = "a@a.a",
                            PostalCode = "12345",
                            Street = "123 Main St"
                        },
                        new
                        {
                            AccountNo = 2,
                            City = "Dallas",
                            Country = "USA",
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6040),
                            CreatedBy = "a@a.a",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6040),
                            ModifiedBy = "a@a.a",
                            PostalCode = "67890",
                            Street = "456 Elm St"
                        },
                        new
                        {
                            AccountNo = 3,
                            City = "Oakville",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6040),
                            CreatedBy = "a@a.a",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6040),
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
                        .HasMaxLength(500)
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
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6130),
                            CreatedBy = "a@a.a",
                            Date = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6130),
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6130),
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
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6140),
                            CreatedBy = "a@a.a",
                            Date = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6140),
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6140),
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
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6150),
                            CreatedBy = "a@a.a",
                            Date = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6150),
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6150),
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
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod");

                    b.HasData(
                        new
                        {
                            PaymentMethodId = 1,
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6100),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6100),
                            ModifiedBy = "a@a.a",
                            Name = "Cash"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6110),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6110),
                            ModifiedBy = "a@a.a",
                            Name = "Credit Card"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6110),
                            CreatedBy = "a@a.a",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6110),
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
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionType");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6070),
                            CreatedBy = "a@a.a",
                            Description = "Donation",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6070),
                            ModifiedBy = "a@a.a",
                            Name = "Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6070),
                            CreatedBy = "a@a.a",
                            Description = "Pledge",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6080),
                            ModifiedBy = "a@a.a",
                            Name = "Pledge"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Created = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6080),
                            CreatedBy = "a@a.a",
                            Description = "Event",
                            Modified = new DateTime(2023, 10, 14, 9, 35, 0, 898, DateTimeKind.Local).AddTicks(6080),
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
                            Id = "42b854cb-ff4f-4976-9ea3-94909aeece31",
                            CreatedDate = new DateTime(2023, 10, 14, 9, 35, 0, 820, DateTimeKind.Local).AddTicks(6930),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "38012cda-2f77-4af1-aa96-47cb80c88ed7",
                            CreatedDate = new DateTime(2023, 10, 14, 9, 35, 0, 820, DateTimeKind.Local).AddTicks(7010),
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
                            Id = "b9082dbb-3958-4441-ba2d-22f18915eacb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f295288a-2d07-4678-b5e7-727dc3219eb7",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAECEeTxD/W+BWU+DWEhtSxWuCxqXj+kGQ8CWAODq29UCpvUc97JUlu1sStVinSUHXnw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "99ab9898-a134-47d6-83be-fb8b451967f8",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "46336c5f-77dc-4e72-a863-1cefdf0727fc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "28bcba0e-4c10-40ef-91b8-f83f59908da2",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAEJ5Dr7aOWKX2CcufrNw2Kb80jFzN3cryR/NGJImux6sW3KPj8KEfvVhmqUCiNbpaiQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b544eaa8-0a74-4b7c-ab2d-a3a7c02e0c1d",
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
                            UserId = "b9082dbb-3958-4441-ba2d-22f18915eacb",
                            RoleId = "42b854cb-ff4f-4976-9ea3-94909aeece31"
                        },
                        new
                        {
                            UserId = "46336c5f-77dc-4e72-a863-1cefdf0727fc",
                            RoleId = "38012cda-2f77-4af1-aa96-47cb80c88ed7"
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
