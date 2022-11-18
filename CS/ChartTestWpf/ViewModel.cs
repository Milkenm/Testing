using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

namespace ChartTestWpf
{
    public class ViewModel
    {
        public ISeries[] Series { get; set; }
            = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 10,20,100,500 },
                    Fill = null
                }
            };
    }
}
