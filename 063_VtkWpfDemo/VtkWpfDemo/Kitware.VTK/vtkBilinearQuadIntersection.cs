using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBilinearQuadIntersection
/// </summary>
/// <remarks>
///    Class to perform non planar quad intersection
///
/// Class for non planar quad intersection.
/// This class is an updated and fixed version of the code by Ramsey et al.
/// (http://shaunramsey.com/research/bp/).
/// </remarks>
public class vtkBilinearQuadIntersection : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBilinearQuadIntersection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBilinearQuadIntersection()
	{
		MRClassNameKey = "class vtkBilinearQuadIntersection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBilinearQuadIntersection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBilinearQuadIntersection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBilinearQuadIntersection_ComputeCartesianCoordinates_01(HandleRef pThis, double u, double v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute cartesian coordinates of point in the quad
	/// using parameteric coordinates
	/// </summary>
	public vtkVector3d ComputeCartesianCoordinates(double u, double v)
	{
		vtkVector3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBilinearQuadIntersection_ComputeCartesianCoordinates_01(GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBilinearQuadIntersection_GetP00Data_02(HandleRef pThis);

	/// <summary>
	/// Get direct access to the underlying point data
	/// </summary>
	public IntPtr GetP00Data()
	{
		return vtkBilinearQuadIntersection_GetP00Data_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBilinearQuadIntersection_GetP01Data_03(HandleRef pThis);

	/// <summary>
	/// Get direct access to the underlying point data
	/// </summary>
	public IntPtr GetP01Data()
	{
		return vtkBilinearQuadIntersection_GetP01Data_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBilinearQuadIntersection_GetP10Data_04(HandleRef pThis);

	/// <summary>
	/// Get direct access to the underlying point data
	/// </summary>
	public IntPtr GetP10Data()
	{
		return vtkBilinearQuadIntersection_GetP10Data_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBilinearQuadIntersection_GetP11Data_05(HandleRef pThis);

	/// <summary>
	/// Get direct access to the underlying point data
	/// </summary>
	public IntPtr GetP11Data()
	{
		return vtkBilinearQuadIntersection_GetP11Data_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBilinearQuadIntersection_RayIntersection_06(HandleRef pThis, HandleRef r, HandleRef q, HandleRef uv);

	/// <summary>
	/// Compute the intersection between a ray r-&gt;q and the quad
	/// </summary>
	public bool RayIntersection(vtkVector3d r, vtkVector3d q, vtkVector3d uv)
	{
		return (vtkBilinearQuadIntersection_RayIntersection_06(GetCppThis(), r?.GetCppThis() ?? default(HandleRef), q?.GetCppThis() ?? default(HandleRef), uv?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}
}
