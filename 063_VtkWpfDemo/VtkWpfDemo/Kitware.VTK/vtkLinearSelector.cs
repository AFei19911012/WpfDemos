using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinearSelector
/// </summary>
/// <remarks>
///    select cells intersecting a line (possibly broken)
///
///
/// This filter takes a vtkCompositeDataSet as input and a line segment as parameter.
/// It outputs a vtkSelection identifying all the cells intersecting the given line segment.
///
/// @par Thanks:
/// This class has been initially developed in the frame of CEA's Love visualization software
/// development &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt; BP12,
/// F-91297 Arpajon, France. &lt;br&gt; Modified and integrated into VTK, Kitware SAS 2012 This class was
/// implemented by Thierry Carrard, Charles Pignerol, and Philippe Pebay.
/// </remarks>
public class vtkLinearSelector : vtkSelectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinearSelector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinearSelector()
	{
		MRClassNameKey = "class vtkLinearSelector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearSelector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinearSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLinearSelector New()
	{
		vtkLinearSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLinearSelector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLinearSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSelector_GetEndPoint_01(HandleRef pThis);

	/// <summary>
	/// Set/Get end point of intersecting segment
	/// </summary>
	public virtual double[] GetEndPoint()
	{
		IntPtr intPtr = vtkLinearSelector_GetEndPoint_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_GetEndPoint_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get end point of intersecting segment
	/// </summary>
	public virtual void GetEndPoint(IntPtr data)
	{
		vtkLinearSelector_GetEndPoint_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLinearSelector_GetIncludeVertices_03(HandleRef pThis);

	/// <summary>
	/// Set/Get whether lines vertice are included in selection
	/// </summary>
	public virtual bool GetIncludeVertices()
	{
		return (vtkLinearSelector_GetIncludeVertices_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearSelector_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinearSelector_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearSelector_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinearSelector_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSelector_GetPoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the list of points defining the intersecting broken line
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSelector_GetPoints_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSelector_GetStartPoint_07(HandleRef pThis);

	/// <summary>
	/// Set/Get starting point of intersecting segment
	/// </summary>
	public virtual double[] GetStartPoint()
	{
		IntPtr intPtr = vtkLinearSelector_GetStartPoint_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_GetStartPoint_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get starting point of intersecting segment
	/// </summary>
	public virtual void GetStartPoint(IntPtr data)
	{
		vtkLinearSelector_GetStartPoint_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinearSelector_GetTolerance_09(HandleRef pThis);

	/// <summary>
	/// Set/Get tolerance to be used by intersection algorithm
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkLinearSelector_GetTolerance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinearSelector_GetVertexEliminationTolerance_10(HandleRef pThis);

	/// <summary>
	/// Set/Get relative tolerance for vertex elimination
	/// </summary>
	public virtual double GetVertexEliminationTolerance()
	{
		return vtkLinearSelector_GetVertexEliminationTolerance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinearSelector_GetVertexEliminationToleranceMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get relative tolerance for vertex elimination
	/// </summary>
	public virtual double GetVertexEliminationToleranceMaxValue()
	{
		return vtkLinearSelector_GetVertexEliminationToleranceMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinearSelector_GetVertexEliminationToleranceMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get relative tolerance for vertex elimination
	/// </summary>
	public virtual double GetVertexEliminationToleranceMinValue()
	{
		return vtkLinearSelector_GetVertexEliminationToleranceMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_IncludeVerticesOff_13(HandleRef pThis);

	/// <summary>
	/// Set/Get whether lines vertice are included in selection
	/// </summary>
	public virtual void IncludeVerticesOff()
	{
		vtkLinearSelector_IncludeVerticesOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_IncludeVerticesOn_14(HandleRef pThis);

	/// <summary>
	/// Set/Get whether lines vertice are included in selection
	/// </summary>
	public virtual void IncludeVerticesOn()
	{
		vtkLinearSelector_IncludeVerticesOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearSelector_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinearSelector_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearSelector_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinearSelector_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSelector_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLinearSelector NewInstance()
	{
		vtkLinearSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSelector_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSelector_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLinearSelector SafeDownCast(vtkObjectBase o)
	{
		vtkLinearSelector vtkLinearSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSelector_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearSelector2 = (vtkLinearSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearSelector2.Register(null);
			}
		}
		return vtkLinearSelector2;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetEndPoint_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get end point of intersecting segment
	/// </summary>
	public virtual void SetEndPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkLinearSelector_SetEndPoint_20(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetEndPoint_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get end point of intersecting segment
	/// </summary>
	public virtual void SetEndPoint(IntPtr _arg)
	{
		vtkLinearSelector_SetEndPoint_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetIncludeVertices_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether lines vertice are included in selection
	/// </summary>
	public virtual void SetIncludeVertices(bool _arg)
	{
		vtkLinearSelector_SetIncludeVertices_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetPoints_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the list of points defining the intersecting broken line
	/// </summary>
	public virtual void SetPoints(vtkPoints arg0)
	{
		vtkLinearSelector_SetPoints_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetStartPoint_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get starting point of intersecting segment
	/// </summary>
	public virtual void SetStartPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkLinearSelector_SetStartPoint_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetStartPoint_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get starting point of intersecting segment
	/// </summary>
	public virtual void SetStartPoint(IntPtr _arg)
	{
		vtkLinearSelector_SetStartPoint_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetTolerance_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get tolerance to be used by intersection algorithm
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkLinearSelector_SetTolerance_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearSelector_SetVertexEliminationTolerance_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get relative tolerance for vertex elimination
	/// </summary>
	public virtual void SetVertexEliminationTolerance(double _arg)
	{
		vtkLinearSelector_SetVertexEliminationTolerance_27(GetCppThis(), _arg);
	}
}
