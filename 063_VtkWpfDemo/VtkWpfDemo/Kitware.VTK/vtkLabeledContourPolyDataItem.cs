using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabeledContourPolyDataItem
/// </summary>
/// <remarks>
///    Filter that translate a vtkPolyData 2D mesh into vtkContextItems.
///
/// @warning
/// The input vtkPolyData should be a 2D mesh.
///
/// </remarks>
public class vtkLabeledContourPolyDataItem : vtkPolyDataItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledContourPolyDataItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabeledContourPolyDataItem()
	{
		MRClassNameKey = "class vtkLabeledContourPolyDataItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledContourPolyDataItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabeledContourPolyDataItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourPolyDataItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabeledContourPolyDataItem New()
	{
		vtkLabeledContourPolyDataItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourPolyDataItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledContourPolyDataItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabeledContourPolyDataItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabeledContourPolyDataItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabeledContourPolyDataItem_GetLabelVisibility_01(HandleRef pThis);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual bool GetLabelVisibility()
	{
		return (vtkLabeledContourPolyDataItem_GetLabelVisibility_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabeledContourPolyDataItem_GetSkipDistance_04(HandleRef pThis);

	/// <summary>
	/// Ensure that there are at least SkipDistance pixels between labels. This
	/// is only enforced on labels along the same line. The default is 0.
	/// </summary>
	public virtual double GetSkipDistance()
	{
		return vtkLabeledContourPolyDataItem_GetSkipDistance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourPolyDataItem_GetTextProperties_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text properties used to label the lines. Note that both vertical and
	/// horizontal justifications will be reset to "Centered" prior to rendering.
	///
	/// If the TextPropertyMapping array exists, then it is used to identify which
	/// text property to use for each label as follows: If the scalar value of a
	/// line is found in the mapping, the index of the value in mapping is used to
	/// lookup the text property in the collection. If there are more mapping
	/// values than properties, the properties are looped through until the
	/// mapping is exhausted.
	///
	/// Lines with scalar values missing from the mapping are assigned text
	/// properties in a round-robin fashion starting from the beginning of the
	/// collection, repeating from the start of the collection as necessary.
	/// @sa SetTextProperty
	/// @sa SetTextPropertyMapping
	/// </summary>
	public virtual vtkTextPropertyCollection GetTextProperties()
	{
		vtkTextPropertyCollection vtkTextPropertyCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourPolyDataItem_GetTextProperties_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextPropertyCollection2 = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextPropertyCollection2.Register(null);
			}
		}
		return vtkTextPropertyCollection2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourPolyDataItem_GetTextPropertyMapping_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Values in this array correspond to vtkTextProperty objects in the
	/// TextProperties collection. If a contour line's scalar value exists in
	/// this array, the corresponding text property is used for the label.
	/// See SetTextProperties for more information.
	/// </summary>
	public virtual vtkDoubleArray GetTextPropertyMapping()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourPolyDataItem_GetTextPropertyMapping_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledContourPolyDataItem_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabeledContourPolyDataItem_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledContourPolyDataItem_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabeledContourPolyDataItem_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_LabelVisibilityOff_09(HandleRef pThis);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkLabeledContourPolyDataItem_LabelVisibilityOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_LabelVisibilityOn_10(HandleRef pThis);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkLabeledContourPolyDataItem_LabelVisibilityOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourPolyDataItem_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabeledContourPolyDataItem NewInstance()
	{
		vtkLabeledContourPolyDataItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourPolyDataItem_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledContourPolyDataItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabeledContourPolyDataItem_Paint_13(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkLabeledContourPolyDataItem_Paint_13(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledContourPolyDataItem_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabeledContourPolyDataItem SafeDownCast(vtkObjectBase o)
	{
		vtkLabeledContourPolyDataItem vtkLabeledContourPolyDataItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledContourPolyDataItem_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabeledContourPolyDataItem2 = (vtkLabeledContourPolyDataItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabeledContourPolyDataItem2.Register(null);
			}
		}
		return vtkLabeledContourPolyDataItem2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_SetLabelVisibility_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, labels will be placed and drawn during rendering. Otherwise,
	/// only the mapper returned by GetPolyDataMapper() will be rendered.
	/// The default is to draw labels.
	/// </summary>
	public virtual void SetLabelVisibility(bool _arg)
	{
		vtkLabeledContourPolyDataItem_SetLabelVisibility_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_SetSkipDistance_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Ensure that there are at least SkipDistance pixels between labels. This
	/// is only enforced on labels along the same line. The default is 0.
	/// </summary>
	public virtual void SetSkipDistance(double _arg)
	{
		vtkLabeledContourPolyDataItem_SetSkipDistance_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_SetTextProperties_17(HandleRef pThis, HandleRef coll);

	/// <summary>
	/// The text properties used to label the lines. Note that both vertical and
	/// horizontal justifications will be reset to "Centered" prior to rendering.
	///
	/// If the TextPropertyMapping array exists, then it is used to identify which
	/// text property to use for each label as follows: If the scalar value of a
	/// line is found in the mapping, the index of the value in mapping is used to
	/// lookup the text property in the collection. If there are more mapping
	/// values than properties, the properties are looped through until the
	/// mapping is exhausted.
	///
	/// Lines with scalar values missing from the mapping are assigned text
	/// properties in a round-robin fashion starting from the beginning of the
	/// collection, repeating from the start of the collection as necessary.
	/// @sa SetTextProperty
	/// @sa SetTextPropertyMapping
	/// </summary>
	public virtual void SetTextProperties(vtkTextPropertyCollection coll)
	{
		vtkLabeledContourPolyDataItem_SetTextProperties_17(GetCppThis(), coll?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_SetTextProperty_18(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The text property used to label the lines. Note that both vertical and
	/// horizontal justifications will be reset to "Centered" prior to rendering.
	/// @note This is a convenience method that clears TextProperties and inserts
	/// the argument as the only property in the collection.
	/// @sa SetTextProperties
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty tprop)
	{
		vtkLabeledContourPolyDataItem_SetTextProperty_18(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledContourPolyDataItem_SetTextPropertyMapping_19(HandleRef pThis, HandleRef mapping);

	/// <summary>
	/// Values in this array correspond to vtkTextProperty objects in the
	/// TextProperties collection. If a contour line's scalar value exists in
	/// this array, the corresponding text property is used for the label.
	/// See SetTextProperties for more information.
	/// </summary>
	public virtual void SetTextPropertyMapping(vtkDoubleArray mapping)
	{
		vtkLabeledContourPolyDataItem_SetTextPropertyMapping_19(GetCppThis(), mapping?.GetCppThis() ?? default(HandleRef));
	}
}
