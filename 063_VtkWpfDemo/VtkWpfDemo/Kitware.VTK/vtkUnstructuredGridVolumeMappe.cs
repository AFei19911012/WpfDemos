using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridVolumeMapper
/// </summary>
/// <remarks>
///    Abstract class for an unstructured grid volume mapper
///
///
/// vtkUnstructuredGridVolumeMapper is the abstract definition of a volume mapper for
/// unstructured data (vtkUnstructuredGrid). Several basic types of volume mappers
/// are supported as subclasses.
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGridVolumeRayCastMapper
/// </seealso>
public abstract class vtkUnstructuredGridVolumeMapper : vtkAbstractVolumeMapper
{
	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public enum COMPOSITE_BLEND_WrapperEnum
	{
		/// <summary>enum member</summary>
		COMPOSITE_BLEND,
		/// <summary>enum member</summary>
		MAXIMUM_INTENSITY_BLEND
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridVolumeMapper()
	{
		MRClassNameKey = "class vtkUnstructuredGridVolumeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkUnstructuredGridVolumeMapper_GetBlendMode_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual int GetBlendMode()
	{
		return vtkUnstructuredGridVolumeMapper_GetBlendMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeMapper_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public vtkUnstructuredGridBase GetInput()
	{
		vtkUnstructuredGridBase vtkUnstructuredGridBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeMapper_GetInput_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridBase2 = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridBase2.Register(null);
			}
		}
		return vtkUnstructuredGridBase2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeMapper_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridVolumeMapper_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeMapper_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridVolumeMapper_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridVolumeMapper NewInstance()
	{
		vtkUnstructuredGridVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeMapper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkUnstructuredGridVolumeMapper_ReleaseGraphicsResources_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_Render_09(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public override void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkUnstructuredGridVolumeMapper_Render_09(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridVolumeMapper vtkUnstructuredGridVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeMapper_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeMapper2 = (vtkUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeMapper2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendMode_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual void SetBlendMode(int _arg)
	{
		vtkUnstructuredGridVolumeMapper_SetBlendMode_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendModeToComposite_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public void SetBlendModeToComposite()
	{
		vtkUnstructuredGridVolumeMapper_SetBlendModeToComposite_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendModeToMaximumIntensity_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public void SetBlendModeToMaximumIntensity()
	{
		vtkUnstructuredGridVolumeMapper_SetBlendModeToMaximumIntensity_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_SetInputData_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual void SetInputData(vtkUnstructuredGridBase arg0)
	{
		vtkUnstructuredGridVolumeMapper_SetInputData_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeMapper_SetInputData_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual void SetInputData(vtkDataSet arg0)
	{
		vtkUnstructuredGridVolumeMapper_SetInputData_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
