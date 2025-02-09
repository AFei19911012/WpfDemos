using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArrowSource
/// </summary>
/// <remarks>
///    Appends a cylinder to a cone to form an arrow.
///
/// vtkArrowSource was intended to be used as the source for a glyph.
/// The shaft base is always at (0,0,0). The arrow tip is always at (1,0,0). If
/// "Invert" is true, then the ends are flipped i.e. tip is at (0,0,0) while
/// base is at (1, 0, 0).
/// The resolution of the cone and shaft can be set and default to 6.
/// The radius of the cone and shaft can be set and default to 0.03 and 0.1.
/// The length of the tip can also be set, and defaults to 0.35.
/// </remarks>
public class vtkArrowSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
	/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
	/// at (1, 0, 0).
	/// </summary>
	public enum ArrowOrigins
	{
		/// <summary>enum member</summary>
		Center = 1,
		/// <summary>enum member</summary>
		Default = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArrowSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArrowSource()
	{
		MRClassNameKey = "class vtkArrowSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrowSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArrowSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrowSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static vtkArrowSource New()
	{
		vtkArrowSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrowSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public vtkArrowSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArrowSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ArrowOrigins vtkArrowSource_GetArrowOrigin_01(HandleRef pThis);

	/// <summary>
	/// Sets and Gets the location used for orienting and scaling the arrow.
	/// Default is set to Default.
	/// </summary>
	public virtual ArrowOrigins GetArrowOrigin()
	{
		return vtkArrowSource_GetArrowOrigin_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrowSource_GetArrowOriginAsString_02(HandleRef pThis);

	/// <summary>
	/// Sets and Gets the location used for orienting and scaling the arrow.
	/// Default is set to Default.
	/// </summary>
	public string GetArrowOriginAsString()
	{
		return vtkArrowSource_GetArrowOriginAsString_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrowSource_GetInvert_03(HandleRef pThis);

	/// <summary>
	/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
	/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
	/// at (1, 0, 0).
	/// </summary>
	public virtual bool GetInvert()
	{
		return (vtkArrowSource_GetInvert_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrowSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArrowSource_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrowSource_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArrowSource_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetShaftRadius_06(HandleRef pThis);

	/// <summary>
	/// Set the radius of the shaft.  Defaults to 0.03.
	/// </summary>
	public virtual double GetShaftRadius()
	{
		return vtkArrowSource_GetShaftRadius_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetShaftRadiusMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the radius of the shaft.  Defaults to 0.03.
	/// </summary>
	public virtual double GetShaftRadiusMaxValue()
	{
		return vtkArrowSource_GetShaftRadiusMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetShaftRadiusMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the radius of the shaft.  Defaults to 0.03.
	/// </summary>
	public virtual double GetShaftRadiusMinValue()
	{
		return vtkArrowSource_GetShaftRadiusMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_GetShaftResolution_09(HandleRef pThis);

	/// <summary>
	/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
	/// </summary>
	public virtual int GetShaftResolution()
	{
		return vtkArrowSource_GetShaftResolution_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_GetShaftResolutionMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
	/// </summary>
	public virtual int GetShaftResolutionMaxValue()
	{
		return vtkArrowSource_GetShaftResolutionMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_GetShaftResolutionMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
	/// </summary>
	public virtual int GetShaftResolutionMinValue()
	{
		return vtkArrowSource_GetShaftResolutionMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetTipLength_12(HandleRef pThis);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual double GetTipLength()
	{
		return vtkArrowSource_GetTipLength_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetTipLengthMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual double GetTipLengthMaxValue()
	{
		return vtkArrowSource_GetTipLengthMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetTipLengthMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual double GetTipLengthMinValue()
	{
		return vtkArrowSource_GetTipLengthMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetTipRadius_15(HandleRef pThis);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual double GetTipRadius()
	{
		return vtkArrowSource_GetTipRadius_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetTipRadiusMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual double GetTipRadiusMaxValue()
	{
		return vtkArrowSource_GetTipRadiusMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrowSource_GetTipRadiusMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual double GetTipRadiusMinValue()
	{
		return vtkArrowSource_GetTipRadiusMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_GetTipResolution_18(HandleRef pThis);

	/// <summary>
	/// Set the resolution of the tip.  The tip behaves the same as a cone.
	/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
	/// </summary>
	public virtual int GetTipResolution()
	{
		return vtkArrowSource_GetTipResolution_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_GetTipResolutionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the resolution of the tip.  The tip behaves the same as a cone.
	/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
	/// </summary>
	public virtual int GetTipResolutionMaxValue()
	{
		return vtkArrowSource_GetTipResolutionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_GetTipResolutionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the resolution of the tip.  The tip behaves the same as a cone.
	/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
	/// </summary>
	public virtual int GetTipResolutionMinValue()
	{
		return vtkArrowSource_GetTipResolutionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_InvertOff_21(HandleRef pThis);

	/// <summary>
	/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
	/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
	/// at (1, 0, 0).
	/// </summary>
	public virtual void InvertOff()
	{
		vtkArrowSource_InvertOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_InvertOn_22(HandleRef pThis);

	/// <summary>
	/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
	/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
	/// at (1, 0, 0).
	/// </summary>
	public virtual void InvertOn()
	{
		vtkArrowSource_InvertOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_IsA_23(HandleRef pThis, string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArrowSource_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrowSource_IsTypeOf_24(string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArrowSource_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrowSource_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new vtkArrowSource NewInstance()
	{
		vtkArrowSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrowSource_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrowSource_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static vtkArrowSource SafeDownCast(vtkObjectBase o)
	{
		vtkArrowSource vtkArrowSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrowSource_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArrowSource2 = (vtkArrowSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArrowSource2.Register(null);
			}
		}
		return vtkArrowSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetArrowOrigin_28(HandleRef pThis, ArrowOrigins _arg);

	/// <summary>
	/// Sets and Gets the location used for orienting and scaling the arrow.
	/// Default is set to Default.
	/// </summary>
	public virtual void SetArrowOrigin(ArrowOrigins _arg)
	{
		vtkArrowSource_SetArrowOrigin_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetArrowOriginToCenter_29(HandleRef pThis);

	/// <summary>
	/// Sets and Gets the location used for orienting and scaling the arrow.
	/// Default is set to Default.
	/// </summary>
	public void SetArrowOriginToCenter()
	{
		vtkArrowSource_SetArrowOriginToCenter_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetArrowOriginToDefault_30(HandleRef pThis);

	/// <summary>
	/// Sets and Gets the location used for orienting and scaling the arrow.
	/// Default is set to Default.
	/// </summary>
	public void SetArrowOriginToDefault()
	{
		vtkArrowSource_SetArrowOriginToDefault_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetInvert_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Inverts the arrow direction. When set to true, base is at (1, 0, 0) while the
	/// tip is at (0, 0, 0). The default is false, i.e. base at (0, 0, 0) and the tip
	/// at (1, 0, 0).
	/// </summary>
	public virtual void SetInvert(bool _arg)
	{
		vtkArrowSource_SetInvert_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetShaftRadius_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the radius of the shaft.  Defaults to 0.03.
	/// </summary>
	public virtual void SetShaftRadius(double _arg)
	{
		vtkArrowSource_SetShaftRadius_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetShaftResolution_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the resolution of the shaft. Minimum is 3 for a triangular shaft.
	/// </summary>
	public virtual void SetShaftResolution(int _arg)
	{
		vtkArrowSource_SetShaftResolution_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetTipLength_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual void SetTipLength(double _arg)
	{
		vtkArrowSource_SetTipLength_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetTipRadius_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the length, and radius of the tip.  They default to 0.35 and 0.1
	/// </summary>
	public virtual void SetTipRadius(double _arg)
	{
		vtkArrowSource_SetTipRadius_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrowSource_SetTipResolution_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the resolution of the tip.  The tip behaves the same as a cone.
	/// Resolution 1 gives a single triangle, 2 gives two crossed triangles.
	/// </summary>
	public virtual void SetTipResolution(int _arg)
	{
		vtkArrowSource_SetTipResolution_36(GetCppThis(), _arg);
	}
}
