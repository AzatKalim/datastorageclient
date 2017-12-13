using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorageClient
{
    public class DbWork
    {
        const int TRIP_PRICE=100;
        const int TICKET_PRICE = 25;

        dataStorageEntity context;

        public DbWork()
        {
            context = new dataStorageEntity();    
        }

        private driver GetDriver(string driverName)
        {
            foreach (var item in context.driver)
            {
                if (item.name == driverName)
                {
                    return item;
                }
            }
            return null;
        }

        public List<string> GetDriversNames()
        {
            List<string> result = new List<string>();
            foreach (var item in context.driver)
            {
                result.Add(item.name);
            }
            result.Add("Все");
            return result;
        }

        public List<string> GetDispatcherNames()
        {
            List<string> result = new List<string>();
            foreach (var item in context.dispatcher)
            {
                result.Add(item.name);
            }
            result.Add("Все");
            return result;
        }

        public List<string> GetConductorNames()
        {
            List<string> result = new List<string>();
            foreach (var item in context.conductor)
            {
                result.Add(item.Name);
            }
            result.Add("Все");
            return result;
        }

        public List<int> GetRouteNumber()
        {
            List<int> result = new List<int>();
            foreach (var item in context.route)
            {
                result.Add(item.route_number);
            }
            result.Add(-1);
            return result;
        }

        public List<DateTime> GetDatesStart()
        {
            List<DateTime> result = new List<DateTime>();
            foreach (var item in context.trip)
            {
                result.Add((DateTime)item.start_time);
            }
            return result;
        }

        public List<DateTime> GetDatesFinish()
        {
            List<DateTime> result = new List<DateTime>();
            foreach (var item in context.trip)
            {
                result.Add((DateTime)item.finish_time);
            }
            return result;
        }

        public List<trip> GetTrip(String driver, String dispatcher, String conductor, int route)
        {
            var result = new List<trip>();
            foreach (var item in context.trip)
            {
                if(((item.dispatcher.name==dispatcher)|| dispatcher=="Все") &&
                ((item.driver.name==driver)|| driver=="Все") &&
                ((item.conductor.Name==conductor)|| conductor=="Все") && 
                ((item.route.route_number==route) || route==-1))
                {
                    result.Add(item);
                }            
            }
            return result;
        }

        public Tuple<int,int,int> GetDriversProfit(string driverName,DateTime start,DateTime stop)
        {
            driver driv = GetDriver(driverName);
            int tripCount = 0;
            int passCount = 0;
            foreach (var item in context.trip)
            {
                if (item.driver.name == driverName && item.start_time>=start && item.finish_time<=stop)
                {
                    tripCount++;
                    passCount += (int)item.passenger_count;
                }
            }
            return new Tuple<int,int,int>(passCount*TICKET_PRICE -TRIP_PRICE*tripCount,tripCount,passCount);
        }

        public int GetDriverProfit(string driver)
        {
            int sum = 0;
            foreach (var item in context.trip)
            {
                if(item.driver.name==driver)
                {
                    sum += (int)item.passenger_count * TRIP_PRICE;
                }
            }
            return sum;
        }
    }
}
