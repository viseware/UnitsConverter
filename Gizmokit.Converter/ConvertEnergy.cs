using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;

namespace viseware.GizmokitConvert
{
    public class ConvertEnergy
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="energy">Type of Unit</param>
        public ConvertEnergy(double value, Energy energy)
        {
            baseValue = SetBaseValue(value, energy);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="energy">index of Unit</param>
        public ConvertEnergy(double value, int energy)
        {
            baseValue = SetBaseValue(value, (Energy)energy);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Energy energy)
        {
            switch (energy)
            {
                case Energy.J:
                    return MultiplyValue(value, 1);
                case Energy.GJ:
                    return MultiplyValue(value, 1000000000);
                case Energy.MJ:
                    return MultiplyValue(value, 1000000);
                case Energy.kJ:
                    return MultiplyValue(value, 1000);
                case Energy.mJ:
                    return MultiplyValue(value, 0.001);
                case Energy.µJ:
                    return MultiplyValue(value, 1.0E-6);
                case Energy.nJ:
                    return MultiplyValue(value, 1.0E-9);
                case Energy.GW_h:
                    return MultiplyValue(value, 3600000000000);
                case Energy.MW_h:
                    return MultiplyValue(value, 3600000000);
                case Energy.kW_h:
                    return MultiplyValue(value, 3600000);
                case Energy.W_h:
                    return MultiplyValue(value, 3600);
                case Energy.kW_s:
                    return MultiplyValue(value, 1000);
                case Energy.W_s:
                    return MultiplyValue(value, 1);
                case Energy.kcalIt:
                    return MultiplyValue(value, 4186.8);
                case Energy.kcalTh:
                    return MultiplyValue(value, 4184);
                case Energy.calit:
                    return MultiplyValue(value, 4.1868);
                case Energy.calth:
                    return MultiplyValue(value, 4.184);
                case Energy.cal:
                    return MultiplyValue(value, 4186.8);
                case Energy.hp:
                    return MultiplyValue(value, 2647795.5);
                case Energy.hp_h:
                    return MultiplyValue(value, 2684519.5368856);
                case Energy.MBtu:
                    return MultiplyValue(value, 1055055852.62);
                case Energy.BtuIT:
                    return MultiplyValue(value, 1055.05585262);
                case Energy.Btuth:
                    return MultiplyValue(value, 1054.3499999744);
                case Energy.MeV:
                    return MultiplyValue(value, 1.60217733E-13);
                case Energy.keV:
                    return MultiplyValue(value, 1.60217733E-16);
                case Energy.eV:
                    return MultiplyValue(value, 1.60217733E-19);
                case Energy.N_m:
                    return MultiplyValue(value, 1);
                case Energy.ton_hour:
                    return MultiplyValue(value, 12660670.23144);
                case Energy.Gton:
                    return MultiplyValue(value, 4.184E+18);
                case Energy.Mton:
                    return MultiplyValue(value, 4.184E+15);
                case Energy.kTon:
                    return MultiplyValue(value, 4184000000000);
                case Energy.ton:
                    return MultiplyValue(value, 4184000000);
                case Energy.gf_m:
                    return MultiplyValue(value, 0.00980665);
                case Energy.gf_cm:
                    return MultiplyValue(value, 9.80665E-5);
                case Energy.kgf_cm:
                    return MultiplyValue(value, 0.0980665);
                case Energy.kgf_m:
                    return MultiplyValue(value, 9.8066499997);
                case Energy.kp_m:
                    return MultiplyValue(value, 9.8066499997);
                case Energy.ibf_ft:
                    return MultiplyValue(value, 1.3558179483);
                case Energy.lbf_in:
                    return MultiplyValue(value, 0.112984829);
                case Energy.ozf_in:
                    return MultiplyValue(value, 0.0070615518);
                case Energy.ft_lbf:
                    return MultiplyValue(value, 1.3558179483);
                case Energy.in_lbf:
                    return MultiplyValue(value, 0.112984829);
                case Energy.in_ozf:
                    return MultiplyValue(value, 0.0070615518);
                case Energy.pdl_ft:
                    return MultiplyValue(value, 0.04214011);
                case Energy.therm:
                    return MultiplyValue(value, 105505600);
                case Energy.Hartree:
                    return MultiplyValue(value, 4.3597482E-18);
                case Energy.Rydberg:
                    return MultiplyValue(value, 2.1798741E-18);
            }
            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="energy">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Energy energy)
        {
            return ConvertUnit(energy);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="energy">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int energy)
        {
            return ConvertUnit((Energy)energy);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Energy convertTo)
        {
            switch (convertTo)
            {
                case Energy.J:
                    return baseValue;
                case Energy.GJ:
                    return DivideValue(baseValue, 1000000000);
                case Energy.MJ:
                    return DivideValue(baseValue, 1000000);
                case Energy.kJ:
                    return DivideValue(baseValue, 1000);
                case Energy.mJ:
                    return DivideValue(baseValue, 0.001);
                case Energy.µJ:
                    return DivideValue(baseValue, 1.0E-6);
                case Energy.nJ:
                    return DivideValue(baseValue, 1.0E-9);
                case Energy.GW_h:
                    return DivideValue(baseValue, 3600000000000);
                case Energy.MW_h:
                    return DivideValue(baseValue, 3600000000);
                case Energy.kW_h:
                    return DivideValue(baseValue, 3600000);
                case Energy.W_h:
                    return DivideValue(baseValue, 3600);
                case Energy.kW_s:
                    return DivideValue(baseValue, 1000);
                case Energy.W_s:
                    return DivideValue(baseValue, 1);
                case Energy.kcalIt:
                    return DivideValue(baseValue, 4186.8);
                case Energy.kcalTh:
                    return DivideValue(baseValue, 4184);
                case Energy.calit:
                    return DivideValue(baseValue, 4.1868);
                case Energy.calth:
                    return DivideValue(baseValue, 4.184);
                case Energy.cal:
                    return DivideValue(baseValue, 4186.8);
                case Energy.hp:
                    return DivideValue(baseValue, 2647795.5);
                case Energy.hp_h:
                    return DivideValue(baseValue, 2684519.5368856);
                case Energy.MBtu:
                    return DivideValue(baseValue, 1055055852.62);
                case Energy.BtuIT:
                    return DivideValue(baseValue, 1055.05585262);
                case Energy.Btuth:
                    return DivideValue(baseValue, 1054.3499999744);
                case Energy.MeV:
                    return DivideValue(baseValue, 1.60217733E-13);
                case Energy.keV:
                    return DivideValue(baseValue, 1.60217733E-16);
                case Energy.eV:
                    return DivideValue(baseValue, 1.60217733E-19);
                case Energy.N_m:
                    return DivideValue(baseValue, 1);
                case Energy.ton_hour:
                    return DivideValue(baseValue, 12660670.23144);
                case Energy.Gton:
                    return DivideValue(baseValue, 4.184E+18);
                case Energy.Mton:
                    return DivideValue(baseValue, 4.184E+15);
                case Energy.kTon:
                    return DivideValue(baseValue, 4184000000000);
                case Energy.ton:
                    return DivideValue(baseValue, 4184000000);
                case Energy.gf_m:
                    return DivideValue(baseValue, 0.00980665);
                case Energy.gf_cm:
                    return DivideValue(baseValue, 9.80665E-5);
                case Energy.kgf_cm:
                    return DivideValue(baseValue, 0.0980665);
                case Energy.kgf_m:
                    return DivideValue(baseValue, 9.8066499997);
                case Energy.kp_m:
                    return DivideValue(baseValue, 9.8066499997);
                case Energy.ibf_ft:
                    return DivideValue(baseValue, 1.3558179483);
                case Energy.lbf_in:
                    return DivideValue(baseValue, 0.112984829);
                case Energy.ozf_in:
                    return DivideValue(baseValue, 0.0070615518);
                case Energy.ft_lbf:
                    return DivideValue(baseValue, 1.3558179483);
                case Energy.in_lbf:
                    return DivideValue(baseValue, 0.112984829);
                case Energy.in_ozf:
                    return DivideValue(baseValue, 0.0070615518);
                case Energy.pdl_ft:
                    return DivideValue(baseValue, 0.04214011);
                case Energy.therm:
                    return DivideValue(baseValue, 105505600);
                case Energy.Hartree:
                    return DivideValue(baseValue, 4.3597482E-18);
                case Energy.Rydberg:
                    return DivideValue(baseValue, 2.1798741E-18);
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
