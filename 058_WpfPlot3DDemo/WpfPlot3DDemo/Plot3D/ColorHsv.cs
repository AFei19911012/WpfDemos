using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace WpfPlot3DDemo.Plot3D
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/22 23:53:15
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/22 23:53:15                     BigWang         首次编写         
	///
    [Serializable, StructLayout(LayoutKind.Sequential), DebuggerDisplay("\\{AHSV = ({A}, {H}, {S}, {V})\\}")]
    public struct ColorHsv : IEquatable<Color>
    {
        /// <summary>Initializes a new instance of the <see cref="T:LukeSw.Drawing.ColorHsv"/> structure
        /// from the specified double values.</summary>
        /// <param name="alpha">The alpha component value. Valid values are 0 through 1.</param>
        /// <param name="hue">The hue component value. Valid values are 0 through 360.</param>
        /// <param name="saturation">The saturation component value. Valid values are 0 through 1.</param>
        /// <param name="value">The value component value. Valid values are 0 through 1.</param>
        public ColorHsv(double alpha, double hue, double saturation, double value)
        {
            ColorRgb.Checkdouble(alpha, "alpha");
            ColorRgb.Checkdouble(hue, "hue", 0.0, 360.0);
            if (hue == 360.0)
            {
                hue = 0.0;
            }
            ColorRgb.Checkdouble(saturation, "saturation");
            ColorRgb.Checkdouble(value, "value");
            this.A = alpha;
            this.H = hue;
            this.S = saturation;
            this.V = value;
        }

        /// <summary>Initializes a new instance of the <see cref="T:LukeSw.Drawing.ColorHsv"/> structure
        /// from the specified double values. The alpha value is implicitly 1 (fully opaque).</summary>
        /// <param name="hue">The hue component value. Valid values are 0 through 360.</param>
        /// <param name="saturation">The saturation component value. Valid values are 0 through 1.</param>
        /// <param name="value">The value component value. Valid values are 0 through 1.</param>
        public ColorHsv(double hue, double saturation, double value)
            : this(1.0, hue, saturation, value) { }

        /// <summary>Gets the alpha component value.</summary>
        public readonly double A;
        /// <summary>Gets the hue component value.</summary>
        public readonly double H;
        /// <summary>Gets the saturation component value.</summary>
        public readonly double S;
        /// <summary>Gets the value component value.</summary>
        public readonly double V;

        /// <summary>Converts this <see cref="T:LukeSw.Drawing.ColorHsv" /> structure to a human-readable string.</summary>
        /// <returns>String that consists of the AHSV component names and their values.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(0x20);
            builder.Append(GetType().Name);
            builder.Append(" [");
            builder.Append("A=");
            builder.Append(this.A);
            builder.Append(", H=");
            builder.Append(this.H);
            builder.Append(", S=");
            builder.Append(this.S);
            builder.Append(", V=");
            builder.Append(this.V);
            builder.Append("]");
            return builder.ToString();
        }

        public override bool Equals(object obj) => ToColorRgb().Equals(obj);

        public bool Equals(Color other) => ToColorRgb() == ColorRgb.FromColor(other);

        public override int GetHashCode() => A.GetHashCode() ^ H.GetHashCode() ^ S.GetHashCode() ^ V.GetHashCode();

        public Color ToColor() => ColorRgb.FromColor(this).ToColor();

        public ColorRgb ToColorRgb() => ColorRgb.FromColor(this);

        public ColorHsl ToColorHsl() => ColorRgb.FromColor(this).ToColorHsl();

        public static ColorHsv FromColor(Color color) => ColorRgb.FromColor(color).ToColorHsv();
    }
}