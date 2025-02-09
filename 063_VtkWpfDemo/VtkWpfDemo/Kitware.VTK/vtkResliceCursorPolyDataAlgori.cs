using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursorPolyDataAlgorithm
/// </summary>
/// <remarks>
///    generates a 2D reslice cursor polydata
///
/// vtkResliceCursorPolyDataAlgorithm is a class that generates a 2D
/// reslice cursor vtkPolyData, suitable for rendering within a
/// vtkResliceCursorActor. The class takes as input the reslice plane
/// normal index (an index into the normal plane maintained by the reslice
/// cursor object) and generates the polydata representing the other two
/// reslice axes suitable for rendering on a slice through this plane.
/// The cursor consists of two intersection axes lines that meet at the
/// cursor focus. These lines may have a user defined thickness. They
/// need not be orthogonal to each other.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursorActor vtkResliceCursor vtkResliceCursorWidget
/// </seealso>
public class vtkResliceCursorPolyDataAlgorithm : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Which of the 3 axes defines the reslice plane normal ?
	/// </summary>
	public enum XAxis_WrapperEnum
	{
		/// <summary>enum member</summary>
		XAxis,
		/// <summary>enum member</summary>
		YAxis,
		/// <summary>enum member</summary>
		ZAxis
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorPolyDataAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursorPolyDataAlgorithm()
	{
		MRClassNameKey = "class vtkResliceCursorPolyDataAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorPolyDataAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursorPolyDataAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResliceCursorPolyDataAlgorithm New()
	{
		vtkResliceCursorPolyDataAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResliceCursorPolyDataAlgorithm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceCursorPolyDataAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkResliceCursorPolyDataAlgorithm_GetAxis1_01(HandleRef pThis);

	/// <summary>
	/// Get the index of the axes and the planes that they represent
	/// </summary>
	public virtual int GetAxis1()
	{
		return vtkResliceCursorPolyDataAlgorithm_GetAxis1_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPolyDataAlgorithm_GetAxis2_02(HandleRef pThis);

	/// <summary>
	/// Get the index of the axes and the planes that they represent
	/// </summary>
	public virtual int GetAxis2()
	{
		return vtkResliceCursorPolyDataAlgorithm_GetAxis2_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis1_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get either one of the axes that this object produces. Depending on
	/// the mode, one renders either the centerline axes or both the
	/// centerline axes and the slab
	/// </summary>
	public virtual vtkPolyData GetCenterlineAxis1()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis1_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis2_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get either one of the axes that this object produces. Depending on
	/// the mode, one renders either the centerline axes or both the
	/// centerline axes and the slab
	/// </summary>
	public virtual vtkPolyData GetCenterlineAxis2()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis2_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkResliceCursorPolyDataAlgorithm_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Get the MTime. Check the MTime of the internal ResliceCursor as well, if
	/// one has been set
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkResliceCursorPolyDataAlgorithm_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPolyDataAlgorithm_GetOtherPlaneForAxis_08(HandleRef pThis, int p);

	/// <summary>
	/// Convenience method that, given one plane, returns the other plane
	/// that this class represents.
	/// </summary>
	public int GetOtherPlaneForAxis(int p)
	{
		return vtkResliceCursorPolyDataAlgorithm_GetOtherPlaneForAxis_08(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis1_09(HandleRef pThis);

	/// <summary>
	/// Get the index of the axes and the planes that they represent
	/// </summary>
	public virtual int GetPlaneAxis1()
	{
		return vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis1_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis2_10(HandleRef pThis);

	/// <summary>
	/// Get the index of the axes and the planes that they represent
	/// </summary>
	public virtual int GetPlaneAxis2()
	{
		return vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis2_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetResliceCursor_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the Reslice cursor from which to generate the polydata representation
	/// </summary>
	public virtual vtkResliceCursor GetResliceCursor()
	{
		vtkResliceCursor vtkResliceCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_GetResliceCursor_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkResliceCursorPolyDataAlgorithm_GetReslicePlaneNormal_12(HandleRef pThis);

	/// <summary>
	/// Which of the 3 axes defines the reslice plane normal ?
	/// </summary>
	public virtual int GetReslicePlaneNormal()
	{
		return vtkResliceCursorPolyDataAlgorithm_GetReslicePlaneNormal_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the slice bounds, ie the slice of this view on which to display
	/// the reslice cursor.
	/// </summary>
	public virtual double[] GetSliceBounds()
	{
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get the slice bounds, ie the slice of this view on which to display
	/// the reslice cursor.
	/// </summary>
	public virtual void GetSliceBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the slice bounds, ie the slice of this view on which to display
	/// the reslice cursor.
	/// </summary>
	public virtual void GetSliceBounds(IntPtr _arg)
	{
		vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis1_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get either one of the axes that this object produces. Depending on
	/// the mode, one renders either the centerline axes or both the
	/// centerline axes and the slab
	/// </summary>
	public virtual vtkPolyData GetThickSlabAxis1()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis1_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis2_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get either one of the axes that this object produces. Depending on
	/// the mode, one renders either the centerline axes or both the
	/// centerline axes and the slab
	/// </summary>
	public virtual vtkPolyData GetThickSlabAxis2()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis2_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkResliceCursorPolyDataAlgorithm_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursorPolyDataAlgorithm_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPolyDataAlgorithm_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursorPolyDataAlgorithm_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResliceCursorPolyDataAlgorithm NewInstance()
	{
		vtkResliceCursorPolyDataAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResliceCursorPolyDataAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorPolyDataAlgorithm2 = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkResliceCursorPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetResliceCursor_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the Reslice cursor from which to generate the polydata representation
	/// </summary>
	public virtual void SetResliceCursor(vtkResliceCursor arg0)
	{
		vtkResliceCursorPolyDataAlgorithm_SetResliceCursor_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormal_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Which of the 3 axes defines the reslice plane normal ?
	/// </summary>
	public virtual void SetReslicePlaneNormal(int _arg)
	{
		vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormal_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToXAxis_25(HandleRef pThis);

	/// <summary>
	/// Set the planes that correspond to the reslice axes.
	/// </summary>
	public void SetReslicePlaneNormalToXAxis()
	{
		vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToXAxis_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToYAxis_26(HandleRef pThis);

	/// <summary>
	/// Set the planes that correspond to the reslice axes.
	/// </summary>
	public void SetReslicePlaneNormalToYAxis()
	{
		vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToYAxis_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToZAxis_27(HandleRef pThis);

	/// <summary>
	/// Set the planes that correspond to the reslice axes.
	/// </summary>
	public void SetReslicePlaneNormalToZAxis()
	{
		vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToZAxis_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_28(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get the slice bounds, ie the slice of this view on which to display
	/// the reslice cursor.
	/// </summary>
	public virtual void SetSliceBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_28(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the slice bounds, ie the slice of this view on which to display
	/// the reslice cursor.
	/// </summary>
	public virtual void SetSliceBounds(IntPtr _arg)
	{
		vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_29(GetCppThis(), _arg);
	}
}
