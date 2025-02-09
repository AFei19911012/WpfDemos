using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractMapper
/// </summary>
/// <remarks>
///    abstract class specifies interface to map data
///
/// vtkAbstractMapper is an abstract class to specify interface between data and
/// graphics primitives or software rendering techniques. Subclasses of
/// vtkAbstractMapper can be used for rendering 2D data, geometry, or volumetric
/// data.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractMapper3D vtkMapper vtkPolyDataMapper vtkVolumeMapper
/// </seealso>
public class vtkAbstractMapper : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractMapper()
	{
		MRClassNameKey = "class vtkAbstractMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_AddClippingPlane_01(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Specify clipping planes to be applied when the data is mapped
	/// (at most 6 clipping planes can be specified).
	/// </summary>
	public void AddClippingPlane(vtkPlane plane)
	{
		vtkAbstractMapper_AddClippingPlane_01(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper_GetAbstractScalars_02(HandleRef input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Internal helper function for getting the active scalars as an
	/// abstract array. The scalar mode indicates where the scalars come
	/// from.  The cellFlag is a return value that is set when the
	/// scalars actually are cell scalars.  (0 for point scalars, 1 for
	/// cell scalars, 2 for field scalars) The arrayAccessMode is used to
	/// indicate how to retrieve the scalars from field data, per id or
	/// per name (if the scalarMode indicates that).
	/// </summary>
	public static vtkAbstractArray GetAbstractScalars(vtkDataSet input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper_GetAbstractScalars_02(input?.GetCppThis() ?? default(HandleRef), scalarMode, arrayAccessMode, arrayId, arrayName, ref cellFlag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper_GetClippingPlanes_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the vtkPlaneCollection which specifies the
	/// clipping planes.
	/// </summary>
	public virtual vtkPlaneCollection GetClippingPlanes()
	{
		vtkPlaneCollection vtkPlaneCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper_GetClippingPlanes_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneCollection2 = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneCollection2.Register(null);
			}
		}
		return vtkPlaneCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper_GetGhostArray_04(HandleRef input, int scalarMode, ref byte ghostsToSkip, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghost array associated with the corresponding scalar mode, if present.
	/// If no ghost array is available, this method returns `nullptr`. `ghostsToSkip` is an output,
	/// and is set to the bit mask associated with the ghost array in the `vtkFieldData` in which
	/// the ghost array lives. This bit mask can be ignored if `nullptr` is returned.
	///
	/// @sa
	/// vtkFieldData
	/// vtkDataSetAttributes
	/// vtkCellData
	/// vtkPointData
	/// </summary>
	public static vtkUnsignedCharArray GetGhostArray(vtkDataSet input, int scalarMode, ref byte ghostsToSkip)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper_GetGhostArray_04(input?.GetCppThis() ?? default(HandleRef), scalarMode, ref ghostsToSkip, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAbstractMapper_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Override Modifiedtime as we have added Clipping planes
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAbstractMapper_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper_GetNumberOfClippingPlanes_06(HandleRef pThis);

	/// <summary>
	/// Get the number of clipping planes.
	/// </summary>
	public int GetNumberOfClippingPlanes()
	{
		return vtkAbstractMapper_GetNumberOfClippingPlanes_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractMapper_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractMapper_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractMapper_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractMapper_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper_GetScalars_09(HandleRef input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Internal helper function for getting the active scalars. The scalar
	/// mode indicates where the scalars come from.  The cellFlag is a
	/// return value that is set when the scalars actually are cell scalars.
	/// (0 for point scalars, 1 for cell scalars, 2 for field scalars)
	/// The arrayAccessMode is used to indicate how to retrieve the scalars from
	/// field data, per id or per name (if the scalarMode indicates that).
	/// </summary>
	public static vtkDataArray GetScalars(vtkDataSet input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper_GetScalars_09(input?.GetCppThis() ?? default(HandleRef), scalarMode, arrayAccessMode, arrayId, arrayName, ref cellFlag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractMapper_GetTimeToDraw_10(HandleRef pThis);

	/// <summary>
	/// Get the time required to draw the geometry last time it was rendered
	/// </summary>
	public virtual double GetTimeToDraw()
	{
		return vtkAbstractMapper_GetTimeToDraw_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractMapper_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractMapper_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractMapper NewInstance()
	{
		vtkAbstractMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAbstractMapper_ReleaseGraphicsResources_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_RemoveAllClippingPlanes_15(HandleRef pThis);

	/// <summary>
	/// Specify clipping planes to be applied when the data is mapped
	/// (at most 6 clipping planes can be specified).
	/// </summary>
	public void RemoveAllClippingPlanes()
	{
		vtkAbstractMapper_RemoveAllClippingPlanes_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_RemoveClippingPlane_16(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Specify clipping planes to be applied when the data is mapped
	/// (at most 6 clipping planes can be specified).
	/// </summary>
	public void RemoveClippingPlane(vtkPlane plane)
	{
		vtkAbstractMapper_RemoveClippingPlane_16(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractMapper SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractMapper vtkAbstractMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractMapper2 = (vtkAbstractMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractMapper2.Register(null);
			}
		}
		return vtkAbstractMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_SetClippingPlanes_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the vtkPlaneCollection which specifies the
	/// clipping planes.
	/// </summary>
	public virtual void SetClippingPlanes(vtkPlaneCollection arg0)
	{
		vtkAbstractMapper_SetClippingPlanes_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_SetClippingPlanes_19(HandleRef pThis, HandleRef planes);

	/// <summary>
	/// An alternative way to set clipping planes: use up to six planes found
	/// in the supplied instance of the implicit function vtkPlanes.
	/// </summary>
	public void SetClippingPlanes(vtkPlanes planes)
	{
		vtkAbstractMapper_SetClippingPlanes_19(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper_ShallowCopy_20(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Make a shallow copy of this mapper.
	/// </summary>
	public virtual void ShallowCopy(vtkAbstractMapper m)
	{
		vtkAbstractMapper_ShallowCopy_20(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}
}
