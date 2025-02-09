using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMCubesReader
/// </summary>
/// <remarks>
///    read binary marching cubes file
///
/// vtkMCubesReader is a source object that reads binary marching cubes
/// files. (Marching cubes is an isosurfacing technique that generates
/// many triangles.) The binary format is supported by W. Lorensen's
/// marching cubes program (and the vtkSliceCubes object). The format
/// repeats point coordinates, so this object will merge the points
/// with a vtkLocator object. You can choose to supply the vtkLocator
/// or use the default.
///
/// @warning
/// Binary files assumed written in sun/hp/sgi (i.e., Big Endian) form.
///
/// @warning
/// Because points are merged when read, degenerate triangles may be removed.
/// Thus the number of triangles read may be fewer than the number of triangles
/// actually created.
///
/// @warning
/// The point merging does not take into account that the same point may have
/// different normals. For example, running vtkPolyDataNormals after
/// vtkContourFilter may split triangles because of the FeatureAngle
/// ivar. Subsequent reading with vtkMCubesReader will merge the points and
/// use the first point's normal. For the most part, this is undesirable.
///
/// @warning
/// Normals are generated from the gradient of the data scalar values. Hence
/// the normals may on occasion point in a direction inconsistent with the
/// ordering of the triangle vertices. If this happens, the resulting surface
/// may be "black".  Reverse the sense of the FlipNormals boolean flag to
/// correct this.
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkMarchingCubes vtkSliceCubes vtkLocator
/// </seealso>
public class vtkMCubesReader : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMCubesReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMCubesReader()
	{
		MRClassNameKey = "class vtkMCubesReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMCubesReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMCubesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public new static vtkMCubesReader New()
	{
		vtkMCubesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMCubesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public vtkMCubesReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMCubesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkMCubesReader_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_FlipNormalsOff_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to flip normals in opposite direction. Flipping ONLY
	/// changes the direction of the normal vector. Contrast this with flipping
	/// in vtkPolyDataNormals which flips both the normal and the cell point
	/// order.
	/// </summary>
	public virtual void FlipNormalsOff()
	{
		vtkMCubesReader_FlipNormalsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_FlipNormalsOn_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to flip normals in opposite direction. Flipping ONLY
	/// changes the direction of the normal vector. Contrast this with flipping
	/// in vtkPolyDataNormals which flips both the normal and the cell point
	/// order.
	/// </summary>
	public virtual void FlipNormalsOn()
	{
		vtkMCubesReader_FlipNormalsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetDataByteOrder_04(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public int GetDataByteOrder()
	{
		return vtkMCubesReader_GetDataByteOrder_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_GetDataByteOrderAsString_05(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public string GetDataByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkMCubesReader_GetDataByteOrderAsString_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_GetFileName_06(HandleRef pThis);

	/// <summary>
	/// Specify file name of marching cubes file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMCubesReader_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetFlipNormals_07(HandleRef pThis);

	/// <summary>
	/// Specify whether to flip normals in opposite direction. Flipping ONLY
	/// changes the direction of the normal vector. Contrast this with flipping
	/// in vtkPolyDataNormals which flips both the normal and the cell point
	/// order.
	/// </summary>
	public virtual int GetFlipNormals()
	{
		return vtkMCubesReader_GetFlipNormals_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetHeaderSize_08(HandleRef pThis);

	/// <summary>
	/// Specify a header size if one exists. The header is skipped and not used at this time.
	/// </summary>
	public virtual int GetHeaderSize()
	{
		return vtkMCubesReader_GetHeaderSize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetHeaderSizeMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify a header size if one exists. The header is skipped and not used at this time.
	/// </summary>
	public virtual int GetHeaderSizeMaxValue()
	{
		return vtkMCubesReader_GetHeaderSizeMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetHeaderSizeMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify a header size if one exists. The header is skipped and not used at this time.
	/// </summary>
	public virtual int GetHeaderSizeMinValue()
	{
		return vtkMCubesReader_GetHeaderSizeMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_GetLimitsFileName_11(HandleRef pThis);

	/// <summary>
	/// Set / get the file name of the marching cubes limits file.
	/// </summary>
	public virtual string GetLimitsFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMCubesReader_GetLimitsFileName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMCubesReader_GetLocator_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMCubesReader_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Return the mtime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMCubesReader_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetNormals_14(HandleRef pThis);

	/// <summary>
	/// Specify whether to read normals.
	/// </summary>
	public virtual int GetNormals()
	{
		return vtkMCubesReader_GetNormals_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMCubesReader_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMCubesReader_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMCubesReader_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMCubesReader_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_GetSwapBytes_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual int GetSwapBytes()
	{
		return vtkMCubesReader_GetSwapBytes_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMCubesReader_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMCubesReader_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMCubesReader_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMCubesReader NewInstance()
	{
		vtkMCubesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMCubesReader_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_NormalsOff_22(HandleRef pThis);

	/// <summary>
	/// Specify whether to read normals.
	/// </summary>
	public virtual void NormalsOff()
	{
		vtkMCubesReader_NormalsOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_NormalsOn_23(HandleRef pThis);

	/// <summary>
	/// Specify whether to read normals.
	/// </summary>
	public virtual void NormalsOn()
	{
		vtkMCubesReader_NormalsOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMCubesReader_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMCubesReader SafeDownCast(vtkObjectBase o)
	{
		vtkMCubesReader vtkMCubesReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMCubesReader_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMCubesReader2 = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMCubesReader2.Register(null);
			}
		}
		return vtkMCubesReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetDataByteOrder_25(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public void SetDataByteOrder(int arg0)
	{
		vtkMCubesReader_SetDataByteOrder_25(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetDataByteOrderToBigEndian_26(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public void SetDataByteOrderToBigEndian()
	{
		vtkMCubesReader_SetDataByteOrderToBigEndian_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetDataByteOrderToLittleEndian_27(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public void SetDataByteOrderToLittleEndian()
	{
		vtkMCubesReader_SetDataByteOrderToLittleEndian_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetFileName_28(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of marching cubes file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMCubesReader_SetFileName_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetFlipNormals_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to flip normals in opposite direction. Flipping ONLY
	/// changes the direction of the normal vector. Contrast this with flipping
	/// in vtkPolyDataNormals which flips both the normal and the cell point
	/// order.
	/// </summary>
	public virtual void SetFlipNormals(int _arg)
	{
		vtkMCubesReader_SetFlipNormals_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetHeaderSize_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a header size if one exists. The header is skipped and not used at this time.
	/// </summary>
	public virtual void SetHeaderSize(int _arg)
	{
		vtkMCubesReader_SetHeaderSize_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetLimitsFileName_31(HandleRef pThis, string _arg);

	/// <summary>
	/// Set / get the file name of the marching cubes limits file.
	/// </summary>
	public virtual void SetLimitsFileName(string _arg)
	{
		vtkMCubesReader_SetLimitsFileName_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetLocator_32(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkMCubesReader_SetLocator_32(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetNormals_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to read normals.
	/// </summary>
	public virtual void SetNormals(int _arg)
	{
		vtkMCubesReader_SetNormals_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SetSwapBytes_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual void SetSwapBytes(int _arg)
	{
		vtkMCubesReader_SetSwapBytes_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SwapBytesOff_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual void SwapBytesOff()
	{
		vtkMCubesReader_SwapBytesOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMCubesReader_SwapBytesOn_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual void SwapBytesOn()
	{
		vtkMCubesReader_SwapBytesOn_36(GetCppThis());
	}
}
