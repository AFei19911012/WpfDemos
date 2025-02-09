using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDataLIC2D
///
///
///  GPU implementation of a Line Integral Convolution, a technique for
///  imaging vector fields.
///
///  The input on port 0 is an vtkImageData with extents of a 2D image. It needs
///  a vector field on point data. This filter only works on point vectors. One
///  can use a vtkCellDataToPointData filter to convert cell vectors to point
///  vectors.
///
///  Port 1 is a special port for customized noise input. It is an optional port.
///  If noise input is not specified, then the filter using vtkImageNoiseSource to
///  generate a 128x128 noise texture.
///
/// </summary>
/// <seealso>
///
///  vtkSurfaceLICPainter vtkLineIntegralConvolution2D
/// </seealso>
public class vtkImageDataLIC2D : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataLIC2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDataLIC2D()
	{
		MRClassNameKey = "class vtkImageDataLIC2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataLIC2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDataLIC2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataLIC2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDataLIC2D New()
	{
		vtkImageDataLIC2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataLIC2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageDataLIC2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageDataLIC2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataLIC2D_GetContext_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
	/// This does not increase the reference count of the
	/// context to avoid reference loops.
	/// SetContext() may raise an error if the OpenGL context does not support the
	/// required OpenGL extensions. Return 0 upon failure and 1 upon success.
	/// </summary>
	public vtkRenderWindow GetContext()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataLIC2D_GetContext_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataLIC2D_GetMagnification_02(HandleRef pThis);

	/// <summary>
	/// The magnification factor. Default is 1
	/// </summary>
	public virtual int GetMagnification()
	{
		return vtkImageDataLIC2D_GetMagnification_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataLIC2D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDataLIC2D_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataLIC2D_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDataLIC2D_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataLIC2D_GetOpenGLExtensionsSupported_05(HandleRef pThis);

	/// <summary>
	/// Check if the required OpenGL extensions / GPU are supported.
	/// </summary>
	public virtual int GetOpenGLExtensionsSupported()
	{
		return vtkImageDataLIC2D_GetOpenGLExtensionsSupported_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageDataLIC2D_GetStepSize_06(HandleRef pThis);

	/// <summary>
	/// Step size.
	/// Specify the step size as a unit of the cell length of the input vector
	/// field. Cell length is the length of the diagonal of a cell.
	/// Initial value is 1.0.
	/// class invariant: StepSize&gt;0.0.
	/// In term of visual quality, the smaller the better.
	/// The type for the interface is double as VTK interface is double
	/// but GPU only supports float. This value will be converted to
	/// float in the execution of the algorithm.
	/// </summary>
	public virtual double GetStepSize()
	{
		return vtkImageDataLIC2D_GetStepSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataLIC2D_GetSteps_07(HandleRef pThis);

	/// <summary>
	/// Number of steps. Initial value is 20.
	/// class invariant: Steps&gt;0.
	/// In term of visual quality, the greater the better.
	/// </summary>
	public virtual int GetSteps()
	{
		return vtkImageDataLIC2D_GetSteps_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataLIC2D_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDataLIC2D_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataLIC2D_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDataLIC2D_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataLIC2D_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageDataLIC2D NewInstance()
	{
		vtkImageDataLIC2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataLIC2D_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataLIC2D_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDataLIC2D SafeDownCast(vtkObjectBase o)
	{
		vtkImageDataLIC2D vtkImageDataLIC2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataLIC2D_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDataLIC2D2 = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDataLIC2D2.Register(null);
			}
		}
		return vtkImageDataLIC2D2;
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataLIC2D_SetContext_13(HandleRef pThis, HandleRef context);

	/// <summary>
	/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
	/// This does not increase the reference count of the
	/// context to avoid reference loops.
	/// SetContext() may raise an error if the OpenGL context does not support the
	/// required OpenGL extensions. Return 0 upon failure and 1 upon success.
	/// </summary>
	public int SetContext(vtkRenderWindow context)
	{
		return vtkImageDataLIC2D_SetContext_13(GetCppThis(), context?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataLIC2D_SetMagnification_14(HandleRef pThis, int _arg);

	/// <summary>
	/// The magnification factor. Default is 1
	/// </summary>
	public virtual void SetMagnification(int _arg)
	{
		vtkImageDataLIC2D_SetMagnification_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataLIC2D_SetStepSize_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Step size.
	/// Specify the step size as a unit of the cell length of the input vector
	/// field. Cell length is the length of the diagonal of a cell.
	/// Initial value is 1.0.
	/// class invariant: StepSize&gt;0.0.
	/// In term of visual quality, the smaller the better.
	/// The type for the interface is double as VTK interface is double
	/// but GPU only supports float. This value will be converted to
	/// float in the execution of the algorithm.
	/// </summary>
	public virtual void SetStepSize(double _arg)
	{
		vtkImageDataLIC2D_SetStepSize_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataLIC2D_SetSteps_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Number of steps. Initial value is 20.
	/// class invariant: Steps&gt;0.
	/// In term of visual quality, the greater the better.
	/// </summary>
	public virtual void SetSteps(int _arg)
	{
		vtkImageDataLIC2D_SetSteps_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataLIC2D_TranslateInputExtent_17(HandleRef pThis, IntPtr inExt, IntPtr inWholeExtent, IntPtr outExt);

	/// <summary>
	/// Check if the required OpenGL extensions / GPU are supported.
	/// </summary>
	public void TranslateInputExtent(IntPtr inExt, IntPtr inWholeExtent, IntPtr outExt)
	{
		vtkImageDataLIC2D_TranslateInputExtent_17(GetCppThis(), inExt, inWholeExtent, outExt);
	}
}
