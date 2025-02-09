using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImagePermute
/// </summary>
/// <remarks>
///     Permutes axes of input.
///
/// vtkImagePermute reorders the axes of the input. Filtered axes specify
/// the input axes which become X, Y, Z.  The input has to have the
/// same scalar type of the output. The filter does copy the
/// data when it executes. This filter is actually a very thin wrapper
/// around vtkImageReslice.
/// </remarks>
public class vtkImagePermute : vtkImageReslice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImagePermute";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImagePermute()
	{
		MRClassNameKey = "class vtkImagePermute";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePermute"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImagePermute(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePermute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImagePermute New()
	{
		vtkImagePermute result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePermute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImagePermute()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImagePermute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePermute_GetFilteredAxes_01(HandleRef pThis);

	/// <summary>
	/// The filtered axes are the input axes that get relabeled to X,Y,Z.
	/// </summary>
	public virtual int[] GetFilteredAxes()
	{
		IntPtr intPtr = vtkImagePermute_GetFilteredAxes_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePermute_GetFilteredAxes_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// The filtered axes are the input axes that get relabeled to X,Y,Z.
	/// </summary>
	public virtual void GetFilteredAxes(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImagePermute_GetFilteredAxes_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePermute_GetFilteredAxes_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The filtered axes are the input axes that get relabeled to X,Y,Z.
	/// </summary>
	public virtual void GetFilteredAxes(IntPtr _arg)
	{
		vtkImagePermute_GetFilteredAxes_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImagePermute_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImagePermute_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImagePermute_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImagePermute_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePermute_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImagePermute_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePermute_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImagePermute_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePermute_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImagePermute NewInstance()
	{
		vtkImagePermute result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePermute_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePermute_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImagePermute SafeDownCast(vtkObjectBase o)
	{
		vtkImagePermute vtkImagePermute2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePermute_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImagePermute2 = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImagePermute2.Register(null);
			}
		}
		return vtkImagePermute2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePermute_SetFilteredAxes_11(HandleRef pThis, int x, int y, int z);

	/// <summary>
	/// The filtered axes are the input axes that get relabeled to X,Y,Z.
	/// </summary>
	public void SetFilteredAxes(int x, int y, int z)
	{
		vtkImagePermute_SetFilteredAxes_11(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePermute_SetFilteredAxes_12(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// The filtered axes are the input axes that get relabeled to X,Y,Z.
	/// </summary>
	public void SetFilteredAxes(IntPtr xyz)
	{
		vtkImagePermute_SetFilteredAxes_12(GetCppThis(), xyz);
	}
}
