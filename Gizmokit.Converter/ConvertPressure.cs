using System;
using System.Collections.Generic;
using System.Text;
using Gizmokit.Converter.Units;
namespace viseware.GizmokitConvert
{
    public class ConvertPressure
    {
        //Holds the converted value
        private double baseValue;

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="pressure">Type of Unit</param>
        public ConvertPressure(double value, Pressure pressure)
        {
            baseValue = SetBaseValue(value, pressure);
        }

        /// <summary>
        /// Set the values
        /// </summary>
        /// <param name="value">Value of the Unit</param>
        /// <param name="pressure">index of Unit</param>
        public ConvertPressure(double value, int pressure)
        {
            baseValue = SetBaseValue(value, (Pressure)pressure);
        }

        //Set the values to the base unit
        private double SetBaseValue(double value, Pressure pressure)
        {
            switch (pressure)
            {
                case Pressure.Pa:
                    return value;
                case Pressure.kPa:
                    return MultiplyValue(value, 1000);
                case Pressure.dPa:
                    return MultiplyValue(value, 0.1);
                case Pressure.cPa:
                    return MultiplyValue(value, 0.01);
                case Pressure.mPa:
                    return MultiplyValue(value, 0.001);
                case Pressure.µPa:
                    return MultiplyValue(value, 1.0E-6);
                case Pressure.nPa:
                    return MultiplyValue(value, 1.0E-9);
                case Pressure.bar:
                    return MultiplyValue(value, 100000);
                case Pressure.mbar:
                    return MultiplyValue(value, 100);
                case Pressure.µbar:
                    return MultiplyValue(value, 0.1);
                case Pressure.psi:
                    return MultiplyValue(value, 6894.7572931783);
                case Pressure.ksi:
                    return MultiplyValue(value, 6894757.2931783);
                case Pressure.atm:
                    return MultiplyValue(value, 101325);
                case Pressure.N_m2:
                    return MultiplyValue(value, 1);
                case Pressure.N_cm2:
                    return MultiplyValue(value, 10000);
                case Pressure.N_mm2:
                    return MultiplyValue(value, 1000000);
                case Pressure.kN_m2:
                    return MultiplyValue(value, 1000);
                case Pressure.kgf_m2:
                    return MultiplyValue(value, 9.80665);
                case Pressure.kgf_cm2:
                    return MultiplyValue(value, 98066.5);
                case Pressure.kgf_mm2:
                    return MultiplyValue(value, 9806650);
                case Pressure.gf_cm2:
                    return MultiplyValue(value, 98.0665);
                case Pressure.lbf_ft2:
                    return MultiplyValue(value, 47.8802589804);
                case Pressure.lbf_in2:
                    return MultiplyValue(value, 6894.7572931783);
                case Pressure.pdl_ft2:
                    return MultiplyValue(value, 1.4881639436);
                case Pressure.Torr:
                    return MultiplyValue(value, 133.3223684211);
                case Pressure.cmHg:
                    return MultiplyValue(value, 1333.22);
                case Pressure.mmHg:
                    return MultiplyValue(value, 133.322);
                case Pressure.inHg:
                    return MultiplyValue(value, 3386.38);
                case Pressure.inHg60f:
                    return MultiplyValue(value, 3376.85);
                case Pressure.cmH2O:
                    return MultiplyValue(value, 98.0638);
                case Pressure.mmH2O:
                    return MultiplyValue(value, 9.80638);
                case Pressure.inH2O:
                    return MultiplyValue(value, 249.082);
                case Pressure.inH2O60f:
                    return MultiplyValue(value, 248.843);
                case Pressure.ftH2O:
                    return MultiplyValue(value, 2988.98);
                case Pressure.ftH2O60f:
                    return MultiplyValue(value, 2986.116);
            }

            throw new Exception("Unable to Convert to base value");
        }
        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="pressure">The unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>       
        public Double ConvertTo(Pressure pressure)
        {
            return ConvertUnit(pressure);
        }

        /// <summary>
        /// Convert the Unit to given scale value
        /// </summary>
        /// <param name="pressure">The index of the Unit to convert to</param>
        /// <returns>The converted value</returns>
        /// <summary>  
        public Double ConvertTo(int pressure)
        {
            return ConvertUnit((Pressure)pressure);
        }

        /// <summary>
        /// Convert the value to given unit
        /// </summary>
        /// <param name="convertTo">unit toconvert to</param>
        /// <returns>converted value</returns>
        private Double ConvertUnit(Pressure convertTo)
        {
            switch (convertTo)
            {
                case Pressure.Pa:
                    return DivideValue(baseValue, 1);
                case Pressure.kPa:
                    return DivideValue(baseValue, 1000);
                case Pressure.dPa:
                    return DivideValue(baseValue, 0.1);
                case Pressure.cPa:
                    return DivideValue(baseValue, 0.01);
                case Pressure.mPa:
                    return DivideValue(baseValue, 0.001);
                case Pressure.µPa:
                    return DivideValue(baseValue, 1.0E-6);
                case Pressure.nPa:
                    return DivideValue(baseValue, 1.0E-9);
                case Pressure.bar:
                    return DivideValue(baseValue, 100000);
                case Pressure.mbar:
                    return DivideValue(baseValue, 100);
                case Pressure.µbar:
                    return DivideValue(baseValue, 0.1);
                case Pressure.psi:
                    return DivideValue(baseValue, 6894.7572931783);
                case Pressure.ksi:
                    return DivideValue(baseValue, 6894757.2931783);
                case Pressure.atm:
                    return DivideValue(baseValue, 101325);
                case Pressure.N_m2:
                    return DivideValue(baseValue, 1);
                case Pressure.N_cm2:
                    return DivideValue(baseValue, 10000);
                case Pressure.N_mm2:
                    return DivideValue(baseValue, 1000000);
                case Pressure.kN_m2:
                    return DivideValue(baseValue, 1000);
                case Pressure.kgf_m2:
                    return DivideValue(baseValue, 9.80665);
                case Pressure.kgf_cm2:
                    return DivideValue(baseValue, 98066.5);
                case Pressure.kgf_mm2:
                    return DivideValue(baseValue, 9806650);
                case Pressure.gf_cm2:
                    return DivideValue(baseValue, 98.0665);
                case Pressure.lbf_ft2:
                    return DivideValue(baseValue, 47.8802589804);
                case Pressure.lbf_in2:
                    return DivideValue(baseValue, 6894.7572931783);
                case Pressure.pdl_ft2:
                    return DivideValue(baseValue, 1.4881639436);
                case Pressure.Torr:
                    return DivideValue(baseValue, 133.3223684211);
                case Pressure.cmHg:
                    return DivideValue(baseValue, 1333.22);
                case Pressure.mmHg:
                    return DivideValue(baseValue, 133.322);
                case Pressure.inHg:
                    return DivideValue(baseValue, 3386.38);
                case Pressure.inHg60f:
                    return DivideValue(baseValue, 3376.85);
                case Pressure.cmH2O:
                    return DivideValue(baseValue, 98.0638);
                case Pressure.mmH2O:
                    return DivideValue(baseValue, 9.80638);
                case Pressure.inH2O:
                    return DivideValue(baseValue, 249.082);
                case Pressure.inH2O60f:
                    return DivideValue(baseValue, 248.843);
                case Pressure.ftH2O:
                    return DivideValue(baseValue, 2988.98);
                case Pressure.ftH2O60f:
                    return DivideValue(baseValue, 2986.116);
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


