using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactList>().HasData(
                GetContactLists()
            );
            modelBuilder.Entity<TransactionType>().HasData(
                GetTransactionTypes()
            );

            modelBuilder.Entity<PaymentMethod>().HasData(
                GetPaymentMethods()
            );

            modelBuilder.Entity<Donations>().HasData(
                GetDonations()
            );

            

            
        }
        public static List<ContactList> GetContactLists()

        {
            List<ContactList> lists = new() {
                new() {
                    AccountNo = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Street = "123 Main St",
                    City = "Maple Ridge",
                    PostalCode = "12345",
                    Country = "Canada",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new() {
                    AccountNo = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Street = "456 Elm St",
                    City = "Dallas",
                    PostalCode = "67890",
                    Country = "USA",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new() {
                    AccountNo = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    Street = "789 Oak St",
                    City = "Oakville",
                    PostalCode = "54321",
                    Country = "Canada",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                }
            };
            return lists;
        }

        public static List<TransactionType> GetTransactionTypes()

        {
            List<TransactionType> types = new() {
                new() {
                    TransactionTypeId = 1,
                    Name = "Donation",
                    Description = "Donation",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new() {
                    TransactionTypeId = 2,
                    Name = "Pledge",
                    Description = "Pledge",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new() {
                    TransactionTypeId = 3,
                    Name = "Event",
                    Description = "Event",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                }
            };
            return types;
        }

        public static List<PaymentMethod> GetPaymentMethods()

        {
            List<PaymentMethod> methods = new() {
                new PaymentMethod {
                    PaymentMethodId = 1,
                    Name = "Cash",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new PaymentMethod {
                    PaymentMethodId = 2,
                    Name = "Credit Card",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new PaymentMethod {
                    PaymentMethodId = 3,
                    Name = "PayPal",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                }
            };
            return methods;
        }

        public static List<Donations> GetDonations()

        {
            List<Donations> donations = new() {
                new() {
                    TransId = 1,
                    Date = DateTime.Now,
                    AccountNo = 1,
                    TransactionTypeId = 1,
                    Amount = 100,
                    PaymentMethodId = 1,
                    Notes = "Donation 1",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new() {
                    TransId = 2,
                    Date = DateTime.Now,
                    AccountNo = 2,
                    TransactionTypeId = 2,
                    Amount = 200,
                    PaymentMethodId = 2,
                    Notes = "Dontation 2",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                },
                new() {
                    TransId = 3,
                    Date = DateTime.Now,
                    AccountNo = 3,
                    TransactionTypeId = 3,
                    Amount = 300,
                    PaymentMethodId = 3,
                    Notes = "Donation 3",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin"
                }
            };
            return donations;
        }
    }
}

