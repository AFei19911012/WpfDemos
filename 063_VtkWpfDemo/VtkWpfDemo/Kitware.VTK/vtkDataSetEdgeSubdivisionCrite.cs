using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataSetEdgeSubdivisionCriterion
/// </summary>
/// <remarks>
///    a subclass of vtkEdgeSubdivisionCriterion for vtkDataSet objects.
///
///
/// This is a subclass of vtkEdgeSubdivisionCriterion that is used for
/// tessellating cells of a vtkDataSet, particularly nonlinear
/// cells.
///
/// It provides functions for setting the current cell being tessellated and a
/// convenience routine, \a EvaluateFields() to evaluate field values at a
/// point. You should call \a EvaluateFields() from inside \a EvaluateLocationAndFields()
/// whenever the result of \a EvaluateLocationAndFields() will be true. Otherwise, do
/// not call \a EvaluateFields() as the midpoint is about to be discarded.
/// (&lt;i&gt;Implementor's note&lt;/i&gt;: This isn't true if UGLY_ASPECT_RATIO_HACK
/// has been defined. But in that case, we don't want the exact field values;
/// we need the linearly interpolated ones at the midpoint for continuity.)
///
/// </remarks>
/// <seealso>
///
/// vtkEdgeSubdivisionCriterion
/// </seealso>
public class vtkDataSetEdgeSubdivisionCriterion : vtkEdgeSubdivisionCriterion
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetEdgeSubdivisionCriterion";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSetEdgeSubdivisionCriterion()
	{
		MRClassNameKey = "class vtkDataSetEdgeSubdivisionCriterion";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetEdgeSubdivisionCriterion"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSetEdgeSubdivisionCriterion(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataSetEdgeSubdivisionCriterion New()
	{
		vtkDataSetEdgeSubdivisionCriterion result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataSetEdgeSubdivisionCriterion()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataSetEdgeSubdivisionCriterion_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_EvaluateCellDataField_01(HandleRef pThis, IntPtr result, IntPtr weights, int field);

	/// <summary>
	/// Evaluate either a cell or nodal field.
	/// This exists because of the funky way that Exodus data will be handled.
	/// Sure, it's a hack, but what are ya gonna do?
	/// </summary>
	public void EvaluateCellDataField(IntPtr result, IntPtr weights, int field)
	{
		vtkDataSetEdgeSubdivisionCriterion_EvaluateCellDataField_01(GetCppThis(), result, weights, field);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_EvaluateFields_02(HandleRef pThis, IntPtr vertex, IntPtr weights, int field_start);

	/// <summary>
	/// Evaluate all of the fields that should be output with the
	/// given \a vertex and store them just past the parametric coordinates
	/// of \a vertex, at the offsets given by
	/// \p vtkEdgeSubdivisionCriterion::GetFieldOffsets() plus \a field_start.
	/// \a field_start contains the number of world-space coordinates (always 3)
	/// plus the embedding dimension (the size of the parameter-space in which
	/// the cell is embedded). It will range between 3 and 6, inclusive.
	///
	/// You must have called SetCellId() before calling this routine or there
	/// will not be a mesh over which to evaluate the fields.
	///
	/// You must have called \p vtkEdgeSubdivisionCriterion::PassDefaultFields()
	/// or \p vtkEdgeSubdivisionCriterion::PassField() or there will be no fields
	/// defined for the output vertex.
	///
	/// This routine is public and returns its input argument so that it
	/// may be used as an argument to
	/// \p vtkStreamingTessellator::AdaptivelySamplekFacet():
	/// @verbatim
	/// vtkStreamingTessellator* t = vtkStreamingTessellator::New();
	/// vtkEdgeSubdivisionCriterion* s;
	/// ...
	/// t-&gt;AdaptivelySample1Facet( s-&gt;EvaluateFields( p0 ), s-&gt;EvaluateFields( p1 ) );
	/// ...
	/// @endverbatim
	/// Although this will work, using \p EvaluateFields() in this manner
	/// should be avoided. It's much more efficient to fetch the corner values
	/// for each attribute and copy them into \a p0, \a p1, ... as opposed to
	/// performing shape function evaluations. The only case where you wouldn't
	/// want to do this is when the field you are interpolating is discontinuous
	/// at cell borders, such as with a discontinuous galerkin method or when
	/// all the Gauss points for quadrature are interior to the cell.
	///
	/// The final argument, \a weights, is the array of weights to apply to each
	/// point's data when interpolating the field. This is returned by
	/// \a vtkCell::EvaluateLocation() when evaluating the geometry.
	/// </summary>
	public IntPtr EvaluateFields(IntPtr vertex, IntPtr weights, int field_start)
	{
		return vtkDataSetEdgeSubdivisionCriterion_EvaluateFields_02(GetCppThis(), vertex, weights, field_start);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSetEdgeSubdivisionCriterion_EvaluateLocationAndFields_03(HandleRef pThis, IntPtr midpt, int field_start);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override bool EvaluateLocationAndFields(IntPtr midpt, int field_start)
	{
		return (vtkDataSetEdgeSubdivisionCriterion_EvaluateLocationAndFields_03(GetCppThis(), midpt, field_start) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_EvaluatePointDataField_04(HandleRef pThis, IntPtr result, IntPtr weights, int field);

	/// <summary>
	/// Evaluate either a cell or nodal field.
	/// This exists because of the funky way that Exodus data will be handled.
	/// Sure, it's a hack, but what are ya gonna do?
	/// </summary>
	public void EvaluatePointDataField(IntPtr result, IntPtr weights, int field)
	{
		vtkDataSetEdgeSubdivisionCriterion_EvaluatePointDataField_04(GetCppThis(), result, weights, field);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetEdgeSubdivisionCriterion_GetActiveFieldCriteria_05(HandleRef pThis);

	/// <summary>
	/// Return a bitfield specifying which FieldError2 criteria are positive (i.e., actively
	/// used to decide edge subdivisions).
	/// This is stored as separate state to make subdivisions go faster.
	/// </summary>
	public virtual int GetActiveFieldCriteria()
	{
		return vtkDataSetEdgeSubdivisionCriterion_GetActiveFieldCriteria_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_GetCell_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCell GetCell()
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion_GetCell_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetCellId_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetCellId()
	{
		return vtkDataSetEdgeSubdivisionCriterion_GetCellId_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataSetEdgeSubdivisionCriterion_GetChordError2_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the square of the allowable chord error at any edge's midpoint.
	/// This value is used by EvaluateLocationAndFields.
	/// </summary>
	public virtual double GetChordError2()
	{
		return vtkDataSetEdgeSubdivisionCriterion_GetChordError2_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataSetEdgeSubdivisionCriterion_GetFieldError2_09(HandleRef pThis, int s);

	/// <summary>
	/// Get/Set the square of the allowable error magnitude for the
	/// scalar field \a s at any edge's midpoint.
	/// A value less than or equal to 0 indicates that the field
	/// should not be used as a criterion for subdivision.
	/// </summary>
	public double GetFieldError2(int s)
	{
		return vtkDataSetEdgeSubdivisionCriterion_GetFieldError2_09(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_GetMesh_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataSet GetMesh()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion_GetMesh_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetEdgeSubdivisionCriterion_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataSetEdgeSubdivisionCriterion_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetEdgeSubdivisionCriterion_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataSetEdgeSubdivisionCriterion_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataSetEdgeSubdivisionCriterion NewInstance()
	{
		vtkDataSetEdgeSubdivisionCriterion result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_ResetFieldError2_17(HandleRef pThis);

	/// <summary>
	/// Tell the subdivider not to use any field values as subdivision criteria.
	/// Effectively calls SetFieldError2( a, -1. ) for all fields.
	/// </summary>
	public virtual void ResetFieldError2()
	{
		vtkDataSetEdgeSubdivisionCriterion_ResetFieldError2_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataSetEdgeSubdivisionCriterion SafeDownCast(vtkObjectBase o)
	{
		vtkDataSetEdgeSubdivisionCriterion vtkDataSetEdgeSubdivisionCriterion2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetEdgeSubdivisionCriterion2 = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetEdgeSubdivisionCriterion2.Register(null);
			}
		}
		return vtkDataSetEdgeSubdivisionCriterion2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetCellId_19(HandleRef pThis, long cell);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetCellId(long cell)
	{
		vtkDataSetEdgeSubdivisionCriterion_SetCellId_19(GetCppThis(), cell);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetChordError2_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the square of the allowable chord error at any edge's midpoint.
	/// This value is used by EvaluateLocationAndFields.
	/// </summary>
	public virtual void SetChordError2(double _arg)
	{
		vtkDataSetEdgeSubdivisionCriterion_SetChordError2_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetFieldError2_21(HandleRef pThis, int s, double err);

	/// <summary>
	/// Get/Set the square of the allowable error magnitude for the
	/// scalar field \a s at any edge's midpoint.
	/// A value less than or equal to 0 indicates that the field
	/// should not be used as a criterion for subdivision.
	/// </summary>
	public virtual void SetFieldError2(int s, double err)
	{
		vtkDataSetEdgeSubdivisionCriterion_SetFieldError2_21(GetCppThis(), s, err);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetMesh_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetMesh(vtkDataSet arg0)
	{
		vtkDataSetEdgeSubdivisionCriterion_SetMesh_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
