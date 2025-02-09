using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridQuadricDecimation
/// </summary>
/// <remarks>
///    reduce the number of
/// tetrahedra in a mesh
///
///
///
/// vtkUnstructuredGridQuadricDecimation is a class that simplifies
/// tetrahedral meshes using randomized multiple choice edge
/// collapses. The input to this filter is a vtkUnstructuredGrid object
/// with a single scalar field (specifying in the ScalarsName
/// attribute). Users can determine the size of the output mesh by
/// either setting the value of TargetReduction or
/// NumberOfTetsOutput. The BoundaryWeight can be set to control how
/// well the mesh boundary should be preserved. The implementation uses
/// Michael Garland's generalized Quadric Error Metrics, the Corner
/// Table representation and the Standard Conjugate Gradient Method to
/// order the edge collapse sequence.
///
/// Instead of using the traditional priority queue, the algorithm uses
/// a randomized approach to yield faster performance with comparable
/// quality. At each step, a set of 8 random candidate edges are
/// examined to select the best edge to collapse. This number can also
/// be changed by users through NumberOfCandidates.
///
/// For more information as well as the streaming version of this
/// algorithm see:
///
/// "Streaming Simplification of Tetrahedral Meshes" by H. T. Vo,
/// S. P. Callahan, P. Lindstrom, V. Pascucci and C. T. Silva, IEEE
/// Transactions on Visualization and Computer Graphics, 13(1):145-155,
/// 2007.
///
///
/// @par Acknowledgments:
/// This code was developed by Huy T. Vo under the supervision of
/// Prof. Claudio T. Silva. The code also contains contributions from
/// Peter Lindstrom and Steven P. Callahan.
///
/// @par Acknowledgments:
/// The work was supported by grants, contracts, and gifts from the
/// National Science Foundation, the Department of Energy and IBM.
/// </remarks>
public class vtkUnstructuredGridQuadricDecimation : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Set/Get the scalar field name used for simplification
	/// </summary>
	public enum NON_ERROR_WrapperEnum
	{
		/// <summary>enum member</summary>
		NON_ERROR = 0,
		/// <summary>enum member</summary>
		NON_TETRAHEDRA = 1,
		/// <summary>enum member</summary>
		NO_CELLS = 3,
		/// <summary>enum member</summary>
		NO_SCALARS = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridQuadricDecimation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridQuadricDecimation()
	{
		MRClassNameKey = "class vtkUnstructuredGridQuadricDecimation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridQuadricDecimation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridQuadricDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridQuadricDecimation New()
	{
		vtkUnstructuredGridQuadricDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridQuadricDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridQuadricDecimation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridQuadricDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidates_01(HandleRef pThis);

	/// <summary>
	/// Enable(1)/Disable(0) the feature of temporarily doubling the number of
	/// candidates for each randomized set if the quadric error was significantly
	/// increased over the last edge collapse, i.e. if the ratio between the error
	/// difference and the last error is over some threshold. Basically, we are
	/// trying to make up for cases when random selection returns so many 'bad'
	/// edges. By doing this we can achieve a higher quality output with much less
	/// time than just double the NumberOfCandidates. Default is Enabled(1)
	/// </summary>
	public virtual int GetAutoAddCandidates()
	{
		return vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidates_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidatesThreshold_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the threshold that decides when to double the set size.
	/// Default is 0.4.
	/// </summary>
	public virtual double GetAutoAddCandidatesThreshold()
	{
		return vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidatesThreshold_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnstructuredGridQuadricDecimation_GetBoundaryWeight_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the weight of the boundary on the quadric metrics. The larger
	/// the number, the better the boundary is preserved.
	/// </summary>
	public virtual double GetBoundaryWeight()
	{
		return vtkUnstructuredGridQuadricDecimation_GetBoundaryWeight_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridQuadricDecimation_GetNumberOfCandidates_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of candidates selected for each randomized set before
	/// performing an edge collapse. Increasing this number can help producing
	/// higher quality output but it will be slower. Default is 8.
	/// </summary>
	public virtual int GetNumberOfCandidates()
	{
		return vtkUnstructuredGridQuadricDecimation_GetNumberOfCandidates_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridQuadricDecimation_GetNumberOfEdgesToDecimate_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired number of edge to collapse
	/// </summary>
	public virtual int GetNumberOfEdgesToDecimate()
	{
		return vtkUnstructuredGridQuadricDecimation_GetNumberOfEdgesToDecimate_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridQuadricDecimation_GetNumberOfTetsOutput_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired number of tetrahedra to be outputted
	/// </summary>
	public virtual int GetNumberOfTetsOutput()
	{
		return vtkUnstructuredGridQuadricDecimation_GetNumberOfTetsOutput_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_GetScalarsName_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar field name used for simplification
	/// </summary>
	public virtual string GetScalarsName()
	{
		return Marshal.PtrToStringAnsi(vtkUnstructuredGridQuadricDecimation_GetScalarsName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnstructuredGridQuadricDecimation_GetTargetReduction_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired reduction (expressed as a fraction of the original
	/// number of tetrehedra)
	/// </summary>
	public virtual double GetTargetReduction()
	{
		return vtkUnstructuredGridQuadricDecimation_GetTargetReduction_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridQuadricDecimation_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridQuadricDecimation_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridQuadricDecimation_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridQuadricDecimation_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridQuadricDecimation NewInstance()
	{
		vtkUnstructuredGridQuadricDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridQuadricDecimation_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridQuadricDecimation SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridQuadricDecimation vtkUnstructuredGridQuadricDecimation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridQuadricDecimation_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridQuadricDecimation2 = (vtkUnstructuredGridQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridQuadricDecimation2.Register(null);
			}
		}
		return vtkUnstructuredGridQuadricDecimation2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidates_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable(1)/Disable(0) the feature of temporarily doubling the number of
	/// candidates for each randomized set if the quadric error was significantly
	/// increased over the last edge collapse, i.e. if the ratio between the error
	/// difference and the last error is over some threshold. Basically, we are
	/// trying to make up for cases when random selection returns so many 'bad'
	/// edges. By doing this we can achieve a higher quality output with much less
	/// time than just double the NumberOfCandidates. Default is Enabled(1)
	/// </summary>
	public virtual void SetAutoAddCandidates(int _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidates_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidatesThreshold_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the threshold that decides when to double the set size.
	/// Default is 0.4.
	/// </summary>
	public virtual void SetAutoAddCandidatesThreshold(double _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidatesThreshold_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetBoundaryWeight_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the weight of the boundary on the quadric metrics. The larger
	/// the number, the better the boundary is preserved.
	/// </summary>
	public virtual void SetBoundaryWeight(double _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetBoundaryWeight_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetNumberOfCandidates_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of candidates selected for each randomized set before
	/// performing an edge collapse. Increasing this number can help producing
	/// higher quality output but it will be slower. Default is 8.
	/// </summary>
	public virtual void SetNumberOfCandidates(int _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetNumberOfCandidates_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetNumberOfEdgesToDecimate_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the desired number of edge to collapse
	/// </summary>
	public virtual void SetNumberOfEdgesToDecimate(int _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetNumberOfEdgesToDecimate_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetNumberOfTetsOutput_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the desired number of tetrahedra to be outputted
	/// </summary>
	public virtual void SetNumberOfTetsOutput(int _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetNumberOfTetsOutput_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetScalarsName_22(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the scalar field name used for simplification
	/// </summary>
	public virtual void SetScalarsName(string _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetScalarsName_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridQuadricDecimation_SetTargetReduction_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the desired reduction (expressed as a fraction of the original
	/// number of tetrehedra)
	/// </summary>
	public virtual void SetTargetReduction(double _arg)
	{
		vtkUnstructuredGridQuadricDecimation_SetTargetReduction_23(GetCppThis(), _arg);
	}
}
