// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

namespace Avalonia.Media
{
    /// <summary>
    /// Describes how a stroke is drawn.
    /// </summary>
    public class Pen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pen"/> class.
        /// </summary>
        /// <param name="color">The stroke color.</param>
        /// <param name="thickness">The stroke thickness.</param>
        /// <param name="dashStyle">The dash style.</param>
        /// <param name="lineCap">Specifies the type of graphic shape to use on both ends of a line.</param>
        /// <param name="lineJoin">The line join.</param>
        /// <param name="miterLimit">The miter limit.</param>
        public Pen(
            uint color,
            double thickness = 1.0,
            DashStyle dashStyle = null,
            PenLineCap lineCap = PenLineCap.Flat,
            PenLineJoin lineJoin = PenLineJoin.Miter,
            double miterLimit = 10.0) : this(new SolidColorBrush(color), thickness, dashStyle, lineCap, lineJoin, miterLimit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pen"/> class.
        /// </summary>
        /// <param name="brush">The brush used to draw.</param>
        /// <param name="thickness">The stroke thickness.</param>
        /// <param name="dashStyle">The dash style.</param>
        /// <param name="lineCap">The line cap.</param>
        /// <param name="lineJoin">The line join.</param>
        /// <param name="miterLimit">The miter limit.</param>
        public Pen(
            IBrush brush,
            double thickness = 1.0,
            DashStyle dashStyle = null,
            PenLineCap lineCap = PenLineCap.Flat,
            PenLineJoin lineJoin = PenLineJoin.Miter,
            double miterLimit = 10.0)
        {
            Brush = brush;
            Thickness = thickness;
            LineCap = lineCap;
            LineJoin = lineJoin;
            MiterLimit = miterLimit;
            DashStyle = dashStyle;
        }

        /// <summary>
        /// Gets the brush used to draw the stroke.
        /// </summary>
        public IBrush Brush { get; }

        /// <summary>
        /// Gets the stroke thickness.
        /// </summary>
        public double Thickness { get; }

        /// <summary>
        /// Specifies the style of dashed lines drawn with a <see cref="Pen"/> object.
        /// </summary>
        public DashStyle DashStyle { get; }

        /// <summary>
        /// Specifies the type of graphic shape to use on both ends of a line.
        /// </summary>
        public PenLineCap LineCap { get; }

        /// <summary>
        /// Specifies how to join consecutive line or curve segments in a <see cref="PathFigure"/> (subpath) contained in a <see cref="PathGeometry"/> object.
        /// </summary>
        public PenLineJoin LineJoin { get; }

        /// <summary>
        /// The limit on the ratio of the miter length to half this pen's Thickness.
        /// </summary>
        public double MiterLimit { get; }
    }
}
