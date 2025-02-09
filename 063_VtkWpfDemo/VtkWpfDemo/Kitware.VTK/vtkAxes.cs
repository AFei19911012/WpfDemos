using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxes
/// </summary>
/// <remarks>
///    create an x-y-z axes
///
/// vtkAxes creates three lines that form an x-y-z axes. The origin of the
/// axes is user specified (0,0,0 is default), and the size is specified with
/// a scale factor. Three scalar values are generated for the three lines and
/// can be used (via color map) to indicate a particular coordinate axis.
/// </remarks>
public class vtkAxes : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxes()
	{
		MRClassNameKey = "class vtkAxes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxes New()
	{
		vtkAxes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAxes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAxes_ComputeNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Option for computing normals.  By default they are computed.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkAxes_ComputeNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_ComputeNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Option for computing normals.  By default they are computed.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkAxes_ComputeNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxes_GetComputeNormals_03(HandleRef pThis);

	/// <summary>
	/// Option for computing normals.  By default they are computed.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkAxes_GetComputeNormals_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxes_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxes_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxes_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxes_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxes_GetOrigin_06(HandleRef pThis);

	/// <summary>
	/// Set the origin of the axes.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkAxes_GetOrigin_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_GetOrigin_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the origin of the axes.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkAxes_GetOrigin_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxes_GetScaleFactor_08(HandleRef pThis);

	/// <summary>
	/// Set the scale factor of the axes. Used to control size.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkAxes_GetScaleFactor_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxes_GetSymmetric_09(HandleRef pThis);

	/// <summary>
	/// If Symmetric is on, the axis continue to negative values.
	/// </summary>
	public virtual int GetSymmetric()
	{
		return vtkAxes_GetSymmetric_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxes_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxes_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxes_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxes_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxes_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxes NewInstance()
	{
		vtkAxes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxes_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxes_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxes SafeDownCast(vtkObjectBase o)
	{
		vtkAxes vtkAxes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxes_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxes2 = (vtkAxes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxes2.Register(null);
			}
		}
		return vtkAxes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SetComputeNormals_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Option for computing normals.  By default they are computed.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkAxes_SetComputeNormals_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SetOrigin_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the origin of the axes.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkAxes_SetOrigin_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SetOrigin_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the origin of the axes.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkAxes_SetOrigin_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SetScaleFactor_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the scale factor of the axes. Used to control size.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkAxes_SetScaleFactor_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SetSymmetric_19(HandleRef pThis, int _arg);

	/// <summary>
	/// If Symmetric is on, the axis continue to negative values.
	/// </summary>
	public virtual void SetSymmetric(int _arg)
	{
		vtkAxes_SetSymmetric_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SymmetricOff_20(HandleRef pThis);

	/// <summary>
	/// If Symmetric is on, the axis continue to negative values.
	/// </summary>
	public virtual void SymmetricOff()
	{
		vtkAxes_SymmetricOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxes_SymmetricOn_21(HandleRef pThis);

	/// <summary>
	/// If Symmetric is on, the axis continue to negative values.
	/// </summary>
	public virtual void SymmetricOn()
	{
		vtkAxes_SymmetricOn_21(GetCppThis());
	}
}
