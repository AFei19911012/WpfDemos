using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelSizeCalculator
///
/// This filter takes an input dataset, an array to process
/// (which must be a string array), and a text property.
/// It creates a new output array (named "LabelSize" by default) with
/// 4 components per tuple that contain the width, height, horizontal
/// offset, and descender height (in that order) of each string in
/// the array.
///
/// Use the inherited SelectInputArrayToProcess to indicate a string array.
/// In no input array is specified, the first of the following that
/// is a string array is used: point scalars, cell scalars, field scalars.
///
/// The second input array to process is an array specifying the type of
/// each label. Different label types may have different font properties.
/// This array must be a vtkIntArray.
/// Any type that does not map to a font property that was set will
/// be set to the type 0's type property.
/// </summary>
public class vtkLabelSizeCalculator : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelSizeCalculator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelSizeCalculator()
	{
		MRClassNameKey = "class vtkLabelSizeCalculator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelSizeCalculator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelSizeCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelSizeCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelSizeCalculator New()
	{
		vtkLabelSizeCalculator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelSizeCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabelSizeCalculator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabelSizeCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLabelSizeCalculator_GetDPI_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the DPI at which the labels are to be rendered. Defaults to 72.
	/// @sa vtkWindow::GetDPI()
	/// </summary>
	public virtual int GetDPI()
	{
		return vtkLabelSizeCalculator_GetDPI_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelSizeCalculator_GetFontProperty_02(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the font used compute label sizes.
	/// This defaults to "Arial" at 12 points.
	/// If type is provided, it refers to the type of the text label provided
	/// in the optional label type array. The default type is type 0.
	/// </summary>
	public virtual vtkTextProperty GetFontProperty(int type)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelSizeCalculator_GetFontProperty_02(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLabelSizeCalculator_GetLabelSizeArrayName_03(HandleRef pThis);

	/// <summary>
	/// The name of the output array containing text label sizes
	/// This defaults to "LabelSize"
	/// </summary>
	public virtual string GetLabelSizeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkLabelSizeCalculator_GetLabelSizeArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelSizeCalculator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelSizeCalculator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelSizeCalculator_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelSizeCalculator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelSizeCalculator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelSizeCalculator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelSizeCalculator_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelSizeCalculator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelSizeCalculator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelSizeCalculator NewInstance()
	{
		vtkLabelSizeCalculator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelSizeCalculator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelSizeCalculator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelSizeCalculator SafeDownCast(vtkObjectBase o)
	{
		vtkLabelSizeCalculator vtkLabelSizeCalculator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelSizeCalculator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelSizeCalculator2 = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelSizeCalculator2.Register(null);
			}
		}
		return vtkLabelSizeCalculator2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelSizeCalculator_SetDPI_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the DPI at which the labels are to be rendered. Defaults to 72.
	/// @sa vtkWindow::GetDPI()
	/// </summary>
	public virtual void SetDPI(int _arg)
	{
		vtkLabelSizeCalculator_SetDPI_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelSizeCalculator_SetFontProperty_12(HandleRef pThis, HandleRef fontProp, int type);

	/// <summary>
	/// Get/Set the font used compute label sizes.
	/// This defaults to "Arial" at 12 points.
	/// If type is provided, it refers to the type of the text label provided
	/// in the optional label type array. The default type is type 0.
	/// </summary>
	public virtual void SetFontProperty(vtkTextProperty fontProp, int type)
	{
		vtkLabelSizeCalculator_SetFontProperty_12(GetCppThis(), fontProp?.GetCppThis() ?? default(HandleRef), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelSizeCalculator_SetLabelSizeArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the output array containing text label sizes
	/// This defaults to "LabelSize"
	/// </summary>
	public virtual void SetLabelSizeArrayName(string _arg)
	{
		vtkLabelSizeCalculator_SetLabelSizeArrayName_13(GetCppThis(), _arg);
	}
}
