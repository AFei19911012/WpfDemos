using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkButtonSource
/// </summary>
/// <remarks>
///    abstract class for creating various button types
///
/// vtkButtonSource is an abstract class that defines an API for creating
/// "button-like" objects in VTK. A button is a geometry with a rectangular
/// region that can be textured. The button is divided into two regions: the
/// texture region and the shoulder region. The points in both regions are
/// assigned texture coordinates. The texture region has texture coordinates
/// consistent with the image to be placed on it.  All points in the shoulder
/// regions are assigned a texture coordinate specified by the user.  In this
/// way the shoulder region can be colored by the texture.
///
/// Creating a vtkButtonSource requires specifying its center point.
/// (Subclasses have other attributes that must be set to control
/// the shape of the button.) You must also specify how to control
/// the shape of the texture region; i.e., whether to size the
/// texture region proportional to the texture dimensions or whether
/// to size the texture region proportional to the button. Also, buttons
/// can be created single sided are mirrored to create two-sided buttons.
///
/// </remarks>
/// <seealso>
///
/// vtkEllipticalButtonSource vtkRectangularButtonSource
///
/// @warning
/// The button is defined in the x-y plane. Use vtkTransformPolyDataFilter
/// or vtkGlyph3D to orient the button in a different direction.
/// </seealso>
public class vtkButtonSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkButtonSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkButtonSource()
	{
		MRClassNameKey = "class vtkButtonSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the origin (center) of the button.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkButtonSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_GetCenter_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the origin (center) of the button.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkButtonSource_GetCenter_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkButtonSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkButtonSource_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkButtonSource_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkButtonSource_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonSource_GetShoulderTextureCoordinate_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the default texture coordinate to set the shoulder region to.
	/// </summary>
	public virtual double[] GetShoulderTextureCoordinate()
	{
		IntPtr intPtr = vtkButtonSource_GetShoulderTextureCoordinate_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_GetShoulderTextureCoordinate_06(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the default texture coordinate to set the shoulder region to.
	/// </summary>
	public virtual void GetShoulderTextureCoordinate(ref double _arg1, ref double _arg2)
	{
		vtkButtonSource_GetShoulderTextureCoordinate_06(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_GetShoulderTextureCoordinate_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the default texture coordinate to set the shoulder region to.
	/// </summary>
	public virtual void GetShoulderTextureCoordinate(IntPtr _arg)
	{
		vtkButtonSource_GetShoulderTextureCoordinate_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonSource_GetTextureDimensions_08(HandleRef pThis);

	/// <summary>
	/// Set/get the texture dimension. This needs to be set if the texture
	/// style is set to fit the image.
	/// </summary>
	public virtual int[] GetTextureDimensions()
	{
		IntPtr intPtr = vtkButtonSource_GetTextureDimensions_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_GetTextureDimensions_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the texture dimension. This needs to be set if the texture
	/// style is set to fit the image.
	/// </summary>
	public virtual void GetTextureDimensions(ref int _arg1, ref int _arg2)
	{
		vtkButtonSource_GetTextureDimensions_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_GetTextureDimensions_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the texture dimension. This needs to be set if the texture
	/// style is set to fit the image.
	/// </summary>
	public virtual void GetTextureDimensions(IntPtr _arg)
	{
		vtkButtonSource_GetTextureDimensions_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonSource_GetTextureStyle_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the style of the texture region: whether to size it
	/// according to the x-y dimensions of the texture, or whether to make
	/// the texture region proportional to the width/height of the button.
	/// </summary>
	public virtual int GetTextureStyle()
	{
		return vtkButtonSource_GetTextureStyle_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonSource_GetTextureStyleMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the style of the texture region: whether to size it
	/// according to the x-y dimensions of the texture, or whether to make
	/// the texture region proportional to the width/height of the button.
	/// </summary>
	public virtual int GetTextureStyleMaxValue()
	{
		return vtkButtonSource_GetTextureStyleMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonSource_GetTextureStyleMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the style of the texture region: whether to size it
	/// according to the x-y dimensions of the texture, or whether to make
	/// the texture region proportional to the width/height of the button.
	/// </summary>
	public virtual int GetTextureStyleMinValue()
	{
		return vtkButtonSource_GetTextureStyleMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonSource_GetTwoSided_14(HandleRef pThis);

	/// <summary>
	/// Indicate whether the button is single or double sided. A double sided
	/// button can be viewed from two sides...it looks sort of like a "pill."
	/// A single-sided button is meant to viewed from a single side; it looks
	/// like a "clam-shell."
	/// </summary>
	public virtual int GetTwoSided()
	{
		return vtkButtonSource_GetTwoSided_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonSource_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkButtonSource_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonSource_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkButtonSource_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkButtonSource NewInstance()
	{
		vtkButtonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButtonSource_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkButtonSource SafeDownCast(vtkObjectBase o)
	{
		vtkButtonSource vtkButtonSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButtonSource_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkButtonSource2 = (vtkButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkButtonSource2.Register(null);
			}
		}
		return vtkButtonSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point defining the origin (center) of the button.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkButtonSource_SetCenter_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetCenter_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point defining the origin (center) of the button.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkButtonSource_SetCenter_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetShoulderTextureCoordinate_21(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/Get the default texture coordinate to set the shoulder region to.
	/// </summary>
	public virtual void SetShoulderTextureCoordinate(double _arg1, double _arg2)
	{
		vtkButtonSource_SetShoulderTextureCoordinate_21(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetShoulderTextureCoordinate_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the default texture coordinate to set the shoulder region to.
	/// </summary>
	public void SetShoulderTextureCoordinate(IntPtr _arg)
	{
		vtkButtonSource_SetShoulderTextureCoordinate_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetTextureDimensions_23(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the texture dimension. This needs to be set if the texture
	/// style is set to fit the image.
	/// </summary>
	public virtual void SetTextureDimensions(int _arg1, int _arg2)
	{
		vtkButtonSource_SetTextureDimensions_23(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetTextureDimensions_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the texture dimension. This needs to be set if the texture
	/// style is set to fit the image.
	/// </summary>
	public void SetTextureDimensions(IntPtr _arg)
	{
		vtkButtonSource_SetTextureDimensions_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetTextureStyle_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the style of the texture region: whether to size it
	/// according to the x-y dimensions of the texture, or whether to make
	/// the texture region proportional to the width/height of the button.
	/// </summary>
	public virtual void SetTextureStyle(int _arg)
	{
		vtkButtonSource_SetTextureStyle_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetTextureStyleToFitImage_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the style of the texture region: whether to size it
	/// according to the x-y dimensions of the texture, or whether to make
	/// the texture region proportional to the width/height of the button.
	/// </summary>
	public void SetTextureStyleToFitImage()
	{
		vtkButtonSource_SetTextureStyleToFitImage_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetTextureStyleToProportional_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the style of the texture region: whether to size it
	/// according to the x-y dimensions of the texture, or whether to make
	/// the texture region proportional to the width/height of the button.
	/// </summary>
	public void SetTextureStyleToProportional()
	{
		vtkButtonSource_SetTextureStyleToProportional_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_SetTwoSided_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the button is single or double sided. A double sided
	/// button can be viewed from two sides...it looks sort of like a "pill."
	/// A single-sided button is meant to viewed from a single side; it looks
	/// like a "clam-shell."
	/// </summary>
	public virtual void SetTwoSided(int _arg)
	{
		vtkButtonSource_SetTwoSided_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_TwoSidedOff_29(HandleRef pThis);

	/// <summary>
	/// Indicate whether the button is single or double sided. A double sided
	/// button can be viewed from two sides...it looks sort of like a "pill."
	/// A single-sided button is meant to viewed from a single side; it looks
	/// like a "clam-shell."
	/// </summary>
	public virtual void TwoSidedOff()
	{
		vtkButtonSource_TwoSidedOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonSource_TwoSidedOn_30(HandleRef pThis);

	/// <summary>
	/// Indicate whether the button is single or double sided. A double sided
	/// button can be viewed from two sides...it looks sort of like a "pill."
	/// A single-sided button is meant to viewed from a single side; it looks
	/// like a "clam-shell."
	/// </summary>
	public virtual void TwoSidedOn()
	{
		vtkButtonSource_TwoSidedOn_30(GetCppThis());
	}
}
