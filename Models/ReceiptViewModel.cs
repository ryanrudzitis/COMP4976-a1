using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class ReceiptViewModel
{
    public required List<Donations> Donations { get; set; }
    public required string DonorFullName { get; set; }
}
}