using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabeledDataMapper
/// </summary>
/// <remarks>
///    draw text labels at dataset points
///
/// vtkLabeledDataMapper is a mapper that renders text at dataset
/// points. Various items can be labeled including point ids, scalars,
/// vectors, normals, texture coordinates, tensors, and field data components.
///
/// The format with which the label is drawn is specified using a
/// printf style format string. The font attributes of the text can
/// be set through the vtkTextProperty associated to this mapper.
///
/// By default, all the components of multi-component data such as
/// vectors, normals, texture coordinates, tensors, and multi-component
/// scalars are labeled. However, you can specify a single component if
/// you prefer. (Note: the label format specifies the format to use for
/// a single component. The label is creating by looping over all components
/// and using the label format to render each component.)
/// The character separator between components can be set. By default,
/// it is set to a single whitespace.
///
/// @warning
/// Use this filter in combination with vtkSelectVisiblePoints if you want
/// to label only points that are visible. If you want to label cells rather
/// than points, use the filter vtkCellCenters to generate points at the
/// center of the cells. Also, you can use the class vtkIdFilter to
/// generate ids as scalars or field data, which can then be labeled.
///
/// </remarks>
/// <seealso>
///
/// vtkMapper2D vtkActor2D vtkTextMapper vtkTextProperty vtkSelectVisiblePoints
/// vtkIdFilter vtkCellCenters
/// </seealso>
public class vtkLabeledDataMapper : vtkMapper2D
{
	/// <summary>
	/// The transform to apply to the labels before mapping to 2D.
	/// </summary>
	public enum Coordinates
	{
		/// <summary>enum member</summary>
		DISPLAY = 1,
		/// <summary>enum member</summary>
		WORLD = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledDataMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabeledDataMapper()
	{
		MRClassNameKey = "class vtkLabeledDataMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledDataMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabeledDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static vtkLabeledDataMapper New()
	{
		vtkLabeledDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public vtkLabeledDataMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabeledDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_CoordinateSystemDisplay_01(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public void CoordinateSystemDisplay()
	{
		vtkLabeledDataMapper_CoordinateSystemDisplay_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_CoordinateSystemWorld_02(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public void CoordinateSystemWorld()
	{
		vtkLabeledDataMapper_CoordinateSystemWorld_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkLabeledDataMapper_GetComponentSeparator_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the separator between components.
	/// </summary>
	public virtual sbyte GetComponentSeparator()
	{
		return vtkLabeledDataMapper_GetComponentSeparator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetCoordinateSystem_04(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual int GetCoordinateSystem()
	{
		return vtkLabeledDataMapper_GetCoordinateSystem_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetCoordinateSystemMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual int GetCoordinateSystemMaxValue()
	{
		return vtkLabeledDataMapper_GetCoordinateSystemMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetCoordinateSystemMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual int GetCoordinateSystemMinValue()
	{
		return vtkLabeledDataMapper_GetCoordinateSystemMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetFieldDataArray_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the field data array to label. This instance variable is
	/// only applicable if field data is labeled.  This will clear
	/// FieldDataName when set.
	/// </summary>
	public virtual int GetFieldDataArray()
	{
		return vtkLabeledDataMapper_GetFieldDataArray_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetFieldDataName_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the field data array to label.  This instance
	/// variable is only applicable if field data is labeled.  This will
	/// override FieldDataArray when set.
	/// </summary>
	public virtual string GetFieldDataName()
	{
		return Marshal.PtrToStringAnsi(vtkLabeledDataMapper_GetFieldDataName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use GetInputDataObject() to get the input data object for composite
	/// datasets.
	/// </summary>
	public vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_GetInput_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetLabelFormat_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels.  This should
	/// be a printf-style format string.
	///
	/// By default, the mapper will try to print each component of the
	/// tuple using a sane format: %d for integers, %f for floats, %g for
	/// doubles, %ld for longs, et cetera.  If you need a different
	/// format, set it here.  You can do things like limit the number of
	/// significant digits, add prefixes/suffixes, basically anything
	/// that printf can do.  If you only want to print one component of a
	/// vector, see the ivar LabeledComponent.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkLabeledDataMapper_GetLabelFormat_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetLabelMode_11(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public virtual int GetLabelMode()
	{
		return vtkLabeledDataMapper_GetLabelMode_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_GetLabelPosition_12(HandleRef pThis, int label, IntPtr pos);

	/// <summary>
	/// Return the position of the requested label.
	/// </summary>
	public void GetLabelPosition(int label, IntPtr pos)
	{
		vtkLabeledDataMapper_GetLabelPosition_12(GetCppThis(), label, pos);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetLabelText_13(HandleRef pThis, int label);

	/// <summary>
	/// Return the text for the requested label.
	/// </summary>
	public string GetLabelText(int label)
	{
		return Marshal.PtrToStringAnsi(vtkLabeledDataMapper_GetLabelText_13(GetCppThis(), label));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetLabelTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// If an integer argument is provided, you may provide different text
	/// properties for different label types. The type is determined by an
	/// optional type input array.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_GetLabelTextProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetLabelTextProperty_15(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// If an integer argument is provided, you may provide different text
	/// properties for different label types. The type is determined by an
	/// optional type input array.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty(int type)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_GetLabelTextProperty_15(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetLabeledComponent_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the component number to label if the data to print has
	/// more than one component. For example, all the components of
	/// scalars, vectors, normals, etc. are labeled by default
	/// (LabeledComponent=(-1)). However, if this ivar is nonnegative,
	/// then only the one component specified is labeled.
	/// </summary>
	public virtual int GetLabeledComponent()
	{
		return vtkLabeledDataMapper_GetLabeledComponent_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLabeledDataMapper_GetMTime_17(HandleRef pThis);

	/// <summary>
	/// Return the modified time for this object.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkLabeledDataMapper_GetMTime_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledDataMapper_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabeledDataMapper_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledDataMapper_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabeledDataMapper_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_GetNumberOfLabels_20(HandleRef pThis);

	/// <summary>
	/// Return the number of labels rendered by the mapper.
	/// </summary>
	public virtual int GetNumberOfLabels()
	{
		return vtkLabeledDataMapper_GetNumberOfLabels_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_GetTransform_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The transform to apply to the labels before mapping to 2D.
	/// </summary>
	public virtual vtkTransform GetTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_GetTransform_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabeledDataMapper_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledDataMapper_IsTypeOf_23(string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabeledDataMapper_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new vtkLabeledDataMapper NewInstance()
	{
		vtkLabeledDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLabeledDataMapper_ReleaseGraphicsResources_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw the text to the screen at each input point.
	/// </summary>
	public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
	{
		vtkLabeledDataMapper_RenderOpaqueGeometry_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_RenderOverlay_28(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw the text to the screen at each input point.
	/// </summary>
	public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
	{
		vtkLabeledDataMapper_RenderOverlay_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledDataMapper_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static vtkLabeledDataMapper SafeDownCast(vtkObjectBase o)
	{
		vtkLabeledDataMapper vtkLabeledDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledDataMapper_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabeledDataMapper2 = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabeledDataMapper2.Register(null);
			}
		}
		return vtkLabeledDataMapper2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetComponentSeparator_30(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// Set/Get the separator between components.
	/// </summary>
	public virtual void SetComponentSeparator(sbyte _arg)
	{
		vtkLabeledDataMapper_SetComponentSeparator_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetCoordinateSystem_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual void SetCoordinateSystem(int _arg)
	{
		vtkLabeledDataMapper_SetCoordinateSystem_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetFieldDataArray_32(HandleRef pThis, int arrayIndex);

	/// <summary>
	/// Set/Get the field data array to label. This instance variable is
	/// only applicable if field data is labeled.  This will clear
	/// FieldDataName when set.
	/// </summary>
	public void SetFieldDataArray(int arrayIndex)
	{
		vtkLabeledDataMapper_SetFieldDataArray_32(GetCppThis(), arrayIndex);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetFieldDataName_33(HandleRef pThis, string arrayName);

	/// <summary>
	/// Set/Get the name of the field data array to label.  This instance
	/// variable is only applicable if field data is labeled.  This will
	/// override FieldDataArray when set.
	/// </summary>
	public void SetFieldDataName(string arrayName)
	{
		vtkLabeledDataMapper_SetFieldDataName_33(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetInputData_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input dataset to the mapper. This mapper handles any type of data.
	/// </summary>
	public virtual void SetInputData(vtkDataObject arg0)
	{
		vtkLabeledDataMapper_SetInputData_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelFormat_35(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels.  This should
	/// be a printf-style format string.
	///
	/// By default, the mapper will try to print each component of the
	/// tuple using a sane format: %d for integers, %f for floats, %g for
	/// doubles, %ld for longs, et cetera.  If you need a different
	/// format, set it here.  You can do things like limit the number of
	/// significant digits, add prefixes/suffixes, basically anything
	/// that printf can do.  If you only want to print one component of a
	/// vector, see the ivar LabeledComponent.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkLabeledDataMapper_SetLabelFormat_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelMode_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public virtual void SetLabelMode(int _arg)
	{
		vtkLabeledDataMapper_SetLabelMode_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelFieldData_37(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelFieldData()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelFieldData_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelIds_38(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelIds()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelIds_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelNormals_39(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelNormals()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelNormals_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelScalars_40(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelScalars()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelScalars_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelTCoords_41(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelTCoords()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelTCoords_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelTensors_42(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelTensors()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelTensors_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelVectors_43(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetLabeledComponent to control which components to plot.
	/// The default is VTK_LABEL_IDS.
	/// </summary>
	public void SetLabelModeToLabelVectors()
	{
		vtkLabeledDataMapper_SetLabelModeToLabelVectors_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelTextProperty_44(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property.
	/// If an integer argument is provided, you may provide different text
	/// properties for different label types. The type is determined by an
	/// optional type input array.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkLabeledDataMapper_SetLabelTextProperty_44(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabelTextProperty_45(HandleRef pThis, HandleRef p, int type);

	/// <summary>
	/// Set/Get the text property.
	/// If an integer argument is provided, you may provide different text
	/// properties for different label types. The type is determined by an
	/// optional type input array.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p, int type)
	{
		vtkLabeledDataMapper_SetLabelTextProperty_45(GetCppThis(), p?.GetCppThis() ?? default(HandleRef), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetLabeledComponent_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the component number to label if the data to print has
	/// more than one component. For example, all the components of
	/// scalars, vectors, normals, etc. are labeled by default
	/// (LabeledComponent=(-1)). However, if this ivar is nonnegative,
	/// then only the one component specified is labeled.
	/// </summary>
	public virtual void SetLabeledComponent(int _arg)
	{
		vtkLabeledDataMapper_SetLabeledComponent_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledDataMapper_SetTransform_47(HandleRef pThis, HandleRef t);

	/// <summary>
	/// The transform to apply to the labels before mapping to 2D.
	/// </summary>
	public void SetTransform(vtkTransform t)
	{
		vtkLabeledDataMapper_SetTransform_47(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}
}
