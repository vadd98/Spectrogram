using System;

namespace Spectrogram.Colormaps
{
    class Spectral : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the Spectral colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            10355010, 10486594, 10618179, 10750019, 10881604, 11013188, 11145029, 11342149, 
            11473990, 11605574, 11737159, 11868999, 12000584, 12197960, 12329545, 12461129, 
            12592970, 12724554, 12856395, 12987979, 13185100, 13316940, 13448525, 13580365, 
            13711950, 13843534, 13975118, 14041166, 14172749, 14238797, 14304844, 14370892, 
            14436683, 14568267, 14634315, 14700362, 14766410, 14832457, 14964041, 15029832, 
            15095880, 15161927, 15293511, 15359558, 15425606, 15491397, 15557445, 15689028, 
            15755076, 15821123, 15887171, 16018755, 16019268, 16020037, 16086086, 16086855, 
            16087368, 16153674, 16154187, 16154956, 16221005, 16221774, 16222543, 16288593, 
            16289362, 16289875, 16356180, 16356693, 16422998, 16423512, 16424281, 16490330, 
            16491099, 16491868, 16557918, 16558687, 16559200, 16625249, 16625763, 16626277, 
            16626790, 16627304, 16627818, 16628331, 16628845, 16629358, 16629872, 16630386, 
            16630899, 16631413, 16631927, 16632440, 16632954, 16633468, 16633981, 16634495, 
            16635009, 16635522, 16636036, 16636550, 16637063, 16637577, 16703627, 16703885, 
            16704143, 16704401, 16704659, 16705173, 16705431, 16705689, 16705947, 16706205, 
            16706719, 16706977, 16707235, 16707493, 16708007, 16708265, 16708523, 16708781, 
            16709039, 16709553, 16709811, 16710069, 16710327, 16710585, 16711099, 16711357, 
            16711358, 16645820, 16580283, 16514489, 16448952, 16383158, 16317621, 16252083, 
            16186290, 16120752, 16054958, 15989421, 15923883, 15858090, 15792552, 15726759, 
            15661221, 15595684, 15529890, 15464353, 15398559, 15333022, 15267484, 15201691, 
            15136153, 15136152, 14939288, 14807960, 14676633, 14479769, 14348442, 14217114, 
            14020251, 13888923, 13757596, 13560732, 13429405, 13298077, 13101214, 12969886, 
            12838559, 12641695, 12510624, 12379296, 12247968, 12051105, 11919777, 11788450, 
            11591586, 11460259, 11328931, 11132068, 10935204, 10803876, 10607012, 10410148, 
            10278820, 10081956, 09885092, 09753764, 09556644, 09359780, 09162916, 09031588, 
            08834724, 08637860, 08506532, 08309668, 08112804, 07915940, 07784612, 07587748, 
            07390884, 07259556, 07062692, 06865828, 06734501, 06537125, 06405542, 06273959, 
            06142120, 06010537, 05878954, 05747371, 05615532, 05483949, 05352366, 05220527, 
            05088944, 04957361, 04825778, 04693939, 04562356, 04430773, 04299189, 04167350, 
            04035767, 03904184, 03772345, 03640762, 03509179, 03377596, 03311292, 03441851, 
            03572410, 03702969, 03767736, 03898295, 04028854, 04093877, 04224436, 04354738, 
            04485297, 04550320, 04680879, 04811182, 04941741, 05006764, 05137323, 05267626, 
            05332649, 05463208, 05593767, 05724070, 05789093, 05919652, 06050211, 06180770, 
        };
    }
}
