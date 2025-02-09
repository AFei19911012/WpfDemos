using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLassoStencilSource
/// </summary>
/// <remarks>
///    Create a stencil from a contour
///
/// vtkLassoStencilSource will create an image stencil from a
/// set of points that define a contour.  Its output can be
/// used with vtkImageStecil or other vtk classes that apply
/// a stencil to an image.
/// </remarks>
/// <seealso>
///
/// vtkROIStencilSource vtkPolyDataToImageStencil
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </seealso>
public class vtkLassoStencilSource : vtkImageStencilSource
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum POLYGON_WrapperEnum
	{
		/// <summary>enum member</summary>
		POLYGON,
		/// <summary>enum member</summary>
		SPLINE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLassoStencilSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLassoStencilSource()
	{
		MRClassNameKey = "class vtkLassoStencilSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLassoStencilSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLassoStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLassoStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLassoStencilSource New()
	{
		vtkLassoStencilSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLassoStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLassoStencilSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLassoStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLassoStencilSource_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// Overload GetMTime() to include the timestamp on the points.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkLassoStencilSource_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLassoStencilSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLassoStencilSource_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLassoStencilSource_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLassoStencilSource_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLassoStencilSource_GetPoints_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The points that make up the lassoo.  The loop does not
	/// have to be closed, the last point will automatically be
	/// connected to the first point by a straight line segment.
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLassoStencilSource_GetPoints_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_GetShape_05(HandleRef pThis);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public virtual int GetShape()
	{
		return vtkLassoStencilSource_GetShape_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLassoStencilSource_GetShapeAsString_06(HandleRef pThis);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public virtual string GetShapeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkLassoStencilSource_GetShapeAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_GetShapeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public virtual int GetShapeMaxValue()
	{
		return vtkLassoStencilSource_GetShapeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_GetShapeMinValue_08(HandleRef pThis);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public virtual int GetShapeMinValue()
	{
		return vtkLassoStencilSource_GetShapeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_GetSliceOrientation_09(HandleRef pThis);

	/// <summary>
	/// The slice orientation.  The default is 2, which is XY.
	/// Other values are 0, which is YZ, and 1, which is XZ.
	/// </summary>
	public virtual int GetSliceOrientation()
	{
		return vtkLassoStencilSource_GetSliceOrientation_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_GetSliceOrientationMaxValue_10(HandleRef pThis);

	/// <summary>
	/// The slice orientation.  The default is 2, which is XY.
	/// Other values are 0, which is YZ, and 1, which is XZ.
	/// </summary>
	public virtual int GetSliceOrientationMaxValue()
	{
		return vtkLassoStencilSource_GetSliceOrientationMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_GetSliceOrientationMinValue_11(HandleRef pThis);

	/// <summary>
	/// The slice orientation.  The default is 2, which is XY.
	/// Other values are 0, which is YZ, and 1, which is XZ.
	/// </summary>
	public virtual int GetSliceOrientationMinValue()
	{
		return vtkLassoStencilSource_GetSliceOrientationMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLassoStencilSource_GetSlicePoints_12(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The points for a particular slice.  This will override the
	/// points that were set by calling SetPoints() for the slice.
	/// To clear the setting, call SetSlicePoints(slice, nullptr).
	/// </summary>
	public virtual vtkPoints GetSlicePoints(int i)
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLassoStencilSource_GetSlicePoints_12(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLassoStencilSource_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLassoStencilSource_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLassoStencilSource_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLassoStencilSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLassoStencilSource NewInstance()
	{
		vtkLassoStencilSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLassoStencilSource_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_RemoveAllSlicePoints_17(HandleRef pThis);

	/// <summary>
	/// Remove points from all slices.
	/// </summary>
	public virtual void RemoveAllSlicePoints()
	{
		vtkLassoStencilSource_RemoveAllSlicePoints_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLassoStencilSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLassoStencilSource SafeDownCast(vtkObjectBase o)
	{
		vtkLassoStencilSource vtkLassoStencilSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLassoStencilSource_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLassoStencilSource2 = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLassoStencilSource2.Register(null);
			}
		}
		return vtkLassoStencilSource2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_SetPoints_19(HandleRef pThis, HandleRef points);

	/// <summary>
	/// The points that make up the lassoo.  The loop does not
	/// have to be closed, the last point will automatically be
	/// connected to the first point by a straight line segment.
	/// </summary>
	public virtual void SetPoints(vtkPoints points)
	{
		vtkLassoStencilSource_SetPoints_19(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_SetShape_20(HandleRef pThis, int _arg);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public virtual void SetShape(int _arg)
	{
		vtkLassoStencilSource_SetShape_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_SetShapeToPolygon_21(HandleRef pThis);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public void SetShapeToPolygon()
	{
		vtkLassoStencilSource_SetShapeToPolygon_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_SetShapeToSpline_22(HandleRef pThis);

	/// <summary>
	/// The shape to use, default is "Polygon".  The spline is a
	/// cardinal spline.  Bezier splines are not yet supported.
	/// </summary>
	public void SetShapeToSpline()
	{
		vtkLassoStencilSource_SetShapeToSpline_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_SetSliceOrientation_23(HandleRef pThis, int _arg);

	/// <summary>
	/// The slice orientation.  The default is 2, which is XY.
	/// Other values are 0, which is YZ, and 1, which is XZ.
	/// </summary>
	public virtual void SetSliceOrientation(int _arg)
	{
		vtkLassoStencilSource_SetSliceOrientation_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLassoStencilSource_SetSlicePoints_24(HandleRef pThis, int i, HandleRef points);

	/// <summary>
	/// The points for a particular slice.  This will override the
	/// points that were set by calling SetPoints() for the slice.
	/// To clear the setting, call SetSlicePoints(slice, nullptr).
	/// </summary>
	public virtual void SetSlicePoints(int i, vtkPoints points)
	{
		vtkLassoStencilSource_SetSlicePoints_24(GetCppThis(), i, points?.GetCppThis() ?? default(HandleRef));
	}
}
