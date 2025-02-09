using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStrahlerMetric
/// </summary>
/// <remarks>
///    compute Strahler metric for a tree
///
/// The Strahler metric is a value assigned to each vertex of a
/// tree that characterizes the structural complexity of the
/// sub-tree rooted at that node.  The metric originated in the
/// study of river systems, but has been applied to other tree-
/// structured systes,  Details of the metric and the rationale
/// for using it in infovis can be found in:
///
/// Tree Visualization and Navigation Clues for Information
/// Visualization, I. Herman, M. Delest, and G. Melancon,
/// Computer Graphics Forum, Vol 17(2), Blackwell, 1998.
///
/// The input tree is copied to the output, but with a new array
/// added to the output vertex data.
///
/// @par Thanks:
/// Thanks to David Duke from the University of Leeds for providing this
/// implementation.
/// </remarks>
public class vtkStrahlerMetric : vtkTreeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStrahlerMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStrahlerMetric()
	{
		MRClassNameKey = "class vtkStrahlerMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStrahlerMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStrahlerMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStrahlerMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStrahlerMetric New()
	{
		vtkStrahlerMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStrahlerMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStrahlerMetric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStrahlerMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkStrahlerMetric_GetMaxStrahler_01(HandleRef pThis);

	/// <summary>
	/// Get the maximum strahler value for the tree.
	/// </summary>
	public virtual float GetMaxStrahler()
	{
		return vtkStrahlerMetric_GetMaxStrahler_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStrahlerMetric_GetNormalize_02(HandleRef pThis);

	/// <summary>
	/// Set/get setting of normalize flag.  If this is set, the
	/// Strahler values are scaled into the range [0..1].
	/// Default is for normalization to be OFF.
	/// </summary>
	public virtual int GetNormalize()
	{
		return vtkStrahlerMetric_GetNormalize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStrahlerMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStrahlerMetric_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStrahlerMetric_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStrahlerMetric_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStrahlerMetric_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStrahlerMetric_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStrahlerMetric_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStrahlerMetric_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStrahlerMetric_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStrahlerMetric NewInstance()
	{
		vtkStrahlerMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStrahlerMetric_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStrahlerMetric_NormalizeOff_09(HandleRef pThis);

	/// <summary>
	/// Set/get setting of normalize flag.  If this is set, the
	/// Strahler values are scaled into the range [0..1].
	/// Default is for normalization to be OFF.
	/// </summary>
	public virtual void NormalizeOff()
	{
		vtkStrahlerMetric_NormalizeOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStrahlerMetric_NormalizeOn_10(HandleRef pThis);

	/// <summary>
	/// Set/get setting of normalize flag.  If this is set, the
	/// Strahler values are scaled into the range [0..1].
	/// Default is for normalization to be OFF.
	/// </summary>
	public virtual void NormalizeOn()
	{
		vtkStrahlerMetric_NormalizeOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStrahlerMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStrahlerMetric SafeDownCast(vtkObjectBase o)
	{
		vtkStrahlerMetric vtkStrahlerMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStrahlerMetric_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStrahlerMetric2 = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStrahlerMetric2.Register(null);
			}
		}
		return vtkStrahlerMetric2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStrahlerMetric_SetMetricArrayName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the array in which the Strahler values will
	/// be stored within the output vertex data.
	/// Default is "Strahler"
	/// </summary>
	public virtual void SetMetricArrayName(string _arg)
	{
		vtkStrahlerMetric_SetMetricArrayName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStrahlerMetric_SetNormalize_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get setting of normalize flag.  If this is set, the
	/// Strahler values are scaled into the range [0..1].
	/// Default is for normalization to be OFF.
	/// </summary>
	public virtual void SetNormalize(int _arg)
	{
		vtkStrahlerMetric_SetNormalize_13(GetCppThis(), _arg);
	}
}
