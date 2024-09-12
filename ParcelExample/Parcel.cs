using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class Parcel
    {
        public string id;
        public bool delivered;
        public int val;
        public string description;

        public override string ToString()
        {
            return string.Format("ID {0} Value {1} Description {2} Delivered {3}", id, val, description, delivered ? "Yes" : "No");
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            List<Parcel> parcels = new List<Parcel>()
            {
            new Parcel { id= Guid.NewGuid().ToString(), delivered = (r.Next(0,2)==1?true:false), val = 100, description = "Computer Parts"},
              new Parcel { id= Guid.NewGuid().ToString(), delivered = (r.Next(0,2)==1?true:false), val = r.Next(100,200), description = " Amazon thing I didn't need"},
                new Parcel { id= Guid.NewGuid().ToString(), delivered = (r.Next(0,2)==1?true:false), val = 300, description = "Temu Junk"},
                  new Parcel { id= Guid.NewGuid().ToString(), delivered = (r.Next(0,2)==1?true:false), val = r.Next(100,200), description = "Book"},
                    new Parcel { id= Guid.NewGuid().ToString(), delivered = (r.Next(0,2)==1?true:false), val = r.Next(100,200), description = "Garden Tools"},
            };

            // standard loops
            foreach (var item in parcels)
            {
                if (item.delivered)
                    Console.WriteLine("Delivered {0} with value {1}", item.description, item.val);
                else
                    Console.WriteLine("Not delivered {0} with value {1}", item.description, item.val);
            }


            var delivered = parcels.Where(s => s.delivered == true);

            foreach (var item in delivered)
                Console.WriteLine("Delivered {0}", item);

            var orderedNotDelivered = parcels
                                        .Where(s => s.delivered == false)
                                        .OrderByDescending(s => s.val);

            foreach (var item in orderedNotDelivered)
                Console.WriteLine("Ordered descending Not delivered {0}", item);
        }
    }
}
