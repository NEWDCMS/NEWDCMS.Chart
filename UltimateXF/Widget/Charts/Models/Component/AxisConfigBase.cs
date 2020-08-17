using System;
using Xamarin.Forms;

namespace UltimateXF.Widget.Charts.Models.Component
{
    public abstract class AxisConfigBase : ConfigBase
    {
        /// <summary>
        /// 启用网格线
        /// </summary>
        private bool? _DrawGridLines;
        public bool? DrawGridLines
        {
            get => _DrawGridLines;
            set
            {
                _DrawGridLines = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 网格颜色
        /// </summary>
        private Color? _GridColor;
        public Color? GridColor
        {
            get => _GridColor;
            set
            {
                _GridColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 轴线宽度
        /// </summary>
        private float? _AxisLineWidth;
        public float? AxisLineWidth
        {
            get => _AxisLineWidth;
            set
            {
                _AxisLineWidth = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 网格线宽度
        /// </summary>
        private float? _GridLineWidth;
        public float? GridLineWidth
        {
            get => _GridLineWidth;
            set
            {
                _GridLineWidth = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 轴线颜色
        /// </summary>
        private Color? _AxisLineColor;
        public Color? AxisLineColor
        {
            get => _AxisLineColor;
            set
            {
                _AxisLineColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 绘制标签
        /// </summary>
        private bool? _DrawLabels;
        public bool? DrawLabels
        {
            get => _DrawLabels;
            set
            {
                _DrawLabels = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 最小间隔
        /// </summary>
        private float? _SpaceMin;
        public float? SpaceMin
        {
            get => _SpaceMin;
            set
            {
                _SpaceMin = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 最大间隔
        /// </summary>
        private float? _SpaceMax;
        public float? SpaceMax
        {
            get => _SpaceMax;
            set
            {
                _SpaceMax = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 是否绘制轴线
        /// </summary>
        private bool? _DrawAxisLine;
        public bool? DrawAxisLine
        {
            get => _DrawAxisLine;
            set
            {
                _DrawAxisLine = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 是否启用中间轴线标签
        /// </summary>
        private bool? _CenterAxisLabels;
        public bool? CenterAxisLabels
        {
            get => _CenterAxisLabels;
            set
            {
                _CenterAxisLabels = value;
                OnPropertyChanged();
            }
        }

        private float? _AxisMaximum;
        public float? AxisMaximum
        {
            get => _AxisMaximum;
            set
            {
                _AxisMaximum = value;
                OnPropertyChanged();
            }
        }

        private float? _AxisMinimum;
        public float? AxisMinimum
        {
            get => _AxisMinimum;
            set
            {
                _AxisMinimum = value;
                OnPropertyChanged();
            }
        }

        private bool? _DrawGridLinesBehindData;
        public bool? DrawGridLinesBehindData
        {
            get => _DrawGridLinesBehindData;
            set
            {
                _DrawGridLinesBehindData = value;
                OnPropertyChanged();
            }
        }

        private bool? _DrawLimitLineBehindData;
        public bool? DrawLimitLineBehindData
        {
            get => _DrawLimitLineBehindData;
            set
            {
                _DrawLimitLineBehindData = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool? _ForceLabels;
        public bool? ForceLabels
        {
            get => _ForceLabels;
            set
            {
                _ForceLabels = value;
                OnPropertyChanged();
            }
        }

        private bool? _CustomAxisMin;
        public bool? CustomAxisMin
        {
            get => _CustomAxisMin;
            set
            {
                _CustomAxisMin = value;
                OnPropertyChanged();
            }
        }

        private bool? _CustomAxisMax;
        public bool? CustomAxisMax
        {
            get => _CustomAxisMax;
            set
            {
                _CustomAxisMax = value;
                OnPropertyChanged();
            }
        }

        private bool? _GranularityEnabled;
        public bool? GranularityEnabled
        {
            get => _GranularityEnabled;
            set
            {
                _GranularityEnabled = value;
                OnPropertyChanged();
            }
        }

        private float? _Granularity;
        public float? Granularity
        {
            get => _Granularity;
            set
            {
                _Granularity = value;
                OnPropertyChanged();
            }
        }

        private int? _LabelCount;
        public int? LabelCount
        {
            get => _LabelCount;
            set
            {
                _LabelCount = value;
                OnPropertyChanged();
            }
        }

        private IAxisValueFormatterXF _AxisValueFormatter;
        public IAxisValueFormatterXF AxisValueFormatter
        {
            get => _AxisValueFormatter;
            set
            {
                _AxisValueFormatter = value;
                OnPropertyChanged();
            }
        }

        public AxisConfigBase()
        {
            
        }
    }
}