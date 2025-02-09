using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkReebGraphSimplificationMetric
/// </summary>
/// <remarks>
///    abstract class for custom Reeb graph
/// simplification metric design.
///
/// This class makes it possible to design customized simplification metric
/// evaluation algorithms, enabling the user to control the definition of what
/// should be considered as noise or signal in the topological filtering process.
///
/// References:
/// "Topological persistence and simplification",
/// H. Edelsbrunner, D. Letscher, and A. Zomorodian,
/// Discrete Computational Geometry, 28:511-533, 2002.
///
/// "Extreme elevation on a 2-manifold",
/// P.K. Agarwal, H. Edelsbrunner, J. Harer, and Y. Wang,
/// ACM Symposium on Computational Geometry, pp. 357-365, 2004.
///
/// "Simplifying flexible isosurfaces using local geometric measures",
/// H. Carr, J. Snoeyink, M van de Panne,
/// IEEE Visualization, 497-504, 2004
///
/// "Loop surgery for volumetric meshes: Reeb graphs reduced to contour trees",
/// J. Tierny, A. Gyulassy, E. Simon, V. Pascucci,
/// IEEE Trans. on Vis. and Comp. Graph. (Proc of IEEE VIS), 15:1177-1184, 2009.
///
///
/// See Graphics/Testing/Cxx/TestReebGraph.cxx for an example of concrete
/// implementation.
/// </remarks>
public class vtkReebGraphSimplificationMetric : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraphSimplificationMetric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkReebGraphSimplificationMetric()
	{
		MRClassNameKey = "class vtkReebGraphSimplificationMetric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraphSimplificationMetric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkReebGraphSimplificationMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReebGraphSimplificationMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReebGraphSimplificationMetric New()
	{
		vtkReebGraphSimplificationMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReebGraphSimplificationMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkReebGraphSimplificationMetric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkReebGraphSimplificationMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkReebGraphSimplificationMetric_ComputeMetric_01(HandleRef pThis, HandleRef mesh, HandleRef field, long startCriticalPoint, HandleRef vertexList, long endCriticalPoint);

	/// <summary>
	/// Function to implement in your simplification metric algorithm.
	/// Given the input mesh and the Ids of the vertices living on the Reeb graph
	/// arc to consider for removal, you should return a value between 0 and 1 (the
	/// smallest the more likely the arc will be removed, depending on the
	/// user-defined simplification threshold).
	/// </summary>
	public virtual double ComputeMetric(vtkDataSet mesh, vtkDataArray field, long startCriticalPoint, vtkAbstractArray vertexList, long endCriticalPoint)
	{
		return vtkReebGraphSimplificationMetric_ComputeMetric_01(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), field?.GetCppThis() ?? default(HandleRef), startCriticalPoint, vertexList?.GetCppThis() ?? default(HandleRef), endCriticalPoint);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkReebGraphSimplificationMetric_GetLowerBound_02(HandleRef pThis);

	/// <summary>
	/// Set the lowest possible value for the custom metric space.
	/// This value can be set prior to launching the Reeb graph simplification and
	/// then used inside the ComputeMetric call to make sure the returned value of
	/// ComputeMetric call is indeed between 0 and 1.
	/// </summary>
	public virtual double GetLowerBound()
	{
		return vtkReebGraphSimplificationMetric_GetLowerBound_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkReebGraphSimplificationMetric_GetUpperBound_05(HandleRef pThis);

	/// <summary>
	/// Set the highest possible value for the custom metric space.
	/// This value can be set prior to launching the Reeb graph simplification and
	/// then used inside the ComputeMetric call to make sure the returned value of
	/// ComputeMetric call is indeed between 0 and 1.
	/// </summary>
	public virtual double GetUpperBound()
	{
		return vtkReebGraphSimplificationMetric_GetUpperBound_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraphSimplificationMetric_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkReebGraphSimplificationMetric_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraphSimplificationMetric_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkReebGraphSimplificationMetric_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReebGraphSimplificationMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkReebGraphSimplificationMetric NewInstance()
	{
		vtkReebGraphSimplificationMetric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReebGraphSimplificationMetric_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReebGraphSimplificationMetric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReebGraphSimplificationMetric SafeDownCast(vtkObjectBase o)
	{
		vtkReebGraphSimplificationMetric vtkReebGraphSimplificationMetric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReebGraphSimplificationMetric_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkReebGraphSimplificationMetric2 = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkReebGraphSimplificationMetric2.Register(null);
			}
		}
		return vtkReebGraphSimplificationMetric2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReebGraphSimplificationMetric_SetLowerBound_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the lowest possible value for the custom metric space.
	/// This value can be set prior to launching the Reeb graph simplification and
	/// then used inside the ComputeMetric call to make sure the returned value of
	/// ComputeMetric call is indeed between 0 and 1.
	/// </summary>
	public virtual void SetLowerBound(double _arg)
	{
		vtkReebGraphSimplificationMetric_SetLowerBound_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReebGraphSimplificationMetric_SetUpperBound_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the highest possible value for the custom metric space.
	/// This value can be set prior to launching the Reeb graph simplification and
	/// then used inside the ComputeMetric call to make sure the returned value of
	/// ComputeMetric call is indeed between 0 and 1.
	/// </summary>
	public virtual void SetUpperBound(double _arg)
	{
		vtkReebGraphSimplificationMetric_SetUpperBound_12(GetCppThis(), _arg);
	}
}
