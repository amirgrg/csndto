﻿namespace Csn.Public.Dto.Misc
{
    public class NameValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class TypeValue
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class SimpleDate
    {
        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }

    public class SimpleValue<T>
    {
        public T Value { get; set; }
        /* use valid SI units of measure, e.g. KM, M. */
        public string UnitOfMeasure { get; set; }
    }

    public class SimpleColour
    {
        /* Location = [Interior, Exterior, Bumber, etc.] */
        public string Location { get; set; }
        /* GenericName = [Black, Blue, Grey, White, Gold, Silver, Red, Yellow, Purple, Green, Brown] */
        public string GenericName { get; set; }
        /* the manufacturer or friendly name */
        public string Name { get; set; }
    }

    public class Price
    {
        /* Type = [RRP, EGC, IGC, WHS etc.] */
        public string Type { get; set; }
        
        public string Location { get; set; }

        /* ISO monetary units: Currency = [USD, AUD, EUR] */
        public string Currency { get; set; }
        public double? Amount { get; set; }
    }
}
