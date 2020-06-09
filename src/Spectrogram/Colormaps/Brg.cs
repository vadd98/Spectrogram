using System;

namespace Spectrogram.Colormaps
{
    class Brg : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the Brg colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            00000255, 00131325, 00262395, 00393465, 00524535, 00655605, 00786675, 00917745, 
            01048815, 01179885, 01310955, 01442025, 01573095, 01704165, 01835235, 01966305, 
            02097375, 02228445, 02359515, 02490585, 02621655, 02752725, 02883795, 03014865, 
            03145935, 03277005, 03408075, 03539145, 03670215, 03801285, 03932355, 04063425, 
            04194495, 04260029, 04456635, 04587705, 04718775, 04784309, 04980915, 05111985, 
            05243055, 05308589, 05505195, 05636265, 05767335, 05832869, 06029475, 06160545, 
            06291615, 06357149, 06553755, 06684825, 06815895, 06881429, 07078035, 07209105, 
            07340175, 07405709, 07602315, 07733385, 07864455, 07929989, 08126595, 08257665, 
            08388735, 08519805, 08585339, 08781945, 08913015, 09044085, 09175154, 09306225, 
            09437295, 09568365, 09633899, 09830505, 09961575, 10092645, 10223714, 10354785, 
            10485855, 10616925, 10682459, 10879065, 11010135, 11141205, 11272274, 11403345, 
            11534415, 11665485, 11731019, 11927625, 12058695, 12189765, 12320834, 12451905, 
            12582975, 12714045, 12779579, 12976184, 13107255, 13238325, 13369394, 13500464, 
            13631535, 13762605, 13828139, 14024744, 14155815, 14286885, 14417954, 14549024, 
            14680095, 14811165, 14876699, 15073304, 15204375, 15335445, 15466514, 15597584, 
            15728655, 15859725, 15925259, 16121864, 16252935, 16384005, 16515074, 16646144, 
            16646400, 16515840, 16385280, 16254720, 16123904, 15993600, 15863040, 15732480, 
            15601920, 15471360, 15340800, 15210240, 15079680, 14949120, 14818560, 14688000, 
            14557440, 14426880, 14296320, 14165760, 14034944, 13839104, 13774080, 13643520, 
            13512960, 13382400, 13251840, 13121280, 12990720, 12794624, 12729600, 12599040, 
            12468480, 12337920, 12207360, 12076800, 11945984, 11750144, 11685120, 11554560, 
            11424000, 11293440, 11162880, 11032320, 10901760, 10705664, 10640640, 10510080, 
            10379520, 10248960, 10118400, 09987840, 09857024, 09661184, 09596160, 09465600, 
            09335040, 09204480, 09073920, 08943360, 08812800, 08616704, 08551680, 08421120, 
            08290560, 08160000, 07963904, 07898880, 07768064, 07637760, 07441664, 07376640, 
            07246080, 07115520, 06919424, 06854400, 06723840, 06593280, 06397184, 06332160, 
            06201600, 06071040, 05874944, 05809920, 05679104, 05548800, 05352704, 05287680, 
            05157120, 05026560, 04830464, 04765440, 04634880, 04504320, 04308224, 04243200, 
            04112640, 03982080, 03785984, 03720960, 03590144, 03459840, 03263744, 03198720, 
            03068160, 02937600, 02741504, 02676480, 02545920, 02415360, 02219264, 02154240, 
            02023680, 01893120, 01697024, 01632000, 01501184, 01370880, 01174784, 01109760, 
            00979200, 00848640, 00652544, 00587520, 00456960, 00326400, 00130304, 00065280, 
        };
    }
}
