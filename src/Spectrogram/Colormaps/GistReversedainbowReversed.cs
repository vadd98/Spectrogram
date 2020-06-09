using System;

namespace Spectrogram.Colormaps
{
    class GistReversedainbowReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the GistReversedainbowReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            16711871, 16711876, 16711882, 16711887, 16711892, 16711898, 16711903, 16711909, 
            16711914, 16711920, 16711925, 16711931, 16580863, 16253183, 15859967, 15532287, 
            15139071, 14811391, 14418175, 14090495, 13762815, 13369599, 13041919, 12648703, 
            12321023, 11927807, 11600127, 11272447, 10879231, 10551551, 10158335, 09830655, 
            09437439, 09109759, 08716543, 08388863, 08061183, 07667967, 07340287, 06947071, 
            06619391, 06226175, 05898495, 05570815, 05177599, 04849919, 04456703, 04129023, 
            03735807, 03408127, 03080447, 02687231, 02359551, 01966335, 01638655, 01245439, 
            00917759, 00524543, 00196863, 00000511, 00002047, 00003327, 00004863, 00006143, 
            00007679, 00008959, 00010239, 00011775, 00013055, 00014591, 00015871, 00017407, 
            00018687, 00019967, 00021503, 00022783, 00024319, 00025599, 00027135, 00028415, 
            00029951, 00031231, 00032511, 00034047, 00035327, 00036863, 00038143, 00039679, 
            00040959, 00042239, 00043775, 00045055, 00046591, 00047871, 00049407, 00050687, 
            00051967, 00053503, 00054783, 00056319, 00057599, 00059135, 00060415, 00061951, 
            00063231, 00064511, 00065532, 00065527, 00065521, 00065516, 00065511, 00065505, 
            00065500, 00065495, 00065489, 00065484, 00065478, 00065473, 00065468, 00065462, 
            00065457, 00065452, 00065446, 00065441, 00065435, 00065430, 00065425, 00065419, 
            00065414, 00065409, 00065403, 00065398, 00065392, 00065387, 00065382, 00065376, 
            00065371, 00065366, 00065360, 00065355, 00065349, 00065344, 00065339, 00065333, 
            00065328, 00065323, 00065317, 00065312, 00065306, 00065301, 00065296, 00065290, 
            00065285, 00065280, 00392960, 00720640, 01113856, 01441536, 01834752, 02162432, 
            02490112, 02883328, 03211008, 03604224, 03931904, 04259584, 04652800, 04980480, 
            05373696, 05701376, 06029056, 06422272, 06749952, 07143168, 07470848, 07798528, 
            08191744, 08519424, 08912640, 09240320, 09568000, 09961216, 10288896, 10682112, 
            11009792, 11337472, 11730688, 12058368, 12451584, 12779264, 13106944, 13500160, 
            13827840, 14221056, 14548736, 14941952, 15269632, 15597312, 15990528, 16318208, 
            16711424, 16775680, 16774400, 16772864, 16771584, 16770048, 16768768, 16767488, 
            16765952, 16764672, 16763136, 16761856, 16760576, 16759040, 16757760, 16756224, 
            16754944, 16753664, 16752128, 16750848, 16749312, 16748032, 16746752, 16745216, 
            16743936, 16742400, 16741120, 16739840, 16738304, 16737024, 16735488, 16734208, 
            16732672, 16731392, 16730112, 16728576, 16727296, 16725760, 16724480, 16723200, 
            16721664, 16720384, 16718848, 16717568, 16716288, 16714752, 16713472, 16711936, 
            16711683, 16711688, 16711694, 16711699, 16711704, 16711710, 16711715, 16711720, 
        };
    }
}
