using System;

namespace Spectrogram.Colormaps
{
    class GistReversedainbow : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the GistReversedainbow colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            16711720, 16711715, 16711710, 16711704, 16711699, 16711694, 16711688, 16711683, 
            16711936, 16713472, 16714752, 16716288, 16717568, 16718848, 16720384, 16721664, 
            16723200, 16724480, 16725760, 16727296, 16728576, 16730112, 16731392, 16732672, 
            16734208, 16735488, 16737024, 16738304, 16739840, 16741120, 16742400, 16743936, 
            16745216, 16746752, 16748032, 16749312, 16750848, 16752128, 16753664, 16754944, 
            16756224, 16757760, 16759040, 16760576, 16761856, 16763136, 16764672, 16765952, 
            16767488, 16768768, 16770048, 16771584, 16772864, 16774400, 16775680, 16711424, 
            16318208, 15990528, 15597312, 15269632, 14941952, 14548736, 14221056, 13827840, 
            13500160, 13106944, 12779264, 12451584, 12058368, 11730688, 11337472, 11009792, 
            10682112, 10288896, 09961216, 09568000, 09240320, 08912640, 08519424, 08191744, 
            07798528, 07470848, 07143168, 06749952, 06422272, 06029056, 05701376, 05373696, 
            04980480, 04652800, 04259584, 03931904, 03604224, 03211008, 02883328, 02490112, 
            02162432, 01834752, 01441536, 01113856, 00720640, 00392960, 00065280, 00065285, 
            00065290, 00065296, 00065301, 00065306, 00065312, 00065317, 00065323, 00065328, 
            00065333, 00065339, 00065344, 00065349, 00065355, 00065360, 00065366, 00065371, 
            00065376, 00065382, 00065387, 00065392, 00065398, 00065403, 00065409, 00065414, 
            00065419, 00065425, 00065430, 00065435, 00065441, 00065446, 00065452, 00065457, 
            00065462, 00065468, 00065473, 00065478, 00065484, 00065489, 00065495, 00065500, 
            00065505, 00065511, 00065516, 00065521, 00065527, 00065532, 00064511, 00063231, 
            00061951, 00060415, 00059135, 00057599, 00056319, 00054783, 00053503, 00051967, 
            00050687, 00049407, 00047871, 00046591, 00045055, 00043775, 00042239, 00040959, 
            00039679, 00038143, 00036863, 00035327, 00034047, 00032511, 00031231, 00029951, 
            00028415, 00027135, 00025599, 00024319, 00022783, 00021503, 00019967, 00018687, 
            00017407, 00015871, 00014591, 00013055, 00011775, 00010239, 00008959, 00007679, 
            00006143, 00004863, 00003327, 00002047, 00000511, 00196863, 00524543, 00917759, 
            01245439, 01638655, 01966335, 02359551, 02687231, 03080447, 03408127, 03735807, 
            04129023, 04456703, 04849919, 05177599, 05570815, 05898495, 06226175, 06619391, 
            06947071, 07340287, 07667967, 08061183, 08388863, 08716543, 09109759, 09437439, 
            09830655, 10158335, 10551551, 10879231, 11272447, 11600127, 11927807, 12321023, 
            12648703, 13041919, 13369599, 13762815, 14090495, 14418175, 14811391, 15139071, 
            15532287, 15859967, 16253183, 16580863, 16711931, 16711925, 16711920, 16711914, 
            16711909, 16711903, 16711898, 16711892, 16711887, 16711882, 16711876, 16711871, 
        };
    }
}
