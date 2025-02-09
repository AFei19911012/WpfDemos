using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSVGExporter
/// </summary>
/// <remarks>
///  Exports vtkContext2D scenes to SVG.
///
/// This exporter draws context2D scenes into a SVG file.
///
/// Limitations:
/// - The Nearest/Linear texture properties are ignored, since SVG doesn't
///   provide any reliable control over interpolation.
/// - Embedded fonts are experimental and poorly tested. Viewer support is
///   lacking at the time of writing, hence the feature is largely useless. By
///   default, fonts are not embedded since they're basically useless bloat.
///   (this option is not exposed in vtkSVGExporter).
/// - TextAsPath is enabled by default, since viewers differ wildly in how they
///   handle text objects (eg. Inkscape renders at expected size, but webkit is
///   way too big).
/// - Pattern fills and markers are not shown on some viewers, e.g. KDE's okular
///   (Webkit seems to work, though).
/// - Clipping seems to be broken in most viewers. Webkit is buggy and forces the
///   clip coordinates to objectBoundingBox, even when explicitly set to
///   userSpaceOnUse.
/// - Many viewers anti-alias the output, leaving thin outlines around the
///   triangles that make up larger polygons. This is a viewer issue and there
///   not much we can do about it from the VTK side of things (and most viewers
///   don't seem to have an antialiasing toggle, either...).
///
/// If ActiveRenderer is specified then it exports contents of
/// ActiveRenderer. Otherwise it exports contents of all renderers.
/// </remarks>
public class vtkSVGExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSVGExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSVGExporter()
	{
		MRClassNameKey = "class vtkSVGExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSVGExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSVGExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSVGExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSVGExporter New()
	{
		vtkSVGExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSVGExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSVGExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSVGExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSVGExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_DrawBackgroundOff_01(HandleRef pThis);

	/// <summary>
	/// If true, the background will be drawn into the output document. Default
	/// is true.
	/// @{
	/// </summary>
	public virtual void DrawBackgroundOff()
	{
		vtkSVGExporter_DrawBackgroundOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_DrawBackgroundOn_02(HandleRef pThis);

	/// <summary>
	/// If true, the background will be drawn into the output document. Default
	/// is true.
	/// @{
	/// </summary>
	public virtual void DrawBackgroundOn()
	{
		vtkSVGExporter_DrawBackgroundOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSVGExporter_GetDescription_03(HandleRef pThis);

	/// <summary>
	/// A description of the exported document. @{ 
	/// </summary>
	public virtual string GetDescription()
	{
		return Marshal.PtrToStringAnsi(vtkSVGExporter_GetDescription_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSVGExporter_GetDrawBackground_04(HandleRef pThis);

	/// <summary>
	/// If true, the background will be drawn into the output document. Default
	/// is true.
	/// @{
	/// </summary>
	public virtual bool GetDrawBackground()
	{
		return (vtkSVGExporter_GetDrawBackground_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSVGExporter_GetFileName_05(HandleRef pThis);

	/// <summary>
	/// The name of the exported file. @{ 
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSVGExporter_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSVGExporter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSVGExporter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSVGExporter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSVGExporter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSVGExporter_GetSubdivisionThreshold_08(HandleRef pThis);

	/// <summary>
	/// Set the threshold for subdividing gradient-shaded polygons/line. Default
	/// value is 1, and lower values yield higher quality and larger files. Larger
	/// values will reduce the number of primitives, but will decrease quality.
	///
	/// A triangle / line will not be subdivided further if all of it's vertices
	/// satisfy the equation:
	///
	/// |v1 - v2|^2 &lt; thresh
	///
	/// e.g. the squared norm of the vector between any verts must be greater than
	/// the threshold for subdivision to occur.
	///
	/// @{
	/// </summary>
	public virtual float GetSubdivisionThreshold()
	{
		return vtkSVGExporter_GetSubdivisionThreshold_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSVGExporter_GetTextAsPath_09(HandleRef pThis);

	/// <summary>
	/// If true, draw all text as path objects rather than text objects. Enabling
	/// this option will:
	///
	/// - Improve portability (text will look exactly the same everywhere).
	/// - Increase file size (text objects are much more compact than paths).
	/// - Prevent text from being easily edited (text metadata is lost).
	///
	/// Note that some text (e.g. MathText) is always rendered as a path.
	///
	/// The default is true, as many browsers and SVG viewers render text
	/// inconsistently.
	///
	/// @{
	/// </summary>
	public virtual bool GetTextAsPath()
	{
		return (vtkSVGExporter_GetTextAsPath_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSVGExporter_GetTitle_10(HandleRef pThis);

	/// <summary>
	/// The title of the exported document. @{ 
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkSVGExporter_GetTitle_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSVGExporter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSVGExporter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSVGExporter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSVGExporter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSVGExporter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSVGExporter NewInstance()
	{
		vtkSVGExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSVGExporter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSVGExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSVGExporter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSVGExporter SafeDownCast(vtkObjectBase o)
	{
		vtkSVGExporter vtkSVGExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSVGExporter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSVGExporter2 = (vtkSVGExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSVGExporter2.Register(null);
			}
		}
		return vtkSVGExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_SetDescription_16(HandleRef pThis, string _arg);

	/// <summary>
	/// A description of the exported document. @{ 
	/// </summary>
	public virtual void SetDescription(string _arg)
	{
		vtkSVGExporter_SetDescription_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_SetDrawBackground_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, the background will be drawn into the output document. Default
	/// is true.
	/// @{
	/// </summary>
	public virtual void SetDrawBackground(bool _arg)
	{
		vtkSVGExporter_SetDrawBackground_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_SetFileName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the exported file. @{ 
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkSVGExporter_SetFileName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_SetSubdivisionThreshold_19(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the threshold for subdividing gradient-shaded polygons/line. Default
	/// value is 1, and lower values yield higher quality and larger files. Larger
	/// values will reduce the number of primitives, but will decrease quality.
	///
	/// A triangle / line will not be subdivided further if all of it's vertices
	/// satisfy the equation:
	///
	/// |v1 - v2|^2 &lt; thresh
	///
	/// e.g. the squared norm of the vector between any verts must be greater than
	/// the threshold for subdivision to occur.
	///
	/// @{
	/// </summary>
	public virtual void SetSubdivisionThreshold(float _arg)
	{
		vtkSVGExporter_SetSubdivisionThreshold_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_SetTextAsPath_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, draw all text as path objects rather than text objects. Enabling
	/// this option will:
	///
	/// - Improve portability (text will look exactly the same everywhere).
	/// - Increase file size (text objects are much more compact than paths).
	/// - Prevent text from being easily edited (text metadata is lost).
	///
	/// Note that some text (e.g. MathText) is always rendered as a path.
	///
	/// The default is true, as many browsers and SVG viewers render text
	/// inconsistently.
	///
	/// @{
	/// </summary>
	public virtual void SetTextAsPath(bool _arg)
	{
		vtkSVGExporter_SetTextAsPath_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_SetTitle_21(HandleRef pThis, string _arg);

	/// <summary>
	/// The title of the exported document. @{ 
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkSVGExporter_SetTitle_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_TextAsPathOff_22(HandleRef pThis);

	/// <summary>
	/// If true, draw all text as path objects rather than text objects. Enabling
	/// this option will:
	///
	/// - Improve portability (text will look exactly the same everywhere).
	/// - Increase file size (text objects are much more compact than paths).
	/// - Prevent text from being easily edited (text metadata is lost).
	///
	/// Note that some text (e.g. MathText) is always rendered as a path.
	///
	/// The default is true, as many browsers and SVG viewers render text
	/// inconsistently.
	///
	/// @{
	/// </summary>
	public virtual void TextAsPathOff()
	{
		vtkSVGExporter_TextAsPathOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSVGExporter_TextAsPathOn_23(HandleRef pThis);

	/// <summary>
	/// If true, draw all text as path objects rather than text objects. Enabling
	/// this option will:
	///
	/// - Improve portability (text will look exactly the same everywhere).
	/// - Increase file size (text objects are much more compact than paths).
	/// - Prevent text from being easily edited (text metadata is lost).
	///
	/// Note that some text (e.g. MathText) is always rendered as a path.
	///
	/// The default is true, as many browsers and SVG viewers render text
	/// inconsistently.
	///
	/// @{
	/// </summary>
	public virtual void TextAsPathOn()
	{
		vtkSVGExporter_TextAsPathOn_23(GetCppThis());
	}
}
