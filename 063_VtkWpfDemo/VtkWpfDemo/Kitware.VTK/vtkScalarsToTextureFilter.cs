using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScalarsToTextureFilter
/// </summary>
/// <remarks>
///    generate texture coordinates and a texture image based on a scalar field
///
/// This filter computes texture coordinates and a 2D texture image based on a polydata,
/// a color transfer function and an array.
/// The output port 0 will contain the input polydata with computed texture coordinates.
/// The output port 1 will contain the texture.
/// The computed texture coordinates is based on vtkTextureMapToPlane which computes them using
/// 3D positions projected on the best fitting plane.
/// </remarks>
/// <seealso>
///  vtkTextureMapToPlane vtkResampleToImage
/// </seealso>
public class vtkScalarsToTextureFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToTextureFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScalarsToTextureFilter()
	{
		MRClassNameKey = "class vtkScalarsToTextureFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToTextureFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScalarsToTextureFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToTextureFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarsToTextureFilter New()
	{
		vtkScalarsToTextureFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToTextureFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarsToTextureFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkScalarsToTextureFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScalarsToTextureFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToTextureFilter_GetTextureDimensions_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the width and height of the generated texture.
	/// Default is 128x128. The width and height must be greater than 1.
	/// </summary>
	public virtual int[] GetTextureDimensions()
	{
		IntPtr intPtr = vtkScalarsToTextureFilter_GetTextureDimensions_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_GetTextureDimensions_04(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the width and height of the generated texture.
	/// Default is 128x128. The width and height must be greater than 1.
	/// </summary>
	public virtual void GetTextureDimensions(ref int _arg1, ref int _arg2)
	{
		vtkScalarsToTextureFilter_GetTextureDimensions_04(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_GetTextureDimensions_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the width and height of the generated texture.
	/// Default is 128x128. The width and height must be greater than 1.
	/// </summary>
	public virtual void GetTextureDimensions(IntPtr _arg)
	{
		vtkScalarsToTextureFilter_GetTextureDimensions_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToTextureFilter_GetTransferFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a color transfer function.
	/// This transfer function will be used to determine the pixel colors of the texture.
	/// If not specified, the filter use a default one (blue/white/red) based on the range of the
	/// input array.
	/// </summary>
	public vtkScalarsToColors GetTransferFunction()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToTextureFilter_GetTransferFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarsToTextureFilter_GetUseTransferFunction_07(HandleRef pThis);

	/// <summary>
	/// Specify if a new point array containing RGBA values have to be computed by the specified
	/// color transfer function.
	/// </summary>
	public virtual bool GetUseTransferFunction()
	{
		return (vtkScalarsToTextureFilter_GetUseTransferFunction_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToTextureFilter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScalarsToTextureFilter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToTextureFilter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScalarsToTextureFilter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToTextureFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScalarsToTextureFilter NewInstance()
	{
		vtkScalarsToTextureFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToTextureFilter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarsToTextureFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToTextureFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarsToTextureFilter SafeDownCast(vtkObjectBase o)
	{
		vtkScalarsToTextureFilter vtkScalarsToTextureFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToTextureFilter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToTextureFilter2 = (vtkScalarsToTextureFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToTextureFilter2.Register(null);
			}
		}
		return vtkScalarsToTextureFilter2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_SetTextureDimensions_13(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the width and height of the generated texture.
	/// Default is 128x128. The width and height must be greater than 1.
	/// </summary>
	public virtual void SetTextureDimensions(int _arg1, int _arg2)
	{
		vtkScalarsToTextureFilter_SetTextureDimensions_13(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_SetTextureDimensions_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the width and height of the generated texture.
	/// Default is 128x128. The width and height must be greater than 1.
	/// </summary>
	public void SetTextureDimensions(IntPtr _arg)
	{
		vtkScalarsToTextureFilter_SetTextureDimensions_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_SetTransferFunction_15(HandleRef pThis, HandleRef stc);

	/// <summary>
	/// Set/Get a color transfer function.
	/// This transfer function will be used to determine the pixel colors of the texture.
	/// If not specified, the filter use a default one (blue/white/red) based on the range of the
	/// input array.
	/// </summary>
	public void SetTransferFunction(vtkScalarsToColors stc)
	{
		vtkScalarsToTextureFilter_SetTransferFunction_15(GetCppThis(), stc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_SetUseTransferFunction_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if a new point array containing RGBA values have to be computed by the specified
	/// color transfer function.
	/// </summary>
	public virtual void SetUseTransferFunction(bool _arg)
	{
		vtkScalarsToTextureFilter_SetUseTransferFunction_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_UseTransferFunctionOff_17(HandleRef pThis);

	/// <summary>
	/// Specify if a new point array containing RGBA values have to be computed by the specified
	/// color transfer function.
	/// </summary>
	public virtual void UseTransferFunctionOff()
	{
		vtkScalarsToTextureFilter_UseTransferFunctionOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToTextureFilter_UseTransferFunctionOn_18(HandleRef pThis);

	/// <summary>
	/// Specify if a new point array containing RGBA values have to be computed by the specified
	/// color transfer function.
	/// </summary>
	public virtual void UseTransferFunctionOn()
	{
		vtkScalarsToTextureFilter_UseTransferFunctionOn_18(GetCppThis());
	}
}
