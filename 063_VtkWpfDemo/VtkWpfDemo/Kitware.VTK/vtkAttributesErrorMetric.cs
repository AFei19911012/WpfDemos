using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAttributesErrorMetric
/// </summary>
/// <remarks>
///     Objects that compute
/// attribute-based error during cell tessellation.
///
///
/// It is a concrete error metric, based on an attribute criterium:
/// the variation of the active attribute/component value from a linear ramp
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
/// </seealso>
public class vtkAttributesErrorMetric : vtkGenericSubdivisionErrorMetric
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAttributesErrorMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAttributesErrorMetric()
	{
		MRClassNameKey = "class vtkAttributesErrorMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributesErrorMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAttributesErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributesErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the error metric with a default relative attribute accuracy
	/// equal to 0.1.
	/// </summary>
	public new static vtkAttributesErrorMetric New()
	{
		vtkAttributesErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributesErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the error metric with a default relative attribute accuracy
	/// equal to 0.1.
	/// </summary>
	public vtkAttributesErrorMetric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAttributesErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributesErrorMetric_GetAbsoluteAttributeTolerance_01(HandleRef pThis);

	/// <summary>
	/// Absolute tolerance of the active scalar (attribute+component).
	/// Subdivision is required if the square distance between the real attribute
	/// at the mid point on the edge and the interpolated attribute is greater
	/// than AbsoluteAttributeTolerance.
	/// This is the attribute accuracy.
	/// 0.01 will give better result than 0.1.
	/// </summary>
	public virtual double GetAbsoluteAttributeTolerance()
	{
		return vtkAttributesErrorMetric_GetAbsoluteAttributeTolerance_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributesErrorMetric_GetAttributeTolerance_02(HandleRef pThis);

	/// <summary>
	/// Relative tolerance of the active scalar (attribute+component).
	/// Subdivision is required if the square distance between the real attribute
	/// at the mid point on the edge and the interpolated attribute is greater
	/// than AttributeTolerance.
	/// This is the attribute accuracy.
	/// 0.01 will give better result than 0.1.
	/// </summary>
	public virtual double GetAttributeTolerance()
	{
		return vtkAttributesErrorMetric_GetAttributeTolerance_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributesErrorMetric_GetError_03(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Return the error at the mid-point. The type of error depends on the state
	/// of the concrete error metric. For instance, it can return an absolute
	/// or relative error metric.
	/// See RequiresEdgeSubdivision() for a description of the arguments.
	/// \pre leftPoint_exists: leftPoint!=0
	/// \pre midPoint_exists: midPoint!=0
	/// \pre rightPoint_exists: rightPoint!=0
	/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
	/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
	/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
	/// \post positive_result: result&gt;=0
	/// </summary>
	public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
	{
		return vtkAttributesErrorMetric_GetError_03(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributesErrorMetric_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAttributesErrorMetric_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributesErrorMetric_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAttributesErrorMetric_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributesErrorMetric_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAttributesErrorMetric_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributesErrorMetric_IsTypeOf_07(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAttributesErrorMetric_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributesErrorMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new vtkAttributesErrorMetric NewInstance()
	{
		vtkAttributesErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributesErrorMetric_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributesErrorMetric_RequiresEdgeSubdivision_10(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Does the edge need to be subdivided according to the distance between
	/// the value of the active attribute/component at the midpoint and the mean
	/// value between the endpoints?
	/// The edge is defined by its `leftPoint' and its `rightPoint'.
	/// `leftPoint', `midPoint' and `rightPoint' have to be initialized before
	/// calling RequiresEdgeSubdivision().
	/// Their format is global coordinates, parametric coordinates and
	/// point centered attributes: xyx rst abc de...
	/// `alpha' is the normalized abscissa of the midpoint along the edge.
	/// (close to 0 means close to the left point, close to 1 means close to the
	/// right point)
	/// \pre leftPoint_exists: leftPoint!=0
	/// \pre midPoint_exists: midPoint!=0
	/// \pre rightPoint_exists: rightPoint!=0
	/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
	/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
	/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
	/// </summary>
	public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
	{
		return vtkAttributesErrorMetric_RequiresEdgeSubdivision_10(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributesErrorMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static vtkAttributesErrorMetric SafeDownCast(vtkObjectBase o)
	{
		vtkAttributesErrorMetric vtkAttributesErrorMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributesErrorMetric_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAttributesErrorMetric2 = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAttributesErrorMetric2.Register(null);
			}
		}
		return vtkAttributesErrorMetric2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributesErrorMetric_SetAbsoluteAttributeTolerance_12(HandleRef pThis, double value);

	/// <summary>
	/// Set the absolute attribute accuracy to `value'. See
	/// GetAbsoluteAttributeTolerance() for details.
	/// It is particularly useful when some concrete implementation of
	/// vtkGenericAttribute does not support GetRange() request, called
	/// internally in SetAttributeTolerance(). It may happen when the
	/// implementation support higher order attributes but
	/// cannot compute the range.
	/// \pre valid_range_value: value&gt;0
	/// </summary>
	public void SetAbsoluteAttributeTolerance(double value)
	{
		vtkAttributesErrorMetric_SetAbsoluteAttributeTolerance_12(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributesErrorMetric_SetAttributeTolerance_13(HandleRef pThis, double value);

	/// <summary>
	/// Set the relative attribute accuracy to `value'. See
	/// GetAttributeTolerance() for details.
	/// \pre valid_range_value: value&gt;0 &amp;&amp; value&lt;1
	/// </summary>
	public void SetAttributeTolerance(double value)
	{
		vtkAttributesErrorMetric_SetAttributeTolerance_13(GetCppThis(), value);
	}
}
