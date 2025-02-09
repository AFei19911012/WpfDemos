using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMeanValueCoordinatesInterpolator
/// </summary>
/// <remarks>
///    compute interpolation computes
/// for closed triangular mesh
///
/// vtkMeanValueCoordinatesInterpolator computes interpolation weights for a
/// closed, manifold polyhedron mesh.  Once computed, the interpolation
/// weights can be used to interpolate data anywhere interior or exterior to
/// the mesh. This work implements two MVC algorithms. The first one is for
/// triangular meshes which is documented in the Siggraph 2005 paper by Tao Ju,
/// Scot Schaefer and Joe Warren from Rice University "Mean Value Coordinates
/// for Closed Triangular Meshes". The second one is for general polyhedron
/// mesh which is documented in the Eurographics Symposium on Geometry Processing
/// 2006 paper by Torsten Langer, Alexander Belyaev and Hans-Peter Seidel from
/// MPI Informatik "Spherical Barycentric Coordinates".
/// The filter will automatically choose which algorithm to use based on whether
/// the input mesh is triangulated or not.
///
/// In VTK this class was initially created to interpolate data across
/// polyhedral cells. In addition, the class can be used to interpolate
/// data values from a polyhedron mesh, and to smoothly deform a mesh from
/// an associated control mesh.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyhedralCell
/// </seealso>
public class vtkMeanValueCoordinatesInterpolator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMeanValueCoordinatesInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMeanValueCoordinatesInterpolator()
	{
		MRClassNameKey = "class vtkMeanValueCoordinatesInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeanValueCoordinatesInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMeanValueCoordinatesInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public new static vtkMeanValueCoordinatesInterpolator New()
	{
		vtkMeanValueCoordinatesInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeanValueCoordinatesInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public vtkMeanValueCoordinatesInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMeanValueCoordinatesInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_01(IntPtr x, HandleRef pts, HandleRef tris, IntPtr weights);

	/// <summary>
	/// Method to generate interpolation weights for a point x[3] from a list of
	/// triangles.  In this version of the method, the triangles are defined by
	/// a vtkPoints array plus a vtkIdList, where the vtkIdList is organized
	/// such that three ids in order define a triangle.  Note that number of weights
	/// must equal the number of points.
	/// </summary>
	public static void ComputeInterpolationWeights(IntPtr x, vtkPoints pts, vtkIdList tris, IntPtr weights)
	{
		vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_01(x, pts?.GetCppThis() ?? default(HandleRef), tris?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_02(IntPtr x, HandleRef pts, HandleRef tris, IntPtr weights);

	/// <summary>
	/// Method to generate interpolation weights for a point x[3] from a list of
	/// polygonal faces.  In this version of the method, the faces are defined by
	/// a vtkPoints array plus a vtkCellArray, where the vtkCellArray contains all
	/// faces and is of format [nFace0Pts, pid1, pid2, pid3,..., nFace1Pts, pid1,
	/// pid2, pid3,...].  Note: the number of weights must equal the number of points.
	/// </summary>
	public static void ComputeInterpolationWeights(IntPtr x, vtkPoints pts, vtkCellArray tris, IntPtr weights)
	{
		vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_02(x, pts?.GetCppThis() ?? default(HandleRef), tris?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMeanValueCoordinatesInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeanValueCoordinatesInterpolator_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMeanValueCoordinatesInterpolator_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeanValueCoordinatesInterpolator_IsTypeOf_06(string type);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMeanValueCoordinatesInterpolator_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public new vtkMeanValueCoordinatesInterpolator NewInstance()
	{
		vtkMeanValueCoordinatesInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeanValueCoordinatesInterpolator_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiable class methods.
	/// </summary>
	public new static vtkMeanValueCoordinatesInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkMeanValueCoordinatesInterpolator vtkMeanValueCoordinatesInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeanValueCoordinatesInterpolator_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMeanValueCoordinatesInterpolator2 = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMeanValueCoordinatesInterpolator2.Register(null);
			}
		}
		return vtkMeanValueCoordinatesInterpolator2;
	}
}
