using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgrammableGlyphFilter
/// </summary>
/// <remarks>
///    control the generation and placement of glyphs at input points
///
/// vtkProgrammableGlyphFilter is a filter that allows you to place a glyph at
/// each input point in the dataset. In addition, the filter is programmable
/// which means the user has control over the generation of the glyph. The
/// glyphs can be controlled via the point data attributes (e.g., scalars,
/// vectors, etc.) or any other information in the input dataset.
///
/// This is the way the filter works. You must define an input dataset which
/// at a minimum contains points with associated attribute values. Also, the
/// Source instance variable must be set which is of type vtkPolyData. Then,
/// for each point in the input, the PointId is set to the current point id,
/// and a user-defined function is called (i.e., GlyphMethod). In this method
/// you can manipulate the Source data (including changing to a different
/// Source object). After the GlyphMethod is called,
/// vtkProgrammableGlyphFilter will invoke an Update() on its Source object,
/// and then copy its data to the output of the
/// vtkProgrammableGlyphFilter. Therefore the output of this filter is of type
/// vtkPolyData.
///
/// Another option to this filter is the way you color the glyphs. You can use
/// the scalar data from the input or the source. The instance variable
/// ColorMode controls this behavior.
///
/// @warning
/// This filter operates on point data attributes. If you want to use cell
/// data attributes, use a filter like vtkCellCenters to generate points at
/// the centers of cells, and then use these points.
///
/// @warning
/// Note that the data attributes (cell and point) are passed to the output of
/// this filter from the Source object. This works well as long as you are not
/// changing the class of the Source object during execution. However, if the
/// class of the Source object changes, then the potential exists that the
/// data attributes might change during execution (e.g., scalars available
/// from one source and not the next), possibly fouling up the copying of data
/// attributes to the output. In this case, you may have to manually set the
/// output's copy flags (e.g., CopyScalarsOn/Off(), CopyVectorsOn/Off(), etc.)
/// to control what's being copied.
///
/// </remarks>
/// <seealso>
///
/// vtkGlyph3D vtkTensorGlyph vtkCellCenters
/// </seealso>
public class vtkProgrammableGlyphFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Signature definition for programmable method callbacks. Methods passed to
	/// SetGlyphMethod or SetGlyphMethodArgDelete must conform to this signature.
	/// The presence of this typedef is useful for reference and for external
	/// analysis tools, but it cannot be used in the method signatures in these
	/// header files themselves because it prevents the internal VTK wrapper
	/// generators from wrapping these methods.
	/// </summary>
	public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableGlyphFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgrammableGlyphFilter()
	{
		MRClassNameKey = "class vtkProgrammableGlyphFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableGlyphFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgrammableGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with nullptr GlyphMethod() and no source object. The ColorMode
	/// is set to color by the input.
	/// </summary>
	public new static vtkProgrammableGlyphFilter New()
	{
		vtkProgrammableGlyphFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with nullptr GlyphMethod() and no source object. The ColorMode
	/// is set to color by the input.
	/// </summary>
	public vtkProgrammableGlyphFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgrammableGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableGlyphFilter_GetColorMode_01(HandleRef pThis);

	/// <summary>
	/// Either color by the input or source scalar data.
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkProgrammableGlyphFilter_GetColorMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_GetColorModeAsString_02(HandleRef pThis);

	/// <summary>
	/// Either color by the input or source scalar data.
	/// </summary>
	public string GetColorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkProgrammableGlyphFilter_GetColorModeAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_GetPoint_05(HandleRef pThis);

	/// <summary>
	/// Get the current point coordinates during processing. Value only valid during the
	/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
	/// </summary>
	public virtual double[] GetPoint()
	{
		IntPtr intPtr = vtkProgrammableGlyphFilter_GetPoint_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_GetPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the current point coordinates during processing. Value only valid during the
	/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
	/// </summary>
	public virtual void GetPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProgrammableGlyphFilter_GetPoint_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_GetPoint_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the current point coordinates during processing. Value only valid during the
	/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
	/// </summary>
	public virtual void GetPoint(IntPtr _arg)
	{
		vtkProgrammableGlyphFilter_GetPoint_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_GetPointData_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the set of point data attributes for the input. A convenience to the
	/// programmer to be used in the GlyphMethod(). Only valid during the Execute()
	/// method of this filter.
	/// </summary>
	public virtual vtkPointData GetPointData()
	{
		vtkPointData vtkPointData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableGlyphFilter_GetPointData_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointData2 = (vtkPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointData2.Register(null);
			}
		}
		return vtkPointData2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableGlyphFilter_GetPointId_09(HandleRef pThis);

	/// <summary>
	/// Get the current point id during processing. Value only valid during the
	/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
	/// </summary>
	public virtual long GetPointId()
	{
		return vtkProgrammableGlyphFilter_GetPointId_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_GetSource_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the source to use for this glyph.
	/// Note that SetSourceData() does not set a pipeline connection but
	/// directly uses the polydata.
	/// </summary>
	public vtkPolyData GetSource()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableGlyphFilter_GetSource_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableGlyphFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgrammableGlyphFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableGlyphFilter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgrammableGlyphFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProgrammableGlyphFilter NewInstance()
	{
		vtkProgrammableGlyphFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableGlyphFilter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableGlyphFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableGlyphFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProgrammableGlyphFilter vtkProgrammableGlyphFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableGlyphFilter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgrammableGlyphFilter2 = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgrammableGlyphFilter2.Register(null);
			}
		}
		return vtkProgrammableGlyphFilter2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetColorMode_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Either color by the input or source scalar data.
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkProgrammableGlyphFilter_SetColorMode_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetColorModeToColorByInput_17(HandleRef pThis);

	/// <summary>
	/// Either color by the input or source scalar data.
	/// </summary>
	public void SetColorModeToColorByInput()
	{
		vtkProgrammableGlyphFilter_SetColorModeToColorByInput_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetColorModeToColorBySource_18(HandleRef pThis);

	/// <summary>
	/// Either color by the input or source scalar data.
	/// </summary>
	public void SetColorModeToColorBySource()
	{
		vtkProgrammableGlyphFilter_SetColorModeToColorBySource_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetGlyphMethod_19(HandleRef pThis, ProgrammableMethodCallbackType f, IntPtr arg);

	/// <summary>
	/// Specify function to be called for each input point.
	/// </summary>
	public void SetGlyphMethod(ProgrammableMethodCallbackType f, IntPtr arg)
	{
		vtkProgrammableGlyphFilter_SetGlyphMethod_19(GetCppThis(), f, arg);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetGlyphMethodArgDelete_20(HandleRef pThis, ProgrammableMethodCallbackType f);

	/// <summary>
	/// Set the arg delete method. This is used to free user memory that might
	/// be associated with the GlyphMethod().
	/// </summary>
	public void SetGlyphMethodArgDelete(ProgrammableMethodCallbackType f)
	{
		vtkProgrammableGlyphFilter_SetGlyphMethodArgDelete_20(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetSourceConnection_21(HandleRef pThis, HandleRef output);

	/// <summary>
	/// Setup a connection for the source to use as the glyph.
	/// Note: you can change the source during execution of this filter.
	/// This is equivalent to SetInputConnection(1, output);
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput output)
	{
		vtkProgrammableGlyphFilter_SetSourceConnection_21(GetCppThis(), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableGlyphFilter_SetSourceData_22(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Set/Get the source to use for this glyph.
	/// Note that SetSourceData() does not set a pipeline connection but
	/// directly uses the polydata.
	/// </summary>
	public void SetSourceData(vtkPolyData source)
	{
		vtkProgrammableGlyphFilter_SetSourceData_22(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
