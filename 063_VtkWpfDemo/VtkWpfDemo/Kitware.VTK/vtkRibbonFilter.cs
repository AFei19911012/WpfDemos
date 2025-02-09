using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRibbonFilter
/// </summary>
/// <remarks>
///    create oriented ribbons from lines defined in polygonal dataset
///
/// vtkRibbonFilter is a filter to create oriented ribbons from lines defined
/// in polygonal dataset. The orientation of the ribbon is along the line
/// segments and perpendicular to "projected" line normals. Projected line
/// normals are the original line normals projected to be perpendicular to
/// the local line segment. An offset angle can be specified to rotate the
/// ribbon with respect to the normal.
///
/// @warning
/// The input line must not have duplicate points, or normals at points that
/// are parallel to the incoming/outgoing line segments. (Duplicate points
/// can be removed with vtkCleanPolyData.) If a line does not meet this
/// criteria, then that line is not tubed.
///
/// </remarks>
/// <seealso>
///
/// vtkTubeFilter
/// </seealso>
public class vtkRibbonFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRibbonFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRibbonFilter()
	{
		MRClassNameKey = "class vtkRibbonFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRibbonFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRibbonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRibbonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct ribbon so that width is 0.1, the width does
	/// not vary with scalar values, and the width factor is 2.0.
	/// </summary>
	public new static vtkRibbonFilter New()
	{
		vtkRibbonFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRibbonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct ribbon so that width is 0.1, the width does
	/// not vary with scalar values, and the width factor is 2.0.
	/// </summary>
	public vtkRibbonFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRibbonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetAngle_01(HandleRef pThis);

	/// <summary>
	/// Set the offset angle of the ribbon from the line normal. (The angle
	/// is expressed in degrees.) The default is 0.0
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkRibbonFilter_GetAngle_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetAngleMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set the offset angle of the ribbon from the line normal. (The angle
	/// is expressed in degrees.) The default is 0.0
	/// </summary>
	public virtual double GetAngleMaxValue()
	{
		return vtkRibbonFilter_GetAngleMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetAngleMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set the offset angle of the ribbon from the line normal. (The angle
	/// is expressed in degrees.) The default is 0.0
	/// </summary>
	public virtual double GetAngleMinValue()
	{
		return vtkRibbonFilter_GetAngleMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRibbonFilter_GetDefaultNormal_04(HandleRef pThis);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and
	/// DefaultNormalOn is set. The default is (0,0,1)
	/// </summary>
	public virtual double[] GetDefaultNormal()
	{
		IntPtr intPtr = vtkRibbonFilter_GetDefaultNormal_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_GetDefaultNormal_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and
	/// DefaultNormalOn is set. The default is (0,0,1)
	/// </summary>
	public virtual void GetDefaultNormal(IntPtr data)
	{
		vtkRibbonFilter_GetDefaultNormal_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_GetGenerateTCoords_06(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public virtual int GetGenerateTCoords()
	{
		return vtkRibbonFilter_GetGenerateTCoords_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRibbonFilter_GetGenerateTCoordsAsString_07(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public string GetGenerateTCoordsAsString()
	{
		return Marshal.PtrToStringAnsi(vtkRibbonFilter_GetGenerateTCoordsAsString_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_GetGenerateTCoordsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public virtual int GetGenerateTCoordsMaxValue()
	{
		return vtkRibbonFilter_GetGenerateTCoordsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_GetGenerateTCoordsMinValue_09(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public virtual int GetGenerateTCoordsMinValue()
	{
		return vtkRibbonFilter_GetGenerateTCoordsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRibbonFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRibbonFilter_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRibbonFilter_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRibbonFilter_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetTextureLength_12(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space. The default is 1.0
	/// </summary>
	public virtual double GetTextureLength()
	{
		return vtkRibbonFilter_GetTextureLength_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetTextureLengthMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space. The default is 1.0
	/// </summary>
	public virtual double GetTextureLengthMaxValue()
	{
		return vtkRibbonFilter_GetTextureLengthMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetTextureLengthMinValue_14(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space. The default is 1.0
	/// </summary>
	public virtual double GetTextureLengthMinValue()
	{
		return vtkRibbonFilter_GetTextureLengthMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_GetUseDefaultNormal_15(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// The default is Off
	/// </summary>
	public virtual int GetUseDefaultNormal()
	{
		return vtkRibbonFilter_GetUseDefaultNormal_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_GetVaryWidth_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of ribbon width with scalar value.
	/// The default is Off
	/// </summary>
	public virtual int GetVaryWidth()
	{
		return vtkRibbonFilter_GetVaryWidth_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetWidth_17(HandleRef pThis);

	/// <summary>
	/// Set the "half" width of the ribbon. If the width is allowed to vary,
	/// this is the minimum width. The default is 0.5
	/// </summary>
	public virtual double GetWidth()
	{
		return vtkRibbonFilter_GetWidth_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetWidthFactor_18(HandleRef pThis);

	/// <summary>
	/// Set the maximum ribbon width in terms of a multiple of the minimum width.
	/// The default is 2.0
	/// </summary>
	public virtual double GetWidthFactor()
	{
		return vtkRibbonFilter_GetWidthFactor_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetWidthMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the "half" width of the ribbon. If the width is allowed to vary,
	/// this is the minimum width. The default is 0.5
	/// </summary>
	public virtual double GetWidthMaxValue()
	{
		return vtkRibbonFilter_GetWidthMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRibbonFilter_GetWidthMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the "half" width of the ribbon. If the width is allowed to vary,
	/// this is the minimum width. The default is 0.5
	/// </summary>
	public virtual double GetWidthMinValue()
	{
		return vtkRibbonFilter_GetWidthMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRibbonFilter_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRibbonFilter_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRibbonFilter_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRibbonFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRibbonFilter NewInstance()
	{
		vtkRibbonFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRibbonFilter_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRibbonFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRibbonFilter SafeDownCast(vtkObjectBase o)
	{
		vtkRibbonFilter vtkRibbonFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRibbonFilter_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRibbonFilter2 = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRibbonFilter2.Register(null);
			}
		}
		return vtkRibbonFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetAngle_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the offset angle of the ribbon from the line normal. (The angle
	/// is expressed in degrees.) The default is 0.0
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkRibbonFilter_SetAngle_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetDefaultNormal_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and
	/// DefaultNormalOn is set. The default is (0,0,1)
	/// </summary>
	public virtual void SetDefaultNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkRibbonFilter_SetDefaultNormal_27(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetDefaultNormal_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and
	/// DefaultNormalOn is set. The default is (0,0,1)
	/// </summary>
	public virtual void SetDefaultNormal(IntPtr _arg)
	{
		vtkRibbonFilter_SetDefaultNormal_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetGenerateTCoords_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public virtual void SetGenerateTCoords(int _arg)
	{
		vtkRibbonFilter_SetGenerateTCoords_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetGenerateTCoordsToNormalizedLength_30(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public void SetGenerateTCoordsToNormalizedLength()
	{
		vtkRibbonFilter_SetGenerateTCoordsToNormalizedLength_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetGenerateTCoordsToOff_31(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public void SetGenerateTCoordsToOff()
	{
		vtkRibbonFilter_SetGenerateTCoordsToOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetGenerateTCoordsToUseLength_32(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public void SetGenerateTCoordsToUseLength()
	{
		vtkRibbonFilter_SetGenerateTCoordsToUseLength_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetGenerateTCoordsToUseScalars_33(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the ribbon with time textures, etc.
	/// </summary>
	public void SetGenerateTCoordsToUseScalars()
	{
		vtkRibbonFilter_SetGenerateTCoordsToUseScalars_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetTextureLength_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space. The default is 1.0
	/// </summary>
	public virtual void SetTextureLength(double _arg)
	{
		vtkRibbonFilter_SetTextureLength_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetUseDefaultNormal_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// The default is Off
	/// </summary>
	public virtual void SetUseDefaultNormal(int _arg)
	{
		vtkRibbonFilter_SetUseDefaultNormal_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetVaryWidth_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the variation of ribbon width with scalar value.
	/// The default is Off
	/// </summary>
	public virtual void SetVaryWidth(int _arg)
	{
		vtkRibbonFilter_SetVaryWidth_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetWidth_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the "half" width of the ribbon. If the width is allowed to vary,
	/// this is the minimum width. The default is 0.5
	/// </summary>
	public virtual void SetWidth(double _arg)
	{
		vtkRibbonFilter_SetWidth_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_SetWidthFactor_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the maximum ribbon width in terms of a multiple of the minimum width.
	/// The default is 2.0
	/// </summary>
	public virtual void SetWidthFactor(double _arg)
	{
		vtkRibbonFilter_SetWidthFactor_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_UseDefaultNormalOff_39(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// The default is Off
	/// </summary>
	public virtual void UseDefaultNormalOff()
	{
		vtkRibbonFilter_UseDefaultNormalOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_UseDefaultNormalOn_40(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// The default is Off
	/// </summary>
	public virtual void UseDefaultNormalOn()
	{
		vtkRibbonFilter_UseDefaultNormalOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_VaryWidthOff_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of ribbon width with scalar value.
	/// The default is Off
	/// </summary>
	public virtual void VaryWidthOff()
	{
		vtkRibbonFilter_VaryWidthOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRibbonFilter_VaryWidthOn_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of ribbon width with scalar value.
	/// The default is Off
	/// </summary>
	public virtual void VaryWidthOn()
	{
		vtkRibbonFilter_VaryWidthOn_42(GetCppThis());
	}
}
