using System;

namespace Spectrogram.Colormaps
{
    class Gnbu : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the Gnbu colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            16252144, 16186351, 16120814, 16055278, 16055021, 15989484, 15923948, 15858411, 
            15858154, 15792618, 15727081, 15726824, 15661288, 15595751, 15530214, 15529958, 
            15464421, 15398884, 15398628, 15333091, 15267554, 15202018, 15201761, 15136224, 
            15070688, 15004895, 15004894, 14939358, 14873821, 14873564, 14808028, 14742491, 
            14676698, 14676698, 14611161, 14611160, 14545368, 14479831, 14479830, 14414294, 
            14348501, 14348500, 14282964, 14282963, 14217170, 14151633, 14151633, 14086096, 
            14020303, 14020303, 13954766, 13954765, 13888973, 13823436, 13823435, 13757899, 
            13692106, 13692105, 13626568, 13561032, 13560775, 13495238, 13495238, 13429701, 
            13363908, 13298372, 13232835, 13167043, 13101506, 13035714, 12904641, 12838849, 
            12773312, 12707520, 12641983, 12576447, 12510654, 12445118, 12313789, 12248253, 
            12182460, 12116924, 12051131, 11985595, 11920058, 11854266, 11723193, 11657401, 
            11591864, 11526072, 11460535, 11394999, 11329206, 11198134, 11132341, 11066805, 
            11001013, 10935477, 10804150, 10738614, 10607287, 10541751, 10475960, 10344888, 
            10279096, 10148025, 10082233, 09950906, 09885370, 09819579, 09688507, 09622716, 
            09491644, 09425853, 09360317, 09228990, 09163454, 09032127, 08966591, 08900800, 
            08769728, 08703936, 08572609, 08507073, 08375746, 08310210, 08244419, 08113347, 
            08047556, 07916228, 07850693, 07784901, 07653574, 07587782, 07456455, 07390919, 
            07325128, 07193800, 07128008, 06996681, 06931145, 06799818, 06734026, 06668235, 
            06537163, 06471372, 06340044, 06274253, 06208461, 06077390, 06011598, 05880271, 
            05814479, 05748944, 05617616, 05551824, 05420497, 05354705, 05223634, 05157842, 
            05092050, 05026257, 04960209, 04894416, 04763087, 04697295, 04631246, 04565453, 
            04499661, 04433868, 04368075, 04302027, 04236234, 04170442, 04039113, 03973064, 
            03907272, 03841479, 03775686, 03709638, 03643845, 03578052, 03512260, 03446467, 
            03314882, 03249090, 03183297, 03117504, 03051456, 02985663, 02919870, 02854078, 
            02788285, 02722493, 02590908, 02525115, 02459323, 02393530, 02327738, 02261945, 
            02196153, 02130104, 02064311, 01998519, 01932726, 01801398, 01735605, 01669813, 
            01604020, 01537971, 01472179, 01406386, 01340594, 01274801, 01209009, 01077680, 
            01011888, 00945839, 00880046, 00814254, 00748461, 00682669, 00616876, 00551084, 
            00550570, 00550313, 00550056, 00549798, 00549285, 00549028, 00548770, 00548513, 
            00548000, 00547742, 00547485, 00547227, 00546714, 00546457, 00546199, 00545942, 
            00545429, 00545171, 00544914, 00544657, 00544143, 00543886, 00543629, 00543371, 
            00542858, 00542601, 00542343, 00542086, 00541573, 00541315, 00541058, 00540801, 
        };
    }
}
