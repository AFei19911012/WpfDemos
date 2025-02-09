using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVortexCore
/// </summary>
/// <remarks>
///    Compute vortex core lines using the parallel vectors method
///
/// vtkVortexCore computes vortex core lines using the parallel vectors method,
/// as described in
///
/// Roth, Martin and Ronald Peikert. “A higher-order method for finding vortex
/// core lines.” Proceedings Visualization '98 (Cat. No.98CB36276) (1998):
/// 143-150.
///
/// By default, the "Higher-Order" approach of computing the parallel vector
/// lines between the flow field's velocity and jerk is disabled in favor of
/// computing the parallel vector lines between the velocity and acceleration,
/// as suggested in
///
/// Haimes, Robert and David N. Kenwright. “On the velocity gradient tensor and
/// fluid feature extraction.” (1999).
///
/// To further discriminate against spurious vortex cores, at each potential point
/// value the Q-criterion, delta-criterion, and lambda_2-criterion are checked as
/// defined in
///
/// Haller, G. (2005). An objective definition of a vortex. Journal of Fluid
/// Mechanics, 525, 1-26.
///
/// Additionally, the lambda_ci criterion is computed as defined in
///
/// Chakraborty, P., Balachandar, S., &amp; Adran, R. (2005). On the relationships
/// between local vortex identification schemes. Journal of Fluid Mechanics, 535,
/// 189-214.
///
/// The Q-criterion and delta-criterion are used to prefilter cells
/// prior to the execution of the parallel lines algorithm, and all criteria
/// values are stored as point values on the output polylines.
///
/// The FasterApproximation option uses a faster approximate gradient calculation
/// to accelerate the vortex core calculation.
///
/// </remarks>
/// <seealso>
///
/// vtkParallelVectors
/// </seealso>
public class vtkVortexCore : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVortexCore";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVortexCore()
	{
		MRClassNameKey = "class vtkVortexCore";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVortexCore"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVortexCore(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVortexCore_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVortexCore New()
	{
		vtkVortexCore result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVortexCore_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVortexCore)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVortexCore()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVortexCore_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkVortexCore_FasterApproximationOff_01(HandleRef pThis);

	/// <summary>
	/// When this flag is on, the gradient filter will provide a less accurate (but close)
	/// algorithm that performs fewer derivative calculations (and is therefore faster).
	/// The default is off.
	/// </summary>
	public virtual void FasterApproximationOff()
	{
		vtkVortexCore_FasterApproximationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVortexCore_FasterApproximationOn_02(HandleRef pThis);

	/// <summary>
	/// When this flag is on, the gradient filter will provide a less accurate (but close)
	/// algorithm that performs fewer derivative calculations (and is therefore faster).
	/// The default is off.
	/// </summary>
	public virtual void FasterApproximationOn()
	{
		vtkVortexCore_FasterApproximationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVortexCore_GetFasterApproximation_03(HandleRef pThis);

	/// <summary>
	/// When this flag is on, the gradient filter will provide a less accurate (but close)
	/// algorithm that performs fewer derivative calculations (and is therefore faster).
	/// The default is off.
	/// </summary>
	public virtual bool GetFasterApproximation()
	{
		return (vtkVortexCore_GetFasterApproximation_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVortexCore_GetHigherOrderMethod_04(HandleRef pThis);

	/// <summary>
	/// When this flag is on, the flow field's jerk is used instead of acceleration as the
	/// second vector field during the parallel vector operation. The default is off.
	/// </summary>
	public virtual int GetHigherOrderMethod()
	{
		return vtkVortexCore_GetHigherOrderMethod_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVortexCore_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVortexCore_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVortexCore_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVortexCore_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVortexCore_HigherOrderMethodOff_07(HandleRef pThis);

	/// <summary>
	/// When this flag is on, the flow field's jerk is used instead of acceleration as the
	/// second vector field during the parallel vector operation. The default is off.
	/// </summary>
	public virtual void HigherOrderMethodOff()
	{
		vtkVortexCore_HigherOrderMethodOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVortexCore_HigherOrderMethodOn_08(HandleRef pThis);

	/// <summary>
	/// When this flag is on, the flow field's jerk is used instead of acceleration as the
	/// second vector field during the parallel vector operation. The default is off.
	/// </summary>
	public virtual void HigherOrderMethodOn()
	{
		vtkVortexCore_HigherOrderMethodOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVortexCore_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVortexCore_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVortexCore_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVortexCore_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVortexCore_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVortexCore NewInstance()
	{
		vtkVortexCore result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVortexCore_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVortexCore)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVortexCore_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVortexCore SafeDownCast(vtkObjectBase o)
	{
		vtkVortexCore vtkVortexCore2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVortexCore_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVortexCore2 = (vtkVortexCore)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVortexCore2.Register(null);
			}
		}
		return vtkVortexCore2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVortexCore_SetFasterApproximation_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// When this flag is on, the gradient filter will provide a less accurate (but close)
	/// algorithm that performs fewer derivative calculations (and is therefore faster).
	/// The default is off.
	/// </summary>
	public virtual void SetFasterApproximation(bool _arg)
	{
		vtkVortexCore_SetFasterApproximation_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVortexCore_SetHigherOrderMethod_15(HandleRef pThis, int _arg);

	/// <summary>
	/// When this flag is on, the flow field's jerk is used instead of acceleration as the
	/// second vector field during the parallel vector operation. The default is off.
	/// </summary>
	public virtual void SetHigherOrderMethod(int _arg)
	{
		vtkVortexCore_SetHigherOrderMethod_15(GetCppThis(), _arg);
	}
}
