using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLightingMapPass
/// </summary>
/// <remarks>
///    TO DO
///
/// Renders lighting information directly instead of final shaded colors.
/// The information keys allow the selection of either normal rendering or
/// luminance. For normals, the (nx, ny, nz) tuple are rendered directly into
/// the (r,g,b) fragment. For luminance, the diffuse and specular intensities are
/// rendered into the red and green channels, respectively. The blue channel is
/// zero. For both luminances and normals, the alpha channel is set to 1.0 if
/// present.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass vtkDefaultPass
/// </seealso>
public class vtkLightingMapPass : vtkDefaultPass
{
	/// <summary>
	/// Set the type of lighting render to perform
	/// </summary>
	public enum RenderMode
	{
		/// <summary>enum member</summary>
		LUMINANCE,
		/// <summary>enum member</summary>
		NORMALS
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLightingMapPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLightingMapPass()
	{
		MRClassNameKey = "class vtkLightingMapPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightingMapPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLightingMapPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightingMapPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLightingMapPass New()
	{
		vtkLightingMapPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightingMapPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLightingMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLightingMapPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLightingMapPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkLightingMapPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLightingMapPass_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLightingMapPass_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLightingMapPass_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern RenderMode vtkLightingMapPass_GetRenderType_03(HandleRef pThis);

	/// <summary>
	/// Set the type of lighting render to perform
	/// </summary>
	public virtual RenderMode GetRenderType()
	{
		return vtkLightingMapPass_GetRenderType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightingMapPass_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLightingMapPass_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightingMapPass_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLightingMapPass_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightingMapPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLightingMapPass NewInstance()
	{
		vtkLightingMapPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightingMapPass_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLightingMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightingMapPass_RENDER_LUMINANCE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If this key exists on the PropertyKeys of a prop, the active scalar array
	/// on the prop will be rendered as its color. This key is mutually exclusive
	/// with the RENDER_LUMINANCE key.
	/// </summary>
	public static vtkInformationIntegerKey RENDER_LUMINANCE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightingMapPass_RENDER_LUMINANCE_08(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightingMapPass_RENDER_NORMALS_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// if this key exists on the ProperyKeys of a prop, the active vector array on
	/// the prop will be rendered as its color. This key is mutually exclusive with
	/// the RENDER_LUMINANCE key.
	/// </summary>
	public static vtkInformationIntegerKey RENDER_NORMALS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightingMapPass_RENDER_NORMALS_09(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightingMapPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLightingMapPass SafeDownCast(vtkObjectBase o)
	{
		vtkLightingMapPass vtkLightingMapPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightingMapPass_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLightingMapPass2 = (vtkLightingMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLightingMapPass2.Register(null);
			}
		}
		return vtkLightingMapPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightingMapPass_SetRenderType_11(HandleRef pThis, RenderMode _arg);

	/// <summary>
	/// Set the type of lighting render to perform
	/// </summary>
	public virtual void SetRenderType(RenderMode _arg)
	{
		vtkLightingMapPass_SetRenderType_11(GetCppThis(), _arg);
	}
}
