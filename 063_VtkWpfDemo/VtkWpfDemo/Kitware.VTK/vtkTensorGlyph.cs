using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTensorGlyph
/// </summary>
/// <remarks>
///    scale and orient glyph(s) according to eigenvalues and eigenvectors of symmetrical part
/// of tensor
///
/// vtkTensorGlyph is a filter that copies a geometric representation
/// (specified as polygonal data) to every input point. The geometric
/// representation, or glyph, can be scaled and/or rotated according to
/// the tensor at the input point. Scaling and rotation is controlled
/// by the eigenvalues/eigenvectors of the symmetrical part of the tensor
/// as follows:
/// For each tensor, the eigenvalues (and associated eigenvectors) are sorted
/// to determine the major, medium, and minor eigenvalues/eigenvectors.
/// The eigenvalue decomposition only makes sense for symmetric tensors,
/// hence the need to only consider the symmetric part of the tensor, which is
/// 1/2 (T + T.transposed()).
///
/// If the boolean variable ThreeGlyphs is not set the major eigenvalue
/// scales the glyph in the x-direction, the medium in the y-direction,
/// and the minor in the z-direction. Then, the glyph is rotated so
/// that the glyph's local x-axis lies along the major eigenvector,
/// y-axis along the medium eigenvector, and z-axis along the minor.
///
/// If the boolean variable ThreeGlyphs is set three glyphs are produced,
/// each of them oriented along an eigenvector and scaled according to the
/// corresponding eigenvector.
///
/// If the boolean variable Symmetric is set each glyph is mirrored (2 or 6
/// glyphs will be produced)
///
/// The x-axis of the source glyph will correspond to the eigenvector
/// on output. Point (0,0,0) in the source will be placed in the data point.
/// Variable Length will normally correspond to the distance from the
/// origin to the tip of the source glyph along the x-axis,
/// but can be changed to produce other results when Symmetric is on,
/// e.g. glyphs that do not touch or that overlap.
///
/// Please note that when Symmetric is false it will generally be better
/// to place the source glyph from (-0.5,0,0) to (0.5,0,0), i.e. centered
/// at the origin. When symmetric is true the placement from (0,0,0) to
/// (1,0,0) will generally be more convenient.
///
/// A scale factor is provided to control the amount of scaling. Also, you
/// can turn off scaling completely if desired. The boolean variable
/// ClampScaling controls the maximum scaling (in conjunction with
/// MaxScaleFactor.) This is useful in certain applications where
/// singularities or large order of magnitude differences exist in
/// the eigenvalues.
///
/// If the boolean variable ColorGlyphs is set to true the glyphs are
/// colored.  The glyphs can be colored using the input scalars
/// (SetColorModeToScalars), which is the default, or colored using the
/// eigenvalues (SetColorModeToEigenvalues).
///
/// Another instance variable, ExtractEigenvalues, has been provided to
/// control extraction of eigenvalues/eigenvectors. If this boolean is
/// false, then eigenvalues/eigenvectors are not extracted, and the
/// columns of the tensor are taken as the eigenvectors (the norm of
/// column, always positive, is the eigenvalue).  This allows
/// additional capability over the vtkGlyph3D object. That is, the
/// glyph can be oriented in three directions instead of one.
///
/// @par Thanks:
/// Thanks to Jose Paulo Moitinho de Almeida for enhancements.
///
/// </remarks>
/// <seealso>
///
/// vtkGlyph3D vtkPointLoad vtkHyperStreamline
/// </seealso>
public class vtkTensorGlyph : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Turn on/off coloring of glyph with input scalar data or
	/// eigenvalues. If false, or input scalar data not present, then the
	/// scalars from the source object are passed through the filter.
	/// </summary>
	public enum COLOR_BY_EIGENVALUES_WrapperEnum
	{
		/// <summary>enum member</summary>
		COLOR_BY_EIGENVALUES = 1,
		/// <summary>enum member</summary>
		COLOR_BY_SCALARS = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTensorGlyph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTensorGlyph()
	{
		MRClassNameKey = "class vtkTensorGlyph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorGlyph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTensorGlyph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorGlyph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public new static vtkTensorGlyph New()
	{
		vtkTensorGlyph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorGlyph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public vtkTensorGlyph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTensorGlyph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ClampScalingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
	/// MaxScaleFactor is used to control the maximum scale factor. (This is
	/// useful to prevent uncontrolled scaling near singularities.)
	/// </summary>
	public virtual void ClampScalingOff()
	{
		vtkTensorGlyph_ClampScalingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ClampScalingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
	/// MaxScaleFactor is used to control the maximum scale factor. (This is
	/// useful to prevent uncontrolled scaling near singularities.)
	/// </summary>
	public virtual void ClampScalingOn()
	{
		vtkTensorGlyph_ClampScalingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ColorGlyphsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off coloring of glyph with input scalar data or
	/// eigenvalues. If false, or input scalar data not present, then the
	/// scalars from the source object are passed through the filter.
	/// </summary>
	public virtual void ColorGlyphsOff()
	{
		vtkTensorGlyph_ColorGlyphsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ColorGlyphsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off coloring of glyph with input scalar data or
	/// eigenvalues. If false, or input scalar data not present, then the
	/// scalars from the source object are passed through the filter.
	/// </summary>
	public virtual void ColorGlyphsOn()
	{
		vtkTensorGlyph_ColorGlyphsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ExtractEigenvaluesOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off extraction of eigenvalues from tensor.
	/// </summary>
	public virtual void ExtractEigenvaluesOff()
	{
		vtkTensorGlyph_ExtractEigenvaluesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ExtractEigenvaluesOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off extraction of eigenvalues from tensor.
	/// </summary>
	public virtual void ExtractEigenvaluesOn()
	{
		vtkTensorGlyph_ExtractEigenvaluesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetClampScaling_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
	/// MaxScaleFactor is used to control the maximum scale factor. (This is
	/// useful to prevent uncontrolled scaling near singularities.)
	/// </summary>
	public virtual int GetClampScaling()
	{
		return vtkTensorGlyph_GetClampScaling_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetColorGlyphs_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off coloring of glyph with input scalar data or
	/// eigenvalues. If false, or input scalar data not present, then the
	/// scalars from the source object are passed through the filter.
	/// </summary>
	public virtual int GetColorGlyphs()
	{
		return vtkTensorGlyph_GetColorGlyphs_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetColorMode_09(HandleRef pThis);

	/// <summary>
	/// Set the color mode to be used for the glyphs.  This can be set to
	/// use the input scalars (default) or to use the eigenvalues at the
	/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
	/// coloring then each glyph is colored by the corresponding
	/// eigenvalue and if not set the color corresponding to the largest
	/// eigenvalue is chosen.  The recognized values are:
	/// COLOR_BY_SCALARS = 0 (default)
	/// COLOR_BY_EIGENVALUES = 1
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkTensorGlyph_GetColorMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetColorModeMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the color mode to be used for the glyphs.  This can be set to
	/// use the input scalars (default) or to use the eigenvalues at the
	/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
	/// coloring then each glyph is colored by the corresponding
	/// eigenvalue and if not set the color corresponding to the largest
	/// eigenvalue is chosen.  The recognized values are:
	/// COLOR_BY_SCALARS = 0 (default)
	/// COLOR_BY_EIGENVALUES = 1
	/// </summary>
	public virtual int GetColorModeMaxValue()
	{
		return vtkTensorGlyph_GetColorModeMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetColorModeMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the color mode to be used for the glyphs.  This can be set to
	/// use the input scalars (default) or to use the eigenvalues at the
	/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
	/// coloring then each glyph is colored by the corresponding
	/// eigenvalue and if not set the color corresponding to the largest
	/// eigenvalue is chosen.  The recognized values are:
	/// COLOR_BY_SCALARS = 0 (default)
	/// COLOR_BY_EIGENVALUES = 1
	/// </summary>
	public virtual int GetColorModeMinValue()
	{
		return vtkTensorGlyph_GetColorModeMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetExtractEigenvalues_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off extraction of eigenvalues from tensor.
	/// </summary>
	public virtual int GetExtractEigenvalues()
	{
		return vtkTensorGlyph_GetExtractEigenvalues_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTensorGlyph_GetLength_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the distance, along x, from the origin to the end of the
	/// source glyph. It is used to draw the symmetric glyphs.
	/// </summary>
	public virtual double GetLength()
	{
		return vtkTensorGlyph_GetLength_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTensorGlyph_GetMaxScaleFactor_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum allowable scale factor. This value is compared to the
	/// combination of the scale factor times the eigenvalue. If less, the scale
	/// factor is reset to the MaxScaleFactor. The boolean ClampScaling has to
	/// be "on" for this to work.
	/// </summary>
	public virtual double GetMaxScaleFactor()
	{
		return vtkTensorGlyph_GetMaxScaleFactor_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorGlyph_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTensorGlyph_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorGlyph_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTensorGlyph_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTensorGlyph_GetScaleFactor_17(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by. (Scale factor always affects
	/// output even if scaling is off.)
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkTensorGlyph_GetScaleFactor_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetScaling_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of glyph with eigenvalues.
	/// </summary>
	public virtual int GetScaling()
	{
		return vtkTensorGlyph_GetScaling_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorGlyph_GetSource_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the geometry to copy to each point.
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public vtkPolyData GetSource()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorGlyph_GetSource_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetSymmetric_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing a mirror of each glyph
	/// </summary>
	public virtual int GetSymmetric()
	{
		return vtkTensorGlyph_GetSymmetric_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_GetThreeGlyphs_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing three glyphs
	/// </summary>
	public virtual int GetThreeGlyphs()
	{
		return vtkTensorGlyph_GetThreeGlyphs_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTensorGlyph_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorGlyph_IsTypeOf_23(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTensorGlyph_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorGlyph_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public new vtkTensorGlyph NewInstance()
	{
		vtkTensorGlyph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorGlyph_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorGlyph_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.Construct object with scaling on and scale factor
	/// 1.0. Eigenvalues are extracted, glyphs are colored with input scalar
	/// data, and logarithmic scaling is turned off.
	/// </summary>
	public new static vtkTensorGlyph SafeDownCast(vtkObjectBase o)
	{
		vtkTensorGlyph vtkTensorGlyph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorGlyph_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTensorGlyph2 = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTensorGlyph2.Register(null);
			}
		}
		return vtkTensorGlyph2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ScalingOff_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of glyph with eigenvalues.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkTensorGlyph_ScalingOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ScalingOn_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of glyph with eigenvalues.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkTensorGlyph_ScalingOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetClampScaling_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off scalar clamping. If scalar clamping is on, the ivar
	/// MaxScaleFactor is used to control the maximum scale factor. (This is
	/// useful to prevent uncontrolled scaling near singularities.)
	/// </summary>
	public virtual void SetClampScaling(int _arg)
	{
		vtkTensorGlyph_SetClampScaling_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetColorGlyphs_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off coloring of glyph with input scalar data or
	/// eigenvalues. If false, or input scalar data not present, then the
	/// scalars from the source object are passed through the filter.
	/// </summary>
	public virtual void SetColorGlyphs(int _arg)
	{
		vtkTensorGlyph_SetColorGlyphs_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetColorMode_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the color mode to be used for the glyphs.  This can be set to
	/// use the input scalars (default) or to use the eigenvalues at the
	/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
	/// coloring then each glyph is colored by the corresponding
	/// eigenvalue and if not set the color corresponding to the largest
	/// eigenvalue is chosen.  The recognized values are:
	/// COLOR_BY_SCALARS = 0 (default)
	/// COLOR_BY_EIGENVALUES = 1
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkTensorGlyph_SetColorMode_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetColorModeToEigenvalues_32(HandleRef pThis);

	/// <summary>
	/// Set the color mode to be used for the glyphs.  This can be set to
	/// use the input scalars (default) or to use the eigenvalues at the
	/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
	/// coloring then each glyph is colored by the corresponding
	/// eigenvalue and if not set the color corresponding to the largest
	/// eigenvalue is chosen.  The recognized values are:
	/// COLOR_BY_SCALARS = 0 (default)
	/// COLOR_BY_EIGENVALUES = 1
	/// </summary>
	public void SetColorModeToEigenvalues()
	{
		vtkTensorGlyph_SetColorModeToEigenvalues_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetColorModeToScalars_33(HandleRef pThis);

	/// <summary>
	/// Set the color mode to be used for the glyphs.  This can be set to
	/// use the input scalars (default) or to use the eigenvalues at the
	/// point.  If ThreeGlyphs is set and the eigenvalues are chosen for
	/// coloring then each glyph is colored by the corresponding
	/// eigenvalue and if not set the color corresponding to the largest
	/// eigenvalue is chosen.  The recognized values are:
	/// COLOR_BY_SCALARS = 0 (default)
	/// COLOR_BY_EIGENVALUES = 1
	/// </summary>
	public void SetColorModeToScalars()
	{
		vtkTensorGlyph_SetColorModeToScalars_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetExtractEigenvalues_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off extraction of eigenvalues from tensor.
	/// </summary>
	public virtual void SetExtractEigenvalues(int _arg)
	{
		vtkTensorGlyph_SetExtractEigenvalues_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetLength_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the distance, along x, from the origin to the end of the
	/// source glyph. It is used to draw the symmetric glyphs.
	/// </summary>
	public virtual void SetLength(double _arg)
	{
		vtkTensorGlyph_SetLength_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetMaxScaleFactor_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum allowable scale factor. This value is compared to the
	/// combination of the scale factor times the eigenvalue. If less, the scale
	/// factor is reset to the MaxScaleFactor. The boolean ClampScaling has to
	/// be "on" for this to work.
	/// </summary>
	public virtual void SetMaxScaleFactor(double _arg)
	{
		vtkTensorGlyph_SetMaxScaleFactor_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetScaleFactor_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify scale factor to scale object by. (Scale factor always affects
	/// output even if scaling is off.)
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkTensorGlyph_SetScaleFactor_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetScaling_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off scaling of glyph with eigenvalues.
	/// </summary>
	public virtual void SetScaling(int _arg)
	{
		vtkTensorGlyph_SetScaling_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetSourceConnection_39(HandleRef pThis, int id, HandleRef algOutput);

	/// <summary>
	/// Specify a source object at a specified table location. New style.
	/// Source connection is stored in port 1. This method is equivalent
	/// to SetInputConnection(1, id, outputPort).
	/// </summary>
	public void SetSourceConnection(int id, vtkAlgorithmOutput algOutput)
	{
		vtkTensorGlyph_SetSourceConnection_39(GetCppThis(), id, algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetSourceConnection_40(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify a source object at a specified table location. New style.
	/// Source connection is stored in port 1. This method is equivalent
	/// to SetInputConnection(1, id, outputPort).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkTensorGlyph_SetSourceConnection_40(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetSourceData_41(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the geometry to copy to each point.
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public void SetSourceData(vtkPolyData source)
	{
		vtkTensorGlyph_SetSourceData_41(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetSymmetric_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off drawing a mirror of each glyph
	/// </summary>
	public virtual void SetSymmetric(int _arg)
	{
		vtkTensorGlyph_SetSymmetric_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SetThreeGlyphs_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off drawing three glyphs
	/// </summary>
	public virtual void SetThreeGlyphs(int _arg)
	{
		vtkTensorGlyph_SetThreeGlyphs_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SymmetricOff_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing a mirror of each glyph
	/// </summary>
	public virtual void SymmetricOff()
	{
		vtkTensorGlyph_SymmetricOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_SymmetricOn_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing a mirror of each glyph
	/// </summary>
	public virtual void SymmetricOn()
	{
		vtkTensorGlyph_SymmetricOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ThreeGlyphsOff_46(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing three glyphs
	/// </summary>
	public virtual void ThreeGlyphsOff()
	{
		vtkTensorGlyph_ThreeGlyphsOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorGlyph_ThreeGlyphsOn_47(HandleRef pThis);

	/// <summary>
	/// Turn on/off drawing three glyphs
	/// </summary>
	public virtual void ThreeGlyphsOn()
	{
		vtkTensorGlyph_ThreeGlyphsOn_47(GetCppThis());
	}
}
