using System;
using System.Collections.Generic;
using System.Text;
using UnitsConverter.Units;
namespace viseware.GizmokitConvert
{
    public class ConvertLength
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="length">Type of Unit</param>
        public ConvertLength(double value, Length length)
        {
            baseValue = SetBaseValue(value, length);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="length">index of Unit</param>
        public ConvertLength(double value, int length)
        {
            baseValue = SetBaseValue(value, (Length)length);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Length length)
        {
            switch (length)
            {
                case Length.m:
                    return value;

                case Length.km:
                    return MultiplyValue(value, 1000);

                case Length.dm:
                    return MultiplyValue(value, 0.1);

                case Length.cm:
                    return MultiplyValue(value, 0.01);

                case Length.mm:
                    return MultiplyValue(value, 0.001);

                case Length.µm:
                    return MultiplyValue(value, 1000000);

                case Length.nm:
                    return MultiplyValue(value, 1.0e-9);

                case Length.@in:
                    return MultiplyValue(value, 0.0254);

                case Length.mi:
                    return MultiplyValue(value, 1609.344);

                case Length.yd:
                    return MultiplyValue(value, 0.9144);

                case Length.ft:
                    return MultiplyValue(value, 0.3048);

                case Length.LY:
                    return MultiplyValue(value, 9.46073047258E+15);

                case Length.µ:
                    return MultiplyValue(value, 1000000);

                case Length.NM:
                    return MultiplyValue(value, 1852);

                case Length.Kpc:
                    return MultiplyValue(value, 3.08567758128E+19);

                case Length.pc:
                    return MultiplyValue(value, 3.08567758128E+16);

                case Length.AU:
                    return MultiplyValue(value, 149597870691);

                case Length.ℓP:
                    return MultiplyValue(value, 1.61605E-35);

                case Length.e:
                    return MultiplyValue(value, 2.81794092E-15);

                case Length.SR:
                    return MultiplyValue(value, 696000000);

                case Length.Banana:
                    return MultiplyValue(value, 0.178);

                case Length.Football:
                    return MultiplyValue(value, 91.44);
            }
            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="length">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Length length)
        {
            return ConvertUnit(length);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="length">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int length)
        {
            return ConvertUnit((Length)length);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Length convertTo)
        {
            switch (convertTo)
            {
                case Length.m:
                    return baseValue;
                case Length.km:
                    return DivideValue(baseValue, 1000);
                case Length.dm:
                    return DivideValue(baseValue, 0.1);
                case Length.cm:
                    return DivideValue(baseValue, 0.01);
                case Length.mm:
                    return DivideValue(baseValue, 0.001);
                case Length.µm:
                    return DivideValue(baseValue, 1000000);
                case Length.nm:
                    return DivideValue(baseValue, 1.0E-9);
                case Length.@in:
                    return DivideValue(baseValue, 0.0254);
                case Length.mi:
                    return DivideValue(baseValue, 1609.344);
                case Length.yd:
                    return DivideValue(baseValue, 0.9144);
                case Length.ft:
                    return DivideValue(baseValue, 0.3048);
                case Length.LY:
                    return DivideValue(baseValue, 9.46073047258E+15);
                case Length.µ:
                    return DivideValue(baseValue, 1000000);
                case Length.NM:
                    return DivideValue(baseValue, 1852);
                case Length.Kpc:
                    return DivideValue(baseValue, 3.08567758128E+19);
                case Length.pc:
                    return DivideValue(baseValue, 3.08567758128E+16);
                case Length.AU:
                    return DivideValue(baseValue, 149597870691);
                case Length.ℓP:
                    return DivideValue(baseValue, 1.61605E-35);
                case Length.e:
                    return DivideValue(baseValue, 2.81794092E-15);
                case Length.SR:
                    return DivideValue(baseValue, 696000000);
                case Length.Banana:
                    return DivideValue(baseValue, 0.178);
                case Length.Football:
                    return DivideValue(baseValue, 91.44);
            }
            throw new Exception("Can not convert this type of unit");
        }

        //multiplay valuse
        public double MultiplyValue(double value1, double value2)
        {
            return (value1 * value2);
        }

        //devide value
        public double DivideValue(double value1, double value2)
        {
            return (value1 / value2);
        }

    }
}

