using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeMapToPolyData
/// </summary>
/// <remarks>
///    converts a tree to a polygonal data representing a tree map
///
///
/// This algorithm requires that the vtkTreeMapLayout filter has already applied to the
/// data in order to create the quadruple array (min x, max x, min y, max y) of
/// bounds for each vertex of the tree.
/// </remarks>
public class vtkTreeMapToPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapToPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeMapToPolyData()
	{
		MRClassNameKey = "class vtkTreeMapToPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapToPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeMapToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeMapToPolyData New()
	{
		vtkTreeMapToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeMapToPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeMapToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTreeMapToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// The spacing along the z-axis between tree map levels.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkTreeMapToPolyData_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeMapToPolyData_GetAddNormals_02(HandleRef pThis);

	/// <summary>
	/// The spacing along the z-axis between tree map levels.
	/// </summary>
	public virtual bool GetAddNormals()
	{
		return (vtkTreeMapToPolyData_GetAddNormals_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeMapToPolyData_GetLevelDeltaZ_03(HandleRef pThis);

	/// <summary>
	/// The spacing along the z-axis between tree map levels.
	/// </summary>
	public virtual double GetLevelDeltaZ()
	{
		return vtkTreeMapToPolyData_GetLevelDeltaZ_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeMapToPolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeMapToPolyData_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeMapToPolyData_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeMapToPolyData_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeMapToPolyData_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeMapToPolyData_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeMapToPolyData_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeMapToPolyData_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapToPolyData_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeMapToPolyData NewInstance()
	{
		vtkTreeMapToPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapToPolyData_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapToPolyData_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeMapToPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkTreeMapToPolyData vtkTreeMapToPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapToPolyData_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeMapToPolyData2 = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeMapToPolyData2.Register(null);
			}
		}
		return vtkTreeMapToPolyData2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapToPolyData_SetAddNormals_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// The spacing along the z-axis between tree map levels.
	/// </summary>
	public virtual void SetAddNormals(bool _arg)
	{
		vtkTreeMapToPolyData_SetAddNormals_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapToPolyData_SetLevelArrayName_12(HandleRef pThis, string name);

	/// <summary>
	/// The field containing the level of each tree node.
	/// This can be added using vtkTreeLevelsFilter before this filter.
	/// If this is not present, the filter simply calls tree-&gt;GetLevel(v) for
	/// each vertex, which will produce the same result, but
	/// may not be as efficient.
	/// </summary>
	public virtual void SetLevelArrayName(string name)
	{
		vtkTreeMapToPolyData_SetLevelArrayName_12(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapToPolyData_SetLevelDeltaZ_13(HandleRef pThis, double _arg);

	/// <summary>
	/// The spacing along the z-axis between tree map levels.
	/// </summary>
	public virtual void SetLevelDeltaZ(double _arg)
	{
		vtkTreeMapToPolyData_SetLevelDeltaZ_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapToPolyData_SetRectanglesArrayName_14(HandleRef pThis, string name);

	/// <summary>
	/// The field containing quadruples of the form (min x, max x, min y, max y)
	/// representing the bounds of the rectangles for each vertex.
	/// This array may be added to the tree using vtkTreeMapLayout.
	/// </summary>
	public virtual void SetRectanglesArrayName(string name)
	{
		vtkTreeMapToPolyData_SetRectanglesArrayName_14(GetCppThis(), name);
	}
}
