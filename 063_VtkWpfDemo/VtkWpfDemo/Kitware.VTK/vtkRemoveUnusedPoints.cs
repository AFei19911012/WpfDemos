using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkRemoveUnusedPoints
/// </summary>
/// <remarks>
///  remove points not used by any cell.
///
/// vtkRemoveUnusedPoints is a filter that removes any points that are not used by the
/// cells. Currently, this filter only supports vtkUnstructuredGrid.
/// </remarks>
public class vtkRemoveUnusedPoints : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveUnusedPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRemoveUnusedPoints()
	{
		MRClassNameKey = "class vtkRemoveUnusedPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveUnusedPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRemoveUnusedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemoveUnusedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRemoveUnusedPoints New()
	{
		vtkRemoveUnusedPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemoveUnusedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRemoveUnusedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRemoveUnusedPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRemoveUnusedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRemoveUnusedPoints_GenerateOriginalPointIdsOff_01(HandleRef pThis);

	/// <summary>
	/// Enable adding a `vtkOriginalPointIds` array to the point data
	/// which identifies the original point index. Default is true.
	/// </summary>
	public virtual void GenerateOriginalPointIdsOff()
	{
		vtkRemoveUnusedPoints_GenerateOriginalPointIdsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemoveUnusedPoints_GenerateOriginalPointIdsOn_02(HandleRef pThis);

	/// <summary>
	/// Enable adding a `vtkOriginalPointIds` array to the point data
	/// which identifies the original point index. Default is true.
	/// </summary>
	public virtual void GenerateOriginalPointIdsOn()
	{
		vtkRemoveUnusedPoints_GenerateOriginalPointIdsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRemoveUnusedPoints_GetGenerateOriginalPointIds_03(HandleRef pThis);

	/// <summary>
	/// Enable adding a `vtkOriginalPointIds` array to the point data
	/// which identifies the original point index. Default is true.
	/// </summary>
	public virtual bool GetGenerateOriginalPointIds()
	{
		return (vtkRemoveUnusedPoints_GetGenerateOriginalPointIds_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemoveUnusedPoints_GetOriginalPointIdsArrayName_06(HandleRef pThis);

	/// <summary>
	/// Choose the name to use for the original point ids array. Default is `vtkOriginalPointIds`.
	/// This is used only when `GenerateOriginalPointIds` is true.
	/// </summary>
	public virtual string GetOriginalPointIdsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRemoveUnusedPoints_GetOriginalPointIdsArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRemoveUnusedPoints_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRemoveUnusedPoints_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRemoveUnusedPoints_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRemoveUnusedPoints_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemoveUnusedPoints_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRemoveUnusedPoints NewInstance()
	{
		vtkRemoveUnusedPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemoveUnusedPoints_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRemoveUnusedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemoveUnusedPoints_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRemoveUnusedPoints SafeDownCast(vtkObjectBase o)
	{
		vtkRemoveUnusedPoints vtkRemoveUnusedPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemoveUnusedPoints_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRemoveUnusedPoints2 = (vtkRemoveUnusedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRemoveUnusedPoints2.Register(null);
			}
		}
		return vtkRemoveUnusedPoints2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemoveUnusedPoints_SetGenerateOriginalPointIds_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable adding a `vtkOriginalPointIds` array to the point data
	/// which identifies the original point index. Default is true.
	/// </summary>
	public virtual void SetGenerateOriginalPointIds(bool _arg)
	{
		vtkRemoveUnusedPoints_SetGenerateOriginalPointIds_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemoveUnusedPoints_SetOriginalPointIdsArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Choose the name to use for the original point ids array. Default is `vtkOriginalPointIds`.
	/// This is used only when `GenerateOriginalPointIds` is true.
	/// </summary>
	public virtual void SetOriginalPointIdsArrayName(string _arg)
	{
		vtkRemoveUnusedPoints_SetOriginalPointIdsArrayName_13(GetCppThis(), _arg);
	}
}
