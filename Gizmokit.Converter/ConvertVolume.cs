using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;

namespace viseware.GizmokitConvert
{
    public class ConvertVolume
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="volume">Type of Unit</param>
        public ConvertVolume(double value, Volume volume)
        {
            baseValue = SetBaseValue(value, volume);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="volume">index of Unit</param>
        public ConvertVolume(double value, int volume)
        {
            baseValue = SetBaseValue(value, (Volume)volume);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Volume volume)
        {
            switch (volume)
            {
                case Volume.m3:
                    return value;
                case Volume.km3:
                    return MultiplyValue(value, 1000000000);
                case Volume.dm3:
                    return MultiplyValue(value, 0.001);
                case Volume.cm3:
                    return MultiplyValue(value, 1.0E-6);
                case Volume.mm3:
                    return MultiplyValue(value, 1.0E-9);
                case Volume.GL:
                    return MultiplyValue(value, 1000000);
                case Volume.ML:
                    return MultiplyValue(value, 1000);
                case Volume.kL:
                    return MultiplyValue(value, 1);
                case Volume.L:
                    return MultiplyValue(value, 0.001);
                case Volume.dL:
                    return MultiplyValue(value, 0.0001);
                case Volume.cL:
                    return MultiplyValue(value, 1.0E-5);
                case Volume.mL:
                    return MultiplyValue(value, 1.0E-6);
                case Volume.µL:
                    return MultiplyValue(value, 1.0E-9);
                case Volume.nL:
                    return MultiplyValue(value, 1.0E-12);
                case Volume.galUS:
                    return MultiplyValue(value, 0.0037854118);
                case Volume.galUk:
                    return MultiplyValue(value, 0.00454609);
                case Volume.ptUS:
                    return MultiplyValue(value, 0.0004731765);
                case Volume.ptUk:
                    return MultiplyValue(value, 0.0005682613);
                case Volume.cup:
                    return MultiplyValue(value, 0.00025);
                case Volume.tablespoon:
                    return MultiplyValue(value, 1.5E-5);
                case Volume.teaspoon:
                    return MultiplyValue(value, 5.0E-6);
                case Volume.mi3:
                    return MultiplyValue(value, 4168181825.4406);
                case Volume.yd3:
                    return MultiplyValue(value, 0.764554858);
                case Volume.ft3:
                    return MultiplyValue(value, 0.0283168466);
                case Volume.in3:
                    return MultiplyValue(value, 1.63871E-5);
                case Volume.cc:
                    return MultiplyValue(value, 1.0E-6);
                case Volume.drop:
                    return MultiplyValue(value, 5.0E-8);
                case Volume.bbl:
                    return MultiplyValue(value, 0.1581);
                case Volume.flozUS:
                    return MultiplyValue(value, 2.95735E-5);
                case Volume.flozUK:
                    return MultiplyValue(value, 2.84131E-5);
                case Volume.CCF:
                    return MultiplyValue(value, 2.8316846592);
                case Volume.ac_ft:
                    return MultiplyValue(value, 1233.4818375475);
                case Volume.ac_in:
                    return MultiplyValue(value, 102.790153129);
                case Volume.EV:
                    return MultiplyValue(value, 1.083E+21);

            }
            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="volume">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Volume volume)
        {
            return ConvertUnit(volume);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="volume">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int volume)
        {
            return ConvertUnit((Volume)volume);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Volume convertTo)
        {
            switch (convertTo)
            {
                case Volume.m3:
                    return DivideValue(baseValue, 1);
                case Volume.km3:
                    return DivideValue(baseValue, 1000000000);
                case Volume.dm3:
                    return DivideValue(baseValue, 0.001);
                case Volume.cm3:
                    return DivideValue(baseValue, 1.0E-6);
                case Volume.mm3:
                    return DivideValue(baseValue, 1.0E-9);
                case Volume.GL:
                    return DivideValue(baseValue, 1000000);
                case Volume.ML:
                    return DivideValue(baseValue, 1000);
                case Volume.kL:
                    return DivideValue(baseValue, 1);
                case Volume.L:
                    return DivideValue(baseValue, 0.001);
                case Volume.dL:
                    return DivideValue(baseValue, 0.0001);
                case Volume.cL:
                    return DivideValue(baseValue, 1.0E-5);
                case Volume.mL:
                    return DivideValue(baseValue, 1.0E-6);
                case Volume.µL:
                    return DivideValue(baseValue, 1.0E-9);
                case Volume.nL:
                    return DivideValue(baseValue, 1.0E-12);
                case Volume.galUS:
                    return DivideValue(baseValue, 0.0037854118);
                case Volume.galUk:
                    return DivideValue(baseValue, 0.00454609);
                case Volume.ptUS:
                    return DivideValue(baseValue, 0.0004731765);
                case Volume.ptUk:
                    return DivideValue(baseValue, 0.0005682613);
                case Volume.cup:
                    return DivideValue(baseValue, 0.00025);
                case Volume.tablespoon:
                    return DivideValue(baseValue, 1.5E-5);
                case Volume.teaspoon:
                    return DivideValue(baseValue, 5.0E-6);
                case Volume.mi3:
                    return DivideValue(baseValue, 4168181825.4406);
                case Volume.yd3:
                    return DivideValue(baseValue, 0.764554858);
                case Volume.ft3:
                    return DivideValue(baseValue, 0.0283168466);
                case Volume.in3:
                    return DivideValue(baseValue, 1.63871E-5);
                case Volume.cc:
                    return DivideValue(baseValue, 1.0E-6);
                case Volume.drop:
                    return DivideValue(baseValue, 5.0E-8);
                case Volume.bbl:
                    return DivideValue(baseValue, 0.1581);
                case Volume.flozUS:
                    return DivideValue(baseValue, 2.95735E-5);
                case Volume.flozUK:
                    return DivideValue(baseValue, 2.84131E-5);
                case Volume.CCF:
                    return DivideValue(baseValue, 2.8316846592);
                case Volume.ac_ft:
                    return DivideValue(baseValue, 1233.4818375475);
                case Volume.ac_in:
                    return DivideValue(baseValue, 102.790153129);
                case Volume.EV:
                    return DivideValue(baseValue, 1.083E+21);

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

