using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication
{
    public interface IPayTotal
    {
        void PayTotalPaymentDone();
        void PayTotalFormClosed();
    }
}
