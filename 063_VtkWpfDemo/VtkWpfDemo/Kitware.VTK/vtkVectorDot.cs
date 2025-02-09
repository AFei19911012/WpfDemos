using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVectorDot
/// </summary>
/// <remarks>
///    generate scalars from dot product of vectors and normals (e.g., show displacement plot)
///
/// vtkVectorDot is a filter to generate point scalar values from a dataset.
/// The scalar value at a point is created by computing the dot product
/// between the normal and vector at each point. Combined with the appropriate
/// color map, this can show nodal lines/mode shapes of vibration, or a
/// displacement plot.
///
/// Note that by default the resulting scalars are mapped into a specified
/// range. This requires an extra pass in the algorithm. This mapping pass can
/// be disabled (set MapScalars to off).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
/// </remarks>
public class vtkVectorDot : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVectorDot";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVectorDot()
	{
		MRClassNameKey = "class vtkVectorDot";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorDot"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVectorDot(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorDot_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with scalar range (-1,1).
	/// </summary>
	public new static vtkVectorDot New()
	{
		vtkVectorDot result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorDot_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVectorDot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with scalar range (-1,1).
	/// </summary>
	public vtkVectorDot()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVectorDot_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorDot_GetActualRange_01(HandleRef pThis);

	/// <summary>
	/// Return the actual range of the generated scalars (prior to mapping).
	/// Note that the data is valid only after the filter executes.
	/// </summary>
	public virtual double[] GetActualRange()
	{
		IntPtr intPtr = vtkVectorDot_GetActualRange_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_GetActualRange_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Return the actual range of the generated scalars (prior to mapping).
	/// Note that the data is valid only after the filter executes.
	/// </summary>
	public virtual void GetActualRange(IntPtr data)
	{
		vtkVectorDot_GetActualRange_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorDot_GetMapScalars_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable the mapping of scalars into a specified range. This will
	/// significantly improve the performance of the algorithm but the resulting
	/// scalar values will strictly be a function of the vector and normal
	/// data. By default, MapScalars is enabled, and the output scalar
	/// values will fall into the range ScalarRange.
	/// </summary>
	public virtual int GetMapScalars()
	{
		return vtkVectorDot_GetMapScalars_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVectorDot_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVectorDot_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVectorDot_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVectorDot_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorDot_GetScalarRange_06(HandleRef pThis);

	/// <summary>
	/// Specify the range into which to map the scalars. This mapping only
	/// occurs if MapScalars is enabled.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkVectorDot_GetScalarRange_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_GetScalarRange_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the range into which to map the scalars. This mapping only
	/// occurs if MapScalars is enabled.
	/// </summary>
	public virtual void GetScalarRange(IntPtr data)
	{
		vtkVectorDot_GetScalarRange_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorDot_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVectorDot_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVectorDot_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVectorDot_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_MapScalarsOff_10(HandleRef pThis);

	/// <summary>
	/// Enable/disable the mapping of scalars into a specified range. This will
	/// significantly improve the performance of the algorithm but the resulting
	/// scalar values will strictly be a function of the vector and normal
	/// data. By default, MapScalars is enabled, and the output scalar
	/// values will fall into the range ScalarRange.
	/// </summary>
	public virtual void MapScalarsOff()
	{
		vtkVectorDot_MapScalarsOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_MapScalarsOn_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable the mapping of scalars into a specified range. This will
	/// significantly improve the performance of the algorithm but the resulting
	/// scalar values will strictly be a function of the vector and normal
	/// data. By default, MapScalars is enabled, and the output scalar
	/// values will fall into the range ScalarRange.
	/// </summary>
	public virtual void MapScalarsOn()
	{
		vtkVectorDot_MapScalarsOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorDot_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVectorDot NewInstance()
	{
		vtkVectorDot result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorDot_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVectorDot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVectorDot_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVectorDot SafeDownCast(vtkObjectBase o)
	{
		vtkVectorDot vtkVectorDot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVectorDot_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVectorDot2 = (vtkVectorDot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVectorDot2.Register(null);
			}
		}
		return vtkVectorDot2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_SetMapScalars_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the mapping of scalars into a specified range. This will
	/// significantly improve the performance of the algorithm but the resulting
	/// scalar values will strictly be a function of the vector and normal
	/// data. By default, MapScalars is enabled, and the output scalar
	/// values will fall into the range ScalarRange.
	/// </summary>
	public virtual void SetMapScalars(int _arg)
	{
		vtkVectorDot_SetMapScalars_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_SetScalarRange_16(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the range into which to map the scalars. This mapping only
	/// occurs if MapScalars is enabled.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkVectorDot_SetScalarRange_16(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVectorDot_SetScalarRange_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the range into which to map the scalars. This mapping only
	/// occurs if MapScalars is enabled.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkVectorDot_SetScalarRange_17(GetCppThis(), _arg);
	}
}
