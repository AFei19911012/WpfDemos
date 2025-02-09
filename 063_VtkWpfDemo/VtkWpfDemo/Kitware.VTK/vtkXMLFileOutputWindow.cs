using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLFileOutputWindow
/// </summary>
/// <remarks>
///    XML File Specific output window class
///
/// Writes debug/warning/error output to an XML file. Uses prefined XML
/// tags for each text display method. The text is processed to replace
/// XML markup characters.
///
///   DisplayText - \&lt;Text\&gt;
///
///   DisplayErrorText - \&lt;Error\&gt;
///
///   DisplayWarningText - \&lt;Warning\&gt;
///
///   DisplayGenericWarningText - \&lt;GenericWarning\&gt;
///
///   DisplayDebugText - \&lt;Debug\&gt;
///
/// The method DisplayTag outputs the text unprocessed. To use this
/// class, instantiate it and then call SetInstance(this).
/// </remarks>
public class vtkXMLFileOutputWindow : vtkFileOutputWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLFileOutputWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLFileOutputWindow()
	{
		MRClassNameKey = "class vtkXMLFileOutputWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLFileOutputWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLFileOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLFileOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLFileOutputWindow New()
	{
		vtkXMLFileOutputWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLFileOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLFileOutputWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLFileOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLFileOutputWindow_DisplayDebugText_01(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file. The text is processed to
	/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
	/// Each display method outputs a different XML tag.
	/// </summary>
	public override void DisplayDebugText(string arg0)
	{
		vtkXMLFileOutputWindow_DisplayDebugText_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLFileOutputWindow_DisplayErrorText_02(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file. The text is processed to
	/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
	/// Each display method outputs a different XML tag.
	/// </summary>
	public override void DisplayErrorText(string arg0)
	{
		vtkXMLFileOutputWindow_DisplayErrorText_02(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLFileOutputWindow_DisplayGenericWarningText_03(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file. The text is processed to
	/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
	/// Each display method outputs a different XML tag.
	/// </summary>
	public override void DisplayGenericWarningText(string arg0)
	{
		vtkXMLFileOutputWindow_DisplayGenericWarningText_03(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLFileOutputWindow_DisplayTag_04(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file without processing it.
	/// </summary>
	public virtual void DisplayTag(string arg0)
	{
		vtkXMLFileOutputWindow_DisplayTag_04(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLFileOutputWindow_DisplayText_05(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file. The text is processed to
	/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
	/// Each display method outputs a different XML tag.
	/// </summary>
	public override void DisplayText(string arg0)
	{
		vtkXMLFileOutputWindow_DisplayText_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLFileOutputWindow_DisplayWarningText_06(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file. The text is processed to
	/// replace &amp;, &lt;, &gt; with &amp;amp, &amp;lt, and &amp;gt.
	/// Each display method outputs a different XML tag.
	/// </summary>
	public override void DisplayWarningText(string arg0)
	{
		vtkXMLFileOutputWindow_DisplayWarningText_06(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLFileOutputWindow_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLFileOutputWindow_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLFileOutputWindow_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLFileOutputWindow_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLFileOutputWindow_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLFileOutputWindow_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLFileOutputWindow NewInstance()
	{
		vtkXMLFileOutputWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLFileOutputWindow_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLFileOutputWindow_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLFileOutputWindow SafeDownCast(vtkObjectBase o)
	{
		vtkXMLFileOutputWindow vtkXMLFileOutputWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLFileOutputWindow_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLFileOutputWindow2 = (vtkXMLFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLFileOutputWindow2.Register(null);
			}
		}
		return vtkXMLFileOutputWindow2;
	}
}
