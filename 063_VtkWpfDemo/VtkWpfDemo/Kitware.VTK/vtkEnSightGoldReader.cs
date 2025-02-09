using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEnSightGoldReader
/// </summary>
/// <remarks>
///    class to read EnSight Gold files
///
/// vtkEnSightGoldReader is a class to read EnSight Gold files into vtk.
/// Because the different parts of the EnSight data can be of various data
/// types, this reader produces multiple outputs, one per part in the input
/// file.
/// All variable information is being stored in field data.  The descriptions
/// listed in the case file are used as the array names in the field data.
/// For complex vector variables, the description is appended with _r (for the
/// array of real values) and _i (for the array if imaginary values).  Complex
/// scalar variables are stored as a single array with 2 components, real and
/// imaginary, listed in that order.
/// @warning
/// You must manually call Update on this reader and then connect the rest
/// of the pipeline because (due to the nature of the file format) it is
/// not possible to know ahead of time how many outputs you will have or
/// what types they will be.
/// This reader can only handle static EnSight datasets (both static geometry
/// and variables).
/// @par Thanks:
/// Thanks to Yvan Fournier for providing the code to support nfaced elements.
/// </remarks>
public class vtkEnSightGoldReader : vtkEnSightReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightGoldReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEnSightGoldReader()
	{
		MRClassNameKey = "class vtkEnSightGoldReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightGoldReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEnSightGoldReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightGoldReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnSightGoldReader New()
	{
		vtkEnSightGoldReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightGoldReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEnSightGoldReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEnSightGoldReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSightGoldReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEnSightGoldReader_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSightGoldReader_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEnSightGoldReader_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightGoldReader_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEnSightGoldReader_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightGoldReader_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEnSightGoldReader_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightGoldReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEnSightGoldReader NewInstance()
	{
		vtkEnSightGoldReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightGoldReader_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightGoldReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnSightGoldReader SafeDownCast(vtkObjectBase o)
	{
		vtkEnSightGoldReader vtkEnSightGoldReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightGoldReader_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEnSightGoldReader2 = (vtkEnSightGoldReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEnSightGoldReader2.Register(null);
			}
		}
		return vtkEnSightGoldReader2;
	}
}
