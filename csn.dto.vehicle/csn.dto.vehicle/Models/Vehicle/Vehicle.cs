﻿using System;
using System.Collections.Generic;
using Csn.Public.Dto.Misc;

namespace Csn.Public.Dto.Vehicle
{
    public class Vehicle
    {
        public Vehicle()
        {
            Specification = new VehicleSpecification();
            Seller = new VehicleSeller();
            ComplianceDate = new SimpleDate();
            BuildDate = new SimpleDate();
            Warranty = new VehicleWarranty();
            Identification = new List<TypeValue>();
            Registration = new VehicleRegistration();
        }

        public Guid Identifier { get; set; }
        public string StockNumber { get; set; }

        /* ListingType = [New, Demo, Used] */
        public string ListingType { get; set; }

        /* SaleStatus = [Available, WithDrawn, Sold] */ 
        public string SaleStatus { get; set; }

        /* SaleType = [Sale, Share, Rent, Auction] */
        public string SaleType { get; set; }

        public string Comment { get; set; }

        public VehicleRegistration Registration { get; set; }

        /* Identification Numbers = [HIN, VIN, Engine, Chassis] */
        public List<TypeValue> Identification { get; set; }

        public List<SimpleColour> Colours { get; set; }

        public SimpleValue<double> Odometer { get; set; }
        public VehicleSeller Seller { get; set; }

        public VehicleSpecification Specification { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public Media Media { get; set; }

        public string Group { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }

        public SimpleDate ComplianceDate { get; set; }
        public SimpleDate BuildDate { get; set; }
        public VehicleWarranty Warranty { get; set; }

        public List<NameValue> Services { get; set; }
        public List<NameValue> Tags { get; set; }
        public List<Price> PriceList { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }
    }
}
