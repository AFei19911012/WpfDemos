using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursorPicker
/// </summary>
/// <remarks>
///    ray-cast cell picker for the reslice cursor
///
/// This class is used by the vtkResliceCursorWidget to pick reslice axes
/// drawn by a vtkResliceCursorActor. The class returns the axes picked if
/// any, whether one has picked the center. It takes as input an instance
/// of vtkResliceCursorPolyDataAlgorithm. This is all done internally by
/// vtkResliceCursorWidget and as such users are not expected to use this
/// class directly, unless they are overriding the behaviour of
/// vtkResliceCursorWidget.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursor vtkResliceCursorWidget
/// </seealso>
public class vtkResliceCursorPicker : vtkPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursorPicker()
	{
		MRClassNameKey = "class vtkResliceCursorPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursorPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResliceCursorPicker New()
	{
		vtkResliceCursorPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResliceCursorPicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceCursorPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkResliceCursorPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursorPicker_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorPicker_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursorPicker_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPicker_GetPickedAxis1_03(HandleRef pThis);

	/// <summary>
	/// Get the picked axis
	/// </summary>
	public virtual int GetPickedAxis1()
	{
		return vtkResliceCursorPicker_GetPickedAxis1_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPicker_GetPickedAxis2_04(HandleRef pThis);

	/// <summary>
	/// Get the picked axis
	/// </summary>
	public virtual int GetPickedAxis2()
	{
		return vtkResliceCursorPicker_GetPickedAxis2_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPicker_GetPickedCenter_05(HandleRef pThis);

	/// <summary>
	/// Get the picked axis
	/// </summary>
	public virtual int GetPickedCenter()
	{
		return vtkResliceCursorPicker_GetPickedCenter_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPicker_GetResliceCursorAlgorithm_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the reslice cursor algorithm. One must be set
	/// </summary>
	public virtual vtkResliceCursorPolyDataAlgorithm GetResliceCursorAlgorithm()
	{
		vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPicker_GetResliceCursorAlgorithm_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkResliceCursorPicker_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursorPicker_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPicker_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursorPicker_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPicker_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResliceCursorPicker NewInstance()
	{
		vtkResliceCursorPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPicker_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorPicker_Pick_11(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

	/// <summary>
	/// Perform pick operation with selection point provided. Normally the
	/// first two values are the (x,y) pixel coordinates for the pick, and
	/// the third value is z=0. The return value will be non-zero if
	/// something was successfully picked.
	/// </summary>
	public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
	{
		return vtkResliceCursorPicker_Pick_11(GetCppThis(), selectionX, selectionY, selectionZ, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPicker_Pick_12(HandleRef pThis, IntPtr displayPos, IntPtr world, HandleRef ren);

	/// <summary>
	/// Overloaded pick method that returns the picked coordinates of the current
	/// resliced plane in world coordinates when given a display position
	/// </summary>
	public void Pick(IntPtr displayPos, IntPtr world, vtkRenderer ren)
	{
		vtkResliceCursorPicker_Pick_12(GetCppThis(), displayPos, world, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorPicker_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResliceCursorPicker SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursorPicker vtkResliceCursorPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorPicker_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorPicker2 = (vtkResliceCursorPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorPicker2.Register(null);
			}
		}
		return vtkResliceCursorPicker2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPicker_SetResliceCursorAlgorithm_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the reslice cursor algorithm. One must be set
	/// </summary>
	public virtual void SetResliceCursorAlgorithm(vtkResliceCursorPolyDataAlgorithm arg0)
	{
		vtkResliceCursorPicker_SetResliceCursorAlgorithm_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorPicker_SetTransformMatrix_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the reslice cursor algorithm. One must be set
	/// </summary>
	public virtual void SetTransformMatrix(vtkMatrix4x4 arg0)
	{
		vtkResliceCursorPicker_SetTransformMatrix_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
