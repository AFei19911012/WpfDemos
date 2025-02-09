using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabeledContourMapper
/// </summary>
/// <remarks>
///    Draw labeled isolines.
///
/// Draw isolines with 3D inline labels.
///
/// The lines in the input polydata will be drawn with labels displaying the
/// scalar value.
///
/// For this mapper to function properly, stenciling must be enabled in the
/// render window (it is disabled by default). Otherwise the lines will be
/// drawn through the labels.
/// </remarks>
public class vtkLabeledContourMapper : vtkMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledContourMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabeledContourMapper()
	{
		MRClassNameKey = "class vtkLabeledContourMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledContourMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabeledContourMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabeledContourMapper New()
	{
		vtkLabeledContourMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabeledContourMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabeledContourMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLabeledContourMapper_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkLabeledContourMapper_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkLabeledContourMapper_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the input data to map.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabeledContourMapper_GetLabelVisibility_04(HandleRef pThis);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual bool GetLabelVisibility()
	{
		return (vtkLabeledContourMapper_GetLabelVisibility_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledContourMapper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabeledContourMapper_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledContourMapper_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabeledContourMapper_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_GetPolyDataMapper_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The polydata mapper used to render the contours.
	/// </summary>
	public virtual vtkPolyDataMapper GetPolyDataMapper()
	{
		vtkPolyDataMapper vtkPolyDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_GetPolyDataMapper_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataMapper2 = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataMapper2.Register(null);
			}
		}
		return vtkPolyDataMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabeledContourMapper_GetSkipDistance_08(HandleRef pThis);

	/// <summary>
	/// Ensure that there are at least SkipDistance pixels between labels. This
	/// is only enforced on labels along the same line. The default is 0.
	/// </summary>
	public virtual double GetSkipDistance()
	{
		return vtkLabeledContourMapper_GetSkipDistance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_GetTextProperties_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text properties used to label the lines. Note that both vertical and
	/// horizontal justifications will be reset to "Centered" prior to rendering.
	///
	/// If the TextPropertyMapping array exists, then it is used to identify which
	/// text property to use for each label as follows: If the scalar value of a
	/// line is found in the mapping, the index of the value in mapping is used to
	/// lookup the text property in the collection. If there are more mapping
	/// values than properties, the properties are looped through until the
	/// mapping is exhausted.
	///
	/// Lines with scalar values missing from the mapping are assigned text
	/// properties in a round-robin fashion starting from the beginning of the
	/// collection, repeating from the start of the collection as necessary.
	/// @sa SetTextProperty
	/// @sa SetTextPropertyMapping
	/// </summary>
	public virtual vtkTextPropertyCollection GetTextProperties()
	{
		vtkTextPropertyCollection vtkTextPropertyCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_GetTextProperties_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextPropertyCollection2 = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextPropertyCollection2.Register(null);
			}
		}
		return vtkTextPropertyCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_GetTextPropertyMapping_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Values in this array correspond to vtkTextProperty objects in the
	/// TextProperties collection. If a contour line's scalar value exists in
	/// this array, the corresponding text property is used for the label.
	/// See SetTextProperties for more information.
	/// </summary>
	public virtual vtkDoubleArray GetTextPropertyMapping()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_GetTextPropertyMapping_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledContourMapper_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabeledContourMapper_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledContourMapper_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabeledContourMapper_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_LabelVisibilityOff_13(HandleRef pThis);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkLabeledContourMapper_LabelVisibilityOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_LabelVisibilityOn_14(HandleRef pThis);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkLabeledContourMapper_LabelVisibilityOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabeledContourMapper NewInstance()
	{
		vtkLabeledContourMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// The polydata mapper used to render the contours.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLabeledContourMapper_ReleaseGraphicsResources_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_Render_18(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkLabeledContourMapper_Render_18(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourMapper_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabeledContourMapper SafeDownCast(vtkObjectBase o)
	{
		vtkLabeledContourMapper vtkLabeledContourMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourMapper_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabeledContourMapper2 = (vtkLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabeledContourMapper2.Register(null);
			}
		}
		return vtkLabeledContourMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_SetInputData_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the input data to map.
	/// </summary>
	public void SetInputData(vtkPolyData arg0)
	{
		vtkLabeledContourMapper_SetInputData_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_SetLabelVisibility_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual void SetLabelVisibility(bool _arg)
	{
		vtkLabeledContourMapper_SetLabelVisibility_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_SetSkipDistance_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Ensure that there are at least SkipDistance pixels between labels. This
	/// is only enforced on labels along the same line. The default is 0.
	/// </summary>
	public virtual void SetSkipDistance(double _arg)
	{
		vtkLabeledContourMapper_SetSkipDistance_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_SetTextProperties_23(HandleRef pThis, HandleRef coll);

	/// <summary>
	/// The text properties used to label the lines. Note that both vertical and
	/// horizontal justifications will be reset to "Centered" prior to rendering.
	///
	/// If the TextPropertyMapping array exists, then it is used to identify which
	/// text property to use for each label as follows: If the scalar value of a
	/// line is found in the mapping, the index of the value in mapping is used to
	/// lookup the text property in the collection. If there are more mapping
	/// values than properties, the properties are looped through until the
	/// mapping is exhausted.
	///
	/// Lines with scalar values missing from the mapping are assigned text
	/// properties in a round-robin fashion starting from the beginning of the
	/// collection, repeating from the start of the collection as necessary.
	/// @sa SetTextProperty
	/// @sa SetTextPropertyMapping
	/// </summary>
	public virtual void SetTextProperties(vtkTextPropertyCollection coll)
	{
		vtkLabeledContourMapper_SetTextProperties_23(GetCppThis(), coll?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_SetTextProperty_24(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The text property used to label the lines. Note that both vertical and
	/// horizontal justifications will be reset to "Centered" prior to rendering.
	/// @note This is a convenience method that clears TextProperties and inserts
	/// the argument as the only property in the collection.
	/// @sa SetTextProperties
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty tprop)
	{
		vtkLabeledContourMapper_SetTextProperty_24(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourMapper_SetTextPropertyMapping_25(HandleRef pThis, HandleRef mapping);

	/// <summary>
	/// Values in this array correspond to vtkTextProperty objects in the
	/// TextProperties collection. If a contour line's scalar value exists in
	/// this array, the corresponding text property is used for the label.
	/// See SetTextProperties for more information.
	/// </summary>
	public virtual void SetTextPropertyMapping(vtkDoubleArray mapping)
	{
		vtkLabeledContourMapper_SetTextPropertyMapping_25(GetCppThis(), mapping?.GetCppThis() ?? default(HandleRef));
	}
}
