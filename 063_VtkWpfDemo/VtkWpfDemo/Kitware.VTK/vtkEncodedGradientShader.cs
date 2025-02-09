using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEncodedGradientShader
/// </summary>
/// <remarks>
///    Compute shading tables for encoded normals.
///
///
/// vtkEncodedGradientShader computes shading tables for encoded normals
/// that indicates the amount of diffuse and specular illumination that is
/// received from all light sources at a surface location with that normal.
/// For diffuse illumination this is accurate, but for specular illumination
/// it is approximate for perspective projections since the center view
/// direction is always used as the view direction. Since the shading table is
/// dependent on the volume (for the transformation that must be applied to
/// the normals to put them into world coordinates) there is a shading table
/// per volume. This is necessary because multiple volumes can share a
/// volume mapper.
/// </remarks>
public class vtkEncodedGradientShader : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEncodedGradientShader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEncodedGradientShader()
	{
		MRClassNameKey = "class vtkEncodedGradientShader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEncodedGradientShader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEncodedGradientShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEncodedGradientShader New()
	{
		vtkEncodedGradientShader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientShader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEncodedGradientShader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEncodedGradientShader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientShader_GetActiveComponent_01(HandleRef pThis);

	/// <summary>
	/// Set the active component for shading. This component's
	/// ambient / diffuse / specular / specular power values will
	/// be used to create the shading table. The default is 1.0
	/// </summary>
	public virtual int GetActiveComponent()
	{
		return vtkEncodedGradientShader_GetActiveComponent_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientShader_GetActiveComponentMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set the active component for shading. This component's
	/// ambient / diffuse / specular / specular power values will
	/// be used to create the shading table. The default is 1.0
	/// </summary>
	public virtual int GetActiveComponentMaxValue()
	{
		return vtkEncodedGradientShader_GetActiveComponentMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientShader_GetActiveComponentMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set the active component for shading. This component's
	/// ambient / diffuse / specular / specular power values will
	/// be used to create the shading table. The default is 1.0
	/// </summary>
	public virtual int GetActiveComponentMinValue()
	{
		return vtkEncodedGradientShader_GetActiveComponentMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_GetBlueDiffuseShadingTable_04(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// Get the red/green/blue shading table.
	/// </summary>
	public IntPtr GetBlueDiffuseShadingTable(vtkVolume vol)
	{
		return vtkEncodedGradientShader_GetBlueDiffuseShadingTable_04(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_GetBlueSpecularShadingTable_05(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// Get the red/green/blue shading table.
	/// </summary>
	public IntPtr GetBlueSpecularShadingTable(vtkVolume vol)
	{
		return vtkEncodedGradientShader_GetBlueSpecularShadingTable_05(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_GetGreenDiffuseShadingTable_06(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// Get the red/green/blue shading table.
	/// </summary>
	public IntPtr GetGreenDiffuseShadingTable(vtkVolume vol)
	{
		return vtkEncodedGradientShader_GetGreenDiffuseShadingTable_06(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_GetGreenSpecularShadingTable_07(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// Get the red/green/blue shading table.
	/// </summary>
	public IntPtr GetGreenSpecularShadingTable(vtkVolume vol)
	{
		return vtkEncodedGradientShader_GetGreenSpecularShadingTable_07(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEncodedGradientShader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEncodedGradientShader_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEncodedGradientShader_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEncodedGradientShader_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_GetRedDiffuseShadingTable_10(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// Get the red/green/blue shading table.
	/// </summary>
	public IntPtr GetRedDiffuseShadingTable(vtkVolume vol)
	{
		return vtkEncodedGradientShader_GetRedDiffuseShadingTable_10(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_GetRedSpecularShadingTable_11(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// Get the red/green/blue shading table.
	/// </summary>
	public IntPtr GetRedSpecularShadingTable(vtkVolume vol)
	{
		return vtkEncodedGradientShader_GetRedSpecularShadingTable_11(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensity_12(HandleRef pThis);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual float GetZeroNormalDiffuseIntensity()
	{
		return vtkEncodedGradientShader_GetZeroNormalDiffuseIntensity_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual float GetZeroNormalDiffuseIntensityMaxValue()
	{
		return vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual float GetZeroNormalDiffuseIntensityMinValue()
	{
		return vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensity_15(HandleRef pThis);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual float GetZeroNormalSpecularIntensity()
	{
		return vtkEncodedGradientShader_GetZeroNormalSpecularIntensity_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual float GetZeroNormalSpecularIntensityMaxValue()
	{
		return vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual float GetZeroNormalSpecularIntensityMinValue()
	{
		return vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientShader_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEncodedGradientShader_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientShader_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEncodedGradientShader_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEncodedGradientShader NewInstance()
	{
		vtkEncodedGradientShader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientShader_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientShader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEncodedGradientShader SafeDownCast(vtkObjectBase o)
	{
		vtkEncodedGradientShader vtkEncodedGradientShader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientShader_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEncodedGradientShader2 = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEncodedGradientShader2.Register(null);
			}
		}
		return vtkEncodedGradientShader2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientShader_SetActiveComponent_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the active component for shading. This component's
	/// ambient / diffuse / specular / specular power values will
	/// be used to create the shading table. The default is 1.0
	/// </summary>
	public virtual void SetActiveComponent(int _arg)
	{
		vtkEncodedGradientShader_SetActiveComponent_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientShader_SetZeroNormalDiffuseIntensity_24(HandleRef pThis, float _arg);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual void SetZeroNormalDiffuseIntensity(float _arg)
	{
		vtkEncodedGradientShader_SetZeroNormalDiffuseIntensity_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientShader_SetZeroNormalSpecularIntensity_25(HandleRef pThis, float _arg);

	/// <summary>
	/// Set / Get the intensity diffuse / specular light used for the
	/// zero normals.
	/// </summary>
	public virtual void SetZeroNormalSpecularIntensity(float _arg)
	{
		vtkEncodedGradientShader_SetZeroNormalSpecularIntensity_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientShader_UpdateShadingTable_26(HandleRef pThis, HandleRef ren, HandleRef vol, HandleRef gradest);

	/// <summary>
	/// Cause the shading table to be updated
	/// </summary>
	public void UpdateShadingTable(vtkRenderer ren, vtkVolume vol, vtkEncodedGradientEstimator gradest)
	{
		vtkEncodedGradientShader_UpdateShadingTable_26(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef), gradest?.GetCppThis() ?? default(HandleRef));
	}
}
