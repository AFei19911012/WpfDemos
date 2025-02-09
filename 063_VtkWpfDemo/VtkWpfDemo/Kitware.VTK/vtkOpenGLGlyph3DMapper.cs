using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLGlyph3DMapper
/// </summary>
/// <remarks>
///    vtkOpenGLGlyph3D on the GPU.
///
/// Do the same job than vtkGlyph3D but on the GPU. For this reason, it is
/// a mapper not a vtkPolyDataAlgorithm. Also, some methods of vtkOpenGLGlyph3D
/// don't make sense in vtkOpenGLGlyph3DMapper: GeneratePointIds, old-style
/// SetSource, PointIdsName, IsPointVisible.
///
/// </remarks>
/// <seealso>
///
/// vtkOpenGLGlyph3D
/// </seealso>
public class vtkOpenGLGlyph3DMapper : vtkGlyph3DMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGlyph3DMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLGlyph3DMapper()
	{
		MRClassNameKey = "class vtkOpenGLGlyph3DMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGlyph3DMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLGlyph3DMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGlyph3DMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGlyph3DMapper New()
	{
		vtkOpenGLGlyph3DMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGlyph3DMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLGlyph3DMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLGlyph3DMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGlyph3DMapper_GetMaxNumberOfLOD_01(HandleRef pThis);

	/// <summary>
	/// Get the maximum number of LOD. OpenGL context must be bound.
	/// The maximum number of LOD depends on GPU capabilities.
	/// </summary>
	public override long GetMaxNumberOfLOD()
	{
		return vtkOpenGLGlyph3DMapper_GetMaxNumberOfLOD_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLGlyph3DMapper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGlyph3DMapper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLGlyph3DMapper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGlyph3DMapper_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLGlyph3DMapper_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGlyph3DMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLGlyph3DMapper NewInstance()
	{
		vtkOpenGLGlyph3DMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGlyph3DMapper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGlyph3DMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkOpenGLGlyph3DMapper_ReleaseGraphicsResources_08(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGlyph3DMapper_Render_09(HandleRef pThis, HandleRef ren, HandleRef a);

	/// <summary>
	/// Method initiates the mapping process. Generally sent by the actor
	/// as each frame is rendered.
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor a)
	{
		vtkOpenGLGlyph3DMapper_Render_09(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGlyph3DMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGlyph3DMapper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLGlyph3DMapper vtkOpenGLGlyph3DMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGlyph3DMapper_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLGlyph3DMapper2 = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLGlyph3DMapper2.Register(null);
			}
		}
		return vtkOpenGLGlyph3DMapper2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGlyph3DMapper_SetLODDistanceAndTargetReduction_11(HandleRef pThis, long index, float distance, float targetReduction);

	/// <summary>
	/// Configure LODs. Culling must be enabled.
	/// distance have to be a positive value, it is the distance to the camera scaled by
	/// the instanced geometry bounding box.
	/// targetReduction have to be between 0 and 1, 0 disable decimation, 1 draw a point.
	///
	/// @sa vtkDecimatePro::SetTargetReduction
	/// </summary>
	public override void SetLODDistanceAndTargetReduction(long index, float distance, float targetReduction)
	{
		vtkOpenGLGlyph3DMapper_SetLODDistanceAndTargetReduction_11(GetCppThis(), index, distance, targetReduction);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGlyph3DMapper_SetNumberOfLOD_12(HandleRef pThis, long nb);

	/// <summary>
	/// Set the number of LOD.
	/// </summary>
	public override void SetNumberOfLOD(long nb)
	{
		vtkOpenGLGlyph3DMapper_SetNumberOfLOD_12(GetCppThis(), nb);
	}
}
