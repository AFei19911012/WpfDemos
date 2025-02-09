using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBooleanTexture
/// </summary>
/// <remarks>
///    generate 2D texture map based on combinations of inside, outside, and on region boundary
///
///
/// vtkBooleanTexture is a filter to generate a 2D texture map based on
/// combinations of inside, outside, and on region boundary. The "region" is
/// implicitly represented via 2D texture coordinates. These texture
/// coordinates are normally generated using a filter like
/// vtkImplicitTextureCoords, which generates the texture coordinates for
/// any implicit function.
///
/// vtkBooleanTexture generates the map according to the s-t texture
/// coordinates plus the notion of being in, on, or outside of a
/// region. An in region is when the texture coordinate is between
/// (0,0.5-thickness/2).  An out region is where the texture coordinate
/// is (0.5+thickness/2). An on region is between
/// (0.5-thickness/2,0.5+thickness/2). The combination in, on, and out
/// for each of the s-t texture coordinates results in 16 possible
/// combinations (see text). For each combination, a different value of
/// intensity and transparency can be assigned. To assign maximum intensity
/// and/or opacity use the value 255. A minimum value of 0 results in
/// a black region (for intensity) and a fully transparent region (for
/// transparency).
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitTextureCoords vtkThresholdTextureCoords
/// </seealso>
public class vtkBooleanTexture : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBooleanTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBooleanTexture()
	{
		MRClassNameKey = "class vtkBooleanTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBooleanTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBooleanTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBooleanTexture New()
	{
		vtkBooleanTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBooleanTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBooleanTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBooleanTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetInIn_01(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "in/in" region.
	/// </summary>
	public virtual byte[] GetInIn()
	{
		IntPtr intPtr = vtkBooleanTexture_GetInIn_01(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetInIn_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "in/in" region.
	/// </summary>
	public virtual void GetInIn(IntPtr data)
	{
		vtkBooleanTexture_GetInIn_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetInOn_03(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "in/on" region.
	/// </summary>
	public virtual byte[] GetInOn()
	{
		IntPtr intPtr = vtkBooleanTexture_GetInOn_03(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetInOn_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "in/on" region.
	/// </summary>
	public virtual void GetInOn(IntPtr data)
	{
		vtkBooleanTexture_GetInOn_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetInOut_05(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "in/out" region.
	/// </summary>
	public virtual byte[] GetInOut()
	{
		IntPtr intPtr = vtkBooleanTexture_GetInOut_05(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetInOut_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "in/out" region.
	/// </summary>
	public virtual void GetInOut(IntPtr data)
	{
		vtkBooleanTexture_GetInOut_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBooleanTexture_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBooleanTexture_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBooleanTexture_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBooleanTexture_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetOnIn_09(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "on/in" region.
	/// </summary>
	public virtual byte[] GetOnIn()
	{
		IntPtr intPtr = vtkBooleanTexture_GetOnIn_09(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetOnIn_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "on/in" region.
	/// </summary>
	public virtual void GetOnIn(IntPtr data)
	{
		vtkBooleanTexture_GetOnIn_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetOnOn_11(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "on/on" region.
	/// </summary>
	public virtual byte[] GetOnOn()
	{
		IntPtr intPtr = vtkBooleanTexture_GetOnOn_11(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetOnOn_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "on/on" region.
	/// </summary>
	public virtual void GetOnOn(IntPtr data)
	{
		vtkBooleanTexture_GetOnOn_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetOnOut_13(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "on/out" region.
	/// </summary>
	public virtual byte[] GetOnOut()
	{
		IntPtr intPtr = vtkBooleanTexture_GetOnOut_13(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetOnOut_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "on/out" region.
	/// </summary>
	public virtual void GetOnOut(IntPtr data)
	{
		vtkBooleanTexture_GetOnOut_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetOutIn_15(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "out/in" region.
	/// </summary>
	public virtual byte[] GetOutIn()
	{
		IntPtr intPtr = vtkBooleanTexture_GetOutIn_15(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetOutIn_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "out/in" region.
	/// </summary>
	public virtual void GetOutIn(IntPtr data)
	{
		vtkBooleanTexture_GetOutIn_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetOutOn_17(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "out/on" region.
	/// </summary>
	public virtual byte[] GetOutOn()
	{
		IntPtr intPtr = vtkBooleanTexture_GetOutOn_17(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetOutOn_18(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "out/on" region.
	/// </summary>
	public virtual void GetOutOn(IntPtr data)
	{
		vtkBooleanTexture_GetOutOn_18(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_GetOutOut_19(HandleRef pThis);

	/// <summary>
	/// Specify intensity/transparency for "out/out" region.
	/// </summary>
	public virtual byte[] GetOutOut()
	{
		IntPtr intPtr = vtkBooleanTexture_GetOutOut_19(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_GetOutOut_20(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify intensity/transparency for "out/out" region.
	/// </summary>
	public virtual void GetOutOut(IntPtr data)
	{
		vtkBooleanTexture_GetOutOut_20(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanTexture_GetThickness_21(HandleRef pThis);

	/// <summary>
	/// Set the thickness of the "on" region.
	/// </summary>
	public virtual int GetThickness()
	{
		return vtkBooleanTexture_GetThickness_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanTexture_GetXSize_22(HandleRef pThis);

	/// <summary>
	/// Set the X texture map dimension.
	/// </summary>
	public virtual int GetXSize()
	{
		return vtkBooleanTexture_GetXSize_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanTexture_GetYSize_23(HandleRef pThis);

	/// <summary>
	/// Set the Y texture map dimension.
	/// </summary>
	public virtual int GetYSize()
	{
		return vtkBooleanTexture_GetYSize_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanTexture_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBooleanTexture_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBooleanTexture_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBooleanTexture_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBooleanTexture NewInstance()
	{
		vtkBooleanTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBooleanTexture_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBooleanTexture_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBooleanTexture SafeDownCast(vtkObjectBase o)
	{
		vtkBooleanTexture vtkBooleanTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBooleanTexture_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBooleanTexture2 = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBooleanTexture2.Register(null);
			}
		}
		return vtkBooleanTexture2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetInIn_29(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "in/in" region.
	/// </summary>
	public virtual void SetInIn(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetInIn_29(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetInIn_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "in/in" region.
	/// </summary>
	public void SetInIn(IntPtr _arg)
	{
		vtkBooleanTexture_SetInIn_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetInOn_31(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "in/on" region.
	/// </summary>
	public virtual void SetInOn(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetInOn_31(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetInOn_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "in/on" region.
	/// </summary>
	public void SetInOn(IntPtr _arg)
	{
		vtkBooleanTexture_SetInOn_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetInOut_33(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "in/out" region.
	/// </summary>
	public virtual void SetInOut(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetInOut_33(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetInOut_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "in/out" region.
	/// </summary>
	public void SetInOut(IntPtr _arg)
	{
		vtkBooleanTexture_SetInOut_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOnIn_35(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "on/in" region.
	/// </summary>
	public virtual void SetOnIn(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetOnIn_35(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOnIn_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "on/in" region.
	/// </summary>
	public void SetOnIn(IntPtr _arg)
	{
		vtkBooleanTexture_SetOnIn_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOnOn_37(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "on/on" region.
	/// </summary>
	public virtual void SetOnOn(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetOnOn_37(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOnOn_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "on/on" region.
	/// </summary>
	public void SetOnOn(IntPtr _arg)
	{
		vtkBooleanTexture_SetOnOn_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOnOut_39(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "on/out" region.
	/// </summary>
	public virtual void SetOnOut(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetOnOut_39(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOnOut_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "on/out" region.
	/// </summary>
	public void SetOnOut(IntPtr _arg)
	{
		vtkBooleanTexture_SetOnOut_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOutIn_41(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "out/in" region.
	/// </summary>
	public virtual void SetOutIn(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetOutIn_41(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOutIn_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "out/in" region.
	/// </summary>
	public void SetOutIn(IntPtr _arg)
	{
		vtkBooleanTexture_SetOutIn_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOutOn_43(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "out/on" region.
	/// </summary>
	public virtual void SetOutOn(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetOutOn_43(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOutOn_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "out/on" region.
	/// </summary>
	public void SetOutOn(IntPtr _arg)
	{
		vtkBooleanTexture_SetOutOn_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOutOut_45(HandleRef pThis, byte _arg1, byte _arg2);

	/// <summary>
	/// Specify intensity/transparency for "out/out" region.
	/// </summary>
	public virtual void SetOutOut(byte _arg1, byte _arg2)
	{
		vtkBooleanTexture_SetOutOut_45(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetOutOut_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify intensity/transparency for "out/out" region.
	/// </summary>
	public void SetOutOut(IntPtr _arg)
	{
		vtkBooleanTexture_SetOutOut_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetThickness_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the thickness of the "on" region.
	/// </summary>
	public virtual void SetThickness(int _arg)
	{
		vtkBooleanTexture_SetThickness_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetXSize_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the X texture map dimension.
	/// </summary>
	public virtual void SetXSize(int _arg)
	{
		vtkBooleanTexture_SetXSize_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBooleanTexture_SetYSize_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Y texture map dimension.
	/// </summary>
	public virtual void SetYSize(int _arg)
	{
		vtkBooleanTexture_SetYSize_49(GetCppThis(), _arg);
	}
}
