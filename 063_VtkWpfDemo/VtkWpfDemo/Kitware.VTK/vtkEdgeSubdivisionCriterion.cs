using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEdgeSubdivisionCriterion
/// </summary>
/// <remarks>
///    how to decide whether a linear approximation to nonlinear geometry or field should be
/// subdivided
///
///
/// Descendants of this abstract class are used to decide whether a
/// piecewise linear approximation (triangles, lines, ... ) to some
/// nonlinear geometry should be subdivided. This decision may be
/// based on an absolute error metric (chord error) or on some
/// view-dependent metric (chord error compared to device resolution)
/// or on some abstract metric (color error). Or anything else, really.
/// Just so long as you implement the EvaluateLocationAndFields member, all will
/// be well.
///
/// </remarks>
/// <seealso>
///
/// vtkDataSetSubdivisionAlgorithm vtkStreamingTessellator
/// </seealso>
public abstract class vtkEdgeSubdivisionCriterion : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeSubdivisionCriterion";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEdgeSubdivisionCriterion()
	{
		MRClassNameKey = "class vtkEdgeSubdivisionCriterion";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeSubdivisionCriterion"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEdgeSubdivisionCriterion(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern byte vtkEdgeSubdivisionCriterion_DontPassField_01(HandleRef pThis, int sourceId, HandleRef t);

	/// <summary>
	/// This does the opposite of \p PassField(); it removes a field from
	/// the output (assuming the field was set to be passed).
	/// Returns true if any action was taken, false otherwise.
	/// </summary>
	public virtual bool DontPassField(int sourceId, vtkStreamingTessellator t)
	{
		return (vtkEdgeSubdivisionCriterion_DontPassField_01(GetCppThis(), sourceId, t?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEdgeSubdivisionCriterion_EvaluateLocationAndFields_02(HandleRef pThis, IntPtr p1, int field_start);

	/// <summary>
	/// You must implement this member function in a subclass.
	/// It will be called by \p vtkStreamingTessellator for each
	/// edge in each primitive that vtkStreamingTessellator generates.
	/// </summary>
	public virtual bool EvaluateLocationAndFields(IntPtr p1, int field_start)
	{
		return (vtkEdgeSubdivisionCriterion_EvaluateLocationAndFields_02(GetCppThis(), p1, field_start) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeSubdivisionCriterion_GetFieldIds_03(HandleRef pThis);

	/// <summary>
	/// Return the map from output field id to input field ids.
	/// That is, field \a i of any output vertex from vtkStreamingTessellator
	/// will be associated with \p GetFieldIds()[\a i] on the input mesh.
	/// </summary>
	public IntPtr GetFieldIds()
	{
		return vtkEdgeSubdivisionCriterion_GetFieldIds_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeSubdivisionCriterion_GetFieldOffsets_04(HandleRef pThis);

	/// <summary>
	/// Return the offset into an output vertex array of all fields.
	/// That is, field \a i of any output vertex, \a p, from vtkStreamingTessellator
	/// will have its first entry at \a p[\p GetFieldOffsets()[\a i] ] .
	/// </summary>
	public IntPtr GetFieldOffsets()
	{
		return vtkEdgeSubdivisionCriterion_GetFieldOffsets_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeSubdivisionCriterion_GetNumberOfFields_05(HandleRef pThis);

	/// <summary>
	/// Return the number of fields being evaluated at each output vertex.
	/// This is the length of the arrays returned by \p GetFieldIds() and
	/// \p GetFieldOffsets().
	/// </summary>
	public int GetNumberOfFields()
	{
		return vtkEdgeSubdivisionCriterion_GetNumberOfFields_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeSubdivisionCriterion_GetOutputField_08(HandleRef pThis, int fieldId);

	/// <summary>
	/// Return the output ID of an input field.
	/// Returns -1 if \a fieldId is not set to be passed to the output.
	/// </summary>
	public int GetOutputField(int fieldId)
	{
		return vtkEdgeSubdivisionCriterion_GetOutputField_08(GetCppThis(), fieldId);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeSubdivisionCriterion_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEdgeSubdivisionCriterion_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeSubdivisionCriterion_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEdgeSubdivisionCriterion_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeSubdivisionCriterion_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEdgeSubdivisionCriterion NewInstance()
	{
		vtkEdgeSubdivisionCriterion result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeSubdivisionCriterion_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeSubdivisionCriterion_PassField_12(HandleRef pThis, int sourceId, int sourceSize, HandleRef t);

	/// <summary>
	/// This is a helper routine called by \p PassFields() which
	/// you may also call directly; it adds \a sourceSize to the size of
	/// the output vertex field values. The offset of the \a sourceId
	/// field in the output vertex array is returned.
	/// -1 is returned if \a sourceSize would force the output to have more
	/// than \a vtkStreamingTessellator::MaxFieldSize field values per vertex.
	/// </summary>
	public virtual int PassField(int sourceId, int sourceSize, vtkStreamingTessellator t)
	{
		return vtkEdgeSubdivisionCriterion_PassField_12(GetCppThis(), sourceId, sourceSize, t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeSubdivisionCriterion_ResetFieldList_13(HandleRef pThis);

	/// <summary>
	/// Don't pass any field values in the vertex pointer.
	/// This is used to reset the list of fields to pass after a
	/// successful run of vtkStreamingTessellator.
	/// </summary>
	public virtual void ResetFieldList()
	{
		vtkEdgeSubdivisionCriterion_ResetFieldList_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeSubdivisionCriterion_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEdgeSubdivisionCriterion SafeDownCast(vtkObjectBase o)
	{
		vtkEdgeSubdivisionCriterion vtkEdgeSubdivisionCriterion2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeSubdivisionCriterion_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEdgeSubdivisionCriterion2 = (vtkEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEdgeSubdivisionCriterion2.Register(null);
			}
		}
		return vtkEdgeSubdivisionCriterion2;
	}
}
