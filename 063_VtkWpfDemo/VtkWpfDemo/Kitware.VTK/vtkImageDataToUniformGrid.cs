using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDataToUniformGrid
/// </summary>
/// <remarks>
///    convert vtkImageData to vtkUniformGrid
///
/// Convert a vtkImageData to vtkUniformGrid and set blanking based on
/// specified by named arrays. By default, values of 0 in the named
/// array will result in the point or cell being blanked. Set Reverse
/// to 1 to indicate that values of 0 will result in the point or
/// cell to not be blanked.
/// </remarks>
public class vtkImageDataToUniformGrid : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataToUniformGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDataToUniformGrid()
	{
		MRClassNameKey = "class vtkImageDataToUniformGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataToUniformGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDataToUniformGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataToUniformGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDataToUniformGrid New()
	{
		vtkImageDataToUniformGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataToUniformGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataToUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageDataToUniformGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageDataToUniformGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDataToUniformGrid_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataToUniformGrid_GetReverse_03(HandleRef pThis);

	/// <summary>
	/// By default, values of 0 (i.e. Reverse = 0) in the array will
	/// result in that point or cell to be blanked. Set Reverse to
	/// 1 to make points or cells to not be blanked for array values
	/// of 0.
	/// </summary>
	public virtual int GetReverse()
	{
		return vtkImageDataToUniformGrid_GetReverse_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataToUniformGrid_GetReverseMaxValue_04(HandleRef pThis);

	/// <summary>
	/// By default, values of 0 (i.e. Reverse = 0) in the array will
	/// result in that point or cell to be blanked. Set Reverse to
	/// 1 to make points or cells to not be blanked for array values
	/// of 0.
	/// </summary>
	public virtual int GetReverseMaxValue()
	{
		return vtkImageDataToUniformGrid_GetReverseMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataToUniformGrid_GetReverseMinValue_05(HandleRef pThis);

	/// <summary>
	/// By default, values of 0 (i.e. Reverse = 0) in the array will
	/// result in that point or cell to be blanked. Set Reverse to
	/// 1 to make points or cells to not be blanked for array values
	/// of 0.
	/// </summary>
	public virtual int GetReverseMinValue()
	{
		return vtkImageDataToUniformGrid_GetReverseMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataToUniformGrid_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDataToUniformGrid_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataToUniformGrid_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDataToUniformGrid_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataToUniformGrid_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageDataToUniformGrid NewInstance()
	{
		vtkImageDataToUniformGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataToUniformGrid_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataToUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataToUniformGrid_ReverseOff_10(HandleRef pThis);

	/// <summary>
	/// By default, values of 0 (i.e. Reverse = 0) in the array will
	/// result in that point or cell to be blanked. Set Reverse to
	/// 1 to make points or cells to not be blanked for array values
	/// of 0.
	/// </summary>
	public virtual void ReverseOff()
	{
		vtkImageDataToUniformGrid_ReverseOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataToUniformGrid_ReverseOn_11(HandleRef pThis);

	/// <summary>
	/// By default, values of 0 (i.e. Reverse = 0) in the array will
	/// result in that point or cell to be blanked. Set Reverse to
	/// 1 to make points or cells to not be blanked for array values
	/// of 0.
	/// </summary>
	public virtual void ReverseOn()
	{
		vtkImageDataToUniformGrid_ReverseOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataToUniformGrid_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDataToUniformGrid SafeDownCast(vtkObjectBase o)
	{
		vtkImageDataToUniformGrid vtkImageDataToUniformGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataToUniformGrid_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDataToUniformGrid2 = (vtkImageDataToUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDataToUniformGrid2.Register(null);
			}
		}
		return vtkImageDataToUniformGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataToUniformGrid_SetReverse_13(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, values of 0 (i.e. Reverse = 0) in the array will
	/// result in that point or cell to be blanked. Set Reverse to
	/// 1 to make points or cells to not be blanked for array values
	/// of 0.
	/// </summary>
	public virtual void SetReverse(int _arg)
	{
		vtkImageDataToUniformGrid_SetReverse_13(GetCppThis(), _arg);
	}
}
