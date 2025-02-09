using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPCAAnalysisFilter
/// </summary>
/// <remarks>
///    Performs principal component analysis of a set of aligned pointsets
///
///
/// vtkPCAAnalysisFilter is a filter that takes as input a set of aligned
/// pointsets (any object derived from vtkPointSet) and performs
/// a principal component analysis of the coordinates.
/// This can be used to visualise the major or minor modes of variation
/// seen in a set of similar biological objects with corresponding
/// landmarks.
/// vtkPCAAnalysisFilter is designed to work with the output from
/// the vtkProcrustesAnalysisFilter
/// vtkPCAAnalysisFilter requires a vtkMultiBlock input consisting
/// of vtkPointSets as first level children.
///
/// vtkPCAAnalysisFilter is an implementation of (for example):
///
/// T. Cootes et al. : Active Shape Models - their training and application.
/// Computer Vision and Image Understanding, 61(1):38-59, 1995.
///
/// The material can also be found in Tim Cootes' ever-changing online report
/// published at his website:
/// http://www.isbe.man.ac.uk/~bim/
///
/// @warning
/// All of the input pointsets must have the same number of points.
///
/// @par Thanks:
/// Rasmus Paulsen and Tim Hutton who developed and contributed this class
///
/// </remarks>
/// <seealso>
///
/// vtkProcrustesAlignmentFilter
/// </seealso>
public class vtkPCAAnalysisFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPCAAnalysisFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPCAAnalysisFilter()
	{
		MRClassNameKey = "class vtkPCAAnalysisFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCAAnalysisFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPCAAnalysisFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAAnalysisFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates with similarity transform.
	/// </summary>
	public new static vtkPCAAnalysisFilter New()
	{
		vtkPCAAnalysisFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAAnalysisFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates with similarity transform.
	/// </summary>
	public vtkPCAAnalysisFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPCAAnalysisFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAAnalysisFilter_GetEvals_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vector of eigenvalues sorted in descending order
	/// </summary>
	public virtual vtkFloatArray GetEvals()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAAnalysisFilter_GetEvals_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAAnalysisFilter_GetModesRequiredFor_02(HandleRef pThis, double proportion);

	/// <summary>
	/// Retrieve how many modes are necessary to model the given proportion of the variation.
	/// proportion should be between 0 and 1
	/// </summary>
	public int GetModesRequiredFor(double proportion)
	{
		return vtkPCAAnalysisFilter_GetModesRequiredFor_02(GetCppThis(), proportion);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAAnalysisFilter_GetParameterisedShape_05(HandleRef pThis, HandleRef b, HandleRef shape);

	/// <summary>
	/// Fills the shape with:
	///
	/// mean + b[0] * sqrt(eigenvalue[0]) * eigenvector[0]
	/// + b[1] * sqrt(eigenvalue[1]) * eigenvector[1]
	/// ...
	/// + b[sizeb-1] * sqrt(eigenvalue[bsize-1]) * eigenvector[bsize-1]
	///
	/// here b are the parameters expressed in standard deviations
	/// bsize is the number of parameters in the b vector
	/// This function assumes that shape is already allocated
	/// with the right size, it just moves the points.
	/// </summary>
	public void GetParameterisedShape(vtkFloatArray b, vtkPointSet shape)
	{
		vtkPCAAnalysisFilter_GetParameterisedShape_05(GetCppThis(), b?.GetCppThis() ?? default(HandleRef), shape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAAnalysisFilter_GetShapeParameters_06(HandleRef pThis, HandleRef shape, HandleRef b, int bsize);

	/// <summary>
	/// Return the bsize parameters b that best model the given shape
	/// (in standard deviations).
	/// That is that the given shape will be approximated by:
	///
	/// shape ~ mean + b[0] * sqrt(eigenvalue[0]) * eigenvector[0]
	/// + b[1] * sqrt(eigenvalue[1]) * eigenvector[1]
	/// ...
	/// + b[bsize-1] * sqrt(eigenvalue[bsize-1]) * eigenvector[bsize-1]
	/// </summary>
	public void GetShapeParameters(vtkPointSet shape, vtkFloatArray b, int bsize)
	{
		vtkPCAAnalysisFilter_GetShapeParameters_06(GetCppThis(), shape?.GetCppThis() ?? default(HandleRef), b?.GetCppThis() ?? default(HandleRef), bsize);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAAnalysisFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPCAAnalysisFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAAnalysisFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPCAAnalysisFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAAnalysisFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPCAAnalysisFilter NewInstance()
	{
		vtkPCAAnalysisFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAAnalysisFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAAnalysisFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPCAAnalysisFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPCAAnalysisFilter vtkPCAAnalysisFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAAnalysisFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPCAAnalysisFilter2 = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPCAAnalysisFilter2.Register(null);
			}
		}
		return vtkPCAAnalysisFilter2;
	}
}
