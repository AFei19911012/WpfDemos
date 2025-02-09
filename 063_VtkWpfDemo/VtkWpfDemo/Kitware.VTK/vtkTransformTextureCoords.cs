using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransformTextureCoords
/// </summary>
/// <remarks>
///    transform (scale, rotate, translate) texture coordinates
///
/// vtkTransformTextureCoords is a filter that operates on texture
/// coordinates. It ingests any type of dataset, and outputs a dataset of the
/// same type. The filter lets you scale, translate, and rotate texture
/// coordinates. For example, by using the Scale ivar, you can shift
/// texture coordinates that range from (0-&gt;1) to range from (0-&gt;10) (useful
/// for repeated patterns).
///
/// The filter operates on texture coordinates of dimension 1-&gt;3. The texture
/// coordinates are referred to as r-s-t. If the texture map is two dimensional,
/// the t-coordinate (and operations on the t-coordinate) are ignored.
///
/// </remarks>
/// <seealso>
///
/// vtkTextureMapToPlane  vtkTextureMapToCylinder
/// vtkTextureMapToSphere vtkThresholdTextureCoords vtkTexture
/// </seealso>
public class vtkTransformTextureCoords : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransformTextureCoords";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransformTextureCoords()
	{
		MRClassNameKey = "class vtkTransformTextureCoords";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformTextureCoords"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransformTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create instance with Origin (0.5,0.5,0.5); Position (0,0,0); and Scale
	/// set to (1,1,1). Rotation of the texture coordinates is turned off.
	/// </summary>
	public new static vtkTransformTextureCoords New()
	{
		vtkTransformTextureCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create instance with Origin (0.5,0.5,0.5); Position (0,0,0); and Scale
	/// set to (1,1,1). Rotation of the texture coordinates is turned off.
	/// </summary>
	public vtkTransformTextureCoords()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransformTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTransformTextureCoords_AddPosition_01(HandleRef pThis, double deltaR, double deltaS, double deltaT);

	/// <summary>
	/// Incrementally change the position of the texture map (i.e., does a
	/// translate or shift of the texture coordinates).
	/// </summary>
	public void AddPosition(double deltaR, double deltaS, double deltaT)
	{
		vtkTransformTextureCoords_AddPosition_01(GetCppThis(), deltaR, deltaS, deltaT);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_AddPosition_02(HandleRef pThis, IntPtr deltaPosition);

	/// <summary>
	/// Incrementally change the position of the texture map (i.e., does a
	/// translate or shift of the texture coordinates).
	/// </summary>
	public void AddPosition(IntPtr deltaPosition)
	{
		vtkTransformTextureCoords_AddPosition_02(GetCppThis(), deltaPosition);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_FlipROff_03(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void FlipROff()
	{
		vtkTransformTextureCoords_FlipROff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_FlipROn_04(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void FlipROn()
	{
		vtkTransformTextureCoords_FlipROn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_FlipSOff_05(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void FlipSOff()
	{
		vtkTransformTextureCoords_FlipSOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_FlipSOn_06(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void FlipSOn()
	{
		vtkTransformTextureCoords_FlipSOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_FlipTOff_07(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// t-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void FlipTOff()
	{
		vtkTransformTextureCoords_FlipTOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_FlipTOn_08(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// t-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void FlipTOn()
	{
		vtkTransformTextureCoords_FlipTOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformTextureCoords_GetFlipR_09(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual int GetFlipR()
	{
		return vtkTransformTextureCoords_GetFlipR_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformTextureCoords_GetFlipS_10(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual int GetFlipS()
	{
		return vtkTransformTextureCoords_GetFlipS_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformTextureCoords_GetFlipT_11(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// t-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual int GetFlipT()
	{
		return vtkTransformTextureCoords_GetFlipT_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformTextureCoords_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransformTextureCoords_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformTextureCoords_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransformTextureCoords_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformTextureCoords_GetOrigin_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the texture map. This is the point about which the
	/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
	/// from (0,1) in the r-s-t coordinates, the default origin is set at
	/// (0.5,0.5,0.5).
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkTransformTextureCoords_GetOrigin_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_GetOrigin_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the origin of the texture map. This is the point about which the
	/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
	/// from (0,1) in the r-s-t coordinates, the default origin is set at
	/// (0.5,0.5,0.5).
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkTransformTextureCoords_GetOrigin_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformTextureCoords_GetPosition_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the texture map. Setting the position translates
	/// the texture map by the amount specified.
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkTransformTextureCoords_GetPosition_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_GetPosition_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the position of the texture map. Setting the position translates
	/// the texture map by the amount specified.
	/// </summary>
	public virtual void GetPosition(IntPtr data)
	{
		vtkTransformTextureCoords_GetPosition_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformTextureCoords_GetScale_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the scale of the texture map. Scaling in performed independently
	/// on the r, s and t axes.
	/// </summary>
	public virtual double[] GetScale()
	{
		IntPtr intPtr = vtkTransformTextureCoords_GetScale_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_GetScale_19(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the scale of the texture map. Scaling in performed independently
	/// on the r, s and t axes.
	/// </summary>
	public virtual void GetScale(IntPtr data)
	{
		vtkTransformTextureCoords_GetScale_19(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformTextureCoords_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransformTextureCoords_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformTextureCoords_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransformTextureCoords_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformTextureCoords_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTransformTextureCoords NewInstance()
	{
		vtkTransformTextureCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformTextureCoords_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformTextureCoords_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransformTextureCoords SafeDownCast(vtkObjectBase o)
	{
		vtkTransformTextureCoords vtkTransformTextureCoords2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformTextureCoords_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransformTextureCoords2 = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransformTextureCoords2.Register(null);
			}
		}
		return vtkTransformTextureCoords2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetFlipR_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void SetFlipR(int _arg)
	{
		vtkTransformTextureCoords_SetFlipR_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetFlipS_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// s-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void SetFlipS(int _arg)
	{
		vtkTransformTextureCoords_SetFlipS_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetFlipT_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean indicates whether the texture map should be flipped around the
	/// t-axis. Note that the flips occur around the texture origin.
	/// </summary>
	public virtual void SetFlipT(int _arg)
	{
		vtkTransformTextureCoords_SetFlipT_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetOrigin_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the origin of the texture map. This is the point about which the
	/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
	/// from (0,1) in the r-s-t coordinates, the default origin is set at
	/// (0.5,0.5,0.5).
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkTransformTextureCoords_SetOrigin_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetOrigin_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the texture map. This is the point about which the
	/// texture map is flipped (e.g., rotated). Since a typical texture map ranges
	/// from (0,1) in the r-s-t coordinates, the default origin is set at
	/// (0.5,0.5,0.5).
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkTransformTextureCoords_SetOrigin_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetPosition_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the position of the texture map. Setting the position translates
	/// the texture map by the amount specified.
	/// </summary>
	public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkTransformTextureCoords_SetPosition_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetPosition_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the texture map. Setting the position translates
	/// the texture map by the amount specified.
	/// </summary>
	public virtual void SetPosition(IntPtr _arg)
	{
		vtkTransformTextureCoords_SetPosition_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetScale_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the scale of the texture map. Scaling in performed independently
	/// on the r, s and t axes.
	/// </summary>
	public virtual void SetScale(double _arg1, double _arg2, double _arg3)
	{
		vtkTransformTextureCoords_SetScale_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformTextureCoords_SetScale_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the scale of the texture map. Scaling in performed independently
	/// on the r, s and t axes.
	/// </summary>
	public virtual void SetScale(IntPtr _arg)
	{
		vtkTransformTextureCoords_SetScale_33(GetCppThis(), _arg);
	}
}
