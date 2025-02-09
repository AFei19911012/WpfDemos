using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRMLImporter
/// </summary>
/// <remarks>
///    imports VRML 2.0 files.
///
///
/// vtkVRMLImporter imports VRML 2.0 files into VTK.
///
/// @warning
/// These nodes are currently supported:
///      Appearance                              IndexedFaceSet
///      Box                                     IndexedLineSet
///      Color                                   Material
///      Cone                                    Shape
///      Coordinate                              Sphere
///      Cylinder                                Transform
///      DirectionalLight
///
/// @warning
/// As you can see this implementation focuses on getting the geometry
/// translated.  The routes and scripting nodes are ignored since they deal
/// with directly accessing a nodes internal structure based on the VRML
/// spec. Since this is a translation the internal data structures differ
/// greatly from the VRML spec and the External Authoring Interface (see the
/// VRML spec). The DEF/USE mechanism does allow the VTK user to extract
/// objects from the scene and directly manipulate them using the native
/// language (Python, Java, or whatever language VTK is wrapped
/// in). This, in a way, removes the need for the route and script mechanism
/// (not completely though).
/// Texture coordinates are attached to the mesh is available but
/// image textures are not loaded.
/// Viewpoints (camera presets) are not imported.
///
/// @par Thanks:
///  Thanks to Russ Coucher of Areva for numerous bug fixes and a new test.
///
/// </remarks>
/// <seealso>
///
/// vtkImporter
/// </seealso>
public class vtkVRMLImporter : vtkImporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRMLImporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRMLImporter()
	{
		MRClassNameKey = "class vtkVRMLImporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMLImporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRMLImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMLImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRMLImporter New()
	{
		vtkVRMLImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMLImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVRMLImporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVRMLImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMLImporter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkVRMLImporter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRMLImporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRMLImporter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRMLImporter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRMLImporter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkVRMLImporter_GetOutputsDescription_04(HandleRef pThis);

	/// <summary>
	/// Get a printable string describing the outputs
	/// </summary>
	public override string GetOutputsDescription()
	{
		return vtkVRMLImporter_GetOutputsDescription_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRMLImporter_GetShapeResolution_05(HandleRef pThis);

	/// <summary>
	/// Specify the resolution for Sphere, Cone and Cylinder shape sources.
	/// Default is 12.
	/// </summary>
	public virtual int GetShapeResolution()
	{
		return vtkVRMLImporter_GetShapeResolution_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMLImporter_GetVRMLDEFObject_06(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// In the VRML spec you can DEF and USE nodes (name them),
	/// This routine will return the associated VTK object which
	/// was created as a result of the DEF mechanism
	/// Send in the name from the VRML file, get the VTK object.
	/// You will have to check and correctly cast the object since
	/// this only returns vtkObjects.
	/// </summary>
	public vtkObject GetVRMLDEFObject(string name)
	{
		vtkObject vtkObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMLImporter_GetVRMLDEFObject_06(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObject2 = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObject2.Register(null);
			}
		}
		return vtkObject2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRMLImporter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRMLImporter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRMLImporter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRMLImporter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMLImporter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRMLImporter NewInstance()
	{
		vtkVRMLImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMLImporter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMLImporter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRMLImporter SafeDownCast(vtkObjectBase o)
	{
		vtkVRMLImporter vtkVRMLImporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMLImporter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRMLImporter2 = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRMLImporter2.Register(null);
			}
		}
		return vtkVRMLImporter2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMLImporter_SetFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkVRMLImporter_SetFileName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMLImporter_SetShapeResolution_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the resolution for Sphere, Cone and Cylinder shape sources.
	/// Default is 12.
	/// </summary>
	public virtual void SetShapeResolution(int _arg)
	{
		vtkVRMLImporter_SetShapeResolution_13(GetCppThis(), _arg);
	}
}
