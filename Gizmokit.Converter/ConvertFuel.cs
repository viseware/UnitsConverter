using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;

namespace viseware.GizmokitConvert
{
    public class ConvertFuel
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="fuel">Type of Unit</param>
        public ConvertFuel(double value, Fuel fuel)
        {
            baseValue = SetBaseValue(value, fuel);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="fuel">index of Unit</param>
        public ConvertFuel(double value, int fuel)
        {
            baseValue = SetBaseValue(value, (Fuel)fuel);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Fuel fuel)
        {
            switch (fuel)
            {
                case Fuel.m_L:
                    return value;
                case Fuel.m_galUS:
                    return MultiplyValue(value, 0.2641720524);
                case Fuel.m_galUK:
                    return MultiplyValue(value, 0.2199687986);
                case Fuel.km_L:
                    return MultiplyValue(value, 1000);
                case Fuel.km_galUS:
                    return MultiplyValue(value, 264.1720524);
                case Fuel.mi_L:
                    return MultiplyValue(value, 1609.344);
                case Fuel.mi_galUS:
                    return MultiplyValue(value, 425.1437075);
                case Fuel.mi_galUK:
                    return MultiplyValue(value, 354.00619);
                case Fuel.NM_L:
                    return MultiplyValue(value, 1853.24496);
                case Fuel.NM_galUS:
                    return MultiplyValue(value, 489.5755247);
                case Fuel.m_flozUS:
                    return MultiplyValue(value, 33.8140227);
                case Fuel.m_flozUK:
                    return MultiplyValue(value, 35.19500777);
                case Fuel.L_m:
                    return MultiplyValue(value, 1);
                case Fuel.L_100km:
                    return MultiplyValue(value, 100000);
                case Fuel.gal_miUS:
                    return MultiplyValue(value, 425.1437074976);
                case Fuel.gal_miUK:
                    return MultiplyValue(value, 354.0061899559);
                case Fuel.gal_100miUS:
                    return MultiplyValue(value, 42514.370749763);
                case Fuel.gal_100miUK:
                    return MultiplyValue(value, 35400.618995592);

            }
            throw new Exception("Unable to Convert to base value");
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="fuel">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Fuel fuel)
        {
            return ConvertUnit(fuel);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="fuel">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int fuel)
        {
            return ConvertUnit((Fuel)fuel);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Fuel convertTo)
        {
            switch (convertTo)
            {
                case Fuel.m_L:
                    return baseValue;
                case Fuel.m_galUS:
                    return DivideValue(baseValue, 0.2641720524);
                case Fuel.m_galUK:
                    return DivideValue(baseValue, 0.2199687986);
                case Fuel.km_L:
                    return DivideValue(baseValue, 1000);
                case Fuel.km_galUS:
                    return DivideValue(baseValue, 264.1720524);
                case Fuel.mi_L:
                    return DivideValue(baseValue, 1609.344);
                case Fuel.mi_galUS:
                    return DivideValue(baseValue, 425.1437075);
                case Fuel.mi_galUK:
                    return DivideValue(baseValue, 354.00619);
                case Fuel.NM_L:
                    return DivideValue(baseValue, 1853.24496);
                case Fuel.NM_galUS:
                    return DivideValue(baseValue, 489.5755247);
                case Fuel.m_flozUS:
                    return DivideValue(baseValue, 33.8140227);
                case Fuel.m_flozUK:
                    return DivideValue(baseValue, 35.19500777);
                case Fuel.L_m:
                    return DivideValue(baseValue, 1);
                case Fuel.L_100km:
                    return DivideValue(baseValue, 100000);
                case Fuel.gal_miUS:
                    return DivideValue(baseValue, 425.1437074976);
                case Fuel.gal_miUK:
                    return DivideValue(baseValue, 354.0061899559);
                case Fuel.gal_100miUS:
                    return DivideValue(baseValue, 42514.370749763);
                case Fuel.gal_100miUK:
                    return DivideValue(baseValue, 35400.618995592);
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


