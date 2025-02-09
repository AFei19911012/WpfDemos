using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursor
/// </summary>
/// <remarks>
///    Geometry for a reslice cursor
///
/// This class represents a reslice cursor. It consists of two cross
/// sectional hairs, with an optional thickness. The crosshairs
/// hairs may have a hole in the center. These may be translated or rotated
/// independent of each other in the view. The result is used to reslice
/// the data along these cross sections. This allows the user to perform
/// multi-planar thin or thick reformat of the data on an image view, rather
/// than a 3D view.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursorWidget vtkResliceCursor vtkResliceCursorPolyDataAlgorithm
/// vtkResliceCursorRepresentation vtkResliceCursorThickLineRepresentation
/// vtkResliceCursorActor vtkImagePlaneWidget
/// </seealso>
public class vtkResliceCursor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursor()
	{
		MRClassNameKey = "class vtkResliceCursor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResliceCursor New()
	{
		vtkResliceCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResliceCursor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceCursor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetAxis_01(HandleRef pThis, int i);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual IntPtr GetAxis(int i)
	{
		return vtkResliceCursor_GetAxis_01(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetCenter_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the cente of the reslice cursor.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkResliceCursor_GetCenter_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetCenter_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the cente of the reslice cursor.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetCenter_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetCenter_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cente of the reslice cursor.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkResliceCursor_GetCenter_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetCenterlineAxisPolyData_05(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the slab and centerline polydata along an axis
	/// </summary>
	public virtual vtkPolyData GetCenterlineAxisPolyData(int axis)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_GetCenterlineAxisPolyData_05(GetCppThis(), axis, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursor_GetHole_06(HandleRef pThis);

	/// <summary>
	/// Show a hole in the center of the cursor, so its easy to see the pixels
	/// within the hole. ON by default
	/// </summary>
	public virtual int GetHole()
	{
		return vtkResliceCursor_GetHole_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResliceCursor_GetHoleWidth_07(HandleRef pThis);

	/// <summary>
	/// Set the width of the hole in mm
	/// </summary>
	public virtual double GetHoleWidth()
	{
		return vtkResliceCursor_GetHoleWidth_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResliceCursor_GetHoleWidthInPixels_08(HandleRef pThis);

	/// <summary>
	/// Set the width of the hole in pixels. If set, this will override the
	/// hole with in mm.
	/// </summary>
	public virtual double GetHoleWidthInPixels()
	{
		return vtkResliceCursor_GetHoleWidthInPixels_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetImage_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the image (3D) that we are slicing
	/// </summary>
	public virtual vtkImageData GetImage()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_GetImage_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkResliceCursor_GetMTime_10(HandleRef pThis);

	/// <summary>
	/// Get the MTime. Check the MTime of the internal planes as well.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkResliceCursor_GetMTime_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursor_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursor_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursor_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursor_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetPlane_13(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the planes that represent normals along the X, Y and Z. The argument
	/// passed to this method must be an integer in the range 0-2 (corresponding
	/// to the X, Y and Z axes.
	/// </summary>
	public virtual vtkPlane GetPlane(int n)
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_GetPlane_13(GetCppThis(), n, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetPolyData_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the 3D PolyData representation
	/// </summary>
	public virtual vtkPolyData GetPolyData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_GetPolyData_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursor_GetThickMode_15(HandleRef pThis);

	/// <summary>
	/// Enable disable thick mode. Default is to enable it.
	/// </summary>
	public virtual int GetThickMode()
	{
		return vtkResliceCursor_GetThickMode_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetThickness_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the thickness of the cursor
	/// </summary>
	public virtual double[] GetThickness()
	{
		IntPtr intPtr = vtkResliceCursor_GetThickness_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetThickness_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the thickness of the cursor
	/// </summary>
	public virtual void GetThickness(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetThickness_17(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetThickness_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the thickness of the cursor
	/// </summary>
	public virtual void GetThickness(IntPtr _arg)
	{
		vtkResliceCursor_GetThickness_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetViewUp_19(HandleRef pThis, int i);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public IntPtr GetViewUp(int i)
	{
		return vtkResliceCursor_GetViewUp_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetXAxis_20(HandleRef pThis);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual double[] GetXAxis()
	{
		IntPtr intPtr = vtkResliceCursor_GetXAxis_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetXAxis_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void GetXAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetXAxis_21(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetXAxis_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void GetXAxis(IntPtr _arg)
	{
		vtkResliceCursor_GetXAxis_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetXViewUp_23(HandleRef pThis);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual double[] GetXViewUp()
	{
		IntPtr intPtr = vtkResliceCursor_GetXViewUp_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetXViewUp_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void GetXViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetXViewUp_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetXViewUp_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void GetXViewUp(IntPtr _arg)
	{
		vtkResliceCursor_GetXViewUp_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetYAxis_26(HandleRef pThis);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual double[] GetYAxis()
	{
		IntPtr intPtr = vtkResliceCursor_GetYAxis_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetYAxis_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void GetYAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetYAxis_27(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetYAxis_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void GetYAxis(IntPtr _arg)
	{
		vtkResliceCursor_GetYAxis_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetYViewUp_29(HandleRef pThis);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual double[] GetYViewUp()
	{
		IntPtr intPtr = vtkResliceCursor_GetYViewUp_29(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetYViewUp_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void GetYViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetYViewUp_30(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetYViewUp_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void GetYViewUp(IntPtr _arg)
	{
		vtkResliceCursor_GetYViewUp_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetZAxis_32(HandleRef pThis);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual double[] GetZAxis()
	{
		IntPtr intPtr = vtkResliceCursor_GetZAxis_32(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetZAxis_33(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void GetZAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetZAxis_33(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetZAxis_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void GetZAxis(IntPtr _arg)
	{
		vtkResliceCursor_GetZAxis_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_GetZViewUp_35(HandleRef pThis);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual double[] GetZViewUp()
	{
		IntPtr intPtr = vtkResliceCursor_GetZViewUp_35(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetZViewUp_36(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void GetZViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkResliceCursor_GetZViewUp_36(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_GetZViewUp_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void GetZViewUp(IntPtr _arg)
	{
		vtkResliceCursor_GetZViewUp_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursor_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursor_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursor_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursor_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResliceCursor NewInstance()
	{
		vtkResliceCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_Reset_42(HandleRef pThis);

	/// <summary>
	/// Reset the cursor to the default position, ie with the axes, normal
	/// to each other and axis aligned and with the cursor pointed at the
	/// center of the image.
	/// </summary>
	public virtual void Reset()
	{
		vtkResliceCursor_Reset_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursor_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResliceCursor SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursor vtkResliceCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursor_SafeDownCast_43(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursor2 = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursor2.Register(null);
			}
		}
		return vtkResliceCursor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetCenter_44(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/Get the cente of the reslice cursor.
	/// </summary>
	public virtual void SetCenter(double arg0, double arg1, double arg2)
	{
		vtkResliceCursor_SetCenter_44(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetCenter_45(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Set/Get the cente of the reslice cursor.
	/// </summary>
	public virtual void SetCenter(IntPtr center)
	{
		vtkResliceCursor_SetCenter_45(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetHole_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Show a hole in the center of the cursor, so its easy to see the pixels
	/// within the hole. ON by default
	/// </summary>
	public virtual void SetHole(int _arg)
	{
		vtkResliceCursor_SetHole_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetHoleWidth_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the width of the hole in mm
	/// </summary>
	public virtual void SetHoleWidth(double _arg)
	{
		vtkResliceCursor_SetHoleWidth_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetHoleWidthInPixels_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the width of the hole in pixels. If set, this will override the
	/// hole with in mm.
	/// </summary>
	public virtual void SetHoleWidthInPixels(double _arg)
	{
		vtkResliceCursor_SetHoleWidthInPixels_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetImage_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the image (3D) that we are slicing
	/// </summary>
	public virtual void SetImage(vtkImageData arg0)
	{
		vtkResliceCursor_SetImage_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetThickMode_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable disable thick mode. Default is to enable it.
	/// </summary>
	public virtual void SetThickMode(int _arg)
	{
		vtkResliceCursor_SetThickMode_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetThickness_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the thickness of the cursor
	/// </summary>
	public virtual void SetThickness(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetThickness_51(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetThickness_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the thickness of the cursor
	/// </summary>
	public virtual void SetThickness(IntPtr _arg)
	{
		vtkResliceCursor_SetThickness_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetXAxis_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void SetXAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetXAxis_53(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetXAxis_54(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void SetXAxis(IntPtr _arg)
	{
		vtkResliceCursor_SetXAxis_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetXViewUp_55(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void SetXViewUp(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetXViewUp_55(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetXViewUp_56(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void SetXViewUp(IntPtr _arg)
	{
		vtkResliceCursor_SetXViewUp_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetYAxis_57(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void SetYAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetYAxis_57(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetYAxis_58(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void SetYAxis(IntPtr _arg)
	{
		vtkResliceCursor_SetYAxis_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetYViewUp_59(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void SetYViewUp(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetYViewUp_59(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetYViewUp_60(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void SetYViewUp(IntPtr _arg)
	{
		vtkResliceCursor_SetYViewUp_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetZAxis_61(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void SetZAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetZAxis_61(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetZAxis_62(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the computed axes directions
	/// </summary>
	public virtual void SetZAxis(IntPtr _arg)
	{
		vtkResliceCursor_SetZAxis_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetZViewUp_63(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void SetZViewUp(double _arg1, double _arg2, double _arg3)
	{
		vtkResliceCursor_SetZViewUp_63(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_SetZViewUp_64(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the view up
	/// </summary>
	public virtual void SetZViewUp(IntPtr _arg)
	{
		vtkResliceCursor_SetZViewUp_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_ThickModeOff_65(HandleRef pThis);

	/// <summary>
	/// Enable disable thick mode. Default is to enable it.
	/// </summary>
	public virtual void ThickModeOff()
	{
		vtkResliceCursor_ThickModeOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_ThickModeOn_66(HandleRef pThis);

	/// <summary>
	/// Enable disable thick mode. Default is to enable it.
	/// </summary>
	public virtual void ThickModeOn()
	{
		vtkResliceCursor_ThickModeOn_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursor_Update_67(HandleRef pThis);

	/// <summary>
	/// Build the polydata
	/// </summary>
	public virtual void Update()
	{
		vtkResliceCursor_Update_67(GetCppThis());
	}
}
