using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiObjectMassProperties
/// </summary>
/// <remarks>
///    compute volume and area of objects in a polygonal mesh
///
/// vtkMultiObjectMassProperties estimates the volume, the surface area, and
/// the centroid of a polygonal mesh. Multiple, valid closed objects may be
/// represented, and each object is assumed to be defined as a polyhedron
/// defined by polygonal faces (i.e., the faces do not have to be triangles).
/// The algorithm computes the total volume and area, as well as per object values
/// which are placed in data arrays. Note that an object is valid only if it is
/// manifold and closed (i.e., each edge is used exactly two times by two different
/// polygons). Invalid objects are processed but may produce inaccurate
/// results. Inconsistent polygon ordering is also allowed.
///
/// The algorithm is composed of two basic parts. First a connected traversal
/// is performed to identify objects, detect whether the objects are valid,
/// and ensure that the composing polygons are ordered consistently. Next, in
/// threaded execution, a parallel process of computing areas, volumes  and
/// centroids is performed. It is possible to skip the first part if the
/// SkipValidityCheck is enabled, AND a vtkIdTypeArray data array named "ObjectIds"
/// is associated with the polygon input (i.e., cell data) that enumerates which
/// object every polygon belongs to (i.e., indicates that it is a boundary
/// polygon of a specified object).
///
/// The algorithm implemented here is inspired by this paper:
/// http://chenlab.ece.cornell.edu/Publication/Cha/icip01_Cha.pdf. Also see
/// the stack-overflow entry: https://stackoverflow.com/questions/1406029/.
/// The centroids are calculated as a weighted average of the centroids of the tetrahedrons
/// which are used to compute the volume of the polygonal object, and the weight is the
/// tetrahedron's volume contribution. If the polygonal object has 0 volume, then the resulted
/// centroid will be (nan, nan, nan). The general assumption here is that the model
/// is of closed surface.  Also, this approach requires triangulating the polygons so
/// triangle meshes are processed much faster. Finally, the volume, area and centroid
/// calculations are done in parallel (threaded) after a connectivity pass is made
/// (used to identify objects and verify that they are manifold and closed).
///
/// The output contains seven additional data arrays. The arrays
/// "ObjectValidity", "ObjectVolumes", "ObjectAreas" and "ObjectCentroids" are
/// placed in the output field data.  These are arrays which indicate which objects are
/// valid; the volume of each object; the surface area of each object; the centroid
/// of each object. Three additional arrays are placed in the output cell data, and
/// indicate, on a per polygons basis, which object the polygon bounds
/// "ObjectIds"; the polygon area "Areas"; and the contribution of volume
/// "Volumes".  Additionally, the TotalVolume and TotalArea is available after
/// the filter executes (i.e., the sum of the ObjectVolumes and ObjectAreas
/// arrays).
///
/// Per-object validity, as mentioned previously, is reported in the
/// ObjectValidity array. However another variable, AllValid, is set after
/// filter execution which indicates whether all objects are valid (!=0) or
/// not. This information can be used as a shortcut in case you want to skip
/// validity checking on an object-by-object basis.
///
/// @warning
/// This filter operates on the polygonal data contained in the input
/// vtkPolyData. Other types (vertices, lines, triangle strips) are ignored and
/// not passed to the output. The input polys and points, as well as
/// associated point and cell data, are passed through to the output.
///
/// @warning
/// This filter is similar to vtkMassProperties. However vtkMassProperties
/// operates on triangle meshes and assumes only a single, closed, properly
/// oriented surface is represented. vtkMultiObjectMassProperties performs
/// additional topological and connectivity operations to identify separate
/// objects, and confirms that they are manifold. It also accommodates
/// inconsistent ordering.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkMassProperties
/// </seealso>
public class vtkMultiObjectMassProperties : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiObjectMassProperties";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiObjectMassProperties()
	{
		MRClassNameKey = "class vtkMultiObjectMassProperties";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiObjectMassProperties"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiObjectMassProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiObjectMassProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkMultiObjectMassProperties New()
	{
		vtkMultiObjectMassProperties result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiObjectMassProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiObjectMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public vtkMultiObjectMassProperties()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiObjectMassProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiObjectMassProperties_GetAllValid_01(HandleRef pThis);

	/// <summary>
	/// Return whether all objects are valid or not. This is valid only after the
	/// filter executes.
	/// </summary>
	public int GetAllValid()
	{
		return vtkMultiObjectMassProperties_GetAllValid_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiObjectMassProperties_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiObjectMassProperties_GetNumberOfObjects_04(HandleRef pThis);

	/// <summary>
	/// Return the number of objects identified. This is valid only after the
	/// filter executes. Check the ObjectValidity array which indicates which of
	/// these identified objects are valid. Invalid objects may have incorrect
	/// volume and area values.
	/// </summary>
	public long GetNumberOfObjects()
	{
		return vtkMultiObjectMassProperties_GetNumberOfObjects_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiObjectMassProperties_GetObjectIdsArrayName_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the ObjectIds array. This array, which indicates in which object
	/// a polygon belongs to, can be either provided by the user or computed.
	/// The default name is "ObjectIds".
	/// </summary>
	public virtual string GetObjectIdsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMultiObjectMassProperties_GetObjectIdsArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiObjectMassProperties_GetSkipValidityCheck_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether to skip the validity check (the first part of the
	/// algorithm). By default this is off; however even if enabled validity
	/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
	/// provided on input to the filter.
	/// </summary>
	public virtual int GetSkipValidityCheck()
	{
		return vtkMultiObjectMassProperties_GetSkipValidityCheck_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMultiObjectMassProperties_GetTotalArea_07(HandleRef pThis);

	/// <summary>
	/// Return the summed area of all objects. This is valid only after the
	/// filter executes.
	/// </summary>
	public double GetTotalArea()
	{
		return vtkMultiObjectMassProperties_GetTotalArea_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMultiObjectMassProperties_GetTotalVolume_08(HandleRef pThis);

	/// <summary>
	/// Return the summed volume of all objects. This is valid only after the
	/// filter executes.
	/// </summary>
	public double GetTotalVolume()
	{
		return vtkMultiObjectMassProperties_GetTotalVolume_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiObjectMassProperties_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiObjectMassProperties_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiObjectMassProperties_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiObjectMassProperties_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiObjectMassProperties_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new vtkMultiObjectMassProperties NewInstance()
	{
		vtkMultiObjectMassProperties result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiObjectMassProperties_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiObjectMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiObjectMassProperties_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkMultiObjectMassProperties SafeDownCast(vtkObjectBase o)
	{
		vtkMultiObjectMassProperties vtkMultiObjectMassProperties2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiObjectMassProperties_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiObjectMassProperties2 = (vtkMultiObjectMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiObjectMassProperties2.Register(null);
			}
		}
		return vtkMultiObjectMassProperties2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiObjectMassProperties_SetObjectIdsArrayName_14(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get the name of the ObjectIds array. This array, which indicates in which object
	/// a polygon belongs to, can be either provided by the user or computed.
	/// The default name is "ObjectIds".
	/// </summary>
	public virtual void SetObjectIdsArrayName(string arg)
	{
		vtkMultiObjectMassProperties_SetObjectIdsArrayName_14(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiObjectMassProperties_SetSkipValidityCheck_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to skip the validity check (the first part of the
	/// algorithm). By default this is off; however even if enabled validity
	/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
	/// provided on input to the filter.
	/// </summary>
	public virtual void SetSkipValidityCheck(int _arg)
	{
		vtkMultiObjectMassProperties_SetSkipValidityCheck_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiObjectMassProperties_SkipValidityCheckOff_16(HandleRef pThis);

	/// <summary>
	/// Indicate whether to skip the validity check (the first part of the
	/// algorithm). By default this is off; however even if enabled validity
	/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
	/// provided on input to the filter.
	/// </summary>
	public virtual void SkipValidityCheckOff()
	{
		vtkMultiObjectMassProperties_SkipValidityCheckOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiObjectMassProperties_SkipValidityCheckOn_17(HandleRef pThis);

	/// <summary>
	/// Indicate whether to skip the validity check (the first part of the
	/// algorithm). By default this is off; however even if enabled validity
	/// skipping will only occur if a vtkIdTypeArray named "ObjectIds" is also
	/// provided on input to the filter.
	/// </summary>
	public virtual void SkipValidityCheckOn()
	{
		vtkMultiObjectMassProperties_SkipValidityCheckOn_17(GetCppThis());
	}
}
