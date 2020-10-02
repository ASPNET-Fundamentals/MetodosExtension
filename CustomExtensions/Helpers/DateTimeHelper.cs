using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions.Helpers
{
    public static class DateTimeHelper
    {
        public static string FormatoFecha(this DateTime value)
        {
            return value.ToString("dd/MM/yyyy");
        }
    }
}
