using System;
using System.Collections.Generic;
using System.Text;

namespace LongWavOtoHelper
{
    public class Model
    {
        public static string GetOtoWithDividedWav(string[] otoLines, string[] wavFilePaths)
        {
            var oto = new Oto(otoLines);
            var divisionInfo = new DivisionInfo(wavFilePaths);
            oto.OnDivideWav(divisionInfo);
            return oto.ToString();
        }

        public static string GetOtoWithJoinedWav(string[] otoLines, string longWavFileName, string[] wavFilePaths)
        {
            var oto = new Oto(otoLines);
            var divisionInfo = new DivisionInfo(wavFilePaths);
            oto.OnRestoreDividedWav(longWavFileName, divisionInfo);
            return oto.ToString();
        }
    }
}
