using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBezierContourLineInterpolator
/// </summary>
/// <remarks>
///    Interpolates supplied nodes with bezier line segments
///
/// The line interpolator interpolates supplied nodes (see InterpolateLine)
/// with Bezier line segments. The fitness of the curve may be controlled using
/// SetMaximumCurveError and SetMaximumNumberOfLineSegments.
///
/// </remarks>
/// <seealso>
///
/// vtkContourLineInterpolator
/// </seealso>
public class vtkBezierContourLineInterpolator : vtkContourLineInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBezierContourLineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBezierContourLineInterpolator()
	{
		MRClassNameKey = "class vtkBezierContourLineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierContourLineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBezierContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBezierContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkBezierContourLineInterpolator New()
	{
		vtkBezierContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBezierContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkBezierContourLineInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBezierContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveError_01(HandleRef pThis);

	/// <summary>
	/// The difference between a line segment connecting two points and the curve
	/// connecting the same points. In the limit of the length of the curve
	/// dx -&gt; 0, the two values will be the same. The smaller this number, the
	/// finer the bezier curve will be interpolated. Default is 0.005
	/// </summary>
	public virtual double GetMaximumCurveError()
	{
		return vtkBezierContourLineInterpolator_GetMaximumCurveError_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveErrorMaxValue_02(HandleRef pThis);

	/// <summary>
	/// The difference between a line segment connecting two points and the curve
	/// connecting the same points. In the limit of the length of the curve
	/// dx -&gt; 0, the two values will be the same. The smaller this number, the
	/// finer the bezier curve will be interpolated. Default is 0.005
	/// </summary>
	public virtual double GetMaximumCurveErrorMaxValue()
	{
		return vtkBezierContourLineInterpolator_GetMaximumCurveErrorMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveErrorMinValue_03(HandleRef pThis);

	/// <summary>
	/// The difference between a line segment connecting two points and the curve
	/// connecting the same points. In the limit of the length of the curve
	/// dx -&gt; 0, the two values will be the same. The smaller this number, the
	/// finer the bezier curve will be interpolated. Default is 0.005
	/// </summary>
	public virtual double GetMaximumCurveErrorMinValue()
	{
		return vtkBezierContourLineInterpolator_GetMaximumCurveErrorMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegments_04(HandleRef pThis);

	/// <summary>
	/// Maximum number of bezier line segments between two nodes. Larger values
	/// create a finer interpolation. Default is 100.
	/// </summary>
	public virtual int GetMaximumCurveLineSegments()
	{
		return vtkBezierContourLineInterpolator_GetMaximumCurveLineSegments_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Maximum number of bezier line segments between two nodes. Larger values
	/// create a finer interpolation. Default is 100.
	/// </summary>
	public virtual int GetMaximumCurveLineSegmentsMaxValue()
	{
		return vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMinValue_06(HandleRef pThis);

	/// <summary>
	/// Maximum number of bezier line segments between two nodes. Larger values
	/// create a finer interpolation. Default is 100.
	/// </summary>
	public virtual int GetMaximumCurveLineSegmentsMinValue()
	{
		return vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierContourLineInterpolator_GetSpan_09(HandleRef pThis, int nodeIndex, HandleRef nodeIndices, HandleRef rep);

	/// <summary>
	/// Span of the interpolator, i.e. the number of control points it's supposed
	/// to interpolate given a node.
	///
	/// The first argument is the current nodeIndex.
	/// i.e., you'd be trying to interpolate between nodes "nodeIndex" and
	/// "nodeIndex-1", unless you're closing the contour, in which case you're
	/// trying to interpolate "nodeIndex" and "Node=0". The node span is
	/// returned in a vtkIntArray.
	///
	/// The node span is returned in a vtkIntArray. The node span returned by
	/// this interpolator will be a 2-tuple with a span of 4.
	/// </summary>
	public override void GetSpan(int nodeIndex, vtkIntArray nodeIndices, vtkContourRepresentation rep)
	{
		vtkBezierContourLineInterpolator_GetSpan_09(GetCppThis(), nodeIndex, nodeIndices?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierContourLineInterpolator_InterpolateLine_10(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
	{
		return vtkBezierContourLineInterpolator_InterpolateLine_10(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef), idx1, idx2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierContourLineInterpolator_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBezierContourLineInterpolator_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierContourLineInterpolator_IsTypeOf_12(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBezierContourLineInterpolator_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBezierContourLineInterpolator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkBezierContourLineInterpolator NewInstance()
	{
		vtkBezierContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBezierContourLineInterpolator_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBezierContourLineInterpolator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkBezierContourLineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkBezierContourLineInterpolator vtkBezierContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBezierContourLineInterpolator_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBezierContourLineInterpolator2 = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBezierContourLineInterpolator2.Register(null);
			}
		}
		return vtkBezierContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierContourLineInterpolator_SetMaximumCurveError_16(HandleRef pThis, double _arg);

	/// <summary>
	/// The difference between a line segment connecting two points and the curve
	/// connecting the same points. In the limit of the length of the curve
	/// dx -&gt; 0, the two values will be the same. The smaller this number, the
	/// finer the bezier curve will be interpolated. Default is 0.005
	/// </summary>
	public virtual void SetMaximumCurveError(double _arg)
	{
		vtkBezierContourLineInterpolator_SetMaximumCurveError_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierContourLineInterpolator_SetMaximumCurveLineSegments_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Maximum number of bezier line segments between two nodes. Larger values
	/// create a finer interpolation. Default is 100.
	/// </summary>
	public virtual void SetMaximumCurveLineSegments(int _arg)
	{
		vtkBezierContourLineInterpolator_SetMaximumCurveLineSegments_17(GetCppThis(), _arg);
	}
}
