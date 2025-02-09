using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitTextureCoords
/// </summary>
/// <remarks>
///    generate 1D, 2D, or 3D texture coordinates based on implicit function(s)
///
/// vtkImplicitTextureCoords is a filter to generate 1D, 2D, or 3D texture
/// coordinates from one, two, or three implicit functions, respectively.
/// In combinations with a vtkBooleanTexture map (or another texture map of
/// your own creation), the texture coordinates can be used to highlight
///             (via color or intensity) or cut (via transparency) dataset geometry without
/// any complex geometric processing. (Note: the texture coordinates are
/// referred to as r-s-t coordinates.)
///
/// The texture coordinates are automatically normalized to lie between (0,1).
/// Thus, no matter what the implicit functions evaluate to, the resulting
/// texture coordinates lie between (0,1), with the zero implicit function
/// value mapped to the 0.5 texture coordinates value. Depending upon the
/// maximum negative/positive implicit function values, the full (0,1) range
/// may not be occupied (i.e., the positive/negative ranges are mapped using
/// the same scale factor).
///
/// A boolean variable InvertTexture is available to flip the texture
/// coordinates around 0.5 (value 1.0 becomes 0.0, 0.25-&gt;0.75). This is
/// equivalent to flipping the texture map (but a whole lot easier).
///
/// @warning
/// You can use the transformation capabilities of vtkImplicitFunction to
/// orient, translate, and scale the implicit functions. Also, the dimension of
/// the texture coordinates is implicitly defined by the number of implicit
/// functions defined.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkTexture vtkBooleanTexture vtkTransformTexture
/// </seealso>
public class vtkImplicitTextureCoords : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitTextureCoords";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitTextureCoords()
	{
		MRClassNameKey = "class vtkImplicitTextureCoords";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitTextureCoords"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create object with texture dimension=2 and no r-s-t implicit functions
	/// defined and FlipTexture turned off.
	/// </summary>
	public new static vtkImplicitTextureCoords New()
	{
		vtkImplicitTextureCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create object with texture dimension=2 and no r-s-t implicit functions
	/// defined and FlipTexture turned off.
	/// </summary>
	public vtkImplicitTextureCoords()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitTextureCoords_FlipTextureOff_01(HandleRef pThis);

	/// <summary>
	/// If enabled, this will flip the sense of inside and outside the implicit
	/// function (i.e., a rotation around the r-s-t=0.5 axis).
	/// </summary>
	public virtual void FlipTextureOff()
	{
		vtkImplicitTextureCoords_FlipTextureOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitTextureCoords_FlipTextureOn_02(HandleRef pThis);

	/// <summary>
	/// If enabled, this will flip the sense of inside and outside the implicit
	/// function (i.e., a rotation around the r-s-t=0.5 axis).
	/// </summary>
	public virtual void FlipTextureOn()
	{
		vtkImplicitTextureCoords_FlipTextureOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitTextureCoords_GetFlipTexture_03(HandleRef pThis);

	/// <summary>
	/// If enabled, this will flip the sense of inside and outside the implicit
	/// function (i.e., a rotation around the r-s-t=0.5 axis).
	/// </summary>
	public virtual int GetFlipTexture()
	{
		return vtkImplicitTextureCoords_GetFlipTexture_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitTextureCoords_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitTextureCoords_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitTextureCoords_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitTextureCoords_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitTextureCoords_GetRFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an implicit function to compute the r texture coordinate.
	/// </summary>
	public virtual vtkImplicitFunction GetRFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitTextureCoords_GetRFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitTextureCoords_GetSFunction_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an implicit function to compute the s texture coordinate.
	/// </summary>
	public virtual vtkImplicitFunction GetSFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitTextureCoords_GetSFunction_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitTextureCoords_GetTFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an implicit function to compute the t texture coordinate.
	/// </summary>
	public virtual vtkImplicitFunction GetTFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitTextureCoords_GetTFunction_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitTextureCoords_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitTextureCoords_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitTextureCoords_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitTextureCoords_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitTextureCoords_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitTextureCoords NewInstance()
	{
		vtkImplicitTextureCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitTextureCoords_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitTextureCoords_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitTextureCoords SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitTextureCoords vtkImplicitTextureCoords2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitTextureCoords_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitTextureCoords2 = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitTextureCoords2.Register(null);
			}
		}
		return vtkImplicitTextureCoords2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitTextureCoords_SetFlipTexture_14(HandleRef pThis, int _arg);

	/// <summary>
	/// If enabled, this will flip the sense of inside and outside the implicit
	/// function (i.e., a rotation around the r-s-t=0.5 axis).
	/// </summary>
	public virtual void SetFlipTexture(int _arg)
	{
		vtkImplicitTextureCoords_SetFlipTexture_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitTextureCoords_SetRFunction_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify an implicit function to compute the r texture coordinate.
	/// </summary>
	public virtual void SetRFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitTextureCoords_SetRFunction_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitTextureCoords_SetSFunction_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify an implicit function to compute the s texture coordinate.
	/// </summary>
	public virtual void SetSFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitTextureCoords_SetSFunction_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitTextureCoords_SetTFunction_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify an implicit function to compute the t texture coordinate.
	/// </summary>
	public virtual void SetTFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitTextureCoords_SetTFunction_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
