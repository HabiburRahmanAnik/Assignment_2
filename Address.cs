using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Address
    {
         private string  roadNo, houseNo, city, country;
     
        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }
        public string RoadNo
        {
            set { this.roadNo = roadNo; }
            get { return this.roadNo; }
        }
        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string City
        {
            set { this.city = city; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }
        public string GetAddress()
        {
            return "Address: " + roadNo + "," + houseNo + "," + city+","+country;
        }
    }
}
