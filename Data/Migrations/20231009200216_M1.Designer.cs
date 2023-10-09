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
    [Migration("20231009200216_M1")]
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
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(6700),
                            CreatedBy = "Admin",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(6710),
                            ModifiedBy = "Admin",
                            PostalCode = "12345",
                            Street = "123 Main St"
                        },
                        new
                        {
                            AccountNo = 2,
                            City = "Dallas",
                            Country = "USA",
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(6710),
                            CreatedBy = "Admin",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(6710),
                            ModifiedBy = "Admin",
                            PostalCode = "67890",
                            Street = "456 Elm St"
                        },
                        new
                        {
                            AccountNo = 3,
                            City = "Oakville",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(6720),
                            CreatedBy = "Admin",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(6720),
                            ModifiedBy = "Admin",
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

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            TransId = 1,
                            AccountNo = 1,
                            Amount = 100f,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7170),
                            CreatedBy = "Admin",
                            Date = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7160),
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7170),
                            ModifiedBy = "Admin",
                            Notes = "Donation 1",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 2,
                            Amount = 200f,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7170),
                            CreatedBy = "Admin",
                            Date = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7170),
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7170),
                            ModifiedBy = "Admin",
                            Notes = "Dontation 2",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 3,
                            Amount = 300f,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7180),
                            CreatedBy = "Admin",
                            Date = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7180),
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(7180),
                            ModifiedBy = "Admin",
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
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(2610),
                            CreatedBy = "Admin",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(2620),
                            ModifiedBy = "Admin",
                            Name = "Cash"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(2620),
                            CreatedBy = "Admin",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(2630),
                            ModifiedBy = "Admin",
                            Name = "Credit Card"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(2630),
                            CreatedBy = "Admin",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 356, DateTimeKind.Local).AddTicks(2630),
                            ModifiedBy = "Admin",
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
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(9900),
                            CreatedBy = "Admin",
                            Description = "Donation",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(9910),
                            ModifiedBy = "Admin",
                            Name = "Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(9920),
                            CreatedBy = "Admin",
                            Description = "Pledge",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(9920),
                            ModifiedBy = "Admin",
                            Name = "Pledge"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Created = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(9920),
                            CreatedBy = "Admin",
                            Description = "Event",
                            Modified = new DateTime(2023, 10, 9, 13, 2, 16, 355, DateTimeKind.Local).AddTicks(9920),
                            ModifiedBy = "Admin",
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
                            Id = "5eb2dd08-4d52-47ea-8294-029420855d8a",
                            CreatedDate = new DateTime(2023, 10, 9, 13, 2, 16, 281, DateTimeKind.Local).AddTicks(4340),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "8ee2052e-c563-4452-a8dd-e207d94fb658",
                            CreatedDate = new DateTime(2023, 10, 9, 13, 2, 16, 281, DateTimeKind.Local).AddTicks(4410),
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
                            Id = "d29ed9a1-475f-4478-902d-177729b635b6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a1bde5d-bcfa-4504-8d2b-8e35cdf29160",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEN8QggkqtMwembp6Bf8BqbJv/YhmK0eag2O8UWMh1rX6rKKjs+5xntCQ1O1FTZZtEA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66ec0a01-4e77-49b2-923b-e85739bd1369",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "e806193e-c63a-4bd4-aead-9c052c77b69c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "49cb53e3-ed28-4b77-b4dd-7e86ff20b42f",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAEO0NzvQ087CZPAGfJFo4jpRBA4r1feDnfFFl14Rb/i4Plb6A5h/CStxrwYIxxcakXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f4d9553-5022-489f-bdc9-2a55de63295d",
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
                            UserId = "d29ed9a1-475f-4478-902d-177729b635b6",
                            RoleId = "5eb2dd08-4d52-47ea-8294-029420855d8a"
                        },
                        new
                        {
                            UserId = "e806193e-c63a-4bd4-aead-9c052c77b69c",
                            RoleId = "8ee2052e-c563-4452-a8dd-e207d94fb658"
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