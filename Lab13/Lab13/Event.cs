using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class Event
    {
        public double val;
        public int x;
        public Event(int x)
        {

            val = 1;
            this.x = x;
        }
        public Event(int x, double val)
        {

            this.val = val;
            this.x = x;
        }
        static public List<Event> MakeACopy(List<Event> original)
        {
            List<Event> copy = new List<Event>();
            foreach (var item in original)
            {
                copy.Add(new Event(item.x, item.val));
            }
            return copy;

        }
    }
}
