using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingEventsBetweenForms
{
    public class ChangeTitleEventArgs : System.EventArgs
    {
        public string TitleName { get; set; }
    }
}
