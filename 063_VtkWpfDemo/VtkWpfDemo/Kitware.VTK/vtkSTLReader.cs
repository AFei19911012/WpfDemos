using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSTLReader
/// </summary>
/// <remarks>
///    read ASCII or binary stereo lithography files
///
/// vtkSTLReader is a source object that reads ASCII or binary stereo
/// lithography files (.stl files). The FileName must be specified to
/// vtkSTLReader. The object automatically detects whether the file is
/// ASCII or binary.
///
/// .stl files are quite inefficient since they duplicate vertex
/// definitions. By setting the Merging boolean you can control whether the
/// point data is merged after reading. Merging is performed by default,
/// however, merging requires a large amount of temporary storage since a
/// 3D hash table must be constructed.
///
/// @warning
/// Binary files written on one system may not be readable on other systems.
/// vtkSTLWriter uses VAX or PC byte ordering and swaps bytes on other systems.
/// </remarks>
public class vtkSTLReader : vtkAbstractPolyDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSTLReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSTLReader()
	{
		MRClassNameKey = "class vtkSTLReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSTLReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSTLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with merging set to true.
	/// </summary>
	public new static vtkSTLReader New()
	{
		vtkSTLReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with merging set to true.
	/// </summary>
	public vtkSTLReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSTLReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSTLReader_GetBinaryHeader_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get binary file header string.
	/// If ASCII STL file is read then BinaryHeader is not set,
	/// and the header can be retrieved using.GetHeader() instead.
	/// \sa GetHeader()
	/// </summary>
	public virtual vtkUnsignedCharArray GetBinaryHeader()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLReader_GetBinaryHeader_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLReader_GetHeader_02(HandleRef pThis);

	/// <summary>
	/// Get header string.
	/// If an ASCII STL file contains multiple solids then
	/// headers are separated by newline character.
	/// If a binary STL file is read, the first zero-terminated
	/// string is stored in this header, the full header is available
	/// by using GetBinaryHeader().
	/// \sa GetBinaryHeader()
	/// </summary>
	public virtual string GetHeader()
	{
		return Marshal.PtrToStringAnsi(vtkSTLReader_GetHeader_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLReader_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLReader_GetLocator_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkSTLReader_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Overload standard modified time function. If locator is modified,
	/// then this object is modified as well.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSTLReader_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLReader_GetMerging_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of points/triangles.
	/// </summary>
	public virtual int GetMerging()
	{
		return vtkSTLReader_GetMerging_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSTLReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSTLReader_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSTLReader_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSTLReader_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLReader_GetScalarTags_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off tagging of solids with scalars.
	/// </summary>
	public virtual int GetScalarTags()
	{
		return vtkSTLReader_GetScalarTags_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLReader_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSTLReader_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLReader_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSTLReader_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_MergingOff_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of points/triangles.
	/// </summary>
	public virtual void MergingOff()
	{
		vtkSTLReader_MergingOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_MergingOn_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of points/triangles.
	/// </summary>
	public virtual void MergingOn()
	{
		vtkSTLReader_MergingOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSTLReader NewInstance()
	{
		vtkSTLReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLReader_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSTLReader SafeDownCast(vtkObjectBase o)
	{
		vtkSTLReader vtkSTLReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLReader_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSTLReader2 = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSTLReader2.Register(null);
			}
		}
		return vtkSTLReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_ScalarTagsOff_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off tagging of solids with scalars.
	/// </summary>
	public virtual void ScalarTagsOff()
	{
		vtkSTLReader_ScalarTagsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_ScalarTagsOn_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off tagging of solids with scalars.
	/// </summary>
	public virtual void ScalarTagsOn()
	{
		vtkSTLReader_ScalarTagsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_SetLocator_18(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkSTLReader_SetLocator_18(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_SetMerging_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off merging of points/triangles.
	/// </summary>
	public virtual void SetMerging(int _arg)
	{
		vtkSTLReader_SetMerging_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLReader_SetScalarTags_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off tagging of solids with scalars.
	/// </summary>
	public virtual void SetScalarTags(int _arg)
	{
		vtkSTLReader_SetScalarTags_20(GetCppThis(), _arg);
	}
}
