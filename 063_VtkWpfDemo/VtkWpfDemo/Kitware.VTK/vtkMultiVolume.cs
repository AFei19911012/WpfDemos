using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkMultiVolume
/// </summary>
/// <remarks>
///  Represents a world axis-aligned bounding-box containing a set of
/// volumes in a rendered scene.
///
/// vtkVolume instances registered in this class can be overlapping. They are
/// intended to be all rendered simultaneously by a vtkGPUVolumeRayCastMapper
/// (inputs should be set directly in the mapper).
///
/// This class holds the full transformation of a bounding-box containing
/// all of the registered volumes.
///
///      + TexToBBox : Texture-to-Data (scaling)
///      + Matrix : Data-to-World (translation)
///
/// @note This class is intended to be used only by mappers supporting multiple
/// inputs.
///
/// </remarks>
/// <seealso>
///  vtkVolume vtkAbstractVolumeMapper vtkGPUVolumeRayCastMapper
/// </seealso>
public class vtkMultiVolume : vtkVolume
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiVolume";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiVolume()
	{
		MRClassNameKey = "class vtkMultiVolume";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiVolume"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiVolume New()
	{
		vtkMultiVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiVolume()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMultiVolume_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Computes the bounds of the box containing all of the vtkVolume instances.
	/// Returns the bounds (vtkVolume::Bounds) in world coordinates [xmin, xmax,
	/// ymin, ymax, zmin, zmax] but also keeps cached the bounds in data coordinates
	/// (vtkMultiVolume::DataBounds).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkMultiVolume_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMultiVolume_GetBoundsTime_02(HandleRef pThis);

	/// <summary>
	/// Total bounds in data coordinates.
	/// </summary>
	public ulong GetBoundsTime()
	{
		return vtkMultiVolume_GetBoundsTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_GetDataBounds_03(HandleRef pThis);

	/// <summary>
	/// Total bounds in data coordinates.
	/// </summary>
	public IntPtr GetDataBounds()
	{
		return vtkMultiVolume_GetDataBounds_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_GetDataGeometry_04(HandleRef pThis);

	/// <summary>
	/// Return the eight corners of the volume
	/// </summary>
	public IntPtr GetDataGeometry()
	{
		return vtkMultiVolume_GetDataGeometry_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMultiVolume_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// \sa vtkVolume
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMultiVolume_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_GetMatrix_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// As with other vtkProp3D, Matrix holds the transformation from data
	/// coordinates to world coordinates.  Since this class represents an
	/// axis-aligned bounding-box, this transformation only contains a translation
	/// vector. Each registered vtkVolume contains its own transformation with
	/// respect to the world coordinate system.
	/// \sa vtkProp3D vtkVolume
	/// </summary>
	public override vtkMatrix4x4 GetMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_GetMatrix_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiVolume_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiVolume_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiVolume_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiVolume_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_GetProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given that this class represents a bounding-box only there is no property
	/// directly associated with it (a cannot be set directly).
	/// This instance will return the property of the volume registered in the 0th
	/// port (or nullptr if no volume has been set).
	/// \sa vtkVolume
	/// </summary>
	public override vtkVolumeProperty GetProperty()
	{
		vtkVolumeProperty vtkVolumeProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_GetProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeProperty2 = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeProperty2.Register(null);
			}
		}
		return vtkVolumeProperty2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_GetTextureMatrix_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the transformation from texture coordinates to data cooridinates
	/// of the bounding-box. Since this class represents an axis-aligned bounding
	/// -boxThis, this transformation only contains a scaling diagonal.
	/// </summary>
	public vtkMatrix4x4 GetTextureMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_GetTextureMatrix_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_GetVolume_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add / Remove a vtkVolume instance.
	/// </summary>
	public vtkVolume GetVolume(int port)
	{
		vtkVolume vtkVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_GetVolume_11(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolume2 = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolume2.Register(null);
			}
		}
		return vtkVolume2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiVolume_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiVolume_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiVolume_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiVolume_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiVolume NewInstance()
	{
		vtkMultiVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiVolume_RemoveVolume_16(HandleRef pThis, int port);

	/// <summary>
	/// Add / Remove a vtkVolume instance.
	/// </summary>
	public void RemoveVolume(int port)
	{
		vtkMultiVolume_RemoveVolume_16(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiVolume_RenderVolumetricGeometry_17(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Since vtkMultiVolume acts like a proxy volume to compute the bounding box
	/// for its internal vtkVolume instances, there are no properties to be set directly
	/// in this instance. For that reason, this override ignores the vtkVolumeProperty
	/// check.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport vp)
	{
		return vtkMultiVolume_RenderVolumetricGeometry_17(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiVolume_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiVolume SafeDownCast(vtkObjectBase o)
	{
		vtkMultiVolume vtkMultiVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiVolume_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiVolume2 = (vtkMultiVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiVolume2.Register(null);
			}
		}
		return vtkMultiVolume2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiVolume_SetProperty_19(HandleRef pThis, HandleRef property);

	/// <summary>
	/// Given that this class represents a bounding-box only there is no property
	/// directly associated with it (a cannot be set directly).
	/// This instance will return the property of the volume registered in the 0th
	/// port (or nullptr if no volume has been set).
	/// \sa vtkVolume
	/// </summary>
	public override void SetProperty(vtkVolumeProperty property)
	{
		vtkMultiVolume_SetProperty_19(GetCppThis(), property?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiVolume_SetVolume_20(HandleRef pThis, HandleRef volume, int port);

	/// <summary>
	/// Add / Remove a vtkVolume instance.
	/// </summary>
	public void SetVolume(vtkVolume volume, int port)
	{
		vtkMultiVolume_SetVolume_20(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), port);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiVolume_ShallowCopy_21(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Checks whether the vtkProp passed is another vtkMultiVolume and tries to
	/// copy accordingly. Otherwise it falls back to vtkVolume::ShallowCopy.
	/// \sa vtkVolume
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkMultiVolume_ShallowCopy_21(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
