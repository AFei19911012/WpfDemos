using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSurfaceLICMapper
/// </summary>
/// <remarks>
///    mapper that performs LIC on the surface of
///  arbitrary geometry.
///
///
///  vtkSurfaceLICMapper performs LIC on the surface of arbitrary
///  geometry. Point vectors are used as the vector field for generating the LIC.
///  The implementation was originallu  based on "Image Space Based Visualization
///  on Unsteady Flow on Surfaces" by Laramee, Jobard and Hauser appeared in
///  proceedings of IEEE Visualization '03, pages 131-138.
///
///  Internal pipeline:
/// &lt;pre&gt;
/// noise
///     |
///     [ PROJ (GAT) (COMP) LIC2D (SCAT) SHADE (CCE) DEP]
///     |                                               |
/// vectors                                         surface LIC
/// &lt;/pre&gt;
/// PROj  - project vectors onto surface
/// GAT   - gather data for compositing and guard pixel generation  (parallel only)
/// COMP  - composite gathered data
/// LIC2D - line intengral convolution, see vtkLineIntegralConvolution2D.
/// SCAT  - scatter result (parallel only, not all compositors use it)
/// SHADE - combine LIC and scalar colors
/// CCE   - color contrast enhancement (optional)
/// DEP   - depth test and copy to back buffer
///
/// The result of each stage is cached in a texture so that during interaction
/// a stage may be skipped if the user has not modified its parameters or input
/// data.
///
/// The parallel parts of algorithm are implemented in vtkPSurfaceLICMapper.
/// Note that for MPI enabled builds this class will be automatically created
/// by the object factory.
///
/// </remarks>
/// <seealso>
///
/// vtkLineIntegralConvolution2D
/// </seealso>
public class vtkSurfaceLICMapper : vtkOpenGLPolyDataMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceLICMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSurfaceLICMapper()
	{
		MRClassNameKey = "class vtkSurfaceLICMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceLICMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSurfaceLICMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceLICMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSurfaceLICMapper New()
	{
		vtkSurfaceLICMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceLICMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSurfaceLICMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSurfaceLICMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceLICMapper_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSurfaceLICMapper_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceLICMapper_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSurfaceLICMapper_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceLICMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSurfaceLICMapper NewInstance()
	{
		vtkSurfaceLICMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceLICMapper_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceLICMapper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release. In this case, releases the display lists.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkSurfaceLICMapper_ReleaseGraphicsResources_07(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceLICMapper_RenderPiece_08(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Implemented by sub classes. Actual rendering is done here.
	/// </summary>
	public override void RenderPiece(vtkRenderer ren, vtkActor act)
	{
		vtkSurfaceLICMapper_RenderPiece_08(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceLICMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSurfaceLICMapper SafeDownCast(vtkObjectBase o)
	{
		vtkSurfaceLICMapper vtkSurfaceLICMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceLICMapper_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSurfaceLICMapper2 = (vtkSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSurfaceLICMapper2.Register(null);
			}
		}
		return vtkSurfaceLICMapper2;
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceLICMapper_ShallowCopy_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Shallow copy of an actor.
	/// </summary>
	public override void ShallowCopy(vtkAbstractMapper arg0)
	{
		vtkSurfaceLICMapper_ShallowCopy_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
