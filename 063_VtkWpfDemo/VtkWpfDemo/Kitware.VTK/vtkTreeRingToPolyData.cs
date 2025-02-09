using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeRingToPolyData
/// </summary>
/// <remarks>
///    converts a tree to a polygonal data
/// representing radial space filling tree.
///
///
/// This algorithm requires that the vtkTreeRingLayout filter has already
/// been applied to the data in order to create the quadruple array
/// (start angle, end angle, inner radius, outer radius) of bounds
/// for each vertex of the tree.
/// </remarks>
public class vtkTreeRingToPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeRingToPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeRingToPolyData()
	{
		MRClassNameKey = "class vtkTreeRingToPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeRingToPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeRingToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeRingToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeRingToPolyData New()
	{
		vtkTreeRingToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeRingToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeRingToPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeRingToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeRingToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Define a shrink percentage for each of the sectors.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkTreeRingToPolyData_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeRingToPolyData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeRingToPolyData_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeRingToPolyData_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeRingToPolyData_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeRingToPolyData_GetShrinkPercentage_04(HandleRef pThis);

	/// <summary>
	/// Define a shrink percentage for each of the sectors.
	/// </summary>
	public virtual double GetShrinkPercentage()
	{
		return vtkTreeRingToPolyData_GetShrinkPercentage_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeRingToPolyData_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeRingToPolyData_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeRingToPolyData_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeRingToPolyData_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeRingToPolyData_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeRingToPolyData NewInstance()
	{
		vtkTreeRingToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeRingToPolyData_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeRingToPolyData_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeRingToPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkTreeRingToPolyData vtkTreeRingToPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeRingToPolyData_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeRingToPolyData2 = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeRingToPolyData2.Register(null);
			}
		}
		return vtkTreeRingToPolyData2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingToPolyData_SetSectorsArrayName_10(HandleRef pThis, string name);

	/// <summary>
	/// The field containing quadruples of the form (start angle, end angle,
	/// inner radius, outer radius)
	/// representing the bounds of the rectangles for each vertex.
	/// This field may be added to the tree using vtkTreeRingLayout.
	/// This array must be set.
	/// </summary>
	public virtual void SetSectorsArrayName(string name)
	{
		vtkTreeRingToPolyData_SetSectorsArrayName_10(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingToPolyData_SetShrinkPercentage_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Define a shrink percentage for each of the sectors.
	/// </summary>
	public virtual void SetShrinkPercentage(double _arg)
	{
		vtkTreeRingToPolyData_SetShrinkPercentage_11(GetCppThis(), _arg);
	}
}
