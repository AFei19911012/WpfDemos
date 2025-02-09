using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointSetToLabelHierarchy
/// </summary>
/// <remarks>
///    build a label hierarchy for a graph or point set.
///
///
///
/// Every point in the input vtkPoints object is taken to be an
/// anchor point for a label. Statistics on the input points
/// are used to subdivide an octree referencing the points
/// until the points each octree node contains have a variance
/// close to the node size and a limited population (&lt; 100).
/// </remarks>
public class vtkPointSetToLabelHierarchy : vtkLabelHierarchyAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToLabelHierarchy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSetToLabelHierarchy()
	{
		MRClassNameKey = "class vtkPointSetToLabelHierarchy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToLabelHierarchy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSetToLabelHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointSetToLabelHierarchy New()
	{
		vtkPointSetToLabelHierarchy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToLabelHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPointSetToLabelHierarchy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSetToLabelHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetBoundedSizeArrayName_01(HandleRef pThis);

	/// <summary>
	/// Set/get the maximum text width (in world coordinates) array name.
	/// </summary>
	public virtual string GetBoundedSizeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy_GetBoundedSizeArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetIconIndexArrayName_02(HandleRef pThis);

	/// <summary>
	/// Set/get the icon index array name.
	/// </summary>
	public virtual string GetIconIndexArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy_GetIconIndexArrayName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetLabelArrayName_03(HandleRef pThis);

	/// <summary>
	/// Set/get the label array name.
	/// </summary>
	public virtual string GetLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy_GetLabelArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToLabelHierarchy_GetMaximumDepth_04(HandleRef pThis);

	/// <summary>
	/// Set/get the maximum tree depth in the output hierarchy.
	/// </summary>
	public virtual int GetMaximumDepth()
	{
		return vtkPointSetToLabelHierarchy_GetMaximumDepth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetOrientationArrayName_07(HandleRef pThis);

	/// <summary>
	/// Set/get the text orientation array name.
	/// </summary>
	public virtual string GetOrientationArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy_GetOrientationArrayName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetPriorityArrayName_08(HandleRef pThis);

	/// <summary>
	/// Set/get the priority array name.
	/// </summary>
	public virtual string GetPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy_GetPriorityArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetSizeArrayName_09(HandleRef pThis);

	/// <summary>
	/// Set/get the priority array name.
	/// </summary>
	public virtual string GetSizeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy_GetSizeArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToLabelHierarchy_GetTargetLabelCount_10(HandleRef pThis);

	/// <summary>
	/// Set/get the "ideal" number of labels to associate with each node in the output hierarchy.
	/// </summary>
	public virtual int GetTargetLabelCount()
	{
		return vtkPointSetToLabelHierarchy_GetTargetLabelCount_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_GetTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the text property assigned to the hierarchy.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToLabelHierarchy_GetTextProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToLabelHierarchy_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointSetToLabelHierarchy_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToLabelHierarchy_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointSetToLabelHierarchy_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPointSetToLabelHierarchy NewInstance()
	{
		vtkPointSetToLabelHierarchy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToLabelHierarchy_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToLabelHierarchy_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointSetToLabelHierarchy SafeDownCast(vtkObjectBase o)
	{
		vtkPointSetToLabelHierarchy vtkPointSetToLabelHierarchy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToLabelHierarchy_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSetToLabelHierarchy2 = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSetToLabelHierarchy2.Register(null);
			}
		}
		return vtkPointSetToLabelHierarchy2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetBoundedSizeArrayName_17(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the maximum text width (in world coordinates) array name.
	/// </summary>
	public virtual void SetBoundedSizeArrayName(string name)
	{
		vtkPointSetToLabelHierarchy_SetBoundedSizeArrayName_17(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetIconIndexArrayName_18(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the icon index array name.
	/// </summary>
	public virtual void SetIconIndexArrayName(string name)
	{
		vtkPointSetToLabelHierarchy_SetIconIndexArrayName_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetLabelArrayName_19(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the label array name.
	/// </summary>
	public virtual void SetLabelArrayName(string name)
	{
		vtkPointSetToLabelHierarchy_SetLabelArrayName_19(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetMaximumDepth_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the maximum tree depth in the output hierarchy.
	/// </summary>
	public virtual void SetMaximumDepth(int _arg)
	{
		vtkPointSetToLabelHierarchy_SetMaximumDepth_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetOrientationArrayName_21(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the text orientation array name.
	/// </summary>
	public virtual void SetOrientationArrayName(string name)
	{
		vtkPointSetToLabelHierarchy_SetOrientationArrayName_21(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetPriorityArrayName_22(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the priority array name.
	/// </summary>
	public virtual void SetPriorityArrayName(string name)
	{
		vtkPointSetToLabelHierarchy_SetPriorityArrayName_22(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetSizeArrayName_23(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the priority array name.
	/// </summary>
	public virtual void SetSizeArrayName(string name)
	{
		vtkPointSetToLabelHierarchy_SetSizeArrayName_23(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetTargetLabelCount_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the "ideal" number of labels to associate with each node in the output hierarchy.
	/// </summary>
	public virtual void SetTargetLabelCount(int _arg)
	{
		vtkPointSetToLabelHierarchy_SetTargetLabelCount_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToLabelHierarchy_SetTextProperty_25(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// Set/get the text property assigned to the hierarchy.
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty tprop)
	{
		vtkPointSetToLabelHierarchy_SetTextProperty_25(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}
}
