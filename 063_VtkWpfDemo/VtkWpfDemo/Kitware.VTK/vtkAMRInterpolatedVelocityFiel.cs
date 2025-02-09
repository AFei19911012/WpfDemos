using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRInterpolatedVelocityField
/// </summary>
/// <remarks>
///    A concrete class for obtaining
///  the interpolated velocity values at a point in AMR data.
///
/// The main functionality supported here is the point location inside
/// vtkOverlappingAMR data set.
/// </remarks>
public class vtkAMRInterpolatedVelocityField : vtkAbstractInterpolatedVelocityField
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkAMRInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static vtkAMRInterpolatedVelocityField New()
	{
		vtkAMRInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public vtkAMRInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInterpolatedVelocityField_CopyParameters_01(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy essential parameters between instances of this class. This
	/// generally is used to copy from instance prototype to another, or to copy
	/// interpolators between thread instances.  Sub-classes can contribute to
	/// the parameter copying process via chaining.
	/// </summary>
	public override void CopyParameters(vtkAbstractInterpolatedVelocityField from)
	{
		vtkAMRInterpolatedVelocityField_CopyParameters_01(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInterpolatedVelocityField_FindGrid_02(IntPtr q, HandleRef amrds, ref uint level, ref uint gridId);

	/// <summary>
	/// Helper function to locator the grid within an AMR dataset.
	/// </summary>
	public static bool FindGrid(IntPtr q, vtkOverlappingAMR amrds, ref uint level, ref uint gridId)
	{
		return (vtkAMRInterpolatedVelocityField_FindGrid_02(q, amrds?.GetCppThis() ?? default(HandleRef), ref level, ref gridId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

	/// <summary>
	/// Evaluate the velocity field f at point p.
	/// If it succeeds, then both the last data set (this-&gt;LastDataSet) and
	/// the last data set location (this-&gt;LastLevel, this-&gt;LastId) will be
	/// set according to where p is found.  If it fails, either p is out of
	/// bound, in which case both the last data set and the last location
	/// will be invalid or, in a multi-process setting, p is inbound but not
	/// on the processor.  In the last case, the last data set location is
	/// still valid
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr f)
	{
		return vtkAMRInterpolatedVelocityField_FunctionValues_03(GetCppThis(), x, f);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInterpolatedVelocityField_GetAmrDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///
	/// Specify the AMR dataset to process.
	/// </summary>
	public virtual vtkOverlappingAMR GetAmrDataSet()
	{
		vtkOverlappingAMR vtkOverlappingAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInterpolatedVelocityField_GetAmrDataSet_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMR2 = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMR2.Register(null);
			}
		}
		return vtkOverlappingAMR2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInterpolatedVelocityField_GetLastDataSetLocation_05(HandleRef pThis, ref uint level, ref uint id);

	/// <summary>
	/// Methods to support local caching while searching for AMR datasets.
	/// </summary>
	public bool GetLastDataSetLocation(ref uint level, ref uint id)
	{
		return (vtkAMRInterpolatedVelocityField_GetLastDataSetLocation_05(GetCppThis(), ref level, ref id) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInterpolatedVelocityField_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRInterpolatedVelocityField_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInterpolatedVelocityField_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRInterpolatedVelocityField_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInterpolatedVelocityField_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new vtkAMRInterpolatedVelocityField NewInstance()
	{
		vtkAMRInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInterpolatedVelocityField_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInterpolatedVelocityField_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static vtkAMRInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkAMRInterpolatedVelocityField vtkAMRInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInterpolatedVelocityField_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRInterpolatedVelocityField2 = (vtkAMRInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkAMRInterpolatedVelocityField2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInterpolatedVelocityField_SetAMRData_13(HandleRef pThis, HandleRef amr);

	/// <summary>
	///
	/// Specify the AMR dataset to process.
	/// </summary>
	public void SetAMRData(vtkOverlappingAMR amr)
	{
		vtkAMRInterpolatedVelocityField_SetAMRData_13(GetCppThis(), amr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInterpolatedVelocityField_SetAmrDataSet_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///
	/// Specify the AMR dataset to process.
	/// </summary>
	public virtual void SetAmrDataSet(vtkOverlappingAMR arg0)
	{
		vtkAMRInterpolatedVelocityField_SetAmrDataSet_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInterpolatedVelocityField_SetLastCellId_15(HandleRef pThis, long c);

	/// <summary>
	/// Set the cell id cached by the last evaluation.
	/// </summary>
	public override void SetLastCellId(long c)
	{
		vtkAMRInterpolatedVelocityField_SetLastCellId_15(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInterpolatedVelocityField_SetLastCellId_16(HandleRef pThis, long c, int dataindex);

	/// <summary>
	/// Methods to support local caching while searching for AMR datasets.
	/// </summary>
	public override void SetLastCellId(long c, int dataindex)
	{
		vtkAMRInterpolatedVelocityField_SetLastCellId_16(GetCppThis(), c, dataindex);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInterpolatedVelocityField_SetLastDataSet_17(HandleRef pThis, int level, int id);

	/// <summary>
	/// Methods to support local caching while searching for AMR datasets.
	/// </summary>
	public bool SetLastDataSet(int level, int id)
	{
		return (vtkAMRInterpolatedVelocityField_SetLastDataSet_17(GetCppThis(), level, id) != 0) ? true : false;
	}
}
