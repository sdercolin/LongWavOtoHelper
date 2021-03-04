using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LongWavOtoHelper
{
    public class DivisionInfo
    {
        public List<DivisionInfoItem> Items;

        public DivisionInfo(IEnumerable<string> filePaths)
        {
            Items = filePaths.Select(x => DivisionInfoItem.Parse(x)).ToList();
        }

        public List<double> GetPositions()
        {
            var lengths = Items.Select(x => x.LengthMs).ToList();
            return lengths
                .Select((x, index) =>
                {
                    var previousLengths = lengths.ToList().GetRange(0, index);
                    return previousLengths.Sum();
                })
                .ToList();
        }
    }

    public class DivisionInfoItem
    {
        public double LengthMs;
        public string FileName;

        public static DivisionInfoItem Parse(string filePath)
        {
            return new DivisionInfoItem
            {
                LengthMs = WavUtil.GetDurationMs(filePath),
                FileName = new FileInfo(filePath).Name
            };
        }
    }
}
