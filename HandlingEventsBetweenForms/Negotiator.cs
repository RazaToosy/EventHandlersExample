using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingEventsBetweenForms
{
    public class Negotiator
    {
        //Singleton functionality
        private static readonly Negotiator _Instance = new Negotiator();
        private Negotiator() { }

        public static Negotiator GetInstance()
        {
            return _Instance;
        }

        //Instance functionality
        public event EventHandler<ChangeTitleEventArgs> TitleChanged;

        public void OnTitleChanged(Object sender, String message)
        {
            var titleChangeDelegate = TitleChanged as EventHandler<ChangeTitleEventArgs>;
            if (titleChangeDelegate != null)
            {
                titleChangeDelegate(sender, new ChangeTitleEventArgs { TitleName = message });
            }
        }
    }
}
