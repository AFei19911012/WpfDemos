using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractVolumeMapper
/// </summary>
/// <remarks>
///    Abstract class for a volume mapper
///
///
/// vtkAbstractVolumeMapper is the abstract definition of a volume mapper.
/// Specific subclasses deal with different specific types of data input
///
/// </remarks>
/// <seealso>
///
/// vtkVolumeMapper vtkUnstructuredGridVolumeMapper
/// </seealso>
public abstract class vtkAbstractVolumeMapper : vtkAbstractMapper3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractVolumeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractVolumeMapper()
	{
		MRClassNameKey = "class vtkAbstractVolumeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractVolumeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkAbstractVolumeMapper_GetArrayAccessMode_01(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to use for rendering.
	/// </summary>
	public virtual int GetArrayAccessMode()
	{
		return vtkAbstractVolumeMapper_GetArrayAccessMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractVolumeMapper_GetArrayId_02(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to use for rendering.
	/// </summary>
	public virtual int GetArrayId()
	{
		return vtkAbstractVolumeMapper_GetArrayId_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_GetArrayName_03(HandleRef pThis);

	/// <summary>
	/// Get the array name or number and component to use for rendering.
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractVolumeMapper_GetArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_GetBounds_04(HandleRef pThis);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkAbstractVolumeMapper_GetBounds_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkAbstractVolumeMapper_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_GetDataObjectInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual vtkDataObject GetDataObjectInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractVolumeMapper_GetDataObjectInput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_GetDataSetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual vtkDataSet GetDataSetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractVolumeMapper_GetDataSetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeBias_08(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// </summary>
	public virtual float GetGradientMagnitudeBias()
	{
		return vtkAbstractVolumeMapper_GetGradientMagnitudeBias_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeBias_09(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// </summary>
	public virtual float GetGradientMagnitudeBias(int arg0)
	{
		return vtkAbstractVolumeMapper_GetGradientMagnitudeBias_09(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeScale_10(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// </summary>
	public virtual float GetGradientMagnitudeScale()
	{
		return vtkAbstractVolumeMapper_GetGradientMagnitudeScale_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeScale_11(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// </summary>
	public virtual float GetGradientMagnitudeScale(int arg0)
	{
		return vtkAbstractVolumeMapper_GetGradientMagnitudeScale_11(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractVolumeMapper_GetScalarMode_14(HandleRef pThis);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkAbstractVolumeMapper_GetScalarMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_GetScalarModeAsString_15(HandleRef pThis);

	/// <summary>
	/// Return the method for obtaining scalar data.
	/// </summary>
	public string GetScalarModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractVolumeMapper_GetScalarModeAsString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractVolumeMapper_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractVolumeMapper_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractVolumeMapper_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractVolumeMapper_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractVolumeMapper NewInstance()
	{
		vtkAbstractVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractVolumeMapper_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAbstractVolumeMapper_ReleaseGraphicsResources_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_Render_20(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkAbstractVolumeMapper_Render_20(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractVolumeMapper_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractVolumeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractVolumeMapper vtkAbstractVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractVolumeMapper_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractVolumeMapper2 = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractVolumeMapper2.Register(null);
			}
		}
		return vtkAbstractVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SelectScalarArray_22(HandleRef pThis, int arrayNum);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which scalar array to use during rendering.
	/// The transfer function in the vtkVolumeProperty (attached to the calling
	/// vtkVolume) will decide how to convert vectors to colors.
	/// </summary>
	public virtual void SelectScalarArray(int arrayNum)
	{
		vtkAbstractVolumeMapper_SelectScalarArray_22(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SelectScalarArray_23(HandleRef pThis, string arrayName);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which scalar array to use during rendering.
	/// The transfer function in the vtkVolumeProperty (attached to the calling
	/// vtkVolume) will decide how to convert vectors to colors.
	/// </summary>
	public virtual void SelectScalarArray(string arrayName)
	{
		vtkAbstractVolumeMapper_SelectScalarArray_23(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetArrayAccessMode_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public virtual void SetArrayAccessMode(int _arg)
	{
		vtkAbstractVolumeMapper_SetArrayAccessMode_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetScalarMode_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkAbstractVolumeMapper_SetScalarMode_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetScalarModeToDefault_26(HandleRef pThis);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public void SetScalarModeToDefault()
	{
		vtkAbstractVolumeMapper_SetScalarModeToDefault_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUseCellData_27(HandleRef pThis);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public void SetScalarModeToUseCellData()
	{
		vtkAbstractVolumeMapper_SetScalarModeToUseCellData_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_28(HandleRef pThis);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public void SetScalarModeToUseCellFieldData()
	{
		vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUsePointData_29(HandleRef pThis);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public void SetScalarModeToUsePointData()
	{
		vtkAbstractVolumeMapper_SetScalarModeToUsePointData_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_30(HandleRef pThis);

	/// <summary>
	/// Control how the mapper works with scalar point data and cell attribute
	/// data.  By default (ScalarModeToDefault), the mapper will use point data,
	/// and if no point data is available, then cell data is used. Alternatively
	/// you can explicitly set the mapper to use point data
	/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
	/// You can also choose to get the scalars from an array in point field
	/// data (ScalarModeToUsePointFieldData) or cell field data
	/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
	/// data array, you must call SelectScalarArray.
	/// </summary>
	public void SetScalarModeToUsePointFieldData()
	{
		vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_30(GetCppThis());
	}
}
