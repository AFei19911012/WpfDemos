using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTriangularTCoords
/// </summary>
/// <remarks>
///    2D texture coordinates based for triangles.
///
/// vtkTriangularTCoords is a filter that generates texture coordinates
/// for triangles. Texture coordinates for each triangle are:
/// (0,0), (1,0) and (.5,sqrt(3)/2). This filter assumes that the triangle
/// texture map is symmetric about the center of the triangle. Thus the order
/// Of the texture coordinates is not important. The procedural texture
/// in vtkTriangularTexture is designed with this symmetry. For more information
/// see the paper "Opacity-modulating Triangular Textures for Irregular
/// Surfaces,"  by Penny Rheingans, IEEE Visualization '96, pp. 219-225.
/// </remarks>
/// <seealso>
///
/// vtkTriangularTexture vtkThresholdPoints vtkTextureMapToPlane
/// vtkTextureMapToSphere vtkTextureMapToCylinder
/// </seealso>
public class vtkTriangularTCoords : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTriangularTCoords";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTriangularTCoords()
	{
		MRClassNameKey = "class vtkTriangularTCoords";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangularTCoords"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTriangularTCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangularTCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangularTCoords New()
	{
		vtkTriangularTCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangularTCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTriangularTCoords()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTriangularTCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangularTCoords_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTriangularTCoords_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangularTCoords_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTriangularTCoords_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTCoords_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTriangularTCoords_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTCoords_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTriangularTCoords_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangularTCoords_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTriangularTCoords NewInstance()
	{
		vtkTriangularTCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangularTCoords_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangularTCoords_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangularTCoords SafeDownCast(vtkObjectBase o)
	{
		vtkTriangularTCoords vtkTriangularTCoords2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangularTCoords_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTriangularTCoords2 = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTriangularTCoords2.Register(null);
			}
		}
		return vtkTriangularTCoords2;
	}
}
