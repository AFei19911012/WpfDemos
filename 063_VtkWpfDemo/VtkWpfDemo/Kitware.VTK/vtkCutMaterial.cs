using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCutMaterial
/// </summary>
/// <remarks>
///    Automatically computes the cut plane for a material array pair.
///
/// vtkCutMaterial computes a cut plane based on an up vector, center of the bounding box
/// and the location of the maximum variable value.
///  These computed values are available so that they can be used to set the camera
/// for the best view of the plane.
/// </remarks>
public class vtkCutMaterial : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCutMaterial";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCutMaterial()
	{
		MRClassNameKey = "class vtkCutMaterial";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCutMaterial"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCutMaterial(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCutMaterial New()
	{
		vtkCutMaterial result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutMaterial_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCutMaterial()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCutMaterial_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_GetArrayName_01(HandleRef pThis);

	/// <summary>
	/// For now, we just use the cell values.
	/// The array name to cut.
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCutMaterial_GetArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_GetCenterPoint_02(HandleRef pThis);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual double[] GetCenterPoint()
	{
		IntPtr intPtr = vtkCutMaterial_GetCenterPoint_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetCenterPoint_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual void GetCenterPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCutMaterial_GetCenterPoint_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetCenterPoint_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual void GetCenterPoint(IntPtr _arg)
	{
		vtkCutMaterial_GetCenterPoint_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutMaterial_GetMaterial_05(HandleRef pThis);

	/// <summary>
	/// Material to probe.
	/// </summary>
	public virtual int GetMaterial()
	{
		return vtkCutMaterial_GetMaterial_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_GetMaterialArrayName_06(HandleRef pThis);

	/// <summary>
	/// Cell array that contains the material values.
	/// </summary>
	public virtual string GetMaterialArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCutMaterial_GetMaterialArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_GetMaximumPoint_07(HandleRef pThis);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual double[] GetMaximumPoint()
	{
		IntPtr intPtr = vtkCutMaterial_GetMaximumPoint_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetMaximumPoint_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual void GetMaximumPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCutMaterial_GetMaximumPoint_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetMaximumPoint_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual void GetMaximumPoint(IntPtr _arg)
	{
		vtkCutMaterial_GetMaximumPoint_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_GetNormal_10(HandleRef pThis);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkCutMaterial_GetNormal_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetNormal_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCutMaterial_GetNormal_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetNormal_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Accesses to the values computed during the execute method.  They
	/// could be used to get a good camera view for the resulting plane.
	/// </summary>
	public virtual void GetNormal(IntPtr _arg)
	{
		vtkCutMaterial_GetNormal_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCutMaterial_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCutMaterial_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCutMaterial_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCutMaterial_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_GetUpVector_15(HandleRef pThis);

	/// <summary>
	/// The last piece of information that specifies the plane.
	/// </summary>
	public virtual double[] GetUpVector()
	{
		IntPtr intPtr = vtkCutMaterial_GetUpVector_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetUpVector_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The last piece of information that specifies the plane.
	/// </summary>
	public virtual void GetUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCutMaterial_GetUpVector_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_GetUpVector_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The last piece of information that specifies the plane.
	/// </summary>
	public virtual void GetUpVector(IntPtr _arg)
	{
		vtkCutMaterial_GetUpVector_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutMaterial_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCutMaterial_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCutMaterial_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCutMaterial_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCutMaterial NewInstance()
	{
		vtkCutMaterial result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutMaterial_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCutMaterial_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCutMaterial SafeDownCast(vtkObjectBase o)
	{
		vtkCutMaterial vtkCutMaterial2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCutMaterial_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCutMaterial2 = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCutMaterial2.Register(null);
			}
		}
		return vtkCutMaterial2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_SetArrayName_23(HandleRef pThis, string _arg);

	/// <summary>
	/// For now, we just use the cell values.
	/// The array name to cut.
	/// </summary>
	public virtual void SetArrayName(string _arg)
	{
		vtkCutMaterial_SetArrayName_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_SetMaterial_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Material to probe.
	/// </summary>
	public virtual void SetMaterial(int _arg)
	{
		vtkCutMaterial_SetMaterial_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_SetMaterialArrayName_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Cell array that contains the material values.
	/// </summary>
	public virtual void SetMaterialArrayName(string _arg)
	{
		vtkCutMaterial_SetMaterialArrayName_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_SetUpVector_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The last piece of information that specifies the plane.
	/// </summary>
	public virtual void SetUpVector(double _arg1, double _arg2, double _arg3)
	{
		vtkCutMaterial_SetUpVector_26(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCutMaterial_SetUpVector_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The last piece of information that specifies the plane.
	/// </summary>
	public virtual void SetUpVector(IntPtr _arg)
	{
		vtkCutMaterial_SetUpVector_27(GetCppThis(), _arg);
	}
}
