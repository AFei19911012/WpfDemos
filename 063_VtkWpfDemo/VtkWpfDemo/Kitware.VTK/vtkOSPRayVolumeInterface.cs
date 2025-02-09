using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOSPRayVolumeInterface
/// </summary>
/// <remarks>
///    Removes link dependence
/// on optional ospray module.
///
/// Class allows SmartVolume to use OSPRay for rendering when ospray
/// is enabled. When disabled, this class does nothing but return a warning.
/// </remarks>
public class vtkOSPRayVolumeInterface : vtkVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOSPRayVolumeInterface";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOSPRayVolumeInterface()
	{
		MRClassNameKey = "class vtkOSPRayVolumeInterface";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOSPRayVolumeInterface"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOSPRayVolumeInterface(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOSPRayVolumeInterface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOSPRayVolumeInterface New()
	{
		vtkOSPRayVolumeInterface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOSPRayVolumeInterface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOSPRayVolumeInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOSPRayVolumeInterface()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOSPRayVolumeInterface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOSPRayVolumeInterface_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOSPRayVolumeInterface_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOSPRayVolumeInterface_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOSPRayVolumeInterface_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOSPRayVolumeInterface_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOSPRayVolumeInterface_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOSPRayVolumeInterface NewInstance()
	{
		vtkOSPRayVolumeInterface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOSPRayVolumeInterface_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOSPRayVolumeInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOSPRayVolumeInterface_Render_07(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Overridden to warn about lack of OSPRay if not overridden.
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkOSPRayVolumeInterface_Render_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOSPRayVolumeInterface_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOSPRayVolumeInterface SafeDownCast(vtkObjectBase o)
	{
		vtkOSPRayVolumeInterface vtkOSPRayVolumeInterface2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOSPRayVolumeInterface_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOSPRayVolumeInterface2 = (vtkOSPRayVolumeInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOSPRayVolumeInterface2.Register(null);
			}
		}
		return vtkOSPRayVolumeInterface2;
	}
}
