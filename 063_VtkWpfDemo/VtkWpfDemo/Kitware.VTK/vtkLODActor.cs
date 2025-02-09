using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLODActor
/// </summary>
/// <remarks>
///    an actor that supports multiple levels of detail
///
/// vtkLODActor is an actor that stores multiple levels of detail (LOD) and
/// can automatically switch between them. It selects which level of detail to
/// use based on how much time it has been allocated to render. Currently a
/// very simple method of TotalTime/NumberOfActors is used. (In the future
/// this should be modified to dynamically allocate the rendering time between
/// different actors based on their needs.)
///
/// There are three levels of detail by default. The top level is just the
/// normal data. The lowest level of detail is a simple bounding box outline
/// of the actor. The middle level of detail is a point cloud of a fixed
/// number of points that have been randomly sampled from the mapper's input
/// data. Point attributes are copied over to the point cloud. These two
/// lower levels of detail are accomplished by creating instances of a
/// vtkOutlineFilter (low-res) and vtkMaskPoints (medium-res). Additional
/// levels of detail can be add using the AddLODMapper() method.
///
/// To control the frame rate, you typically set the vtkRenderWindowInteractor
/// DesiredUpdateRate and StillUpdateRate. This then will cause vtkLODActor
/// to adjust its LOD to fulfill the requested update rate.
///
/// For greater control on levels of detail, see also vtkLODProp3D. That
/// class allows arbitrary definition of each LOD.
///
/// @warning
/// If you provide your own mappers, you are responsible for setting its
/// ivars correctly, such as ScalarRange, LookupTable, and so on.
///
/// @warning
/// On some systems the point cloud rendering (the default, medium level of
/// detail) can result in points so small that they can hardly be seen. In
/// this case, use the GetProperty()-&gt;SetPointSize() method to increase the
/// rendered size of the points.
///
/// </remarks>
/// <seealso>
///
/// vtkActor vtkRenderer vtkLODProp3D
/// </seealso>
public class vtkLODActor : vtkActor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLODActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLODActor()
	{
		MRClassNameKey = "class vtkLODActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLODActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLODActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a vtkLODActor with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0). NumberOfCloudPoints is set to 150.
	/// </summary>
	public new static vtkLODActor New()
	{
		vtkLODActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a vtkLODActor with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0). NumberOfCloudPoints is set to 150.
	/// </summary>
	public vtkLODActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLODActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_AddLODMapper_01(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Add another level of detail.
	/// They do not have to be in any order of complexity.
	/// </summary>
	public void AddLODMapper(vtkMapper mapper)
	{
		vtkLODActor_AddLODMapper_01(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODActor_GetLODMappers_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// All the mappers for different LODs are stored here.
	/// The order is not important.
	/// </summary>
	public virtual vtkMapperCollection GetLODMappers()
	{
		vtkMapperCollection vtkMapperCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODActor_GetLODMappers_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMapperCollection2 = (vtkMapperCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMapperCollection2.Register(null);
			}
		}
		return vtkMapperCollection2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODActor_GetLowResFilter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// You may plug in your own filters to decimate/subsample the input.
	/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
	/// (medium-res).
	/// </summary>
	public virtual vtkPolyDataAlgorithm GetLowResFilter()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODActor_GetLowResFilter_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODActor_GetMediumResFilter_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// You may plug in your own filters to decimate/subsample the input.
	/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
	/// (medium-res).
	/// </summary>
	public virtual vtkPolyDataAlgorithm GetMediumResFilter()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODActor_GetMediumResFilter_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODActor_GetNumberOfCloudPoints_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of random points for the point cloud.
	/// </summary>
	public virtual int GetNumberOfCloudPoints()
	{
		return vtkLODActor_GetNumberOfCloudPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLODActor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLODActor_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLODActor_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLODActor_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODActor_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLODActor_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODActor_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLODActor_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_Modified_10(HandleRef pThis);

	/// <summary>
	/// When this objects gets modified, this method also modifies the object.
	/// </summary>
	public override void Modified()
	{
		vtkLODActor_Modified_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODActor_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLODActor NewInstance()
	{
		vtkLODActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODActor_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLODActor_ReleaseGraphicsResources_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_Render_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This causes the actor to be rendered.
	/// It, in turn, will render the actor's property and then mapper.
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkMapper arg1)
	{
		vtkLODActor_Render_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODActor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLODActor SafeDownCast(vtkObjectBase o)
	{
		vtkLODActor vtkLODActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODActor_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLODActor2 = (vtkLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLODActor2.Register(null);
			}
		}
		return vtkLODActor2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_SetLowResFilter_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// You may plug in your own filters to decimate/subsample the input.
	/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
	/// (medium-res).
	/// </summary>
	public virtual void SetLowResFilter(vtkPolyDataAlgorithm arg0)
	{
		vtkLODActor_SetLowResFilter_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_SetMediumResFilter_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// You may plug in your own filters to decimate/subsample the input.
	/// The default is to use a vtkOutlineFilter (low-res) and vtkMaskPoints
	/// (medium-res).
	/// </summary>
	public virtual void SetMediumResFilter(vtkPolyDataAlgorithm arg0)
	{
		vtkLODActor_SetMediumResFilter_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_SetNumberOfCloudPoints_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of random points for the point cloud.
	/// </summary>
	public virtual void SetNumberOfCloudPoints(int _arg)
	{
		vtkLODActor_SetNumberOfCloudPoints_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODActor_ShallowCopy_19(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an LOD actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkLODActor_ShallowCopy_19(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
