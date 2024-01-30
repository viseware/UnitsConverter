using System;
using System.Collections.Generic;
using System.Text;
using UnitsConverter.Units;

namespace UnitsConverter
{
    public class ConvertData
    {

        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="data">Type of Unit</param>
        public ConvertData(double value, Data data)
        {
            baseValue = SetBaseValue(value, data);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="data">index of Unit</param>
        public ConvertData(double value, int data)
        {
            baseValue = SetBaseValue(value, (Data)data);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Data data)
        {
            switch (data)
            {
                case Data.b:
                    return value;
                case Data.PB:
                    return MultiplyValue(value, 9.007199254741E+15);
                case Data.TB:
                    return MultiplyValue(value, 8796093022208);
                case Data.GB:
                    return MultiplyValue(value, 8589934592);
                case Data.MB:
                    return MultiplyValue(value, 8388608);
                case Data.kB:
                    return MultiplyValue(value, 8192);
                case Data.B:
                    return MultiplyValue(value, 8);
                case Data.nibble:
                    return MultiplyValue(value, 4);
                case Data.character:
                    return MultiplyValue(value, 8);
                case Data.word:
                    return MultiplyValue(value, 16);
                case Data.block:
                    return MultiplyValue(value, 4096);
                case Data.Pb:
                    return MultiplyValue(value, 1.1258999068426E+15);
                case Data.Tb:
                    return MultiplyValue(value, 1099511627776);
                case Data.Gb:
                    return MultiplyValue(value, 1073741824);
                case Data.Mb:
                    return MultiplyValue(value, 1048576);
                case Data.Kb:
                    return MultiplyValue(value, 1024);
                case Data.fd:
                    return MultiplyValue(value, 5830656);
                case Data.fdHD:
                    return MultiplyValue(value, 11661312);
                case Data.fd5HD:
                    return MultiplyValue(value, 9711616);
                case Data.CD74:
                    return MultiplyValue(value, 5448466432);
                case Data.CD80:
                    return MultiplyValue(value, 5890233976);
                case Data.DVD11:
                    return MultiplyValue(value, 40372692582.4);
                case Data.DVD21:
                    return MultiplyValue(value, 73014444032);
                case Data.DVD12:
                    return MultiplyValue(value, 80745385164.8);
                case Data.DVD22:
                    return MultiplyValue(value, 146028888064);
            }

            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="data">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Data data)
        {
            return ConvertUnit(data);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="data">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int data)
        {
            return ConvertUnit((Data)data);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Data convertTo)
        {
            switch (convertTo)
            {
                case Data.b:
                    return baseValue;
                case Data.PB:
                    return DivideValue(baseValue, 9.007199254741E+15);
                case Data.TB:
                    return DivideValue(baseValue, 8796093022208);
                case Data.GB:
                    return DivideValue(baseValue, 8589934592);
                case Data.MB:
                    return DivideValue(baseValue, 8388608);
                case Data.kB:
                    return DivideValue(baseValue, 8192);
                case Data.B:
                    return DivideValue(baseValue, 8);
                case Data.nibble:
                    return DivideValue(baseValue, 4);
                case Data.character:
                    return DivideValue(baseValue, 8);
                case Data.word:
                    return DivideValue(baseValue, 16);
                case Data.block:
                    return DivideValue(baseValue, 4096);
                case Data.Pb:
                    return DivideValue(baseValue, 1.1258999068426E+15);
                case Data.Tb:
                    return DivideValue(baseValue, 1099511627776);
                case Data.Gb:
                    return DivideValue(baseValue, 1073741824);
                case Data.Mb:
                    return DivideValue(baseValue, 1048576);
                case Data.Kb:
                    return DivideValue(baseValue, 1024);
                case Data.fd:
                    return DivideValue(baseValue, 5830656);
                case Data.fdHD:
                    return DivideValue(baseValue, 11661312);
                case Data.fd5HD:
                    return DivideValue(baseValue, 9711616);
                case Data.CD74:
                    return DivideValue(baseValue, 5448466432);
                case Data.CD80:
                    return DivideValue(baseValue, 5890233976);
                case Data.DVD11:
                    return DivideValue(baseValue, 40372692582.4);
                case Data.DVD21:
                    return DivideValue(baseValue, 73014444032);
                case Data.DVD12:
                    return DivideValue(baseValue, 80745385164.8);
                case Data.DVD22:
                    return DivideValue(baseValue, 146028888064);
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

