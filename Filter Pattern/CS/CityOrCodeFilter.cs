﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Filter
{
    public class CityOrCodeFilter : OrFilter
    {
        private readonly string _city;
        private readonly string _barcode;

        public CityOrCodeFilter(string city, string barcode)
        {
            this._barcode = barcode;
            this._city = city;
        }
        
        public override List<Item> MatchItems(List<Item> items)
        {
            return items.Where(item => item.GetCity().Equals(this._city) || item.GetBarcode().Equals(this._barcode)).ToList();
        }
    }
}