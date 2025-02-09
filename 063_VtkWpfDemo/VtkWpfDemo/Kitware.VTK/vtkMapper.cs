using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMapper
/// </summary>
/// <remarks>
///    abstract class specifies interface to map data to graphics primitives
///
/// vtkMapper is an abstract class to specify interface between data and
/// graphics primitives. Subclasses of vtkMapper map data through a
/// lookuptable and control the creation of rendering primitives that
/// interface to the graphics library. The mapping can be controlled by
/// supplying a lookup table and specifying a scalar range to map data
/// through.
///
/// There are several important control mechanisms affecting the behavior of
/// this object. The ScalarVisibility flag controls whether scalar data (if
/// any) controls the color of the associated actor(s) that refer to the
/// mapper. The ScalarMode ivar is used to determine whether scalar point data
/// or cell data is used to color the object. By default, point data scalars
/// are used unless there are none, in which cell scalars are used. Or you can
/// explicitly control whether to use point or cell scalar data. Finally, the
/// mapping of scalars through the lookup table varies depending on the
/// setting of the ColorMode flag. See the documentation for the appropriate
/// methods for an explanation.
///
/// Another important feature of the mapper is the ability to shift the
/// z-buffer to resolve coincident topology. For example, if you'd like to
/// draw a mesh with some edges a different color, and the edges lie on the
/// mesh, this feature can be useful to get nice looking lines. (See the
/// ResolveCoincidentTopology-related methods.)
///
/// </remarks>
/// <seealso>
///
/// vtkDataSetMapper vtkPolyDataMapper
/// </seealso>
public abstract class vtkMapper : vtkAbstractMapper3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMapper()
	{
		MRClassNameKey = "class vtkMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_CanUseTextureMapForColoring_01(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Returns if we can use texture maps for scalar coloring. Note this doesn't
	/// say we "will" use scalar coloring. It says, if we do use scalar coloring,
	/// we will use a texture.
	/// When rendering multiblock datasets, if any 2 blocks provide different
	/// lookup tables for the scalars, then also we cannot use textures. This case
	/// can be handled if required.
	/// </summary>
	public virtual int CanUseTextureMapForColoring(vtkDataObject input)
	{
		return vtkMapper_CanUseTextureMapForColoring_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ClearColorArrays_02(HandleRef pThis);

	/// <summary>
	/// Call to force a rebuild of color result arrays on next MapScalars.
	/// Necessary when using arrays in the case of multiblock data.
	/// </summary>
	public void ClearColorArrays()
	{
		vtkMapper_ClearColorArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ColorByArrayComponent_03(HandleRef pThis, int arrayNum, int component);

	/// <summary>
	/// Legacy:
	/// These methods used to be used to specify the array component.
	/// It is better to do this in the lookup table.
	/// </summary>
	public void ColorByArrayComponent(int arrayNum, int component)
	{
		vtkMapper_ColorByArrayComponent_03(GetCppThis(), arrayNum, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ColorByArrayComponent_04(HandleRef pThis, string arrayName, int component);

	/// <summary>
	/// Legacy:
	/// These methods used to be used to specify the array component.
	/// It is better to do this in the lookup table.
	/// </summary>
	public void ColorByArrayComponent(string arrayName, int component)
	{
		vtkMapper_ColorByArrayComponent_04(GetCppThis(), arrayName, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_CreateDefaultLookupTable_05(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available with the scalar data.
	/// </summary>
	public virtual void CreateDefaultLookupTable()
	{
		vtkMapper_CreateDefaultLookupTable_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetArrayAccessMode_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual int GetArrayAccessMode()
	{
		return vtkMapper_GetArrayAccessMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetArrayComponent_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkMapper_GetArrayComponent_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetArrayId_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual int GetArrayId()
	{
		return vtkMapper_GetArrayId_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetArrayName_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMapper_GetArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetBounds_10(HandleRef pThis);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkMapper_GetBounds_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetBounds_11(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkMapper_GetBounds_11(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetCoincidentTopologyLineOffsetParameters_12(HandleRef pThis, ref double factor, ref double units);

	/// <summary>
	/// Get the net parameters for handling coincident topology
	/// obtained by summing the global values with the relative values.
	/// </summary>
	public void GetCoincidentTopologyLineOffsetParameters(ref double factor, ref double units)
	{
		vtkMapper_GetCoincidentTopologyLineOffsetParameters_12(GetCppThis(), ref factor, ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetCoincidentTopologyPointOffsetParameter_13(HandleRef pThis, ref double units);

	/// <summary>
	/// Get the net parameters for handling coincident topology
	/// obtained by summing the global values with the relative values.
	/// </summary>
	public void GetCoincidentTopologyPointOffsetParameter(ref double units)
	{
		vtkMapper_GetCoincidentTopologyPointOffsetParameter_13(GetCppThis(), ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetCoincidentTopologyPolygonOffsetParameters_14(HandleRef pThis, ref double factor, ref double units);

	/// <summary>
	/// Get the net parameters for handling coincident topology
	/// obtained by summing the global values with the relative values.
	/// </summary>
	public void GetCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
	{
		vtkMapper_GetCoincidentTopologyPolygonOffsetParameters_14(GetCppThis(), ref factor, ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetColorCoordinates_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide read access to the color texture coordinate array
	/// </summary>
	public vtkFloatArray GetColorCoordinates()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetColorCoordinates_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetColorMapColors_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide read access to the color array
	/// </summary>
	public vtkUnsignedCharArray GetColorMapColors()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetColorMapColors_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetColorMode_17(HandleRef pThis);

	/// <summary>
	/// default (ColorModeToDefault), unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table, while
	/// everything else is.  ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0.  Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.  (Note that for multi-component
	/// scalars, the particular component to use for mapping can be
	/// specified using the SelectColorArray() method.)
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkMapper_GetColorMode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetColorModeAsString_18(HandleRef pThis);

	/// <summary>
	/// Return the method of coloring scalar data.
	/// </summary>
	public string GetColorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkMapper_GetColorModeAsString_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetColorTextureMap_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide read access to the color texture array
	/// </summary>
	public vtkImageData GetColorTextureMap()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetColorTextureMap_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMapper_GetFieldDataTupleId_20(HandleRef pThis);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public virtual long GetFieldDataTupleId()
	{
		return vtkMapper_GetFieldDataTupleId_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetInput_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a vtkDataSet.  This method is overridden in
	/// the specialized mapper classes to return more specific data types.
	/// </summary>
	public vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetInput_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetInputAsDataSet_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this mapper as a vtkDataSet, instead of as a
	/// more specialized data type that the subclass may return from
	/// GetInput().  This method is provided for use in the wrapper languages,
	/// C++ programmers should use GetInput() instead.
	/// </summary>
	public vtkDataSet GetInputAsDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetInputAsDataSet_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetInterpolateScalarsBeforeMapping_23(HandleRef pThis);

	/// <summary>
	/// By default, vertex color is used to map colors to a surface.
	/// Colors are interpolated after being mapped.
	/// This option avoids color interpolation by using a one dimensional
	/// texture map for the colors.
	/// </summary>
	public virtual int GetInterpolateScalarsBeforeMapping()
	{
		return vtkMapper_GetInterpolateScalarsBeforeMapping_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetLookupTable_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetLookupTable_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMapper_GetMTime_25(HandleRef pThis);

	/// <summary>
	/// Overload standard modified time function. If lookup table is modified,
	/// then this object is modified as well.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMapper_GetMTime_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMapper_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMapper_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMapper_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMapper_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetRelativeCoincidentTopologyLineOffsetParameters_28(HandleRef pThis, ref double factor, ref double units);

	/// <summary>
	/// Used to set the line offset values relative to the global
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// </summary>
	public void GetRelativeCoincidentTopologyLineOffsetParameters(ref double factor, ref double units)
	{
		vtkMapper_GetRelativeCoincidentTopologyLineOffsetParameters_28(GetCppThis(), ref factor, ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetRelativeCoincidentTopologyPointOffsetParameter_29(HandleRef pThis, ref double units);

	/// <summary>
	/// Used to set the point offset value relative to the global
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// </summary>
	public void GetRelativeCoincidentTopologyPointOffsetParameter(ref double units)
	{
		vtkMapper_GetRelativeCoincidentTopologyPointOffsetParameter_29(GetCppThis(), ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetRelativeCoincidentTopologyPolygonOffsetParameters_30(HandleRef pThis, ref double factor, ref double units);

	/// <summary>
	/// Used to set the polygon offset values relative to the global
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// </summary>
	public void GetRelativeCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
	{
		vtkMapper_GetRelativeCoincidentTopologyPolygonOffsetParameters_30(GetCppThis(), ref factor, ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMapper_GetRenderTime_31(HandleRef pThis);

	/// <summary>
	/// This instance variable is used by vtkLODActor to determine which
	/// mapper to use.  It is an estimate of the time necessary to render.
	/// Setting the render time does not modify the mapper.
	/// </summary>
	public virtual double GetRenderTime()
	{
		return vtkMapper_GetRenderTime_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetResolveCoincidentTopology_32();

	/// <summary>
	/// Set/Get a global flag that controls whether coincident topology (e.g., a
	/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
	/// hence rendering problems). If not off, there are two methods to choose
	/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
	/// and points from each other. ShiftZBuffer is a legacy method that used to
	/// remap the z-buffer to distinguish vertices, lines, and polygons, but
	/// does not always produce acceptable results. You should only use the
	/// PolygonOffset method (or none) at this point.
	/// </summary>
	public static int GetResolveCoincidentTopology()
	{
		return vtkMapper_GetResolveCoincidentTopology_32();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetResolveCoincidentTopologyLineOffsetParameters_33(ref double factor, ref double units);

	/// <summary>
	/// Used to set the line offset scale factor and units.
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// These are global variables.
	/// </summary>
	public static void GetResolveCoincidentTopologyLineOffsetParameters(ref double factor, ref double units)
	{
		vtkMapper_GetResolveCoincidentTopologyLineOffsetParameters_33(ref factor, ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetResolveCoincidentTopologyPointOffsetParameter_34(ref double units);

	/// <summary>
	/// Used to set the point offset value
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// These are global variables.
	/// </summary>
	public static void GetResolveCoincidentTopologyPointOffsetParameter(ref double units)
	{
		vtkMapper_GetResolveCoincidentTopologyPointOffsetParameter_34(ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_35();

	/// <summary>
	/// Used when ResolveCoincidentTopology is set to PolygonOffset. The polygon
	/// offset can be applied either to the solid polygonal faces or the
	/// lines/vertices. When set (default), the offset is applied to the faces
	/// otherwise it is applied to lines and vertices.
	/// This is a global variable.
	/// </summary>
	public static int GetResolveCoincidentTopologyPolygonOffsetFaces()
	{
		return vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_35();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_36(ref double factor, ref double units);

	/// <summary>
	/// Used to set the polygon offset scale factor and units.
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// These are global variables.
	/// </summary>
	public static void GetResolveCoincidentTopologyPolygonOffsetParameters(ref double factor, ref double units)
	{
		vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_36(ref factor, ref units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMapper_GetResolveCoincidentTopologyZShift_37();

	/// <summary>
	/// Used to set the z-shift if ResolveCoincidentTopology is set to
	/// ShiftZBuffer. This is a global variable.
	/// </summary>
	public static double GetResolveCoincidentTopologyZShift()
	{
		return vtkMapper_GetResolveCoincidentTopologyZShift_37();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetScalarMode_38(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkMapper_GetScalarMode_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetScalarModeAsString_39(HandleRef pThis);

	/// <summary>
	/// Return the method for obtaining scalar data.
	/// </summary>
	public string GetScalarModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkMapper_GetScalarModeAsString_39(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetScalarRange_40(HandleRef pThis);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkMapper_GetScalarRange_40(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_GetScalarRange_41(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public virtual void GetScalarRange(IntPtr data)
	{
		vtkMapper_GetScalarRange_41(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetScalarVisibility_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual int GetScalarVisibility()
	{
		return vtkMapper_GetScalarVisibility_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_GetSelection_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get selection used to display particular points or cells in a second pass.
	/// This can be use to efficiently display a selection.
	/// </summary>
	public virtual vtkSelection GetSelection()
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_GetSelection_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetStatic_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether the mapper's data is static. Static data
	/// means that the mapper does not propagate updates down the pipeline, greatly
	/// decreasing the time it takes to update many mappers. This should only be
	/// used if the data never changes.
	/// </summary>
	public virtual int GetStatic()
	{
		return vtkMapper_GetStatic_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMapper_GetSupportsSelection_45(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	/// </summary>
	public virtual bool GetSupportsSelection()
	{
		return (vtkMapper_GetSupportsSelection_45(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_GetUseLookupTableScalarRange_46(HandleRef pThis);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual int GetUseLookupTableScalarRange()
	{
		return vtkMapper_GetUseLookupTableScalarRange_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMapper_HasOpaqueGeometry_47(HandleRef pThis);

	/// <summary>
	/// Some introspection on the type of data the mapper will render
	/// used by props to determine if they should invoke the mapper
	/// on a specific rendering pass.
	/// </summary>
	public virtual bool HasOpaqueGeometry()
	{
		return (vtkMapper_HasOpaqueGeometry_47(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMapper_HasTranslucentPolygonalGeometry_48(HandleRef pThis);

	/// <summary>
	/// Some introspection on the type of data the mapper will render
	/// used by props to determine if they should invoke the mapper
	/// on a specific rendering pass.
	/// </summary>
	public virtual bool HasTranslucentPolygonalGeometry()
	{
		return (vtkMapper_HasTranslucentPolygonalGeometry_48(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_InterpolateScalarsBeforeMappingOff_49(HandleRef pThis);

	/// <summary>
	/// By default, vertex color is used to map colors to a surface.
	/// Colors are interpolated after being mapped.
	/// This option avoids color interpolation by using a one dimensional
	/// texture map for the colors.
	/// </summary>
	public virtual void InterpolateScalarsBeforeMappingOff()
	{
		vtkMapper_InterpolateScalarsBeforeMappingOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_InterpolateScalarsBeforeMappingOn_50(HandleRef pThis);

	/// <summary>
	/// By default, vertex color is used to map colors to a surface.
	/// Colors are interpolated after being mapped.
	/// This option avoids color interpolation by using a one dimensional
	/// texture map for the colors.
	/// </summary>
	public virtual void InterpolateScalarsBeforeMappingOn()
	{
		vtkMapper_InterpolateScalarsBeforeMappingOn_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_IsA_51(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMapper_IsA_51(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapper_IsTypeOf_52(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMapper_IsTypeOf_52(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_MapScalars_53(HandleRef pThis, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Map the scalars (if there are any scalars and ScalarVisibility is on)
	/// through the lookup table, returning an unsigned char RGBA array. This is
	/// typically done as part of the rendering process. The alpha parameter
	/// allows the blending of the scalars with an additional alpha (typically
	/// which comes from a vtkActor, etc.)
	/// </summary>
	public virtual vtkUnsignedCharArray MapScalars(double alpha)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_MapScalars_53(GetCppThis(), alpha, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_MapScalars_54(HandleRef pThis, double alpha, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Map the scalars (if there are any scalars and ScalarVisibility is on)
	/// through the lookup table, returning an unsigned char RGBA array. This is
	/// typically done as part of the rendering process. The alpha parameter
	/// allows the blending of the scalars with an additional alpha (typically
	/// which comes from a vtkActor, etc.)
	/// </summary>
	public virtual vtkUnsignedCharArray MapScalars(double alpha, ref int cellFlag)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_MapScalars_54(GetCppThis(), alpha, ref cellFlag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_MapScalars_55(HandleRef pThis, HandleRef input, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Map the scalars (if there are any scalars and ScalarVisibility is on)
	/// through the lookup table, returning an unsigned char RGBA array. This is
	/// typically done as part of the rendering process. The alpha parameter
	/// allows the blending of the scalars with an additional alpha (typically
	/// which comes from a vtkActor, etc.)
	/// </summary>
	public virtual vtkUnsignedCharArray MapScalars(vtkDataSet input, double alpha)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_MapScalars_55(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), alpha, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_MapScalars_56(HandleRef pThis, HandleRef input, double alpha, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Map the scalars (if there are any scalars and ScalarVisibility is on)
	/// through the lookup table, returning an unsigned char RGBA array. This is
	/// typically done as part of the rendering process. The alpha parameter
	/// allows the blending of the scalars with an additional alpha (typically
	/// which comes from a vtkActor, etc.)
	/// </summary>
	public virtual vtkUnsignedCharArray MapScalars(vtkDataSet input, double alpha, ref int cellFlag)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_MapScalars_56(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), alpha, ref cellFlag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMapper NewInstance()
	{
		vtkMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_NewInstance_57(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ReleaseGraphicsResources_58(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkMapper_ReleaseGraphicsResources_58(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_Render_59(HandleRef pThis, HandleRef ren, HandleRef a);

	/// <summary>
	/// Method initiates the mapping process. Generally sent by the actor
	/// as each frame is rendered.
	/// </summary>
	public virtual void Render(vtkRenderer ren, vtkActor a)
	{
		vtkMapper_Render_59(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapper_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMapper SafeDownCast(vtkObjectBase o)
	{
		vtkMapper vtkMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapper_SafeDownCast_60(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMapper2 = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMapper2.Register(null);
			}
		}
		return vtkMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ScalarVisibilityOff_61(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkMapper_ScalarVisibilityOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ScalarVisibilityOn_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkMapper_ScalarVisibilityOn_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SelectColorArray_63(HandleRef pThis, int arrayNum);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(int arrayNum)
	{
		vtkMapper_SelectColorArray_63(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SelectColorArray_64(HandleRef pThis, string arrayName);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(string arrayName)
	{
		vtkMapper_SelectColorArray_64(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetArrayAccessMode_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual void SetArrayAccessMode(int _arg)
	{
		vtkMapper_SetArrayAccessMode_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetArrayComponent_66(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkMapper_SetArrayComponent_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetArrayId_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual void SetArrayId(int _arg)
	{
		vtkMapper_SetArrayId_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetArrayName_68(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the array name or number and component to color by.
	/// </summary>
	public virtual void SetArrayName(string _arg)
	{
		vtkMapper_SetArrayName_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetColorMode_69(HandleRef pThis, int _arg);

	/// <summary>
	/// default (ColorModeToDefault), unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table, while
	/// everything else is.  ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0.  Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.  (Note that for multi-component
	/// scalars, the particular component to use for mapping can be
	/// specified using the SelectColorArray() method.)
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkMapper_SetColorMode_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetColorModeToDefault_70(HandleRef pThis);

	/// <summary>
	/// default (ColorModeToDefault), unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table, while
	/// everything else is.  ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0.  Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.  (Note that for multi-component
	/// scalars, the particular component to use for mapping can be
	/// specified using the SelectColorArray() method.)
	/// </summary>
	public void SetColorModeToDefault()
	{
		vtkMapper_SetColorModeToDefault_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetColorModeToDirectScalars_71(HandleRef pThis);

	/// <summary>
	/// default (ColorModeToDefault), unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table, while
	/// everything else is.  ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0.  Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.  (Note that for multi-component
	/// scalars, the particular component to use for mapping can be
	/// specified using the SelectColorArray() method.)
	/// </summary>
	public void SetColorModeToDirectScalars()
	{
		vtkMapper_SetColorModeToDirectScalars_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetColorModeToMapScalars_72(HandleRef pThis);

	/// <summary>
	/// default (ColorModeToDefault), unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table, while
	/// everything else is.  ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0.  Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.  (Note that for multi-component
	/// scalars, the particular component to use for mapping can be
	/// specified using the SelectColorArray() method.)
	/// </summary>
	public void SetColorModeToMapScalars()
	{
		vtkMapper_SetColorModeToMapScalars_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetFieldDataTupleId_73(HandleRef pThis, long _arg);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public virtual void SetFieldDataTupleId(long _arg)
	{
		vtkMapper_SetFieldDataTupleId_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetInterpolateScalarsBeforeMapping_74(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, vertex color is used to map colors to a surface.
	/// Colors are interpolated after being mapped.
	/// This option avoids color interpolation by using a one dimensional
	/// texture map for the colors.
	/// </summary>
	public virtual void SetInterpolateScalarsBeforeMapping(int _arg)
	{
		vtkMapper_SetInterpolateScalarsBeforeMapping_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetLookupTable_75(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkMapper_SetLookupTable_75(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetRelativeCoincidentTopologyLineOffsetParameters_76(HandleRef pThis, double factor, double units);

	/// <summary>
	/// Used to set the line offset values relative to the global
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// </summary>
	public void SetRelativeCoincidentTopologyLineOffsetParameters(double factor, double units)
	{
		vtkMapper_SetRelativeCoincidentTopologyLineOffsetParameters_76(GetCppThis(), factor, units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetRelativeCoincidentTopologyPointOffsetParameter_77(HandleRef pThis, double units);

	/// <summary>
	/// Used to set the point offset value relative to the global
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// </summary>
	public void SetRelativeCoincidentTopologyPointOffsetParameter(double units)
	{
		vtkMapper_SetRelativeCoincidentTopologyPointOffsetParameter_77(GetCppThis(), units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetRelativeCoincidentTopologyPolygonOffsetParameters_78(HandleRef pThis, double factor, double units);

	/// <summary>
	/// Used to set the polygon offset values relative to the global
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// </summary>
	public void SetRelativeCoincidentTopologyPolygonOffsetParameters(double factor, double units)
	{
		vtkMapper_SetRelativeCoincidentTopologyPolygonOffsetParameters_78(GetCppThis(), factor, units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetRenderTime_79(HandleRef pThis, double time);

	/// <summary>
	/// This instance variable is used by vtkLODActor to determine which
	/// mapper to use.  It is an estimate of the time necessary to render.
	/// Setting the render time does not modify the mapper.
	/// </summary>
	public void SetRenderTime(double time)
	{
		vtkMapper_SetRenderTime_79(GetCppThis(), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopology_80(int val);

	/// <summary>
	/// Set/Get a global flag that controls whether coincident topology (e.g., a
	/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
	/// hence rendering problems). If not off, there are two methods to choose
	/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
	/// and points from each other. ShiftZBuffer is a legacy method that used to
	/// remap the z-buffer to distinguish vertices, lines, and polygons, but
	/// does not always produce acceptable results. You should only use the
	/// PolygonOffset method (or none) at this point.
	/// </summary>
	public static void SetResolveCoincidentTopology(int val)
	{
		vtkMapper_SetResolveCoincidentTopology_80(val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyLineOffsetParameters_81(double factor, double units);

	/// <summary>
	/// Used to set the line offset scale factor and units.
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// These are global variables.
	/// </summary>
	public static void SetResolveCoincidentTopologyLineOffsetParameters(double factor, double units)
	{
		vtkMapper_SetResolveCoincidentTopologyLineOffsetParameters_81(factor, units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyPointOffsetParameter_82(double units);

	/// <summary>
	/// Used to set the point offset value
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// These are global variables.
	/// </summary>
	public static void SetResolveCoincidentTopologyPointOffsetParameter(double units)
	{
		vtkMapper_SetResolveCoincidentTopologyPointOffsetParameter_82(units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_83(int faces);

	/// <summary>
	/// Used when ResolveCoincidentTopology is set to PolygonOffset. The polygon
	/// offset can be applied either to the solid polygonal faces or the
	/// lines/vertices. When set (default), the offset is applied to the faces
	/// otherwise it is applied to lines and vertices.
	/// This is a global variable.
	/// </summary>
	public static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)
	{
		vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_83(faces);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_84(double factor, double units);

	/// <summary>
	/// Used to set the polygon offset scale factor and units.
	/// Used when ResolveCoincidentTopology is set to PolygonOffset.
	/// These are global variables.
	/// </summary>
	public static void SetResolveCoincidentTopologyPolygonOffsetParameters(double factor, double units)
	{
		vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_84(factor, units);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyToDefault_85();

	/// <summary>
	/// Set/Get a global flag that controls whether coincident topology (e.g., a
	/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
	/// hence rendering problems). If not off, there are two methods to choose
	/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
	/// and points from each other. ShiftZBuffer is a legacy method that used to
	/// remap the z-buffer to distinguish vertices, lines, and polygons, but
	/// does not always produce acceptable results. You should only use the
	/// PolygonOffset method (or none) at this point.
	/// </summary>
	public static void SetResolveCoincidentTopologyToDefault()
	{
		vtkMapper_SetResolveCoincidentTopologyToDefault_85();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyToOff_86();

	/// <summary>
	/// Set/Get a global flag that controls whether coincident topology (e.g., a
	/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
	/// hence rendering problems). If not off, there are two methods to choose
	/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
	/// and points from each other. ShiftZBuffer is a legacy method that used to
	/// remap the z-buffer to distinguish vertices, lines, and polygons, but
	/// does not always produce acceptable results. You should only use the
	/// PolygonOffset method (or none) at this point.
	/// </summary>
	public static void SetResolveCoincidentTopologyToOff()
	{
		vtkMapper_SetResolveCoincidentTopologyToOff_86();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_87();

	/// <summary>
	/// Set/Get a global flag that controls whether coincident topology (e.g., a
	/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
	/// hence rendering problems). If not off, there are two methods to choose
	/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
	/// and points from each other. ShiftZBuffer is a legacy method that used to
	/// remap the z-buffer to distinguish vertices, lines, and polygons, but
	/// does not always produce acceptable results. You should only use the
	/// PolygonOffset method (or none) at this point.
	/// </summary>
	public static void SetResolveCoincidentTopologyToPolygonOffset()
	{
		vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_87();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_88();

	/// <summary>
	/// Set/Get a global flag that controls whether coincident topology (e.g., a
	/// line on top of a polygon) is shifted to avoid z-buffer resolution (and
	/// hence rendering problems). If not off, there are two methods to choose
	/// from. PolygonOffset uses graphics systems calls to shift polygons, lines
	/// and points from each other. ShiftZBuffer is a legacy method that used to
	/// remap the z-buffer to distinguish vertices, lines, and polygons, but
	/// does not always produce acceptable results. You should only use the
	/// PolygonOffset method (or none) at this point.
	/// </summary>
	public static void SetResolveCoincidentTopologyToShiftZBuffer()
	{
		vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_88();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetResolveCoincidentTopologyZShift_89(double val);

	/// <summary>
	/// Used to set the z-shift if ResolveCoincidentTopology is set to
	/// ShiftZBuffer. This is a global variable.
	/// </summary>
	public static void SetResolveCoincidentTopologyZShift(double val)
	{
		vtkMapper_SetResolveCoincidentTopologyZShift_89(val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarMode_90(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkMapper_SetScalarMode_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarModeToDefault_91(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToDefault()
	{
		vtkMapper_SetScalarModeToDefault_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarModeToUseCellData_92(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUseCellData()
	{
		vtkMapper_SetScalarModeToUseCellData_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarModeToUseCellFieldData_93(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUseCellFieldData()
	{
		vtkMapper_SetScalarModeToUseCellFieldData_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarModeToUseFieldData_94(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUseFieldData()
	{
		vtkMapper_SetScalarModeToUseFieldData_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarModeToUsePointData_95(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUsePointData()
	{
		vtkMapper_SetScalarModeToUsePointData_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarModeToUsePointFieldData_96(HandleRef pThis);

	/// <summary>
	/// Control how the filter works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the filter will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the filter to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectColorArray before you call
	/// GetColors.
	/// </summary>
	public void SetScalarModeToUsePointFieldData()
	{
		vtkMapper_SetScalarModeToUsePointFieldData_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarRange_97(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkMapper_SetScalarRange_97(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarRange_98(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify range in terms of scalar minimum and maximum (smin,smax). These
	/// values are used to map scalars into lookup table. Has no effect when
	/// UseLookupTableScalarRange is true.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkMapper_SetScalarRange_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetScalarVisibility_99(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void SetScalarVisibility(int _arg)
	{
		vtkMapper_SetScalarVisibility_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetSelection_100(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get selection used to display particular points or cells in a second pass.
	/// This can be use to efficiently display a selection.
	/// </summary>
	public virtual void SetSelection(vtkSelection arg0)
	{
		vtkMapper_SetSelection_100(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetStatic_101(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag to control whether the mapper's data is static. Static data
	/// means that the mapper does not propagate updates down the pipeline, greatly
	/// decreasing the time it takes to update many mappers. This should only be
	/// used if the data never changes.
	/// </summary>
	public virtual void SetStatic(int _arg)
	{
		vtkMapper_SetStatic_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_SetUseLookupTableScalarRange_102(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual void SetUseLookupTableScalarRange(int _arg)
	{
		vtkMapper_SetUseLookupTableScalarRange_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_ShallowCopy_103(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Make a shallow copy of this mapper.
	/// </summary>
	public override void ShallowCopy(vtkAbstractMapper m)
	{
		vtkMapper_ShallowCopy_103(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_StaticOff_104(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether the mapper's data is static. Static data
	/// means that the mapper does not propagate updates down the pipeline, greatly
	/// decreasing the time it takes to update many mappers. This should only be
	/// used if the data never changes.
	/// </summary>
	public virtual void StaticOff()
	{
		vtkMapper_StaticOff_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_StaticOn_105(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether the mapper's data is static. Static data
	/// means that the mapper does not propagate updates down the pipeline, greatly
	/// decreasing the time it takes to update many mappers. This should only be
	/// used if the data never changes.
	/// </summary>
	public virtual void StaticOn()
	{
		vtkMapper_StaticOn_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_UseLookupTableScalarRangeOff_106(HandleRef pThis);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual void UseLookupTableScalarRangeOff()
	{
		vtkMapper_UseLookupTableScalarRangeOff_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapper_UseLookupTableScalarRangeOn_107(HandleRef pThis);

	/// <summary>
	/// Control whether the mapper sets the lookuptable range based on its
	/// own ScalarRange, or whether it will use the LookupTable ScalarRange
	/// regardless of it's own setting. By default the Mapper is allowed to set
	/// the LookupTable range, but users who are sharing LookupTables between
	/// mappers/actors will probably wish to force the mapper to use the
	/// LookupTable unchanged.
	/// </summary>
	public virtual void UseLookupTableScalarRangeOn()
	{
		vtkMapper_UseLookupTableScalarRangeOn_107(GetCppThis());
	}
}
