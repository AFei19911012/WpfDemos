using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCityGMLReader
/// </summary>
/// <remarks>
///    read CityGML data file
///
/// </remarks>
public class vtkCityGMLReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCityGMLReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCityGMLReader()
	{
		MRClassNameKey = "class vtkCityGMLReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCityGMLReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCityGMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCityGMLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCityGMLReader New()
	{
		vtkCityGMLReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCityGMLReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCityGMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCityGMLReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCityGMLReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetBeginBuildingIndex_01(HandleRef pThis);

	/// <summary>
	/// Read a range of buildings from the file [begin, end)
	/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
	/// will read all buildings from the file.
	/// </summary>
	public virtual int GetBeginBuildingIndex()
	{
		return vtkCityGMLReader_GetBeginBuildingIndex_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetEndBuildingIndex_02(HandleRef pThis);

	/// <summary>
	/// Read a range of buildings from the file [begin, end)
	/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
	/// will read all buildings from the file.
	/// </summary>
	public virtual int GetEndBuildingIndex()
	{
		return vtkCityGMLReader_GetEndBuildingIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCityGMLReader_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify file name of the CityGML data file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkCityGMLReader_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetLOD_04(HandleRef pThis);

	/// <summary>
	/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
	/// through 4 (most detailed), default value is 3.
	/// </summary>
	public virtual int GetLOD()
	{
		return vtkCityGMLReader_GetLOD_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetLODMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
	/// through 4 (most detailed), default value is 3.
	/// </summary>
	public virtual int GetLODMaxValue()
	{
		return vtkCityGMLReader_GetLODMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetLODMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
	/// through 4 (most detailed), default value is 3.
	/// </summary>
	public virtual int GetLODMinValue()
	{
		return vtkCityGMLReader_GetLODMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetNumberOfBuildings_07(HandleRef pThis);

	/// <summary>
	/// Number of buildings read from the file.
	/// Default is numeric_limits&lt;int&gt;::max() which means the reader will read all
	/// buildings from the file. You can set either NumberOfBuidlings to read the range
	/// [0, NumberOfBuildings) or you can set BeginBuildingIndex and EndBuildingIndex to
	/// read the range [BeginBuildingIndex, EndBuildingIndex). If you send them both,
	/// a warning will be printed and we'll use the latter.
	/// </summary>
	public virtual int GetNumberOfBuildings()
	{
		return vtkCityGMLReader_GetNumberOfBuildings_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCityGMLReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCityGMLReader_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCityGMLReader_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCityGMLReader_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_GetUseTransparencyAsOpacity_10(HandleRef pThis);

	/// <summary>
	/// Certain input files use app:transparency as opacity. Set this field true
	/// to show that correctly. The default is false.
	/// </summary>
	public virtual int GetUseTransparencyAsOpacity()
	{
		return vtkCityGMLReader_GetUseTransparencyAsOpacity_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCityGMLReader_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCityGMLReader_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCityGMLReader_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCityGMLReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCityGMLReader NewInstance()
	{
		vtkCityGMLReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCityGMLReader_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCityGMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCityGMLReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCityGMLReader SafeDownCast(vtkObjectBase o)
	{
		vtkCityGMLReader vtkCityGMLReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCityGMLReader_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCityGMLReader2 = (vtkCityGMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCityGMLReader2.Register(null);
			}
		}
		return vtkCityGMLReader2;
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_SetBeginBuildingIndex_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Read a range of buildings from the file [begin, end)
	/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
	/// will read all buildings from the file.
	/// </summary>
	public virtual void SetBeginBuildingIndex(int _arg)
	{
		vtkCityGMLReader_SetBeginBuildingIndex_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_SetEndBuildingIndex_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Read a range of buildings from the file [begin, end)
	/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
	/// will read all buildings from the file.
	/// </summary>
	public virtual void SetEndBuildingIndex(int _arg)
	{
		vtkCityGMLReader_SetEndBuildingIndex_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_SetFileName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of the CityGML data file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkCityGMLReader_SetFileName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_SetLOD_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
	/// through 4 (most detailed), default value is 3.
	/// </summary>
	public virtual void SetLOD(int _arg)
	{
		vtkCityGMLReader_SetLOD_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_SetNumberOfBuildings_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Number of buildings read from the file.
	/// Default is numeric_limits&lt;int&gt;::max() which means the reader will read all
	/// buildings from the file. You can set either NumberOfBuidlings to read the range
	/// [0, NumberOfBuildings) or you can set BeginBuildingIndex and EndBuildingIndex to
	/// read the range [BeginBuildingIndex, EndBuildingIndex). If you send them both,
	/// a warning will be printed and we'll use the latter.
	/// </summary>
	public virtual void SetNumberOfBuildings(int _arg)
	{
		vtkCityGMLReader_SetNumberOfBuildings_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_SetUseTransparencyAsOpacity_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Certain input files use app:transparency as opacity. Set this field true
	/// to show that correctly. The default is false.
	/// </summary>
	public virtual void SetUseTransparencyAsOpacity(int _arg)
	{
		vtkCityGMLReader_SetUseTransparencyAsOpacity_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_UseTransparencyAsOpacityOff_22(HandleRef pThis);

	/// <summary>
	/// Certain input files use app:transparency as opacity. Set this field true
	/// to show that correctly. The default is false.
	/// </summary>
	public virtual void UseTransparencyAsOpacityOff()
	{
		vtkCityGMLReader_UseTransparencyAsOpacityOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCityGMLReader_UseTransparencyAsOpacityOn_23(HandleRef pThis);

	/// <summary>
	/// Certain input files use app:transparency as opacity. Set this field true
	/// to show that correctly. The default is false.
	/// </summary>
	public virtual void UseTransparencyAsOpacityOn()
	{
		vtkCityGMLReader_UseTransparencyAsOpacityOn_23(GetCppThis());
	}
}
