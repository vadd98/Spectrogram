using System;

namespace Spectrogram.Colormaps
{
    class BinaryReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the BinaryReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            00000000, 00065793, 00131586, 00197379, 00263172, 00328965, 00394758, 00460551, 
            00526344, 00592137, 00657930, 00723723, 00789516, 00855309, 00921102, 00986895, 
            01052688, 01118481, 01184274, 01250067, 01315860, 01381653, 01447446, 01513239, 
            01579032, 01644825, 01710618, 01776411, 01842204, 01907997, 01973790, 02039583, 
            02105376, 02105376, 02236962, 02302755, 02368548, 02368548, 02500134, 02565927, 
            02631720, 02631720, 02763306, 02829099, 02894892, 02894892, 03026478, 03092271, 
            03158064, 03158064, 03289650, 03355443, 03421236, 03421236, 03552822, 03618615, 
            03684408, 03684408, 03815994, 03881787, 03947580, 03947580, 04079166, 04144959, 
            04210752, 04276545, 04276545, 04408131, 04473924, 04539717, 04605510, 04671303, 
            04737096, 04802889, 04802889, 04934475, 05000268, 05066061, 05131854, 05197647, 
            05263440, 05329233, 05329233, 05460819, 05526612, 05592405, 05658198, 05723991, 
            05789784, 05855577, 05855577, 05987163, 06052956, 06118749, 06184542, 06250335, 
            06316128, 06381921, 06381921, 06513507, 06579300, 06645093, 06710886, 06776679, 
            06842472, 06908265, 06908265, 07039851, 07105644, 07171437, 07237230, 07303023, 
            07368816, 07434609, 07434609, 07566195, 07631988, 07697781, 07763574, 07829367, 
            07895160, 07960953, 07960953, 08092539, 08158332, 08224125, 08289918, 08355711, 
            08421504, 08487297, 08553090, 08618883, 08618883, 08750469, 08816262, 08882055, 
            08947848, 09013641, 09079434, 09145227, 09211020, 09276813, 09342606, 09408399, 
            09474192, 09539985, 09605778, 09671571, 09671571, 09803157, 09868950, 09934743, 
            10000536, 10066329, 10132122, 10197915, 10263708, 10329501, 10395294, 10461087, 
            10526880, 10592673, 10658466, 10724259, 10724259, 10855845, 10921638, 10987431, 
            11053224, 11119017, 11184810, 11250603, 11316396, 11382189, 11447982, 11513775, 
            11579568, 11645361, 11711154, 11776947, 11776947, 11908533, 11974326, 12040119, 
            12105912, 12171705, 12237498, 12303291, 12369084, 12434877, 12500670, 12566463, 
            12632256, 12698049, 12763842, 12829635, 12829635, 12961221, 13027014, 13092807, 
            13158600, 13224393, 13290186, 13355979, 13421772, 13487565, 13553358, 13619151, 
            13684944, 13750737, 13816530, 13882323, 13882323, 14013909, 14079702, 14145495, 
            14211288, 14277081, 14342874, 14408667, 14474460, 14540253, 14606046, 14671839, 
            14737632, 14803425, 14869218, 14935011, 14935011, 15066597, 15132390, 15198183, 
            15263976, 15329769, 15395562, 15461355, 15527148, 15592941, 15658734, 15724527, 
            15790320, 15856113, 15921906, 15987699, 15987699, 16119285, 16185078, 16250871, 
            16316664, 16382457, 16448250, 16514043, 16579836, 16645629, 16711422, 16777215, 
        };
    }
}
