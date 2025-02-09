using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageReader
/// </summary>
/// <remarks>
///    Superclass of transformable binary file readers.
///
/// vtkImageReader provides methods needed to read a region from a file.
/// It supports both transforms and masks on the input data, but as a result
/// is more complicated and slower than its parent class vtkImageReader2.
///
/// </remarks>
/// <seealso>
///
/// vtkBMPReader vtkPNMReader vtkTIFFReader
/// </seealso>
public class vtkImageReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageReader()
	{
		MRClassNameKey = "class vtkImageReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReader New()
	{
		vtkImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader_CanReadFile_01(HandleRef pThis, string arg0);

	/// <summary>
	/// vtkImageReader itself can read raw binary files. That being the case,
	/// we need to implement `CanReadFile` to return success for any file.
	/// Subclasses that read specific file format should override and implement
	/// appropriate checks for file format.
	/// </summary>
	public override int CanReadFile(string arg0)
	{
		return vtkImageReader_CanReadFile_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_ComputeInverseTransformedExtent_02(HandleRef pThis, IntPtr inExtent, IntPtr outExtent);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public void ComputeInverseTransformedExtent(IntPtr inExtent, IntPtr outExtent)
	{
		vtkImageReader_ComputeInverseTransformedExtent_02(GetCppThis(), inExtent, outExtent);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_ComputeInverseTransformedIncrements_03(HandleRef pThis, IntPtr inIncr, IntPtr outIncr);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public void ComputeInverseTransformedIncrements(IntPtr inIncr, IntPtr outIncr)
	{
		vtkImageReader_ComputeInverseTransformedIncrements_03(GetCppThis(), inIncr, outIncr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageReader_GetDataMask_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the Data mask.  The data mask is a simply integer whose bits are
	/// treated as a mask to the bits read from disk.  That is, the data mask is
	/// bitwise-and'ed to the numbers read from disk.  This ivar is stored as 64
	/// bits, the largest mask you will need.  The mask will be truncated to the
	/// data size required to be read (using the least significant bits).
	/// </summary>
	public virtual ulong GetDataMask()
	{
		return vtkImageReader_GetDataMask_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader_GetDataVOI_05(HandleRef pThis);

	/// <summary>
	/// Set/get the data VOI. You can limit the reader to only
	/// read a subset of the data.
	/// </summary>
	public virtual int[] GetDataVOI()
	{
		IntPtr intPtr = vtkImageReader_GetDataVOI_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_GetDataVOI_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/get the data VOI. You can limit the reader to only
	/// read a subset of the data.
	/// </summary>
	public virtual void GetDataVOI(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageReader_GetDataVOI_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_GetDataVOI_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the data VOI. You can limit the reader to only
	/// read a subset of the data.
	/// </summary>
	public virtual void GetDataVOI(IntPtr _arg)
	{
		vtkImageReader_GetDataVOI_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageReader_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageReader_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader_GetScalarArrayName_10(HandleRef pThis);

	/// <summary>
	/// Set/get the scalar array name for this data set.
	/// </summary>
	public virtual string GetScalarArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader_GetScalarArrayName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader_GetTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public virtual vtkTransform GetTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader_GetTransform_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageReader_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageReader_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageReader NewInstance()
	{
		vtkImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader_OpenAndSeekFile_16(HandleRef pThis, IntPtr extent, int slice);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public int OpenAndSeekFile(IntPtr extent, int slice)
	{
		return vtkImageReader_OpenAndSeekFile_16(GetCppThis(), extent, slice);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReader SafeDownCast(vtkObjectBase o)
	{
		vtkImageReader vtkImageReader3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReader3 = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReader3.Register(null);
			}
		}
		return vtkImageReader3;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_SetDataMask_18(HandleRef pThis, ulong _arg);

	/// <summary>
	/// Set/Get the Data mask.  The data mask is a simply integer whose bits are
	/// treated as a mask to the bits read from disk.  That is, the data mask is
	/// bitwise-and'ed to the numbers read from disk.  This ivar is stored as 64
	/// bits, the largest mask you will need.  The mask will be truncated to the
	/// data size required to be read (using the least significant bits).
	/// </summary>
	public virtual void SetDataMask(ulong _arg)
	{
		vtkImageReader_SetDataMask_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_SetDataVOI_19(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set/get the data VOI. You can limit the reader to only
	/// read a subset of the data.
	/// </summary>
	public virtual void SetDataVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageReader_SetDataVOI_19(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_SetDataVOI_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the data VOI. You can limit the reader to only
	/// read a subset of the data.
	/// </summary>
	public virtual void SetDataVOI(IntPtr _arg)
	{
		vtkImageReader_SetDataVOI_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_SetScalarArrayName_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the scalar array name for this data set.
	/// </summary>
	public virtual void SetScalarArrayName(string _arg)
	{
		vtkImageReader_SetScalarArrayName_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader_SetTransform_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public virtual void SetTransform(vtkTransform arg0)
	{
		vtkImageReader_SetTransform_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
