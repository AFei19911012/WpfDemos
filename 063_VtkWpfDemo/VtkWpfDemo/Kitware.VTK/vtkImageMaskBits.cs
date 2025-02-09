using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMaskBits
/// </summary>
/// <remarks>
///    applies a bit-mask pattern to each component.
///
///
/// vtkImageMaskBits applies a bit-mask pattern to each component.  The
/// bit-mask can be applied using a variety of boolean bitwise operators.
/// </remarks>
public class vtkImageMaskBits : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMaskBits";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMaskBits()
	{
		MRClassNameKey = "class vtkImageMaskBits";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMaskBits"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMaskBits(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMaskBits_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMaskBits New()
	{
		vtkImageMaskBits result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMaskBits_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMaskBits()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMaskBits_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMaskBits_GetMasks_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public virtual uint[] GetMasks()
	{
		IntPtr intPtr = vtkImageMaskBits_GetMasks_01(GetCppThis());
		uint[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new uint[4];
			int[] array2 = new int[4];
			Marshal.Copy(intPtr, array2, 0, array.Length);
			for (int i = 0; i < 4; i++)
			{
				array[i] = (uint)array2[i];
			}
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_GetMasks_02(HandleRef pThis, ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public virtual void GetMasks(ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4)
	{
		vtkImageMaskBits_GetMasks_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_GetMasks_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public virtual void GetMasks(IntPtr _arg)
	{
		vtkImageMaskBits_GetMasks_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMaskBits_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMaskBits_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMaskBits_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMaskBits_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMaskBits_GetOperation_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkImageMaskBits_GetOperation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMaskBits_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMaskBits_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMaskBits_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMaskBits_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMaskBits_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMaskBits NewInstance()
	{
		vtkImageMaskBits result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMaskBits_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMaskBits_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMaskBits SafeDownCast(vtkObjectBase o)
	{
		vtkImageMaskBits vtkImageMaskBits2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMaskBits_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMaskBits2 = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMaskBits2.Register(null);
			}
		}
		return vtkImageMaskBits2;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetMask_12(HandleRef pThis, uint mask);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public void SetMask(uint mask)
	{
		vtkImageMaskBits_SetMask_12(GetCppThis(), mask);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetMasks_13(HandleRef pThis, uint _arg1, uint _arg2, uint _arg3, uint _arg4);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public virtual void SetMasks(uint _arg1, uint _arg2, uint _arg3, uint _arg4)
	{
		vtkImageMaskBits_SetMasks_13(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetMasks_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public virtual void SetMasks(IntPtr _arg)
	{
		vtkImageMaskBits_SetMasks_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetMasks_15(HandleRef pThis, uint mask1, uint mask2);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public void SetMasks(uint mask1, uint mask2)
	{
		vtkImageMaskBits_SetMasks_15(GetCppThis(), mask1, mask2);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetMasks_16(HandleRef pThis, uint mask1, uint mask2, uint mask3);

	/// <summary>
	/// Set/Get the bit-masks. Default is 0xffffffff.
	/// </summary>
	public void SetMasks(uint mask1, uint mask2, uint mask3)
	{
		vtkImageMaskBits_SetMasks_16(GetCppThis(), mask1, mask2, mask3);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetOperation_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkImageMaskBits_SetOperation_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetOperationToAnd_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public void SetOperationToAnd()
	{
		vtkImageMaskBits_SetOperationToAnd_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetOperationToNand_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public void SetOperationToNand()
	{
		vtkImageMaskBits_SetOperationToNand_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetOperationToNor_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public void SetOperationToNor()
	{
		vtkImageMaskBits_SetOperationToNor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetOperationToOr_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public void SetOperationToOr()
	{
		vtkImageMaskBits_SetOperationToOr_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMaskBits_SetOperationToXor_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the boolean operator. Default is AND.
	/// </summary>
	public void SetOperationToXor()
	{
		vtkImageMaskBits_SetOperationToXor_22(GetCppThis());
	}
}
