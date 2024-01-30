using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;

namespace viseware.GizmokitConvert
{
    public class ConvertTemperature
    {
        //Holds the converted value
        private double baseValue;


        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="temperature">Type of Unit</param>
        public ConvertTemperature(double value, Temperature temperature)
        {
            baseValue = SetBaseValue(value, temperature);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="temperature">index of Unit</param>
        public ConvertTemperature(double value, int temperature)
        {
            baseValue = SetBaseValue(value, (Temperature)temperature);
        }


        //Set the values to the base unit
        private double SetBaseValue(double value, Temperature temperature)
        {
            switch (temperature)
            {
                case Temperature.C:
                    return value + 273.15;

                case Temperature.K:
                    return value;

                case Temperature.F:
                    return (value - 32) * 5 / 9 + 273.15;
            }

            throw new Exception("Unable to Convert to base value");
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="temperature">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Temperature temperature)
        {
            return ConvertUnit(temperature);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="temperature">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int temperature)
        {
            return ConvertUnit((Temperature)temperature);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="temperature">unit toconvert to</param>
        /// <returns>converted value</returns>
        private double ConvertUnit(Temperature temperature)
        {
            switch (temperature)
            {
                case Temperature.K:
                    return baseValue;

                case Temperature.C:
                    return baseValue - 273.15;

                case Temperature.F:
                    return (baseValue - 273.15) * 9 / 5 + 32;
            }
            throw new Exception("Can not convert this type of unit");
        }
    }
}


