using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAssembly
/// </summary>
/// <remarks>
///    create hierarchies of vtkProp3Ds (transformable props)
///
/// vtkAssembly is an object that groups vtkProp3Ds, its subclasses, and
/// other assemblies into a tree-like hierarchy. The vtkProp3Ds and
/// assemblies can then be transformed together by transforming just the root
/// assembly of the hierarchy.
///
/// A vtkAssembly object can be used in place of an vtkProp3D since it is a
/// subclass of vtkProp3D. The difference is that vtkAssembly maintains a list
/// of vtkProp3D instances (its "parts") that form the assembly. Then, any
/// operation that transforms (i.e., scales, rotates, translates) the parent
/// assembly will transform all its parts.  Note that this process is
/// recursive: you can create groups consisting of assemblies and/or
/// vtkProp3Ds to arbitrary depth.
///
/// To add an assembly to the renderer's list of props, you only need to
/// add the root of the assembly. During rendering, the parts of the
/// assembly are rendered during a hierarchical traversal process.
///
/// @warning
/// Collections of assemblies are slower to render than an equivalent list
/// of actors. This is because to support arbitrary nesting of assemblies,
/// the state of the assemblies (i.e., transformation matrices) must
/// be propagated through the assembly hierarchy.
///
/// @warning
/// Assemblies can consist of hierarchies of assemblies, where one actor or
/// assembly used in one hierarchy is also used in other hierarchies. However,
/// make that there are no cycles (e.g., parent-&gt;child-&gt;parent), this will
/// cause program failure.
///
/// @warning
/// If you wish to create assemblies without any transformation (using the
/// assembly strictly as a grouping mechanism), then you may wish to
/// consider using vtkPropAssembly.
///
/// </remarks>
/// <seealso>
///
/// vtkActor vtkTransform vtkMapper vtkPolyDataMapper vtkPropAssembly
/// </seealso>
public class vtkAssembly : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAssembly";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAssembly()
	{
		MRClassNameKey = "class vtkAssembly";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssembly"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssembly New()
	{
		vtkAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAssembly()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAssembly_AddPart_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a part to the list of parts.
	/// </summary>
	public void AddPart(vtkProp3D arg0)
	{
		vtkAssembly_AddPart_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE DO NOT USE THIS
	/// METHOD OUTSIDE OF THE RENDERING PROCESS Overload the superclass' vtkProp
	/// BuildPaths() method. Paths consist of an ordered sequence of actors,
	/// with transformations properly concatenated.
	/// </summary>
	public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
	{
		vtkAssembly_BuildPaths_02(GetCppThis(), paths?.GetCppThis() ?? default(HandleRef), path?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_GetActors_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkAssembly_GetActors_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_GetBounds_04(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for the assembly as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkAssembly_GetBounds_04(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssembly_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Get the bounds for the assembly as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkAssembly_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAssembly_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Override default GetMTime method to also consider all of the
	/// assembly's parts.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAssembly_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssembly_GetNextPath_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods to traverse the parts of an assembly. Each part (starting from
	/// the root) will appear properly transformed and with the correct
	/// properties (depending upon the ApplyProperty and ApplyTransform ivars).
	/// Note that the part appears as an instance of vtkProp. These methods
	/// should be contrasted to those that traverse the list of parts using
	/// GetParts().  GetParts() returns a list of children of this assembly, not
	/// necessarily with the correct transformation or properties. To use the
	/// methods below - first invoke InitPathTraversal() followed by repeated
	/// calls to GetNextPath().  GetNextPath() returns a NULL pointer when the
	/// list is exhausted.
	/// </summary>
	public override vtkAssemblyPath GetNextPath()
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssembly_GetNextPath_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAssembly_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAssembly_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssembly_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAssembly_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_GetNumberOfPaths_10(HandleRef pThis);

	/// <summary>
	/// Methods to traverse the parts of an assembly. Each part (starting from
	/// the root) will appear properly transformed and with the correct
	/// properties (depending upon the ApplyProperty and ApplyTransform ivars).
	/// Note that the part appears as an instance of vtkProp. These methods
	/// should be contrasted to those that traverse the list of parts using
	/// GetParts().  GetParts() returns a list of children of this assembly, not
	/// necessarily with the correct transformation or properties. To use the
	/// methods below - first invoke InitPathTraversal() followed by repeated
	/// calls to GetNextPath().  GetNextPath() returns a NULL pointer when the
	/// list is exhausted.
	/// </summary>
	public override int GetNumberOfPaths()
	{
		return vtkAssembly_GetNumberOfPaths_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssembly_GetParts_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the parts (direct descendants) of this assembly.
	/// </summary>
	public vtkProp3DCollection GetParts()
	{
		vtkProp3DCollection vtkProp3DCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssembly_GetParts_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DCollection2 = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DCollection2.Register(null);
			}
		}
		return vtkProp3DCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_GetVolumes_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetVolumes(vtkPropCollection arg0)
	{
		vtkAssembly_GetVolumes_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkAssembly_HasTranslucentPolygonalGeometry_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_InitPathTraversal_14(HandleRef pThis);

	/// <summary>
	/// Methods to traverse the parts of an assembly. Each part (starting from
	/// the root) will appear properly transformed and with the correct
	/// properties (depending upon the ApplyProperty and ApplyTransform ivars).
	/// Note that the part appears as an instance of vtkProp. These methods
	/// should be contrasted to those that traverse the list of parts using
	/// GetParts().  GetParts() returns a list of children of this assembly, not
	/// necessarily with the correct transformation or properties. To use the
	/// methods below - first invoke InitPathTraversal() followed by repeated
	/// calls to GetNextPath().  GetNextPath() returns a NULL pointer when the
	/// list is exhausted.
	/// </summary>
	public override void InitPathTraversal()
	{
		vtkAssembly_InitPathTraversal_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAssembly_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAssembly_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssembly_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAssembly NewInstance()
	{
		vtkAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssembly_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAssembly_ReleaseGraphicsResources_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_RemovePart_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a part from the list of parts,
	/// </summary>
	public void RemovePart(vtkProp3D arg0)
	{
		vtkAssembly_RemovePart_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.
	/// The rendering process is recursive.
	/// Note that a mapper need not be defined. If not defined, then no geometry
	/// will be drawn for this assembly. This allows you to create "logical"
	/// assemblies; that is, assemblies that only serve to group and transform
	/// its parts.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport ren)
	{
		return vtkAssembly_RenderOpaqueGeometry_21(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.
	/// The rendering process is recursive.
	/// Note that a mapper need not be defined. If not defined, then no geometry
	/// will be drawn for this assembly. This allows you to create "logical"
	/// assemblies; that is, assemblies that only serve to group and transform
	/// its parts.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
	{
		return vtkAssembly_RenderTranslucentPolygonalGeometry_22(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssembly_RenderVolumetricGeometry_23(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Render this assembly and all its parts.
	/// The rendering process is recursive.
	/// Note that a mapper need not be defined. If not defined, then no geometry
	/// will be drawn for this assembly. This allows you to create "logical"
	/// assemblies; that is, assemblies that only serve to group and transform
	/// its parts.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport ren)
	{
		return vtkAssembly_RenderVolumetricGeometry_23(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssembly_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssembly SafeDownCast(vtkObjectBase o)
	{
		vtkAssembly vtkAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssembly_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssembly2 = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssembly2.Register(null);
			}
		}
		return vtkAssembly2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssembly_ShallowCopy_25(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an assembly. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkAssembly_ShallowCopy_25(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
