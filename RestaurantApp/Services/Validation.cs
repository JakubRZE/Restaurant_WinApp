using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Services
{
    class Validation
    {
        public static bool emailValidating(TextBox tekstbox)
        {
            System.Text.RegularExpressions.Regex mail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            return mail.IsMatch(tekstbox.Text) ? true : false;
        }
    }
}
