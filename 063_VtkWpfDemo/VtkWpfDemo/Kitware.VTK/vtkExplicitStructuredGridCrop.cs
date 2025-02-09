using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExplicitStructuredGridCrop
/// </summary>
/// <remarks>
///    Filter which extracts a piece of explicit structured
/// grid changing its extents.
/// </remarks>
public class vtkExplicitStructuredGridCrop : vtkExplicitStructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGridCrop";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExplicitStructuredGridCrop()
	{
		MRClassNameKey = "class vtkExplicitStructuredGridCrop";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGridCrop"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExplicitStructuredGridCrop(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridCrop_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExplicitStructuredGridCrop New()
	{
		vtkExplicitStructuredGridCrop result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGridCrop_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExplicitStructuredGridCrop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExplicitStructuredGridCrop()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExplicitStructuredGridCrop_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridCrop_GetOutputWholeExtent_03(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void GetOutputWholeExtent(IntPtr extent)
	{
		vtkExplicitStructuredGridCrop_GetOutputWholeExtent_03(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridCrop_GetOutputWholeExtent_04(HandleRef pThis);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public IntPtr GetOutputWholeExtent()
	{
		return vtkExplicitStructuredGridCrop_GetOutputWholeExtent_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGridCrop_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExplicitStructuredGridCrop_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGridCrop_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExplicitStructuredGridCrop_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridCrop_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExplicitStructuredGridCrop NewInstance()
	{
		vtkExplicitStructuredGridCrop result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGridCrop_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExplicitStructuredGridCrop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridCrop_ResetOutputWholeExtent_09(HandleRef pThis);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void ResetOutputWholeExtent()
	{
		vtkExplicitStructuredGridCrop_ResetOutputWholeExtent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridCrop_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExplicitStructuredGridCrop SafeDownCast(vtkObjectBase o)
	{
		vtkExplicitStructuredGridCrop vtkExplicitStructuredGridCrop2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGridCrop_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExplicitStructuredGridCrop2 = (vtkExplicitStructuredGridCrop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExplicitStructuredGridCrop2.Register(null);
			}
		}
		return vtkExplicitStructuredGridCrop2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridCrop_SetOutputWholeExtent_11(HandleRef pThis, IntPtr extent, HandleRef outInfo);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
	{
		vtkExplicitStructuredGridCrop_SetOutputWholeExtent_11(GetCppThis(), extent, outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridCrop_SetOutputWholeExtent_12(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// The whole extent of the output has to be set explicitly.
	/// </summary>
	public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkExplicitStructuredGridCrop_SetOutputWholeExtent_12(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}
}
