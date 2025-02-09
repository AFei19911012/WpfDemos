using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMarkBoundaryFilter
/// </summary>
/// <remarks>
///    mark points and cells that lie on the boundary of a dataset
///
/// vtkMarkBoundaryFilter is a general-purpose filter to mark those cells and
/// points on the boundary of a dataset. The output of the filter is identical
/// to the input, with the exception that two, new data arrays are added to
/// the output that indicate which input points, and input cells, are on the
/// boundary. (Cells and points on the boundary are indicated by a value ==1,
/// otherwise ==0, and are accessed in the appropriate data array by cell id
/// or point id. The output data arrays are of type vtkUnsignedChar.)
///
/// In general, n-dimensional faces are on the boundary of a (n+1)-dataset if
/// used by a single (n+1)-dimensional cell. So for example the boundary cells
/// of a volumetric dataset are those with quad faces used by only one
/// voxel. Boundary points are those points used by the boundary faces. A cell
/// may have multiple boundary faces.
///
/// An optional array can be produced that encodes the boundary faces of each
/// cell. For each cell cellId that is on the boundary, the nth bit of the
/// value of the faces tuple at location cellId is set.
///
/// @warning
/// This filter is similar to vtkGeometryFilter in that it identifies boundary
/// cells and points. However, vtkGeometryFilter produces output boundary faces
/// and points as output. vtkMarkBoundaryFilter simply identifies which cells
/// and points are on the boundary. (This filter is often used in parallel
/// computing applications to help distribute data across multiple processes.)
///
/// @warning
/// The points and cells boundary arrays are of type unsigned char.  The
/// optional boundary faces array is of type of vtkIdType (either a 32-bit or
/// 64-but integral value depending on compilation flags). Hence if the number
/// of cell faces exceeds the number of bits in a face array value, then the
/// faces array cannot properly encode the boundary faces for that cell. This
/// may be a problem for cell types with an arbitrary number of faces such as
/// vtkPolyhedron and vtkPolygon.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkGeometryFilter vtkDataSetSurfaceFilter
/// </seealso>
public class vtkMarkBoundaryFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMarkBoundaryFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMarkBoundaryFilter()
	{
		MRClassNameKey = "class vtkMarkBoundaryFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarkBoundaryFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMarkBoundaryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarkBoundaryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkMarkBoundaryFilter New()
	{
		vtkMarkBoundaryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarkBoundaryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMarkBoundaryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkMarkBoundaryFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMarkBoundaryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarkBoundaryFilter_GenerateBoundaryFacesOff_01(HandleRef pThis);

	/// <summary>
	/// Enable the creation of the boundary faces array. This array encodes
	/// which faces are on the boundary of the ith cell. By default, this array
	/// is not created. To use this array, bit masking is required to determine
	/// if the jth face is on the boundary.
	/// </summary>
	public virtual void GenerateBoundaryFacesOff()
	{
		vtkMarkBoundaryFilter_GenerateBoundaryFacesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarkBoundaryFilter_GenerateBoundaryFacesOn_02(HandleRef pThis);

	/// <summary>
	/// Enable the creation of the boundary faces array. This array encodes
	/// which faces are on the boundary of the ith cell. By default, this array
	/// is not created. To use this array, bit masking is required to determine
	/// if the jth face is on the boundary.
	/// </summary>
	public virtual void GenerateBoundaryFacesOn()
	{
		vtkMarkBoundaryFilter_GenerateBoundaryFacesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarkBoundaryFilter_GetBoundaryCellsName_03(HandleRef pThis);

	/// <summary>
	/// Specify the names of the two data arrays which indicate which cells and points
	/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
	/// "BoundaryFaces" are used.
	/// </summary>
	public virtual string GetBoundaryCellsName()
	{
		return Marshal.PtrToStringAnsi(vtkMarkBoundaryFilter_GetBoundaryCellsName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarkBoundaryFilter_GetBoundaryFacesName_04(HandleRef pThis);

	/// <summary>
	/// Specify the names of the two data arrays which indicate which cells and points
	/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
	/// "BoundaryFaces" are used.
	/// </summary>
	public virtual string GetBoundaryFacesName()
	{
		return Marshal.PtrToStringAnsi(vtkMarkBoundaryFilter_GetBoundaryFacesName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarkBoundaryFilter_GetBoundaryPointsName_05(HandleRef pThis);

	/// <summary>
	/// Specify the names of the two data arrays which indicate which cells and points
	/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
	/// "BoundaryFaces" are used.
	/// </summary>
	public virtual string GetBoundaryPointsName()
	{
		return Marshal.PtrToStringAnsi(vtkMarkBoundaryFilter_GetBoundaryPointsName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMarkBoundaryFilter_GetGenerateBoundaryFaces_06(HandleRef pThis);

	/// <summary>
	/// Enable the creation of the boundary faces array. This array encodes
	/// which faces are on the boundary of the ith cell. By default, this array
	/// is not created. To use this array, bit masking is required to determine
	/// if the jth face is on the boundary.
	/// </summary>
	public virtual bool GetGenerateBoundaryFaces()
	{
		return (vtkMarkBoundaryFilter_GetGenerateBoundaryFaces_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMarkBoundaryFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarkBoundaryFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMarkBoundaryFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarkBoundaryFilter_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMarkBoundaryFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarkBoundaryFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkMarkBoundaryFilter NewInstance()
	{
		vtkMarkBoundaryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarkBoundaryFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMarkBoundaryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarkBoundaryFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkMarkBoundaryFilter SafeDownCast(vtkObjectBase o)
	{
		vtkMarkBoundaryFilter vtkMarkBoundaryFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarkBoundaryFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMarkBoundaryFilter2 = (vtkMarkBoundaryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMarkBoundaryFilter2.Register(null);
			}
		}
		return vtkMarkBoundaryFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarkBoundaryFilter_SetBoundaryCellsName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the names of the two data arrays which indicate which cells and points
	/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
	/// "BoundaryFaces" are used.
	/// </summary>
	public virtual void SetBoundaryCellsName(string _arg)
	{
		vtkMarkBoundaryFilter_SetBoundaryCellsName_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarkBoundaryFilter_SetBoundaryFacesName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the names of the two data arrays which indicate which cells and points
	/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
	/// "BoundaryFaces" are used.
	/// </summary>
	public virtual void SetBoundaryFacesName(string _arg)
	{
		vtkMarkBoundaryFilter_SetBoundaryFacesName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarkBoundaryFilter_SetBoundaryPointsName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the names of the two data arrays which indicate which cells and points
	/// are on the boundary. By default, "BoundaryPoints", "BoundaryCells", and
	/// "BoundaryFaces" are used.
	/// </summary>
	public virtual void SetBoundaryPointsName(string _arg)
	{
		vtkMarkBoundaryFilter_SetBoundaryPointsName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarkBoundaryFilter_SetGenerateBoundaryFaces_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable the creation of the boundary faces array. This array encodes
	/// which faces are on the boundary of the ith cell. By default, this array
	/// is not created. To use this array, bit masking is required to determine
	/// if the jth face is on the boundary.
	/// </summary>
	public virtual void SetGenerateBoundaryFaces(bool _arg)
	{
		vtkMarkBoundaryFilter_SetGenerateBoundaryFaces_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
