using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAdjacencyMatrixToEdgeTable
///
///
/// Treats a dense 2-way array of doubles as an adacency matrix and converts it into a
/// vtkTable suitable for use as an edge table with vtkTableToGraph.
///
/// @par Thanks:
/// </summary>
/// <seealso>
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkAdjacencyMatrixToEdgeTable : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAdjacencyMatrixToEdgeTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAdjacencyMatrixToEdgeTable()
	{
		MRClassNameKey = "class vtkAdjacencyMatrixToEdgeTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdjacencyMatrixToEdgeTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAdjacencyMatrixToEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAdjacencyMatrixToEdgeTable New()
	{
		vtkAdjacencyMatrixToEdgeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAdjacencyMatrixToEdgeTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAdjacencyMatrixToEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdjacencyMatrixToEdgeTable_GetMinimumCount_01(HandleRef pThis);

	/// <summary>
	/// Specifies the minimum number of adjacent edges to include for each source vertex.
	/// Default: 0
	/// </summary>
	public virtual long GetMinimumCount()
	{
		return vtkAdjacencyMatrixToEdgeTable_GetMinimumCount_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdjacencyMatrixToEdgeTable_GetMinimumThreshold_02(HandleRef pThis);

	/// <summary>
	/// Specifies a minimum threshold that an edge weight must exceed to be included in
	/// the output.
	/// Default: 0.5
	/// </summary>
	public virtual double GetMinimumThreshold()
	{
		return vtkAdjacencyMatrixToEdgeTable_GetMinimumThreshold_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAdjacencyMatrixToEdgeTable_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdjacencyMatrixToEdgeTable_GetSourceDimension_05(HandleRef pThis);

	/// <summary>
	/// Specifies whether rows or columns become the "source" in the output edge table.
	/// 0 = rows, 1 = columns.  Default: 0
	/// </summary>
	public virtual long GetSourceDimension()
	{
		return vtkAdjacencyMatrixToEdgeTable_GetSourceDimension_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_GetValueArrayName_06(HandleRef pThis);

	/// <summary>
	/// Controls the name of the output table column that contains edge weights.
	/// Default: "value"
	/// </summary>
	public virtual string GetValueArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAdjacencyMatrixToEdgeTable_GetValueArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdjacencyMatrixToEdgeTable_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAdjacencyMatrixToEdgeTable_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdjacencyMatrixToEdgeTable_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAdjacencyMatrixToEdgeTable_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAdjacencyMatrixToEdgeTable NewInstance()
	{
		vtkAdjacencyMatrixToEdgeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAdjacencyMatrixToEdgeTable SafeDownCast(vtkObjectBase o)
	{
		vtkAdjacencyMatrixToEdgeTable vtkAdjacencyMatrixToEdgeTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAdjacencyMatrixToEdgeTable2 = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAdjacencyMatrixToEdgeTable2.Register(null);
			}
		}
		return vtkAdjacencyMatrixToEdgeTable2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdjacencyMatrixToEdgeTable_SetMinimumCount_12(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies the minimum number of adjacent edges to include for each source vertex.
	/// Default: 0
	/// </summary>
	public virtual void SetMinimumCount(long _arg)
	{
		vtkAdjacencyMatrixToEdgeTable_SetMinimumCount_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdjacencyMatrixToEdgeTable_SetMinimumThreshold_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Specifies a minimum threshold that an edge weight must exceed to be included in
	/// the output.
	/// Default: 0.5
	/// </summary>
	public virtual void SetMinimumThreshold(double _arg)
	{
		vtkAdjacencyMatrixToEdgeTable_SetMinimumThreshold_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdjacencyMatrixToEdgeTable_SetSourceDimension_14(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies whether rows or columns become the "source" in the output edge table.
	/// 0 = rows, 1 = columns.  Default: 0
	/// </summary>
	public virtual void SetSourceDimension(long _arg)
	{
		vtkAdjacencyMatrixToEdgeTable_SetSourceDimension_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdjacencyMatrixToEdgeTable_SetValueArrayName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Controls the name of the output table column that contains edge weights.
	/// Default: "value"
	/// </summary>
	public virtual void SetValueArrayName(string _arg)
	{
		vtkAdjacencyMatrixToEdgeTable_SetValueArrayName_15(GetCppThis(), _arg);
	}
}
