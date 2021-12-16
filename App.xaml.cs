using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Yukseev_SchoolApp
{
    public partial class App : Application
    {
        public static Entities.user17_1Entities Context
        { get; } = new Entities.user17_1Entities();
    }
}
