using System;

namespace Spectrogram.Colormaps
{
    class TwilightReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the TwilightReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            14801121, 14801120, 14801119, 14800861, 14735324, 14735066, 14669272, 14669014, 
            14603220, 14537169, 14536911, 14470860, 14405065, 14339014, 14272963, 14206912, 
            14206396, 14140345, 14074293, 14008242, 13942191, 13876139, 13810088, 13744036, 
            13743265, 13677214, 13611162, 13545111, 13544340, 13478288, 13412237, 13411466, 
            13345415, 13344644, 13278593, 13278078, 13211771, 13211257, 13144950, 13078900, 
            13078129, 13012079, 13011309, 12945259, 12878953, 12878439, 12812133, 12746083, 
            12745569, 12679264, 12613214, 12546909, 12480859, 12414554, 12348505, 12282456, 
            12216151, 12150102, 12083797, 12017748, 11951700, 11885395, 11753810, 11687762, 
            11621713, 11489873, 11423825, 11357776, 11226192, 11160144, 11028304, 10962255, 
            10830671, 10699087, 10633039, 10501455, 10369871, 10238287, 10106703, 10040655, 
            09909071, 09777743, 09646159, 09514576, 09382992, 09186128, 09054544, 08923216, 
            08791632, 08594768, 08463184, 08331856, 08134991, 08003663, 07806799, 07675471, 
            07478606, 07281742, 07150413, 06953549, 06756684, 06625611, 06428747, 06231882, 
            06100809, 05903944, 05772615, 05576006, 05379141, 05248068, 05051203, 04920130, 
            04788801, 04592192, 04461119, 04329789, 04198716, 04067644, 03936571, 03805498, 
            03674425, 03608888, 03477816, 03412279, 03346743, 03215927, 03150646, 03085366, 
            03150647, 03215929, 03281211, 03346748, 03412286, 03477568, 03543106, 03674181, 
            03739719, 03805258, 03936588, 04067663, 04133202, 04264533, 04395608, 04461403, 
            04592479, 04723810, 04789606, 04920937, 05052268, 05118064, 05249395, 05315447, 
            05381242, 05447293, 05578880, 05644675, 05710726, 05711241, 05777548, 05843599, 
            05909649, 05910164, 05976470, 05976984, 06043034, 06043804, 06044318, 06045088, 
            06111138, 06111908, 06112421, 06112935, 06113704, 06179754, 06180523, 06181036, 
            06181805, 06182319, 06182832, 06183601, 06184114, 06250163, 06250932, 06251444, 
            06251957, 06252726, 06318775, 06319287, 06319800, 06386105, 06386617, 06387130, 
            06453178, 06519483, 06519995, 06586044, 06652092, 06652605, 06718653, 06784702, 
            06850750, 06982334, 07048639, 07114687, 07180735, 07312320, 07378368, 07509952, 
            07576001, 07707329, 07838913, 07970497, 08102082, 08233666, 08365250, 08496835, 
            08628419, 08760004, 08956868, 09088452, 09220037, 09417157, 09614278, 09745606, 
            09942727, 10139847, 10271432, 10468297, 10665417, 10862538, 11059403, 11256524, 
            11453644, 11650509, 11847630, 12044495, 12241616, 12438482, 12635603, 12832468, 
            13029333, 13226454, 13357783, 13554648, 13685978, 13882843, 14014172, 14145501, 
            14276574, 14342366, 14473439, 14539232, 14670305, 14735841, 14801122, 14801122, 
        };
    }
}
