using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphMapper
/// </summary>
/// <remarks>
///    map vtkGraph and derived
/// classes to graphics primitives
///
///
/// vtkGraphMapper is a mapper to map vtkGraph
/// (and all derived classes) to graphics primitives.
/// </remarks>
public class vtkGraphMapper : vtkMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphMapper()
	{
		MRClassNameKey = "class vtkGraphMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphMapper New()
	{
		vtkGraphMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGraphMapper_AddIconType_01(HandleRef pThis, string type, int index);

	/// <summary>
	/// Associate the icon at index "index" in the vtkTexture to all vertices
	/// containing "type" as a value in the vertex attribute array specified by
	/// IconArrayName.
	/// </summary>
	public void AddIconType(string type, int index)
	{
		vtkGraphMapper_AddIconType_01(GetCppThis(), type, index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ClearIconTypes_02(HandleRef pThis);

	/// <summary>
	/// Clear all icon mappings.
	/// </summary>
	public void ClearIconTypes()
	{
		vtkGraphMapper_ClearIconTypes_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ColorEdgesOff_03(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public void ColorEdgesOff()
	{
		vtkGraphMapper_ColorEdgesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ColorEdgesOn_04(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public void ColorEdgesOn()
	{
		vtkGraphMapper_ColorEdgesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ColorVerticesOff_05(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public void ColorVerticesOff()
	{
		vtkGraphMapper_ColorVerticesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ColorVerticesOn_06(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public void ColorVerticesOn()
	{
		vtkGraphMapper_ColorVerticesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_EdgeVisibilityOff_07(HandleRef pThis);

	/// <summary>
	/// Whether to show edges or not.  Default is on.
	/// </summary>
	public virtual void EdgeVisibilityOff()
	{
		vtkGraphMapper_EdgeVisibilityOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_EdgeVisibilityOn_08(HandleRef pThis);

	/// <summary>
	/// Whether to show edges or not.  Default is on.
	/// </summary>
	public virtual void EdgeVisibilityOn()
	{
		vtkGraphMapper_EdgeVisibilityOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_EnableEdgesByArrayOff_09(HandleRef pThis);

	/// <summary>
	/// Whether to enable/disable edges using array values.  Default is off.
	/// </summary>
	public virtual void EnableEdgesByArrayOff()
	{
		vtkGraphMapper_EnableEdgesByArrayOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_EnableEdgesByArrayOn_10(HandleRef pThis);

	/// <summary>
	/// Whether to enable/disable edges using array values.  Default is off.
	/// </summary>
	public virtual void EnableEdgesByArrayOn()
	{
		vtkGraphMapper_EnableEdgesByArrayOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_EnableVerticesByArrayOff_11(HandleRef pThis);

	/// <summary>
	/// Whether to enable/disable vertices using array values.  Default is off.
	/// </summary>
	public virtual void EnableVerticesByArrayOff()
	{
		vtkGraphMapper_EnableVerticesByArrayOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_EnableVerticesByArrayOn_12(HandleRef pThis);

	/// <summary>
	/// Whether to enable/disable vertices using array values.  Default is off.
	/// </summary>
	public virtual void EnableVerticesByArrayOn()
	{
		vtkGraphMapper_EnableVerticesByArrayOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetBounds_13(HandleRef pThis);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkGraphMapper_GetBounds_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_GetBounds_14(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkGraphMapper_GetBounds_14(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphMapper_GetColorEdges_15(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public bool GetColorEdges()
	{
		return (vtkGraphMapper_GetColorEdges_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphMapper_GetColorVertices_16(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public bool GetColorVertices()
	{
		return (vtkGraphMapper_GetColorVertices_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetEdgeColorArrayName_17(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public string GetEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphMapper_GetEdgeColorArrayName_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGraphMapper_GetEdgeLineWidth_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the edge line width
	/// </summary>
	public virtual float GetEdgeLineWidth()
	{
		return vtkGraphMapper_GetEdgeLineWidth_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetEdgeLookupTable_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access to the lookup tables used by the vertex and edge mappers.
	/// </summary>
	public virtual vtkLookupTable GetEdgeLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_GetEdgeLookupTable_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphMapper_GetEdgeVisibility_20(HandleRef pThis);

	/// <summary>
	/// Whether to show edges or not.  Default is on.
	/// </summary>
	public bool GetEdgeVisibility()
	{
		return (vtkGraphMapper_GetEdgeVisibility_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphMapper_GetEnableEdgesByArray_21(HandleRef pThis);

	/// <summary>
	/// Whether to enable/disable edges using array values.  Default is off.
	/// </summary>
	public virtual int GetEnableEdgesByArray()
	{
		return vtkGraphMapper_GetEnableEdgesByArray_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphMapper_GetEnableVerticesByArray_22(HandleRef pThis);

	/// <summary>
	/// Whether to enable/disable vertices using array values.  Default is off.
	/// </summary>
	public virtual int GetEnableVerticesByArray()
	{
		return vtkGraphMapper_GetEnableVerticesByArray_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetEnabledEdgesArrayName_23(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual string GetEnabledEdgesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphMapper_GetEnabledEdgesArrayName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetEnabledVerticesArrayName_24(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual string GetEnabledVerticesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphMapper_GetEnabledVerticesArrayName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetIconArrayName_25(HandleRef pThis);

	/// <summary>
	/// The array to use for assigning icons.
	/// </summary>
	public string GetIconArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphMapper_GetIconArrayName_25(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetIconSize_26(HandleRef pThis);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public IntPtr GetIconSize()
	{
		return vtkGraphMapper_GetIconSize_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetIconTexture_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The texture containing the icon sheet.
	/// </summary>
	public vtkTexture GetIconTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_GetIconTexture_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphMapper_GetIconVisibility_28(HandleRef pThis);

	/// <summary>
	/// Whether to show icons.  Default is off.
	/// </summary>
	public bool GetIconVisibility()
	{
		return (vtkGraphMapper_GetIconVisibility_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetInput_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the Input of this mapper.
	/// </summary>
	public new vtkGraph GetInput()
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_GetInput_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGraphMapper_GetMTime_30(HandleRef pThis);

	/// <summary>
	/// Get the mtime also considering the lookup table.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGraphMapper_GetMTime_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphMapper_GetNumberOfGenerationsFromBase_31(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphMapper_GetNumberOfGenerationsFromBase_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphMapper_GetNumberOfGenerationsFromBaseType_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphMapper_GetNumberOfGenerationsFromBaseType_32(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphMapper_GetScaledGlyphs_33(HandleRef pThis);

	/// <summary>
	/// Whether scaled glyphs are on or not.  Default is off.
	/// By default this mapper uses vertex glyphs that do not
	/// scale. If you turn this option on you will get circles
	/// at each vertex and they will scale as you zoom in/out.
	/// </summary>
	public virtual bool GetScaledGlyphs()
	{
		return (vtkGraphMapper_GetScaledGlyphs_33(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetScalingArrayName_34(HandleRef pThis);

	/// <summary>
	/// Glyph scaling array name. Default is "scale"
	/// </summary>
	public virtual string GetScalingArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphMapper_GetScalingArrayName_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetVertexColorArrayName_35(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring vertices.  Default is "color".
	/// </summary>
	public string GetVertexColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphMapper_GetVertexColorArrayName_35(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_GetVertexLookupTable_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access to the lookup tables used by the vertex and edge mappers.
	/// </summary>
	public virtual vtkLookupTable GetVertexLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_GetVertexLookupTable_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGraphMapper_GetVertexPointSize_37(HandleRef pThis);

	/// <summary>
	/// Get/Set the vertex point size
	/// </summary>
	public virtual float GetVertexPointSize()
	{
		return vtkGraphMapper_GetVertexPointSize_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_IconVisibilityOff_38(HandleRef pThis);

	/// <summary>
	/// Whether to show icons.  Default is off.
	/// </summary>
	public virtual void IconVisibilityOff()
	{
		vtkGraphMapper_IconVisibilityOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_IconVisibilityOn_39(HandleRef pThis);

	/// <summary>
	/// Whether to show icons.  Default is off.
	/// </summary>
	public virtual void IconVisibilityOn()
	{
		vtkGraphMapper_IconVisibilityOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphMapper_IsA_40(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphMapper_IsA_40(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphMapper_IsTypeOf_41(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphMapper_IsTypeOf_41(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_NewInstance_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphMapper NewInstance()
	{
		vtkGraphMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_NewInstance_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkGraphMapper_ReleaseGraphicsResources_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_Render_45(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkGraphMapper_Render_45(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphMapper_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphMapper SafeDownCast(vtkObjectBase o)
	{
		vtkGraphMapper vtkGraphMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphMapper_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphMapper2 = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphMapper2.Register(null);
			}
		}
		return vtkGraphMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ScaledGlyphsOff_47(HandleRef pThis);

	/// <summary>
	/// Whether scaled glyphs are on or not.  Default is off.
	/// By default this mapper uses vertex glyphs that do not
	/// scale. If you turn this option on you will get circles
	/// at each vertex and they will scale as you zoom in/out.
	/// </summary>
	public virtual void ScaledGlyphsOff()
	{
		vtkGraphMapper_ScaledGlyphsOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_ScaledGlyphsOn_48(HandleRef pThis);

	/// <summary>
	/// Whether scaled glyphs are on or not.  Default is off.
	/// By default this mapper uses vertex glyphs that do not
	/// scale. If you turn this option on you will get circles
	/// at each vertex and they will scale as you zoom in/out.
	/// </summary>
	public virtual void ScaledGlyphsOn()
	{
		vtkGraphMapper_ScaledGlyphsOn_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetColorEdges_49(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public void SetColorEdges(bool vis)
	{
		vtkGraphMapper_SetColorEdges_49(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetColorVertices_50(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public void SetColorVertices(bool vis)
	{
		vtkGraphMapper_SetColorVertices_50(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEdgeColorArrayName_51(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public void SetEdgeColorArrayName(string name)
	{
		vtkGraphMapper_SetEdgeColorArrayName_51(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEdgeLineWidth_52(HandleRef pThis, float width);

	/// <summary>
	/// Get/Set the edge line width
	/// </summary>
	public void SetEdgeLineWidth(float width)
	{
		vtkGraphMapper_SetEdgeLineWidth_52(GetCppThis(), width);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEdgeVisibility_53(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show edges or not.  Default is on.
	/// </summary>
	public void SetEdgeVisibility(bool vis)
	{
		vtkGraphMapper_SetEdgeVisibility_53(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEnableEdgesByArray_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Whether to enable/disable edges using array values.  Default is off.
	/// </summary>
	public virtual void SetEnableEdgesByArray(int _arg)
	{
		vtkGraphMapper_SetEnableEdgesByArray_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEnableVerticesByArray_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Whether to enable/disable vertices using array values.  Default is off.
	/// </summary>
	public virtual void SetEnableVerticesByArray(int _arg)
	{
		vtkGraphMapper_SetEnableVerticesByArray_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEnabledEdgesArrayName_56(HandleRef pThis, string _arg);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual void SetEnabledEdgesArrayName(string _arg)
	{
		vtkGraphMapper_SetEnabledEdgesArrayName_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetEnabledVerticesArrayName_57(HandleRef pThis, string _arg);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public virtual void SetEnabledVerticesArrayName(string _arg)
	{
		vtkGraphMapper_SetEnabledVerticesArrayName_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetIconAlignment_58(HandleRef pThis, int alignment);

	/// <summary>
	/// Specify where the icons should be placed in relation to the vertex.
	/// See vtkIconGlyphFilter.h for possible values.
	/// </summary>
	public void SetIconAlignment(int alignment)
	{
		vtkGraphMapper_SetIconAlignment_58(GetCppThis(), alignment);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetIconArrayName_59(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for assigning icons.
	/// </summary>
	public void SetIconArrayName(string name)
	{
		vtkGraphMapper_SetIconArrayName_59(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetIconSize_60(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public void SetIconSize(IntPtr size)
	{
		vtkGraphMapper_SetIconSize_60(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetIconTexture_61(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// The texture containing the icon sheet.
	/// </summary>
	public void SetIconTexture(vtkTexture texture)
	{
		vtkGraphMapper_SetIconTexture_61(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetIconVisibility_62(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show icons.  Default is off.
	/// </summary>
	public void SetIconVisibility(bool vis)
	{
		vtkGraphMapper_SetIconVisibility_62(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetInputData_63(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the Input of this mapper.
	/// </summary>
	public void SetInputData(vtkGraph input)
	{
		vtkGraphMapper_SetInputData_63(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetScaledGlyphs_64(HandleRef pThis, byte arg);

	/// <summary>
	/// Whether scaled glyphs are on or not.  Default is off.
	/// By default this mapper uses vertex glyphs that do not
	/// scale. If you turn this option on you will get circles
	/// at each vertex and they will scale as you zoom in/out.
	/// </summary>
	public void SetScaledGlyphs(bool arg)
	{
		vtkGraphMapper_SetScaledGlyphs_64(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetScalingArrayName_65(HandleRef pThis, string _arg);

	/// <summary>
	/// Glyph scaling array name. Default is "scale"
	/// </summary>
	public virtual void SetScalingArrayName(string _arg)
	{
		vtkGraphMapper_SetScalingArrayName_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetVertexColorArrayName_66(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring vertices.  Default is "color".
	/// </summary>
	public void SetVertexColorArrayName(string name)
	{
		vtkGraphMapper_SetVertexColorArrayName_66(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphMapper_SetVertexPointSize_67(HandleRef pThis, float size);

	/// <summary>
	/// Get/Set the vertex point size
	/// </summary>
	public void SetVertexPointSize(float size)
	{
		vtkGraphMapper_SetVertexPointSize_67(GetCppThis(), size);
	}
}
