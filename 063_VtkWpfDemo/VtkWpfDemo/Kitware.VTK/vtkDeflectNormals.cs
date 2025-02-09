using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDeflectNormals
/// </summary>
/// <remarks>
///    deflect normals using a 3 component vector field
///
/// vtkDeflectNormals is a filter that modifies the normals using a vector field.
/// It is useful to give a 3D perception of a flat surface using shading of the mapper.
///
/// The filter passes both its point data and cell data to its output.
/// </remarks>
public class vtkDeflectNormals : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDeflectNormals";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDeflectNormals()
	{
		MRClassNameKey = "class vtkDeflectNormals";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDeflectNormals"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDeflectNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeflectNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDeflectNormals New()
	{
		vtkDeflectNormals result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeflectNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDeflectNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDeflectNormals()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDeflectNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDeflectNormals_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDeflectNormals_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDeflectNormals_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDeflectNormals_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDeflectNormals_GetScaleFactor_03(HandleRef pThis);

	/// <summary>
	/// Specify value to scale deflection.
	/// Default is 1.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkDeflectNormals_GetScaleFactor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDeflectNormals_GetUseUserNormal_04(HandleRef pThis);

	/// <summary>
	/// Specify value of the user defined normal.
	/// Default is false.
	/// </summary>
	public virtual bool GetUseUserNormal()
	{
		return (vtkDeflectNormals_GetUseUserNormal_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeflectNormals_GetUserNormal_05(HandleRef pThis);

	/// <summary>
	/// Specify user defined normal.
	/// Default is (0, 0, 1).
	/// </summary>
	public virtual double[] GetUserNormal()
	{
		IntPtr intPtr = vtkDeflectNormals_GetUserNormal_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_GetUserNormal_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify user defined normal.
	/// Default is (0, 0, 1).
	/// </summary>
	public virtual void GetUserNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkDeflectNormals_GetUserNormal_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_GetUserNormal_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify user defined normal.
	/// Default is (0, 0, 1).
	/// </summary>
	public virtual void GetUserNormal(IntPtr _arg)
	{
		vtkDeflectNormals_GetUserNormal_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDeflectNormals_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDeflectNormals_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDeflectNormals_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDeflectNormals_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeflectNormals_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDeflectNormals NewInstance()
	{
		vtkDeflectNormals result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeflectNormals_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDeflectNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDeflectNormals_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDeflectNormals SafeDownCast(vtkObjectBase o)
	{
		vtkDeflectNormals vtkDeflectNormals2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDeflectNormals_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDeflectNormals2 = (vtkDeflectNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDeflectNormals2.Register(null);
			}
		}
		return vtkDeflectNormals2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_SetScaleFactor_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify value to scale deflection.
	/// Default is 1.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkDeflectNormals_SetScaleFactor_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_SetUseUserNormal_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify value of the user defined normal.
	/// Default is false.
	/// </summary>
	public virtual void SetUseUserNormal(bool _arg)
	{
		vtkDeflectNormals_SetUseUserNormal_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_SetUserNormal_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify user defined normal.
	/// Default is (0, 0, 1).
	/// </summary>
	public virtual void SetUserNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkDeflectNormals_SetUserNormal_15(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_SetUserNormal_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify user defined normal.
	/// Default is (0, 0, 1).
	/// </summary>
	public virtual void SetUserNormal(IntPtr _arg)
	{
		vtkDeflectNormals_SetUserNormal_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_UseUserNormalOff_17(HandleRef pThis);

	/// <summary>
	/// Specify value of the user defined normal.
	/// Default is false.
	/// </summary>
	public virtual void UseUserNormalOff()
	{
		vtkDeflectNormals_UseUserNormalOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDeflectNormals_UseUserNormalOn_18(HandleRef pThis);

	/// <summary>
	/// Specify value of the user defined normal.
	/// Default is false.
	/// </summary>
	public virtual void UseUserNormalOn()
	{
		vtkDeflectNormals_UseUserNormalOn_18(GetCppThis());
	}
}
