﻿using System.Collections.Generic;
using System.Drawing;

namespace LiveCharts.Core.Abstractions
{
    /// <summary>
    /// Defines a path.
    /// </summary>
    public interface ICartesianPath
    {
        /// <summary>
        /// Initializes the specified view.
        /// </summary>
        /// <param name="view">The view.</param>
        void Initialize(IChartView view);

        /// <summary>
        /// Sets the style.
        /// </summary>
        /// <param name="startPoint">The start point of the path.</param>
        /// <param name="stroke">The stroke.</param>
        /// <param name="fill">The fill.</param>
        /// <param name="strokeThickness">The stroke thickness.</param>
        /// <param name="strokeDashArray">The stroke dash array.</param>
        void SetStyle(
            PointF startPoint, Color stroke, Color fill, double strokeThickness, IEnumerable<double> strokeDashArray);

        /// <summary>
        /// Adds the bezier segment and returns the instance added.
        /// </summary>
        /// <param name="segment">The segment instance.</param>
        /// <param name="index">The index to insert the segment at.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="p3">The p3.</param>
        object InsertSegment(object segment, int index, PointF p1, PointF p2, PointF p3);

        /// <summary>
        /// Removes the segment.
        /// </summary>
        /// <param name="segment">The segment.</param>
        void RemoveSegment(object segment);

        /// <summary>
        /// Closes this instance.
        /// </summary>
        void Close(IChartView view, double length, double i, double j);

        /// <summary>
        /// Disposes the specified view.
        /// </summary>
        /// <param name="view">The view.</param>
        void Dispose(IChartView view);
    }
}
