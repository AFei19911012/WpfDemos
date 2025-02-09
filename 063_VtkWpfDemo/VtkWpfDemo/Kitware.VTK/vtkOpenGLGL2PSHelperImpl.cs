using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLGL2PSHelperImpl
/// </summary>
/// <remarks>
///    vtkOpenGLGL2PSHelper override
/// implementation.
/// </remarks>
public class vtkOpenGLGL2PSHelperImpl : vtkOpenGLGL2PSHelper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGL2PSHelperImpl";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLGL2PSHelperImpl()
	{
		MRClassNameKey = "class vtkOpenGLGL2PSHelperImpl";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGL2PSHelperImpl"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLGL2PSHelperImpl(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelperImpl_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGL2PSHelperImpl New()
	{
		vtkOpenGLGL2PSHelperImpl result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelperImpl_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGL2PSHelperImpl)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLGL2PSHelperImpl()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLGL2PSHelperImpl_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelperImpl_Draw3DPath_01(HandleRef pThis, HandleRef path, HandleRef actorMatrix, IntPtr rasterPos, IntPtr actorColor, HandleRef ren, string label);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Draw3DPath(vtkPath path, vtkMatrix4x4 actorMatrix, IntPtr rasterPos, IntPtr actorColor, vtkRenderer ren, string label)
	{
		vtkOpenGLGL2PSHelperImpl_Draw3DPath_01(GetCppThis(), path?.GetCppThis() ?? default(HandleRef), actorMatrix?.GetCppThis() ?? default(HandleRef), rasterPos, actorColor, ren?.GetCppThis() ?? default(HandleRef), label);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelperImpl_DrawImage_02(HandleRef pThis, HandleRef input, IntPtr pos);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void DrawImage(vtkImageData input, IntPtr pos)
	{
		vtkOpenGLGL2PSHelperImpl_DrawImage_02(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelperImpl_DrawPath_03(HandleRef pThis, HandleRef path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, string label);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void DrawPath(vtkPath path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, string label)
	{
		vtkOpenGLGL2PSHelperImpl_DrawPath_03(GetCppThis(), path?.GetCppThis() ?? default(HandleRef), rasterPos, windowPos, rgba, scale, rotateAngle, strokeWidth, label);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelperImpl_DrawString_04(HandleRef pThis, string str, HandleRef tprop, IntPtr pos, double backgroundDepth, HandleRef ren);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void DrawString(string str, vtkTextProperty tprop, IntPtr pos, double backgroundDepth, vtkRenderer ren)
	{
		vtkOpenGLGL2PSHelperImpl_DrawString_04(GetCppThis(), str, tprop?.GetCppThis() ?? default(HandleRef), pos, backgroundDepth, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLGL2PSHelperImpl_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGL2PSHelperImpl_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLGL2PSHelperImpl_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGL2PSHelperImpl_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLGL2PSHelperImpl_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelperImpl_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLGL2PSHelperImpl NewInstance()
	{
		vtkOpenGLGL2PSHelperImpl result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelperImpl_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGL2PSHelperImpl)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelperImpl_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGL2PSHelperImpl SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLGL2PSHelperImpl vtkOpenGLGL2PSHelperImpl2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelperImpl_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLGL2PSHelperImpl2 = (vtkOpenGLGL2PSHelperImpl)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLGL2PSHelperImpl2.Register(null);
			}
		}
		return vtkOpenGLGL2PSHelperImpl2;
	}
}
