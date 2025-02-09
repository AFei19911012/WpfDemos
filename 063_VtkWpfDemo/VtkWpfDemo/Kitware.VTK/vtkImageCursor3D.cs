using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageCursor3D
/// </summary>
/// <remarks>
///    Paints a cursor on top of an image or volume.
///
/// vtkImageCursor3D will draw a cursor on a 2d image or 3d volume.
/// </remarks>
public class vtkImageCursor3D : vtkImageInPlaceFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageCursor3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageCursor3D()
	{
		MRClassNameKey = "class vtkImageCursor3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCursor3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageCursor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCursor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageCursor3D New()
	{
		vtkImageCursor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCursor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageCursor3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageCursor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCursor3D_GetCursorPosition_01(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the center point of the 3d cursor.
	/// </summary>
	public virtual double[] GetCursorPosition()
	{
		IntPtr intPtr = vtkImageCursor3D_GetCursorPosition_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCursor3D_GetCursorPosition_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Sets/Gets the center point of the 3d cursor.
	/// </summary>
	public virtual void GetCursorPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageCursor3D_GetCursorPosition_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCursor3D_GetCursorPosition_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets/Gets the center point of the 3d cursor.
	/// </summary>
	public virtual void GetCursorPosition(IntPtr _arg)
	{
		vtkImageCursor3D_GetCursorPosition_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCursor3D_GetCursorRadius_04(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the radius of the cursor. The radius determines
	/// how far the axis lines project out from the cursors center.
	/// </summary>
	public virtual int GetCursorRadius()
	{
		return vtkImageCursor3D_GetCursorRadius_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageCursor3D_GetCursorValue_05(HandleRef pThis);

	/// <summary>
	/// Sets/Gets what pixel value to draw the cursor in.
	/// </summary>
	public virtual double GetCursorValue()
	{
		return vtkImageCursor3D_GetCursorValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCursor3D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageCursor3D_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCursor3D_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageCursor3D_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCursor3D_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageCursor3D_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCursor3D_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageCursor3D_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCursor3D_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageCursor3D NewInstance()
	{
		vtkImageCursor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCursor3D_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCursor3D_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageCursor3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageCursor3D vtkImageCursor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCursor3D_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageCursor3D2 = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageCursor3D2.Register(null);
			}
		}
		return vtkImageCursor3D2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCursor3D_SetCursorPosition_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Sets/Gets the center point of the 3d cursor.
	/// </summary>
	public virtual void SetCursorPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkImageCursor3D_SetCursorPosition_13(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCursor3D_SetCursorPosition_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets/Gets the center point of the 3d cursor.
	/// </summary>
	public virtual void SetCursorPosition(IntPtr _arg)
	{
		vtkImageCursor3D_SetCursorPosition_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCursor3D_SetCursorRadius_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets/Gets the radius of the cursor. The radius determines
	/// how far the axis lines project out from the cursors center.
	/// </summary>
	public virtual void SetCursorRadius(int _arg)
	{
		vtkImageCursor3D_SetCursorRadius_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCursor3D_SetCursorValue_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Sets/Gets what pixel value to draw the cursor in.
	/// </summary>
	public virtual void SetCursorValue(double _arg)
	{
		vtkImageCursor3D_SetCursorValue_16(GetCppThis(), _arg);
	}
}
