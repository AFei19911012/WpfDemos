using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageNoiseSource
/// </summary>
/// <remarks>
///    Create an image filled with noise.
///
/// vtkImageNoiseSource just produces images filled with noise.  The only
/// option now is uniform noise specified by a min and a max.  There is one
/// major problem with this source. Every time it executes, it will output
/// different pixel values.  This has important implications when a stream
/// requests overlapping regions.  The same pixels will have different values
/// on different updates.
/// </remarks>
public class vtkImageNoiseSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageNoiseSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageNoiseSource()
	{
		MRClassNameKey = "class vtkImageNoiseSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNoiseSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageNoiseSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageNoiseSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageNoiseSource New()
	{
		vtkImageNoiseSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageNoiseSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageNoiseSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageNoiseSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageNoiseSource_GetMaximum_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum values for the generated noise.
	/// </summary>
	public virtual double GetMaximum()
	{
		return vtkImageNoiseSource_GetMaximum_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageNoiseSource_GetMinimum_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum values for the generated noise.
	/// </summary>
	public virtual double GetMinimum()
	{
		return vtkImageNoiseSource_GetMinimum_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageNoiseSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageNoiseSource_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageNoiseSource_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageNoiseSource_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNoiseSource_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageNoiseSource_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageNoiseSource_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageNoiseSource_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageNoiseSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageNoiseSource NewInstance()
	{
		vtkImageNoiseSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageNoiseSource_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageNoiseSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageNoiseSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageNoiseSource vtkImageNoiseSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageNoiseSource_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageNoiseSource2 = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageNoiseSource2.Register(null);
			}
		}
		return vtkImageNoiseSource2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNoiseSource_SetMaximum_10(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum and maximum values for the generated noise.
	/// </summary>
	public virtual void SetMaximum(double _arg)
	{
		vtkImageNoiseSource_SetMaximum_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNoiseSource_SetMinimum_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum and maximum values for the generated noise.
	/// </summary>
	public virtual void SetMinimum(double _arg)
	{
		vtkImageNoiseSource_SetMinimum_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNoiseSource_SetWholeExtent_12(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

	/// <summary>
	/// Set how large of an image to generate.
	/// </summary>
	public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
	{
		vtkImageNoiseSource_SetWholeExtent_12(GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageNoiseSource_SetWholeExtent_13(HandleRef pThis, IntPtr ext);

	/// <summary>
	/// Set how large of an image to generate.
	/// </summary>
	public void SetWholeExtent(IntPtr ext)
	{
		vtkImageNoiseSource_SetWholeExtent_13(GetCppThis(), ext);
	}
}
