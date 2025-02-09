using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageOpenClose3D
/// </summary>
/// <remarks>
///    Will perform opening or closing.
///
/// vtkImageOpenClose3D performs opening or closing by having two
/// vtkImageErodeDilates in series.  The size of operation
/// is determined by the method SetKernelSize, and the operator is an ellipse.
/// OpenValue and CloseValue determine how the filter behaves.  For binary
/// images Opening and closing behaves as expected.
/// Close value is first dilated, and then eroded.
/// Open value is first eroded, and then dilated.
/// Degenerate two dimensional opening/closing can be achieved by setting the
/// one axis the 3D KernelSize to 1.
/// Values other than open value and close value are not touched.
/// This enables the filter to processes segmented images containing more than
/// two tags.
/// </remarks>
public class vtkImageOpenClose3D : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageOpenClose3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageOpenClose3D()
	{
		MRClassNameKey = "class vtkImageOpenClose3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageOpenClose3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageOpenClose3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageOpenClose3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public new static vtkImageOpenClose3D New()
	{
		vtkImageOpenClose3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageOpenClose3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public vtkImageOpenClose3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageOpenClose3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageOpenClose3D_DebugOff_01(HandleRef pThis);

	/// <summary>
	/// Turn debugging output on. (in sub filters also)
	/// </summary>
	public override void DebugOff()
	{
		vtkImageOpenClose3D_DebugOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageOpenClose3D_DebugOn_02(HandleRef pThis);

	/// <summary>
	/// Turn debugging output on. (in sub filters also)
	/// </summary>
	public override void DebugOn()
	{
		vtkImageOpenClose3D_DebugOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageOpenClose3D_GetCloseValue_03(HandleRef pThis);

	/// <summary>
	/// Determines the value that will closed.
	/// Close value is first dilated, and then eroded
	/// </summary>
	public double GetCloseValue()
	{
		return vtkImageOpenClose3D_GetCloseValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageOpenClose3D_GetFilter0_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Needed for Progress functions
	/// </summary>
	public virtual vtkImageDilateErode3D GetFilter0()
	{
		vtkImageDilateErode3D vtkImageDilateErode3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageOpenClose3D_GetFilter0_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDilateErode3D2 = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDilateErode3D2.Register(null);
			}
		}
		return vtkImageDilateErode3D2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageOpenClose3D_GetFilter1_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Needed for Progress functions
	/// </summary>
	public virtual vtkImageDilateErode3D GetFilter1()
	{
		vtkImageDilateErode3D vtkImageDilateErode3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageOpenClose3D_GetFilter1_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDilateErode3D2 = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDilateErode3D2.Register(null);
			}
		}
		return vtkImageDilateErode3D2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageOpenClose3D_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// This method considers the sub filters MTimes when computing this objects
	/// modified time.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageOpenClose3D_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageOpenClose3D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageOpenClose3D_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageOpenClose3D_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageOpenClose3D_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageOpenClose3D_GetOpenValue_09(HandleRef pThis);

	/// <summary>
	/// Determines the value that will opened.
	/// Open value is first eroded, and then dilated.
	/// </summary>
	public double GetOpenValue()
	{
		return vtkImageOpenClose3D_GetOpenValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageOpenClose3D_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageOpenClose3D_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageOpenClose3D_IsTypeOf_11(string type);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageOpenClose3D_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageOpenClose3D_Modified_12(HandleRef pThis);

	/// <summary>
	/// Pass modified message to sub filters.
	/// </summary>
	public override void Modified()
	{
		vtkImageOpenClose3D_Modified_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageOpenClose3D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public new vtkImageOpenClose3D NewInstance()
	{
		vtkImageOpenClose3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageOpenClose3D_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageOpenClose3D_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Default open value is 0, and default close value is 255.
	/// </summary>
	public new static vtkImageOpenClose3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageOpenClose3D vtkImageOpenClose3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageOpenClose3D_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageOpenClose3D2 = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageOpenClose3D2.Register(null);
			}
		}
		return vtkImageOpenClose3D2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageOpenClose3D_SetCloseValue_16(HandleRef pThis, double value);

	/// <summary>
	/// Determines the value that will closed.
	/// Close value is first dilated, and then eroded
	/// </summary>
	public void SetCloseValue(double value)
	{
		vtkImageOpenClose3D_SetCloseValue_16(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageOpenClose3D_SetKernelSize_17(HandleRef pThis, int size0, int size1, int size2);

	/// <summary>
	/// Selects the size of gaps or objects removed.
	/// </summary>
	public void SetKernelSize(int size0, int size1, int size2)
	{
		vtkImageOpenClose3D_SetKernelSize_17(GetCppThis(), size0, size1, size2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageOpenClose3D_SetOpenValue_18(HandleRef pThis, double value);

	/// <summary>
	/// Determines the value that will opened.
	/// Open value is first eroded, and then dilated.
	/// </summary>
	public void SetOpenValue(double value)
	{
		vtkImageOpenClose3D_SetOpenValue_18(GetCppThis(), value);
	}
}
