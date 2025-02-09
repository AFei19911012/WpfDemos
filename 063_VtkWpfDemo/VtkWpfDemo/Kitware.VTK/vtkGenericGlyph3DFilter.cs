using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericGlyph3DFilter
/// </summary>
/// <remarks>
///    copy oriented and scaled glyph geometry to every input point
///
/// vtkGenericGlyph3DFilter is a filter that copies a geometric representation (called
/// a glyph) to every point in the input dataset. The glyph is defined with
/// polygonal data from a source filter input. The glyph may be oriented
/// along the input vectors or normals, and it may be scaled according to
/// scalar data or vector magnitude. More than one glyph may be used by
/// creating a table of source objects, each defining a different glyph. If a
/// table of glyphs is defined, then the table can be indexed into by using
/// either scalar value or vector magnitude.
///
/// To use this object you'll have to provide an input dataset and a source
/// to define the glyph. Then decide whether you want to scale the glyph and
/// how to scale the glyph (using scalar value or vector magnitude). Next
/// decide whether you want to orient the glyph, and whether to use the
/// vector data or normal data to orient it. Finally, decide whether to use a
/// table of glyphs, or just a single glyph. If you use a table of glyphs,
/// you'll have to decide whether to index into it with scalar value or with
/// vector magnitude.
///
/// @warning
/// Contrary to vtkGlyph3D, the only way to specify which attributes will be
/// used for scaling, coloring and orienting is through SelectInputScalars(),
/// SelectInputVectors() and SelectInputNormals().
///
/// @warning
/// The scaling of the glyphs is controlled by the ScaleFactor ivar multiplied
/// by the scalar value at each point (if VTK_SCALE_BY_SCALAR is set), or
/// multiplied by the vector magnitude (if VTK_SCALE_BY_VECTOR is set),
/// Alternatively (if VTK_SCALE_BY_VECTORCOMPONENTS is set), the scaling
/// may be specified for x,y,z using the vector components. The
/// scale factor can be further controlled by enabling clamping using the
/// Clamping ivar. If clamping is enabled, the scale is normalized by the
/// Range ivar, and then multiplied by the scale factor. The normalization
/// process includes clamping the scale value between (0,1).
///
/// @warning
/// Typically this object operates on input data with scalar and/or vector
/// data. However, scalar and/or vector aren't necessary, and it can be used
/// to copy data from a single source to each point. In this case the scale
/// factor can be used to uniformly scale the glyphs.
///
/// @warning
/// The object uses "vector" data to scale glyphs, orient glyphs, and/or index
/// into a table of glyphs. You can choose to use either the vector or normal
/// data at each input point. Use the method SetVectorModeToUseVector() to use
/// the vector input data, and SetVectorModeToUseNormal() to use the
/// normal input data.
///
/// @warning
/// If you do use a table of glyphs, make sure to set the Range ivar to make
/// sure the index into the glyph table is computed correctly.
///
/// @warning
/// You can turn off scaling of the glyphs completely by using the Scaling
/// ivar. You can also turn off scaling due to data (either vector or scalar)
/// by using the SetScaleModeToDataScalingOff() method.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorGlyph
/// </seealso>
public class vtkGenericGlyph3DFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericGlyph3DFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericGlyph3DFilter()
	{
		MRClassNameKey = "class vtkGenericGlyph3DFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericGlyph3DFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericGlyph3DFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with scaling on, scaling mode is by scalar value,
	/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
	/// orientation is by vector. Clamping and indexing are turned off. No
	/// initial sources are defined.
	/// </summary>
	public new static vtkGenericGlyph3DFilter New()
	{
		vtkGenericGlyph3DFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGlyph3DFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with scaling on, scaling mode is by scalar value,
	/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
	/// orientation is by vector. Clamping and indexing are turned off. No
	/// initial sources are defined.
	/// </summary>
	public vtkGenericGlyph3DFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericGlyph3DFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_ClampingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual void ClampingOff()
	{
		vtkGenericGlyph3DFilter_ClampingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_ClampingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual void ClampingOn()
	{
		vtkGenericGlyph3DFilter_ClampingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_GeneratePointIdsOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual void GeneratePointIdsOff()
	{
		vtkGenericGlyph3DFilter_GeneratePointIdsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_GeneratePointIdsOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual void GeneratePointIdsOn()
	{
		vtkGenericGlyph3DFilter_GeneratePointIdsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetClamping_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual int GetClamping()
	{
		return vtkGenericGlyph3DFilter_GetClamping_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetColorMode_06(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkGenericGlyph3DFilter_GetColorMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetColorModeAsString_07(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public string GetColorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetColorModeAsString_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetGeneratePointIds_08(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual int GetGeneratePointIds()
	{
		return vtkGenericGlyph3DFilter_GetGeneratePointIds_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetIndexMode_09(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used.
	/// </summary>
	public virtual int GetIndexMode()
	{
		return vtkGenericGlyph3DFilter_GetIndexMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetIndexModeAsString_10(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used.
	/// </summary>
	public string GetIndexModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetIndexModeAsString_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputNormalsSelection_11(HandleRef pThis);

	/// <summary>
	/// If you want to use an arbitrary normals array, then set its name here.
	/// By default this in nullptr and the filter will use the active normal array.
	/// </summary>
	public virtual string GetInputNormalsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetInputNormalsSelection_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputScalarsSelection_12(HandleRef pThis);

	/// <summary>
	/// If you want to use an arbitrary scalars array, then set its name here.
	/// By default this in nullptr and the filter will use the active scalar array.
	/// </summary>
	public virtual string GetInputScalarsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetInputScalarsSelection_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetInputVectorsSelection_13(HandleRef pThis);

	/// <summary>
	/// If you want to use an arbitrary vectors array, then set its name here.
	/// By default this in nullptr and the filter will use the active vector array.
	/// </summary>
	public virtual string GetInputVectorsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetInputVectorsSelection_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericGlyph3DFilter_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetOrient_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual int GetOrient()
	{
		return vtkGenericGlyph3DFilter_GetOrient_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetPointIdsName_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the PointIds array if generated. By default the Ids
	/// are named "InputPointIds", but this can be changed with this function.
	/// </summary>
	public virtual string GetPointIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetPointIdsName_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetRange_18(HandleRef pThis);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkGenericGlyph3DFilter_GetRange_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_GetRange_19(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual void GetRange(IntPtr data)
	{
		vtkGenericGlyph3DFilter_GetRange_19(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericGlyph3DFilter_GetScaleFactor_20(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkGenericGlyph3DFilter_GetScaleFactor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetScaleMode_21(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public virtual int GetScaleMode()
	{
		return vtkGenericGlyph3DFilter_GetScaleMode_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetScaleModeAsString_22(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public string GetScaleModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetScaleModeAsString_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetScaling_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual int GetScaling()
	{
		return vtkGenericGlyph3DFilter_GetScaling_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetSource_24(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to a source object at a specified table location.
	/// </summary>
	public vtkPolyData GetSource(int id)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGlyph3DFilter_GetSource_24(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_GetVectorMode_25(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public virtual int GetVectorMode()
	{
		return vtkGenericGlyph3DFilter_GetVectorMode_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_GetVectorModeAsString_26(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public string GetVectorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGenericGlyph3DFilter_GetVectorModeAsString_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericGlyph3DFilter_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGlyph3DFilter_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericGlyph3DFilter_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericGlyph3DFilter NewInstance()
	{
		vtkGenericGlyph3DFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGlyph3DFilter_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_OrientOff_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual void OrientOff()
	{
		vtkGenericGlyph3DFilter_OrientOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_OrientOn_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual void OrientOn()
	{
		vtkGenericGlyph3DFilter_OrientOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGlyph3DFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericGlyph3DFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGenericGlyph3DFilter vtkGenericGlyph3DFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGlyph3DFilter_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericGlyph3DFilter2 = (vtkGenericGlyph3DFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericGlyph3DFilter2.Register(null);
			}
		}
		return vtkGenericGlyph3DFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_ScalingOff_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkGenericGlyph3DFilter_ScalingOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_ScalingOn_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkGenericGlyph3DFilter_ScalingOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SelectInputNormals_36(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to use an arbitrary normals array, then set its name here.
	/// By default this in nullptr and the filter will use the active normal array.
	/// </summary>
	public void SelectInputNormals(string fieldName)
	{
		vtkGenericGlyph3DFilter_SelectInputNormals_36(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SelectInputScalars_37(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to use an arbitrary scalars array, then set its name here.
	/// By default this in nullptr and the filter will use the active scalar array.
	/// </summary>
	public void SelectInputScalars(string fieldName)
	{
		vtkGenericGlyph3DFilter_SelectInputScalars_37(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SelectInputVectors_38(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to use an arbitrary vectors array, then set its name here.
	/// By default this in nullptr and the filter will use the active vector array.
	/// </summary>
	public void SelectInputVectors(string fieldName)
	{
		vtkGenericGlyph3DFilter_SelectInputVectors_38(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetClamping_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual void SetClamping(int _arg)
	{
		vtkGenericGlyph3DFilter_SetClamping_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetColorMode_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkGenericGlyph3DFilter_SetColorMode_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByScalar_41(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public void SetColorModeToColorByScalar()
	{
		vtkGenericGlyph3DFilter_SetColorModeToColorByScalar_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByScale_42(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public void SetColorModeToColorByScale()
	{
		vtkGenericGlyph3DFilter_SetColorModeToColorByScale_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetColorModeToColorByVector_43(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public void SetColorModeToColorByVector()
	{
		vtkGenericGlyph3DFilter_SetColorModeToColorByVector_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetGeneratePointIds_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual void SetGeneratePointIds(int _arg)
	{
		vtkGenericGlyph3DFilter_SetGeneratePointIds_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetIndexMode_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used.
	/// </summary>
	public virtual void SetIndexMode(int _arg)
	{
		vtkGenericGlyph3DFilter_SetIndexMode_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToOff_46(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used.
	/// </summary>
	public void SetIndexModeToOff()
	{
		vtkGenericGlyph3DFilter_SetIndexModeToOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToScalar_47(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used.
	/// </summary>
	public void SetIndexModeToScalar()
	{
		vtkGenericGlyph3DFilter_SetIndexModeToScalar_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetIndexModeToVector_48(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used.
	/// </summary>
	public void SetIndexModeToVector()
	{
		vtkGenericGlyph3DFilter_SetIndexModeToVector_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetOrient_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual void SetOrient(int _arg)
	{
		vtkGenericGlyph3DFilter_SetOrient_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetPointIdsName_50(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the PointIds array if generated. By default the Ids
	/// are named "InputPointIds", but this can be changed with this function.
	/// </summary>
	public virtual void SetPointIdsName(string _arg)
	{
		vtkGenericGlyph3DFilter_SetPointIdsName_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetRange_51(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual void SetRange(double _arg1, double _arg2)
	{
		vtkGenericGlyph3DFilter_SetRange_51(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetRange_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkGenericGlyph3DFilter_SetRange_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaleFactor_53(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify scale factor to scale object by.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkGenericGlyph3DFilter_SetScaleFactor_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaleMode_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public virtual void SetScaleMode(int _arg)
	{
		vtkGenericGlyph3DFilter_SetScaleMode_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToDataScalingOff_55(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToDataScalingOff()
	{
		vtkGenericGlyph3DFilter_SetScaleModeToDataScalingOff_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByScalar_56(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToScaleByScalar()
	{
		vtkGenericGlyph3DFilter_SetScaleModeToScaleByScalar_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByVector_57(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToScaleByVector()
	{
		vtkGenericGlyph3DFilter_SetScaleModeToScaleByVector_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaleModeToScaleByVectorComponents_58(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToScaleByVectorComponents()
	{
		vtkGenericGlyph3DFilter_SetScaleModeToScaleByVectorComponents_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetScaling_59(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual void SetScaling(int _arg)
	{
		vtkGenericGlyph3DFilter_SetScaling_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetSourceData_60(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Set the source to use for the glyph.
	/// </summary>
	public void SetSourceData(vtkPolyData pd)
	{
		vtkGenericGlyph3DFilter_SetSourceData_60(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetSourceData_61(HandleRef pThis, int id, HandleRef pd);

	/// <summary>
	/// Specify a source object at a specified table location.
	/// </summary>
	public void SetSourceData(int id, vtkPolyData pd)
	{
		vtkGenericGlyph3DFilter_SetSourceData_61(GetCppThis(), id, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetVectorMode_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public virtual void SetVectorMode(int _arg)
	{
		vtkGenericGlyph3DFilter_SetVectorMode_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToUseNormal_63(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToUseNormal()
	{
		vtkGenericGlyph3DFilter_SetVectorModeToUseNormal_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToUseVector_64(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToUseVector()
	{
		vtkGenericGlyph3DFilter_SetVectorModeToUseVector_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGlyph3DFilter_SetVectorModeToVectorRotationOff_65(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToVectorRotationOff()
	{
		vtkGenericGlyph3DFilter_SetVectorModeToVectorRotationOff_65(GetCppThis());
	}
}
