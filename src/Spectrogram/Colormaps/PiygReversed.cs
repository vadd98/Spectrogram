using System;

namespace Spectrogram.Colormaps
{
    class PiygReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the PiygReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            02581529, 02647321, 02713369, 02844953, 02911002, 03042586, 03108378, 03239963, 
            03306011, 03437595, 03503644, 03634972, 03701020, 03832605, 03898653, 04030237, 
            04096030, 04227614, 04293662, 04425246, 04491295, 04622623, 04688671, 04820256, 
            04886304, 05017888, 05083681, 05215266, 05346852, 05478181, 05609766, 05741351, 
            05872681, 06004266, 06135851, 06267180, 06398766, 06530095, 06661680, 06793265, 
            06924595, 07056180, 07187765, 07319094, 07450680, 07582265, 07713594, 07845179, 
            07976765, 08108094, 08239679, 08371265, 08502595, 08633926, 08765513, 08896843, 
            09093966, 09225297, 09356883, 09488214, 09685337, 09816668, 09947998, 10079585, 
            10276452, 10408038, 10539369, 10670956, 10867823, 10999409, 11130740, 11262327, 
            11393657, 11590524, 11722111, 11853441, 11985028, 12116359, 12247690, 12378765, 
            12510096, 12641427, 12707221, 12838552, 12969627, 13100958, 13232289, 13298084, 
            13429415, 13560490, 13691821, 13823152, 13888946, 14020021, 14151352, 14282683, 
            14414014, 14479809, 14610884, 14742215, 14873546, 15004877, 15136208, 15136209, 
            15201747, 15267284, 15267286, 15332823, 15398361, 15398362, 15463900, 15529437, 
            15529439, 15594976, 15660514, 15660771, 15726309, 15791846, 15791848, 15857386, 
            15922923, 15922925, 15988462, 16054000, 16054001, 16119539, 16185076, 16185078, 
            16250614, 16250358, 16250102, 16249845, 16315125, 16315125, 16314868, 16314612, 
            16379892, 16379636, 16379379, 16379123, 16378867, 16444146, 16443890, 16443890, 
            16443633, 16508913, 16508657, 16508400, 16508144, 16573424, 16573167, 16572911, 
            16572655, 16638191, 16572142, 16571629, 16505836, 16505323, 16439274, 16439018, 
            16372969, 16372456, 16306663, 16306150, 16240101, 16239845, 16173796, 16173283, 
            16107490, 16106977, 16106721, 16040672, 16040159, 15974366, 15973853, 15907804, 
            15907548, 15841499, 15840986, 15774937, 15708887, 15708117, 15642067, 15575762, 
            15509712, 15508942, 15442893, 15376843, 15310537, 15310023, 15243718, 15177668, 
            15111362, 15110848, 15044543, 14978493, 14912187, 14911674, 14845368, 14779318, 
            14713012, 14712499, 14646193, 14580143, 14579630, 14513068, 14446506, 14380200, 
            14313638, 14247076, 14180770, 14114208, 14047902, 13981340, 13914778, 13848472, 
            13781910, 13715605, 13649043, 13582481, 13516175, 13449613, 13383307, 13316745, 
            13250183, 13183877, 13117315, 13051009, 12984447, 12917885, 12786300, 12654970, 
            12523640, 12392311, 12260981, 12129651, 11932786, 11801456, 11670126, 11538796, 
            11407467, 11276137, 11144807, 10947942, 10816612, 10685282, 10553953, 10422623, 
            10291293, 10094428, 09963098, 09831768, 09700439, 09569109, 09437779, 09306450, 
        };
    }
}
