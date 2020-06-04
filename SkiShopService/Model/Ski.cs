using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopService.Model
{
    public class Ski
    {
        private int _id;
        private int _skiLength;
        private string _skiType;
        private int _price;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int SkiLength
        {
            get { return _skiLength; }
            set { _skiLength = value; }
        }

        public string SkiType
        {
            get { return _skiType; }
            set { _skiType = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Ski(int id, int skiLength, string skiType, int price)
        {
            Id = id;
            SkiLength = skiLength;
            SkiType = skiType;
            Price = price;
        }

        public Ski()
        {

        }

    }
}
