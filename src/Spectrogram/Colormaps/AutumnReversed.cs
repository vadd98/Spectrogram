using System;

namespace Spectrogram.Colormaps
{
    class AutumnReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the AutumnReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            16776960, 16776704, 16776448, 16776192, 16775936, 16775680, 16775424, 16775168, 
            16774912, 16774656, 16774400, 16774144, 16773888, 16773632, 16773376, 16773120, 
            16772864, 16772608, 16772352, 16772096, 16771840, 16771584, 16771328, 16771072, 
            16770816, 16770560, 16770304, 16770048, 16769792, 16769536, 16769280, 16769024, 
            16768768, 16768512, 16768256, 16768000, 16767744, 16767488, 16767232, 16766976, 
            16766720, 16766464, 16766208, 16765696, 16765696, 16765440, 16765184, 16764928, 
            16764672, 16764416, 16764160, 16763904, 16763648, 16763392, 16763136, 16762880, 
            16762624, 16762368, 16762112, 16761600, 16761600, 16761344, 16761088, 16760832, 
            16760576, 16760320, 16760064, 16759808, 16759552, 16759296, 16759040, 16758784, 
            16758528, 16758272, 16758016, 16757504, 16757504, 16757248, 16756992, 16756736, 
            16756480, 16756224, 16755968, 16755712, 16755456, 16755200, 16754944, 16754688, 
            16754432, 16754176, 16753920, 16753408, 16753408, 16753152, 16752896, 16752640, 
            16752384, 16752128, 16751872, 16751616, 16751360, 16751104, 16750848, 16750592, 
            16750336, 16750080, 16749824, 16749312, 16749312, 16749056, 16748800, 16748544, 
            16748288, 16748032, 16747776, 16747520, 16747264, 16747008, 16746752, 16746496, 
            16746240, 16745984, 16745728, 16745216, 16745216, 16744960, 16744704, 16744448, 
            16744192, 16743936, 16743680, 16743424, 16743168, 16742656, 16742656, 16742400, 
            16742144, 16741888, 16741632, 16741376, 16740864, 16740608, 16740608, 16740352, 
            16740096, 16739840, 16739584, 16739328, 16739072, 16738560, 16738560, 16738304, 
            16738048, 16737792, 16737536, 16737280, 16736768, 16736512, 16736512, 16736256, 
            16736000, 16735744, 16735488, 16735232, 16734976, 16734464, 16734464, 16734208, 
            16733952, 16733696, 16733440, 16733184, 16732672, 16732416, 16732416, 16732160, 
            16731904, 16731648, 16731392, 16731136, 16730880, 16730368, 16730368, 16730112, 
            16729856, 16729600, 16729344, 16729088, 16728576, 16728320, 16728320, 16728064, 
            16727808, 16727552, 16727296, 16727040, 16726784, 16726272, 16726016, 16726016, 
            16725760, 16725504, 16725248, 16724992, 16724480, 16724224, 16723968, 16723968, 
            16723712, 16723456, 16723200, 16722944, 16722688, 16722176, 16721920, 16721920, 
            16721664, 16721408, 16721152, 16720896, 16720384, 16720128, 16719872, 16719872, 
            16719616, 16719360, 16719104, 16718848, 16718592, 16718080, 16717824, 16717824, 
            16717568, 16717312, 16717056, 16716800, 16716288, 16716032, 16715776, 16715776, 
            16715520, 16715264, 16715008, 16714752, 16714496, 16713984, 16713728, 16713728, 
            16713472, 16713216, 16712960, 16712704, 16712192, 16711936, 16711680, 16711680, 
        };
    }
}
