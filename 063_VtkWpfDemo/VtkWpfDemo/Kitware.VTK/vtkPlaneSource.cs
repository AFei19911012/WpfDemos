using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlaneSource
/// </summary>
/// <remarks>
///    create an array of quadrilaterals located in a plane
///
/// vtkPlaneSource creates an m x n array of quadrilaterals arranged as
/// a regular tiling in a plane. The plane is defined by specifying an
/// origin point, and then two other points that, together with the
/// origin, define two axes for the plane. These axes do not have to be
/// orthogonal - so you can create a parallelogram. (The axes must not
/// be parallel.) The resolution of the plane (i.e., number of subdivisions) is
/// controlled by the ivars XResolution and YResolution.
///
/// By default, the plane is centered at the origin and perpendicular to the
/// z-axis, with width and height of length 1 and resolutions set to 1.
///
/// There are three convenience methods that allow you to easily move the
/// plane.  The first, SetNormal(), allows you to specify the plane
/// normal. The effect of this method is to rotate the plane around the center
/// of the plane, aligning the plane normal with the specified normal. The
/// rotation is about the axis defined by the cross product of the current
/// normal with the new normal. The second, SetCenter(), translates the center
/// of the plane to the specified center point. The third method, Push(),
/// allows you to translate the plane along the plane normal by the distance
/// specified. (Negative Push values translate the plane in the negative
/// normal direction.)  Note that the SetNormal(), SetCenter() and Push()
/// methods modify the Origin, Point1, and/or Point2 instance variables.
///
/// @warning
/// The normal to the plane will point in the direction of the cross product
/// of the first axis (Origin-&gt;Point1) with the second (Origin-&gt;Point2). This
/// also affects the normals to the generated polygons.
/// </remarks>
public class vtkPlaneSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlaneSource()
	{
		MRClassNameKey = "class vtkPlaneSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlaneSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct plane perpendicular to z-axis, resolution 1x1, width
	/// and height 1.0, and centered at the origin.
	/// </summary>
	public new static vtkPlaneSource New()
	{
		vtkPlaneSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct plane perpendicular to z-axis, resolution 1x1, width
	/// and height 1.0, and centered at the origin.
	/// </summary>
	public vtkPlaneSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlaneSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlaneSource_GetAxis1_01(HandleRef pThis, IntPtr a1);

	/// <summary>
	/// Convenience methods to retrieve the axes of the plane; that is
	/// axis a1 is the vector (Point1-Origin), and axis a2 is the vector
	/// (Point2-Origin).
	/// </summary>
	public void GetAxis1(IntPtr a1)
	{
		vtkPlaneSource_GetAxis1_01(GetCppThis(), a1);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetAxis2_02(HandleRef pThis, IntPtr a2);

	/// <summary>
	/// Convenience methods to retrieve the axes of the plane; that is
	/// axis a1 is the vector (Point1-Origin), and axis a2 is the vector
	/// (Point2-Origin).
	/// </summary>
	public void GetAxis2(IntPtr a2)
	{
		vtkPlaneSource_GetAxis2_02(GetCppThis(), a2);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of the plane. Works in conjunction with the plane
	/// normal to position the plane. Don't use this method to define the plane.
	/// Instead, use it to move the plane to a new center point.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkPlaneSource_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetCenter_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the center of the plane. Works in conjunction with the plane
	/// normal to position the plane. Don't use this method to define the plane.
	/// Instead, use it to move the plane to a new center point.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkPlaneSource_GetCenter_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_GetNormal_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the plane normal. Works in conjunction with the plane center to
	/// orient the plane. Don't use this method to define the plane. Instead, use
	/// it to rotate the plane around the current center point.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkPlaneSource_GetNormal_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetNormal_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the plane normal. Works in conjunction with the plane center to
	/// orient the plane. Don't use this method to define the plane. Instead, use
	/// it to rotate the plane around the current center point.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkPlaneSource_GetNormal_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaneSource_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlaneSource_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaneSource_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlaneSource_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_GetOrigin_09(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the origin of the plane.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkPlaneSource_GetOrigin_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetOrigin_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the origin of the plane.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkPlaneSource_GetOrigin_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneSource_GetOutputPointsPrecision_11(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPlaneSource_GetOutputPointsPrecision_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_GetPoint1_12(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public virtual double[] GetPoint1()
	{
		IntPtr intPtr = vtkPlaneSource_GetPoint1_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetPoint1_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public virtual void GetPoint1(IntPtr data)
	{
		vtkPlaneSource_GetPoint1_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_GetPoint2_14(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public virtual double[] GetPoint2()
	{
		IntPtr intPtr = vtkPlaneSource_GetPoint2_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetPoint2_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public virtual void GetPoint2(IntPtr data)
	{
		vtkPlaneSource_GetPoint2_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_GetResolution_16(HandleRef pThis, ref int xR, ref int yR);

	/// <summary>
	/// Set the number of x-y subdivisions in the plane.
	/// </summary>
	public void GetResolution(ref int xR, ref int yR)
	{
		vtkPlaneSource_GetResolution_16(GetCppThis(), ref xR, ref yR);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneSource_GetXResolution_17(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the plane along the first axes.
	/// </summary>
	public virtual int GetXResolution()
	{
		return vtkPlaneSource_GetXResolution_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneSource_GetYResolution_18(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the plane along the second axes.
	/// </summary>
	public virtual int GetYResolution()
	{
		return vtkPlaneSource_GetYResolution_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneSource_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlaneSource_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneSource_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlaneSource_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlaneSource NewInstance()
	{
		vtkPlaneSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneSource_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_Push_23(HandleRef pThis, double distance);

	/// <summary>
	/// Translate the plane in the direction of the normal by the
	/// distance specified.  Negative values move the plane in the
	/// opposite direction.
	/// </summary>
	public void Push(double distance)
	{
		vtkPlaneSource_Push_23(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_Rotate_24(HandleRef pThis, double angle, IntPtr rotationAxis);

	/// <summary>
	/// Rotate plane at center around a given axis
	/// If the absolute value of the angle is inferior to the defined EPSILON, then don't
	/// rotate
	/// </summary>
	public void Rotate(double angle, IntPtr rotationAxis)
	{
		vtkPlaneSource_Rotate_24(GetCppThis(), angle, rotationAxis);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneSource_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlaneSource SafeDownCast(vtkObjectBase o)
	{
		vtkPlaneSource vtkPlaneSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneSource_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneSource2 = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneSource2.Register(null);
			}
		}
		return vtkPlaneSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetCenter_26(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the center of the plane. Works in conjunction with the plane
	/// normal to position the plane. Don't use this method to define the plane.
	/// Instead, use it to move the plane to a new center point.
	/// </summary>
	public void SetCenter(double x, double y, double z)
	{
		vtkPlaneSource_SetCenter_26(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetCenter_27(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Set/Get the center of the plane. Works in conjunction with the plane
	/// normal to position the plane. Don't use this method to define the plane.
	/// Instead, use it to move the plane to a new center point.
	/// </summary>
	public void SetCenter(IntPtr center)
	{
		vtkPlaneSource_SetCenter_27(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetNormal_28(HandleRef pThis, double nx, double ny, double nz);

	/// <summary>
	/// Set/Get the plane normal. Works in conjunction with the plane center to
	/// orient the plane. Don't use this method to define the plane. Instead, use
	/// it to rotate the plane around the current center point.
	/// </summary>
	public void SetNormal(double nx, double ny, double nz)
	{
		vtkPlaneSource_SetNormal_28(GetCppThis(), nx, ny, nz);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetNormal_29(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Set/Get the plane normal. Works in conjunction with the plane center to
	/// orient the plane. Don't use this method to define the plane. Instead, use
	/// it to rotate the plane around the current center point.
	/// </summary>
	public void SetNormal(IntPtr n)
	{
		vtkPlaneSource_SetNormal_29(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetOrigin_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point defining the origin of the plane.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkPlaneSource_SetOrigin_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetOrigin_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point defining the origin of the plane.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkPlaneSource_SetOrigin_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetOutputPointsPrecision_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPlaneSource_SetOutputPointsPrecision_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetPoint1_33(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public void SetPoint1(double x, double y, double z)
	{
		vtkPlaneSource_SetPoint1_33(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetPoint1_34(HandleRef pThis, IntPtr pnt);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public void SetPoint1(IntPtr pnt)
	{
		vtkPlaneSource_SetPoint1_34(GetCppThis(), pnt);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetPoint2_35(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public void SetPoint2(double x, double y, double z)
	{
		vtkPlaneSource_SetPoint2_35(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetPoint2_36(HandleRef pThis, IntPtr pnt);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public void SetPoint2(IntPtr pnt)
	{
		vtkPlaneSource_SetPoint2_36(GetCppThis(), pnt);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetResolution_37(HandleRef pThis, int xR, int yR);

	/// <summary>
	/// Set the number of x-y subdivisions in the plane.
	/// </summary>
	public void SetResolution(int xR, int yR)
	{
		vtkPlaneSource_SetResolution_37(GetCppThis(), xR, yR);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetXResolution_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the resolution of the plane along the first axes.
	/// </summary>
	public virtual void SetXResolution(int _arg)
	{
		vtkPlaneSource_SetXResolution_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneSource_SetYResolution_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the resolution of the plane along the second axes.
	/// </summary>
	public virtual void SetYResolution(int _arg)
	{
		vtkPlaneSource_SetYResolution_39(GetCppThis(), _arg);
	}
}
