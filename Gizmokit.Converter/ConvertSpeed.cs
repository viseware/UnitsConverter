using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;
namespace viseware.GizmokitConvert
{
    class ConvertSpeed
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="speed">Type of Unit</param>
        public ConvertSpeed(double value, Speed speed)
        {
            baseValue = SetBaseValue(value, speed);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="speed">index of Unit</param>
        public ConvertSpeed(double value, int speed)
        {
            baseValue = SetBaseValue(value, (Speed)speed);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Speed speed)
        {
            switch (speed)
            {
                case Speed.m_s:
                    return value;

                case Speed.m_h:
                    return value * 0.0002777778;

                case Speed.m_min:
                    return value * 0.016666667;

                case Speed.km_h:
                    return value * 0.2777777778;

                case Speed.km_min:
                    return value * 16.6666666667;

                case Speed.km_s:
                    return value * 1000;

                case Speed.cm_h:
                    return value * 2.7777777777778E-6;

                case Speed.cm_min:
                    return value * 0.0001666667;

                case Speed.cm_s:
                    return value * 0.01;

                case Speed.mm_h:
                    return value * 2.7777777777778E-7;

                case Speed.mm_min:
                    return value * 1.66667E-5;

                case Speed.mm_s:
                    return value * 0.001;

                case Speed.ft_h:
                    return value * 8.46667E-5;

                case Speed.ft_min:
                    return value * 0.00508;

                case Speed.ft_s:
                    return value * 0.3048;

                case Speed.yd_h:
                    return value * 0.000254;

                case Speed.Yd_min:
                    return value * 0.000254;

                case Speed.Yd_s:
                    return value * 0.9144;

                case Speed.mi_h:
                    return value * 26.8224;

                case Speed.mi_min:
                    return value * 1609.344;

                case Speed.mi_s:
                    return value * 0.514444444;

                case Speed.KT:
                    return value * 0.514773333;

                case Speed.C:
                    return value * 299792458;

                case Speed.Ma:
                    return value * 295.0464;

            }

            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="speed">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>     
        public Double ConvertTo(Speed speed)
        {
            return ConvertUnit(speed);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="temperature">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int speed)
        {
            return ConvertUnit((Speed)speed);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="temperature">unit toconvert to</param>
        /// <returns>converted value</returns>
        public Double ConvertUnit(Speed speed)
        {
            switch (speed)
            {
                case Speed.m_s:
                    return baseValue;

                case Speed.m_h:
                    return baseValue / 0.0002777778;

                case Speed.m_min:
                    return baseValue / 0.016666667;

                case Speed.km_h:
                    return baseValue / 0.2777777778;

                case Speed.km_min:
                    return baseValue / 16.6666666667;

                case Speed.km_s:
                    return baseValue / 1000;

                case Speed.cm_h:
                    return baseValue / 2.7777777777778E-6;

                case Speed.cm_min:
                    return baseValue / 0.0001666667;

                case Speed.cm_s:
                    return baseValue / 0.01;

                case Speed.mm_h:
                    return baseValue / 2.7777777777778E-7;

                case Speed.mm_min:
                    return baseValue / 1.66667E-5;

                case Speed.mm_s:
                    return baseValue / 0.001;

                case Speed.ft_h:
                    return baseValue / 8.46667E-5;

                case Speed.ft_min:
                    return baseValue / 0.00508;

                case Speed.ft_s:
                    return baseValue / 0.3048;

                case Speed.yd_h:
                    return baseValue / 0.000254;

                case Speed.Yd_min:
                    return baseValue / 0.000254;

                case Speed.Yd_s:
                    return baseValue / 0.9144;

                case Speed.mi_h:
                    return baseValue / 26.8224;

                case Speed.mi_min:
                    return baseValue / 1609.344;

                case Speed.mi_s:
                    return baseValue / 0.514444444;

                case Speed.KT:
                    return baseValue / 0.514773333;

                case Speed.C:
                    return baseValue / 299792458;

                case Speed.Ma:
                    return baseValue / 295.0464;
            }
            throw new Exception("Can not convert this type of unit");
        }
    }
}

