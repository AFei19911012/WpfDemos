using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageClip
/// </summary>
/// <remarks>
///    Reduces the image extent of the input.
///
/// vtkImageClip  will make an image smaller.  The output must have
/// an image extent which is the subset of the input.  The filter has two
/// modes of operation:
/// 1: By default, the data is not copied in this filter.
/// Only the whole extent is modified.
/// 2: If ClipDataOn is set, then you will get no more that the clipped
/// extent.
/// </remarks>
public class vtkImageClip : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageClip";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageClip()
	{
		MRClassNameKey = "class vtkImageClip";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageClip"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageClip New()
	{
		vtkImageClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageClip()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageClip_ClipDataOff_01(HandleRef pThis);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual void ClipDataOff()
	{
		vtkImageClip_ClipDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageClip_ClipDataOn_02(HandleRef pThis);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual void ClipDataOn()
	{
		vtkImageClip_ClipDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageClip_GetClipData_03(HandleRef pThis);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual int GetClipData()
	{
		return vtkImageClip_GetClipData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageClip_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageClip_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageClip_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageClip_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageClip_GetOutputWholeExtent_06(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void GetOutputWholeExtent(IntPtr extent)
	{
		vtkImageClip_GetOutputWholeExtent_06(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageClip_GetOutputWholeExtent_07(HandleRef pThis);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public int[] GetOutputWholeExtent()
	{
		IntPtr intPtr = vtkImageClip_GetOutputWholeExtent_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageClip_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageClip_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageClip_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageClip_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageClip NewInstance()
	{
		vtkImageClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageClip_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageClip_ResetOutputWholeExtent_12(HandleRef pThis);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void ResetOutputWholeExtent()
	{
		vtkImageClip_ResetOutputWholeExtent_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageClip SafeDownCast(vtkObjectBase o)
	{
		vtkImageClip vtkImageClip2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageClip_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageClip2 = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageClip2.Register(null);
			}
		}
		return vtkImageClip2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageClip_SetClipData_14(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual void SetClipData(int _arg)
	{
		vtkImageClip_SetClipData_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageClip_SetOutputWholeExtent_15(HandleRef pThis, IntPtr extent, HandleRef outInfo);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
	{
		vtkImageClip_SetOutputWholeExtent_15(GetCppThis(), extent, outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageClip_SetOutputWholeExtent_16(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkImageClip_SetOutputWholeExtent_16(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}
}
