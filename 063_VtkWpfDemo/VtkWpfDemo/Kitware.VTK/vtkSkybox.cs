using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSkybox
/// </summary>
/// <remarks>
///  Renders a skybox environment
///
/// You must provide a texture cube map using the SetTexture method.
/// </remarks>
public class vtkSkybox : vtkActor
{
	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public enum Projection
	{
		/// <summary>enum member</summary>
		Cube = 0,
		/// <summary>enum member</summary>
		Floor = 2,
		/// <summary>enum member</summary>
		Sphere = 1,
		/// <summary>enum member</summary>
		StereoSphere = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSkybox";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSkybox()
	{
		MRClassNameKey = "class vtkSkybox";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSkybox"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSkybox(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSkybox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSkybox New()
	{
		vtkSkybox result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSkybox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSkybox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSkybox()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSkybox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSkybox_GammaCorrectOff_01(HandleRef pThis);

	/// <summary>
	/// Define if the colors should be gamma corrected.
	/// This is generally required if the input texture is in linear color space.
	/// Default is off.
	/// </summary>
	public virtual void GammaCorrectOff()
	{
		vtkSkybox_GammaCorrectOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_GammaCorrectOn_02(HandleRef pThis);

	/// <summary>
	/// Define if the colors should be gamma corrected.
	/// This is generally required if the input texture is in linear color space.
	/// Default is off.
	/// </summary>
	public virtual void GammaCorrectOn()
	{
		vtkSkybox_GammaCorrectOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSkybox_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
	/// method GetBounds(double bounds[6]) is available from the superclass.)
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkSkybox_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSkybox_GetFloorPlane_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual float[] GetFloorPlane()
	{
		IntPtr intPtr = vtkSkybox_GetFloorPlane_04(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_GetFloorPlane_05(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void GetFloorPlane(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
	{
		vtkSkybox_GetFloorPlane_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_GetFloorPlane_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void GetFloorPlane(IntPtr _arg)
	{
		vtkSkybox_GetFloorPlane_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSkybox_GetFloorRight_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual float[] GetFloorRight()
	{
		IntPtr intPtr = vtkSkybox_GetFloorRight_07(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_GetFloorRight_08(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void GetFloorRight(ref float _arg1, ref float _arg2, ref float _arg3)
	{
		vtkSkybox_GetFloorRight_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_GetFloorRight_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void GetFloorRight(IntPtr _arg)
	{
		vtkSkybox_GetFloorRight_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSkybox_GetGammaCorrect_10(HandleRef pThis);

	/// <summary>
	/// Define if the colors should be gamma corrected.
	/// This is generally required if the input texture is in linear color space.
	/// Default is off.
	/// </summary>
	public virtual bool GetGammaCorrect()
	{
		return (vtkSkybox_GetGammaCorrect_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSkybox_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSkybox_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSkybox_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSkybox_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSkybox_GetProjection_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public virtual int GetProjection()
	{
		return vtkSkybox_GetProjection_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSkybox_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSkybox_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSkybox_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSkybox_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSkybox_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSkybox NewInstance()
	{
		vtkSkybox result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSkybox_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSkybox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSkybox_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSkybox SafeDownCast(vtkObjectBase o)
	{
		vtkSkybox vtkSkybox2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSkybox_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSkybox2 = (vtkSkybox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSkybox2.Register(null);
			}
		}
		return vtkSkybox2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetFloorPlane_19(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void SetFloorPlane(float _arg1, float _arg2, float _arg3, float _arg4)
	{
		vtkSkybox_SetFloorPlane_19(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetFloorPlane_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void SetFloorPlane(IntPtr _arg)
	{
		vtkSkybox_SetFloorPlane_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetFloorRight_21(HandleRef pThis, float _arg1, float _arg2, float _arg3);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void SetFloorRight(float _arg1, float _arg2, float _arg3)
	{
		vtkSkybox_SetFloorRight_21(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetFloorRight_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane equation for the floor.
	/// </summary>
	public virtual void SetFloorRight(IntPtr _arg)
	{
		vtkSkybox_SetFloorRight_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetGammaCorrect_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Define if the colors should be gamma corrected.
	/// This is generally required if the input texture is in linear color space.
	/// Default is off.
	/// </summary>
	public virtual void SetGammaCorrect(bool _arg)
	{
		vtkSkybox_SetGammaCorrect_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetProjection_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public virtual void SetProjection(int _arg)
	{
		vtkSkybox_SetProjection_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetProjectionToCube_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public void SetProjectionToCube()
	{
		vtkSkybox_SetProjectionToCube_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetProjectionToFloor_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public void SetProjectionToFloor()
	{
		vtkSkybox_SetProjectionToFloor_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetProjectionToSphere_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public void SetProjectionToSphere()
	{
		vtkSkybox_SetProjectionToSphere_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSkybox_SetProjectionToStereoSphere_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the projection to be used
	/// </summary>
	public void SetProjectionToStereoSphere()
	{
		vtkSkybox_SetProjectionToStereoSphere_28(GetCppThis());
	}
}
