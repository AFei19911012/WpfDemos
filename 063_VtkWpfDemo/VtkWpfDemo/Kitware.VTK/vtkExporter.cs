using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExporter
/// </summary>
/// <remarks>
///    abstract class to write a scene to a file
///
/// vtkExporter is an abstract class that exports a scene to a file. It
/// is very similar to vtkWriter except that a writer only writes out
/// the geometric and topological data for an object, where an exporter
/// can write out material properties, lighting, camera parameters etc.
/// The concrete subclasses of this class may not write out all of this
/// information. For example vtkOBJExporter writes out Wavefront obj files
/// which do not include support for camera parameters.
///
/// vtkExporter provides the convenience methods StartWrite() and EndWrite().
/// These methods are executed before and after execution of the Write()
/// method. You can also specify arguments to these methods.
/// This class defines SetInput and GetInput methods which take or return
/// a vtkRenderWindow.
/// @warning
/// Every subclass of vtkExporter must implement a WriteData() method.
///
/// </remarks>
/// <seealso>
///
/// vtkOBJExporter vtkRenderWindow vtkWriter
/// </seealso>
public abstract class vtkExporter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExporter()
	{
		MRClassNameKey = "class vtkExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExporter_GetActiveRenderer_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the renderer that contains actors to be written.
	/// If it is set to nullptr (by default), then in most subclasses
	/// the behavior is to only export actors of the first renderer.
	/// In some subclasses, if ActiveRenderer is nullptr then
	/// actors of all renderers will be exported.
	/// The renderer must be in the renderer collection of the specified
	/// RenderWindow.
	/// \sa SetRenderWindow()
	/// </summary>
	public virtual vtkRenderer GetActiveRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExporter_GetActiveRenderer_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExporter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These methods are provided for backward compatibility. Will disappear
	/// soon.
	/// </summary>
	public vtkRenderWindow GetInput()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExporter_GetInput_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExporter_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// Returns the MTime also considering the RenderWindow.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExporter_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExporter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExporter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExporter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExporter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExporter_GetRenderWindow_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the rendering window that contains the scene to be written.
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExporter_GetRenderWindow_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExporter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExporter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExporter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExporter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExporter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExporter NewInstance()
	{
		vtkExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExporter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExporter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExporter SafeDownCast(vtkObjectBase o)
	{
		vtkExporter vtkExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExporter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExporter2 = (vtkExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExporter2.Register(null);
			}
		}
		return vtkExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExporter_SetActiveRenderer_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the renderer that contains actors to be written.
	/// If it is set to nullptr (by default), then in most subclasses
	/// the behavior is to only export actors of the first renderer.
	/// In some subclasses, if ActiveRenderer is nullptr then
	/// actors of all renderers will be exported.
	/// The renderer must be in the renderer collection of the specified
	/// RenderWindow.
	/// \sa SetRenderWindow()
	/// </summary>
	public virtual void SetActiveRenderer(vtkRenderer arg0)
	{
		vtkExporter_SetActiveRenderer_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExporter_SetInput_12(HandleRef pThis, HandleRef renWin);

	/// <summary>
	/// These methods are provided for backward compatibility. Will disappear
	/// soon.
	/// </summary>
	public void SetInput(vtkRenderWindow renWin)
	{
		vtkExporter_SetInput_12(GetCppThis(), renWin?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExporter_SetRenderWindow_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the rendering window that contains the scene to be written.
	/// </summary>
	public virtual void SetRenderWindow(vtkRenderWindow arg0)
	{
		vtkExporter_SetRenderWindow_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExporter_Update_14(HandleRef pThis);

	/// <summary>
	/// Convenient alias for Write() method.
	/// </summary>
	public void Update()
	{
		vtkExporter_Update_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExporter_Write_15(HandleRef pThis);

	/// <summary>
	/// Write data to output. Method executes subclasses WriteData() method, as
	/// well as StartWrite() and EndWrite() methods.
	/// </summary>
	public virtual void Write()
	{
		vtkExporter_Write_15(GetCppThis());
	}
}
