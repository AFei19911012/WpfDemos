using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSeedConnectivity
/// </summary>
/// <remarks>
///    SeedConnectivity with user defined seeds.
///
/// vtkImageSeedConnectivity marks pixels connected to user supplied seeds.
/// The input must be unsigned char, and the output is also unsigned char.  If
/// a seed supplied by the user does not have pixel value "InputTrueValue",
/// then the image is scanned +x, +y, +z until a pixel is encountered with
/// value "InputTrueValue".  This new pixel is used as the seed .  Any pixel
/// with out value "InputTrueValue" is consider off.  The output pixels values
/// are 0 for any off pixel in input, "OutputTrueValue" for any pixels
/// connected to seeds, and "OutputUnconnectedValue" for any on pixels not
/// connected to seeds.  The same seeds are used for all images in the image
/// set.
/// </remarks>
public class vtkImageSeedConnectivity : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSeedConnectivity";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSeedConnectivity()
	{
		MRClassNameKey = "class vtkImageSeedConnectivity";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSeedConnectivity"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSeedConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeedConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSeedConnectivity New()
	{
		vtkImageSeedConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeedConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSeedConnectivity()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSeedConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_AddSeed_01(HandleRef pThis, int num, IntPtr index);

	/// <summary>
	/// Methods for manipulating the seed pixels.
	/// </summary>
	public void AddSeed(int num, IntPtr index)
	{
		vtkImageSeedConnectivity_AddSeed_01(GetCppThis(), num, index);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_AddSeed_02(HandleRef pThis, int i0, int i1, int i2);

	/// <summary>
	/// Methods for manipulating the seed pixels.
	/// </summary>
	public void AddSeed(int i0, int i1, int i2)
	{
		vtkImageSeedConnectivity_AddSeed_02(GetCppThis(), i0, i1, i2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_AddSeed_03(HandleRef pThis, int i0, int i1);

	/// <summary>
	/// Methods for manipulating the seed pixels.
	/// </summary>
	public void AddSeed(int i0, int i1)
	{
		vtkImageSeedConnectivity_AddSeed_03(GetCppThis(), i0, i1);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeedConnectivity_GetConnector_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkImageCOnnector used by this filter.
	/// </summary>
	public virtual vtkImageConnector GetConnector()
	{
		vtkImageConnector vtkImageConnector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeedConnectivity_GetConnector_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageConnector2 = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageConnector2.Register(null);
			}
		}
		return vtkImageConnector2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSeedConnectivity_GetDimensionality_05(HandleRef pThis);

	/// <summary>
	/// Set the number of axes to use in connectivity.
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageSeedConnectivity_GetDimensionality_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageSeedConnectivity_GetInputConnectValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get what value is considered as connecting pixels.
	/// </summary>
	public virtual byte GetInputConnectValue()
	{
		return vtkImageSeedConnectivity_GetInputConnectValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSeedConnectivity_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSeedConnectivity_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSeedConnectivity_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSeedConnectivity_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageSeedConnectivity_GetOutputConnectedValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the value to set connected pixels to.
	/// </summary>
	public virtual byte GetOutputConnectedValue()
	{
		return vtkImageSeedConnectivity_GetOutputConnectedValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageSeedConnectivity_GetOutputUnconnectedValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the value to set unconnected pixels to.
	/// </summary>
	public virtual byte GetOutputUnconnectedValue()
	{
		return vtkImageSeedConnectivity_GetOutputUnconnectedValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSeedConnectivity_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSeedConnectivity_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSeedConnectivity_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSeedConnectivity_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeedConnectivity_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSeedConnectivity NewInstance()
	{
		vtkImageSeedConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeedConnectivity_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_RemoveAllSeeds_15(HandleRef pThis);

	/// <summary>
	/// Methods for manipulating the seed pixels.
	/// </summary>
	public void RemoveAllSeeds()
	{
		vtkImageSeedConnectivity_RemoveAllSeeds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeedConnectivity_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSeedConnectivity SafeDownCast(vtkObjectBase o)
	{
		vtkImageSeedConnectivity vtkImageSeedConnectivity2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeedConnectivity_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSeedConnectivity2 = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSeedConnectivity2.Register(null);
			}
		}
		return vtkImageSeedConnectivity2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_SetDimensionality_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of axes to use in connectivity.
	/// </summary>
	public virtual void SetDimensionality(int _arg)
	{
		vtkImageSeedConnectivity_SetDimensionality_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_SetInputConnectValue_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get what value is considered as connecting pixels.
	/// </summary>
	public virtual void SetInputConnectValue(byte _arg)
	{
		vtkImageSeedConnectivity_SetInputConnectValue_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_SetOutputConnectedValue_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the value to set connected pixels to.
	/// </summary>
	public virtual void SetOutputConnectedValue(byte _arg)
	{
		vtkImageSeedConnectivity_SetOutputConnectedValue_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeedConnectivity_SetOutputUnconnectedValue_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the value to set unconnected pixels to.
	/// </summary>
	public virtual void SetOutputUnconnectedValue(byte _arg)
	{
		vtkImageSeedConnectivity_SetOutputUnconnectedValue_20(GetCppThis(), _arg);
	}
}
