using System;

namespace Spectrogram.Colormaps
{
    class PlasmaReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the PlasmaReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            15726625, 15791651, 15791397, 15856422, 15921446, 15921190, 15986214, 15985702, 
            16050726, 16116006, 16115494, 16180517, 16180261, 16245285, 16244772, 16310052, 
            16309540, 16374564, 16374052, 16439332, 16438820, 16438564, 16503588, 16503076, 
            16502820, 16567845, 16567333, 16567077, 16566566, 16566054, 16631334, 16630823, 
            16630568, 16630056, 16629801, 16629289, 16628778, 16628523, 16628011, 16627756, 
            16627245, 16626989, 16626478, 16626223, 16625712, 16625457, 16559409, 16559154, 
            16558643, 16558388, 16557877, 16557621, 16491574, 16491319, 16491064, 16425017, 
            16424762, 16424250, 16423995, 16357948, 16357693, 16291902, 16291391, 16291136, 
            16225089, 16224833, 16159042, 16158531, 16158276, 16092485, 16091974, 16026183, 
            16025927, 15959880, 15959625, 15893834, 15893579, 15827532, 15761741, 15761485, 
            15695438, 15695183, 15629392, 15563601, 15563090, 15497299, 15497044, 15431252, 
            15365205, 15364950, 15299159, 15233368, 15233113, 15167066, 15101274, 15035483, 
            15035228, 14969437, 14903390, 14903135, 14837344, 14771552, 14705761, 14639714, 
            14639459, 14573668, 14507877, 14442086, 14441830, 14375783, 14309992, 14244201, 
            14178410, 14112619, 14112364, 14046573, 13980525, 13914734, 13848943, 13783152, 
            13717361, 13717106, 13651315, 13585268, 13519477, 13453685, 13387894, 13322103, 
            13256312, 13190521, 13124730, 13058683, 12992892, 12927101, 12861310, 12795519, 
            12729728, 12663936, 12598145, 12532098, 12466307, 12400516, 12334725, 12268934, 
            12203143, 12137352, 12071561, 12005514, 11939723, 11873932, 11808141, 11676814, 
            11611023, 11545231, 11479184, 11413393, 11347602, 11281811, 11150484, 11084693, 
            11018902, 10953111, 10821527, 10755736, 10689945, 10624154, 10492827, 10427035, 
            10361244, 10295453, 10164126, 10098078, 10032287, 09900960, 09835168, 09769377, 
            09638049, 09572258, 09440931, 09375139, 09309348, 09177764, 09111972, 08980645, 
            08914853, 08783782, 08717990, 08652198, 08520871, 08455335, 08324007, 08258471, 
            08127143, 08061608, 07930280, 07864744, 07733672, 07667880, 07536808, 07471272, 
            07340200, 07274664, 07143592, 07078056, 06946983, 06815911, 06750375, 06619303, 
            06553767, 06422694, 06357158, 06226086, 06160549, 06029477, 05898405, 05833124, 
            05702052, 05636515, 05505443, 05374371, 05308834, 05178018, 05112481, 04981409, 
            04850336, 04784799, 04653727, 04522910, 04457374, 04326301, 04195228, 04129692, 
            03998619, 03867546, 03802266, 03671193, 03540120, 03409048, 03343511, 03212438, 
            03081365, 02950292, 02819476, 02688403, 02557330, 02426257, 02295184, 02164111, 
            02033038, 01902221, 01771148, 01574539, 01377930, 01246857, 01050503, 00788358, 
        };
    }
}
