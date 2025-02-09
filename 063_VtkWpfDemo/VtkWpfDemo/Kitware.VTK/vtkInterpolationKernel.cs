using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInterpolationKernel
/// </summary>
/// <remarks>
///    base class for interpolation kernels
///
///
/// vtkInterpolationKernel specifies an abstract interface for interpolation
/// kernels. An interpolation kernel is used to produce an interpolated data
/// value at a point X from the points + data in a local neighborhood
/// surrounding X. For example, given the N nearest points surrounding X, the
/// interpolation kernel provides N weights, which when combined with the N
/// data values associated with these nearest points, produces an interpolated
/// data value at point X.
///
/// Note that various kernel initialization methods are provided. The basic
/// method requires providing a point locator to accelerate neighborhood
/// queries. Some kernels may refer back to the original dataset, or the point
/// attribute data associated with the dataset. The initialization method
/// enables different styles of initialization and is kernel-dependent.
///
/// Typically the kernels are invoked in two parts: first, the basis is
/// computed using the supplied point locator and dataset. This basis is a
/// local footprint of point surrounding a poitnX. In this footprint are the
/// neighboring points used to compute the interpolation weights. Then, the
/// weights are computed from points forming the basis. However, advanced
/// users can develop their own basis, skipping the ComputeBasis() method, and
/// then invoke ComputeWeights() directly.
///
/// @warning
/// The ComputeBasis() and ComputeWeights() methods must be thread safe as they
/// are used in threaded algorithms.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkPointInterpolator2D vtkGeneralizedKernel
/// vtkGaussianKernel vtkSPHKernel vtkShepardKernel vtkVoronoiKernel
/// </seealso>
public abstract class vtkInterpolationKernel : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolationKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInterpolationKernel()
	{
		MRClassNameKey = "class vtkInterpolationKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolationKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInterpolationKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolationKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

	/// <summary>
	/// Given a point x (and optional associated point id), determine the points
	/// around x which form an interpolation basis. The user must provide the
	/// vtkIdList pIds, which will be dynamically resized as necessary. The
	/// method returns the number of points in the basis. Typically this method
	/// is called before ComputeWeights(). Note that ptId is optional in most
	/// cases, although in some kernels it is used to facilitate basis
	/// computation.
	/// </summary>
	public virtual long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
	{
		return vtkInterpolationKernel_ComputeBasis_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), ptId);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolationKernel_ComputeWeights_02(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

	/// <summary>
	/// Given a point x, and a list of basis points pIds, compute interpolation
	/// weights associated with these basis points.  Note that both the nearby
	/// basis points list pIds and the weights array are provided by the caller
	/// of the method, and may be dynamically resized as necessary. The method
	/// returns the number of weights (pIds may be resized in some
	/// cases). Typically this method is called after ComputeBasis(), although
	/// advanced users can invoke ComputeWeights() and provide the interpolation
	/// basis points pIds directly.
	/// </summary>
	public virtual long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
	{
		return vtkInterpolationKernel_ComputeWeights_02(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolationKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard method for type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInterpolationKernel_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolationKernel_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard method for type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInterpolationKernel_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInterpolationKernel_GetRequiresInitialization_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether the kernel needs initialization. By default this data
	/// member is true, and using classes will invoke Initialize() on the
	/// kernel. However, if the user takes over initialization manually, then
	/// set RequiresInitialization to false (0).
	/// </summary>
	public virtual bool GetRequiresInitialization()
	{
		return (vtkInterpolationKernel_GetRequiresInitialization_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInterpolationKernel_Initialize_06(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

	/// <summary>
	/// Initialize the kernel. Pass information into the kernel that is
	/// necessary to subsequently perform evaluation. The locator refers to the
	/// points that are to be interpolated from; these points (ds) and the
	/// associated point data (pd) are provided as well. Note that some kernels
	/// may require manual setup / initialization, in which case set
	/// RequiresInitialization to false, do not call Initialize(), and of course
	/// manually initialize the kernel.
	/// </summary>
	public virtual void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
	{
		vtkInterpolationKernel_Initialize_06(GetCppThis(), loc?.GetCppThis() ?? default(HandleRef), ds?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInterpolationKernel_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard method for type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInterpolationKernel_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInterpolationKernel_IsTypeOf_08(string type);

	/// <summary>
	/// Standard method for type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInterpolationKernel_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolationKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard method for type and printing.
	/// </summary>
	public new vtkInterpolationKernel NewInstance()
	{
		vtkInterpolationKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolationKernel_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInterpolationKernel_RequiresInitializationOff_10(HandleRef pThis);

	/// <summary>
	/// Indicate whether the kernel needs initialization. By default this data
	/// member is true, and using classes will invoke Initialize() on the
	/// kernel. However, if the user takes over initialization manually, then
	/// set RequiresInitialization to false (0).
	/// </summary>
	public virtual void RequiresInitializationOff()
	{
		vtkInterpolationKernel_RequiresInitializationOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInterpolationKernel_RequiresInitializationOn_11(HandleRef pThis);

	/// <summary>
	/// Indicate whether the kernel needs initialization. By default this data
	/// member is true, and using classes will invoke Initialize() on the
	/// kernel. However, if the user takes over initialization manually, then
	/// set RequiresInitialization to false (0).
	/// </summary>
	public virtual void RequiresInitializationOn()
	{
		vtkInterpolationKernel_RequiresInitializationOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolationKernel_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard method for type and printing.
	/// </summary>
	public new static vtkInterpolationKernel SafeDownCast(vtkObjectBase o)
	{
		vtkInterpolationKernel vtkInterpolationKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolationKernel_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInterpolationKernel2 = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInterpolationKernel2.Register(null);
			}
		}
		return vtkInterpolationKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInterpolationKernel_SetRequiresInitialization_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether the kernel needs initialization. By default this data
	/// member is true, and using classes will invoke Initialize() on the
	/// kernel. However, if the user takes over initialization manually, then
	/// set RequiresInitialization to false (0).
	/// </summary>
	public virtual void SetRequiresInitialization(bool _arg)
	{
		vtkInterpolationKernel_SetRequiresInitialization_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
