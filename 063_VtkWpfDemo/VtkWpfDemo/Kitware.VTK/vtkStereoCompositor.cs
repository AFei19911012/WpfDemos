using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkStereoCompositor
/// </summary>
/// <remarks>
///  helper class to generate composited stereo images.
///
/// vtkStereoCompositor is used by vtkRenderWindow to composite left and right
/// eye rendering results into a single color buffer.
///
/// Note that all methods on vtkStereoCompositor take in pointers to the left and
/// right rendering results and generate the result in the buffer passed for the
/// left eye.
/// </remarks>
public class vtkStereoCompositor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStereoCompositor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStereoCompositor()
	{
		MRClassNameKey = "class vtkStereoCompositor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStereoCompositor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStereoCompositor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStereoCompositor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStereoCompositor New()
	{
		vtkStereoCompositor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStereoCompositor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStereoCompositor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStereoCompositor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStereoCompositor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkStereoCompositor_Anaglyph_01(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, float colorSaturation, IntPtr colorMask);

	/// <summary>
	/// Methods for compositing left and right eye images based on various
	/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
	/// of these modes. Note that all these methods generate the result in the
	/// buffer passed for the left eye.
	/// </summary>
	public bool Anaglyph(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, float colorSaturation, IntPtr colorMask)
	{
		return (vtkStereoCompositor_Anaglyph_01(GetCppThis(), rgbLeftNResult?.GetCppThis() ?? default(HandleRef), rgbRight?.GetCppThis() ?? default(HandleRef), colorSaturation, colorMask) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStereoCompositor_Checkerboard_02(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

	/// <summary>
	/// Methods for compositing left and right eye images based on various
	/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
	/// of these modes. Note that all these methods generate the result in the
	/// buffer passed for the left eye.
	/// </summary>
	public bool Checkerboard(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
	{
		return (vtkStereoCompositor_Checkerboard_02(GetCppThis(), rgbLeftNResult?.GetCppThis() ?? default(HandleRef), rgbRight?.GetCppThis() ?? default(HandleRef), size) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStereoCompositor_Dresden_03(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

	/// <summary>
	/// Methods for compositing left and right eye images based on various
	/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
	/// of these modes. Note that all these methods generate the result in the
	/// buffer passed for the left eye.
	/// </summary>
	public bool Dresden(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
	{
		return (vtkStereoCompositor_Dresden_03(GetCppThis(), rgbLeftNResult?.GetCppThis() ?? default(HandleRef), rgbRight?.GetCppThis() ?? default(HandleRef), size) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStereoCompositor_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStereoCompositor_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStereoCompositor_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStereoCompositor_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStereoCompositor_Interlaced_06(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

	/// <summary>
	/// Methods for compositing left and right eye images based on various
	/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
	/// of these modes. Note that all these methods generate the result in the
	/// buffer passed for the left eye.
	/// </summary>
	public bool Interlaced(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
	{
		return (vtkStereoCompositor_Interlaced_06(GetCppThis(), rgbLeftNResult?.GetCppThis() ?? default(HandleRef), rgbRight?.GetCppThis() ?? default(HandleRef), size) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStereoCompositor_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStereoCompositor_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStereoCompositor_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStereoCompositor_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStereoCompositor_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStereoCompositor NewInstance()
	{
		vtkStereoCompositor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStereoCompositor_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStereoCompositor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStereoCompositor_RedBlue_11(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight);

	/// <summary>
	/// Methods for compositing left and right eye images based on various
	/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
	/// of these modes. Note that all these methods generate the result in the
	/// buffer passed for the left eye.
	/// </summary>
	public bool RedBlue(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight)
	{
		return (vtkStereoCompositor_RedBlue_11(GetCppThis(), rgbLeftNResult?.GetCppThis() ?? default(HandleRef), rgbRight?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStereoCompositor_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStereoCompositor SafeDownCast(vtkObjectBase o)
	{
		vtkStereoCompositor vtkStereoCompositor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStereoCompositor_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStereoCompositor2 = (vtkStereoCompositor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStereoCompositor2.Register(null);
			}
		}
		return vtkStereoCompositor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStereoCompositor_SplitViewportHorizontal_13(HandleRef pThis, HandleRef rgbLeftNResult, HandleRef rgbRight, IntPtr size);

	/// <summary>
	/// Methods for compositing left and right eye images based on various
	/// supported modes. See vtkRenderWindow::SetStereoType for explanation of each
	/// of these modes. Note that all these methods generate the result in the
	/// buffer passed for the left eye.
	/// </summary>
	public bool SplitViewportHorizontal(vtkUnsignedCharArray rgbLeftNResult, vtkUnsignedCharArray rgbRight, IntPtr size)
	{
		return (vtkStereoCompositor_SplitViewportHorizontal_13(GetCppThis(), rgbLeftNResult?.GetCppThis() ?? default(HandleRef), rgbRight?.GetCppThis() ?? default(HandleRef), size) != 0) ? true : false;
	}
}
