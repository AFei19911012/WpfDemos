using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDeformPointSet
/// </summary>
/// <remarks>
///    use a control polyhedron to deform an input vtkPointSet
///
/// vtkDeformPointSet is a filter that uses a control polyhdron to deform an
/// input dataset of type vtkPointSet. The control polyhedron (or mesh) must
/// be a closed, manifold surface.
///
/// The filter executes as follows. In initial pipeline execution, the control
/// mesh and input vtkPointSet are assumed in undeformed position, and an
/// initial set of interpolation weights are computed for each point in the
/// vtkPointSet (one interpolation weight value for each point in the control
/// mesh). The filter then stores these interpolation weights after filter
/// execution. The next time the filter executes, assuming that the number of
/// points/cells in the control mesh and vtkPointSet have not changed, the
/// points in the vtkPointSet are recomputed based on the original
/// weights. Hence if the control mesh has been deformed, it will in turn
/// cause deformation in the vtkPointSet. This can be used to animate or edit
/// the geometry of the vtkPointSet.
///
/// @warning
/// Note that a set of interpolation weights per point in the vtkPointSet is
/// maintained. The number of interpolation weights is the number of points
/// in the control mesh. Hence keep the control mesh small in size or a n^2
/// data explostion will occur.
///
/// @warning
/// The filter maintains interpolation weights between executions (after the
/// initial execution pass computes the interpolation weights). You can
/// explicitly cause the filter to reinitialize by setting the
/// InitializeWeights boolean to true. By default, the filter will execute and
/// then set InitializeWeights to false.
///
/// @warning
/// This work was motivated by the work of Tao Ju et al in "Mesh Value Coordinates
/// for Closed Triangular Meshes." The MVC algorithm is currently used to generate
/// interpolation weights. However, in the future this filter may be extended to
/// provide other interpolation functions.
///
/// @warning
/// A final note: point data and cell data are passed from the input to the output.
/// Only the point coordinates of the input vtkPointSet are modified.
///
/// </remarks>
/// <seealso>
///
/// vtkMeanValueCoordinatesInterpolator vtkProbePolyhedron vtkPolyhedron
/// </seealso>
public class vtkDeformPointSet : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDeformPointSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDeformPointSet()
	{
		MRClassNameKey = "class vtkDeformPointSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDeformPointSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDeformPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeformPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static vtkDeformPointSet New()
	{
		vtkDeformPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeformPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDeformPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public vtkDeformPointSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDeformPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeformPointSet_GetControlMeshData_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the control mesh to deform the input vtkPointSet. The control
	/// mesh must be a closed, non-self-intersecting, manifold mesh.
	/// </summary>
	public vtkPolyData GetControlMeshData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeformPointSet_GetControlMeshData_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDeformPointSet_GetInitializeWeights_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to regenerate interpolation weights or not. Initially
	/// the filter will reexecute no matter what this flag is set to (initial
	/// weights must be computed). Also, this flag is ignored if the number of
	/// input points/cells or the number of control mesh points/cells changes
	/// between executions. Thus flag is used to force reexecution and
	/// recomputation of weights.
	/// </summary>
	public virtual int GetInitializeWeights()
	{
		return vtkDeformPointSet_GetInitializeWeights_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDeformPointSet_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDeformPointSet_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDeformPointSet_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDeformPointSet_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeformPointSet_InitializeWeightsOff_05(HandleRef pThis);

	/// <summary>
	/// Specify whether to regenerate interpolation weights or not. Initially
	/// the filter will reexecute no matter what this flag is set to (initial
	/// weights must be computed). Also, this flag is ignored if the number of
	/// input points/cells or the number of control mesh points/cells changes
	/// between executions. Thus flag is used to force reexecution and
	/// recomputation of weights.
	/// </summary>
	public virtual void InitializeWeightsOff()
	{
		vtkDeformPointSet_InitializeWeightsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeformPointSet_InitializeWeightsOn_06(HandleRef pThis);

	/// <summary>
	/// Specify whether to regenerate interpolation weights or not. Initially
	/// the filter will reexecute no matter what this flag is set to (initial
	/// weights must be computed). Also, this flag is ignored if the number of
	/// input points/cells or the number of control mesh points/cells changes
	/// between executions. Thus flag is used to force reexecution and
	/// recomputation of weights.
	/// </summary>
	public virtual void InitializeWeightsOn()
	{
		vtkDeformPointSet_InitializeWeightsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDeformPointSet_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDeformPointSet_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDeformPointSet_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDeformPointSet_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeformPointSet_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new vtkDeformPointSet NewInstance()
	{
		vtkDeformPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeformPointSet_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDeformPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeformPointSet_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static vtkDeformPointSet SafeDownCast(vtkObjectBase o)
	{
		vtkDeformPointSet vtkDeformPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeformPointSet_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDeformPointSet2 = (vtkDeformPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDeformPointSet2.Register(null);
			}
		}
		return vtkDeformPointSet2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeformPointSet_SetControlMeshConnection_12(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the point locations used to probe input. Any geometry
	/// can be used. New style. Equivalent to SetInputConnection(1, algOutput).
	/// </summary>
	public void SetControlMeshConnection(vtkAlgorithmOutput algOutput)
	{
		vtkDeformPointSet_SetControlMeshConnection_12(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeformPointSet_SetControlMeshData_13(HandleRef pThis, HandleRef controlMesh);

	/// <summary>
	/// Specify the control mesh to deform the input vtkPointSet. The control
	/// mesh must be a closed, non-self-intersecting, manifold mesh.
	/// </summary>
	public void SetControlMeshData(vtkPolyData controlMesh)
	{
		vtkDeformPointSet_SetControlMeshData_13(GetCppThis(), controlMesh?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeformPointSet_SetInitializeWeights_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to regenerate interpolation weights or not. Initially
	/// the filter will reexecute no matter what this flag is set to (initial
	/// weights must be computed). Also, this flag is ignored if the number of
	/// input points/cells or the number of control mesh points/cells changes
	/// between executions. Thus flag is used to force reexecution and
	/// recomputation of weights.
	/// </summary>
	public virtual void SetInitializeWeights(int _arg)
	{
		vtkDeformPointSet_SetInitializeWeights_14(GetCppThis(), _arg);
	}
}
