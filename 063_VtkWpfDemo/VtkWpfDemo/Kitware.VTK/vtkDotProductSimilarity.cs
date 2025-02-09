using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDotProductSimilarity
/// </summary>
/// <remarks>
///    compute dot-product similarity metrics.
///
///
/// Treats matrices as collections of vectors and computes dot-product similarity
/// metrics between vectors.
///
/// The results are returned as an edge-table that lists the index of each vector
/// and their computed similarity.  The output edge-table is typically used with
/// vtkTableToGraph to create a similarity graph.
///
/// This filter can be used with one or two input matrices.  If you provide a single
/// matrix as input, every vector in the matrix is compared with every other vector. If
/// you provide two matrices, every vector in the first matrix is compared with every
/// vector in the second matrix.
///
/// Note that this filter *only* computes the dot-product between each pair of vectors;
/// if you want to compute the cosine of the angles between vectors, you will need to
/// normalize the inputs yourself.
///
/// Inputs:
///   Input port 0: (required) A vtkDenseArray&lt;double&gt; with two dimensions (a matrix).
///   Input port 1: (optional) A vtkDenseArray&lt;double&gt; with two dimensions (a matrix).
///
/// Outputs:
///   Output port 0: A vtkTable containing "source", "target", and "similarity" columns.
///
/// @warning
/// Note that the complexity of this filter is quadratic!  It also requires dense arrays
/// as input, in the future it should be generalized to accept sparse arrays.
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkDotProductSimilarity : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDotProductSimilarity";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDotProductSimilarity()
	{
		MRClassNameKey = "class vtkDotProductSimilarity";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDotProductSimilarity"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDotProductSimilarity(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDotProductSimilarity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDotProductSimilarity New()
	{
		vtkDotProductSimilarity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDotProductSimilarity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDotProductSimilarity()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDotProductSimilarity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_GetDiagonal_01(HandleRef pThis);

	/// <summary>
	/// When computing similarities for a single input matrix, controls whether the
	/// results will include the diagonal of the similarity matrix.  Default: false.
	/// </summary>
	public virtual int GetDiagonal()
	{
		return vtkDotProductSimilarity_GetDiagonal_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_GetFirstSecond_02(HandleRef pThis);

	/// <summary>
	/// When computing similarities for two input matrices, controls whether the results
	/// will include comparisons from the first matrix to the second matrix.
	/// </summary>
	public virtual int GetFirstSecond()
	{
		return vtkDotProductSimilarity_GetFirstSecond_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_GetLowerDiagonal_03(HandleRef pThis);

	/// <summary>
	/// When computing similarities for a single input matrix, controls whether the
	/// results will include the lower diagonal of the similarity matrix.  Default: false.
	/// </summary>
	public virtual int GetLowerDiagonal()
	{
		return vtkDotProductSimilarity_GetLowerDiagonal_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDotProductSimilarity_GetMaximumCount_04(HandleRef pThis);

	/// <summary>
	/// Specifies a maximum number of edges to include for each vector.
	/// </summary>
	public virtual long GetMaximumCount()
	{
		return vtkDotProductSimilarity_GetMaximumCount_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDotProductSimilarity_GetMinimumCount_05(HandleRef pThis);

	/// <summary>
	/// Specifies a minimum number of edges to include for each vector.
	/// </summary>
	public virtual long GetMinimumCount()
	{
		return vtkDotProductSimilarity_GetMinimumCount_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDotProductSimilarity_GetMinimumThreshold_06(HandleRef pThis);

	/// <summary>
	/// Specifies a minimum threshold that a similarity must exceed to be included in
	/// the output.
	/// </summary>
	public virtual double GetMinimumThreshold()
	{
		return vtkDotProductSimilarity_GetMinimumThreshold_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDotProductSimilarity_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDotProductSimilarity_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDotProductSimilarity_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDotProductSimilarity_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_GetSecondFirst_09(HandleRef pThis);

	/// <summary>
	/// When computing similarities for two input matrices, controls whether the results
	/// will include comparisons from the second matrix to the first matrix.
	/// </summary>
	public virtual int GetSecondFirst()
	{
		return vtkDotProductSimilarity_GetSecondFirst_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_GetUpperDiagonal_10(HandleRef pThis);

	/// <summary>
	/// When computing similarities for a single input matrix, controls whether the
	/// results will include the upper diagonal of the similarity matrix.  Default: true.
	/// </summary>
	public virtual int GetUpperDiagonal()
	{
		return vtkDotProductSimilarity_GetUpperDiagonal_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDotProductSimilarity_GetVectorDimension_11(HandleRef pThis);

	/// <summary>
	/// Controls whether to compute similarities for row-vectors or column-vectors.
	/// 0 = rows, 1 = columns.
	/// </summary>
	public virtual long GetVectorDimension()
	{
		return vtkDotProductSimilarity_GetVectorDimension_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDotProductSimilarity_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDotProductSimilarity_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDotProductSimilarity_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDotProductSimilarity_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDotProductSimilarity NewInstance()
	{
		vtkDotProductSimilarity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDotProductSimilarity_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDotProductSimilarity_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDotProductSimilarity SafeDownCast(vtkObjectBase o)
	{
		vtkDotProductSimilarity vtkDotProductSimilarity2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDotProductSimilarity_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDotProductSimilarity2 = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDotProductSimilarity2.Register(null);
			}
		}
		return vtkDotProductSimilarity2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetDiagonal_17(HandleRef pThis, int _arg);

	/// <summary>
	/// When computing similarities for a single input matrix, controls whether the
	/// results will include the diagonal of the similarity matrix.  Default: false.
	/// </summary>
	public virtual void SetDiagonal(int _arg)
	{
		vtkDotProductSimilarity_SetDiagonal_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetFirstSecond_18(HandleRef pThis, int _arg);

	/// <summary>
	/// When computing similarities for two input matrices, controls whether the results
	/// will include comparisons from the first matrix to the second matrix.
	/// </summary>
	public virtual void SetFirstSecond(int _arg)
	{
		vtkDotProductSimilarity_SetFirstSecond_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetLowerDiagonal_19(HandleRef pThis, int _arg);

	/// <summary>
	/// When computing similarities for a single input matrix, controls whether the
	/// results will include the lower diagonal of the similarity matrix.  Default: false.
	/// </summary>
	public virtual void SetLowerDiagonal(int _arg)
	{
		vtkDotProductSimilarity_SetLowerDiagonal_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetMaximumCount_20(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies a maximum number of edges to include for each vector.
	/// </summary>
	public virtual void SetMaximumCount(long _arg)
	{
		vtkDotProductSimilarity_SetMaximumCount_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetMinimumCount_21(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies a minimum number of edges to include for each vector.
	/// </summary>
	public virtual void SetMinimumCount(long _arg)
	{
		vtkDotProductSimilarity_SetMinimumCount_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetMinimumThreshold_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Specifies a minimum threshold that a similarity must exceed to be included in
	/// the output.
	/// </summary>
	public virtual void SetMinimumThreshold(double _arg)
	{
		vtkDotProductSimilarity_SetMinimumThreshold_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetSecondFirst_23(HandleRef pThis, int _arg);

	/// <summary>
	/// When computing similarities for two input matrices, controls whether the results
	/// will include comparisons from the second matrix to the first matrix.
	/// </summary>
	public virtual void SetSecondFirst(int _arg)
	{
		vtkDotProductSimilarity_SetSecondFirst_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetUpperDiagonal_24(HandleRef pThis, int _arg);

	/// <summary>
	/// When computing similarities for a single input matrix, controls whether the
	/// results will include the upper diagonal of the similarity matrix.  Default: true.
	/// </summary>
	public virtual void SetUpperDiagonal(int _arg)
	{
		vtkDotProductSimilarity_SetUpperDiagonal_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDotProductSimilarity_SetVectorDimension_25(HandleRef pThis, long _arg);

	/// <summary>
	/// Controls whether to compute similarities for row-vectors or column-vectors.
	/// 0 = rows, 1 = columns.
	/// </summary>
	public virtual void SetVectorDimension(long _arg)
	{
		vtkDotProductSimilarity_SetVectorDimension_25(GetCppThis(), _arg);
	}
}
