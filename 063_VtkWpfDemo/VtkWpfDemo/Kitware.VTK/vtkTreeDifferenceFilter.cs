using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeDifferenceFilter
/// </summary>
/// <remarks>
///    compare two trees
///
///
/// vtkTreeDifferenceFilter compares two trees by analyzing a vtkDoubleArray.
/// Each tree must have a copy of this array.  A user of this filter should
/// call SetComparisonArrayName to specify the array that should be used as
/// the basis of coparison.  This array can either be part of the trees'
/// EdgeData or VertexData.
///
/// </remarks>
public class vtkTreeDifferenceFilter : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeDifferenceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeDifferenceFilter()
	{
		MRClassNameKey = "class vtkTreeDifferenceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeDifferenceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeDifferenceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeDifferenceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeDifferenceFilter New()
	{
		vtkTreeDifferenceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeDifferenceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeDifferenceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeDifferenceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeDifferenceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkTreeDifferenceFilter_GetComparisonArrayIsVertexData_01(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison array is within the trees' vertex data or
	/// not.  By default, we assume that the array to compare is within the trees'
	/// EdgeData().
	/// </summary>
	public virtual bool GetComparisonArrayIsVertexData()
	{
		return (vtkTreeDifferenceFilter_GetComparisonArrayIsVertexData_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeDifferenceFilter_GetComparisonArrayName_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the array that we're comparing between the two trees.
	/// The named array must be a vtkDoubleArray.
	/// </summary>
	public virtual string GetComparisonArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeDifferenceFilter_GetComparisonArrayName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeDifferenceFilter_GetIdArrayName_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the identifier array in the trees' VertexData.
	/// This array is used to find corresponding vertices in the two trees.
	/// If this array name is not set, then we assume that the vertices in
	/// the two trees to compare have corresponding vtkIdTypes.
	/// Otherwise, the named array must be a vtkStringArray.
	/// The identifier array does not necessarily have to specify a name for
	/// each vertex in the tree.  If some vertices are unnamed, then this
	/// filter will assign correspondence between ancestors of named vertices.
	/// </summary>
	public virtual string GetIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeDifferenceFilter_GetIdArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeDifferenceFilter_GetOutputArrayName_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of a new vtkDoubleArray that will contain the results of
	/// the comparison between the two trees.  This new array will be added to
	/// the input tree's VertexData or EdgeData, based on the value of
	/// ComparisonArrayIsVertexData.  If this method is not called, the new
	/// vtkDoubleArray will be named "difference" by default.
	/// </summary>
	public virtual string GetOutputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeDifferenceFilter_GetOutputArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeDifferenceFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeDifferenceFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeDifferenceFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeDifferenceFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeDifferenceFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeDifferenceFilter NewInstance()
	{
		vtkTreeDifferenceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeDifferenceFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeDifferenceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeDifferenceFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeDifferenceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTreeDifferenceFilter vtkTreeDifferenceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeDifferenceFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeDifferenceFilter2 = (vtkTreeDifferenceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeDifferenceFilter2.Register(null);
			}
		}
		return vtkTreeDifferenceFilter2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeDifferenceFilter_SetComparisonArrayIsVertexData_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether the comparison array is within the trees' vertex data or
	/// not.  By default, we assume that the array to compare is within the trees'
	/// EdgeData().
	/// </summary>
	public virtual void SetComparisonArrayIsVertexData(bool _arg)
	{
		vtkTreeDifferenceFilter_SetComparisonArrayIsVertexData_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeDifferenceFilter_SetComparisonArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the array that we're comparing between the two trees.
	/// The named array must be a vtkDoubleArray.
	/// </summary>
	public virtual void SetComparisonArrayName(string _arg)
	{
		vtkTreeDifferenceFilter_SetComparisonArrayName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeDifferenceFilter_SetIdArrayName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the identifier array in the trees' VertexData.
	/// This array is used to find corresponding vertices in the two trees.
	/// If this array name is not set, then we assume that the vertices in
	/// the two trees to compare have corresponding vtkIdTypes.
	/// Otherwise, the named array must be a vtkStringArray.
	/// The identifier array does not necessarily have to specify a name for
	/// each vertex in the tree.  If some vertices are unnamed, then this
	/// filter will assign correspondence between ancestors of named vertices.
	/// </summary>
	public virtual void SetIdArrayName(string _arg)
	{
		vtkTreeDifferenceFilter_SetIdArrayName_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeDifferenceFilter_SetOutputArrayName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of a new vtkDoubleArray that will contain the results of
	/// the comparison between the two trees.  This new array will be added to
	/// the input tree's VertexData or EdgeData, based on the value of
	/// ComparisonArrayIsVertexData.  If this method is not called, the new
	/// vtkDoubleArray will be named "difference" by default.
	/// </summary>
	public virtual void SetOutputArrayName(string _arg)
	{
		vtkTreeDifferenceFilter_SetOutputArrayName_15(GetCppThis(), _arg);
	}
}
