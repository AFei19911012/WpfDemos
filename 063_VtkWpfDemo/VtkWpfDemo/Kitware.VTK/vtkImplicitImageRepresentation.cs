using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitImageRepresentation
/// </summary>
/// <remarks>
///    a representation for a vtkImplicitPlaneWidget2 which reslices a volume
///
/// This class is a specialization of the vtkImplicitPlaneRepresentation. It
/// is specialized to resample volumes across a plane. It is similar to
/// vtkImagePlaneWidget, except the combination of vtkImplicitPlaneWidget2 and
/// vtkImplicitImageRepresentation is a second generation widget design, with
/// a much simpler and intuitive plane manipulation.
///
/// See the documentation for vtkImplicitPlaneWidget2 and
/// vtkImplicitPlaneRepresentation for usage information. One notable difference
/// is that the methods PlaceImage() are preferred to the superclasses'
/// PlaceWidget() method.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitPlaneWidget2 vtkImagePlaneWidget
/// </seealso>
public class vtkImplicitImageRepresentation : vtkImplicitPlaneRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitImageRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitImageRepresentation()
	{
		MRClassNameKey = "class vtkImplicitImageRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitImageRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitImageRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitImageRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkImplicitImageRepresentation New()
	{
		vtkImplicitImageRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitImageRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkImplicitImageRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitImageRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2. Most of the required
	/// methods are implemented by this class's superclass.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkImplicitImageRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitImageRepresentation_GetColorMap_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the vtkImageMapToColors filter used by this
	/// widget.  The user can properly render other transparent actors in a
	/// scene by calling the filter's SetOutputFormatToRGB and
	/// PassAlphaToOutputOff.
	/// </summary>
	public virtual vtkImageMapToColors GetColorMap()
	{
		vtkImageMapToColors vtkImageMapToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitImageRepresentation_GetColorMap_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapToColors2 = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapToColors2.Register(null);
			}
		}
		return vtkImageMapToColors2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitImageRepresentation_GetLookupTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
	/// alternatively, to the lut of another representation or widget.  In this way,
	/// a set of three orthogonal planes can share the same lut so that
	/// window-levelling is performed uniformly among planes.  The default
	/// internal lut can be re- set/allocated by setting to nullptr.
	/// </summary>
	public virtual vtkLookupTable GetLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitImageRepresentation_GetLookupTable_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitImageRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitImageRepresentation_GetReslice_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the vtkImageReslice filter used by this
	/// widget.
	/// </summary>
	public virtual vtkImageReslice GetReslice()
	{
		vtkImageReslice vtkImageReslice2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitImageRepresentation_GetReslice_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReslice2 = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReslice2.Register(null);
			}
		}
		return vtkImageReslice2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitImageRepresentation_GetResliceInterpolate_07(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public virtual int GetResliceInterpolate()
	{
		return vtkImplicitImageRepresentation_GetResliceInterpolate_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitImageRepresentation_GetTextureInterpolate_08(HandleRef pThis);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual bool GetTextureInterpolate()
	{
		return (vtkImplicitImageRepresentation_GetTextureInterpolate_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitImageRepresentation_GetUserControlledLookupTable_09(HandleRef pThis);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method. The default is Off.
	/// </summary>
	public virtual bool GetUserControlledLookupTable()
	{
		return (vtkImplicitImageRepresentation_GetUserControlledLookupTable_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitImageRepresentation_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitImageRepresentation_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitImageRepresentation_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitImageRepresentation_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitImageRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkImplicitImageRepresentation NewInstance()
	{
		vtkImplicitImageRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitImageRepresentation_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_PlaceImage_14(HandleRef pThis, HandleRef img);

	/// <summary>
	/// Various ways to specify the vtkImageData* input for the
	/// vtkImageReslice; and perform PlaceWidget().
	/// </summary>
	public void PlaceImage(vtkImageData img)
	{
		vtkImplicitImageRepresentation_PlaceImage_14(GetCppThis(), img?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_PlaceImage_15(HandleRef pThis, HandleRef aout);

	/// <summary>
	/// Various ways to specify the vtkImageData* input for the
	/// vtkImageReslice; and perform PlaceWidget().
	/// </summary>
	public void PlaceImage(vtkAlgorithmOutput aout)
	{
		vtkImplicitImageRepresentation_PlaceImage_15(GetCppThis(), aout?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitImageRepresentation_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkImplicitImageRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitImageRepresentation vtkImplicitImageRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitImageRepresentation_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitImageRepresentation2 = (vtkImplicitImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitImageRepresentation2.Register(null);
			}
		}
		return vtkImplicitImageRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetColorMap_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Convenience method to get the vtkImageMapToColors filter used by this
	/// widget.  The user can properly render other transparent actors in a
	/// scene by calling the filter's SetOutputFormatToRGB and
	/// PassAlphaToOutputOff.
	/// </summary>
	public virtual void SetColorMap(vtkImageMapToColors arg0)
	{
		vtkImplicitImageRepresentation_SetColorMap_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetCropPlaneToBoundingBox_18(HandleRef pThis, byte arg0);

	/// <summary>
	/// This method modifies the texture pipeline in order to generate texture
	/// coordinates.
	/// </summary>
	public override void SetCropPlaneToBoundingBox(bool arg0)
	{
		vtkImplicitImageRepresentation_SetCropPlaneToBoundingBox_18(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetLookupTable_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
	/// alternatively, to the lut of another representation or widget.  In this way,
	/// a set of three orthogonal planes can share the same lut so that
	/// window-levelling is performed uniformly among planes.  The default
	/// internal lut can be re- set/allocated by setting to nullptr.
	/// </summary>
	public virtual void SetLookupTable(vtkLookupTable arg0)
	{
		vtkImplicitImageRepresentation_SetLookupTable_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolate_20(HandleRef pThis, int arg0);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolate(int arg0)
	{
		vtkImplicitImageRepresentation_SetResliceInterpolate_20(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolateToCubic_21(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolateToCubic()
	{
		vtkImplicitImageRepresentation_SetResliceInterpolateToCubic_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolateToLinear_22(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolateToLinear()
	{
		vtkImplicitImageRepresentation_SetResliceInterpolateToLinear_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetResliceInterpolateToNearestNeighbour_23(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolateToNearestNeighbour()
	{
		vtkImplicitImageRepresentation_SetResliceInterpolateToNearestNeighbour_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetTextureInterpolate_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual void SetTextureInterpolate(bool _arg)
	{
		vtkImplicitImageRepresentation_SetTextureInterpolate_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_SetUserControlledLookupTable_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method. The default is Off.
	/// </summary>
	public virtual void SetUserControlledLookupTable(bool _arg)
	{
		vtkImplicitImageRepresentation_SetUserControlledLookupTable_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_TextureInterpolateOff_26(HandleRef pThis);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual void TextureInterpolateOff()
	{
		vtkImplicitImageRepresentation_TextureInterpolateOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_TextureInterpolateOn_27(HandleRef pThis);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual void TextureInterpolateOn()
	{
		vtkImplicitImageRepresentation_TextureInterpolateOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_UserControlledLookupTableOff_28(HandleRef pThis);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method. The default is Off.
	/// </summary>
	public virtual void UserControlledLookupTableOff()
	{
		vtkImplicitImageRepresentation_UserControlledLookupTableOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitImageRepresentation_UserControlledLookupTableOn_29(HandleRef pThis);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method. The default is Off.
	/// </summary>
	public virtual void UserControlledLookupTableOn()
	{
		vtkImplicitImageRepresentation_UserControlledLookupTableOn_29(GetCppThis());
	}
}
