using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSplitByCellScalarFilter
/// </summary>
/// <remarks>
///    splits input dataset according an integer cell scalar array.
///
/// vtkSplitByCellScalarFilter is a filter that splits any dataset type
/// according an integer cell scalar value (typically a material identifier) to
/// a multiblock. Each block of the output contains cells that have the same
/// scalar value. Output blocks will be of type vtkUnstructuredGrid except if
/// input is of type vtkPolyData. In that case output blocks are of type
/// vtkPolyData.
///
/// </remarks>
/// <seealso>
///
/// vtkThreshold
///
/// @par Thanks:
/// This class was written by Joachim Pouderoux, Kitware 2016.
/// </seealso>
public class vtkSplitByCellScalarFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSplitByCellScalarFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSplitByCellScalarFilter()
	{
		MRClassNameKey = "class vtkSplitByCellScalarFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitByCellScalarFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSplitByCellScalarFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitByCellScalarFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplitByCellScalarFilter New()
	{
		vtkSplitByCellScalarFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitByCellScalarFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplitByCellScalarFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSplitByCellScalarFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSplitByCellScalarFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSplitByCellScalarFilter_GetPassAllPoints_03(HandleRef pThis);

	/// <summary>
	/// Specify if input points array must be passed to output blocks. If so,
	/// filter processing is faster but outblocks will contains more points than
	/// what is needed by the cells it owns. If not, a new points array is created
	/// for every block and it will only contains points for copied cells.
	/// Note that this function is only possible for PointSet datasets.
	/// The default is true.
	/// </summary>
	public virtual bool GetPassAllPoints()
	{
		return (vtkSplitByCellScalarFilter_GetPassAllPoints_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitByCellScalarFilter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSplitByCellScalarFilter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitByCellScalarFilter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSplitByCellScalarFilter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitByCellScalarFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSplitByCellScalarFilter NewInstance()
	{
		vtkSplitByCellScalarFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitByCellScalarFilter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplitByCellScalarFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitByCellScalarFilter_PassAllPointsOff_08(HandleRef pThis);

	/// <summary>
	/// Specify if input points array must be passed to output blocks. If so,
	/// filter processing is faster but outblocks will contains more points than
	/// what is needed by the cells it owns. If not, a new points array is created
	/// for every block and it will only contains points for copied cells.
	/// Note that this function is only possible for PointSet datasets.
	/// The default is true.
	/// </summary>
	public virtual void PassAllPointsOff()
	{
		vtkSplitByCellScalarFilter_PassAllPointsOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitByCellScalarFilter_PassAllPointsOn_09(HandleRef pThis);

	/// <summary>
	/// Specify if input points array must be passed to output blocks. If so,
	/// filter processing is faster but outblocks will contains more points than
	/// what is needed by the cells it owns. If not, a new points array is created
	/// for every block and it will only contains points for copied cells.
	/// Note that this function is only possible for PointSet datasets.
	/// The default is true.
	/// </summary>
	public virtual void PassAllPointsOn()
	{
		vtkSplitByCellScalarFilter_PassAllPointsOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitByCellScalarFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplitByCellScalarFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSplitByCellScalarFilter vtkSplitByCellScalarFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitByCellScalarFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSplitByCellScalarFilter2 = (vtkSplitByCellScalarFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSplitByCellScalarFilter2.Register(null);
			}
		}
		return vtkSplitByCellScalarFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitByCellScalarFilter_SetPassAllPoints_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if input points array must be passed to output blocks. If so,
	/// filter processing is faster but outblocks will contains more points than
	/// what is needed by the cells it owns. If not, a new points array is created
	/// for every block and it will only contains points for copied cells.
	/// Note that this function is only possible for PointSet datasets.
	/// The default is true.
	/// </summary>
	public virtual void SetPassAllPoints(bool _arg)
	{
		vtkSplitByCellScalarFilter_SetPassAllPoints_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
