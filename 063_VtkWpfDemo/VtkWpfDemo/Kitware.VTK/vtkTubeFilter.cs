using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTubeFilter
/// </summary>
/// <remarks>
///    filter that generates tubes around lines
///
/// vtkTubeFilter is a filter that generates a tube around each input line.
/// The tubes are made up of triangle strips and rotate around the tube with
/// the rotation of the line normals. (If no normals are present, they are
/// computed automatically.) The radius of the tube can be set to vary with
/// scalar or vector value. If the radius varies with scalar value the radius
/// is linearly adjusted. If the radius varies by vector, a mass flux preserving
/// variation is used. If the radius varies by vector norm, the radius is
/// linearly adjusted to its norm. The number of sides for the tube also
/// can be specified. You can also specify which of the sides are visible. This
/// is useful for generating interesting striping effects. Other options
/// include the ability to cap the tube and generate texture coordinates.
/// Texture coordinates can be used with an associated texture map to create
/// interesting effects such as marking the tube with stripes corresponding
/// to length or time.
///
/// This filter is typically used to create thick or dramatic lines. Another
/// common use is to combine this filter with vtkStreamTracer to generate
/// streamtubes.
///
/// @warning
/// The number of tube sides must be greater than 3. If you wish to use fewer
/// sides (i.e., a ribbon), use vtkRibbonFilter.
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
/// vtkRibbonFilter vtkStreamTracer vtkTubeBender
///
/// @par Thanks:
/// Michael Finch for absolute scalar radius
/// </seealso>
public class vtkTubeFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTubeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTubeFilter()
	{
		MRClassNameKey = "class vtkTubeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTubeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTubeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with radius 0.5, radius variation turned off, the
	/// number of sides set to 3, and radius factor of 10.
	/// </summary>
	public new static vtkTubeFilter New()
	{
		vtkTubeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTubeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with radius 0.5, radius variation turned off, the
	/// number of sides set to 3, and radius factor of 10.
	/// </summary>
	public vtkTubeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTubeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_CappingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap the ends with polygons. Initial value is off.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkTubeFilter_CappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_CappingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap the ends with polygons. Initial value is off.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkTubeFilter_CappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetCapping_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to cap the ends with polygons. Initial value is off.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkTubeFilter_GetCapping_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeFilter_GetDefaultNormal_04(HandleRef pThis);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and the
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual double[] GetDefaultNormal()
	{
		IntPtr intPtr = vtkTubeFilter_GetDefaultNormal_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_GetDefaultNormal_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and the
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual void GetDefaultNormal(IntPtr data)
	{
		vtkTubeFilter_GetDefaultNormal_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetGenerateTCoords_06(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public virtual int GetGenerateTCoords()
	{
		return vtkTubeFilter_GetGenerateTCoords_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeFilter_GetGenerateTCoordsAsString_07(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public string GetGenerateTCoordsAsString()
	{
		return Marshal.PtrToStringAnsi(vtkTubeFilter_GetGenerateTCoordsAsString_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetGenerateTCoordsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public virtual int GetGenerateTCoordsMaxValue()
	{
		return vtkTubeFilter_GetGenerateTCoordsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetGenerateTCoordsMinValue_09(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public virtual int GetGenerateTCoordsMinValue()
	{
		return vtkTubeFilter_GetGenerateTCoordsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTubeFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTubeFilter_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTubeFilter_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTubeFilter_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetNumberOfSides_12(HandleRef pThis);

	/// <summary>
	/// Set the number of sides for the tube. At a minimum, number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSides()
	{
		return vtkTubeFilter_GetNumberOfSides_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetNumberOfSidesMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set the number of sides for the tube. At a minimum, number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSidesMaxValue()
	{
		return vtkTubeFilter_GetNumberOfSidesMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetNumberOfSidesMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set the number of sides for the tube. At a minimum, number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSidesMinValue()
	{
		return vtkTubeFilter_GetNumberOfSidesMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOffset_15(HandleRef pThis);

	/// <summary>
	/// Control the striping of the tubes. The offset sets the
	/// first tube side that is visible. Offset is generally used with
	/// OnRatio to create nifty striping effects.
	/// </summary>
	public virtual int GetOffset()
	{
		return vtkTubeFilter_GetOffset_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOffsetMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Control the striping of the tubes. The offset sets the
	/// first tube side that is visible. Offset is generally used with
	/// OnRatio to create nifty striping effects.
	/// </summary>
	public virtual int GetOffsetMaxValue()
	{
		return vtkTubeFilter_GetOffsetMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOffsetMinValue_17(HandleRef pThis);

	/// <summary>
	/// Control the striping of the tubes. The offset sets the
	/// first tube side that is visible. Offset is generally used with
	/// OnRatio to create nifty striping effects.
	/// </summary>
	public virtual int GetOffsetMinValue()
	{
		return vtkTubeFilter_GetOffsetMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOnRatio_18(HandleRef pThis);

	/// <summary>
	/// Control the striping of the tubes. If OnRatio is greater than 1,
	/// then every nth tube side is turned on, beginning with the Offset
	/// side.
	/// </summary>
	public virtual int GetOnRatio()
	{
		return vtkTubeFilter_GetOnRatio_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOnRatioMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Control the striping of the tubes. If OnRatio is greater than 1,
	/// then every nth tube side is turned on, beginning with the Offset
	/// side.
	/// </summary>
	public virtual int GetOnRatioMaxValue()
	{
		return vtkTubeFilter_GetOnRatioMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOnRatioMinValue_20(HandleRef pThis);

	/// <summary>
	/// Control the striping of the tubes. If OnRatio is greater than 1,
	/// then every nth tube side is turned on, beginning with the Offset
	/// side.
	/// </summary>
	public virtual int GetOnRatioMinValue()
	{
		return vtkTubeFilter_GetOnRatioMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetOutputPointsPrecision_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkTubeFilter_GetOutputPointsPrecision_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetRadius_22(HandleRef pThis);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkTubeFilter_GetRadius_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetRadiusFactor_23(HandleRef pThis);

	/// <summary>
	/// Set the maximum tube radius in terms of a multiple of the minimum radius.
	/// </summary>
	public virtual double GetRadiusFactor()
	{
		return vtkTubeFilter_GetRadiusFactor_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetRadiusMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkTubeFilter_GetRadiusMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetRadiusMinValue_25(HandleRef pThis);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkTubeFilter_GetRadiusMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetSidesShareVertices_26(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether tube sides should share vertices.
	/// This creates independent strips, with constant normals so the
	/// tube is always faceted in appearance.
	/// </summary>
	public virtual int GetSidesShareVertices()
	{
		return vtkTubeFilter_GetSidesShareVertices_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetTextureLength_27(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual double GetTextureLength()
	{
		return vtkTubeFilter_GetTextureLength_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetTextureLengthMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual double GetTextureLengthMaxValue()
	{
		return vtkTubeFilter_GetTextureLengthMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTubeFilter_GetTextureLengthMinValue_29(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual double GetTextureLengthMinValue()
	{
		return vtkTubeFilter_GetTextureLengthMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetUseDefaultNormal_30(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual int GetUseDefaultNormal()
	{
		return vtkTubeFilter_GetUseDefaultNormal_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetVaryRadius_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public virtual int GetVaryRadius()
	{
		return vtkTubeFilter_GetVaryRadius_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeFilter_GetVaryRadiusAsString_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public string GetVaryRadiusAsString()
	{
		return Marshal.PtrToStringAnsi(vtkTubeFilter_GetVaryRadiusAsString_32(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetVaryRadiusMaxValue_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public virtual int GetVaryRadiusMaxValue()
	{
		return vtkTubeFilter_GetVaryRadiusMaxValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_GetVaryRadiusMinValue_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public virtual int GetVaryRadiusMinValue()
	{
		return vtkTubeFilter_GetVaryRadiusMinValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTubeFilter_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTubeFilter_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTubeFilter_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeFilter_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTubeFilter NewInstance()
	{
		vtkTubeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTubeFilter_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTubeFilter_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTubeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTubeFilter vtkTubeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTubeFilter_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTubeFilter2 = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTubeFilter2.Register(null);
			}
		}
		return vtkTubeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetCapping_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether to cap the ends with polygons. Initial value is off.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkTubeFilter_SetCapping_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetDefaultNormal_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and the
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual void SetDefaultNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkTubeFilter_SetDefaultNormal_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetDefaultNormal_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the default normal to use if no normals are supplied, and the
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual void SetDefaultNormal(IntPtr _arg)
	{
		vtkTubeFilter_SetDefaultNormal_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetGenerateTCoords_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public virtual void SetGenerateTCoords(int _arg)
	{
		vtkTubeFilter_SetGenerateTCoords_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetGenerateTCoordsToNormalizedLength_44(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public void SetGenerateTCoordsToNormalizedLength()
	{
		vtkTubeFilter_SetGenerateTCoordsToNormalizedLength_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetGenerateTCoordsToOff_45(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public void SetGenerateTCoordsToOff()
	{
		vtkTubeFilter_SetGenerateTCoordsToOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetGenerateTCoordsToUseLength_46(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public void SetGenerateTCoordsToUseLength()
	{
		vtkTubeFilter_SetGenerateTCoordsToUseLength_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetGenerateTCoordsToUseScalars_47(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the tube with length textures, etc. If you
	/// use scalars to create the texture, the scalars are assumed to be
	/// monotonically increasing (or decreasing).
	/// </summary>
	public void SetGenerateTCoordsToUseScalars()
	{
		vtkTubeFilter_SetGenerateTCoordsToUseScalars_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetNumberOfSides_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of sides for the tube. At a minimum, number of sides is 3.
	/// </summary>
	public virtual void SetNumberOfSides(int _arg)
	{
		vtkTubeFilter_SetNumberOfSides_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetOffset_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the striping of the tubes. The offset sets the
	/// first tube side that is visible. Offset is generally used with
	/// OnRatio to create nifty striping effects.
	/// </summary>
	public virtual void SetOffset(int _arg)
	{
		vtkTubeFilter_SetOffset_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetOnRatio_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the striping of the tubes. If OnRatio is greater than 1,
	/// then every nth tube side is turned on, beginning with the Offset
	/// side.
	/// </summary>
	public virtual void SetOnRatio(int _arg)
	{
		vtkTubeFilter_SetOnRatio_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetOutputPointsPrecision_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkTubeFilter_SetOutputPointsPrecision_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetRadius_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the minimum tube radius (minimum because the tube radius may vary).
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkTubeFilter_SetRadius_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetRadiusFactor_53(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the maximum tube radius in terms of a multiple of the minimum radius.
	/// </summary>
	public virtual void SetRadiusFactor(double _arg)
	{
		vtkTubeFilter_SetRadiusFactor_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetSidesShareVertices_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Set a boolean to control whether tube sides should share vertices.
	/// This creates independent strips, with constant normals so the
	/// tube is always faceted in appearance.
	/// </summary>
	public virtual void SetSidesShareVertices(int _arg)
	{
		vtkTubeFilter_SetSidesShareVertices_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetTextureLength_55(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual void SetTextureLength(double _arg)
	{
		vtkTubeFilter_SetTextureLength_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetUseDefaultNormal_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual void SetUseDefaultNormal(int _arg)
	{
		vtkTubeFilter_SetUseDefaultNormal_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetVaryRadius_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public virtual void SetVaryRadius(int _arg)
	{
		vtkTubeFilter_SetVaryRadius_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByAbsoluteScalar_58(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public void SetVaryRadiusToVaryRadiusByAbsoluteScalar()
	{
		vtkTubeFilter_SetVaryRadiusToVaryRadiusByAbsoluteScalar_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByScalar_59(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public void SetVaryRadiusToVaryRadiusByScalar()
	{
		vtkTubeFilter_SetVaryRadiusToVaryRadiusByScalar_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByVector_60(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public void SetVaryRadiusToVaryRadiusByVector()
	{
		vtkTubeFilter_SetVaryRadiusToVaryRadiusByVector_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByVectorNorm_61(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public void SetVaryRadiusToVaryRadiusByVectorNorm()
	{
		vtkTubeFilter_SetVaryRadiusToVaryRadiusByVectorNorm_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusOff_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off the variation of tube radius with scalar value.
	/// </summary>
	public void SetVaryRadiusToVaryRadiusOff()
	{
		vtkTubeFilter_SetVaryRadiusToVaryRadiusOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SidesShareVerticesOff_63(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether tube sides should share vertices.
	/// This creates independent strips, with constant normals so the
	/// tube is always faceted in appearance.
	/// </summary>
	public virtual void SidesShareVerticesOff()
	{
		vtkTubeFilter_SidesShareVerticesOff_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_SidesShareVerticesOn_64(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether tube sides should share vertices.
	/// This creates independent strips, with constant normals so the
	/// tube is always faceted in appearance.
	/// </summary>
	public virtual void SidesShareVerticesOn()
	{
		vtkTubeFilter_SidesShareVerticesOn_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_UseDefaultNormalOff_65(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual void UseDefaultNormalOff()
	{
		vtkTubeFilter_UseDefaultNormalOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTubeFilter_UseDefaultNormalOn_66(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// DefaultNormalOn is set.
	/// </summary>
	public virtual void UseDefaultNormalOn()
	{
		vtkTubeFilter_UseDefaultNormalOn_66(GetCppThis());
	}
}
