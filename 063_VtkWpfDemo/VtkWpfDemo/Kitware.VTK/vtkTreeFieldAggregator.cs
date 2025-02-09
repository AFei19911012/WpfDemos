using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeFieldAggregator
/// </summary>
/// <remarks>
///    aggregate field values from the leaves up the tree
///
///
/// vtkTreeFieldAggregator may be used to assign sizes to all the vertices in the
/// tree, based on the sizes of the leaves.  The size of a vertex will equal
/// the sum of the sizes of the child vertices.  If you have a data array with
/// values for all leaves, you may specify that array, and the values will
/// be filled in for interior tree vertices.  If you do not yet have an array,
/// you may tell the filter to create a new array, assuming that the size
/// of each leaf vertex is 1.  You may optionally set a flag to first take the
/// log of all leaf values before aggregating.
/// </remarks>
public class vtkTreeFieldAggregator : vtkTreeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeFieldAggregator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeFieldAggregator()
	{
		MRClassNameKey = "class vtkTreeFieldAggregator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeFieldAggregator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeFieldAggregator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeFieldAggregator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeFieldAggregator New()
	{
		vtkTreeFieldAggregator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeFieldAggregator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeFieldAggregator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeFieldAggregator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTreeFieldAggregator_GetField_01(HandleRef pThis);

	/// <summary>
	/// The field to aggregate.  If this is a string array, the entries are converted to double.
	/// TODO: Remove this field and use the ArrayToProcess in vtkAlgorithm.
	/// </summary>
	public virtual string GetField()
	{
		return Marshal.PtrToStringAnsi(vtkTreeFieldAggregator_GetField_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeFieldAggregator_GetLeafVertexUnitSize_02(HandleRef pThis);

	/// <summary>
	/// If set, the algorithm will assume a size of 1 for each leaf vertex.
	/// </summary>
	public virtual bool GetLeafVertexUnitSize()
	{
		return (vtkTreeFieldAggregator_GetLeafVertexUnitSize_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeFieldAggregator_GetLogScale_03(HandleRef pThis);

	/// <summary>
	/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
	/// </summary>
	public virtual bool GetLogScale()
	{
		return (vtkTreeFieldAggregator_GetLogScale_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeFieldAggregator_GetMinValue_04(HandleRef pThis);

	/// <summary>
	/// If the value of the vertex is less than MinValue then consider it's value to be minVal.
	/// </summary>
	public virtual double GetMinValue()
	{
		return vtkTreeFieldAggregator_GetMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeFieldAggregator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeFieldAggregator_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeFieldAggregator_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeFieldAggregator_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeFieldAggregator_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeFieldAggregator_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeFieldAggregator_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeFieldAggregator_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_LeafVertexUnitSizeOff_09(HandleRef pThis);

	/// <summary>
	/// If set, the algorithm will assume a size of 1 for each leaf vertex.
	/// </summary>
	public virtual void LeafVertexUnitSizeOff()
	{
		vtkTreeFieldAggregator_LeafVertexUnitSizeOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_LeafVertexUnitSizeOn_10(HandleRef pThis);

	/// <summary>
	/// If set, the algorithm will assume a size of 1 for each leaf vertex.
	/// </summary>
	public virtual void LeafVertexUnitSizeOn()
	{
		vtkTreeFieldAggregator_LeafVertexUnitSizeOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_LogScaleOff_11(HandleRef pThis);

	/// <summary>
	/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
	/// </summary>
	public virtual void LogScaleOff()
	{
		vtkTreeFieldAggregator_LogScaleOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_LogScaleOn_12(HandleRef pThis);

	/// <summary>
	/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
	/// </summary>
	public virtual void LogScaleOn()
	{
		vtkTreeFieldAggregator_LogScaleOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeFieldAggregator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeFieldAggregator NewInstance()
	{
		vtkTreeFieldAggregator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeFieldAggregator_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeFieldAggregator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeFieldAggregator SafeDownCast(vtkObjectBase o)
	{
		vtkTreeFieldAggregator vtkTreeFieldAggregator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeFieldAggregator_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeFieldAggregator2 = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeFieldAggregator2.Register(null);
			}
		}
		return vtkTreeFieldAggregator2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_SetField_16(HandleRef pThis, string _arg);

	/// <summary>
	/// The field to aggregate.  If this is a string array, the entries are converted to double.
	/// TODO: Remove this field and use the ArrayToProcess in vtkAlgorithm.
	/// </summary>
	public virtual void SetField(string _arg)
	{
		vtkTreeFieldAggregator_SetField_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_SetLeafVertexUnitSize_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set, the algorithm will assume a size of 1 for each leaf vertex.
	/// </summary>
	public virtual void SetLeafVertexUnitSize(bool _arg)
	{
		vtkTreeFieldAggregator_SetLeafVertexUnitSize_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_SetLogScale_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
	/// </summary>
	public virtual void SetLogScale(bool _arg)
	{
		vtkTreeFieldAggregator_SetLogScale_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeFieldAggregator_SetMinValue_19(HandleRef pThis, double _arg);

	/// <summary>
	/// If the value of the vertex is less than MinValue then consider it's value to be minVal.
	/// </summary>
	public virtual void SetMinValue(double _arg)
	{
		vtkTreeFieldAggregator_SetMinValue_19(GetCppThis(), _arg);
	}
}
