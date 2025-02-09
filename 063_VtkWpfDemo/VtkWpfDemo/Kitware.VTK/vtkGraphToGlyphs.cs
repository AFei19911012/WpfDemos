using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphToGlyphs
/// </summary>
/// <remarks>
///    create glyphs for graph vertices
///
///
/// Converts a vtkGraph to a vtkPolyData containing a glyph for each vertex.
/// This assumes that the points
/// of the graph have already been filled (perhaps by vtkGraphLayout).
/// The glyphs will automatically be scaled to be the same size in screen
/// coordinates. To do this the filter requires a pointer to the renderer
/// into which the glyphs will be rendered.
/// </remarks>
public class vtkGraphToGlyphs : vtkPolyDataAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CIRCLE_WrapperEnum
	{
		/// <summary>enum member</summary>
		CIRCLE = 7,
		/// <summary>enum member</summary>
		CROSS = 3,
		/// <summary>enum member</summary>
		DASH = 2,
		/// <summary>enum member</summary>
		DIAMOND = 8,
		/// <summary>enum member</summary>
		SPHERE = 9,
		/// <summary>enum member</summary>
		SQUARE = 6,
		/// <summary>enum member</summary>
		THICKCROSS = 4,
		/// <summary>enum member</summary>
		TRIANGLE = 5,
		/// <summary>enum member</summary>
		VERTEX = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToGlyphs";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphToGlyphs()
	{
		MRClassNameKey = "class vtkGraphToGlyphs";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToGlyphs"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphToGlyphs(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToGlyphs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphToGlyphs New()
	{
		vtkGraphToGlyphs result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToGlyphs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphToGlyphs()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphToGlyphs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGraphToGlyphs_FilledOff_01(HandleRef pThis);

	/// <summary>
	/// Whether to fill the glyph, or to just render the outline.
	/// </summary>
	public virtual void FilledOff()
	{
		vtkGraphToGlyphs_FilledOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToGlyphs_FilledOn_02(HandleRef pThis);

	/// <summary>
	/// Whether to fill the glyph, or to just render the outline.
	/// </summary>
	public virtual void FilledOn()
	{
		vtkGraphToGlyphs_FilledOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphToGlyphs_GetFilled_03(HandleRef pThis);

	/// <summary>
	/// Whether to fill the glyph, or to just render the outline.
	/// </summary>
	public virtual bool GetFilled()
	{
		return (vtkGraphToGlyphs_GetFilled_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphToGlyphs_GetGlyphType_04(HandleRef pThis);

	/// <summary>
	/// The glyph type, specified as one of the enumerated values in this
	/// class. VERTEX is a special glyph that cannot be scaled, but instead
	/// is rendered as an OpenGL vertex primitive. This may appear as a box
	/// or circle depending on the hardware.
	/// </summary>
	public virtual int GetGlyphType()
	{
		return vtkGraphToGlyphs_GetGlyphType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGraphToGlyphs_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// The modified time of this filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGraphToGlyphs_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphToGlyphs_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphToGlyphs_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphToGlyphs_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphToGlyphs_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToGlyphs_GetRenderer_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The renderer in which the glyphs will be placed.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToGlyphs_GetRenderer_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphToGlyphs_GetScaling_09(HandleRef pThis);

	/// <summary>
	/// Whether to use the input array to process in order to scale the
	/// vertices.
	/// </summary>
	public virtual bool GetScaling()
	{
		return (vtkGraphToGlyphs_GetScaling_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphToGlyphs_GetScreenSize_10(HandleRef pThis);

	/// <summary>
	/// Set the desired screen size of each glyph. If you are using scaling,
	/// this will be the size of the glyph when rendering an object with
	/// scaling value 1.0.
	/// </summary>
	public virtual double GetScreenSize()
	{
		return vtkGraphToGlyphs_GetScreenSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphToGlyphs_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphToGlyphs_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphToGlyphs_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphToGlyphs_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToGlyphs_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphToGlyphs NewInstance()
	{
		vtkGraphToGlyphs result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToGlyphs_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphToGlyphs_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphToGlyphs SafeDownCast(vtkObjectBase o)
	{
		vtkGraphToGlyphs vtkGraphToGlyphs2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphToGlyphs_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphToGlyphs2 = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphToGlyphs2.Register(null);
			}
		}
		return vtkGraphToGlyphs2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToGlyphs_SetFilled_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to fill the glyph, or to just render the outline.
	/// </summary>
	public virtual void SetFilled(bool _arg)
	{
		vtkGraphToGlyphs_SetFilled_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToGlyphs_SetGlyphType_17(HandleRef pThis, int _arg);

	/// <summary>
	/// The glyph type, specified as one of the enumerated values in this
	/// class. VERTEX is a special glyph that cannot be scaled, but instead
	/// is rendered as an OpenGL vertex primitive. This may appear as a box
	/// or circle depending on the hardware.
	/// </summary>
	public virtual void SetGlyphType(int _arg)
	{
		vtkGraphToGlyphs_SetGlyphType_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToGlyphs_SetRenderer_18(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// The renderer in which the glyphs will be placed.
	/// </summary>
	public virtual void SetRenderer(vtkRenderer ren)
	{
		vtkGraphToGlyphs_SetRenderer_18(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToGlyphs_SetScaling_19(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to use the input array to process in order to scale the
	/// vertices.
	/// </summary>
	public virtual void SetScaling(bool b)
	{
		vtkGraphToGlyphs_SetScaling_19(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphToGlyphs_SetScreenSize_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the desired screen size of each glyph. If you are using scaling,
	/// this will be the size of the glyph when rendering an object with
	/// scaling value 1.0.
	/// </summary>
	public virtual void SetScreenSize(double _arg)
	{
		vtkGraphToGlyphs_SetScreenSize_20(GetCppThis(), _arg);
	}
}
