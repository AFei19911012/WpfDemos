using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArcPlotter
/// </summary>
/// <remarks>
///    plot data along an arbitrary polyline
///
/// vtkArcPlotter performs plotting of attribute data along polylines defined
/// with an input vtkPolyData data object. Any type of attribute data can be
/// plotted including scalars, vectors, tensors, normals, texture coordinates,
/// and field data. Either one or multiple data components can be plotted.
///
/// To use this class you must specify an input data set that contains one or
/// more polylines, and some attribute data including which component of the
/// attribute data. (By default, this class processes the first component of
/// scalar data.) You will also need to set an offset radius (the distance
/// of the polyline to the median line of the plot), a width for the plot
/// (the distance that the minimum and maximum plot values are mapped into),
/// an possibly an offset (used to offset attribute data with multiple
/// components).
///
/// Normally the filter automatically computes normals for generating the
/// offset arc plot. However, you can specify a default normal and use that
/// instead.
///
/// </remarks>
/// <seealso>
///
/// vtkXYPlotActor
/// </seealso>
public class vtkArcPlotter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArcPlotter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArcPlotter()
	{
		MRClassNameKey = "class vtkArcPlotter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcPlotter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArcPlotter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcPlotter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public new static vtkArcPlotter New()
	{
		vtkArcPlotter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcPlotter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public vtkArcPlotter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArcPlotter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcPlotter_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a camera used to orient the plot along the arc. If no camera
	/// is specified, then the orientation of the plot is arbitrary.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcPlotter_GetCamera_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcPlotter_GetDefaultNormal_02(HandleRef pThis);

	/// <summary>
	/// Set the default normal to use if you do not wish automatic normal
	/// calculation. The arc plot will be generated using this normal.
	/// </summary>
	public virtual float[] GetDefaultNormal()
	{
		IntPtr intPtr = vtkArcPlotter_GetDefaultNormal_02(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_GetDefaultNormal_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the default normal to use if you do not wish automatic normal
	/// calculation. The arc plot will be generated using this normal.
	/// </summary>
	public virtual void GetDefaultNormal(IntPtr data)
	{
		vtkArcPlotter_GetDefaultNormal_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_GetFieldDataArray_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the field data array to plot. This instance variable is
	/// only applicable if field data is plotted.
	/// </summary>
	public virtual int GetFieldDataArray()
	{
		return vtkArcPlotter_GetFieldDataArray_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_GetFieldDataArrayMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the field data array to plot. This instance variable is
	/// only applicable if field data is plotted.
	/// </summary>
	public virtual int GetFieldDataArrayMaxValue()
	{
		return vtkArcPlotter_GetFieldDataArrayMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_GetFieldDataArrayMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the field data array to plot. This instance variable is
	/// only applicable if field data is plotted.
	/// </summary>
	public virtual int GetFieldDataArrayMinValue()
	{
		return vtkArcPlotter_GetFieldDataArrayMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetHeight_07(HandleRef pThis);

	/// <summary>
	/// Set the height of the plot. (The radius combined with the height
	/// define the location of the plot relative to the generating polyline.)
	/// </summary>
	public virtual double GetHeight()
	{
		return vtkArcPlotter_GetHeight_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetHeightMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the height of the plot. (The radius combined with the height
	/// define the location of the plot relative to the generating polyline.)
	/// </summary>
	public virtual double GetHeightMaxValue()
	{
		return vtkArcPlotter_GetHeightMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetHeightMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the height of the plot. (The radius combined with the height
	/// define the location of the plot relative to the generating polyline.)
	/// </summary>
	public virtual double GetHeightMinValue()
	{
		return vtkArcPlotter_GetHeightMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkArcPlotter_GetMTime_10(HandleRef pThis);

	/// <summary>
	/// New GetMTime because of camera dependency.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkArcPlotter_GetMTime_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArcPlotter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArcPlotter_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArcPlotter_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArcPlotter_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetOffset_13(HandleRef pThis);

	/// <summary>
	/// Specify an offset that translates each subsequent plot (if there is
	/// more than one component plotted) from the defining arc (i.e., polyline).
	/// </summary>
	public virtual double GetOffset()
	{
		return vtkArcPlotter_GetOffset_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetOffsetMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify an offset that translates each subsequent plot (if there is
	/// more than one component plotted) from the defining arc (i.e., polyline).
	/// </summary>
	public virtual double GetOffsetMaxValue()
	{
		return vtkArcPlotter_GetOffsetMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetOffsetMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify an offset that translates each subsequent plot (if there is
	/// more than one component plotted) from the defining arc (i.e., polyline).
	/// </summary>
	public virtual double GetOffsetMinValue()
	{
		return vtkArcPlotter_GetOffsetMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_GetPlotComponent_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the component number to plot if the data has more than one
	/// component. If the value of the plot component is == (-1), then all
	/// the components will be plotted.
	/// </summary>
	public virtual int GetPlotComponent()
	{
		return vtkArcPlotter_GetPlotComponent_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_GetPlotMode_17(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public virtual int GetPlotMode()
	{
		return vtkArcPlotter_GetPlotMode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetRadius_18(HandleRef pThis);

	/// <summary>
	/// Set the radius of the "median" value of the first plotted component.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkArcPlotter_GetRadius_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetRadiusMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the radius of the "median" value of the first plotted component.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkArcPlotter_GetRadiusMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArcPlotter_GetRadiusMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the radius of the "median" value of the first plotted component.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkArcPlotter_GetRadiusMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_GetUseDefaultNormal_21(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// By default, normals are automatically computed from the generating
	/// polyline and camera.
	/// </summary>
	public virtual int GetUseDefaultNormal()
	{
		return vtkArcPlotter_GetUseDefaultNormal_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArcPlotter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArcPlotter_IsTypeOf_23(string type);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArcPlotter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcPlotter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public new vtkArcPlotter NewInstance()
	{
		vtkArcPlotter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcPlotter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArcPlotter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate with no default camera and plot mode set to
	/// VTK_SCALARS.
	/// </summary>
	public new static vtkArcPlotter SafeDownCast(vtkObjectBase o)
	{
		vtkArcPlotter vtkArcPlotter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArcPlotter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArcPlotter2 = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArcPlotter2.Register(null);
			}
		}
		return vtkArcPlotter2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetCamera_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a camera used to orient the plot along the arc. If no camera
	/// is specified, then the orientation of the plot is arbitrary.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkArcPlotter_SetCamera_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetDefaultNormal_28(HandleRef pThis, float _arg1, float _arg2, float _arg3);

	/// <summary>
	/// Set the default normal to use if you do not wish automatic normal
	/// calculation. The arc plot will be generated using this normal.
	/// </summary>
	public virtual void SetDefaultNormal(float _arg1, float _arg2, float _arg3)
	{
		vtkArcPlotter_SetDefaultNormal_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetDefaultNormal_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the default normal to use if you do not wish automatic normal
	/// calculation. The arc plot will be generated using this normal.
	/// </summary>
	public virtual void SetDefaultNormal(IntPtr _arg)
	{
		vtkArcPlotter_SetDefaultNormal_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetFieldDataArray_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the field data array to plot. This instance variable is
	/// only applicable if field data is plotted.
	/// </summary>
	public virtual void SetFieldDataArray(int _arg)
	{
		vtkArcPlotter_SetFieldDataArray_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetHeight_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the height of the plot. (The radius combined with the height
	/// define the location of the plot relative to the generating polyline.)
	/// </summary>
	public virtual void SetHeight(double _arg)
	{
		vtkArcPlotter_SetHeight_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetOffset_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify an offset that translates each subsequent plot (if there is
	/// more than one component plotted) from the defining arc (i.e., polyline).
	/// </summary>
	public virtual void SetOffset(double _arg)
	{
		vtkArcPlotter_SetOffset_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotComponent_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the component number to plot if the data has more than one
	/// component. If the value of the plot component is == (-1), then all
	/// the components will be plotted.
	/// </summary>
	public virtual void SetPlotComponent(int _arg)
	{
		vtkArcPlotter_SetPlotComponent_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotMode_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public virtual void SetPlotMode(int _arg)
	{
		vtkArcPlotter_SetPlotMode_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotModeToPlotFieldData_35(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public void SetPlotModeToPlotFieldData()
	{
		vtkArcPlotter_SetPlotModeToPlotFieldData_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotModeToPlotNormals_36(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public void SetPlotModeToPlotNormals()
	{
		vtkArcPlotter_SetPlotModeToPlotNormals_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotModeToPlotScalars_37(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public void SetPlotModeToPlotScalars()
	{
		vtkArcPlotter_SetPlotModeToPlotScalars_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotModeToPlotTCoords_38(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public void SetPlotModeToPlotTCoords()
	{
		vtkArcPlotter_SetPlotModeToPlotTCoords_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotModeToPlotTensors_39(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public void SetPlotModeToPlotTensors()
	{
		vtkArcPlotter_SetPlotModeToPlotTensors_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetPlotModeToPlotVectors_40(HandleRef pThis);

	/// <summary>
	/// Specify which data to plot: scalars, vectors, normals, texture coords,
	/// tensors, or field data. If the data has more than one component, use
	/// the method SetPlotComponent to control which component to plot.
	/// </summary>
	public void SetPlotModeToPlotVectors()
	{
		vtkArcPlotter_SetPlotModeToPlotVectors_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetRadius_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the radius of the "median" value of the first plotted component.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkArcPlotter_SetRadius_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_SetUseDefaultNormal_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// By default, normals are automatically computed from the generating
	/// polyline and camera.
	/// </summary>
	public virtual void SetUseDefaultNormal(int _arg)
	{
		vtkArcPlotter_SetUseDefaultNormal_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_UseDefaultNormalOff_43(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// By default, normals are automatically computed from the generating
	/// polyline and camera.
	/// </summary>
	public virtual void UseDefaultNormalOff()
	{
		vtkArcPlotter_UseDefaultNormalOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArcPlotter_UseDefaultNormalOn_44(HandleRef pThis);

	/// <summary>
	/// Set a boolean to control whether to use default normals.
	/// By default, normals are automatically computed from the generating
	/// polyline and camera.
	/// </summary>
	public virtual void UseDefaultNormalOn()
	{
		vtkArcPlotter_UseDefaultNormalOn_44(GetCppThis());
	}
}
