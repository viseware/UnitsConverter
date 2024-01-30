using System;
using System.Collections.Generic;


namespace Gizmokit.Converter.Units
{
    /// <summary>
    /// temparature units
    /// </summary>
    public enum Temperature
    {
        K,
        C,
        F
    }

    /// <summary>
    /// time units
    /// </summary>
    public enum Time
    {
        s,
        ns,
        μs,
        ms,
        min,
        hr,
        days,
        week,
        fortnight,
        month,
        year,
        decade,
        Century

    }

    /// <summary>
    /// speed units
    /// </summary>
    public enum Speed
    {
        m_s,
        m_h,
        m_min,
        km_h,
        km_min,
        km_s,
        cm_h,
        cm_min,
        cm_s,
        mm_h,
        mm_min,
        mm_s,
        ft_h,
        ft_min,
        ft_s,
        yd_h,
        Yd_min,
        Yd_s,
        mi_h,
        mi_min,
        mi_s,
        KT,
        C,
        Ma
    }

    /// <summary>
    /// lenght units
    /// </summary>
    public enum Length
    {
        m,
        km,
        dm,
        cm,
        mm,
        µm,
        nm,
        @in,
        mi,
        yd,
        ft,
        LY,
        µ,
        NM,
        Kpc,
        pc,
        AU,
        ℓP,
        e,
        SR,
        Banana,
        Football
    }

    /// <summary>
    /// area units
    /// </summary>
    public enum Area
    {
        m2,
        km2,
        dm2,
        cm2,
        mm2,
        µm2,
        nm2,
        ha,
        ac,
        mi2,
        yd2,
        ft2,
        hm2,
        a2,
        b2,
        ecr,
    }

    /// <summary>
    /// weight units
    /// </summary>
    public enum Weight
    {
        kg,
        g,
        dg,
        cg,
        mg,
        µg,
        ng,
        t,
        kt,
        ibs,
        oz,
        car,
        u,
        stoneUS,
        stoneUK,
        pwt,
        gr,
        mp,
        me,
        mm,
        pm,
        mn,
        md,
        em,
        sm,
    }

    /// <summary>
    /// volume units
    /// </summary>
    public enum Volume
    {
        m3,
        km3,
        dm3,
        cm3,
        mm3,
        GL,
        ML,
        kL,
        L,
        dL,
        cL,
        mL,
        µL,
        nL,
        galUS,
        galUk,
        ptUS,
        ptUk,
        cup,
        tablespoon,
        teaspoon,
        mi3,
        yd3,
        ft3,
        in3,
        cc,
        drop,
        bbl,
        flozUS,
        flozUK,
        CCF,
        ac_ft,
        ac_in,
        EV
    }

    /// <summary>
    /// Force units
    /// </summary>
    public enum Force
    {
        N,
        GN,
        MN,
        kN,
        dN,
        cN,
        mN,
        µN,
        nN,
        tf,
        kgf,
        gf,
        J_m,
        J_cm,
        ton_force,
        ton_fL,
        kipf,
        lbf,
        ozf,
        pdf,
        p,
        kp,
    }

    /// <summary>
    /// Fuel units
    /// </summary>
    public enum Fuel
    {
        m_L,
        m_galUS,
        m_galUK,
        km_L,
        km_galUS,
        mi_L,
        mi_galUS,
        mi_galUK,
        NM_L,
        NM_galUS,
        m_flozUS,
        m_flozUK,
        L_m,
        L_100km,
        gal_miUS,
        gal_miUK,
        gal_100miUS,
        gal_100miUK
    }

    /// <summary>
    /// Pressure units
    /// </summary>
    public enum Pressure
    {
        Pa,
        kPa,
        dPa,
        cPa,
        mPa,
        µPa,
        nPa,
        bar,
        mbar,
        µbar,
        psi,
        ksi,
        atm,
        N_m2,
        N_cm2,
        N_mm2,
        kN_m2,
        kgf_m2,
        kgf_cm2,
        kgf_mm2,
        gf_cm2,
        lbf_ft2,
        lbf_in2,
        pdl_ft2,
        Torr,
        cmHg,
        mmHg,
        inHg,
        inHg60f,
        cmH2O,
        mmH2O,
        inH2O,
        inH2O60f,
        ftH2O,
        ftH2O60f,
    }
    /// <summary>
    /// Data units
    /// </summary>
    public enum Data
    {
        b,
        PB,
        TB,
        GB,
        MB,
        kB,
        B,
        nibble,
        character,
        word,
        block,
        Pb,
        Tb,
        Gb,
        Mb,
        Kb,
        fd,
        fdHD,
        fd5HD,
        CD74,
        CD80,
        DVD11,
        DVD21,
        DVD12,
        DVD22
    }

    /// <summary>
    /// Energy units
    /// </summary>
    public enum Energy
    {
        J,
        GJ,
        MJ,
        kJ,
        mJ,
        µJ,
        nJ,
        GW_h,
        MW_h,
        kW_h,
        W_h,
        kW_s,
        W_s,
        kcalIt,
        kcalTh,
        calit,
        calth,
        cal,
        hp,
        hp_h,
        MBtu,
        BtuIT,
        Btuth,
        MeV,
        keV,
        eV,
        N_m,
        ton_hour,
        Gton,
        Mton,
        kTon,
        ton,
        gf_m,
        gf_cm,
        kgf_cm,
        kgf_m,
        kp_m,
        ibf_ft,
        lbf_in,
        ozf_in,
        ft_lbf,
        in_lbf,
        in_ozf,
        pdl_ft,
        therm,
        Hartree,
        Rydberg
    }

    /// <summary>
    /// Power units
    /// </summary>
    public enum Power
    {
        W,
        PW,
        TW,
        GW,
        MW,
        kW,
        dW,
        cW,
        mW,
        µW,
        nW,
        hpM,
        hpE,
        Btu_h,
        Btu_min,
        Btu_s,
        ton,
        kcal_h,
        kcal_min,
        kcal_s,
        cal_h,
        cal_min,
        cal_s,
        ft_lbf_h,
        ft_lbf_min,
        ft_lbf_s,
        kV_A,
        V_A,
        N_m_s,
        J_s,
        PJ_s,
        TJ_s,
        GJ_s,
        MJ_s,
        kJ_s,
        dJ_s,
        cJ_s,
        mJ_s,
        µJ_s,
        nJ_s,
        J_h,
        J_min,
        kJ_h,
        kJ_min,
    }

    public class Units
    {
        /// <summary>
        /// List of all avalible temparature units
        /// </summary>
        public List<string> temperatureUnits = new List<string>()
        {"K (kelvin)",  "C (Celsius)", "F (Fahrenheit)" };

        /// <summary>
        /// List of all avalible time units
        /// </summary>
        public List<string> timeUnits = new List<string>() {"s (seconds)", "ns (Nanoseconds)", "ms (milliseconds)", "m (minutes)", "h (hours)",
            "days", "week", "fortnight", "months", "years", "decades", "cent (century)" };

        /// <summary>
        /// List of all avalible speed units
        /// </summary>
        public List<string> speedUnits = new List<string>() { "m/s (meter per second)", "m/h (meter per hour)", "m/min (meter per minutes)",
            "km/h (kilometer per hour)", "km/min (kilometer per minutes)", "km/s (kilometer per second)",
            "cm/h (centimeter per hour)", "cm/min (centimeter per minutes)", "cm/s (centimeter per second)",
            "mm/h (millimeter per hour)", "mm/min (millimeter per minute)", "mm/s (millimeter per second)",
            "ft/h (feet per hour)", "ft/min (feet per minutes)", "ft/s (feet per second)", "yd/h (yard per hour)",
            "yd/min (yard per minutes)", "yd/s (yard per second)", "mi/h (mile per hour)", "mi/min (mile per minutes)",
            "mi/s (mile per second)", "kt (knots)", "C (velocity of light in vacuum)", "MACH"};

        /// <summary>
        /// List of all avalible lenght units
        /// </summary>
        public List<string> lenghtUnits = new List<string>() {"m (meter)", "km (kilometer)", "dm (decimeter)", "cm (centimeter)",
            "mm (millimeter)", "µm (micrometer)", "nm (nanometer)", "in (inch)", "mi (mile)", "yd (yard)", "ft (Feet)", "ly (Light year)",
            "µ (micron)", "NM (Nautical mile (international))", "kpc (kiloparsec)", "pc (parsec)", "AU (astronomical unit)",
            "ℓP (Planck length)", "Electron radius", "sun radius", "banana (Average)", "football field length (US)"};

        /// <summary>
        /// List of all avalible area units
        /// </summary>
        public List<string> areaUnits = new List<string>() {"m² (squared meter)", "km² (squared kilometer)", "dm² (squared decimeter)",
            "cm² (squared centimeter)", "mm² (squared millimeter)", "µm² (squared micromillimeter)", "nm² (squared nanometer)",
            "ha(Hectare)", "ac (acre)", "mi² (squared mile)", "yd² (squared yard)", "ft² (squared feet)", "hm² (squared hectometer)",
            "a (are)", "b (barn)", "Electron cross section" };

        /// <summary>
        /// List of all avalible weight units
        /// </summary>
        public List<string> weightUnits = new List<string>() {"kg (kilogram)", "g (gram)", "dg (decigram)", "cg (centigram)",
            "mg (milligram)", "µg (microgram)", "ng (nanogram)", "t (ton)", "kt (kiloton)", "lbs. (pound)", "oz (ounce)",
            "car (carat)", "u (atomic mass)", "stone (US)", "stone (UK)", "pwt (pennyweight)", "gr (Grain)", "Planck mass",
            "Electron mass (rest)", "Muon mass", "Proton mass", "Neutron mass", "Deuteron mass", "Earth's mass", "Sun's mass" };

        /// <summary>
        /// List of all avalible volume units
        /// </summary>
        public List<string> volumeUnits = new List<string>() { " m³ (cubic meter)", "km³ (cubic kilometer)", "dm3 (cubic decimeter)",
            "cm³ (cubic centimeter)", "mm³ (cubic millimeter)", "GL (gigalitre)", "ML (megaliter)", "kL (kiloliter)", "L (liter)",
            "dL (deciliter)", "cL (centiliter)", "mL (milliliter)", "µL (microliter)", "nL (nanoliter)", "gal (gallon (US))",
            "gal gallon (UK)", "pt (pint (US))", "pt (pint (UK))", "cup", "tablespoon (metric)", "teaspoon (metric)",
            "mi³ (cubic mile)", "yd³ (cubic yard)", "ft³ (cubic foot)", "in³ (cubic inch)", "cc", "drop", "bbl (barrel (oil))",
            "fl oz (fluid ounce US)", "fl oz (fluid ounce UK)", "CCF (100 Cubic Feet)", "ac-ft (acre-foot)", "ac-in (acre-inch)",
            "Earth's volume" };

        /// <summary>
        /// List of all avalible force units
        /// </summary>
        public List<string> forceUnits = new List<string>() { "N (newton)", "GN (giganewton)", "MN (meganewton)", "kN (kilonewton)",
            "dN (decinewton)", "cN (centinewton)", "mN (millinewton)", "µN (micronewton)", "nN (nanonewton)", "tf (ton-force)",
            "kgf (kilogram-force)", "gf (gram-force)", "J/m (joule/meter)", "J/cm (joule/centimeter)", "ton-force (short)",
            "ton f (ton-force (long) UK)", "kipf (kilopound-force)", "lbf (pound-force)", "ozf (ounce-force)", "pdf (poundal)",
            "p (pond)", "kp (kilopond)" };

        /// <summary>
        /// List of all avalible fuel units
        /// </summary>
        public List<string> fuelUnits = new List<string>() { "m/L (meter/liter) ", "m/gal (meter/gallon (US))",
            "m/gal (meter/gallon (UK))", "km/L (kilometer/liter)", "km/gal (kilometer/gallon (US))", "mi/L (mile/liter)",
            "mi/gal (mile/gallon (US))", "mi/gal (mile/gallon (UK))", "NM/L (nautical mile/liter)", "NM/gal (nautical mile/gallon (US))",
            "m/fl oz (meter/fluid ounce (US))", "m/fl oz (meter/fluid ounce (UK))", "L/m (liter/meter)", "L/100km (liter/100 km)",
            "gal/mi (gallon (US)/mile)", "gal/mi (gallon (UK)/mile)", "gal/100mi (gallon (US)/100 mi)", "gal/100mi (gallon (UK)/100 mi)"};

        /// <summary>
        /// List of all avalible pressure units
        /// </summary>
        public List<string> pressureUnits = new List<string>() { "Pa (pascal)", "kPa (kilopascal)", "dPa (decipascal)", "cPa (centipascal)",
            "mPa (milipascal)", "µPa (micropascal)", "nPa  (nanopascal)", "bar", "mbar (millibar)", "µbar (microbar)", "psi", "ksi",
            "atm (Standard atmosphere)", "N/m² (newton/square meter)", "N/cm² (newton/square centimeter)", "N/mm² (newton/square millimeter)"
            , "kN/m² (kilonewton/square meter)", "kgf/m² (kilogram-force/square meter)", "kgf/cm² (kilogram-force/square cm)",
            "kgf/mm² (kilogram-force/square millimeter)", "gf/cm² (gram-force/square centimeter)", "lbf/ft² (pound-force/square foot)",
            "lbf/in² (pound-force/square inch)", "pdl/ft² (poundal per square foot)", "Torr", "cmHg (centimeter mercury (0°C))",
            "mmHg (millimeter mercury (0°C))", "inHg (inch mercury (32°F))", "inHg (inch mercury (60°F))", "cmH2O (centimeter water (4°C))",
            "mmH2O (millimeter water (4°C))", "inH2O (inch water (4°C))", "inH2O (inch water (60°F))", "ftH2O (foot water (4°C))",
            "ftH2O (foot water) (60°F)"};

        /// <summary>
        /// List of all avalible data units
        /// </summary>
        public List<string> dataUnits = new List<string>(){"bit [b]","PB (petabyte)","TB (terabyte)","GB (gigabyte)","MB (megabyte)",
            "kB (kilobyte)","B (byte)","nibble","character","word","block","Pb (petabit)","Tb (terabit)","Gb (gigabit)","Mb (megabit)",
            "Kb (kilobit)","floppy disk (3.5\")","floppy disk (3.5\", HD)","floppy disk (5.25\", HD)",
            "CD (74 minute)","CD (80 minute)","DVD (1 layer, 1 side)","DVD (2 layer, 1 side)",
            "DVD (1 layer, 2 side)","DVD (2 layer, 2 side)"};

        /// <summary>
        /// List of all avalible energy units
        /// </summary>
        public List<string> energyUnits = new List<string>() { "J (joule)", "GJ (gigajoule)", "MJ (megajoule)", "kJ (kilojoule)",
            "mJ (millijoule)", "µJ (microjoule)", "nJ (nanojoule)", "GW-h (gigawatt-hour)", "MW-h (megawatt-hour)",
            "kW-h (kilowatt-hour)", "W-h (watt-hour)", "kW-s (kilowatt-second)", "W-s (watt-second)", "kcal (kilocalorie (IT))",
            "kcal (kilocalorie (th))", "cal (calorie (IT))", "cal (calorie (th))", "cal (calorie (nutritional))", "hp (horsepower)",
            "hp-h (horsepower hour)", "MBtu (Mega British thermal unit (IT))", "Btu (British thermal unit (IT))", "Btu (British thermal unit (th))",
            "MeV (Megaelectron-Volt)", "keV (kiloelectron-Volt)", "eV (electron-Volt)", "N-m (newton-meter)", "ton-hour (refrigeration)",
            "Gton (Gigaton)", "Mton (Megaton)", "kTon (kiloton)", "ton (explosives)", "gf-m (gram-force meter)",
            "gf-cm (gram-force centimeter)", "kgf-cm (kilogram-force centimeter)", "kgf-m (kilogram-force meter)", "kp-m (kilopond meter)",
            "ibf-ft (pound-force foot)", "lbf-in (pound-force inch)", "ozf-in (ounce-force inch)", "ft-lbf (foot-pound)",
            "in-lbf (inch-pound)", "in-ozf (inch-ounce)", "pdl-ft (poundal foot)", "therm", "Hartree energy", "Rydberg constant" };

        /// <summary>
        /// List of all avalible power units
        /// </summary>
        public List<string> powerUnits = new List<string>() { "W (watt)", "PW  (petawatt)", "TW (terawatt)", "GW (gigawatt)",
            "MW (megawatt)", "kW (kilowatt)", "dW (deciwatt)", "cW (centiwatt)", "mW (milliwatt)", "µW (microwatt)",
            "nW (nanowatt)", "hp (horsepower (metric))", "hp (horsepower (electric))", "Btu/h (Btu (IT)/hour)",
            "Btu/min (Btu (IT)/minute)", "Btu/s (Btu (IT)/second)", "ton (refrigeration)", "kcal/h (kilocalorie (IT)/hour)",
            "kcal/min (kilocalorie (IT)/minute)", "kcal/s (kilocalorie (IT)/second)", "cal/h (calorie (IT)/hour)",
            "cal/min (calorie (IT)/minute)", "cal/s (calorie (IT)/second)", "ft-lbf/h  (foot pound-force/hour)",
            "ft-lbf/min (foot pound-force/minute)", "ft-lbf/s (foot pound-force/second)", "kV-A (kilovolt ampere)", "V-A (volt ampere)",
            "N-m/s (newton meter/second)", "J/s (joule/second)", "PJ/s (petajoule/second)", "TJ/s (terajoule/second)",
            "GJ/s (gigajoule/second)", "MJ/s (megajoule/second)", "kJ/s (kilojoule/second)", "dJ/s (decijoule/second)",
            "cJ/s (centijoule/second)", "mJ/s (millijoule/second)", "µJ/s (microjoule/second)", "nJ/s (nanojoule/second)",
            "J/h (joule/hour)", "J/min (joule/minute)", "kJ/h (kilojoule/hour)", "kJ/min (kilojoule/minute)" };

        /// <summary>
        /// Gets the Index value of a unit from the list
        /// </summary>
        /// <param name="list">list to use to fetch the index from</param>
        /// <param name="selected">Inupt unit to fetch the index of</param>
        /// <returns>Index of the given unit</returns>
        public int GetIndexOfList(List<string> list, string selected)
        {
            var index = list.IndexOf(selected);
            if (index == -1)
            {
                throw new Exception("Can not find the index of given unit in given list");
            }

            return index;
        }
    }
}
