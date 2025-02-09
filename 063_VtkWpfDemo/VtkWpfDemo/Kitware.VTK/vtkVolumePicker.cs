using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumePicker
/// </summary>
/// <remarks>
///    ray-cast picker enhanced for volumes
///
/// vtkVolumePicker is a subclass of vtkCellPicker.  It has one
/// advantage over vtkCellPicker for volumes: it will be able to
/// correctly perform picking when CroppingPlanes are present.  This
/// isn't possible for vtkCellPicker since it doesn't link to
/// the VolumeRendering classes and hence cannot access information
/// about the CroppingPlanes.
///
/// </remarks>
/// <seealso>
///
/// vtkPicker vtkPointPicker vtkCellPicker
///
/// @par Thanks:
/// This class was contributed to VTK by David Gobbi on behalf of Atamai Inc.
/// </seealso>
public class vtkVolumePicker : vtkCellPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumePicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumePicker()
	{
		MRClassNameKey = "class vtkVolumePicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumePicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumePicker New()
	{
		vtkVolumePicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVolumePicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolumePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkVolumePicker_GetCroppingPlaneId_01(HandleRef pThis);

	/// <summary>
	/// Get the index of the cropping plane that the pick ray passed
	/// through on its way to the prop. This will be set regardless
	/// of whether PickCroppingPlanes is on.  The crop planes are ordered
	/// as follows: xmin, xmax, ymin, ymax, zmin, zmax.  If the volume is
	/// not cropped, the value will bet set to -1.
	/// </summary>
	public virtual int GetCroppingPlaneId()
	{
		return vtkVolumePicker_GetCroppingPlaneId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumePicker_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumePicker_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumePicker_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumePicker_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumePicker_GetPickCroppingPlanes_04(HandleRef pThis);

	/// <summary>
	/// Set whether to pick the cropping planes of props that have them.
	/// If this is set, then the pick will be done on the cropping planes
	/// rather than on the data. The GetCroppingPlaneId() method will return
	/// the index of the cropping plane of the volume that was picked.  This
	/// setting is only relevant to the picking of volumes.
	/// </summary>
	public virtual int GetPickCroppingPlanes()
	{
		return vtkVolumePicker_GetPickCroppingPlanes_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumePicker_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumePicker_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumePicker_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumePicker_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumePicker_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumePicker NewInstance()
	{
		vtkVolumePicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumePicker_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumePicker_PickCroppingPlanesOff_09(HandleRef pThis);

	/// <summary>
	/// Set whether to pick the cropping planes of props that have them.
	/// If this is set, then the pick will be done on the cropping planes
	/// rather than on the data. The GetCroppingPlaneId() method will return
	/// the index of the cropping plane of the volume that was picked.  This
	/// setting is only relevant to the picking of volumes.
	/// </summary>
	public virtual void PickCroppingPlanesOff()
	{
		vtkVolumePicker_PickCroppingPlanesOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumePicker_PickCroppingPlanesOn_10(HandleRef pThis);

	/// <summary>
	/// Set whether to pick the cropping planes of props that have them.
	/// If this is set, then the pick will be done on the cropping planes
	/// rather than on the data. The GetCroppingPlaneId() method will return
	/// the index of the cropping plane of the volume that was picked.  This
	/// setting is only relevant to the picking of volumes.
	/// </summary>
	public virtual void PickCroppingPlanesOn()
	{
		vtkVolumePicker_PickCroppingPlanesOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumePicker_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumePicker SafeDownCast(vtkObjectBase o)
	{
		vtkVolumePicker vtkVolumePicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumePicker_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumePicker2 = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumePicker2.Register(null);
			}
		}
		return vtkVolumePicker2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumePicker_SetPickCroppingPlanes_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to pick the cropping planes of props that have them.
	/// If this is set, then the pick will be done on the cropping planes
	/// rather than on the data. The GetCroppingPlaneId() method will return
	/// the index of the cropping plane of the volume that was picked.  This
	/// setting is only relevant to the picking of volumes.
	/// </summary>
	public virtual void SetPickCroppingPlanes(int _arg)
	{
		vtkVolumePicker_SetPickCroppingPlanes_12(GetCppThis(), _arg);
	}
}
