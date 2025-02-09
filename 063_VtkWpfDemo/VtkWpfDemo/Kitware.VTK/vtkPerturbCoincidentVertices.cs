using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPerturbCoincidentVertices
/// </summary>
/// <remarks>
///    Perturbs vertices that are coincident.
///
///
/// This filter perturbs vertices in a graph that have coincident coordinates.
/// In particular this happens all the time with graphs that are georeferenced,
/// so we need a nice scheme to perturb the vertices so that when the user
/// zooms in the vertices can be distiquished.
/// </remarks>
public class vtkPerturbCoincidentVertices : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPerturbCoincidentVertices";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPerturbCoincidentVertices()
	{
		MRClassNameKey = "class vtkPerturbCoincidentVertices";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerturbCoincidentVertices"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPerturbCoincidentVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerturbCoincidentVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPerturbCoincidentVertices New()
	{
		vtkPerturbCoincidentVertices result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerturbCoincidentVertices_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPerturbCoincidentVertices()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPerturbCoincidentVertices_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPerturbCoincidentVertices_GetPerturbFactor_03(HandleRef pThis);

	/// <summary>
	/// Specify the perturbation factor (defaults to 1.0)
	/// </summary>
	public virtual double GetPerturbFactor()
	{
		return vtkPerturbCoincidentVertices_GetPerturbFactor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerturbCoincidentVertices_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPerturbCoincidentVertices_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerturbCoincidentVertices_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPerturbCoincidentVertices_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerturbCoincidentVertices_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPerturbCoincidentVertices NewInstance()
	{
		vtkPerturbCoincidentVertices result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerturbCoincidentVertices_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerturbCoincidentVertices_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPerturbCoincidentVertices SafeDownCast(vtkObjectBase o)
	{
		vtkPerturbCoincidentVertices vtkPerturbCoincidentVertices2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerturbCoincidentVertices_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPerturbCoincidentVertices2 = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPerturbCoincidentVertices2.Register(null);
			}
		}
		return vtkPerturbCoincidentVertices2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerturbCoincidentVertices_SetPerturbFactor_09(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the perturbation factor (defaults to 1.0)
	/// </summary>
	public virtual void SetPerturbFactor(double _arg)
	{
		vtkPerturbCoincidentVertices_SetPerturbFactor_09(GetCppThis(), _arg);
	}
}
