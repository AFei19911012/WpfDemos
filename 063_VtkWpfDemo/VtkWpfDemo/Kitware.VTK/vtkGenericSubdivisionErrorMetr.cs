using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericSubdivisionErrorMetric
/// </summary>
/// <remarks>
///    Objects that compute
/// error during cell tessellation.
///
///
/// Objects of that class answer the following question during the cell
/// subdivision: "does the edge need to be subdivided?" through
/// RequiresEdgeSubdivision().
/// The answer depends on the criterium actually used in the subclass of this
/// abstract class: a geometric-based error
/// metric (variation of edge from a straight line), an attribute-based error
/// metric (variation of the active attribute/component value from a linear
/// ramp) , a view-depend error metric, ...
/// Cell subdivision is performed in the context of the adaptor
/// framework: higher-order, or complex cells, are automatically tessellated
/// into simplices so that they can be processed with conventional
/// visualization algorithms.
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator
/// </seealso>
public abstract class vtkGenericSubdivisionErrorMetric : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericSubdivisionErrorMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericSubdivisionErrorMetric()
	{
		MRClassNameKey = "class vtkGenericSubdivisionErrorMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericSubdivisionErrorMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericSubdivisionErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericSubdivisionErrorMetric_GetDataSet_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the dataset to be tessellated.
	/// </summary>
	public virtual vtkGenericDataSet GetDataSet()
	{
		vtkGenericDataSet vtkGenericDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericSubdivisionErrorMetric_GetDataSet_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericDataSet2 = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericDataSet2.Register(null);
			}
		}
		return vtkGenericDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericSubdivisionErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

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
	public virtual double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
	{
		return vtkGenericSubdivisionErrorMetric_GetError_02(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericSubdivisionErrorMetric_GetGenericCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The cell that the edge belongs to.
	/// </summary>
	public virtual vtkGenericAdaptorCell GetGenericCell()
	{
		vtkGenericAdaptorCell vtkGenericAdaptorCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericSubdivisionErrorMetric_GetGenericCell_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAdaptorCell2 = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAdaptorCell2.Register(null);
			}
		}
		return vtkGenericAdaptorCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericSubdivisionErrorMetric_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericSubdivisionErrorMetric_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericSubdivisionErrorMetric_IsTypeOf_07(string type);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericSubdivisionErrorMetric_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericSubdivisionErrorMetric_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new vtkGenericSubdivisionErrorMetric NewInstance()
	{
		vtkGenericSubdivisionErrorMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericSubdivisionErrorMetric_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericSubdivisionErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericSubdivisionErrorMetric_RequiresEdgeSubdivision_09(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

	/// <summary>
	/// Does the edge need to be subdivided according to the implemented
	/// computation?
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
	public virtual int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
	{
		return vtkGenericSubdivisionErrorMetric_RequiresEdgeSubdivision_09(GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericSubdivisionErrorMetric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and error macros.
	/// </summary>
	public new static vtkGenericSubdivisionErrorMetric SafeDownCast(vtkObjectBase o)
	{
		vtkGenericSubdivisionErrorMetric vtkGenericSubdivisionErrorMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericSubdivisionErrorMetric_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericSubdivisionErrorMetric2 = (vtkGenericSubdivisionErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericSubdivisionErrorMetric2.Register(null);
			}
		}
		return vtkGenericSubdivisionErrorMetric2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericSubdivisionErrorMetric_SetDataSet_11(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Set/Get the dataset to be tessellated.
	/// </summary>
	public void SetDataSet(vtkGenericDataSet ds)
	{
		vtkGenericSubdivisionErrorMetric_SetDataSet_11(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericSubdivisionErrorMetric_SetGenericCell_12(HandleRef pThis, HandleRef cell);

	/// <summary>
	/// The cell that the edge belongs to.
	/// </summary>
	public void SetGenericCell(vtkGenericAdaptorCell cell)
	{
		vtkGenericSubdivisionErrorMetric_SetGenericCell_12(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef));
	}
}
