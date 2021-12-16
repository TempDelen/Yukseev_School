using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Меняем namespace для обьединения двух файлов в одно пространство имён
namespace Yukseev_SchoolApp.Entities
{
    class ServiceClass
    {
    }

    public partial class Service
    {
        public string DiscountText
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return "";
                else
                    return $"Скидка = {Discount * 100}%";
            }
        }

        public double CostWithDiscount
        {
            get
            {
                if (Discount == 0 || Discount == null)
                {
                    return (double)Cost;
                }
                else
                {
                    var costWithDiscount = (double)Cost - (1.00 - Discount);
                    return costWithDiscount.Value;
                }
            }
        }

        public string TotalCost
        {
            get
            {
                if (Discount == 0 || Discount == null)
                {
                    return $"{Cost:N2} рублей за {DurationInSeconds / 60} минут";
                }
                else
                {
                    return $"{CostWithDiscount:N2} рублей за {DurationInSeconds / 60} минут";
                }
            }
        }
        public string BackColor
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return "Gray";
                else
                    return "LightGreen";
            }
        }
    }
}
