using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSurfaceReconstructionFilter
/// </summary>
/// <remarks>
///    reconstructs a surface from unorganized points
///
/// vtkSurfaceReconstructionFilter takes a list of points assumed to lie on
/// the surface of a solid 3D object. A signed measure of the distance to the
/// surface is computed and sampled on a regular grid. The grid can then be
/// contoured at zero to extract the surface. The default values for
/// neighborhood size and sample spacing should give reasonable results for
/// most uses but can be set if desired. This procedure is based on the PhD
/// work of Hugues Hoppe: http://www.research.microsoft.com/~hoppe
/// </remarks>
public class vtkSurfaceReconstructionFilter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceReconstructionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSurfaceReconstructionFilter()
	{
		MRClassNameKey = "class vtkSurfaceReconstructionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceReconstructionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSurfaceReconstructionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceReconstructionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with NeighborhoodSize=20.
	/// </summary>
	public new static vtkSurfaceReconstructionFilter New()
	{
		vtkSurfaceReconstructionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceReconstructionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with NeighborhoodSize=20.
	/// </summary>
	public vtkSurfaceReconstructionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSurfaceReconstructionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceReconstructionFilter_GetNeighborhoodSize_01(HandleRef pThis);

	/// <summary>
	/// Specify the number of neighbors each point has, used for estimating the
	/// local surface orientation.  The default value of 20 should be OK for
	/// most applications, higher values can be specified if the spread of
	/// points is uneven. Values as low as 10 may yield adequate results for
	/// some surfaces. Higher values cause the algorithm to take longer. Higher
	/// values will cause errors on sharp boundaries.
	/// </summary>
	public virtual int GetNeighborhoodSize()
	{
		return vtkSurfaceReconstructionFilter_GetNeighborhoodSize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSurfaceReconstructionFilter_GetSampleSpacing_04(HandleRef pThis);

	/// <summary>
	/// Specify the spacing of the 3D sampling grid. If not set, a
	/// reasonable guess will be made.
	/// </summary>
	public virtual double GetSampleSpacing()
	{
		return vtkSurfaceReconstructionFilter_GetSampleSpacing_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceReconstructionFilter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSurfaceReconstructionFilter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceReconstructionFilter_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSurfaceReconstructionFilter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceReconstructionFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSurfaceReconstructionFilter NewInstance()
	{
		vtkSurfaceReconstructionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceReconstructionFilter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceReconstructionFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSurfaceReconstructionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSurfaceReconstructionFilter vtkSurfaceReconstructionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceReconstructionFilter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSurfaceReconstructionFilter2 = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSurfaceReconstructionFilter2.Register(null);
			}
		}
		return vtkSurfaceReconstructionFilter2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceReconstructionFilter_SetNeighborhoodSize_10(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of neighbors each point has, used for estimating the
	/// local surface orientation.  The default value of 20 should be OK for
	/// most applications, higher values can be specified if the spread of
	/// points is uneven. Values as low as 10 may yield adequate results for
	/// some surfaces. Higher values cause the algorithm to take longer. Higher
	/// values will cause errors on sharp boundaries.
	/// </summary>
	public virtual void SetNeighborhoodSize(int _arg)
	{
		vtkSurfaceReconstructionFilter_SetNeighborhoodSize_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceReconstructionFilter_SetSampleSpacing_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the spacing of the 3D sampling grid. If not set, a
	/// reasonable guess will be made.
	/// </summary>
	public virtual void SetSampleSpacing(double _arg)
	{
		vtkSurfaceReconstructionFilter_SetSampleSpacing_11(GetCppThis(), _arg);
	}
}
