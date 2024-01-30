using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;
namespace viseware.GizmokitConvert
{
    public class ConvertForce
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="force">Type of Unit</param>
        public ConvertForce(double value, Force force)
        {
            baseValue = SetBaseValue(value, force);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="force">index of Unit</param>
        public ConvertForce(double value, int force)
        {
            baseValue = SetBaseValue(value, (Force)force);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Force force)
        {
            switch (force)
            {
                case Force.N:
                    return value;
                case Force.GN:
                    return MultiplyValue(value, 1000000000);
                case Force.MN:
                    return MultiplyValue(value, 1000000);
                case Force.kN:
                    return MultiplyValue(value, 1000);
                case Force.dN:
                    return MultiplyValue(value, 0.1);
                case Force.cN:
                    return MultiplyValue(value, 0.01);
                case Force.mN:
                    return MultiplyValue(value, 0.001);
                case Force.µN:
                    return MultiplyValue(value, 1.0E-6);
                case Force.nN:
                    return MultiplyValue(value, 1.0E-9);
                case Force.tf:
                    return MultiplyValue(value, 9806.65);
                case Force.kgf:
                    return MultiplyValue(value, 9.80665);
                case Force.gf:
                    return MultiplyValue(value, 0.00980665);
                case Force.J_m:
                    return MultiplyValue(value, 1);
                case Force.J_cm:
                    return MultiplyValue(value, 0.01);
                case Force.ton_force:
                    return MultiplyValue(value, 8896.443230521);
                case Force.ton_fL:
                    return MultiplyValue(value, 9964.0164181707);
                case Force.kipf:
                    return MultiplyValue(value, 4448.2216152548);
                case Force.lbf:
                    return MultiplyValue(value, 4.4482216153);
                case Force.ozf:
                    return MultiplyValue(value, 0.278013851);
                case Force.pdf:
                    return MultiplyValue(value, 0.1382549544);
                case Force.p:
                    return MultiplyValue(value, 0.00980665);
                case Force.kp:
                    return MultiplyValue(value, 9.80665);

            }
            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="force">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Force force)
        {
            return ConvertUnit(force);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="force">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int force)
        {
            return ConvertUnit((Force)force);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Force convertTo)
        {
            switch (convertTo)
            {
                case Force.N:
                    return DivideValue(baseValue, 1);
                case Force.GN:
                    return DivideValue(baseValue, 1000000000);
                case Force.MN:
                    return DivideValue(baseValue, 1000000);
                case Force.kN:
                    return DivideValue(baseValue, 1000);
                case Force.dN:
                    return DivideValue(baseValue, 0.1);
                case Force.cN:
                    return DivideValue(baseValue, 0.01);
                case Force.mN:
                    return DivideValue(baseValue, 0.001);
                case Force.µN:
                    return DivideValue(baseValue, 1.0E-6);
                case Force.nN:
                    return DivideValue(baseValue, 1.0E-9);
                case Force.tf:
                    return DivideValue(baseValue, 9806.65);
                case Force.kgf:
                    return DivideValue(baseValue, 9.80665);
                case Force.gf:
                    return DivideValue(baseValue, 0.00980665);
                case Force.J_m:
                    return DivideValue(baseValue, 1);
                case Force.J_cm:
                    return DivideValue(baseValue, 0.01);
                case Force.ton_force:
                    return DivideValue(baseValue, 8896.443230521);
                case Force.ton_fL:
                    return DivideValue(baseValue, 9964.0164181707);
                case Force.kipf:
                    return DivideValue(baseValue, 4448.2216152548);
                case Force.lbf:
                    return DivideValue(baseValue, 4.4482216153);
                case Force.ozf:
                    return DivideValue(baseValue, 0.278013851);
                case Force.pdf:
                    return DivideValue(baseValue, 0.1382549544);
                case Force.p:
                    return DivideValue(baseValue, 0.00980665);
                case Force.kp:
                    return DivideValue(baseValue, 9.80665);
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

