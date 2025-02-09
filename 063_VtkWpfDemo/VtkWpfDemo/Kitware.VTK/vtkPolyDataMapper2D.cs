using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataMapper2D
/// </summary>
/// <remarks>
///    draw vtkPolyData onto the image plane
///
/// vtkPolyDataMapper2D is a mapper that renders 3D polygonal data
/// (vtkPolyData) onto the 2D image plane (i.e., the renderer's viewport).
/// By default, the 3D data is transformed into 2D data by ignoring the
/// z-coordinate of the 3D points in vtkPolyData, and taking the x-y values
/// as local display values (i.e., pixel coordinates). Alternatively, you
/// can provide a vtkCoordinate object that will transform the data into
/// local display coordinates (use the vtkCoordinate::SetCoordinateSystem()
/// methods to indicate which coordinate system you are transforming the
/// data from).
///
/// </remarks>
/// <seealso>
///
/// vtkMapper2D vtkActor2D
/// </seealso>
public class vtkPolyDataMapper2D : vtkMapper2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapper2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataMapper2D()
	{
		MRClassNameKey = "class vtkPolyDataMapper2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapper2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataMapper2D New()
	{
		vtkPolyDataMapper2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolyDataMapper2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_ColorByArrayComponent_01(HandleRef pThis, int arrayNum, int component);

	/// <summary>
	/// Choose which component of which field data array to color by.
	/// </summary>
	public void ColorByArrayComponent(int arrayNum, int component)
	{
		vtkPolyDataMapper2D_ColorByArrayComponent_01(GetCppThis(), arrayNum, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_ColorByArrayComponent_02(HandleRef pThis, string arrayName, int component);

	/// <summary>
	/// Choose which component of which field data array to color by.
	/// </summary>
	public void ColorByArrayComponent(string arrayName, int component)
	{
		vtkPolyDataMapper2D_ColorByArrayComponent_02(GetCppThis(), arrayName, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_CreateDefaultLookupTable_03(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available with the scalar data.
	/// </summary>
	public virtual void CreateDefaultLookupTable()
	{
		vtkPolyDataMapper2D_CreateDefaultLookupTable_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetArrayAccessMode_04(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to color by.
	/// </summary>
	public int GetArrayAccessMode()
	{
		return vtkPolyDataMapper2D_GetArrayAccessMode_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetArrayComponent_05(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to color by.
	/// </summary>
	public int GetArrayComponent()
	{
		return vtkPolyDataMapper2D_GetArrayComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetArrayId_06(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to color by.
	/// </summary>
	public int GetArrayId()
	{
		return vtkPolyDataMapper2D_GetArrayId_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_GetArrayName_07(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to color by.
	/// </summary>
	public string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPolyDataMapper2D_GetArrayName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetColorMode_08(HandleRef pThis);

	/// <summary>
	/// Control how the scalar data is mapped to colors.  By default
	/// (ColorModeToDefault), unsigned char scalars are treated as
	/// colors, and NOT mapped through the lookup table, while everything
	/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
	/// that all integer types are treated as colors with values in the
	/// range 0-255 and floating types are treated as colors with values
	/// in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped through
	/// the lookup table.  (Note that for multi-component scalars, the
	/// particular component to use for mapping can be specified using the
	/// ColorByArrayComponent() method.)
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkPolyDataMapper2D_GetColorMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_GetColorModeAsString_09(HandleRef pThis);

	/// <summary>
	/// Return the method of coloring scalar data.
	/// </summary>
	public string GetColorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkPolyDataMapper2D_GetColorModeAsString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the input to the mapper.
	/// </summary>
	public vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_GetInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_GetLookupTable_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_GetLookupTable_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPolyDataMapper2D_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Overload standard modified time function. If lookup table is modified,
	/// then this object is modified as well.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPolyDataMapper2D_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataMapper2D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataMapper2D_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataMapper2D_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataMapper2D_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetScalarMode_15(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkPolyDataMapper2D_GetScalarMode_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_GetScalarRange_16(HandleRef pThis);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkPolyDataMapper2D_GetScalarRange_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_GetScalarRange_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public virtual void GetScalarRange(IntPtr data)
	{
		vtkPolyDataMapper2D_GetScalarRange_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetScalarVisibility_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual int GetScalarVisibility()
	{
		return vtkPolyDataMapper2D_GetScalarVisibility_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_GetTransformCoordinate_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a vtkCoordinate object to be used to transform the vtkPolyData
	/// point coordinates. By default (no vtkCoordinate specified), the point
	/// coordinates are taken as viewport coordinates (pixels in the viewport
	/// into which the mapper is rendering).
	/// </summary>
	public virtual vtkCoordinate GetTransformCoordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_GetTransformCoordinate_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataMapper2D_GetTransformCoordinateUseDouble_20(HandleRef pThis);

	/// <summary>
	/// Specify whether or not rounding to integers the transformed points when
	/// TransformCoordinate is set. By default, it does not use double precision.
	/// </summary>
	public virtual bool GetTransformCoordinateUseDouble()
	{
		return (vtkPolyDataMapper2D_GetTransformCoordinateUseDouble_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_GetUseLookupTableScalarRange_21(HandleRef pThis);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual int GetUseLookupTableScalarRange()
	{
		return vtkPolyDataMapper2D_GetUseLookupTableScalarRange_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataMapper2D_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper2D_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataMapper2D_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_MapScalars_24(HandleRef pThis, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Map the scalars (if there are any scalars and ScalarVisibility is on)
	/// through the lookup table, returning an unsigned char RGBA array. This is
	/// typically done as part of the rendering process. The alpha parameter
	/// allows the blending of the scalars with an additional alpha (typically
	/// which comes from a vtkActor, etc.)
	/// </summary>
	public vtkUnsignedCharArray MapScalars(double alpha)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_MapScalars_24(GetCppThis(), alpha, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataMapper2D NewInstance()
	{
		vtkPolyDataMapper2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper2D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataMapper2D SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataMapper2D vtkPolyDataMapper2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper2D_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataMapper2D2 = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataMapper2D2.Register(null);
			}
		}
		return vtkPolyDataMapper2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_ScalarVisibilityOff_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkPolyDataMapper2D_ScalarVisibilityOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_ScalarVisibilityOn_29(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkPolyDataMapper2D_ScalarVisibilityOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetColorMode_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the scalar data is mapped to colors.  By default
	/// (ColorModeToDefault), unsigned char scalars are treated as
	/// colors, and NOT mapped through the lookup table, while everything
	/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
	/// that all integer types are treated as colors with values in the
	/// range 0-255 and floating types are treated as colors with values
	/// in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped through
	/// the lookup table.  (Note that for multi-component scalars, the
	/// particular component to use for mapping can be specified using the
	/// ColorByArrayComponent() method.)
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkPolyDataMapper2D_SetColorMode_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetColorModeToDefault_31(HandleRef pThis);

	/// <summary>
	/// Control how the scalar data is mapped to colors.  By default
	/// (ColorModeToDefault), unsigned char scalars are treated as
	/// colors, and NOT mapped through the lookup table, while everything
	/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
	/// that all integer types are treated as colors with values in the
	/// range 0-255 and floating types are treated as colors with values
	/// in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped through
	/// the lookup table.  (Note that for multi-component scalars, the
	/// particular component to use for mapping can be specified using the
	/// ColorByArrayComponent() method.)
	/// </summary>
	public void SetColorModeToDefault()
	{
		vtkPolyDataMapper2D_SetColorModeToDefault_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetColorModeToDirectScalars_32(HandleRef pThis);

	/// <summary>
	/// Control how the scalar data is mapped to colors.  By default
	/// (ColorModeToDefault), unsigned char scalars are treated as
	/// colors, and NOT mapped through the lookup table, while everything
	/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
	/// that all integer types are treated as colors with values in the
	/// range 0-255 and floating types are treated as colors with values
	/// in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped through
	/// the lookup table.  (Note that for multi-component scalars, the
	/// particular component to use for mapping can be specified using the
	/// ColorByArrayComponent() method.)
	/// </summary>
	public void SetColorModeToDirectScalars()
	{
		vtkPolyDataMapper2D_SetColorModeToDirectScalars_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetColorModeToMapScalars_33(HandleRef pThis);

	/// <summary>
	/// Control how the scalar data is mapped to colors.  By default
	/// (ColorModeToDefault), unsigned char scalars are treated as
	/// colors, and NOT mapped through the lookup table, while everything
	/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
	/// that all integer types are treated as colors with values in the
	/// range 0-255 and floating types are treated as colors with values
	/// in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped through
	/// the lookup table.  (Note that for multi-component scalars, the
	/// particular component to use for mapping can be specified using the
	/// ColorByArrayComponent() method.)
	/// </summary>
	public void SetColorModeToMapScalars()
	{
		vtkPolyDataMapper2D_SetColorModeToMapScalars_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetInputData_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to the mapper.
	/// </summary>
	public void SetInputData(vtkPolyData arg0)
	{
		vtkPolyDataMapper2D_SetInputData_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetLookupTable_35(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkPolyDataMapper2D_SetLookupTable_35(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarMode_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkPolyDataMapper2D_SetScalarMode_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarModeToDefault_37(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToDefault()
	{
		vtkPolyDataMapper2D_SetScalarModeToDefault_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarModeToUseCellData_38(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUseCellData()
	{
		vtkPolyDataMapper2D_SetScalarModeToUseCellData_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarModeToUseCellFieldData_39(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUseCellFieldData()
	{
		vtkPolyDataMapper2D_SetScalarModeToUseCellFieldData_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarModeToUsePointData_40(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUsePointData()
	{
		vtkPolyDataMapper2D_SetScalarModeToUsePointData_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarModeToUsePointFieldData_41(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call ColorByArrayComponent before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUsePointFieldData()
	{
		vtkPolyDataMapper2D_SetScalarModeToUsePointFieldData_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarRange_42(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkPolyDataMapper2D_SetScalarRange_42(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarRange_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkPolyDataMapper2D_SetScalarRange_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetScalarVisibility_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void SetScalarVisibility(int _arg)
	{
		vtkPolyDataMapper2D_SetScalarVisibility_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetTransformCoordinate_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a vtkCoordinate object to be used to transform the vtkPolyData
	/// point coordinates. By default (no vtkCoordinate specified), the point
	/// coordinates are taken as viewport coordinates (pixels in the viewport
	/// into which the mapper is rendering).
	/// </summary>
	public virtual void SetTransformCoordinate(vtkCoordinate arg0)
	{
		vtkPolyDataMapper2D_SetTransformCoordinate_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetTransformCoordinateUseDouble_46(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether or not rounding to integers the transformed points when
	/// TransformCoordinate is set. By default, it does not use double precision.
	/// </summary>
	public virtual void SetTransformCoordinateUseDouble(bool _arg)
	{
		vtkPolyDataMapper2D_SetTransformCoordinateUseDouble_46(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_SetUseLookupTableScalarRange_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual void SetUseLookupTableScalarRange(int _arg)
	{
		vtkPolyDataMapper2D_SetUseLookupTableScalarRange_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_ShallowCopy_48(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Make a shallow copy of this mapper.
	/// </summary>
	public override void ShallowCopy(vtkAbstractMapper m)
	{
		vtkPolyDataMapper2D_ShallowCopy_48(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_TransformCoordinateUseDoubleOff_49(HandleRef pThis);

	/// <summary>
	/// Specify whether or not rounding to integers the transformed points when
	/// TransformCoordinate is set. By default, it does not use double precision.
	/// </summary>
	public virtual void TransformCoordinateUseDoubleOff()
	{
		vtkPolyDataMapper2D_TransformCoordinateUseDoubleOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_TransformCoordinateUseDoubleOn_50(HandleRef pThis);

	/// <summary>
	/// Specify whether or not rounding to integers the transformed points when
	/// TransformCoordinate is set. By default, it does not use double precision.
	/// </summary>
	public virtual void TransformCoordinateUseDoubleOn()
	{
		vtkPolyDataMapper2D_TransformCoordinateUseDoubleOn_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_UseLookupTableScalarRangeOff_51(HandleRef pThis);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual void UseLookupTableScalarRangeOff()
	{
		vtkPolyDataMapper2D_UseLookupTableScalarRangeOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper2D_UseLookupTableScalarRangeOn_52(HandleRef pThis);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual void UseLookupTableScalarRangeOn()
	{
		vtkPolyDataMapper2D_UseLookupTableScalarRangeOn_52(GetCppThis());
	}
}
