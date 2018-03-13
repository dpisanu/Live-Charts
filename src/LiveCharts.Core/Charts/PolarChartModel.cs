﻿using System.Drawing;
using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Dimensions;

namespace LiveCharts.Core.Charts
{
    /// <summary>
    /// Represents a chart with a polar system.
    /// </summary>
    /// <seealso cref="ChartModel" />
    public class PolarChartModel : ChartModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolarChartModel"/> class.
        /// </summary>
        /// <param name="view">The chart view.</param>
        public PolarChartModel(IChartView view)
            : base(view)
        {
        }

        /// <inheritdoc />
        public override float ScaleToUi(float dataValue, Plane plane, float[] sizeVector = null)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public override float ScaleFromUi(float pixelsValue, Plane plane, float[] sizeVector = null)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        protected override void ViewOnPointerMoved(PointF location, TooltipSelectionMode selectionMode, params double[] dimensions)
        {
            throw new System.NotImplementedException();
        }
    }
}