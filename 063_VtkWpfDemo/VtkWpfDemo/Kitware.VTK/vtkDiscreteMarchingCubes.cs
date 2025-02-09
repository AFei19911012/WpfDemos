using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiscreteMarchingCubes
/// </summary>
/// <remarks>
///    generate object boundaries from
/// labelled volumes
///
/// This filter extracts object boundaries from label maps (label maps are
/// volumes in which each voxel is labeled according to the region in which it
/// is contained).  The filter takes as input a volume (e.g., 3D structured
/// point set) of segmentation labels and generates on output one or more
/// models representing the boundaries between the specified label and the
/// adjacent structures.  One or more label values must be specified to
/// generate the models.  The boundary positions are always defined to be
/// half-way between adjacent voxels. This filter works best with integral
/// scalar values.
///
/// If ComputeScalars is on (the default), each output cell will have cell
/// data that corresponding to the scalar value (segmentation label) of the
/// corresponding cube. Note that this differs from vtkMarchingCubes, which
/// stores the scalar value as point data. The rationale for this difference
/// is that cell vertices may be shared between multiple cells. This also
/// means that the resultant polydata may be non-manifold (cell faces may be
/// coincident). To further process the polydata, users should either: 1)
/// extract cells that have a common scalar value using vtkThreshold, or 2)
/// process the data with filters that can handle non-manifold polydata
/// (e.g. vtkWindowedSincPolyDataFilter). Also note, Normals and Gradients are
/// not computed.
///
/// If ComputeAdjacentScalars is on (default is off), each output point will
/// have point data that contains the label value of the neighbouring voxel.
/// This allows to remove regions of the resulting vtkPolyData that are
/// adjacent to specific label meshes. For example, if the input is a label
/// image that was created by running a watershed transformation on a distance
/// map followed by masking with the original binary segmentation. For further
/// details and images see the VTK Journal paper:
/// "Providing values of adjacent voxel with vtkDiscreteMarchingCubes"
/// by Roman Grothausmann:
/// http://hdl.handle.net/10380/3559
/// http://www.vtkjournal.org/browse/publication/975
///
/// @warning
/// This filter is specialized to volumes. If you are interested in contouring
/// other types of data, use the general vtkContourFilter. If you want to
/// contour an image (i.e., a volume slice), use vtFlyingEdges2D or
/// vtkMarchingSquares.
///
/// </remarks>
/// <seealso>
///
/// vtkSurfaceNets3D vtkDiscreteFlyingEdges3D vtkSurfaceNets2D
/// vtkContourFilter vtkSliceCubes vtkMarchingSquares vtkDividingCubes
/// </seealso>
public class vtkDiscreteMarchingCubes : vtkMarchingCubes
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteMarchingCubes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiscreteMarchingCubes()
	{
		MRClassNameKey = "class vtkDiscreteMarchingCubes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteMarchingCubes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiscreteMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public new static vtkDiscreteMarchingCubes New()
	{
		vtkDiscreteMarchingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public vtkDiscreteMarchingCubes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiscreteMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of neighbouring voxel values.
	/// </summary>
	public virtual void ComputeAdjacentScalarsOff()
	{
		vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of neighbouring voxel values.
	/// </summary>
	public virtual void ComputeAdjacentScalarsOn()
	{
		vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteMarchingCubes_GetComputeAdjacentScalars_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of neighbouring voxel values.
	/// </summary>
	public virtual int GetComputeAdjacentScalars()
	{
		return vtkDiscreteMarchingCubes_GetComputeAdjacentScalars_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteMarchingCubes_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiscreteMarchingCubes_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteMarchingCubes_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiscreteMarchingCubes_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteMarchingCubes_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public new vtkDiscreteMarchingCubes NewInstance()
	{
		vtkDiscreteMarchingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteMarchingCubes_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteMarchingCubes_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an object.
	/// </summary>
	public new static vtkDiscreteMarchingCubes SafeDownCast(vtkObjectBase o)
	{
		vtkDiscreteMarchingCubes vtkDiscreteMarchingCubes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteMarchingCubes_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiscreteMarchingCubes2 = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiscreteMarchingCubes2.Register(null);
			}
		}
		return vtkDiscreteMarchingCubes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteMarchingCubes_SetComputeAdjacentScalars_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the computation of neighbouring voxel values.
	/// </summary>
	public virtual void SetComputeAdjacentScalars(int _arg)
	{
		vtkDiscreteMarchingCubes_SetComputeAdjacentScalars_11(GetCppThis(), _arg);
	}
}
