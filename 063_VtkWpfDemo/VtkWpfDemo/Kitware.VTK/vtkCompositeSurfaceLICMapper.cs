using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeSurfaceLICMapper
/// </summary>
/// <remarks>
///    mapper for composite dataset
///
/// vtkCompositeSurfaceLICMapper is similar to
/// vtkGenericCompositeSurfaceLICMapper but requires that its inputs all have the
/// same properties (normals, tcoord, scalars, etc) It will only draw
/// polys and it does not support edge flags. The advantage to using
/// this class is that it generally should be faster
/// </remarks>
public class vtkCompositeSurfaceLICMapper : vtkCompositePolyDataMapper2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeSurfaceLICMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeSurfaceLICMapper()
	{
		MRClassNameKey = "class vtkCompositeSurfaceLICMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeSurfaceLICMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeSurfaceLICMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeSurfaceLICMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeSurfaceLICMapper New()
	{
		vtkCompositeSurfaceLICMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeSurfaceLICMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCompositeSurfaceLICMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeSurfaceLICMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeSurfaceLICMapper_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeSurfaceLICMapper_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeSurfaceLICMapper_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeSurfaceLICMapper_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeSurfaceLICMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeSurfaceLICMapper NewInstance()
	{
		vtkCompositeSurfaceLICMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeSurfaceLICMapper_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeSurfaceLICMapper_Render_07(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Lots of LIC setup code
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkCompositeSurfaceLICMapper_Render_07(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeSurfaceLICMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeSurfaceLICMapper SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeSurfaceLICMapper vtkCompositeSurfaceLICMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeSurfaceLICMapper_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeSurfaceLICMapper2 = (vtkCompositeSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeSurfaceLICMapper2.Register(null);
			}
		}
		return vtkCompositeSurfaceLICMapper2;
	}
}
