using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTDxInteractorStyleSettings
/// </summary>
/// <remarks>
///    3DConnexion device settings
///
///
/// vtkTDxInteractorStyleSettings defines settings for 3DConnexion device such
/// as sensitivity, axis filters
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyle vtkRenderWindowInteractor
/// vtkTDxInteractorStyle
/// </seealso>
public class vtkTDxInteractorStyleSettings : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyleSettings";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTDxInteractorStyleSettings()
	{
		MRClassNameKey = "class vtkTDxInteractorStyleSettings";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyleSettings"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTDxInteractorStyleSettings(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTDxInteractorStyleSettings_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTDxInteractorStyleSettings New()
	{
		vtkTDxInteractorStyleSettings result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTDxInteractorStyleSettings_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTDxInteractorStyleSettings()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTDxInteractorStyleSettings_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkTDxInteractorStyleSettings_GetAngleSensitivity_01(HandleRef pThis);

	/// <summary>
	/// Sensitivity of the rotation angle. This can be any value:
	/// positive, negative, null.
	/// - x&lt;-1.0: faster reversed
	/// - x=-1.0: reversed neutral
	/// - -1.0&lt;x&lt;0.0:  reversed slower
	/// - x=0.0: no rotation
	/// - 0.0&lt;x&lt;1.0: slower
	/// - x=1.0: neutral
	/// - x&gt;1.0: faster
	/// </summary>
	public virtual double GetAngleSensitivity()
	{
		return vtkTDxInteractorStyleSettings_GetAngleSensitivity_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTDxInteractorStyleSettings_GetTranslationXSensitivity_04(HandleRef pThis);

	/// <summary>
	/// Sensitivity of the translation along the X-axis. This can be any value:
	/// positive, negative, null.
	/// - x&lt;-1.0: faster reversed
	/// - x=-1.0: reversed neutral
	/// - -1.0&lt;x&lt;0.0:  reversed slower
	/// - x=0.0: no translation
	/// - 0.0&lt;x&lt;1.0: slower
	/// - x=1.0: neutral
	/// - x&gt;1.0: faster
	/// Initial value is 1.0
	/// </summary>
	public virtual double GetTranslationXSensitivity()
	{
		return vtkTDxInteractorStyleSettings_GetTranslationXSensitivity_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTDxInteractorStyleSettings_GetTranslationYSensitivity_05(HandleRef pThis);

	/// <summary>
	/// Sensitivity of the translation along the Y-axis.
	/// See comment of SetTranslationXSensitivity().
	/// </summary>
	public virtual double GetTranslationYSensitivity()
	{
		return vtkTDxInteractorStyleSettings_GetTranslationYSensitivity_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTDxInteractorStyleSettings_GetTranslationZSensitivity_06(HandleRef pThis);

	/// <summary>
	/// Sensitivity of the translation along the Z-axis.
	/// See comment of SetTranslationXSensitivity().
	/// </summary>
	public virtual double GetTranslationZSensitivity()
	{
		return vtkTDxInteractorStyleSettings_GetTranslationZSensitivity_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationX_07(HandleRef pThis);

	/// <summary>
	/// Use or mask the rotation component around the X-axis. Initial value is
	/// true.
	/// </summary>
	public virtual bool GetUseRotationX()
	{
		return (vtkTDxInteractorStyleSettings_GetUseRotationX_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationY_08(HandleRef pThis);

	/// <summary>
	/// Use or mask the rotation component around the Y-axis. Initial value is
	/// true.
	/// </summary>
	public virtual bool GetUseRotationY()
	{
		return (vtkTDxInteractorStyleSettings_GetUseRotationY_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationZ_09(HandleRef pThis);

	/// <summary>
	/// Use or mask the rotation component around the Z-axis. Initial value is
	/// true.
	/// </summary>
	public virtual bool GetUseRotationZ()
	{
		return (vtkTDxInteractorStyleSettings_GetUseRotationZ_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTDxInteractorStyleSettings_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTDxInteractorStyleSettings_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTDxInteractorStyleSettings_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTDxInteractorStyleSettings_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTDxInteractorStyleSettings_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTDxInteractorStyleSettings NewInstance()
	{
		vtkTDxInteractorStyleSettings result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTDxInteractorStyleSettings_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTDxInteractorStyleSettings_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTDxInteractorStyleSettings SafeDownCast(vtkObjectBase o)
	{
		vtkTDxInteractorStyleSettings vtkTDxInteractorStyleSettings2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTDxInteractorStyleSettings_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTDxInteractorStyleSettings2 = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTDxInteractorStyleSettings2.Register(null);
			}
		}
		return vtkTDxInteractorStyleSettings2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetAngleSensitivity_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Sensitivity of the rotation angle. This can be any value:
	/// positive, negative, null.
	/// - x&lt;-1.0: faster reversed
	/// - x=-1.0: reversed neutral
	/// - -1.0&lt;x&lt;0.0:  reversed slower
	/// - x=0.0: no rotation
	/// - 0.0&lt;x&lt;1.0: slower
	/// - x=1.0: neutral
	/// - x&gt;1.0: faster
	/// </summary>
	public virtual void SetAngleSensitivity(double _arg)
	{
		vtkTDxInteractorStyleSettings_SetAngleSensitivity_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetTranslationXSensitivity_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Sensitivity of the translation along the X-axis. This can be any value:
	/// positive, negative, null.
	/// - x&lt;-1.0: faster reversed
	/// - x=-1.0: reversed neutral
	/// - -1.0&lt;x&lt;0.0:  reversed slower
	/// - x=0.0: no translation
	/// - 0.0&lt;x&lt;1.0: slower
	/// - x=1.0: neutral
	/// - x&gt;1.0: faster
	/// Initial value is 1.0
	/// </summary>
	public virtual void SetTranslationXSensitivity(double _arg)
	{
		vtkTDxInteractorStyleSettings_SetTranslationXSensitivity_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetTranslationYSensitivity_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Sensitivity of the translation along the Y-axis.
	/// See comment of SetTranslationXSensitivity().
	/// </summary>
	public virtual void SetTranslationYSensitivity(double _arg)
	{
		vtkTDxInteractorStyleSettings_SetTranslationYSensitivity_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetTranslationZSensitivity_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Sensitivity of the translation along the Z-axis.
	/// See comment of SetTranslationXSensitivity().
	/// </summary>
	public virtual void SetTranslationZSensitivity(double _arg)
	{
		vtkTDxInteractorStyleSettings_SetTranslationZSensitivity_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationX_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use or mask the rotation component around the X-axis. Initial value is
	/// true.
	/// </summary>
	public virtual void SetUseRotationX(bool _arg)
	{
		vtkTDxInteractorStyleSettings_SetUseRotationX_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationY_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use or mask the rotation component around the Y-axis. Initial value is
	/// true.
	/// </summary>
	public virtual void SetUseRotationY(bool _arg)
	{
		vtkTDxInteractorStyleSettings_SetUseRotationY_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationZ_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use or mask the rotation component around the Z-axis. Initial value is
	/// true.
	/// </summary>
	public virtual void SetUseRotationZ(bool _arg)
	{
		vtkTDxInteractorStyleSettings_SetUseRotationZ_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
