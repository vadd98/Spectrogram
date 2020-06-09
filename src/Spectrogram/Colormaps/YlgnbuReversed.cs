using System;

namespace Spectrogram.Colormaps
{
    class YlgnbuReversed : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value)
        {
            byte[] bytes = BitConverter.GetBytes(rgb[value]);
            return (bytes[2], bytes[1], bytes[0]);
        }

        // RGB values are derived from the YlgnbuReversed colormap in Matplotlib 3.2.1 (https://matplotlib.org)
        private readonly int[] rgb =
        {
            00531800, 00531801, 00597595, 00663389, 00728927, 00794721, 00860515, 00926309, 
            00991847, 01057640, 01123434, 01188972, 01189230, 01255024, 01320818, 01386356, 
            01452150, 01517944, 01583481, 01649275, 01715069, 01780863, 01846401, 01846659, 
            01912453, 01978247, 02043784, 02109578, 02175372, 02240910, 02306704, 02372498, 
            02372756, 02373012, 02373269, 02373781, 02374038, 02374295, 02374807, 02375064, 
            02375321, 02375833, 02376090, 02310810, 02311067, 02311580, 02311836, 02312093, 
            02312606, 02312862, 02313119, 02313632, 02313888, 02314145, 02249121, 02249378, 
            02249635, 02250147, 02250404, 02250661, 02251173, 02251430, 02251686, 02252199, 
            02186920, 02187432, 02187689, 02188202, 02188459, 02188971, 02189484, 02124205, 
            02124718, 02124974, 02125487, 02126000, 02126257, 02061233, 02061490, 02062003, 
            02062516, 02062772, 02063285, 01998006, 01998519, 01999032, 01999288, 01999801, 
            02000058, 02000571, 01935291, 01935804, 01936317, 01936574, 01937086, 01937599, 
            01937856, 02003648, 02069440, 02135232, 02201280, 02332608, 02398400, 02464192, 
            02529985, 02595777, 02661825, 02727617, 02793409, 02924737, 02990529, 03056321, 
            03122370, 03188162, 03253954, 03319746, 03451074, 03516866, 03582658, 03648706, 
            03714499, 03780291, 03846083, 03911875, 04043203, 04109251, 04175043, 04240835, 
            04306627, 04437955, 04569027, 04700355, 04831682, 04962754, 05094082, 05225409, 
            05356737, 05487809, 05619137, 05750464, 05881792, 06012864, 06144191, 06275519, 
            06406591, 06537919, 06603710, 06735038, 06866110, 06997437, 07128765, 07259837, 
            07391165, 07522492, 07653820, 07784892, 07916219, 08047547, 08178875, 08309947, 
            08441274, 08572602, 08703930, 08900794, 09032121, 09163193, 09294521, 09491385, 
            09622713, 09754040, 09950904, 10082232, 10213560, 10344632, 10541495, 10672823, 
            10804151, 10935479, 11132342, 11263670, 11394998, 11526070, 11722934, 11854261, 
            11985589, 12116917, 12313781, 12445108, 12576436, 12707764, 12904372, 13035700, 
            13101491, 13232563, 13298355, 13363891, 13429683, 13495219, 13626547, 13692083, 
            13757875, 13823411, 13889202, 14020274, 14086066, 14151602, 14217138, 14282930, 
            14348466, 14479794, 14545330, 14611122, 14676658, 14742449, 14873521, 14939313, 
            15004849, 15070641, 15136177, 15267505, 15333041, 15398833, 15464369, 15529905, 
            15595698, 15661235, 15661236, 15726773, 15727031, 15792568, 15792569, 15858106, 
            15923644, 15923901, 15989438, 15989439, 16054977, 16055234, 16120771, 16120772, 
            16186310, 16251847, 16252104, 16317641, 16317643, 16383180, 16383437, 16448974, 
            16514512, 16514513, 16580050, 16580307, 16645845, 16645846, 16711383, 16777177, 
        };
    }
}
