using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImagePointDataIterator
/// </summary>
/// <remarks>
///    iterate over point data in an image.
///
/// This class will iterate over an image.  For each position, it will
/// provide the (I,J,K) index, the point Id, and if a stencil is supplied,
/// it will report whether the point is inside or outside of the stencil.
/// &lt;p&gt;For efficiency, this class iterates over spans rather than points.
/// Each span is one image row or partial row, defined by a start position
/// and a size.  Within a span, only the X index and the point Id will change.
/// The vtkImagePointDataIterator and related iterators are the preferred
/// method of iterating over image data within the VTK image filters.
/// </remarks>
/// <seealso>
///
/// vtkImageData vtkImageStencilData vtkImageProgressIterator
/// </seealso>
public class vtkImagePointDataIterator : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImagePointDataIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImagePointDataIterator()
	{
		MRClassNameKey = "class vtkImagePointDataIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePointDataIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImagePointDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImagePointDataIterator_GetId_01(HandleRef pThis);

	/// <summary>
	/// Get the point Id at the beginning of the current span.
	/// </summary>
	public long GetId()
	{
		return vtkImagePointDataIterator_GetId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointDataIterator_GetIndex_02(HandleRef pThis, IntPtr result);

	/// <summary>
	/// Get the index at the beginning of the current span.
	/// </summary>
	public void GetIndex(IntPtr result)
	{
		vtkImagePointDataIterator_GetIndex_02(GetCppThis(), result);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePointDataIterator_GetIndex_03(HandleRef pThis);

	/// <summary>
	/// Get the index at the beginning of the current span.
	/// </summary>
	public int[] GetIndex()
	{
		IntPtr intPtr = vtkImagePointDataIterator_GetIndex_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePointDataIterator_GetVoidPointer_04(HandleRef image, long i, IntPtr pixelIncrement);

	/// <summary>
	/// Get a void pointer and pixel increment for the given point Id.
	/// The pixel increment is the number of scalar components.
	/// </summary>
	public static IntPtr GetVoidPointer(vtkImageData image, long i, IntPtr pixelIncrement)
	{
		return vtkImagePointDataIterator_GetVoidPointer_04(image?.GetCppThis() ?? default(HandleRef), i, pixelIncrement);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePointDataIterator_GetVoidPointer_05(HandleRef array, long i, IntPtr pixelIncrement);

	/// <summary>
	/// Get a void pointer and pixel increment for the given point Id.
	/// The array must be the same size as the image.  The pixel increment
	/// that is returned will be the number of components for the array.
	/// </summary>
	public static IntPtr GetVoidPointer(vtkDataArray array, long i, IntPtr pixelIncrement)
	{
		return vtkImagePointDataIterator_GetVoidPointer_05(array?.GetCppThis() ?? default(HandleRef), i, pixelIncrement);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointDataIterator_Initialize_06(HandleRef pThis, HandleRef image, IntPtr extent, HandleRef stencil, HandleRef algorithm, int threadId);

	/// <summary>
	/// Initialize an iterator.  See constructor for more details.
	/// </summary>
	public void Initialize(vtkImageData image, IntPtr extent, vtkImageStencilData stencil, vtkAlgorithm algorithm, int threadId)
	{
		vtkImagePointDataIterator_Initialize_06(GetCppThis(), image?.GetCppThis() ?? default(HandleRef), extent, stencil?.GetCppThis() ?? default(HandleRef), algorithm?.GetCppThis() ?? default(HandleRef), threadId);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImagePointDataIterator_IsAtEnd_07(HandleRef pThis);

	/// <summary>
	/// Test if the iterator has completed iterating over the entire extent.
	/// </summary>
	public bool IsAtEnd()
	{
		return (vtkImagePointDataIterator_IsAtEnd_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImagePointDataIterator_IsInStencil_08(HandleRef pThis);

	/// <summary>
	/// Check if the iterator is within the region specified by the stencil.
	/// This is updated when NextSpan() is called.
	/// </summary>
	public bool IsInStencil()
	{
		return (vtkImagePointDataIterator_IsInStencil_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointDataIterator_NextSpan_09(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the beginning of the next span.
	/// A span is a contiguous region of the image over which nothing but
	/// the point Id and the X index changes.
	/// </summary>
	public void NextSpan()
	{
		vtkImagePointDataIterator_NextSpan_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImagePointDataIterator_SpanEndId_10(HandleRef pThis);

	/// <summary>
	/// Get the end of the span.
	/// </summary>
	public long SpanEndId()
	{
		return vtkImagePointDataIterator_SpanEndId_10(GetCppThis());
	}
}
