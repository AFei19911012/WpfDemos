using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeometricErrorMetric
/// </summary>
/// <remarks>
///    Objects that compute
/// geometry-based error during cell tessellation.
///
///
/// It is a concrete error metric, based on a geometric criterium:
/// the variation of the edge from a straight line.
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric
/// </seealso>
public class vtkGeometricErrorMetric : vtkGenericSubdivisionErrorMetric
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeometricErrorMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeometricErrorMetric()
	{
		MRClassNameKey = "class vtkGeometricErrorMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeometricErrorMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeometricErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometricErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the error metric with a default squared absolute geometric
	/// accuracy equal to 1.
	/// </summary>
	public new static vtkGeometricErrorMetric New()
	{
		vtkGeometricErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometricErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the error metric with a default squared absolute geometric
	/// accuracy equal to 1.
	/// </summary>
	public vtkGeometricErrorMetric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGeometricErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkGeometricErrorMetric_GetAbsoluteGeometricTolerance_01(HandleRef pThis);

	/// <summary>
	/// Return the squared absolute geometric accuracy. See
	/// SetAbsoluteGeometricTolerance() for details.
	/// \post positive_result: result&gt;0
	/// </summary>
	public virtual double GetAbsoluteGeometricTolerance()
	{
		return vtkGeometricErrorMetric_GetAbsoluteGeometricTolerance_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGeometricErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

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
		return vtkGeometricErrorMetric_GetError_02(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometricErrorMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeometricErrorMetric_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometricErrorMetric_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeometricErrorMetric_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometricErrorMetric_GetRelative_05(HandleRef pThis);

	/// <summary>
	/// Return the type of output of GetError()
	/// </summary>
	public int GetRelative()
	{
		return vtkGeometricErrorMetric_GetRelative_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometricErrorMetric_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeometricErrorMetric_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometricErrorMetric_IsTypeOf_07(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeometricErrorMetric_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometricErrorMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new vtkGeometricErrorMetric NewInstance()
	{
		vtkGeometricErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometricErrorMetric_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometricErrorMetric_RequiresEdgeSubdivision_10(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Does the edge need to be subdivided according to the distance between
	/// the line passing through its endpoints and the mid point?
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
		return vtkGeometricErrorMetric_RequiresEdgeSubdivision_10(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometricErrorMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static vtkGeometricErrorMetric SafeDownCast(vtkObjectBase o)
	{
		vtkGeometricErrorMetric vtkGeometricErrorMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometricErrorMetric_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeometricErrorMetric2 = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeometricErrorMetric2.Register(null);
			}
		}
		return vtkGeometricErrorMetric2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometricErrorMetric_SetAbsoluteGeometricTolerance_12(HandleRef pThis, double value);

	/// <summary>
	/// Set the geometric accuracy with a squared absolute value.
	/// This is the geometric object-based accuracy.
	/// Subdivision will be required if the square distance between the real
	/// point and the straight line passing through the vertices of the edge is
	/// greater than `value'. For instance 0.01 will give better result than 0.1.
	/// \pre positive_value: value&gt;0
	/// </summary>
	public void SetAbsoluteGeometricTolerance(double value)
	{
		vtkGeometricErrorMetric_SetAbsoluteGeometricTolerance_12(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometricErrorMetric_SetRelativeGeometricTolerance_13(HandleRef pThis, double value, HandleRef ds);

	/// <summary>
	/// Set the geometric accuracy with a value relative to the length of the
	/// bounding box of the dataset. Internally compute the absolute tolerance.
	/// For instance 0.01 will give better result than 0.1.
	/// \pre valid_range_value: value&gt;0 &amp;&amp; value&lt;1
	/// \pre ds_exists: ds!=0
	/// </summary>
	public void SetRelativeGeometricTolerance(double value, vtkGenericDataSet ds)
	{
		vtkGeometricErrorMetric_SetRelativeGeometricTolerance_13(GetCppThis(), value, ds?.GetCppThis() ?? default(HandleRef));
	}
}
