using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEnSight6Reader
/// </summary>
/// <remarks>
///    class to read EnSight6 files
///
/// vtkEnSight6Reader is a class to read EnSight6 files into vtk.
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
/// </remarks>
public class vtkEnSight6Reader : vtkEnSightReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEnSight6Reader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEnSight6Reader()
	{
		MRClassNameKey = "class vtkEnSight6Reader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSight6Reader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEnSight6Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSight6Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnSight6Reader New()
	{
		vtkEnSight6Reader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSight6Reader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEnSight6Reader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEnSight6Reader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkEnSight6Reader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEnSight6Reader_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSight6Reader_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEnSight6Reader_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSight6Reader_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEnSight6Reader_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSight6Reader_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEnSight6Reader_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSight6Reader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEnSight6Reader NewInstance()
	{
		vtkEnSight6Reader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSight6Reader_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSight6Reader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnSight6Reader SafeDownCast(vtkObjectBase o)
	{
		vtkEnSight6Reader vtkEnSight6Reader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSight6Reader_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEnSight6Reader2 = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEnSight6Reader2.Register(null);
			}
		}
		return vtkEnSight6Reader2;
	}
}
