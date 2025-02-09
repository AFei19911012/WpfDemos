using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPLY
/// </summary>
/// <remarks>
///    a modified version of the PLY 1.1 library
///
/// vtkPLY is a modified version of the PLY 1.1 library. The library
/// has been modified by wrapping in a class (to minimize global symbols);
/// to take advantage of functionality generally not available through the
/// PLY library API; and to correct problems with the PLY library.
///
/// The original distribution was taken from the Stanford University PLY
/// file format release 1.1 (see http://graphics.stanford.edu/data/3Dscanrep/).
///
/// </remarks>
/// <seealso>
///
/// vtkPLYWriter vtkPLYReader
/// </seealso>
public class vtkPLY : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPLY";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPLY()
	{
		MRClassNameKey = "class vtkPLY";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLY"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPLY(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPLY_equal_strings_01(string arg0, string arg1);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static bool equal_strings(string arg0, string arg1)
	{
		return (vtkPLY_equal_strings_01(arg0, arg1) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLY_get_ascii_item_02(string arg0, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void get_ascii_item(string arg0, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4)
	{
		vtkPLY_get_ascii_item_02(arg0, arg1, arg2, arg3, arg4);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPLY_get_item_value_03(string arg0, int arg1);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static double get_item_value(string arg0, int arg1)
	{
		return vtkPLY_get_item_value_03(arg0, arg1);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLY_get_prop_type_04(string arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static int get_prop_type(string arg0)
	{
		return vtkPLY_get_prop_type_04(arg0);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLY_get_stored_item_05(IntPtr arg0, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void get_stored_item(IntPtr arg0, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4)
	{
		vtkPLY_get_stored_item_05(arg0, arg1, arg2, arg3, arg4);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLY_my_alloc_06(ulong arg0, int arg1, string arg2);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static IntPtr my_alloc(ulong arg0, int arg1, string arg2)
	{
		return vtkPLY_my_alloc_06(arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLY_store_item_07(string arg0, int arg1, int arg2, uint arg3, double arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void store_item(string arg0, int arg1, int arg2, uint arg3, double arg4)
	{
		vtkPLY_store_item_07(arg0, arg1, arg2, arg3, arg4);
	}
}
