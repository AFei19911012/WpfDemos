using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPropAssembly
/// </summary>
/// <remarks>
///    create hierarchies of props
///
/// vtkPropAssembly is an object that groups props and other prop assemblies
/// into a tree-like hierarchy. The props can then be treated as a group
/// (e.g., turning visibility on and off).
///
/// A vtkPropAssembly object can be used in place of an vtkProp since it is a
/// subclass of vtkProp. The difference is that vtkPropAssembly maintains a
/// list of other prop and prop assembly instances (its "parts") that form the
/// assembly. Note that this process is recursive: you can create groups
/// consisting of prop assemblies to arbitrary depth.
///
/// vtkPropAssembly's and vtkProp's that compose a prop assembly need not be
/// added to a renderer's list of props, as long as the parent assembly is in
/// the prop list. This is because they are automatically rendered during
/// the hierarchical traversal process.
///
/// @warning
/// vtkPropAssemblies can consist of hierarchies of assemblies, where one
/// actor or assembly used in one hierarchy is also used in other
/// hierarchies. However, make that there are no cycles (e.g.,
/// parent-&gt;child-&gt;parent), this will cause program failure.
///
/// </remarks>
/// <seealso>
///
/// vtkProp3D vtkActor vtkAssembly vtkActor2D vtkVolume
/// </seealso>
public class vtkPropAssembly : vtkProp
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPropAssembly";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPropAssembly()
	{
		MRClassNameKey = "class vtkPropAssembly";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropAssembly"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPropAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create with an empty parts list.
	/// </summary>
	public new static vtkPropAssembly New()
	{
		vtkPropAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create with an empty parts list.
	/// </summary>
	public vtkPropAssembly()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPropAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropAssembly_AddPart_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a part to the list of parts.
	/// </summary>
	public void AddPart(vtkProp arg0)
	{
		vtkPropAssembly_AddPart_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropAssembly_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Overload the superclass' vtkProp BuildPaths() method.
	/// </summary>
	public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
	{
		vtkPropAssembly_BuildPaths_02(GetCppThis(), paths?.GetCppThis() ?? default(HandleRef), path?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropAssembly_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this prop assembly as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// May return NULL in some cases (meaning the bounds is undefined).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkPropAssembly_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPropAssembly_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Override default GetMTime method to also consider all of the
	/// prop assembly's parts.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPropAssembly_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropAssembly_GetNextPath_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods to traverse the paths (i.e., leaf nodes) of a prop
	/// assembly. These methods should be contrasted to those that traverse the
	/// list of parts using GetParts().  GetParts() returns a list of children
	/// of this assembly, not necessarily the leaf nodes of the assembly. To use
	/// the methods below - first invoke InitPathTraversal() followed by
	/// repeated calls to GetNextPath().  GetNextPath() returns a NULL pointer
	/// when the list is exhausted. (See the superclass vtkProp for more
	/// information about paths.)
	/// </summary>
	public override vtkAssemblyPath GetNextPath()
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropAssembly_GetNextPath_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPropAssembly_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPropAssembly_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPropAssembly_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPropAssembly_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_GetNumberOfPaths_08(HandleRef pThis);

	/// <summary>
	/// Methods to traverse the paths (i.e., leaf nodes) of a prop
	/// assembly. These methods should be contrasted to those that traverse the
	/// list of parts using GetParts().  GetParts() returns a list of children
	/// of this assembly, not necessarily the leaf nodes of the assembly. To use
	/// the methods below - first invoke InitPathTraversal() followed by
	/// repeated calls to GetNextPath().  GetNextPath() returns a NULL pointer
	/// when the list is exhausted. (See the superclass vtkProp for more
	/// information about paths.)
	/// </summary>
	public override int GetNumberOfPaths()
	{
		return vtkPropAssembly_GetNumberOfPaths_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropAssembly_GetParts_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the list of parts.
	/// </summary>
	public vtkPropCollection GetParts()
	{
		vtkPropCollection vtkPropCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropAssembly_GetParts_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropCollection2 = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropCollection2.Register(null);
			}
		}
		return vtkPropCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_HasTranslucentPolygonalGeometry_10(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkPropAssembly_HasTranslucentPolygonalGeometry_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropAssembly_InitPathTraversal_11(HandleRef pThis);

	/// <summary>
	/// Methods to traverse the paths (i.e., leaf nodes) of a prop
	/// assembly. These methods should be contrasted to those that traverse the
	/// list of parts using GetParts().  GetParts() returns a list of children
	/// of this assembly, not necessarily the leaf nodes of the assembly. To use
	/// the methods below - first invoke InitPathTraversal() followed by
	/// repeated calls to GetNextPath().  GetNextPath() returns a NULL pointer
	/// when the list is exhausted. (See the superclass vtkProp for more
	/// information about paths.)
	/// </summary>
	public override void InitPathTraversal()
	{
		vtkPropAssembly_InitPathTraversal_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPropAssembly_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPropAssembly_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropAssembly_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPropAssembly NewInstance()
	{
		vtkPropAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropAssembly_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropAssembly_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPropAssembly_ReleaseGraphicsResources_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropAssembly_RemovePart_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a part from the list of parts,
	/// </summary>
	public void RemovePart(vtkProp arg0)
	{
		vtkPropAssembly_RemovePart_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.  The rendering process is
	/// recursive. The parts of each assembly are rendered only if the
	/// visibility for the prop is turned on.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport ren)
	{
		return vtkPropAssembly_RenderOpaqueGeometry_18(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_RenderOverlay_19(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.  The rendering process is
	/// recursive. The parts of each assembly are rendered only if the
	/// visibility for the prop is turned on.
	/// </summary>
	public override int RenderOverlay(vtkViewport ren)
	{
		return vtkPropAssembly_RenderOverlay_19(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.  The rendering process is
	/// recursive. The parts of each assembly are rendered only if the
	/// visibility for the prop is turned on.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
	{
		return vtkPropAssembly_RenderTranslucentPolygonalGeometry_20(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPropAssembly_RenderVolumetricGeometry_21(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.  The rendering process is
	/// recursive. The parts of each assembly are rendered only if the
	/// visibility for the prop is turned on.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport ren)
	{
		return vtkPropAssembly_RenderVolumetricGeometry_21(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPropAssembly_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPropAssembly SafeDownCast(vtkObjectBase o)
	{
		vtkPropAssembly vtkPropAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPropAssembly_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropAssembly2 = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropAssembly2.Register(null);
			}
		}
		return vtkPropAssembly2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPropAssembly_ShallowCopy_23(HandleRef pThis, HandleRef Prop);

	/// <summary>
	/// Shallow copy of this vtkPropAssembly.
	/// </summary>
	public override void ShallowCopy(vtkProp Prop)
	{
		vtkPropAssembly_ShallowCopy_23(GetCppThis(), Prop?.GetCppThis() ?? default(HandleRef));
	}
}
