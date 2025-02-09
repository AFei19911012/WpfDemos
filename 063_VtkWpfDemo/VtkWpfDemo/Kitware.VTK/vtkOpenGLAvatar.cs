using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLAvatar
/// </summary>
/// <remarks>
///    OpenGL Avatar
///
/// vtkOpenGLAvatar is a concrete implementation of the abstract class vtkAvatar.
/// vtkOpenGLAvatar interfaces to the OpenGL rendering library.
/// </remarks>
public class vtkOpenGLAvatar : vtkAvatar
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLAvatar";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLAvatar()
	{
		MRClassNameKey = "class vtkOpenGLAvatar";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLAvatar"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLAvatar(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLAvatar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLAvatar New()
	{
		vtkOpenGLAvatar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLAvatar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLAvatar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLAvatar()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLAvatar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLAvatar_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkOpenGLAvatar_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLAvatar_GetLabelTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLAvatar_GetLabelTextProperty_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLAvatar_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLAvatar_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLAvatar_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLAvatar_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLAvatar_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLAvatar_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLAvatar_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLAvatar_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLAvatar_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLAvatar NewInstance()
	{
		vtkOpenGLAvatar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLAvatar_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLAvatar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLAvatar_RenderOpaqueGeometry_09(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport vp)
	{
		return vtkOpenGLAvatar_RenderOpaqueGeometry_09(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLAvatar_RenderTranslucentPolygonalGeometry_10(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
	{
		return vtkOpenGLAvatar_RenderTranslucentPolygonalGeometry_10(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLAvatar_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLAvatar SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLAvatar vtkOpenGLAvatar2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLAvatar_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLAvatar2 = (vtkOpenGLAvatar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLAvatar2.Register(null);
			}
		}
		return vtkOpenGLAvatar2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetLabel_12(HandleRef pThis, string label);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public void SetLabel(string label)
	{
		vtkOpenGLAvatar_SetLabel_12(GetCppThis(), label);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetLeftShowRay_13(HandleRef pThis, byte v);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public void SetLeftShowRay(bool v)
	{
		vtkOpenGLAvatar_SetLeftShowRay_13(GetCppThis(), (byte)(v ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetRayLength_14(HandleRef pThis, double length);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public void SetRayLength(double length)
	{
		vtkOpenGLAvatar_SetRayLength_14(GetCppThis(), length);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetRightShowRay_15(HandleRef pThis, byte v);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public void SetRightShowRay(bool v)
	{
		vtkOpenGLAvatar_SetRightShowRay_15(GetCppThis(), (byte)(v ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetShowHandsOnly_16(HandleRef pThis, byte val);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public override void SetShowHandsOnly(bool val)
	{
		vtkOpenGLAvatar_SetShowHandsOnly_16(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetUseLeftHand_17(HandleRef pThis, byte val);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public override void SetUseLeftHand(bool val)
	{
		vtkOpenGLAvatar_SetUseLeftHand_17(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLAvatar_SetUseRightHand_18(HandleRef pThis, byte val);

	/// <summary>
	/// Actual Avatar render method.
	/// </summary>
	public override void SetUseRightHand(bool val)
	{
		vtkOpenGLAvatar_SetUseRightHand_18(GetCppThis(), (byte)(val ? 1u : 0u));
	}
}
