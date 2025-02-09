using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGlyph2D
/// </summary>
/// <remarks>
///    copy oriented and scaled glyph geometry to every input point (2D specialization)
///
/// This subclass of vtkGlyph3D is a specialization to 2D. Transformations
/// (i.e., translation, scaling, and rotation) are constrained to the plane.
/// For example, rotations due to a vector are computed from the x-y
/// coordinates of the vector only, and are assumed to occur around the
/// z-axis. (See vtkGlyph3D for documentation on the interface to this
/// class.)
///
/// Frequently this class is used in combination with vtkGlyphSource.
/// vtkGlyphSource2D can produce a family of 2D glyphs.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorGlyph vtkGlyph3D vtkProgrammableGlyphFilter vtkGlyphSource2D
/// </seealso>
public class vtkGlyph2D : vtkGlyph3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGlyph2D()
	{
		MRClassNameKey = "class vtkGlyph2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGlyph2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with scaling on, scaling mode is by scalar value,
	/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
	/// orientation is by vector. Clamping and indexing are turned off. No
	/// initial sources are defined.
	/// </summary>
	public new static vtkGlyph2D New()
	{
		vtkGlyph2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with scaling on, scaling mode is by scalar value,
	/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
	/// orientation is by vector. Clamping and indexing are turned off. No
	/// initial sources are defined.
	/// </summary>
	public vtkGlyph2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGlyph2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGlyph2D_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph2D_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGlyph2D_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph2D_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGlyph2D_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph2D_IsTypeOf_04(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGlyph2D_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new vtkGlyph2D NewInstance()
	{
		vtkGlyph2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph2D_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph2D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new static vtkGlyph2D SafeDownCast(vtkObjectBase o)
	{
		vtkGlyph2D vtkGlyph2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph2D_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGlyph2D2 = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGlyph2D2.Register(null);
			}
		}
		return vtkGlyph2D2;
	}
}
