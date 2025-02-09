using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearGridClip
/// </summary>
/// <remarks>
///    Reduces the image extent of the input.
///
/// vtkRectilinearGridClip  will make an image smaller.  The output must have
/// an image extent which is the subset of the input.  The filter has two
/// modes of operation:
/// 1: By default, the data is not copied in this filter.
/// Only the whole extent is modified.
/// 2: If ClipDataOn is set, then you will get no more that the clipped
/// extent.
/// </remarks>
public class vtkRectilinearGridClip : vtkRectilinearGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridClip";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearGridClip()
	{
		MRClassNameKey = "class vtkRectilinearGridClip";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridClip"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearGridClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridClip New()
	{
		vtkRectilinearGridClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRectilinearGridClip()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearGridClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_ClipDataOff_01(HandleRef pThis);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual void ClipDataOff()
	{
		vtkRectilinearGridClip_ClipDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_ClipDataOn_02(HandleRef pThis);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual void ClipDataOn()
	{
		vtkRectilinearGridClip_ClipDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridClip_GetClipData_03(HandleRef pThis);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual int GetClipData()
	{
		return vtkRectilinearGridClip_GetClipData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridClip_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearGridClip_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridClip_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearGridClip_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_GetOutputWholeExtent_06(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void GetOutputWholeExtent(IntPtr extent)
	{
		vtkRectilinearGridClip_GetOutputWholeExtent_06(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridClip_GetOutputWholeExtent_07(HandleRef pThis);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public IntPtr GetOutputWholeExtent()
	{
		return vtkRectilinearGridClip_GetOutputWholeExtent_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridClip_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearGridClip_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridClip_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearGridClip_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearGridClip NewInstance()
	{
		vtkRectilinearGridClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridClip_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_ResetOutputWholeExtent_12(HandleRef pThis);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void ResetOutputWholeExtent()
	{
		vtkRectilinearGridClip_ResetOutputWholeExtent_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridClip SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearGridClip vtkRectilinearGridClip2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridClip_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGridClip2 = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGridClip2.Register(null);
			}
		}
		return vtkRectilinearGridClip2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_SetClipData_14(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, ClipData is off, and only the WholeExtent is modified.
	/// the data's extent may actually be larger.  When this flag is on,
	/// the data extent will be no more than the OutputWholeExtent.
	/// </summary>
	public virtual void SetClipData(int _arg)
	{
		vtkRectilinearGridClip_SetClipData_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_15(HandleRef pThis, IntPtr extent, HandleRef outInfo);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
	{
		vtkRectilinearGridClip_SetOutputWholeExtent_15(GetCppThis(), extent, outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_16(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkRectilinearGridClip_SetOutputWholeExtent_16(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}
}
