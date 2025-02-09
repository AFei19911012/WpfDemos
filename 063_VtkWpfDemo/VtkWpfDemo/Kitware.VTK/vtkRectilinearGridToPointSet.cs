using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearGridToPointSet
/// </summary>
/// <remarks>
///    Converts a vtkRectilinearGrid to a vtkPointSet
///
///
/// vtkRectilinearGridToPointSet takes a vtkRectilinearGrid as an image and
/// outputs an equivalent vtkStructuredGrid (which is a subclass of
/// vtkPointSet).
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// This class was developed by Kenneth Moreland (kmorelndia.gov) from
/// Sandia National Laboratories.
/// </seealso>
public class vtkRectilinearGridToPointSet : vtkStructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridToPointSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearGridToPointSet()
	{
		MRClassNameKey = "class vtkRectilinearGridToPointSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridToPointSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearGridToPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridToPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridToPointSet New()
	{
		vtkRectilinearGridToPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridToPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridToPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRectilinearGridToPointSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearGridToPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearGridToPointSet_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridToPointSet_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearGridToPointSet_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridToPointSet_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearGridToPointSet_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridToPointSet_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearGridToPointSet NewInstance()
	{
		vtkRectilinearGridToPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridToPointSet_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridToPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridToPointSet_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridToPointSet SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearGridToPointSet vtkRectilinearGridToPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridToPointSet_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGridToPointSet2 = (vtkRectilinearGridToPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGridToPointSet2.Register(null);
			}
		}
		return vtkRectilinearGridToPointSet2;
	}
}
