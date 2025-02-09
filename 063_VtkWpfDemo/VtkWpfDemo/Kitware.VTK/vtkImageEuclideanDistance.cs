using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageEuclideanDistance
/// </summary>
/// <remarks>
///    computes 3D Euclidean DT
///
/// vtkImageEuclideanDistance implements the Euclidean DT using
/// Saito's algorithm. The distance map produced contains the square of the
/// Euclidean distance values.
///
/// The algorithm has a o(n^(D+1)) complexity over nxnx...xn images in D
/// dimensions. It is very efficient on relatively small images. Cuisenaire's
/// algorithms should be used instead if n &gt;&gt; 500. These are not implemented
/// yet.
///
/// For the special case of images where the slice-size is a multiple of
/// 2^N with a large N (typically for 256x256 slices), Saito's algorithm
/// encounters a lot of cache conflicts during the 3rd iteration which can
/// slow it very significantly. In that case, one should use
/// vtkImageEuclideanDistance::SetAlgorithmToSaitoCached() instead for better performance.
///
/// References:
///
/// T. Saito and J.I. Toriwaki. New algorithms for Euclidean distance
/// transformations of an n-dimensional digitised picture with applications.
/// Pattern Recognition, 27(11). pp. 1551--1565, 1994.
///
/// O. Cuisenaire. Distance Transformation: fast algorithms and applications
/// to medical image processing. PhD Thesis, Universite catholique de Louvain,
/// October 1999. http://ltswww.epfl.ch/~cuisenai/papers/oc_thesis.pdf
/// </remarks>
public class vtkImageEuclideanDistance : vtkImageDecomposeFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageEuclideanDistance";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageEuclideanDistance()
	{
		MRClassNameKey = "class vtkImageEuclideanDistance";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEuclideanDistance"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageEuclideanDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEuclideanDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageEuclideanDistance New()
	{
		vtkImageEuclideanDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageEuclideanDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageEuclideanDistance()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageEuclideanDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_ConsiderAnisotropyOff_01(HandleRef pThis);

	/// <summary>
	/// Used to define whether Spacing should be used in the computation of the
	/// distances
	/// </summary>
	public virtual void ConsiderAnisotropyOff()
	{
		vtkImageEuclideanDistance_ConsiderAnisotropyOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_ConsiderAnisotropyOn_02(HandleRef pThis);

	/// <summary>
	/// Used to define whether Spacing should be used in the computation of the
	/// distances
	/// </summary>
	public virtual void ConsiderAnisotropyOn()
	{
		vtkImageEuclideanDistance_ConsiderAnisotropyOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEuclideanDistance_GetAlgorithm_03(HandleRef pThis);

	/// <summary>
	/// Selects a Euclidean DT algorithm.
	/// 1. Saito
	/// 2. Saito-cached
	/// More algorithms will be added later on.
	/// </summary>
	public virtual int GetAlgorithm()
	{
		return vtkImageEuclideanDistance_GetAlgorithm_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEuclideanDistance_GetConsiderAnisotropy_04(HandleRef pThis);

	/// <summary>
	/// Used to define whether Spacing should be used in the computation of the
	/// distances
	/// </summary>
	public virtual int GetConsiderAnisotropy()
	{
		return vtkImageEuclideanDistance_GetConsiderAnisotropy_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEuclideanDistance_GetInitialize_05(HandleRef pThis);

	/// <summary>
	/// Used to set all non-zero voxels to MaximumDistance before starting
	/// the distance transformation. Setting Initialize off keeps the current
	/// value in the input image as starting point. This allows to superimpose
	/// several distance maps.
	/// </summary>
	public virtual int GetInitialize()
	{
		return vtkImageEuclideanDistance_GetInitialize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageEuclideanDistance_GetMaximumDistance_06(HandleRef pThis);

	/// <summary>
	/// Any distance bigger than this-&gt;MaximumDistance will not ne computed but
	/// set to this-&gt;MaximumDistance instead.
	/// </summary>
	public virtual double GetMaximumDistance()
	{
		return vtkImageEuclideanDistance_GetMaximumDistance_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageEuclideanDistance_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageEuclideanDistance_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageEuclideanDistance_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageEuclideanDistance_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_InitializeOff_09(HandleRef pThis);

	/// <summary>
	/// Used to set all non-zero voxels to MaximumDistance before starting
	/// the distance transformation. Setting Initialize off keeps the current
	/// value in the input image as starting point. This allows to superimpose
	/// several distance maps.
	/// </summary>
	public virtual void InitializeOff()
	{
		vtkImageEuclideanDistance_InitializeOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_InitializeOn_10(HandleRef pThis);

	/// <summary>
	/// Used to set all non-zero voxels to MaximumDistance before starting
	/// the distance transformation. Setting Initialize off keeps the current
	/// value in the input image as starting point. This allows to superimpose
	/// several distance maps.
	/// </summary>
	public virtual void InitializeOn()
	{
		vtkImageEuclideanDistance_InitializeOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEuclideanDistance_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageEuclideanDistance_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEuclideanDistance_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageEuclideanDistance_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEuclideanDistance_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageEuclideanDistance NewInstance()
	{
		vtkImageEuclideanDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageEuclideanDistance_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEuclideanDistance_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageEuclideanDistance SafeDownCast(vtkObjectBase o)
	{
		vtkImageEuclideanDistance vtkImageEuclideanDistance2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageEuclideanDistance_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageEuclideanDistance2 = (vtkImageEuclideanDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageEuclideanDistance2.Register(null);
			}
		}
		return vtkImageEuclideanDistance2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_SetAlgorithm_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Selects a Euclidean DT algorithm.
	/// 1. Saito
	/// 2. Saito-cached
	/// More algorithms will be added later on.
	/// </summary>
	public virtual void SetAlgorithm(int _arg)
	{
		vtkImageEuclideanDistance_SetAlgorithm_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_SetAlgorithmToSaito_17(HandleRef pThis);

	/// <summary>
	/// Selects a Euclidean DT algorithm.
	/// 1. Saito
	/// 2. Saito-cached
	/// More algorithms will be added later on.
	/// </summary>
	public void SetAlgorithmToSaito()
	{
		vtkImageEuclideanDistance_SetAlgorithmToSaito_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_SetAlgorithmToSaitoCached_18(HandleRef pThis);

	/// <summary>
	/// Selects a Euclidean DT algorithm.
	/// 1. Saito
	/// 2. Saito-cached
	/// More algorithms will be added later on.
	/// </summary>
	public void SetAlgorithmToSaitoCached()
	{
		vtkImageEuclideanDistance_SetAlgorithmToSaitoCached_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_SetConsiderAnisotropy_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Used to define whether Spacing should be used in the computation of the
	/// distances
	/// </summary>
	public virtual void SetConsiderAnisotropy(int _arg)
	{
		vtkImageEuclideanDistance_SetConsiderAnisotropy_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_SetInitialize_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Used to set all non-zero voxels to MaximumDistance before starting
	/// the distance transformation. Setting Initialize off keeps the current
	/// value in the input image as starting point. This allows to superimpose
	/// several distance maps.
	/// </summary>
	public virtual void SetInitialize(int _arg)
	{
		vtkImageEuclideanDistance_SetInitialize_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEuclideanDistance_SetMaximumDistance_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Any distance bigger than this-&gt;MaximumDistance will not ne computed but
	/// set to this-&gt;MaximumDistance instead.
	/// </summary>
	public virtual void SetMaximumDistance(double _arg)
	{
		vtkImageEuclideanDistance_SetMaximumDistance_21(GetCppThis(), _arg);
	}
}
