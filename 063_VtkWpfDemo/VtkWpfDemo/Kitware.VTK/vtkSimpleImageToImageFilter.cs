using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimpleImageToImageFilter
/// </summary>
/// <remarks>
///    Generic image filter with one input.
///
/// vtkSimpleImageToImageFilter is a filter which aims to avoid much
/// of the complexity associated with vtkImageAlgorithm (i.e.
/// support for pieces, multi-threaded operation). If you need to write
/// a simple image-image filter which operates on the whole input, use
/// this as the superclass. The subclass has to provide only an execute
/// method which takes input and output as arguments. Memory allocation
/// is handled in vtkSimpleImageToImageFilter. Also, you are guaranteed to
/// have a valid input in the Execute(input, output) method. By default,
/// this filter
/// requests it's input's whole extent and copies the input's information
/// (spacing, whole extent etc...) to the output. If the output's setup
/// is different (for example, if it performs some sort of sub-sampling),
/// ExecuteInformation has to be overwritten. As an example of how this
/// can be done, you can look at vtkImageShrink3D::ExecuteInformation.
/// For a complete example which uses templates to support generic data
/// types, see vtkSimpleImageToImageFilter.
///
/// </remarks>
/// <seealso>
///
/// vtkImageAlgorithm vtkSimpleImageFilterExample
/// </seealso>
public abstract class vtkSimpleImageToImageFilter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleImageToImageFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimpleImageToImageFilter()
	{
		MRClassNameKey = "class vtkSimpleImageToImageFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleImageToImageFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimpleImageToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleImageToImageFilter_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimpleImageToImageFilter_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleImageToImageFilter_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimpleImageToImageFilter_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleImageToImageFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimpleImageToImageFilter NewInstance()
	{
		vtkSimpleImageToImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleImageToImageFilter_NewInstance_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleImageToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleImageToImageFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleImageToImageFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSimpleImageToImageFilter vtkSimpleImageToImageFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleImageToImageFilter_SafeDownCast_06(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimpleImageToImageFilter2 = (vtkSimpleImageToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimpleImageToImageFilter2.Register(null);
			}
		}
		return vtkSimpleImageToImageFilter2;
	}
}
