using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxisExtended
/// </summary>
/// <remarks>
///    extended axis tick positioning
///
/// This implements the optimization based tick position calculating algorithm in the paper "An
/// Extension of Wilkinson's Algorithm for Positioning Tick Labels on Axes" by Junstin Talbot, Sharon
/// Lin and Pat Hanrahan
///
///
/// </remarks>
/// <seealso>
///
/// vtkAxis
/// </seealso>
public class vtkAxisExtended : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxisExtended";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxisExtended()
	{
		MRClassNameKey = "class vtkAxisExtended";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisExtended"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxisExtended(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisExtended_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxisExtended New()
	{
		vtkAxisExtended result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisExtended_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisExtended)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAxisExtended()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxisExtended_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_Coverage_01(double dmin, double dmax, double lmin, double lmax);

	/// <summary>
	/// This method makes the data range approximately same as the labeling
	/// range more preferable
	/// </summary>
	public static double Coverage(double dmin, double dmax, double lmin, double lmax)
	{
		return vtkAxisExtended_Coverage_01(dmin, dmax, lmin, lmax);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_CoverageMax_02(double dmin, double dmax, double span);

	/// <summary>
	/// This gives the maximum possible value of coverage given the step size
	/// </summary>
	public static double CoverageMax(double dmin, double dmax, double span)
	{
		return vtkAxisExtended_CoverageMax_02(dmin, dmax, span);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_Density_03(int k, double m, double dmin, double dmax, double lmin, double lmax);

	/// <summary>
	/// This method return a value to make the density of the labels close to
	/// the user given value
	/// </summary>
	public static double Density(int k, double m, double dmin, double dmax, double lmin, double lmax)
	{
		return vtkAxisExtended_Density_03(k, m, dmin, dmax, lmin, lmax);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_DensityMax_04(int k, double m);

	/// <summary>
	/// Derives the maximum values for density given k (number of ticks) and
	/// m (user given)
	/// </summary>
	public static double DensityMax(int k, double m)
	{
		return vtkAxisExtended_DensityMax_04(k, m);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_FormatLegibilityScore_05(double n, int format);

	/// <summary>
	/// This methods return the legibility score of different formats
	/// </summary>
	public static double FormatLegibilityScore(double n, int format)
	{
		return vtkAxisExtended_FormatLegibilityScore_05(n, format);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_FormatStringLength_06(int format, double n, int precision);

	/// <summary>
	/// This method returns the string length of different format notations.
	/// </summary>
	public static int FormatStringLength(int format, double n, int precision)
	{
		return vtkAxisExtended_FormatStringLength_06(format, n, precision);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisExtended_GenerateExtendedTickLabels_07(HandleRef pThis, double dmin, double dmax, double m, double scaling, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method implements the algorithm given in the paper
	/// The method return the minimum tick position, maximum tick position and
	/// the tick spacing
	/// </summary>
	public vtkVector3d GenerateExtendedTickLabels(double dmin, double dmax, double m, double scaling)
	{
		vtkVector3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisExtended_GenerateExtendedTickLabels_07(GetCppThis(), dmin, dmax, m, scaling, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_GetDesiredFontSize_08(HandleRef pThis);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual int GetDesiredFontSize()
	{
		return vtkAxisExtended_GetDesiredFontSize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_GetFontSize_09(HandleRef pThis);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual int GetFontSize()
	{
		return vtkAxisExtended_GetFontSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAxisExtended_GetIsAxisVertical_10(HandleRef pThis);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual bool GetIsAxisVertical()
	{
		return (vtkAxisExtended_GetIsAxisVertical_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_GetLabelFormat_11(HandleRef pThis);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual int GetLabelFormat()
	{
		return vtkAxisExtended_GetLabelFormat_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisExtended_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxisExtended_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisExtended_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxisExtended_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_GetOrientation_14(HandleRef pThis);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual int GetOrientation()
	{
		return vtkAxisExtended_GetOrientation_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_GetPrecision_15(HandleRef pThis);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual int GetPrecision()
	{
		return vtkAxisExtended_GetPrecision_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxisExtended_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisExtended_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxisExtended_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisExtended_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxisExtended NewInstance()
	{
		vtkAxisExtended result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisExtended_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisExtended)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisExtended_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxisExtended SafeDownCast(vtkObjectBase o)
	{
		vtkAxisExtended vtkAxisExtended2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisExtended_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisExtended2 = (vtkAxisExtended)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisExtended2.Register(null);
			}
		}
		return vtkAxisExtended2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisExtended_SetDesiredFontSize_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual void SetDesiredFontSize(int _arg)
	{
		vtkAxisExtended_SetDesiredFontSize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisExtended_SetFontSize_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual void SetFontSize(int _arg)
	{
		vtkAxisExtended_SetFontSize_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisExtended_SetIsAxisVertical_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual void SetIsAxisVertical(bool _arg)
	{
		vtkAxisExtended_SetIsAxisVertical_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisExtended_SetLabelFormat_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual void SetLabelFormat(int _arg)
	{
		vtkAxisExtended_SetLabelFormat_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisExtended_SetOrientation_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual void SetOrientation(int _arg)
	{
		vtkAxisExtended_SetOrientation_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisExtended_SetPrecision_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get methods for variables
	/// </summary>
	public virtual void SetPrecision(int _arg)
	{
		vtkAxisExtended_SetPrecision_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_Simplicity_27(int qIndex, int qLength, int j, double lmin, double lmax, double lstep);

	/// <summary>
	/// This method return a value to make step sizes corresponding to low q
	/// and j values more preferable
	/// </summary>
	public static double Simplicity(int qIndex, int qLength, int j, double lmin, double lmax, double lstep)
	{
		return vtkAxisExtended_Simplicity_27(qIndex, qLength, j, lmin, lmax, lstep);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisExtended_SimplicityMax_28(int qIndex, int qLength, int j);

	/// <summary>
	/// This method returns the maximum possible value of simplicity value given
	/// q and j
	/// </summary>
	public static double SimplicityMax(int qIndex, int qLength, int j)
	{
		return vtkAxisExtended_SimplicityMax_28(qIndex, qLength, j);
	}
}
