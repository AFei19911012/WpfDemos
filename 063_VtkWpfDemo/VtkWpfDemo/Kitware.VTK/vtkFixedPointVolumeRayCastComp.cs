using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFixedPointVolumeRayCastCompositeGOHelper
/// </summary>
/// <remarks>
///    A helper that generates composite images for the volume ray cast mapper
///
/// This is one of the helper classes for the vtkFixedPointVolumeRayCastMapper.
/// It will generate composite images using an alpha blending operation.
/// This class should not be used directly, it is a helper class for
/// the mapper and has no user-level API.
///
/// </remarks>
/// <seealso>
///
/// vtkFixedPointVolumeRayCastMapper
/// </seealso>
public class vtkFixedPointVolumeRayCastCompositeGOHelper : vtkFixedPointVolumeRayCastHelper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedPointVolumeRayCastCompositeGOHelper()
	{
		MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeGOHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeGOHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeGOHelper New()
	{
		vtkFixedPointVolumeRayCastCompositeGOHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeGOHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFixedPointVolumeRayCastCompositeGOHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
	{
		vtkFixedPointVolumeRayCastCompositeGOHelper_GenerateImage_01(GetCppThis(), threadID, threadCount, vol?.GetCppThis() ?? default(HandleRef), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeGOHelper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOHelper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeGOHelper_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOHelper_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedPointVolumeRayCastCompositeGOHelper NewInstance()
	{
		vtkFixedPointVolumeRayCastCompositeGOHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeGOHelper SafeDownCast(vtkObjectBase o)
	{
		vtkFixedPointVolumeRayCastCompositeGOHelper vtkFixedPointVolumeRayCastCompositeGOHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper2 = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeGOHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeGOHelper2;
	}
}
/// <summary>
///    vtkFixedPointVolumeRayCastCompositeGOShadeHelper
/// </summary>
/// <remarks>
///    A helper that generates composite images for the volume ray cast mapper
///
/// This is one of the helper classes for the vtkFixedPointVolumeRayCastMapper.
/// It will generate composite images using an alpha blending operation.
/// This class should not be used directly, it is a helper class for
/// the mapper and has no user-level API.
///
/// </remarks>
/// <seealso>
///
/// vtkFixedPointVolumeRayCastMapper
/// </seealso>
public class vtkFixedPointVolumeRayCastCompositeGOShadeHelper : vtkFixedPointVolumeRayCastHelper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOShadeHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedPointVolumeRayCastCompositeGOShadeHelper()
	{
		MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeGOShadeHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOShadeHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeGOShadeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOShadeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeGOShadeHelper New()
	{
		vtkFixedPointVolumeRayCastCompositeGOShadeHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOShadeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeGOShadeHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeGOShadeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
	{
		vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GenerateImage_01(GetCppThis(), threadID, threadCount, vol?.GetCppThis() ?? default(HandleRef), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOShadeHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedPointVolumeRayCastCompositeGOShadeHelper NewInstance()
	{
		vtkFixedPointVolumeRayCastCompositeGOShadeHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOShadeHelper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOShadeHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeGOShadeHelper SafeDownCast(vtkObjectBase o)
	{
		vtkFixedPointVolumeRayCastCompositeGOShadeHelper vtkFixedPointVolumeRayCastCompositeGOShadeHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOShadeHelper_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper2 = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeGOShadeHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeGOShadeHelper2;
	}
}
/// <summary>
///    vtkFixedPointVolumeRayCastCompositeHelper
/// </summary>
/// <remarks>
///    A helper that generates composite images for the volume ray cast mapper
///
/// This is one of the helper classes for the vtkFixedPointVolumeRayCastMapper.
/// It will generate composite images using an alpha blending operation.
/// This class should not be used directly, it is a helper class for
/// the mapper and has no user-level API.
///
/// </remarks>
/// <seealso>
///
/// vtkFixedPointVolumeRayCastMapper
/// </seealso>
public class vtkFixedPointVolumeRayCastCompositeHelper : vtkFixedPointVolumeRayCastHelper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedPointVolumeRayCastCompositeHelper()
	{
		MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeHelper New()
	{
		vtkFixedPointVolumeRayCastCompositeHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFixedPointVolumeRayCastCompositeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
	{
		vtkFixedPointVolumeRayCastCompositeHelper_GenerateImage_01(GetCppThis(), threadID, threadCount, vol?.GetCppThis() ?? default(HandleRef), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeHelper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeHelper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeHelper_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeHelper_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedPointVolumeRayCastCompositeHelper NewInstance()
	{
		vtkFixedPointVolumeRayCastCompositeHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeHelper SafeDownCast(vtkObjectBase o)
	{
		vtkFixedPointVolumeRayCastCompositeHelper vtkFixedPointVolumeRayCastCompositeHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeHelper2 = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeHelper2;
	}
}
/// <summary>
///    vtkFixedPointVolumeRayCastCompositeShadeHelper
/// </summary>
/// <remarks>
///    A helper that generates composite images for the volume ray cast mapper
///
/// This is one of the helper classes for the vtkFixedPointVolumeRayCastMapper.
/// It will generate composite images using an alpha blending operation.
/// This class should not be used directly, it is a helper class for
/// the mapper and has no user-level API.
///
/// </remarks>
/// <seealso>
///
/// vtkFixedPointVolumeRayCastMapper
/// </seealso>
public class vtkFixedPointVolumeRayCastCompositeShadeHelper : vtkFixedPointVolumeRayCastHelper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeShadeHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedPointVolumeRayCastCompositeShadeHelper()
	{
		MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeShadeHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeShadeHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeShadeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeShadeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeShadeHelper New()
	{
		vtkFixedPointVolumeRayCastCompositeShadeHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeShadeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedPointVolumeRayCastCompositeShadeHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeShadeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFixedPointVolumeRayCastCompositeShadeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
	{
		vtkFixedPointVolumeRayCastCompositeShadeHelper_GenerateImage_01(GetCppThis(), threadID, threadCount, vol?.GetCppThis() ?? default(HandleRef), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeShadeHelper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeShadeHelper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastCompositeShadeHelper_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedPointVolumeRayCastCompositeShadeHelper_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeShadeHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedPointVolumeRayCastCompositeShadeHelper NewInstance()
	{
		vtkFixedPointVolumeRayCastCompositeShadeHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeShadeHelper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeShadeHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastCompositeShadeHelper SafeDownCast(vtkObjectBase o)
	{
		vtkFixedPointVolumeRayCastCompositeShadeHelper vtkFixedPointVolumeRayCastCompositeShadeHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeShadeHelper_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper2 = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeShadeHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeShadeHelper2;
	}
}
