using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkNIFTIWriter
/// \brief Write NIfTI-1 and NIfTI-2 medical image files
///
/// This class writes NIFTI files, either in .nii format or as separate
/// .img and .hdr files.  If told to write a file that ends in ".gz",
/// then the writer will automatically compress the file with zlib.
/// Images of type unsigned char that have 3 or 4 scalar components
/// will automatically be written as RGB or RGBA respectively.  Images
/// of type float or double that have 2 components will automatically be
/// written as complex values.
///
/// This class was contributed to VTK by the Calgary Image Processing and
/// Analysis Centre (CIPAC).
///
/// \sa vtkNIFTIReader
/// </summary>
public class vtkNIFTIWriter : vtkImageWriter
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum EndianEnum
	{
		/// <summary>enum member</summary>
		BigEndian,
		/// <summary>enum member</summary>
		LittleEndian
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNIFTIWriter()
	{
		MRClassNameKey = "class vtkNIFTIWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNIFTIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNIFTIWriter New()
	{
		vtkNIFTIWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNIFTIWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNIFTIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern EndianEnum vtkNIFTIWriter_GetDataByteOrder_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual EndianEnum GetDataByteOrder()
	{
		return vtkNIFTIWriter_GetDataByteOrder_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_GetDescription_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetDescription()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIWriter_GetDescription_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_GetNIFTIHeader_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNIFTIHeader GetNIFTIHeader()
	{
		vtkNIFTIHeader vtkNIFTIHeader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIWriter_GetNIFTIHeader_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNIFTIHeader2 = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNIFTIHeader2.Register(null);
			}
		}
		return vtkNIFTIHeader2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIWriter_GetNIFTIVersion_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetNIFTIVersion()
	{
		return vtkNIFTIWriter_GetNIFTIVersion_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNIFTIWriter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIWriter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNIFTIWriter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkNIFTIWriter_GetPlanarRGB_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual bool GetPlanarRGB()
	{
		return (vtkNIFTIWriter_GetPlanarRGB_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIWriter_GetQFac_08(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetQFac()
	{
		return vtkNIFTIWriter_GetQFac_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_GetQFormMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetQFormMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIWriter_GetQFormMatrix_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIWriter_GetRescaleIntercept_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetRescaleIntercept()
	{
		return vtkNIFTIWriter_GetRescaleIntercept_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIWriter_GetRescaleSlope_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetRescaleSlope()
	{
		return vtkNIFTIWriter_GetRescaleSlope_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_GetSFormMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetSFormMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIWriter_GetSFormMatrix_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIWriter_GetTimeDimension_13(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetTimeDimension()
	{
		return vtkNIFTIWriter_GetTimeDimension_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIWriter_GetTimeSpacing_14(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetTimeSpacing()
	{
		return vtkNIFTIWriter_GetTimeSpacing_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIWriter_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNIFTIWriter_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIWriter_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNIFTIWriter_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNIFTIWriter NewInstance()
	{
		vtkNIFTIWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIWriter_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_PlanarRGBOff_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void PlanarRGBOff()
	{
		vtkNIFTIWriter_PlanarRGBOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_PlanarRGBOn_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void PlanarRGBOn()
	{
		vtkNIFTIWriter_PlanarRGBOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIWriter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNIFTIWriter SafeDownCast(vtkObjectBase o)
	{
		vtkNIFTIWriter vtkNIFTIWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIWriter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNIFTIWriter2 = (vtkNIFTIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNIFTIWriter2.Register(null);
			}
		}
		return vtkNIFTIWriter2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetDataByteOrder_22(HandleRef pThis, EndianEnum _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetDataByteOrder(EndianEnum _arg)
	{
		vtkNIFTIWriter_SetDataByteOrder_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetDataByteOrderToBigEndian_23(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetDataByteOrderToBigEndian()
	{
		vtkNIFTIWriter_SetDataByteOrderToBigEndian_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetDataByteOrderToLittleEndian_24(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetDataByteOrderToLittleEndian()
	{
		vtkNIFTIWriter_SetDataByteOrderToLittleEndian_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetDescription_25(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetDescription(string _arg)
	{
		vtkNIFTIWriter_SetDescription_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetNIFTIHeader_26(HandleRef pThis, HandleRef hdr);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetNIFTIHeader(vtkNIFTIHeader hdr)
	{
		vtkNIFTIWriter_SetNIFTIHeader_26(GetCppThis(), hdr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetNIFTIVersion_27(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetNIFTIVersion(int _arg)
	{
		vtkNIFTIWriter_SetNIFTIVersion_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetPlanarRGB_28(HandleRef pThis, byte _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetPlanarRGB(bool _arg)
	{
		vtkNIFTIWriter_SetPlanarRGB_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetQFac_29(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQFac(double _arg)
	{
		vtkNIFTIWriter_SetQFac_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetQFormMatrix_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetQFormMatrix(vtkMatrix4x4 arg0)
	{
		vtkNIFTIWriter_SetQFormMatrix_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetRescaleIntercept_31(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetRescaleIntercept(double _arg)
	{
		vtkNIFTIWriter_SetRescaleIntercept_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetRescaleSlope_32(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetRescaleSlope(double _arg)
	{
		vtkNIFTIWriter_SetRescaleSlope_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetSFormMatrix_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetSFormMatrix(vtkMatrix4x4 arg0)
	{
		vtkNIFTIWriter_SetSFormMatrix_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetTimeDimension_34(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTimeDimension(int _arg)
	{
		vtkNIFTIWriter_SetTimeDimension_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIWriter_SetTimeSpacing_35(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTimeSpacing(double _arg)
	{
		vtkNIFTIWriter_SetTimeSpacing_35(GetCppThis(), _arg);
	}
}
