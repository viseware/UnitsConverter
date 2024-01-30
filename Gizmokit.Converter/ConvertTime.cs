using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;

namespace viseware.GizmokitConvert
{
    public class ConvertTime
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="time">Type of Unit</param>
        public ConvertTime(double value, Time time)
        {
            baseValue = SetBaseValue(value, time);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="time">index of Unit</param>
        public ConvertTime(double value, int time)
        {
            baseValue = SetBaseValue(value, (Time)time);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Time time)
        {
            switch (time)
            {
                case Time.s:
                    return value;

                case Time.ns:
                    return value / 1E+9;

                case Time.μs:
                    return value / 1E+6;

                case Time.ms:
                    return value / 1000;

                case Time.min:
                    return value * 60;

                case Time.hr:
                    return value * 3600;

                case Time.days:
                    return value * 86400;

                case Time.week:
                    return value * 604800;

                case Time.fortnight:
                    return value * 1209600;

                case Time.month:
                    return value * 2628000;

                case Time.year:
                    return value * 31557600;

                case Time.decade:
                    return value * 315360000;

                case Time.Century:
                    return value * 3153600000;
            }

            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="time">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Time time)
        {
            return ConvertUnit(time);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="time">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int time)
        {
            return ConvertUnit((Time)time);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Time convertTo)
        {
            switch (convertTo)
            {
                case Time.s:
                    return baseValue;

                case Time.ns:
                    return baseValue * 1E+9;

                case Time.μs:
                    return baseValue * 1E+6;

                case Time.ms:
                    return baseValue * 1000;

                case Time.min:
                    return baseValue / 60;

                case Time.hr:
                    return baseValue / 3600;

                case Time.days:
                    return baseValue / 86400;

                case Time.week:
                    return baseValue / 604800;

                case Time.fortnight:
                    return baseValue / 1209600;

                case Time.month:
                    return baseValue / 2628000;

                case Time.year:
                    return baseValue / 31557600;

                case Time.decade:
                    return baseValue / 315360000;

                case Time.Century:
                    return baseValue / 3153600000;
            }
            throw new Exception("Can not convert this type of unit");
        }
    }
}

