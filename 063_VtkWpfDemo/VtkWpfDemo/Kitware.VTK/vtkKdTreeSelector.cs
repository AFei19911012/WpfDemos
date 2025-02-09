using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKdTreeSelector
/// </summary>
/// <remarks>
///    Selects point ids using a kd-tree.
///
///
/// If SetKdTree is used, the filter ignores the input and selects based on that
/// kd-tree.  If SetKdTree is not used, the filter builds a kd-tree using the
/// input point set and uses that tree for selection.  The output is a
/// vtkSelection containing the ids found in the kd-tree using the specified
/// bounds.
/// </remarks>
public class vtkKdTreeSelector : vtkSelectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKdTreeSelector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKdTreeSelector()
	{
		MRClassNameKey = "class vtkKdTreeSelector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTreeSelector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKdTreeSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreeSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdTreeSelector New()
	{
		vtkKdTreeSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreeSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKdTreeSelector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKdTreeSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkKdTreeSelector_GetKdTree_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The kd-tree to use to find selected ids.
	/// The kd-tree must be initialized with the desired set of points.
	/// When this is set, the optional input is ignored.
	/// </summary>
	public virtual vtkKdTree GetKdTree()
	{
		vtkKdTree vtkKdTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreeSelector_GetKdTree_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKdTree2 = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKdTree2.Register(null);
			}
		}
		return vtkKdTree2;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkKdTreeSelector_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// The threshold for the single selection.
	/// A single point is added to the selection if it is within
	/// this threshold from the bounds center.
	/// Default is 1.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkKdTreeSelector_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTreeSelector_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKdTreeSelector_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTreeSelector_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKdTreeSelector_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTreeSelector_GetSelectionAttribute_05(HandleRef pThis);

	/// <summary>
	/// The field attribute to use when generating the selection.
	/// If set, creates a PEDIGREEIDS or GLOBALIDS selection.
	/// If not set (or is set to -1), creates a INDICES selection.
	/// By default this is not set.
	/// NOTE: This should be set a constant in vtkDataSetAttributes,
	/// not vtkSelection.
	/// </summary>
	public virtual int GetSelectionAttribute()
	{
		return vtkKdTreeSelector_GetSelectionAttribute_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreeSelector_GetSelectionBounds_06(HandleRef pThis);

	/// <summary>
	/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
	/// To perform a search in 2D, use the bounds
	/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
	/// </summary>
	public virtual double[] GetSelectionBounds()
	{
		IntPtr intPtr = vtkKdTreeSelector_GetSelectionBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_GetSelectionBounds_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
	/// To perform a search in 2D, use the bounds
	/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
	/// </summary>
	public virtual void GetSelectionBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkKdTreeSelector_GetSelectionBounds_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_GetSelectionBounds_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
	/// To perform a search in 2D, use the bounds
	/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
	/// </summary>
	public virtual void GetSelectionBounds(IntPtr _arg)
	{
		vtkKdTreeSelector_GetSelectionBounds_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreeSelector_GetSelectionFieldName_09(HandleRef pThis);

	/// <summary>
	/// The field name to use when generating the selection.
	/// If set, creates a VALUES selection.
	/// If not set (or is set to nullptr), creates a INDICES selection.
	/// By default this is not set.
	/// </summary>
	public virtual string GetSelectionFieldName()
	{
		return Marshal.PtrToStringAnsi(vtkKdTreeSelector_GetSelectionFieldName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKdTreeSelector_GetSingleSelection_10(HandleRef pThis);

	/// <summary>
	/// Whether to only allow up to one value in the result.
	/// The item selected is closest to the center of the bounds,
	/// if there are any points within the selection threshold.
	/// Default is off.
	/// </summary>
	public virtual bool GetSingleSelection()
	{
		return (vtkKdTreeSelector_GetSingleSelection_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKdTreeSelector_GetSingleSelectionThreshold_11(HandleRef pThis);

	/// <summary>
	/// The threshold for the single selection.
	/// A single point is added to the selection if it is within
	/// this threshold from the bounds center.
	/// Default is 1.
	/// </summary>
	public virtual double GetSingleSelectionThreshold()
	{
		return vtkKdTreeSelector_GetSingleSelectionThreshold_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTreeSelector_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKdTreeSelector_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTreeSelector_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKdTreeSelector_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreeSelector_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKdTreeSelector NewInstance()
	{
		vtkKdTreeSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreeSelector_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreeSelector_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdTreeSelector SafeDownCast(vtkObjectBase o)
	{
		vtkKdTreeSelector vtkKdTreeSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreeSelector_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKdTreeSelector2 = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKdTreeSelector2.Register(null);
			}
		}
		return vtkKdTreeSelector2;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetKdTree_17(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// The kd-tree to use to find selected ids.
	/// The kd-tree must be initialized with the desired set of points.
	/// When this is set, the optional input is ignored.
	/// </summary>
	public void SetKdTree(vtkKdTree tree)
	{
		vtkKdTreeSelector_SetKdTree_17(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetSelectionAttribute_18(HandleRef pThis, int _arg);

	/// <summary>
	/// The field attribute to use when generating the selection.
	/// If set, creates a PEDIGREEIDS or GLOBALIDS selection.
	/// If not set (or is set to -1), creates a INDICES selection.
	/// By default this is not set.
	/// NOTE: This should be set a constant in vtkDataSetAttributes,
	/// not vtkSelection.
	/// </summary>
	public virtual void SetSelectionAttribute(int _arg)
	{
		vtkKdTreeSelector_SetSelectionAttribute_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetSelectionBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
	/// To perform a search in 2D, use the bounds
	/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
	/// </summary>
	public virtual void SetSelectionBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkKdTreeSelector_SetSelectionBounds_19(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetSelectionBounds_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
	/// To perform a search in 2D, use the bounds
	/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
	/// </summary>
	public virtual void SetSelectionBounds(IntPtr _arg)
	{
		vtkKdTreeSelector_SetSelectionBounds_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetSelectionFieldName_21(HandleRef pThis, string _arg);

	/// <summary>
	/// The field name to use when generating the selection.
	/// If set, creates a VALUES selection.
	/// If not set (or is set to nullptr), creates a INDICES selection.
	/// By default this is not set.
	/// </summary>
	public virtual void SetSelectionFieldName(string _arg)
	{
		vtkKdTreeSelector_SetSelectionFieldName_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetSingleSelection_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to only allow up to one value in the result.
	/// The item selected is closest to the center of the bounds,
	/// if there are any points within the selection threshold.
	/// Default is off.
	/// </summary>
	public virtual void SetSingleSelection(bool _arg)
	{
		vtkKdTreeSelector_SetSingleSelection_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SetSingleSelectionThreshold_23(HandleRef pThis, double _arg);

	/// <summary>
	/// The threshold for the single selection.
	/// A single point is added to the selection if it is within
	/// this threshold from the bounds center.
	/// Default is 1.
	/// </summary>
	public virtual void SetSingleSelectionThreshold(double _arg)
	{
		vtkKdTreeSelector_SetSingleSelectionThreshold_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SingleSelectionOff_24(HandleRef pThis);

	/// <summary>
	/// Whether to only allow up to one value in the result.
	/// The item selected is closest to the center of the bounds,
	/// if there are any points within the selection threshold.
	/// Default is off.
	/// </summary>
	public virtual void SingleSelectionOff()
	{
		vtkKdTreeSelector_SingleSelectionOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreeSelector_SingleSelectionOn_25(HandleRef pThis);

	/// <summary>
	/// Whether to only allow up to one value in the result.
	/// The item selected is closest to the center of the bounds,
	/// if there are any points within the selection threshold.
	/// Default is off.
	/// </summary>
	public virtual void SingleSelectionOn()
	{
		vtkKdTreeSelector_SingleSelectionOn_25(GetCppThis());
	}
}
