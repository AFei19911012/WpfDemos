using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositePolyDataMapper2
/// </summary>
/// <remarks>
///    mapper for composite dataset consisting
/// of polygonal data.
///
/// vtkCompositePolyDataMapper2 is similar to vtkCompositePolyDataMapper except
/// that instead of creating individual mapper for each block in the composite
/// dataset, it iterates over the blocks internally.
/// </remarks>
public class vtkCompositePolyDataMapper2 : vtkOpenGLPolyDataMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositePolyDataMapper2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositePolyDataMapper2()
	{
		MRClassNameKey = "class vtkCompositePolyDataMapper2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositePolyDataMapper2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositePolyDataMapper2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositePolyDataMapper2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositePolyDataMapper2 New()
	{
		vtkCompositePolyDataMapper2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositePolyDataMapper2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCompositePolyDataMapper2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositePolyDataMapper2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOff_01(HandleRef pThis);

	/// <summary>
	/// If the current 'color by' array is missing on some datasets, color these
	/// dataset by the LookupTable's NaN color, if the lookup table supports it.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void ColorMissingArraysWithNanColorOff()
	{
		vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOn_02(HandleRef pThis);

	/// <summary>
	/// If the current 'color by' array is missing on some datasets, color these
	/// dataset by the LookupTable's NaN color, if the lookup table supports it.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void ColorMissingArraysWithNanColorOn()
	{
		vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositePolyDataMapper2_GetBlockColor_03(HandleRef pThis, uint index);

	/// <summary>
	/// Set/get the color for a block given its flat index.
	/// </summary>
	public IntPtr GetBlockColor(uint index)
	{
		return vtkCompositePolyDataMapper2_GetBlockColor_03(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompositePolyDataMapper2_GetBlockOpacity_04(HandleRef pThis, uint index);

	/// <summary>
	/// Set/get the opacity for a block given its flat index.
	/// </summary>
	public double GetBlockOpacity(uint index)
	{
		return vtkCompositePolyDataMapper2_GetBlockOpacity_04(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositePolyDataMapper2_GetBlockVisibility_05(HandleRef pThis, uint index);

	/// <summary>
	/// Set/get the visibility for a block given its flat index.
	/// </summary>
	public bool GetBlockVisibility(uint index)
	{
		return (vtkCompositePolyDataMapper2_GetBlockVisibility_05(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositePolyDataMapper2_GetColorMissingArraysWithNanColor_06(HandleRef pThis);

	/// <summary>
	/// If the current 'color by' array is missing on some datasets, color these
	/// dataset by the LookupTable's NaN color, if the lookup table supports it.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual bool GetColorMissingArraysWithNanColor()
	{
		return (vtkCompositePolyDataMapper2_GetColorMissingArraysWithNanColor_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositePolyDataMapper2_GetCompositeDataDisplayAttributes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the composite data set attributes.
	/// </summary>
	public vtkCompositeDataDisplayAttributes GetCompositeDataDisplayAttributes()
	{
		vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositePolyDataMapper2_GetCompositeDataDisplayAttributes_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataDisplayAttributes2 = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataDisplayAttributes2.Register(null);
			}
		}
		return vtkCompositeDataDisplayAttributes2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkCompositePolyDataMapper2_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Overridden to include vtkCompositeDataDisplayAttributes' mtime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkCompositePolyDataMapper2_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositePolyDataMapper2_HasOpaqueGeometry_11(HandleRef pThis);

	/// <summary>
	/// Some introspection on the type of data the mapper will render
	/// used by props to determine if they should invoke the mapper
	/// on a specific rendering pass.
	/// </summary>
	public override bool HasOpaqueGeometry()
	{
		return (vtkCompositePolyDataMapper2_HasOpaqueGeometry_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositePolyDataMapper2_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

	/// <summary>
	/// Some introspection on the type of data the mapper will render
	/// used by props to determine if they should invoke the mapper
	/// on a specific rendering pass.
	/// </summary>
	public override bool HasTranslucentPolygonalGeometry()
	{
		return (vtkCompositePolyDataMapper2_HasTranslucentPolygonalGeometry_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositePolyDataMapper2_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositePolyDataMapper2_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositePolyDataMapper2_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositePolyDataMapper2_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositePolyDataMapper2_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositePolyDataMapper2 NewInstance()
	{
		vtkCompositePolyDataMapper2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositePolyDataMapper2_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCompositePolyDataMapper2_ReleaseGraphicsResources_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_RemoveBlockColor_18(HandleRef pThis, uint index);

	/// <summary>
	/// Set/get the color for a block given its flat index.
	/// </summary>
	public void RemoveBlockColor(uint index)
	{
		vtkCompositePolyDataMapper2_RemoveBlockColor_18(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_RemoveBlockColors_19(HandleRef pThis);

	/// <summary>
	/// Set/get the color for a block given its flat index.
	/// </summary>
	public void RemoveBlockColors()
	{
		vtkCompositePolyDataMapper2_RemoveBlockColors_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_RemoveBlockOpacities_20(HandleRef pThis);

	/// <summary>
	/// Set/get the opacity for a block given its flat index.
	/// </summary>
	public void RemoveBlockOpacities()
	{
		vtkCompositePolyDataMapper2_RemoveBlockOpacities_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_RemoveBlockOpacity_21(HandleRef pThis, uint index);

	/// <summary>
	/// Set/get the opacity for a block given its flat index.
	/// </summary>
	public void RemoveBlockOpacity(uint index)
	{
		vtkCompositePolyDataMapper2_RemoveBlockOpacity_21(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_RemoveBlockVisibilities_22(HandleRef pThis);

	/// <summary>
	/// Set/get the visibility for a block given its flat index.
	/// </summary>
	public void RemoveBlockVisibilities()
	{
		vtkCompositePolyDataMapper2_RemoveBlockVisibilities_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_RemoveBlockVisibility_23(HandleRef pThis, uint index);

	/// <summary>
	/// Set/get the visibility for a block given its flat index.
	/// </summary>
	public void RemoveBlockVisibility(uint index)
	{
		vtkCompositePolyDataMapper2_RemoveBlockVisibility_23(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_Render_24(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// This calls RenderPiece (in a for loop if streaming is necessary).
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkCompositePolyDataMapper2_Render_24(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositePolyDataMapper2_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositePolyDataMapper2 SafeDownCast(vtkObjectBase o)
	{
		vtkCompositePolyDataMapper2 vtkCompositePolyDataMapper3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositePolyDataMapper2_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositePolyDataMapper3 = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositePolyDataMapper3.Register(null);
			}
		}
		return vtkCompositePolyDataMapper3;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetBlockColor_26(HandleRef pThis, uint index, IntPtr color);

	/// <summary>
	/// Set/get the color for a block given its flat index.
	/// </summary>
	public void SetBlockColor(uint index, IntPtr color)
	{
		vtkCompositePolyDataMapper2_SetBlockColor_26(GetCppThis(), index, color);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetBlockColor_27(HandleRef pThis, uint index, double r, double g, double b);

	/// <summary>
	/// Set/get the color for a block given its flat index.
	/// </summary>
	public void SetBlockColor(uint index, double r, double g, double b)
	{
		vtkCompositePolyDataMapper2_SetBlockColor_27(GetCppThis(), index, r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetBlockOpacity_28(HandleRef pThis, uint index, double opacity);

	/// <summary>
	/// Set/get the opacity for a block given its flat index.
	/// </summary>
	public void SetBlockOpacity(uint index, double opacity)
	{
		vtkCompositePolyDataMapper2_SetBlockOpacity_28(GetCppThis(), index, opacity);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetBlockVisibility_29(HandleRef pThis, uint index, byte visible);

	/// <summary>
	/// Set/get the visibility for a block given its flat index.
	/// </summary>
	public void SetBlockVisibility(uint index, bool visible)
	{
		vtkCompositePolyDataMapper2_SetBlockVisibility_29(GetCppThis(), index, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetColorMissingArraysWithNanColor_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// If the current 'color by' array is missing on some datasets, color these
	/// dataset by the LookupTable's NaN color, if the lookup table supports it.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void SetColorMissingArraysWithNanColor(bool _arg)
	{
		vtkCompositePolyDataMapper2_SetColorMissingArraysWithNanColor_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetCompositeDataDisplayAttributes_31(HandleRef pThis, HandleRef attributes);

	/// <summary>
	/// Set/get the composite data set attributes.
	/// </summary>
	public void SetCompositeDataDisplayAttributes(vtkCompositeDataDisplayAttributes attributes)
	{
		vtkCompositePolyDataMapper2_SetCompositeDataDisplayAttributes_31(GetCppThis(), attributes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetInputArrayToProcess_32(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, string name);

	/// <summary>
	/// Call SetInputArrayToProcess on helpers.
	/// </summary>
	public override void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
	{
		vtkCompositePolyDataMapper2_SetInputArrayToProcess_32(GetCppThis(), idx, port, connection, fieldAssociation, name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetInputArrayToProcess_33(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

	/// <summary>
	/// Call SetInputArrayToProcess on helpers.
	/// </summary>
	public override void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
	{
		vtkCompositePolyDataMapper2_SetInputArrayToProcess_33(GetCppThis(), idx, port, connection, fieldAssociation, fieldAttributeType);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetInputArrayToProcess_34(HandleRef pThis, int idx, HandleRef info);

	/// <summary>
	/// Call SetInputArrayToProcess on helpers.
	/// </summary>
	public override void SetInputArrayToProcess(int idx, vtkInformation info)
	{
		vtkCompositePolyDataMapper2_SetInputArrayToProcess_34(GetCppThis(), idx, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetPauseShiftScale_35(HandleRef pThis, byte pauseShiftScale);

	/// <summary>
	///
	/// This override passes the information to all instances in \a Helpers .
	/// </summary>
	public override void SetPauseShiftScale(bool pauseShiftScale)
	{
		vtkCompositePolyDataMapper2_SetPauseShiftScale_35(GetCppThis(), (byte)(pauseShiftScale ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositePolyDataMapper2_SetVBOShiftScaleMethod_36(HandleRef pThis, int m);

	/// <summary>
	///   the VBO's shift+scale transform.
	/// </summary>
	public override void SetVBOShiftScaleMethod(int m)
	{
		vtkCompositePolyDataMapper2_SetVBOShiftScaleMethod_36(GetCppThis(), m);
	}
}
