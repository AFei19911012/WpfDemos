using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSelectedFrustum
/// </summary>
/// <remarks>
///    Returns the portion of the input dataset that
/// lies within a selection frustum.
///
///
/// This class intersects the input DataSet with a frustum and determines which
/// cells and points lie within the frustum. The frustum is defined with a
/// vtkPlanes containing six cutting planes. The output is a DataSet that is
/// either a shallow copy of the input dataset with two new "vtkInsidedness"
/// attribute arrays, or a completely new UnstructuredGrid that contains only
/// the cells and points of the input that are inside the frustum. The
/// PreserveTopology flag controls which occurs. When PreserveTopology is off
/// this filter adds a scalar array called vtkOriginalCellIds that says what
/// input cell produced each output cell. This is an example of a Pedigree ID
/// which helps to trace back results.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractGeometry, vtkAreaPicker, vtkExtractSelection, vtkSelection
/// </seealso>
public class vtkExtractSelectedFrustum : vtkExtractSelectionBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedFrustum";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSelectedFrustum()
	{
		MRClassNameKey = "class vtkExtractSelectedFrustum";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedFrustum"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSelectedFrustum(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedFrustum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedFrustum New()
	{
		vtkExtractSelectedFrustum result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedFrustum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractSelectedFrustum()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractSelectedFrustum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractSelectedFrustum_CreateFrustum_01(HandleRef pThis, IntPtr vertices);

	/// <summary>
	/// Given eight vertices, creates a frustum.
	/// each pt is x,y,z,1
	/// in the following order
	/// near lower left, far lower left
	/// near upper left, far upper left
	/// near lower right, far lower right
	/// near upper right, far upper right
	/// </summary>
	public void CreateFrustum(IntPtr vertices)
	{
		vtkExtractSelectedFrustum_CreateFrustum_01(GetCppThis(), vertices);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedFrustum_GetClipPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return eight points that define the selection frustum. Valid if
	/// create Frustum was used, invalid if SetFrustum was.
	/// </summary>
	public virtual vtkPoints GetClipPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedFrustum_GetClipPoints_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_GetContainingCells_03(HandleRef pThis);

	/// <summary>
	/// Sets/gets the intersection test type. Only meaningful when fieldType is
	/// vtkSelection::POINT
	/// </summary>
	public virtual int GetContainingCells()
	{
		return vtkExtractSelectedFrustum_GetContainingCells_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_GetFieldType_04(HandleRef pThis);

	/// <summary>
	/// Sets/gets the intersection test type.
	/// </summary>
	public virtual int GetFieldType()
	{
		return vtkExtractSelectedFrustum_GetFieldType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedFrustum_GetFrustum_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the selection frustum. The planes object must contain six planes.
	/// </summary>
	public virtual vtkPlanes GetFrustum()
	{
		vtkPlanes vtkPlanes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedFrustum_GetFrustum_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlanes2 = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlanes2.Register(null);
			}
		}
		return vtkPlanes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_GetInsideOut_06(HandleRef pThis);

	/// <summary>
	/// When on, extracts cells outside the frustum instead of inside.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkExtractSelectedFrustum_GetInsideOut_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExtractSelectedFrustum_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the Frustum
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractSelectedFrustum_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_GetShowBounds_10(HandleRef pThis);

	/// <summary>
	/// When On, this returns an unstructured grid that outlines selection area.
	/// Off is the default.
	/// </summary>
	public virtual int GetShowBounds()
	{
		return vtkExtractSelectedFrustum_GetShowBounds_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_InsideOutOff_11(HandleRef pThis);

	/// <summary>
	/// When on, extracts cells outside the frustum instead of inside.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkExtractSelectedFrustum_InsideOutOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_InsideOutOn_12(HandleRef pThis);

	/// <summary>
	/// When on, extracts cells outside the frustum instead of inside.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkExtractSelectedFrustum_InsideOutOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSelectedFrustum_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSelectedFrustum_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedFrustum_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractSelectedFrustum NewInstance()
	{
		vtkExtractSelectedFrustum result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedFrustum_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedFrustum_OverallBoundsTest_17(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Does a quick test on the AABBox defined by the bounds.
	/// </summary>
	public int OverallBoundsTest(IntPtr bounds)
	{
		return vtkExtractSelectedFrustum_OverallBoundsTest_17(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedFrustum_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedFrustum SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSelectedFrustum vtkExtractSelectedFrustum2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedFrustum_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelectedFrustum2 = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelectedFrustum2.Register(null);
			}
		}
		return vtkExtractSelectedFrustum2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_SetContainingCells_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets/gets the intersection test type. Only meaningful when fieldType is
	/// vtkSelection::POINT
	/// </summary>
	public virtual void SetContainingCells(int _arg)
	{
		vtkExtractSelectedFrustum_SetContainingCells_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_SetFieldType_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets/gets the intersection test type.
	/// </summary>
	public virtual void SetFieldType(int _arg)
	{
		vtkExtractSelectedFrustum_SetFieldType_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_SetFrustum_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the selection frustum. The planes object must contain six planes.
	/// </summary>
	public virtual void SetFrustum(vtkPlanes arg0)
	{
		vtkExtractSelectedFrustum_SetFrustum_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_SetInsideOut_22(HandleRef pThis, int _arg);

	/// <summary>
	/// When on, extracts cells outside the frustum instead of inside.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkExtractSelectedFrustum_SetInsideOut_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_SetShowBounds_23(HandleRef pThis, int _arg);

	/// <summary>
	/// When On, this returns an unstructured grid that outlines selection area.
	/// Off is the default.
	/// </summary>
	public virtual void SetShowBounds(int _arg)
	{
		vtkExtractSelectedFrustum_SetShowBounds_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_ShowBoundsOff_24(HandleRef pThis);

	/// <summary>
	/// When On, this returns an unstructured grid that outlines selection area.
	/// Off is the default.
	/// </summary>
	public virtual void ShowBoundsOff()
	{
		vtkExtractSelectedFrustum_ShowBoundsOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedFrustum_ShowBoundsOn_25(HandleRef pThis);

	/// <summary>
	/// When On, this returns an unstructured grid that outlines selection area.
	/// Off is the default.
	/// </summary>
	public virtual void ShowBoundsOn()
	{
		vtkExtractSelectedFrustum_ShowBoundsOn_25(GetCppThis());
	}
}
