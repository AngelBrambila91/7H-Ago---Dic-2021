using System;

namespace Shared
{
    public class BusinessClassPasenger
    {
        public override string ToString()
        {
            return $"Business Class";
        }
    }

    public class FirstClassPaseenger
    {
        public int AirMiles { get; set; }
        public override string ToString()
        {
            return $"First Class with {AirMiles:N0} air miles";
        }
    }

    public class CoachClassPassenger
    {
        public double CarryOnKG { get; set; }
        public override string ToString()
        {
            return $"Coach class with {CarryOnKG:N2} KG carry on";
        }
    }
}
