using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSmoothErrorMetric
/// </summary>
/// <remarks>
///    Objects that compute
/// geometry-based error during cell tessellation according to
/// some max angle.
///
///
/// It is a concrete error metric, based on a geometric criterium:
/// a max angle between the chord passing through the midpoint and one of the
/// endpoints and the other chord passing through the midpoint and the other
/// endpoint of the edge. It is related to the flatness of an edge.
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
/// </seealso>
public class vtkSmoothErrorMetric : vtkGenericSubdivisionErrorMetric
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSmoothErrorMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSmoothErrorMetric()
	{
		MRClassNameKey = "class vtkSmoothErrorMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmoothErrorMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSmoothErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the error metric with a default flatness threshold of 90.1
	/// degrees.
	/// </summary>
	public new static vtkSmoothErrorMetric New()
	{
		vtkSmoothErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the error metric with a default flatness threshold of 90.1
	/// degrees.
	/// </summary>
	public vtkSmoothErrorMetric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSmoothErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkSmoothErrorMetric_GetAngleTolerance_01(HandleRef pThis);

	/// <summary>
	/// Return the flatness threshold.
	/// \post positive_result: result&gt;90 &amp;&amp; result&lt;180
	/// </summary>
	public double GetAngleTolerance()
	{
		return vtkSmoothErrorMetric_GetAngleTolerance_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Return the error at the mid-point. It will return an error relative to
	/// the bounding box size if GetRelative() is true, a square absolute error
	/// otherwise.
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
		return vtkSmoothErrorMetric_GetError_02(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmoothErrorMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSmoothErrorMetric_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmoothErrorMetric_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSmoothErrorMetric_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothErrorMetric_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSmoothErrorMetric_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothErrorMetric_IsTypeOf_06(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSmoothErrorMetric_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothErrorMetric_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new vtkSmoothErrorMetric NewInstance()
	{
		vtkSmoothErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothErrorMetric_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothErrorMetric_RequiresEdgeSubdivision_09(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Does the edge need to be subdivided according to the cosine between
	/// the two chords passing through the mid-point and the endpoints?
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
		return vtkSmoothErrorMetric_RequiresEdgeSubdivision_09(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothErrorMetric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static vtkSmoothErrorMetric SafeDownCast(vtkObjectBase o)
	{
		vtkSmoothErrorMetric vtkSmoothErrorMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothErrorMetric_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSmoothErrorMetric2 = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSmoothErrorMetric2.Register(null);
			}
		}
		return vtkSmoothErrorMetric2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothErrorMetric_SetAngleTolerance_11(HandleRef pThis, double value);

	/// <summary>
	/// Set the flatness threshold with an angle in degrees. Internally
	/// compute the cosine. value is supposed to be in ]90,180[, if not
	/// it is clamped in [90.1,179.9].
	/// For instance 178 will give better result than 150.
	/// </summary>
	public void SetAngleTolerance(double value)
	{
		vtkSmoothErrorMetric_SetAngleTolerance_11(GetCppThis(), value);
	}
}
