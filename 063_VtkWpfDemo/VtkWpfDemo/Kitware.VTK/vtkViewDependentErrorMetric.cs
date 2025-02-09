using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkViewDependentErrorMetric
/// </summary>
/// <remarks>
///    Objects that compute a
/// screen-based error during cell tessellation.
///
///
/// It is a concrete error metric, based on a geometric criterium in
/// the screen space: the variation of the projected edge from a projected
/// straight line
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
/// </seealso>
public class vtkViewDependentErrorMetric : vtkGenericSubdivisionErrorMetric
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkViewDependentErrorMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkViewDependentErrorMetric()
	{
		MRClassNameKey = "class vtkViewDependentErrorMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewDependentErrorMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkViewDependentErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewDependentErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the error metric with a default squared screen-based geometric
	/// accuracy measured in pixels equal to 0.25 (0.5^2).
	/// </summary>
	public new static vtkViewDependentErrorMetric New()
	{
		vtkViewDependentErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewDependentErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the error metric with a default squared screen-based geometric
	/// accuracy measured in pixels equal to 0.25 (0.5^2).
	/// </summary>
	public vtkViewDependentErrorMetric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkViewDependentErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewDependentErrorMetric_GetError_01(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

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
		return vtkViewDependentErrorMetric_GetError_01(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkViewDependentErrorMetric_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewDependentErrorMetric_GetPixelTolerance_04(HandleRef pThis);

	/// <summary>
	/// Return the squared screen-based geometric accuracy measured in pixels.
	/// An accuracy less or equal to 0.25 (0.5^2) ensures that the screen-space
	/// interpolation of a mid-point matches exactly with the projection of the
	/// mid-point (a value less than 1 but greater than 0.25 is not enough,
	/// because of 8-neighbors). Maybe it is useful for lower accuracy in case of
	/// anti-aliasing?
	/// \post positive_result: result&gt;0
	/// </summary>
	public virtual double GetPixelTolerance()
	{
		return vtkViewDependentErrorMetric_GetPixelTolerance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewDependentErrorMetric_GetViewport_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the renderer with `renderer' on which the error metric
	/// is based. The error metric use the active camera of the renderer.
	/// </summary>
	public virtual vtkViewport GetViewport()
	{
		vtkViewport vtkViewport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewDependentErrorMetric_GetViewport_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewport2 = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewport2.Register(null);
			}
		}
		return vtkViewport2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewDependentErrorMetric_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkViewDependentErrorMetric_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewDependentErrorMetric_IsTypeOf_07(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkViewDependentErrorMetric_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewDependentErrorMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new vtkViewDependentErrorMetric NewInstance()
	{
		vtkViewDependentErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewDependentErrorMetric_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewDependentErrorMetric_RequiresEdgeSubdivision_10(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Does the edge need to be subdivided according to the distance between
	/// the line passing through its endpoints in screen space and the projection
	/// of its mid point?
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
		return vtkViewDependentErrorMetric_RequiresEdgeSubdivision_10(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewDependentErrorMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static vtkViewDependentErrorMetric SafeDownCast(vtkObjectBase o)
	{
		vtkViewDependentErrorMetric vtkViewDependentErrorMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewDependentErrorMetric_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewDependentErrorMetric2 = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewDependentErrorMetric2.Register(null);
			}
		}
		return vtkViewDependentErrorMetric2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewDependentErrorMetric_SetPixelTolerance_12(HandleRef pThis, double value);

	/// <summary>
	/// Set the squared screen-based geometric accuracy measured in pixels.
	/// Subdivision will be required if the square distance between the projection
	/// of the real point and the straight line passing through the projection
	/// of the vertices of the edge is greater than `value'.
	/// For instance, 0.25 will give better result than 1.
	/// \pre positive_value: value&gt;0
	/// </summary>
	public void SetPixelTolerance(double value)
	{
		vtkViewDependentErrorMetric_SetPixelTolerance_12(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewDependentErrorMetric_SetViewport_13(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Set/Get the renderer with `renderer' on which the error metric
	/// is based. The error metric use the active camera of the renderer.
	/// </summary>
	public void SetViewport(vtkViewport viewport)
	{
		vtkViewDependentErrorMetric_SetViewport_13(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}
}
