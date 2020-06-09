using System;

namespace Spectrogram.Colormaps
{
    class Pubugn : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the Pubugn colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            16775163, 16709370, 16643578, 16643577, 16577785, 16577529, 16511992, 16446200, 
            16445944, 16380407, 16380151, 16314359, 16248822, 16248566, 16182774, 16182773, 
            16116981, 16051189, 16051188, 15985396, 15985140, 15919603, 15853811, 15853555, 
            15788018, 15787762, 15721970, 15656433, 15656177, 15590384, 15590384, 15524592, 
            15458799, 15458799, 15393007, 15327471, 15261678, 15196142, 15130350, 15064813, 
            14999021, 14933485, 14933228, 14867692, 14801900, 14736363, 14670571, 14604779, 
            14539242, 14473450, 14473450, 14407658, 14342121, 14276329, 14210793, 14145000, 
            14079464, 14013672, 14013671, 13947879, 13882343, 13816550, 13750758, 13685222, 
            13619429, 13553893, 13488101, 13356772, 13291236, 13225444, 13094371, 13028579, 
            12962787, 12831714, 12765922, 12700130, 12569057, 12503265, 12437729, 12306400, 
            12240608, 12175072, 12043743, 11977951, 11912415, 11846622, 11715550, 11649757, 
            11583965, 11452893, 11387100, 11321308, 11190236, 11124443, 11058907, 10927579, 
            10861786, 10730714, 10599386, 10468057, 10336985, 10205656, 10074584, 09943256, 
            09811927, 09680855, 09549527, 09418198, 09287126, 09155797, 09024469, 08893397, 
            08762068, 08630996, 08499668, 08368339, 08237267, 08105938, 07974610, 07843538, 
            07712209, 07581137, 07449809, 07318480, 07187408, 07056079, 06924751, 06793679, 
            06727886, 06596558, 06531021, 06399693, 06333900, 06202572, 06136779, 06005707, 
            05874379, 05808586, 05677258, 05611465, 05480393, 05414600, 05283272, 05217479, 
            05086407, 05020614, 04889286, 04823493, 04692165, 04561092, 04495300, 04363971, 
            04298179, 04166851, 04101314, 03969986, 03904193, 03772865, 03707328, 03576000, 
            03444670, 03379133, 03247803, 03182265, 03050936, 02919862, 02854068, 02722995, 
            02591665, 02526127, 02395054, 02329260, 02198186, 02066856, 02001319, 01869989, 
            01738915, 01673122, 01542048, 01410718, 01345181, 01213851, 01148313, 01016983, 
            00885910, 00820116, 00689042, 00557969, 00492175, 00361101, 00295308, 00164234, 
            00098440, 00098183, 00098181, 00097924, 00097666, 00097665, 00097407, 00097150, 
            00097148, 00096891, 00096633, 00096631, 00096374, 00096116, 00096115, 00095857, 
            00095600, 00095598, 00095341, 00095083, 00095082, 00094824, 00094823, 00094565, 
            00094307, 00094306, 00094048, 00093791, 00093789, 00093532, 00093274, 00093273, 
            00092760, 00092502, 00092245, 00091988, 00091731, 00091218, 00090961, 00090704, 
            00090447, 00090190, 00089933, 00089419, 00089162, 00088905, 00088648, 00088391, 
            00087878, 00087621, 00087364, 00087107, 00086850, 00086336, 00086079, 00085822, 
            00085565, 00085308, 00084795, 00084538, 00084281, 00084024, 00083767, 00083510, 
        };
    }
}
