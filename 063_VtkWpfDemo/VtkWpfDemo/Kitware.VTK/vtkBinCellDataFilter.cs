using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBinCellDataFilter
/// </summary>
/// <remarks>
///    bin source cell data into input cells.
///
/// vtkBinCellDataFilter takes a source mesh containing scalar cell data, an
/// input mesh and a set of bin values and bins the source mesh's scalar cell
/// data into the cells of the input mesh. The resulting output mesh is identical
/// to the input mesh, with an additional cell data field, with tuple size equal
/// to the number of bins + 1, that represents a histogram of the cell data
/// values for all of the source cells whose centroid lie within the input cell.
///
/// This filter is useful for analyzing the efficacy of an input mesh's ability
/// to represent the cell data of the source mesh.
/// </remarks>
public class vtkBinCellDataFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Set/get which component of the scalar array to bin; defaults to 0.
	/// </summary>
	public enum CellOverlapCriterion
	{
		/// <summary>enum member</summary>
		CELL_CENTROID,
		/// <summary>enum member</summary>
		CELL_POINTS
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBinCellDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBinCellDataFilter()
	{
		MRClassNameKey = "class vtkBinCellDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBinCellDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBinCellDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with initial range (VTK_DOUBLE_MIN, VTK_DOUBLE_MAX) and
	/// a single bin.
	/// </summary>
	public new static vtkBinCellDataFilter New()
	{
		vtkBinCellDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinCellDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBinCellDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with initial range (VTK_DOUBLE_MIN, VTK_DOUBLE_MAX) and
	/// a single bin.
	/// </summary>
	public vtkBinCellDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBinCellDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBinCellDataFilter_ComputeToleranceOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field value is ignored.
	/// Off by default.
	/// </summary>
	public virtual void ComputeToleranceOff()
	{
		vtkBinCellDataFilter_ComputeToleranceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_ComputeToleranceOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field value is ignored.
	/// Off by default.
	/// </summary>
	public virtual void ComputeToleranceOn()
	{
		vtkBinCellDataFilter_ComputeToleranceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_GenerateValues_03(HandleRef pThis, int numBins, IntPtr range);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public void GenerateValues(int numBins, IntPtr range)
	{
		vtkBinCellDataFilter_GenerateValues_03(GetCppThis(), numBins, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_GenerateValues_04(HandleRef pThis, int numBins, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public void GenerateValues(int numBins, double rangeStart, double rangeEnd)
	{
		vtkBinCellDataFilter_GenerateValues_04(GetCppThis(), numBins, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_GetArrayComponent_05(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to bin; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkBinCellDataFilter_GetArrayComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_GetCellLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a spatial locator for speeding the search process. By
	/// default an instance of vtkStaticCellLocator is used.
	/// </summary>
	public virtual vtkAbstractCellLocator GetCellLocator()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinCellDataFilter_GetCellLocator_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLocator2 = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLocator2.Register(null);
			}
		}
		return vtkAbstractCellLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_GetCellOverlapMethod_07(HandleRef pThis);

	/// <summary>
	/// Set whether cell overlap is determined by source cell centroid or by source
	/// cell points.
	/// Centroid by default.
	/// </summary>
	public virtual int GetCellOverlapMethod()
	{
		return vtkBinCellDataFilter_GetCellOverlapMethod_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_GetCellOverlapMethodMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set whether cell overlap is determined by source cell centroid or by source
	/// cell points.
	/// Centroid by default.
	/// </summary>
	public virtual int GetCellOverlapMethodMaxValue()
	{
		return vtkBinCellDataFilter_GetCellOverlapMethodMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_GetCellOverlapMethodMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set whether cell overlap is determined by source cell centroid or by source
	/// cell points.
	/// Centroid by default.
	/// </summary>
	public virtual int GetCellOverlapMethodMinValue()
	{
		return vtkBinCellDataFilter_GetCellOverlapMethodMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBinCellDataFilter_GetComputeTolerance_10(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field value is ignored.
	/// Off by default.
	/// </summary>
	public virtual bool GetComputeTolerance()
	{
		return (vtkBinCellDataFilter_GetComputeTolerance_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBinCellDataFilter_GetNumberOfBins_11(HandleRef pThis);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public long GetNumberOfBins()
	{
		return vtkBinCellDataFilter_GetNumberOfBins_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBinCellDataFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBinCellDataFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBinCellDataFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBinCellDataFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_GetNumberOfNonzeroBinsArrayName_14(HandleRef pThis);

	/// <summary>
	/// Returns the name of the id array added to the output that holds the number
	/// of nonzero bins per cell.
	/// Set to "NumberOfNonzeroBins" by default.
	/// </summary>
	public virtual string GetNumberOfNonzeroBinsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkBinCellDataFilter_GetNumberOfNonzeroBinsArrayName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_GetSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the data set whose cells will be counted.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is used to determine how many source cells lie within
	/// each input cell.
	/// </summary>
	public vtkDataObject GetSource()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinCellDataFilter_GetSource_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_GetSpatialMatch_16(HandleRef pThis);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual int GetSpatialMatch()
	{
		return vtkBinCellDataFilter_GetSpatialMatch_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBinCellDataFilter_GetStoreNumberOfNonzeroBins_17(HandleRef pThis);

	/// <summary>
	/// Set whether to store the number of nonzero bins for each cell.
	/// On by default.
	/// </summary>
	public virtual bool GetStoreNumberOfNonzeroBins()
	{
		return (vtkBinCellDataFilter_GetStoreNumberOfNonzeroBins_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBinCellDataFilter_GetTolerance_18(HandleRef pThis);

	/// <summary>
	/// Set the tolerance used to compute whether a cell centroid in the
	/// source is in a cell of the input.  This value is only used
	/// if ComputeTolerance is off.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkBinCellDataFilter_GetTolerance_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBinCellDataFilter_GetValue_19(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkBinCellDataFilter_GetValue_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_GetValues_20(HandleRef pThis);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkBinCellDataFilter_GetValues_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_GetValues_21(HandleRef pThis, IntPtr binValues);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public void GetValues(IntPtr binValues)
	{
		vtkBinCellDataFilter_GetValues_21(GetCppThis(), binValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBinCellDataFilter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinCellDataFilter_IsTypeOf_23(string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBinCellDataFilter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new vtkBinCellDataFilter NewInstance()
	{
		vtkBinCellDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinCellDataFilter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBinCellDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinCellDataFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new static vtkBinCellDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkBinCellDataFilter vtkBinCellDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinCellDataFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBinCellDataFilter2 = (vtkBinCellDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBinCellDataFilter2.Register(null);
			}
		}
		return vtkBinCellDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetArrayComponent_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to bin; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkBinCellDataFilter_SetArrayComponent_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetCellLocator_28(HandleRef pThis, HandleRef cellLocator);

	/// <summary>
	/// Set/Get a spatial locator for speeding the search process. By
	/// default an instance of vtkStaticCellLocator is used.
	/// </summary>
	public virtual void SetCellLocator(vtkAbstractCellLocator cellLocator)
	{
		vtkBinCellDataFilter_SetCellLocator_28(GetCppThis(), cellLocator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetCellOverlapMethod_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether cell overlap is determined by source cell centroid or by source
	/// cell points.
	/// Centroid by default.
	/// </summary>
	public virtual void SetCellOverlapMethod(int _arg)
	{
		vtkBinCellDataFilter_SetCellOverlapMethod_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetComputeTolerance_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field value is ignored.
	/// Off by default.
	/// </summary>
	public virtual void SetComputeTolerance(bool _arg)
	{
		vtkBinCellDataFilter_SetComputeTolerance_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetNumberOfBins_31(HandleRef pThis, int numBins);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public void SetNumberOfBins(int numBins)
	{
		vtkBinCellDataFilter_SetNumberOfBins_31(GetCppThis(), numBins);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetNumberOfNonzeroBinsArrayName_32(HandleRef pThis, string _arg);

	/// <summary>
	/// Returns the name of the id array added to the output that holds the number
	/// of nonzero bins per cell.
	/// Set to "NumberOfNonzeroBins" by default.
	/// </summary>
	public virtual void SetNumberOfNonzeroBinsArrayName(string _arg)
	{
		vtkBinCellDataFilter_SetNumberOfNonzeroBinsArrayName_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetSourceConnection_33(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the data set whose cells will be counted.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is used to determine how many source cells lie within
	/// each input cell.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkBinCellDataFilter_SetSourceConnection_33(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetSourceData_34(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the data set whose cells will be counted.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is used to determine how many source cells lie within
	/// each input cell.
	/// </summary>
	public void SetSourceData(vtkDataObject source)
	{
		vtkBinCellDataFilter_SetSourceData_34(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetSpatialMatch_35(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual void SetSpatialMatch(int _arg)
	{
		vtkBinCellDataFilter_SetSpatialMatch_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetStoreNumberOfNonzeroBins_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to store the number of nonzero bins for each cell.
	/// On by default.
	/// </summary>
	public virtual void SetStoreNumberOfNonzeroBins(bool _arg)
	{
		vtkBinCellDataFilter_SetStoreNumberOfNonzeroBins_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetTolerance_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance used to compute whether a cell centroid in the
	/// source is in a cell of the input.  This value is only used
	/// if ComputeTolerance is off.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkBinCellDataFilter_SetTolerance_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SetValue_38(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set / get bin values.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkBinCellDataFilter_SetValue_38(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SpatialMatchOff_39(HandleRef pThis);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual void SpatialMatchOff()
	{
		vtkBinCellDataFilter_SpatialMatchOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_SpatialMatchOn_40(HandleRef pThis);

	/// <summary>
	/// This flag is used only when a piece is requested to update.  By default
	/// the flag is off.  Because no spatial correspondence between input pieces
	/// and source pieces is known, all of the source has to be requested no
	/// matter what piece of the output is requested.  When there is a spatial
	/// correspondence, the user/application can set this flag.  This hint allows
	/// the breakup of the probe operation to be much more efficient.  When piece
	/// m of n is requested for update by the user, then only n of m needs to
	/// be requested of the source.
	/// </summary>
	public virtual void SpatialMatchOn()
	{
		vtkBinCellDataFilter_SpatialMatchOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOff_41(HandleRef pThis);

	/// <summary>
	/// Set whether to store the number of nonzero bins for each cell.
	/// On by default.
	/// </summary>
	public virtual void StoreNumberOfNonzeroBinsOff()
	{
		vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOn_42(HandleRef pThis);

	/// <summary>
	/// Set whether to store the number of nonzero bins for each cell.
	/// On by default.
	/// </summary>
	public virtual void StoreNumberOfNonzeroBinsOn()
	{
		vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOn_42(GetCppThis());
	}
}
