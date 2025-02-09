using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTriangularTexture
/// </summary>
/// <remarks>
///    generate 2D triangular texture map
///
/// vtkTriangularTexture is a filter that generates a 2D texture map based on
/// the paper "Opacity-modulating Triangular Textures for Irregular Surfaces,"
/// by Penny Rheingans, IEEE Visualization '96, pp. 219-225.
/// The textures assume texture coordinates of (0,0), (1.0) and
/// (.5, sqrt(3)/2). The sequence of texture values is the same along each
/// edge of the triangular texture map. So, the assignment order of texture
/// coordinates is arbitrary.
///
/// </remarks>
/// <seealso>
///
/// vtkTriangularTCoords
/// </seealso>
public class vtkTriangularTexture : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTriangularTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTriangularTexture()
	{
		MRClassNameKey = "class vtkTriangularTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangularTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTriangularTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangularTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with XSize and YSize = 64; the texture pattern =1
	/// (opaque at centroid); and the scale factor set to 1.0.
	/// </summary>
	public new static vtkTriangularTexture New()
	{
		vtkTriangularTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangularTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with XSize and YSize = 64; the texture pattern =1
	/// (opaque at centroid); and the scale factor set to 1.0.
	/// </summary>
	public vtkTriangularTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTriangularTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangularTexture_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTriangularTexture_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangularTexture_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTriangularTexture_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTriangularTexture_GetScaleFactor_03(HandleRef pThis);

	/// <summary>
	/// Set a Scale Factor.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkTriangularTexture_GetScaleFactor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_GetTexturePattern_04(HandleRef pThis);

	/// <summary>
	/// Set the texture pattern.
	/// 1 = opaque at centroid (default)
	/// 2 = opaque at vertices
	/// 3 = opaque in rings around vertices
	/// </summary>
	public virtual int GetTexturePattern()
	{
		return vtkTriangularTexture_GetTexturePattern_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_GetTexturePatternMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the texture pattern.
	/// 1 = opaque at centroid (default)
	/// 2 = opaque at vertices
	/// 3 = opaque in rings around vertices
	/// </summary>
	public virtual int GetTexturePatternMaxValue()
	{
		return vtkTriangularTexture_GetTexturePatternMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_GetTexturePatternMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the texture pattern.
	/// 1 = opaque at centroid (default)
	/// 2 = opaque at vertices
	/// 3 = opaque in rings around vertices
	/// </summary>
	public virtual int GetTexturePatternMinValue()
	{
		return vtkTriangularTexture_GetTexturePatternMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_GetXSize_07(HandleRef pThis);

	/// <summary>
	/// Set the X texture map dimension. Default is 64.
	/// </summary>
	public virtual int GetXSize()
	{
		return vtkTriangularTexture_GetXSize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_GetYSize_08(HandleRef pThis);

	/// <summary>
	/// Set the Y texture map dimension. Default is 64.
	/// </summary>
	public virtual int GetYSize()
	{
		return vtkTriangularTexture_GetYSize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTriangularTexture_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangularTexture_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTriangularTexture_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangularTexture_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTriangularTexture NewInstance()
	{
		vtkTriangularTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangularTexture_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangularTexture_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangularTexture SafeDownCast(vtkObjectBase o)
	{
		vtkTriangularTexture vtkTriangularTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangularTexture_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTriangularTexture2 = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTriangularTexture2.Register(null);
			}
		}
		return vtkTriangularTexture2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangularTexture_SetScaleFactor_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Set a Scale Factor.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkTriangularTexture_SetScaleFactor_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangularTexture_SetTexturePattern_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the texture pattern.
	/// 1 = opaque at centroid (default)
	/// 2 = opaque at vertices
	/// 3 = opaque in rings around vertices
	/// </summary>
	public virtual void SetTexturePattern(int _arg)
	{
		vtkTriangularTexture_SetTexturePattern_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangularTexture_SetXSize_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the X texture map dimension. Default is 64.
	/// </summary>
	public virtual void SetXSize(int _arg)
	{
		vtkTriangularTexture_SetXSize_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangularTexture_SetYSize_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Y texture map dimension. Default is 64.
	/// </summary>
	public virtual void SetYSize(int _arg)
	{
		vtkTriangularTexture_SetYSize_17(GetCppThis(), _arg);
	}
}
