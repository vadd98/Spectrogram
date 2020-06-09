using System;

namespace Spectrogram.Colormaps
{
    class Cividis : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the Cividis colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            00008781, 00009039, 00009040, 00009298, 00009556, 00009813, 00009815, 00010073, 
            00010331, 00010332, 00010590, 00010848, 00010850, 00011108, 00011366, 00011367, 
            00011625, 00011883, 00012141, 00012143, 00012400, 00012400, 00012656, 00012656, 
            00275056, 00537456, 00734064, 00930928, 01127791, 01324655, 01455727, 01587055, 
            01718383, 01849454, 01915246, 02046574, 02177902, 02243438, 02374766, 02440557, 
            02571629, 02637421, 02768749, 02834285, 02900077, 03031404, 03097196, 03162732, 
            03228524, 03294316, 03425388, 03491180, 03556972, 03622508, 03688300, 03754092, 
            03819627, 03885419, 04016747, 04082539, 04148075, 04213867, 04279659, 04345195, 
            04410987, 04476779, 04542315, 04608107, 04673899, 04739435, 04805227, 04871019, 
            04936812, 05002348, 05068140, 05133932, 05133932, 05199724, 05265516, 05331052, 
            05396844, 05462636, 05528172, 05593965, 05659757, 05725549, 05791085, 05856877, 
            05857133, 05922669, 05988462, 06054254, 06119790, 06185582, 06251374, 06317166, 
            06382703, 06382959, 06448751, 06514287, 06580079, 06645872, 06711664, 06777200, 
            06842992, 06843249, 06908785, 06974577, 07040369, 07105906, 07171698, 07237490, 
            07237747, 07303283, 07369075, 07434867, 07500660, 07566196, 07631989, 07632245, 
            07697781, 07763574, 07829366, 07895158, 07960695, 07960951, 08026743, 08092535, 
            08158072, 08223864, 08289656, 08355192, 08420984, 08486776, 08552568, 08618104, 
            08683896, 08749688, 08749944, 08815480, 08881272, 08947064, 09012856, 09078392, 
            09144184, 09209976, 09275768, 09341304, 09407095, 09472887, 09538679, 09604215, 
            09670007, 09735799, 09801591, 09867127, 09932918, 09998710, 10064502, 10130294, 
            10195830, 10261622, 10327413, 10393205, 10458741, 10524533, 10590324, 10656116, 
            10721908, 10787444, 10853235, 10919027, 10984819, 11050611, 11116146, 11181938, 
            11247730, 11313521, 11379313, 11444849, 11510640, 11576432, 11642224, 11708015, 
            11773551, 11839343, 11905134, 11970926, 12036717, 12102509, 12168045, 12233836, 
            12299628, 12365419, 12431211, 12497002, 12562538, 12693865, 12759657, 12825448, 
            12891240, 12957031, 13022567, 13088358, 13154149, 13219941, 13285732, 13351524, 
            13417315, 13483106, 13548642, 13614433, 13680224, 13811552, 13877343, 13943134, 
            14008926, 14074717, 14140252, 14206043, 14271834, 14337626, 14403417, 14469208, 
            14600535, 14666326, 14732117, 14797908, 14863443, 14929234, 14995025, 15060816, 
            15126607, 15257934, 15323725, 15389516, 15455307, 15521098, 15586888, 15652679, 
            15718470, 15849796, 15915587, 15981122, 16046912, 16112703, 16178493, 16309819, 
            16375610, 16441400, 16507190, 16638516, 16638771, 16639284, 16639542, 16639799, 
        };
    }
}
