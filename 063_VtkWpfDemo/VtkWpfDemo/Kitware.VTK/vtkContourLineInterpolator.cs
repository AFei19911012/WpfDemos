using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourLineInterpolator
/// </summary>
/// <remarks>
///    Defines API for interpolating/modifying nodes from a vtkContourRepresentation
///
/// vtkContourLineInterpolator is an abstract base class for interpolators
/// that are used by the vtkContourRepresentation class to interpolate
/// and/or modify nodes in a contour. Subclasses must override the virtual
/// method \c InterpolateLine. This is used by the contour representation
/// to give the interpolator a chance to define an interpolation scheme
/// between nodes. See vtkBezierContourLineInterpolator for a concrete
/// implementation. Subclasses may also override \c UpdateNode. This provides
/// a way for the representation to give the interpolator a chance to modify
/// the nodes, as the user constructs the contours. For instance, a sticky
/// contour widget may be implemented that moves nodes to nearby regions of
/// high gradient, to be used in contour-guided segmentation.
/// </remarks>
public abstract class vtkContourLineInterpolator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourLineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourLineInterpolator()
	{
		MRClassNameKey = "class vtkContourLineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourLineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourLineInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourLineInterpolator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourLineInterpolator_GetSpan_03(HandleRef pThis, int nodeIndex, HandleRef nodeIndices, HandleRef rep);

	/// <summary>
	/// Span of the interpolator. ie. the number of control points its supposed
	/// to interpolate given a node.
	///
	/// The first argument is the current nodeIndex.
	/// ie, you'd be trying to interpolate between nodes "nodeIndex" and
	/// "nodeIndex-1", unless you're closing the contour in which case, you're
	/// trying to interpolate "nodeIndex" and "Node=0".
	///
	/// The node span is returned in a vtkIntArray. The default node span is 1
	/// (ie. nodeIndices is a 2 tuple (nodeIndex, nodeIndex-1)). However, it
	/// need not always be 1. For instance, cubic spline interpolators, which
	/// have a span of 3 control points, it can be larger. See
	/// vtkBezierContourLineInterpolator for instance.
	/// </summary>
	public virtual void GetSpan(int nodeIndex, vtkIntArray nodeIndices, vtkContourRepresentation rep)
	{
		vtkContourLineInterpolator_GetSpan_03(GetCppThis(), nodeIndex, nodeIndices?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLineInterpolator_InterpolateLine_04(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

	/// <summary>
	/// Subclasses that wish to interpolate a line segment must implement this.
	/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
	/// and idx2, that allow the contour to adhere to a bezier curve.
	/// </summary>
	public virtual int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
	{
		return vtkContourLineInterpolator_InterpolateLine_04(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef), idx1, idx2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLineInterpolator_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourLineInterpolator_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLineInterpolator_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourLineInterpolator_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkContourLineInterpolator NewInstance()
	{
		vtkContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourLineInterpolator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkContourLineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkContourLineInterpolator vtkContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourLineInterpolator_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourLineInterpolator2 = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourLineInterpolator2.Register(null);
			}
		}
		return vtkContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourLineInterpolator_UpdateNode_09(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

	/// <summary>
	/// The interpolator is given a chance to update the node. For instance, the
	/// vtkImageContourLineInterpolator updates the idx'th node in the contour,
	/// so it automatically sticks to edges in the vicinity as the user
	/// constructs the contour.
	/// Returns 0 if the node (world position) is unchanged.
	/// </summary>
	public virtual int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
	{
		return vtkContourLineInterpolator_UpdateNode_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}
}
