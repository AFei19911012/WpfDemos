using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFiniteDifferenceGradientEstimator
/// </summary>
/// <remarks>
///    Use finite differences to estimate gradient.
///
///
///  vtkFiniteDifferenceGradientEstimator is a concrete subclass of
///  vtkEncodedGradientEstimator that uses a central differences technique to
///  estimate the gradient. The gradient at some sample location (x,y,z)
///  would be estimated by:
///
///       nx = (f(x-dx,y,z) - f(x+dx,y,z)) / 2*dx;
///       ny = (f(x,y-dy,z) - f(x,y+dy,z)) / 2*dy;
///       nz = (f(x,y,z-dz) - f(x,y,z+dz)) / 2*dz;
///
///  This value is normalized to determine a unit direction vector and a
///  magnitude. The normal is computed in voxel space, and
///  dx = dy = dz = SampleSpacingInVoxels. A scaling factor is applied to
///  convert this normal from voxel space to world coordinates.
///
/// </remarks>
/// <seealso>
///
/// vtkEncodedGradientEstimator
/// </seealso>
public class vtkFiniteDifferenceGradientEstimator : vtkEncodedGradientEstimator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFiniteDifferenceGradientEstimator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFiniteDifferenceGradientEstimator()
	{
		MRClassNameKey = "class vtkFiniteDifferenceGradientEstimator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFiniteDifferenceGradientEstimator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFiniteDifferenceGradientEstimator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkFiniteDifferenceGradientEstimator with
	/// a SampleSpacingInVoxels of 1.
	/// </summary>
	public new static vtkFiniteDifferenceGradientEstimator New()
	{
		vtkFiniteDifferenceGradientEstimator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFiniteDifferenceGradientEstimator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkFiniteDifferenceGradientEstimator with
	/// a SampleSpacingInVoxels of 1.
	/// </summary>
	public vtkFiniteDifferenceGradientEstimator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFiniteDifferenceGradientEstimator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFiniteDifferenceGradientEstimator_GetSampleSpacingInVoxels_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the spacing between samples for the finite differences
	/// method used to compute the normal. This spacing is in voxel units.
	/// </summary>
	public virtual int GetSampleSpacingInVoxels()
	{
		return vtkFiniteDifferenceGradientEstimator_GetSampleSpacingInVoxels_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFiniteDifferenceGradientEstimator_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFiniteDifferenceGradientEstimator_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFiniteDifferenceGradientEstimator_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFiniteDifferenceGradientEstimator_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFiniteDifferenceGradientEstimator NewInstance()
	{
		vtkFiniteDifferenceGradientEstimator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFiniteDifferenceGradientEstimator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFiniteDifferenceGradientEstimator SafeDownCast(vtkObjectBase o)
	{
		vtkFiniteDifferenceGradientEstimator vtkFiniteDifferenceGradientEstimator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFiniteDifferenceGradientEstimator_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFiniteDifferenceGradientEstimator2 = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFiniteDifferenceGradientEstimator2.Register(null);
			}
		}
		return vtkFiniteDifferenceGradientEstimator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFiniteDifferenceGradientEstimator_SetSampleSpacingInVoxels_09(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the spacing between samples for the finite differences
	/// method used to compute the normal. This spacing is in voxel units.
	/// </summary>
	public virtual void SetSampleSpacingInVoxels(int _arg)
	{
		vtkFiniteDifferenceGradientEstimator_SetSampleSpacingInVoxels_09(GetCppThis(), _arg);
	}
}
