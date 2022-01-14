using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IRentBusiness
    {
        int GetRentCount();
        decimal CalculateRevenue();
        int InsertRent(Rent rent);
    }
}
