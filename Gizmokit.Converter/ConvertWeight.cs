using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;

namespace viseware.GizmokitConvert
{
    class ConvertWeight
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="weight">Type of Unit</param>
        public ConvertWeight(double value, Weight weight)
        {
            baseValue = SetBaseValue(value, weight);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="weight">index of Unit</param>
        public ConvertWeight(double value, int weight)
        {
            baseValue = SetBaseValue(value, (Weight)weight);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Weight weight)
        {
            switch (weight)
            {
                case Weight.kg:
                    return MultiplyValue(value, 1);
                case Weight.g:
                    return MultiplyValue(value, 0.001);
                case Weight.dg:
                    return MultiplyValue(value, 0.0001);
                case Weight.cg:
                    return MultiplyValue(value, 1.0E-5);
                case Weight.mg:
                    return MultiplyValue(value, 1.0e-6);
                case Weight.µg:
                    return MultiplyValue(value, 10e-9);
                case Weight.ng:
                    return MultiplyValue(value, 1.0e-12);
                case Weight.t:
                    return MultiplyValue(value, 1000);
                case Weight.kt:
                    return MultiplyValue(value, 1000000);
                case Weight.ibs:
                    return MultiplyValue(value, 0.45359237);
                case Weight.oz:
                    return MultiplyValue(value, 0.0283495231);
                case Weight.car:
                    return MultiplyValue(value, 0.0002);
                case Weight.u:
                    return MultiplyValue(value, 1.6605402E-27);
                case Weight.stoneUS:
                    return MultiplyValue(value, 5.669904625);
                case Weight.stoneUK:
                    return MultiplyValue(value, 6.35029318);
                case Weight.pwt:
                    return MultiplyValue(value, 0.0015551738);
                case Weight.gr:
                    return MultiplyValue(value, 6.47989e-5);
                case Weight.mp:
                    return MultiplyValue(value, 2.17671E-8);
                case Weight.me:
                    return MultiplyValue(value, 9.1093897E-31);
                case Weight.mm:
                    return MultiplyValue(value, 1.8835327E-28);
                case Weight.pm:
                    return MultiplyValue(value, 1.6726231E-27);
                case Weight.mn:
                    return MultiplyValue(value, 1.6749286E-27);
                case Weight.md:
                    return MultiplyValue(value, 3.343586E-27);
                case Weight.em:
                    return MultiplyValue(value, 5.9760000000002E+24);
                case Weight.sm:
                    return MultiplyValue(value, 2.0E+30);
            }
            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="weight">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Weight weight)
        {
            return ConvertUnit(weight);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="weight">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int weight)
        {
            return ConvertUnit((Weight)weight);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Weight convertTo)
        {
            switch (convertTo)
            {
                case Weight.kg:
                    return DivideValue(baseValue, 1);
                case Weight.g:
                    return DivideValue(baseValue, 0.001);
                case Weight.dg:
                    return DivideValue(baseValue, 0.0001);
                case Weight.cg:
                    return DivideValue(baseValue, 1.0E-5);
                case Weight.mg:
                    return DivideValue(baseValue, 1.0e-6);
                case Weight.µg:
                    return DivideValue(baseValue, 10e-9);
                case Weight.ng:
                    return DivideValue(baseValue, 1.0e-12);
                case Weight.t:
                    return DivideValue(baseValue, 1000);
                case Weight.kt:
                    return DivideValue(baseValue, 1000000);
                case Weight.ibs:
                    return DivideValue(baseValue, 0.45359237);
                case Weight.oz:
                    return DivideValue(baseValue, 0.0283495231);
                case Weight.car:
                    return DivideValue(baseValue, 0.0002);
                case Weight.u:
                    return DivideValue(baseValue, 1.6605402E-27);
                case Weight.stoneUS:
                    return DivideValue(baseValue, 5.669904625);
                case Weight.stoneUK:
                    return DivideValue(baseValue, 6.35029318);
                case Weight.pwt:
                    return DivideValue(baseValue, 0.0015551738);
                case Weight.gr:
                    return DivideValue(baseValue, 6.47989e-5);
                case Weight.mp:
                    return DivideValue(baseValue, 2.17671E-8);
                case Weight.me:
                    return DivideValue(baseValue, 9.1093897E-31);
                case Weight.mm:
                    return DivideValue(baseValue, 1.8835327E-28);
                case Weight.pm:
                    return DivideValue(baseValue, 1.6726231E-27);
                case Weight.mn:
                    return DivideValue(baseValue, 1.6749286E-27);
                case Weight.md:
                    return DivideValue(baseValue, 3.343586E-27);
                case Weight.em:
                    return DivideValue(baseValue, 5.9760000000002E+24);
                case Weight.sm:
                    return DivideValue(baseValue, 2.0E+30);

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

