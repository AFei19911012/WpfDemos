using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridVolumeRayCastFunction
/// </summary>
/// <remarks>
///    a superclass for ray casting functions
///
///
/// vtkUnstructuredGridVolumeRayCastFunction is a superclass for ray casting functions that
/// can be used within a vtkUnstructuredGridVolumeRayCastMapper.
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGridVolumeRayCastMapper vtkUnstructuredGridVolumeRayIntegrator
/// </seealso>
public abstract class vtkUnstructuredGridVolumeRayCastFunction : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridVolumeRayCastFunction()
	{
		MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridVolumeRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastFunction_Finalize_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void FinalizeWrapper()
	{
		vtkUnstructuredGridVolumeRayCastFunction_Finalize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastFunction_Initialize_04(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void Initialize(vtkRenderer ren, vtkVolume vol)
	{
		vtkUnstructuredGridVolumeRayCastFunction_Initialize_04(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastFunction_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridVolumeRayCastFunction_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastFunction_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridVolumeRayCastFunction_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridVolumeRayCastFunction NewInstance()
	{
		vtkUnstructuredGridVolumeRayCastFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_NewIterator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a new object that will iterate over all the intersections of a
	/// ray with the cells of the input.  The calling code is responsible for
	/// deleting the returned object.
	/// </summary>
	public virtual vtkUnstructuredGridVolumeRayCastIterator NewIterator()
	{
		vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction_NewIterator_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayCastIterator2 = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayCastIterator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayCastIterator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeRayCastFunction SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridVolumeRayCastFunction vtkUnstructuredGridVolumeRayCastFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayCastFunction2 = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayCastFunction2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayCastFunction2;
	}
}
/// <summary>
///    vtkUnstructuredGridVolumeRayCastIterator
///
///
///
/// vtkUnstructuredGridVolumeRayCastIterator is a superclass for iterating
/// over the intersections of a viewing ray with a group of unstructured
/// cells.  These iterators are created with a
/// vtkUnstructuredGridVolumeRayCastFunction.
///
/// </summary>
/// <seealso>
///
/// vtkUnstructuredGridVolumeRayCastFunction
///
/// </seealso>
public abstract class vtkUnstructuredGridVolumeRayCastIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridVolumeRayCastIterator()
	{
		MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridVolumeRayCastIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastIterator_GetBounds_02(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public virtual void GetBounds(ref double _arg1, ref double _arg2)
	{
		vtkUnstructuredGridVolumeRayCastIterator_GetBounds_02(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastIterator_GetBounds_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public virtual void GetBounds(IntPtr _arg)
	{
		vtkUnstructuredGridVolumeRayCastIterator_GetBounds_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetMaxNumberOfIntersections_04(HandleRef pThis);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public virtual long GetMaxNumberOfIntersections()
	{
		return vtkUnstructuredGridVolumeRayCastIterator_GetMaxNumberOfIntersections_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNextIntersections_05(HandleRef pThis, HandleRef intersectedCells, HandleRef intersectionLengths, HandleRef scalars, HandleRef nearIntersections, HandleRef farIntersections);

	/// <summary>
	/// Get the intersections of the next several cells.  The cell ids are
	/// stored in \c intersectedCells and the length of each ray segment
	/// within the cell is stored in \c intersectionLengths.  The point
	/// scalars \c scalars are interpolated and stored in \c nearIntersections
	/// and \c farIntersections.  \c intersectedCells, \c intersectionLengths,
	/// or \c scalars may be \c NULL to suppress passing the associated
	/// information.  The number of intersections actually encountered is
	/// returned.  0 is returned if and only if no more intersections are to
	/// be found.
	/// </summary>
	public virtual long GetNextIntersections(vtkIdList intersectedCells, vtkDoubleArray intersectionLengths, vtkDataArray scalars, vtkDataArray nearIntersections, vtkDataArray farIntersections)
	{
		return vtkUnstructuredGridVolumeRayCastIterator_GetNextIntersections_05(GetCppThis(), intersectedCells?.GetCppThis() ?? default(HandleRef), intersectionLengths?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef), nearIntersections?.GetCppThis() ?? default(HandleRef), farIntersections?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastIterator_Initialize_08(HandleRef pThis, int x, int y);

	/// <summary>
	/// Initializes the iteration to the start of the ray at the given screen
	/// coordinates.
	/// </summary>
	public virtual void Initialize(int x, int y)
	{
		vtkUnstructuredGridVolumeRayCastIterator_Initialize_08(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastIterator_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridVolumeRayCastIterator_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastIterator_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridVolumeRayCastIterator_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridVolumeRayCastIterator NewInstance()
	{
		vtkUnstructuredGridVolumeRayCastIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeRayCastIterator SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayCastIterator2 = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayCastIterator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayCastIterator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetBounds_13(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2)
	{
		vtkUnstructuredGridVolumeRayCastIterator_SetBounds_13(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetBounds_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public void SetBounds(IntPtr _arg)
	{
		vtkUnstructuredGridVolumeRayCastIterator_SetBounds_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetMaxNumberOfIntersections_15(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/get the bounds of the cast ray (in viewing coordinates).  By
	/// default the range is [0,1].
	/// </summary>
	public virtual void SetMaxNumberOfIntersections(long _arg)
	{
		vtkUnstructuredGridVolumeRayCastIterator_SetMaxNumberOfIntersections_15(GetCppThis(), _arg);
	}
}
/// <summary>
///    vtkUnstructuredGridVolumeRayCastMapper
/// </summary>
/// <remarks>
///    A software mapper for unstructured volumes
///
/// This is a software ray caster for rendering volumes in vtkUnstructuredGrid.
///
/// </remarks>
/// <seealso>
///
/// vtkVolumeMapper
/// </seealso>
public class vtkUnstructuredGridVolumeRayCastMapper : vtkUnstructuredGridVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridVolumeRayCastMapper()
	{
		MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeRayCastMapper New()
	{
		vtkUnstructuredGridVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridVolumeRayCastMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOff()
	{
		vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOn()
	{
		vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_CastRays_03(HandleRef pThis, int threadID, int threadCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public void CastRays(int threadID, int threadCount)
	{
		vtkUnstructuredGridVolumeRayCastMapper_CastRays_03(GetCppThis(), threadID, threadCount);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistances_04(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistances()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistances_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_05(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMaxValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_06(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMinValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_07(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual int[] GetImageInUseSize()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void GetImageInUseSize(IntPtr data)
	{
		vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_09(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual int[] GetImageOrigin()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void GetImageOrigin(IntPtr data)
	{
		vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistance_11(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual float GetImageSampleDistance()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistance_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual float GetImageSampleDistanceMaxValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMinValue_13(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual float GetImageSampleDistanceMinValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_14(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual int[] GetImageViewportSize()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_14(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void GetImageViewportSize(IntPtr data)
	{
		vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometry_16(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometry()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometry_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_17(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometryMaxValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_18(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometryMinValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistance_19(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMaximumImageSampleDistance()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistance_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_20(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMaxValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_21(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMinValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistance_22(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMinimumImageSampleDistance()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistance_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_23(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMaxValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_24(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMinValue()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfThreads_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of threads to use. This by default is equal to
	/// the number of available processors detected.
	/// </summary>
	public virtual int GetNumberOfThreads()
	{
		return vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfThreads_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetRayCastFunction_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the helper class for casting rays.
	/// </summary>
	public virtual vtkUnstructuredGridVolumeRayCastFunction GetRayCastFunction()
	{
		vtkUnstructuredGridVolumeRayCastFunction vtkUnstructuredGridVolumeRayCastFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_GetRayCastFunction_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayCastFunction2 = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayCastFunction2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayCastFunction2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetRayIntegrator_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the helper class for integrating rays.  If set to NULL, a
	/// default integrator will be assigned.
	/// </summary>
	public virtual vtkUnstructuredGridVolumeRayIntegrator GetRayIntegrator()
	{
		vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_GetRayIntegrator_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayIntegrator2 = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayIntegrator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayIntegrator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOff_30(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void IntermixIntersectingGeometryOff()
	{
		vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOn_31(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void IntermixIntersectingGeometryOn()
	{
		vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridVolumeRayCastMapper_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayCastMapper_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridVolumeRayCastMapper_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridVolumeRayCastMapper NewInstance()
	{
		vtkUnstructuredGridVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_ReleaseGraphicsResources_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkUnstructuredGridVolumeRayCastMapper_ReleaseGraphicsResources_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_Render_37(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkUnstructuredGridVolumeRayCastMapper_Render_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridVolumeRayCastMapper vtkUnstructuredGridVolumeRayCastMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayCastMapper2 = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayCastMapper2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayCastMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetAutoAdjustSampleDistances_39(HandleRef pThis, int _arg);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void SetAutoAdjustSampleDistances(int _arg)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetAutoAdjustSampleDistances_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetImageSampleDistance_40(HandleRef pThis, float _arg);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual void SetImageSampleDistance(float _arg)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetImageSampleDistance_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetIntermixIntersectingGeometry_41(HandleRef pThis, int _arg);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void SetIntermixIntersectingGeometry(int _arg)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetIntermixIntersectingGeometry_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetMaximumImageSampleDistance_42(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual void SetMaximumImageSampleDistance(float _arg)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetMaximumImageSampleDistance_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetMinimumImageSampleDistance_43(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual void SetMinimumImageSampleDistance(float _arg)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetMinimumImageSampleDistance_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetNumberOfThreads_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of threads to use. This by default is equal to
	/// the number of available processors detected.
	/// </summary>
	public virtual void SetNumberOfThreads(int _arg)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetNumberOfThreads_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetRayCastFunction_45(HandleRef pThis, HandleRef f);

	/// <summary>
	/// Set/Get the helper class for casting rays.
	/// </summary>
	public virtual void SetRayCastFunction(vtkUnstructuredGridVolumeRayCastFunction f)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetRayCastFunction_45(GetCppThis(), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetRayIntegrator_46(HandleRef pThis, HandleRef ri);

	/// <summary>
	/// Set/Get the helper class for integrating rays.  If set to NULL, a
	/// default integrator will be assigned.
	/// </summary>
	public virtual void SetRayIntegrator(vtkUnstructuredGridVolumeRayIntegrator ri)
	{
		vtkUnstructuredGridVolumeRayCastMapper_SetRayIntegrator_46(GetCppThis(), ri?.GetCppThis() ?? default(HandleRef));
	}
}
