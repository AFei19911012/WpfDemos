using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSortFileNames
/// </summary>
/// <remarks>
///    Group and sort a set of filenames
///
/// vtkSortFileNames will take a list of filenames (e.g. from
/// a file load dialog) and sort them into one or more series.  If
/// the input list of filenames contains any directories, these can
/// be removed before sorting using the SkipDirectories flag.  This
/// class should be used where information about the series groupings
/// can be determined by the filenames, but it might not be successful
/// in cases where the information about the series groupings is
/// stored in the files themselves (e.g DICOM).
/// </remarks>
/// <seealso>
///
/// vtkImageReader2
/// </seealso>
public class vtkSortFileNames : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSortFileNames";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSortFileNames()
	{
		MRClassNameKey = "class vtkSortFileNames";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortFileNames"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSortFileNames(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFileNames_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSortFileNames New()
	{
		vtkSortFileNames result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFileNames_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSortFileNames()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSortFileNames_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFileNames_GetFileNames_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the full list of sorted filenames.
	/// </summary>
	public virtual vtkStringArray GetFileNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFileNames_GetFileNames_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_GetGrouping_02(HandleRef pThis);

	/// <summary>
	/// Sort the file names into groups, according to similarity in
	/// filename name and path.  Files in different directories,
	/// or with different extensions, or which do not fit into the same
	/// numbered series will be placed into different groups.  This is
	/// off by default.
	/// </summary>
	public virtual int GetGrouping()
	{
		return vtkSortFileNames_GetGrouping_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_GetIgnoreCase_03(HandleRef pThis);

	/// <summary>
	/// Ignore case when sorting.  This flag is honored by both
	/// the sorting and the grouping. This is off by default.
	/// </summary>
	public virtual int GetIgnoreCase()
	{
		return vtkSortFileNames_GetIgnoreCase_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFileNames_GetInputFileNames_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a list of file names to group and sort.
	/// </summary>
	public virtual vtkStringArray GetInputFileNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFileNames_GetInputFileNames_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFileNames_GetNthGroup_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the Nth group of file names.  This method should only
	/// be used if grouping is on.  If grouping is off, it will always
	/// return null.
	/// </summary>
	public virtual vtkStringArray GetNthGroup(int i)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFileNames_GetNthGroup_05(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSortFileNames_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSortFileNames_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSortFileNames_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSortFileNames_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_GetNumberOfGroups_08(HandleRef pThis);

	/// <summary>
	/// Get the number of groups that the names were split into, if
	/// grouping is on.  The filenames are automatically split into
	/// groups, where the filenames in each group will be identical
	/// except for their series numbers.  If grouping is not on, this
	/// method will return zero.
	/// </summary>
	public virtual int GetNumberOfGroups()
	{
		return vtkSortFileNames_GetNumberOfGroups_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_GetNumericSort_09(HandleRef pThis);

	/// <summary>
	/// Sort the files numerically, rather than lexicographically.
	/// For filenames that contain numbers, this means the order will be
	/// ["file8.dat", "file9.dat", "file10.dat"]
	/// instead of the usual alphabetic sorting order
	/// ["file10.dat" "file8.dat", "file9.dat"].
	/// NumericSort is off by default.
	/// </summary>
	public virtual int GetNumericSort()
	{
		return vtkSortFileNames_GetNumericSort_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_GetSkipDirectories_10(HandleRef pThis);

	/// <summary>
	/// Skip directories. If this flag is set, any input item that
	/// is a directory rather than a file will not be included in
	/// the output.  This is off by default.
	/// </summary>
	public virtual int GetSkipDirectories()
	{
		return vtkSortFileNames_GetSkipDirectories_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_GroupingOff_11(HandleRef pThis);

	/// <summary>
	/// Sort the file names into groups, according to similarity in
	/// filename name and path.  Files in different directories,
	/// or with different extensions, or which do not fit into the same
	/// numbered series will be placed into different groups.  This is
	/// off by default.
	/// </summary>
	public virtual void GroupingOff()
	{
		vtkSortFileNames_GroupingOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_GroupingOn_12(HandleRef pThis);

	/// <summary>
	/// Sort the file names into groups, according to similarity in
	/// filename name and path.  Files in different directories,
	/// or with different extensions, or which do not fit into the same
	/// numbered series will be placed into different groups.  This is
	/// off by default.
	/// </summary>
	public virtual void GroupingOn()
	{
		vtkSortFileNames_GroupingOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_IgnoreCaseOff_13(HandleRef pThis);

	/// <summary>
	/// Ignore case when sorting.  This flag is honored by both
	/// the sorting and the grouping. This is off by default.
	/// </summary>
	public virtual void IgnoreCaseOff()
	{
		vtkSortFileNames_IgnoreCaseOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_IgnoreCaseOn_14(HandleRef pThis);

	/// <summary>
	/// Ignore case when sorting.  This flag is honored by both
	/// the sorting and the grouping. This is off by default.
	/// </summary>
	public virtual void IgnoreCaseOn()
	{
		vtkSortFileNames_IgnoreCaseOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSortFileNames_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFileNames_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSortFileNames_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFileNames_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSortFileNames NewInstance()
	{
		vtkSortFileNames result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFileNames_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_NumericSortOff_19(HandleRef pThis);

	/// <summary>
	/// Sort the files numerically, rather than lexicographically.
	/// For filenames that contain numbers, this means the order will be
	/// ["file8.dat", "file9.dat", "file10.dat"]
	/// instead of the usual alphabetic sorting order
	/// ["file10.dat" "file8.dat", "file9.dat"].
	/// NumericSort is off by default.
	/// </summary>
	public virtual void NumericSortOff()
	{
		vtkSortFileNames_NumericSortOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_NumericSortOn_20(HandleRef pThis);

	/// <summary>
	/// Sort the files numerically, rather than lexicographically.
	/// For filenames that contain numbers, this means the order will be
	/// ["file8.dat", "file9.dat", "file10.dat"]
	/// instead of the usual alphabetic sorting order
	/// ["file10.dat" "file8.dat", "file9.dat"].
	/// NumericSort is off by default.
	/// </summary>
	public virtual void NumericSortOn()
	{
		vtkSortFileNames_NumericSortOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFileNames_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSortFileNames SafeDownCast(vtkObjectBase o)
	{
		vtkSortFileNames vtkSortFileNames2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFileNames_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSortFileNames2 = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSortFileNames2.Register(null);
			}
		}
		return vtkSortFileNames2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SetGrouping_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Sort the file names into groups, according to similarity in
	/// filename name and path.  Files in different directories,
	/// or with different extensions, or which do not fit into the same
	/// numbered series will be placed into different groups.  This is
	/// off by default.
	/// </summary>
	public virtual void SetGrouping(int _arg)
	{
		vtkSortFileNames_SetGrouping_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SetIgnoreCase_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Ignore case when sorting.  This flag is honored by both
	/// the sorting and the grouping. This is off by default.
	/// </summary>
	public virtual void SetIgnoreCase(int _arg)
	{
		vtkSortFileNames_SetIgnoreCase_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SetInputFileNames_24(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set a list of file names to group and sort.
	/// </summary>
	public void SetInputFileNames(vtkStringArray input)
	{
		vtkSortFileNames_SetInputFileNames_24(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SetNumericSort_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Sort the files numerically, rather than lexicographically.
	/// For filenames that contain numbers, this means the order will be
	/// ["file8.dat", "file9.dat", "file10.dat"]
	/// instead of the usual alphabetic sorting order
	/// ["file10.dat" "file8.dat", "file9.dat"].
	/// NumericSort is off by default.
	/// </summary>
	public virtual void SetNumericSort(int _arg)
	{
		vtkSortFileNames_SetNumericSort_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SetSkipDirectories_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Skip directories. If this flag is set, any input item that
	/// is a directory rather than a file will not be included in
	/// the output.  This is off by default.
	/// </summary>
	public virtual void SetSkipDirectories(int _arg)
	{
		vtkSortFileNames_SetSkipDirectories_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SkipDirectoriesOff_27(HandleRef pThis);

	/// <summary>
	/// Skip directories. If this flag is set, any input item that
	/// is a directory rather than a file will not be included in
	/// the output.  This is off by default.
	/// </summary>
	public virtual void SkipDirectoriesOff()
	{
		vtkSortFileNames_SkipDirectoriesOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_SkipDirectoriesOn_28(HandleRef pThis);

	/// <summary>
	/// Skip directories. If this flag is set, any input item that
	/// is a directory rather than a file will not be included in
	/// the output.  This is off by default.
	/// </summary>
	public virtual void SkipDirectoriesOn()
	{
		vtkSortFileNames_SkipDirectoriesOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortFileNames_Update_29(HandleRef pThis);

	/// <summary>
	/// Update the output filenames from the input filenames.
	/// This method is called automatically by GetFileNames()
	/// and GetNumberOfGroups() if the input names have changed.
	/// </summary>
	public virtual void Update()
	{
		vtkSortFileNames_Update_29(GetCppThis());
	}
}
