using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImagePointIterator
/// </summary>
/// <remarks>
///    iterate over all data points in an image.
///
/// This class will iterate over an image.  For each position, it provides
/// the (x,y,z) position, the (I,J,K) index, and the point Id.  If a stencil
/// is provided, then it also reports, for each point, whether the point is
/// inside the stencil.
/// &lt;p&gt;The iterator can go through the image point-by-point or span-by-span.
/// The Next() method advances to the next point, while the NextSpan() method
/// skips to the beginning of the next span, where a span is defined as a
/// start position and point count within an image row.
/// </remarks>
/// <seealso>
///
/// vtkImageData vtkImageStencilData vtkImageProgressIterator
/// </seealso>
public class vtkImagePointIterator : vtkImagePointDataIterator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImagePointIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImagePointIterator()
	{
		MRClassNameKey = "class vtkImagePointIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePointIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImagePointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkImagePointIterator_GetPosition_01(HandleRef pThis);

	/// <summary>
	/// Get the current position.
	/// </summary>
	public double[] GetPosition()
	{
		IntPtr intPtr = vtkImagePointIterator_GetPosition_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointIterator_GetPosition_02(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the current position and place it in the provided array.
	/// </summary>
	public void GetPosition(IntPtr x)
	{
		vtkImagePointIterator_GetPosition_02(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointIterator_Initialize_03(HandleRef pThis, HandleRef image, IntPtr extent, HandleRef stencil, HandleRef algorithm, int threadId);

	/// <summary>
	/// Initialize an iterator.  See constructor for more details.
	/// </summary>
	public new void Initialize(vtkImageData image, IntPtr extent, vtkImageStencilData stencil, vtkAlgorithm algorithm, int threadId)
	{
		vtkImagePointIterator_Initialize_03(GetCppThis(), image?.GetCppThis() ?? default(HandleRef), extent, stencil?.GetCppThis() ?? default(HandleRef), algorithm?.GetCppThis() ?? default(HandleRef), threadId);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImagePointIterator_IsAtEnd_04(HandleRef pThis);

	/// <summary>
	/// Test if the iterator has completed iterating over the entire extent.
	/// </summary>
	public new bool IsAtEnd()
	{
		return (vtkImagePointIterator_IsAtEnd_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointIterator_Next_05(HandleRef pThis);

	/// <summary>
	/// Move to the next position (rather than directly to the next span).
	/// This will automatically advance to the next span if the end of the
	/// current span is reached.
	/// </summary>
	public void Next()
	{
		vtkImagePointIterator_Next_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePointIterator_NextSpan_06(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the beginning of the next span.
	/// A span is a contiguous region of the image over which nothing but
	/// the point Id and the X index changes.
	/// </summary>
	public new void NextSpan()
	{
		vtkImagePointIterator_NextSpan_06(GetCppThis());
	}
}
