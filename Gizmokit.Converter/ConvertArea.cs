using System;
using Gizmokit.Converter.Units;

namespace Gizmokit.Converter
{
    public class ConvertArea
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="area">Type of Unit</param>
        public ConvertArea(double value, Area area)
        {
            baseValue = SetBaseValue(value, area);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="area">index of Unit</param>
        public ConvertArea(double value, int area)
        {
            baseValue = SetBaseValue(value, (Area)area);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Area area)
        {
            switch (area)
            {
                case Area.m2:
                    return value;
                case Area.km2:
                    return MultiplyValue(value, 1000000);
                case Area.dm2:
                    return MultiplyValue(value, 0.01);
                case Area.cm2:
                    return MultiplyValue(value, 0.0001);
                case Area.mm2:
                    return MultiplyValue(value, 1.0E-6);
                case Area.µm2:
                    return MultiplyValue(value, 1.0E-12);
                case Area.nm2:
                    return MultiplyValue(value, 1.0E-18);
                case Area.ha:
                    return MultiplyValue(value, 10000);
                case Area.ac:
                    return MultiplyValue(value, 4046.8564224);
                case Area.mi2:
                    return MultiplyValue(value, 2589988.110336);
                case Area.yd2:
                    return MultiplyValue(value, 0.83612736);
                case Area.ft2:
                    return MultiplyValue(value, 0.09290304);
                case Area.hm2:
                    return MultiplyValue(value, 10000);
                case Area.a2:
                    return MultiplyValue(value, 100);
                case Area.b2:
                    return MultiplyValue(value, 1.0E-28);
                case Area.ecr:
                    return MultiplyValue(value, 6.6524615999999E-29);

            }

            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="area">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Area area)
        {
            return ConvertUnit(area);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="area">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int area)
        {
            return ConvertUnit((Area)area);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Area convertTo)
        {
            switch (convertTo)
            {
                case Area.m2:
                    return baseValue;
                case Area.km2:
                    return DivideValue(baseValue, 1000000);
                case Area.dm2:
                    return DivideValue(baseValue, 0.01);
                case Area.cm2:
                    return DivideValue(baseValue, 0.0001);
                case Area.mm2:
                    return DivideValue(baseValue, 1.0E-6);
                case Area.µm2:
                    return DivideValue(baseValue, 1.0E-12);
                case Area.nm2:
                    return DivideValue(baseValue, 1.0E-18);
                case Area.ha:
                    return DivideValue(baseValue, 10000);
                case Area.ac:
                    return DivideValue(baseValue, 4046.8564224);
                case Area.mi2:
                    return DivideValue(baseValue, 2589988.110336);
                case Area.yd2:
                    return DivideValue(baseValue, 0.83612736);
                case Area.ft2:
                    return DivideValue(baseValue, 0.09290304);
                case Area.hm2:
                    return DivideValue(baseValue, 10000);
                case Area.a2:
                    return DivideValue(baseValue, 100);
                case Area.b2:
                    return DivideValue(baseValue, 1.0E-28);
                case Area.ecr:
                    return DivideValue(baseValue, 6.6524615999999E-29);

            }

            throw new Exception("Can not convert this type of unit");
        }

        //multiply values
        public double MultiplyValue(double value1, double value2)
        {
            return (value1 * value2);
        }

        //divide value
        public double DivideValue(double value1, double value2)
        {
            return (value1 / value2);
        }
    }
}

