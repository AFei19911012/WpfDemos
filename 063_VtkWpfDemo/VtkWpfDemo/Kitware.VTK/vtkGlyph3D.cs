using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGlyph3D
/// </summary>
/// <remarks>
///    copy oriented and scaled glyph geometry to every input point
///
/// vtkGlyph3D is a filter that copies a geometric representation (called
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
/// @warning
/// You can set what arrays to use for the scalars, vectors, normals, and
/// color scalars by using the SetInputArrayToProcess methods in
/// vtkAlgorithm. The first array is scalars, the next vectors, the next
/// normals and finally color scalars.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorGlyph
/// </seealso>
public class vtkGlyph3D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGlyph3D()
	{
		MRClassNameKey = "class vtkGlyph3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGlyph3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with scaling on, scaling mode is by scalar value,
	/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
	/// orientation is by vector. Clamping and indexing are turned off. No
	/// initial sources are defined.
	/// </summary>
	public new static vtkGlyph3D New()
	{
		vtkGlyph3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with scaling on, scaling mode is by scalar value,
	/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
	/// orientation is by vector. Clamping and indexing are turned off. No
	/// initial sources are defined.
	/// </summary>
	public vtkGlyph3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGlyph3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGlyph3D_ClampingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual void ClampingOff()
	{
		vtkGlyph3D_ClampingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_ClampingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual void ClampingOn()
	{
		vtkGlyph3D_ClampingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_FillCellDataOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of cell data as part of the output.
	/// The cell data at each cell will match the point data of the input
	/// at the glyphed point.
	/// </summary>
	public virtual void FillCellDataOff()
	{
		vtkGlyph3D_FillCellDataOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_FillCellDataOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of cell data as part of the output.
	/// The cell data at each cell will match the point data of the input
	/// at the glyphed point.
	/// </summary>
	public virtual void FillCellDataOn()
	{
		vtkGlyph3D_FillCellDataOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_GeneratePointIdsOff_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual void GeneratePointIdsOff()
	{
		vtkGlyph3D_GeneratePointIdsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_GeneratePointIdsOn_06(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual void GeneratePointIdsOn()
	{
		vtkGlyph3D_GeneratePointIdsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetClamping_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual int GetClamping()
	{
		return vtkGlyph3D_GetClamping_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetColorMode_08(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkGlyph3D_GetColorMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetColorModeAsString_09(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public string GetColorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3D_GetColorModeAsString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetFillCellData_10(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of cell data as part of the output.
	/// The cell data at each cell will match the point data of the input
	/// at the glyphed point.
	/// </summary>
	public virtual int GetFillCellData()
	{
		return vtkGlyph3D_GetFillCellData_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetFollowedCameraPosition_11(HandleRef pThis);

	/// <summary>
	/// Set/Get point position glyphs will face towards. Used if vector mode is
	/// VTK_FOLLOW_CAMERA_DIRECTION.
	/// </summary>
	public virtual double[] GetFollowedCameraPosition()
	{
		IntPtr intPtr = vtkGlyph3D_GetFollowedCameraPosition_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_GetFollowedCameraPosition_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get point position glyphs will face towards. Used if vector mode is
	/// VTK_FOLLOW_CAMERA_DIRECTION.
	/// </summary>
	public virtual void GetFollowedCameraPosition(IntPtr data)
	{
		vtkGlyph3D_GetFollowedCameraPosition_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetFollowedCameraViewUp_13(HandleRef pThis);

	/// <summary>
	/// Set/Get glyphs up direction. Used if vector mode is VTK_FOLLOW_CAMERA_DIRECTION.
	/// </summary>
	public virtual double[] GetFollowedCameraViewUp()
	{
		IntPtr intPtr = vtkGlyph3D_GetFollowedCameraViewUp_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_GetFollowedCameraViewUp_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get glyphs up direction. Used if vector mode is VTK_FOLLOW_CAMERA_DIRECTION.
	/// </summary>
	public virtual void GetFollowedCameraViewUp(IntPtr data)
	{
		vtkGlyph3D_GetFollowedCameraViewUp_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetGeneratePointIds_15(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual int GetGeneratePointIds()
	{
		return vtkGlyph3D_GetGeneratePointIds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetIndexMode_16(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used. Note that indexing mode will only use the
	/// InputScalarsSelection array and not the InputColorScalarsSelection
	/// as the scalar source if an array is specified.
	/// </summary>
	public virtual int GetIndexMode()
	{
		return vtkGlyph3D_GetIndexMode_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetIndexModeAsString_17(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used. Note that indexing mode will only use the
	/// InputScalarsSelection array and not the InputColorScalarsSelection
	/// as the scalar source if an array is specified.
	/// </summary>
	public string GetIndexModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3D_GetIndexModeAsString_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGlyph3D_GetMTime_18(HandleRef pThis);

	/// <summary>
	/// Overridden to include SourceTransform's MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGlyph3D_GetMTime_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph3D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGlyph3D_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph3D_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGlyph3D_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetOrient_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual int GetOrient()
	{
		return vtkGlyph3D_GetOrient_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetOutputPointsPrecision_22(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkGlyph3D_GetOutputPointsPrecision_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetPointIdsName_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the PointIds array if generated. By default the Ids
	/// are named "InputPointIds", but this can be changed with this function.
	/// </summary>
	public virtual string GetPointIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3D_GetPointIdsName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetRange_24(HandleRef pThis);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkGlyph3D_GetRange_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_GetRange_25(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual void GetRange(IntPtr data)
	{
		vtkGlyph3D_GetRange_25(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyph3D_GetScaleFactor_26(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkGlyph3D_GetScaleFactor_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetScaleMode_27(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public virtual int GetScaleMode()
	{
		return vtkGlyph3D_GetScaleMode_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetScaleModeAsString_28(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public string GetScaleModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3D_GetScaleModeAsString_28(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetScaling_29(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual int GetScaling()
	{
		return vtkGlyph3D_GetScaling_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetSource_30(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to a source object at a specified table location.
	/// </summary>
	public vtkPolyData GetSource(int id)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3D_GetSource_30(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetSourceTransform_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When set, this is use to transform the source polydata before using it to
	/// generate the glyph. This is useful if one wanted to reorient the source,
	/// for example.
	/// </summary>
	public virtual vtkTransform GetSourceTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3D_GetSourceTransform_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_GetVectorMode_32(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public virtual int GetVectorMode()
	{
		return vtkGlyph3D_GetVectorMode_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_GetVectorModeAsString_33(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public string GetVectorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3D_GetVectorModeAsString_33(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_IsA_34(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGlyph3D_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_IsPointVisible_35(HandleRef pThis, HandleRef arg0, long arg1);

	/// <summary>
	/// This can be overwritten by subclass to return 0 when a point is
	/// blanked. Default implementation is to always return 1;
	/// </summary>
	public virtual int IsPointVisible(vtkDataSet arg0, long arg1)
	{
		return vtkGlyph3D_IsPointVisible_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3D_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGlyph3D_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGlyph3D NewInstance()
	{
		vtkGlyph3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3D_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_OrientOff_39(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual void OrientOff()
	{
		vtkGlyph3D_OrientOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_OrientOn_40(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual void OrientOn()
	{
		vtkGlyph3D_OrientOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3D_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGlyph3D SafeDownCast(vtkObjectBase o)
	{
		vtkGlyph3D vtkGlyph3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3D_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGlyph3D2 = (vtkGlyph3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGlyph3D2.Register(null);
			}
		}
		return vtkGlyph3D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_ScalingOff_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkGlyph3D_ScalingOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_ScalingOn_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkGlyph3D_ScalingOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetClamping_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off clamping of "scalar" values to range. (Scalar value may be
	/// vector magnitude if ScaleByVector() is enabled.)
	/// </summary>
	public virtual void SetClamping(int _arg)
	{
		vtkGlyph3D_SetClamping_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetColorMode_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkGlyph3D_SetColorMode_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetColorModeToColorByScalar_46(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public void SetColorModeToColorByScalar()
	{
		vtkGlyph3D_SetColorModeToColorByScalar_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetColorModeToColorByScale_47(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public void SetColorModeToColorByScale()
	{
		vtkGlyph3D_SetColorModeToColorByScale_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetColorModeToColorByVector_48(HandleRef pThis);

	/// <summary>
	/// Either color by scale, scalar or by vector/normal magnitude.
	/// </summary>
	public void SetColorModeToColorByVector()
	{
		vtkGlyph3D_SetColorModeToColorByVector_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetFillCellData_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the generation of cell data as part of the output.
	/// The cell data at each cell will match the point data of the input
	/// at the glyphed point.
	/// </summary>
	public virtual void SetFillCellData(int _arg)
	{
		vtkGlyph3D_SetFillCellData_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetFollowedCameraPosition_50(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get point position glyphs will face towards. Used if vector mode is
	/// VTK_FOLLOW_CAMERA_DIRECTION.
	/// </summary>
	public virtual void SetFollowedCameraPosition(IntPtr data)
	{
		vtkGlyph3D_SetFollowedCameraPosition_50(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetFollowedCameraViewUp_51(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get glyphs up direction. Used if vector mode is VTK_FOLLOW_CAMERA_DIRECTION.
	/// </summary>
	public virtual void SetFollowedCameraViewUp(IntPtr data)
	{
		vtkGlyph3D_SetFollowedCameraViewUp_51(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetGeneratePointIds_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the generation of point ids as part of the output. The
	/// point ids are the id of the input generating point. The point ids are
	/// stored in the output point field data and named "InputPointIds". Point
	/// generation is useful for debugging and pick operations.
	/// </summary>
	public virtual void SetGeneratePointIds(int _arg)
	{
		vtkGlyph3D_SetGeneratePointIds_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetIndexMode_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used. Note that indexing mode will only use the
	/// InputScalarsSelection array and not the InputColorScalarsSelection
	/// as the scalar source if an array is specified.
	/// </summary>
	public virtual void SetIndexMode(int _arg)
	{
		vtkGlyph3D_SetIndexMode_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetIndexModeToOff_54(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used. Note that indexing mode will only use the
	/// InputScalarsSelection array and not the InputColorScalarsSelection
	/// as the scalar source if an array is specified.
	/// </summary>
	public void SetIndexModeToOff()
	{
		vtkGlyph3D_SetIndexModeToOff_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetIndexModeToScalar_55(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used. Note that indexing mode will only use the
	/// InputScalarsSelection array and not the InputColorScalarsSelection
	/// as the scalar source if an array is specified.
	/// </summary>
	public void SetIndexModeToScalar()
	{
		vtkGlyph3D_SetIndexModeToScalar_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetIndexModeToVector_56(HandleRef pThis);

	/// <summary>
	/// Index into table of sources by scalar, by vector/normal magnitude, or
	/// no indexing. If indexing is turned off, then the first source glyph in
	/// the table of glyphs is used. Note that indexing mode will only use the
	/// InputScalarsSelection array and not the InputColorScalarsSelection
	/// as the scalar source if an array is specified.
	/// </summary>
	public void SetIndexModeToVector()
	{
		vtkGlyph3D_SetIndexModeToVector_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetOrient_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off orienting of input geometry along vector/normal.
	/// </summary>
	public virtual void SetOrient(int _arg)
	{
		vtkGlyph3D_SetOrient_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetOutputPointsPrecision_58(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkGlyph3D_SetOutputPointsPrecision_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetPointIdsName_59(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the PointIds array if generated. By default the Ids
	/// are named "InputPointIds", but this can be changed with this function.
	/// </summary>
	public virtual void SetPointIdsName(string _arg)
	{
		vtkGlyph3D_SetPointIdsName_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetRange_60(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual void SetRange(double _arg1, double _arg2)
	{
		vtkGlyph3D_SetRange_60(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetRange_61(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkGlyph3D_SetRange_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaleFactor_62(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify scale factor to scale object by.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkGlyph3D_SetScaleFactor_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaleMode_63(HandleRef pThis, int _arg);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public virtual void SetScaleMode(int _arg)
	{
		vtkGlyph3D_SetScaleMode_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaleModeToDataScalingOff_64(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToDataScalingOff()
	{
		vtkGlyph3D_SetScaleModeToDataScalingOff_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaleModeToScaleByScalar_65(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToScaleByScalar()
	{
		vtkGlyph3D_SetScaleModeToScaleByScalar_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaleModeToScaleByVector_66(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToScaleByVector()
	{
		vtkGlyph3D_SetScaleModeToScaleByVector_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaleModeToScaleByVectorComponents_67(HandleRef pThis);

	/// <summary>
	/// Either scale by scalar or by vector/normal magnitude.
	/// </summary>
	public void SetScaleModeToScaleByVectorComponents()
	{
		vtkGlyph3D_SetScaleModeToScaleByVectorComponents_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetScaling_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off scaling of source geometry.
	/// </summary>
	public virtual void SetScaling(int _arg)
	{
		vtkGlyph3D_SetScaling_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetSourceConnection_69(HandleRef pThis, int id, HandleRef algOutput);

	/// <summary>
	/// Specify a source object at a specified table location. New style.
	/// Source connection is stored in port 1. This method is equivalent
	/// to SetInputConnection(1, id, outputPort).
	/// </summary>
	public void SetSourceConnection(int id, vtkAlgorithmOutput algOutput)
	{
		vtkGlyph3D_SetSourceConnection_69(GetCppThis(), id, algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetSourceConnection_70(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify a source object at a specified table location. New style.
	/// Source connection is stored in port 1. This method is equivalent
	/// to SetInputConnection(1, id, outputPort).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkGlyph3D_SetSourceConnection_70(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetSourceData_71(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Set the source to use for the glyph.
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public void SetSourceData(vtkPolyData pd)
	{
		vtkGlyph3D_SetSourceData_71(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetSourceData_72(HandleRef pThis, int id, HandleRef pd);

	/// <summary>
	/// Specify a source object at a specified table location.
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public void SetSourceData(int id, vtkPolyData pd)
	{
		vtkGlyph3D_SetSourceData_72(GetCppThis(), id, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetSourceTransform_73(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// When set, this is use to transform the source polydata before using it to
	/// generate the glyph. This is useful if one wanted to reorient the source,
	/// for example.
	/// </summary>
	public void SetSourceTransform(vtkTransform arg0)
	{
		vtkGlyph3D_SetSourceTransform_73(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetVectorMode_74(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public virtual void SetVectorMode(int _arg)
	{
		vtkGlyph3D_SetVectorMode_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetVectorModeToFollowCameraDirection_75(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToFollowCameraDirection()
	{
		vtkGlyph3D_SetVectorModeToFollowCameraDirection_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetVectorModeToUseNormal_76(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToUseNormal()
	{
		vtkGlyph3D_SetVectorModeToUseNormal_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetVectorModeToUseVector_77(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToUseVector()
	{
		vtkGlyph3D_SetVectorModeToUseVector_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3D_SetVectorModeToVectorRotationOff_78(HandleRef pThis);

	/// <summary>
	/// Specify whether to use vector or normal to perform vector operations.
	/// </summary>
	public void SetVectorModeToVectorRotationOff()
	{
		vtkGlyph3D_SetVectorModeToVectorRotationOff_78(GetCppThis());
	}
}
