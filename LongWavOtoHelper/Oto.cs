using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongWavOtoHelper
{
    public class Oto
    {
        List<OtoItem> items;

        public Oto(IEnumerable<string> contents)
        {
            items = contents.Select(x => OtoItem.Parse(x)).ToList();
        }

        public void OnDivideWav(DivisionInfo divisionInfo)
        {
            var wavPositions = divisionInfo.GetPositions();

            var itemsGroupedWithBelongedWavIndex = items.GroupBy(item =>
            {
                var nextWavPosition = wavPositions.FirstOrDefault(x => x > item.StartMs);
                if (nextWavPosition == 0.0)
                {
                    return wavPositions.Count - 1;
                }
                var nextWavIndex = wavPositions.IndexOf(nextWavPosition);
                return nextWavIndex - 1;
            });

            items = itemsGroupedWithBelongedWavIndex.SelectMany(group =>
            {
                var belongedWavIndex = group.Key;
                var items = group.ToList();
                return items.Select(item =>
                {
                    var newWaveFileName = divisionInfo.Items[belongedWavIndex].FileName;
                    var newStartMs = item.StartMs - wavPositions[belongedWavIndex];
                    return item.Copy(newWaveFileName, newStartMs);
                });
            }).ToList();
        }

        public void OnRestoreDividedWav(string longWavFileName, DivisionInfo divisionInfo)
        {
            var wavPositions = divisionInfo.GetPositions();
            items = items.Select(item =>
            {

                var infoItem = divisionInfo.Items.First(x => x.FileName == item.WavFileName);
                var position = wavPositions[divisionInfo.Items.IndexOf(infoItem)];
                var newStartMs = item.StartMs + position;
                return item.Copy(longWavFileName, newStartMs);
            }).ToList();
        }

        public override string ToString()
        {
            return string.Join("\r\n", items.Select(x => x.ToString()));
        }
    }

    public class OtoItem
    {
        public string WavFileName;
        public string Alias;
        public double StartMs;
        public string Rest;

        public static OtoItem Parse(string content)
        {
            var index1 = content.IndexOf("=");
            var index2 = content.IndexOf(",");
            var index3 = content.IndexOf(",", index2 + 1);
            return new OtoItem
            {
                WavFileName = content.Substring(0, index1),
                Alias = content.Substring(index1 + 1, index2 - index1 - 1),
                StartMs = double.Parse(content.Substring(index2 + 1, index3 - index2 - 1)),
                Rest = content.Substring(index3 + 1)
            };
        }

        public OtoItem Copy(string wavFileName, double StartMs)
        {
            return new OtoItem
            {
                WavFileName = wavFileName,
                Alias = this.Alias,
                StartMs = StartMs,
                Rest = this.Rest
            };
        }

        public override string ToString()
        {
            return string.Format("{0}={1},{2},{3}", WavFileName, Alias, StartMs, Rest);
        }
    }
}
