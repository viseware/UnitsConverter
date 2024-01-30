using System;
using System.Collections.Generic;
using System.Text;
using UnitsConverter.Units;

namespace viseware.GizmokitConvert
{
    public class ConvertPower
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="power">Type of Unit</param>
        public ConvertPower(double value, Power power)
        {
            baseValue = SetBaseValue(value, power);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="power">index of Unit</param>
        public ConvertPower(double value, int power)
        {
            baseValue = SetBaseValue(value, (Power)power);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Power power)
        {
            switch (power)
            {
                case Power.W:
                    return value;
                case Power.PW:
                    return MultiplyValue(value, 1.0E+15);
                case Power.TW:
                    return MultiplyValue(value, 1000000000000);
                case Power.GW:
                    return MultiplyValue(value, 1000000000);
                case Power.MW:
                    return MultiplyValue(value, 1000000);
                case Power.kW:
                    return MultiplyValue(value, 1000);
                case Power.dW:
                    return MultiplyValue(value, 0.1);
                case Power.cW:
                    return MultiplyValue(value, 0.01);
                case Power.mW:
                    return MultiplyValue(value, 0.001);
                case Power.µW:
                    return MultiplyValue(value, 1.0E-6);
                case Power.nW:
                    return MultiplyValue(value, 1.0E-9);
                case Power.hpM:
                    return MultiplyValue(value, 735.49875);
                case Power.hpE:
                    return MultiplyValue(value, 746);
                case Power.Btu_h:
                    return MultiplyValue(value, 0.2930710702);
                case Power.Btu_min:
                    return MultiplyValue(value, 17.5842642103);
                case Power.Btu_s:
                    return MultiplyValue(value, 1055.05585262);
                case Power.ton:
                    return MultiplyValue(value, 3516.8528420667);
                case Power.kcal_h:
                    return MultiplyValue(value, 1.163);
                case Power.kcal_min:
                    return MultiplyValue(value, 69.78);
                case Power.kcal_s:
                    return MultiplyValue(value, 4186.8);
                case Power.cal_h:
                    return MultiplyValue(value, 0.001163);
                case Power.cal_min:
                    return MultiplyValue(value, 0.06978);
                case Power.cal_s:
                    return MultiplyValue(value, 4.1868);
                case Power.ft_lbf_h:
                    return MultiplyValue(value, 0.0003766161);
                case Power.ft_lbf_min:
                    return MultiplyValue(value, 0.0225969658);
                case Power.ft_lbf_s:
                    return MultiplyValue(value, 1.3558179483);
                case Power.kV_A:
                    return MultiplyValue(value, 1000);
                case Power.V_A:
                    return MultiplyValue(value, 1);
                case Power.N_m_s:
                    return MultiplyValue(value, 1);
                case Power.J_s:
                    return MultiplyValue(value, 1);
                case Power.PJ_s:
                    return MultiplyValue(value, 1.0E+15);
                case Power.TJ_s:
                    return MultiplyValue(value, 1000000000000);
                case Power.GJ_s:
                    return MultiplyValue(value, 1000000000);
                case Power.MJ_s:
                    return MultiplyValue(value, 1000000);
                case Power.kJ_s:
                    return MultiplyValue(value, 1000);
                case Power.dJ_s:
                    return MultiplyValue(value, 0.1);
                case Power.cJ_s:
                    return MultiplyValue(value, 0.01);
                case Power.mJ_s:
                    return MultiplyValue(value, 0.001);
                case Power.µJ_s:
                    return MultiplyValue(value, 1.0E-6);
                case Power.nJ_s:
                    return MultiplyValue(value, 1.0E-9);
                case Power.J_h:
                    return MultiplyValue(value, 0.0002777778);
                case Power.J_min:
                    return MultiplyValue(value, 0.0166666667);
                case Power.kJ_h:
                    return MultiplyValue(value, 0.2777777778);
                case Power.kJ_min:
                    return MultiplyValue(value, 16.6666666667);
            }

            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="power">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Power power)
        {
            return ConvertUnit(power);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="power">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int power)
        {
            return ConvertUnit((Power)power);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Power convertTo)
        {
            switch (convertTo)
            {
                case Power.W:
                    return DivideValue(baseValue, 1);
                case Power.PW:
                    return DivideValue(baseValue, 1.0E+15);
                case Power.TW:
                    return DivideValue(baseValue, 1000000000000);
                case Power.GW:
                    return DivideValue(baseValue, 1000000000);
                case Power.MW:
                    return DivideValue(baseValue, 1000000);
                case Power.kW:
                    return DivideValue(baseValue, 1000);
                case Power.dW:
                    return DivideValue(baseValue, 0.1);
                case Power.cW:
                    return DivideValue(baseValue, 0.01);
                case Power.mW:
                    return DivideValue(baseValue, 0.001);
                case Power.µW:
                    return DivideValue(baseValue, 1.0E-6);
                case Power.nW:
                    return DivideValue(baseValue, 1.0E-9);
                case Power.hpM:
                    return DivideValue(baseValue, 735.49875);
                case Power.hpE:
                    return DivideValue(baseValue, 746);
                case Power.Btu_h:
                    return DivideValue(baseValue, 0.2930710702);
                case Power.Btu_min:
                    return DivideValue(baseValue, 17.5842642103);
                case Power.Btu_s:
                    return DivideValue(baseValue, 1055.05585262);
                case Power.ton:
                    return DivideValue(baseValue, 3516.8528420667);
                case Power.kcal_h:
                    return DivideValue(baseValue, 1.163);
                case Power.kcal_min:
                    return DivideValue(baseValue, 69.78);
                case Power.kcal_s:
                    return DivideValue(baseValue, 4186.8);
                case Power.cal_h:
                    return DivideValue(baseValue, 0.001163);
                case Power.cal_min:
                    return DivideValue(baseValue, 0.06978);
                case Power.cal_s:
                    return DivideValue(baseValue, 4.1868);
                case Power.ft_lbf_h:
                    return DivideValue(baseValue, 0.0003766161);
                case Power.ft_lbf_min:
                    return DivideValue(baseValue, 0.0225969658);
                case Power.ft_lbf_s:
                    return DivideValue(baseValue, 1.3558179483);
                case Power.kV_A:
                    return DivideValue(baseValue, 1000);
                case Power.V_A:
                    return DivideValue(baseValue, 1);
                case Power.N_m_s:
                    return DivideValue(baseValue, 1);
                case Power.J_s:
                    return DivideValue(baseValue, 1);
                case Power.PJ_s:
                    return DivideValue(baseValue, 1.0E+15);
                case Power.TJ_s:
                    return DivideValue(baseValue, 1000000000000);
                case Power.GJ_s:
                    return DivideValue(baseValue, 1000000000);
                case Power.MJ_s:
                    return DivideValue(baseValue, 1000000);
                case Power.kJ_s:
                    return DivideValue(baseValue, 1000);
                case Power.dJ_s:
                    return DivideValue(baseValue, 0.1);
                case Power.cJ_s:
                    return DivideValue(baseValue, 0.01);
                case Power.mJ_s:
                    return DivideValue(baseValue, 0.001);
                case Power.µJ_s:
                    return DivideValue(baseValue, 1.0E-6);
                case Power.nJ_s:
                    return DivideValue(baseValue, 1.0E-9);
                case Power.J_h:
                    return DivideValue(baseValue, 0.0002777778);
                case Power.J_min:
                    return DivideValue(baseValue, 0.0166666667);
                case Power.kJ_h:
                    return DivideValue(baseValue, 0.2777777778);
                case Power.kJ_min:
                    return DivideValue(baseValue, 16.6666666667);
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

