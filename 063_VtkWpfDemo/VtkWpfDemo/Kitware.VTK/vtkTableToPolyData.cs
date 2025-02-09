using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTableToPolyData
/// </summary>
/// <remarks>
///    filter used to convert a vtkTable to a vtkPolyData
/// consisting of vertices.
///
/// vtkTableToPolyData is a filter used to convert a vtkTable  to a vtkPolyData
/// consisting of vertices.
/// </remarks>
public class vtkTableToPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTableToPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTableToPolyData()
	{
		MRClassNameKey = "class vtkTableToPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTableToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableToPolyData New()
	{
		vtkTableToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTableToPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTableToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_Create2DPointsOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether the points of the polydata are 3D or 2D. If this is set to
	/// true then the Z Column will be ignored and the z value of each point on the
	/// polydata will be set to 0. By default this will be off.
	/// </summary>
	public virtual void Create2DPointsOff()
	{
		vtkTableToPolyData_Create2DPointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_Create2DPointsOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether the points of the polydata are 3D or 2D. If this is set to
	/// true then the Z Column will be ignored and the z value of each point on the
	/// polydata will be set to 0. By default this will be off.
	/// </summary>
	public virtual void Create2DPointsOn()
	{
		vtkTableToPolyData_Create2DPointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableToPolyData_GetCreate2DPoints_03(HandleRef pThis);

	/// <summary>
	/// Specify whether the points of the polydata are 3D or 2D. If this is set to
	/// true then the Z Column will be ignored and the z value of each point on the
	/// polydata will be set to 0. By default this will be off.
	/// </summary>
	public virtual bool GetCreate2DPoints()
	{
		return (vtkTableToPolyData_GetCreate2DPoints_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableToPolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTableToPolyData_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableToPolyData_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTableToPolyData_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableToPolyData_GetPreserveCoordinateColumnsAsDataArrays_06(HandleRef pThis);

	/// <summary>
	/// Allow user to keep columns specified as X,Y,Z as Data arrays.
	/// By default this will be off.
	/// </summary>
	public virtual bool GetPreserveCoordinateColumnsAsDataArrays()
	{
		return (vtkTableToPolyData_GetPreserveCoordinateColumnsAsDataArrays_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToPolyData_GetXColumn_07(HandleRef pThis);

	/// <summary>
	/// Set the name of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual string GetXColumn()
	{
		return Marshal.PtrToStringAnsi(vtkTableToPolyData_GetXColumn_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetXColumnIndex_08(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual int GetXColumnIndex()
	{
		return vtkTableToPolyData_GetXColumnIndex_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetXColumnIndexMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual int GetXColumnIndexMaxValue()
	{
		return vtkTableToPolyData_GetXColumnIndexMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetXColumnIndexMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual int GetXColumnIndexMinValue()
	{
		return vtkTableToPolyData_GetXColumnIndexMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetXComponent_11(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual int GetXComponent()
	{
		return vtkTableToPolyData_GetXComponent_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetXComponentMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual int GetXComponentMaxValue()
	{
		return vtkTableToPolyData_GetXComponentMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetXComponentMinValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual int GetXComponentMinValue()
	{
		return vtkTableToPolyData_GetXComponentMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToPolyData_GetYColumn_14(HandleRef pThis);

	/// <summary>
	/// Set the name of the column to use as the Y coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual string GetYColumn()
	{
		return Marshal.PtrToStringAnsi(vtkTableToPolyData_GetYColumn_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetYColumnIndex_15(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the Y coordinate for the points.
	/// </summary>
	public virtual int GetYColumnIndex()
	{
		return vtkTableToPolyData_GetYColumnIndex_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetYColumnIndexMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the Y coordinate for the points.
	/// </summary>
	public virtual int GetYColumnIndexMaxValue()
	{
		return vtkTableToPolyData_GetYColumnIndexMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetYColumnIndexMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the Y coordinate for the points.
	/// </summary>
	public virtual int GetYColumnIndexMinValue()
	{
		return vtkTableToPolyData_GetYColumnIndexMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetYComponent_18(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetYComponent()
	{
		return vtkTableToPolyData_GetYComponent_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetYComponentMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetYComponentMaxValue()
	{
		return vtkTableToPolyData_GetYComponentMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetYComponentMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetYComponentMinValue()
	{
		return vtkTableToPolyData_GetYComponentMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToPolyData_GetZColumn_21(HandleRef pThis);

	/// <summary>
	/// Set the name of the column to use as the Z coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual string GetZColumn()
	{
		return Marshal.PtrToStringAnsi(vtkTableToPolyData_GetZColumn_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetZColumnIndex_22(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the Z coordinate for the points.
	/// </summary>
	public virtual int GetZColumnIndex()
	{
		return vtkTableToPolyData_GetZColumnIndex_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetZColumnIndexMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the Z coordinate for the points.
	/// </summary>
	public virtual int GetZColumnIndexMaxValue()
	{
		return vtkTableToPolyData_GetZColumnIndexMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetZColumnIndexMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set the index of the column to use as the Z coordinate for the points.
	/// </summary>
	public virtual int GetZColumnIndexMinValue()
	{
		return vtkTableToPolyData_GetZColumnIndexMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetZComponent_25(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetZComponent()
	{
		return vtkTableToPolyData_GetZComponent_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetZComponentMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetZComponentMaxValue()
	{
		return vtkTableToPolyData_GetZComponentMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_GetZComponentMinValue_27(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetZComponentMinValue()
	{
		return vtkTableToPolyData_GetZComponentMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTableToPolyData_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToPolyData_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTableToPolyData_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToPolyData_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTableToPolyData NewInstance()
	{
		vtkTableToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToPolyData_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOff_32(HandleRef pThis);

	/// <summary>
	/// Allow user to keep columns specified as X,Y,Z as Data arrays.
	/// By default this will be off.
	/// </summary>
	public virtual void PreserveCoordinateColumnsAsDataArraysOff()
	{
		vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOn_33(HandleRef pThis);

	/// <summary>
	/// Allow user to keep columns specified as X,Y,Z as Data arrays.
	/// By default this will be off.
	/// </summary>
	public virtual void PreserveCoordinateColumnsAsDataArraysOn()
	{
		vtkTableToPolyData_PreserveCoordinateColumnsAsDataArraysOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToPolyData_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableToPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkTableToPolyData vtkTableToPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToPolyData_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTableToPolyData2 = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTableToPolyData2.Register(null);
			}
		}
		return vtkTableToPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetCreate2DPoints_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether the points of the polydata are 3D or 2D. If this is set to
	/// true then the Z Column will be ignored and the z value of each point on the
	/// polydata will be set to 0. By default this will be off.
	/// </summary>
	public virtual void SetCreate2DPoints(bool _arg)
	{
		vtkTableToPolyData_SetCreate2DPoints_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetPreserveCoordinateColumnsAsDataArrays_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Allow user to keep columns specified as X,Y,Z as Data arrays.
	/// By default this will be off.
	/// </summary>
	public virtual void SetPreserveCoordinateColumnsAsDataArrays(bool _arg)
	{
		vtkTableToPolyData_SetPreserveCoordinateColumnsAsDataArrays_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetXColumn_37(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual void SetXColumn(string _arg)
	{
		vtkTableToPolyData_SetXColumn_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetXColumnIndex_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the index of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual void SetXColumnIndex(int _arg)
	{
		vtkTableToPolyData_SetXColumnIndex_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetXComponent_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual void SetXComponent(int _arg)
	{
		vtkTableToPolyData_SetXComponent_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetYColumn_40(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the column to use as the Y coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual void SetYColumn(string _arg)
	{
		vtkTableToPolyData_SetYColumn_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetYColumnIndex_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the index of the column to use as the Y coordinate for the points.
	/// </summary>
	public virtual void SetYColumnIndex(int _arg)
	{
		vtkTableToPolyData_SetYColumnIndex_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetYComponent_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual void SetYComponent(int _arg)
	{
		vtkTableToPolyData_SetYComponent_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetZColumn_43(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the column to use as the Z coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual void SetZColumn(string _arg)
	{
		vtkTableToPolyData_SetZColumn_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetZColumnIndex_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the index of the column to use as the Z coordinate for the points.
	/// </summary>
	public virtual void SetZColumnIndex(int _arg)
	{
		vtkTableToPolyData_SetZColumnIndex_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToPolyData_SetZComponent_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual void SetZComponent(int _arg)
	{
		vtkTableToPolyData_SetZComponent_45(GetCppThis(), _arg);
	}
}
