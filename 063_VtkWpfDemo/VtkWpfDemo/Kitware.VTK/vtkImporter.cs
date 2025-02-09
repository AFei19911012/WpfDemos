using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImporter
/// </summary>
/// <remarks>
///    importer abstract class
///
/// vtkImporter is an abstract class that specifies the protocol for
/// importing actors, cameras, lights and properties into a
/// vtkRenderWindow. The following takes place:
/// 1) Create a RenderWindow and Renderer if none is provided.
/// 2) Call ImportBegin, if ImportBegin returns False, return
/// 3) Call ReadData, which calls:
///  a) Import the Actors
///  b) Import the cameras
///  c) Import the lights
///  d) Import the Properties
/// 7) Call ImportEnd
///
/// Subclasses optionally implement the ImportActors, ImportCameras,
/// ImportLights and ImportProperties or ReadData methods. An ImportBegin and
/// ImportEnd can optionally be provided to perform Importer-specific
/// initialization and termination.  The Read method initiates the import
/// process. If a RenderWindow is provided, its Renderer will contained
/// the imported objects. If the RenderWindow has no Renderer, one is
/// created. If no RenderWindow is provided, both a RenderWindow and
/// Renderer will be created. Both the RenderWindow and Renderer can be
/// accessed using Get methods.
///
/// </remarks>
/// <seealso>
///
/// vtk3DSImporter vtkExporter
/// </seealso>
public class vtkImporter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImporter()
	{
		MRClassNameKey = "class vtkImporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_DisableAnimation_01(HandleRef pThis, long arg0);

	/// <summary>
	/// Enable/Disable/Get the status of specific animations
	/// </summary>
	public virtual void DisableAnimation(long arg0)
	{
		vtkImporter_DisableAnimation_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_EnableAnimation_02(HandleRef pThis, long arg0);

	/// <summary>
	/// Enable/Disable/Get the status of specific animations
	/// </summary>
	public virtual void EnableAnimation(long arg0)
	{
		vtkImporter_EnableAnimation_02(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkImporter_GetAnimationName_03(HandleRef pThis, long arg0);

	/// <summary>
	/// Get the name of an animation.
	/// Return an empty if not provided by implementation.
	/// </summary>
	public virtual string GetAnimationName(long arg0)
	{
		return vtkImporter_GetAnimationName_03(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkImporter_GetCameraName_04(HandleRef pThis, long arg0);

	/// <summary>
	/// Get the name of a camera.
	/// Return an empty string if not provided by implementation.
	/// </summary>
	public virtual string GetCameraName(long arg0)
	{
		return vtkImporter_GetCameraName_04(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImporter_GetNumberOfAnimations_05(HandleRef pThis);

	/// <summary>
	/// Get the number of available animations.
	/// Return -1 if not provided by implementation.
	/// </summary>
	public virtual long GetNumberOfAnimations()
	{
		return vtkImporter_GetNumberOfAnimations_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImporter_GetNumberOfCameras_06(HandleRef pThis);

	/// <summary>
	/// Get the number of available cameras.
	/// Return 0 if not provided by implementation.
	/// </summary>
	public virtual long GetNumberOfCameras()
	{
		return vtkImporter_GetNumberOfCameras_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImporter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImporter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImporter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImporter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkImporter_GetOutputsDescription_09(HandleRef pThis);

	/// <summary>
	/// Recover a printable string that let importer implementation
	/// Describe their outputs.
	/// </summary>
	public virtual string GetOutputsDescription()
	{
		return vtkImporter_GetOutputsDescription_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImporter_GetRenderWindow_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the vtkRenderWindow to contain the imported actors, cameras and
	/// lights, If no vtkRenderWindow is set, one will be created and can be
	/// obtained with the GetRenderWindow method. If the vtkRenderWindow has been
	/// specified, the first vtkRenderer it has will be used to import the
	/// objects. If the vtkRenderWindow has no Renderer, one will be created and
	/// can be accessed using GetRenderer.
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImporter_GetRenderWindow_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImporter_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the renderer that contains the imported actors, cameras and
	/// lights.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImporter_GetRenderer_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImporter_GetTemporalInformation_12(HandleRef pThis, long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, HandleRef timeSteps);

	/// <summary>
	/// Get temporal information for the currently enabled animations.
	/// the three return arguments can be defined or not.
	/// Return true in case of success, false otherwise.
	/// </summary>
	public virtual bool GetTemporalInformation(long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, vtkDoubleArray timeSteps)
	{
		return (vtkImporter_GetTemporalInformation_12(GetCppThis(), animationIndex, frameRate, ref nbTimeSteps, timeRange, timeSteps?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImporter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImporter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImporter_IsAnimationEnabled_14(HandleRef pThis, long arg0);

	/// <summary>
	/// Enable/Disable/Get the status of specific animations
	/// </summary>
	public virtual bool IsAnimationEnabled(long arg0)
	{
		return (vtkImporter_IsAnimationEnabled_14(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImporter_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImporter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImporter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImporter NewInstance()
	{
		vtkImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImporter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_Read_17(HandleRef pThis);

	/// <summary>
	/// Import the actors, cameras, lights and properties into a vtkRenderWindow.
	/// </summary>
	public void Read()
	{
		vtkImporter_Read_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImporter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImporter SafeDownCast(vtkObjectBase o)
	{
		vtkImporter vtkImporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImporter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImporter2 = (vtkImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImporter2.Register(null);
			}
		}
		return vtkImporter2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_SetCamera_19(HandleRef pThis, long arg0);

	/// <summary>
	/// Enable a specific camera.
	/// If a negative index is provided, no camera from the importer is used.
	/// Does nothing if not provided by implementation.
	/// </summary>
	public virtual void SetCamera(long arg0)
	{
		vtkImporter_SetCamera_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_SetRenderWindow_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the vtkRenderWindow to contain the imported actors, cameras and
	/// lights, If no vtkRenderWindow is set, one will be created and can be
	/// obtained with the GetRenderWindow method. If the vtkRenderWindow has been
	/// specified, the first vtkRenderer it has will be used to import the
	/// objects. If the vtkRenderWindow has no Renderer, one will be created and
	/// can be accessed using GetRenderer.
	/// </summary>
	public virtual void SetRenderWindow(vtkRenderWindow arg0)
	{
		vtkImporter_SetRenderWindow_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_Update_21(HandleRef pThis);

	/// <summary>
	/// Import the actors, cameras, lights and properties into a vtkRenderWindow.
	/// </summary>
	public void Update()
	{
		vtkImporter_Update_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImporter_UpdateTimeStep_22(HandleRef pThis, double timeStep);

	/// <summary>
	/// Import the actors, camera, lights and properties at a specific timestep.
	/// If not reimplemented, only call Update().
	/// </summary>
	public virtual void UpdateTimeStep(double timeStep)
	{
		vtkImporter_UpdateTimeStep_22(GetCppThis(), timeStep);
	}
}
