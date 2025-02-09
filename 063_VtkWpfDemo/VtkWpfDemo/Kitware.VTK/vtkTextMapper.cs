using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextMapper
/// </summary>
/// <remarks>
///    2D text annotation
///
/// vtkTextMapper provides 2D text annotation support for VTK.  It is a
/// vtkMapper2D that can be associated with a vtkActor2D and placed into a
/// vtkRenderer.
///
/// To use vtkTextMapper, specify an input text string.
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkTextActor vtkTextActor3D vtkTextProperty vtkTextRenderer
/// </seealso>
public class vtkTextMapper : vtkMapper2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextMapper()
	{
		MRClassNameKey = "class vtkTextMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new text mapper.
	/// </summary>
	public new static vtkTextMapper New()
	{
		vtkTextMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a new text mapper.
	/// </summary>
	public vtkTextMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTextMapper_GetHeight_01(HandleRef pThis, HandleRef v);

	/// <summary>
	/// Return the size[2]/width/height of the rectangle required to draw this
	/// mapper (in pixels).
	/// </summary>
	public virtual int GetHeight(vtkViewport v)
	{
		return vtkTextMapper_GetHeight_01(GetCppThis(), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextMapper_GetInput_02(HandleRef pThis);

	/// <summary>
	/// The input text string to the mapper.
	/// </summary>
	public virtual string GetInput()
	{
		return Marshal.PtrToStringAnsi(vtkTextMapper_GetInput_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTextMapper_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// Use these methods when setting font size relative to the renderer's size. These
	/// methods are static so that external classes (e.g., widgets) can easily use them.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTextMapper_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextMapper_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextMapper_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextMapper_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextMapper_GetSize_06(HandleRef pThis, HandleRef arg0, IntPtr size);

	/// <summary>
	/// Return the size[2]/width/height of the rectangle required to draw this
	/// mapper (in pixels).
	/// </summary>
	public virtual void GetSize(vtkViewport arg0, IntPtr size)
	{
		vtkTextMapper_GetSize_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), size);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextMapper_GetTextProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextMapper_GetTextProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextMapper_GetWidth_08(HandleRef pThis, HandleRef v);

	/// <summary>
	/// Return the size[2]/width/height of the rectangle required to draw this
	/// mapper (in pixels).
	/// </summary>
	public virtual int GetWidth(vtkViewport v)
	{
		return vtkTextMapper_GetWidth_08(GetCppThis(), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextMapper_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextMapper_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextMapper_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextMapper_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextMapper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextMapper NewInstance()
	{
		vtkTextMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextMapper_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextMapper_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Use these methods when setting font size relative to the renderer's size. These
	/// methods are static so that external classes (e.g., widgets) can easily use them.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTextMapper_ReleaseGraphicsResources_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextMapper_RenderOverlay_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Use these methods when setting font size relative to the renderer's size. These
	/// methods are static so that external classes (e.g., widgets) can easily use them.
	/// </summary>
	public override void RenderOverlay(vtkViewport arg0, vtkActor2D arg1)
	{
		vtkTextMapper_RenderOverlay_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextMapper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextMapper SafeDownCast(vtkObjectBase o)
	{
		vtkTextMapper vtkTextMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextMapper_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextMapper2 = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextMapper2.Register(null);
			}
		}
		return vtkTextMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextMapper_SetConstrainedFontSize_16(HandleRef pThis, HandleRef arg0, int targetWidth, int targetHeight);

	/// <summary>
	/// Set and return the font size (in points) required to make this mapper fit
	/// in a given
	/// target rectangle (width x height, in pixels). A static version of the method
	/// is also available for convenience to other classes (e.g., widgets).
	/// </summary>
	public virtual int SetConstrainedFontSize(vtkViewport arg0, int targetWidth, int targetHeight)
	{
		return vtkTextMapper_SetConstrainedFontSize_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), targetWidth, targetHeight);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextMapper_SetConstrainedFontSize_17(HandleRef arg0, HandleRef arg1, int targetWidth, int targetHeight);

	/// <summary>
	/// Set and return the font size (in points) required to make this mapper fit
	/// in a given
	/// target rectangle (width x height, in pixels). A static version of the method
	/// is also available for convenience to other classes (e.g., widgets).
	/// </summary>
	public static int SetConstrainedFontSize(vtkTextMapper arg0, vtkViewport arg1, int targetWidth, int targetHeight)
	{
		return vtkTextMapper_SetConstrainedFontSize_17(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), targetWidth, targetHeight);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextMapper_SetInput_18(HandleRef pThis, string _arg);

	/// <summary>
	/// The input text string to the mapper.
	/// </summary>
	public virtual void SetInput(string _arg)
	{
		vtkTextMapper_SetInput_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextMapper_SetRelativeFontSize_19(HandleRef arg0, HandleRef arg1, IntPtr winSize, IntPtr stringSize, float sizeFactor);

	/// <summary>
	/// Use these methods when setting font size relative to the renderer's size. These
	/// methods are static so that external classes (e.g., widgets) can easily use them.
	/// </summary>
	public static int SetRelativeFontSize(vtkTextMapper arg0, vtkViewport arg1, IntPtr winSize, IntPtr stringSize, float sizeFactor)
	{
		return vtkTextMapper_SetRelativeFontSize_19(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), winSize, stringSize, sizeFactor);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextMapper_SetTextProperty_20(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty p)
	{
		vtkTextMapper_SetTextProperty_20(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextMapper_ShallowCopy_21(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Shallow copy of an actor.
	/// </summary>
	public override void ShallowCopy(vtkAbstractMapper m)
	{
		vtkTextMapper_ShallowCopy_21(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}
}
