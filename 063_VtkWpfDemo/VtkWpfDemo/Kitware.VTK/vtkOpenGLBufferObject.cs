using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <remarks>
///  OpenGL buffer object
///
/// OpenGL buffer object to store index, geometry and/or attribute data on the
/// GPU.
/// </remarks>
public class vtkOpenGLBufferObject : vtkObject
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ObjectType
	{
		/// <summary>enum member</summary>
		ArrayBuffer,
		/// <summary>enum member</summary>
		ElementArrayBuffer,
		/// <summary>enum member</summary>
		TextureBuffer
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLBufferObject";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLBufferObject()
	{
		MRClassNameKey = "class vtkOpenGLBufferObject";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLBufferObject"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLBufferObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLBufferObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLBufferObject New()
	{
		vtkOpenGLBufferObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLBufferObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLBufferObject()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLBufferObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLBufferObject_Bind_01(HandleRef pThis);

	/// <summary>
	/// Bind the buffer object ready for rendering.
	/// @note Only one ARRAY_BUFFER and one ELEMENT_ARRAY_BUFFER may be bound at
	/// any time.
	/// </summary>
	public bool Bind()
	{
		return (vtkOpenGLBufferObject_Bind_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLBufferObject_GenerateBuffer_02(HandleRef pThis, ObjectType type);

	/// <summary>
	/// Generate the opengl buffer for this Handle 
	/// </summary>
	public bool GenerateBuffer(ObjectType type)
	{
		return (vtkOpenGLBufferObject_GenerateBuffer_02(GetCppThis(), type) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOpenGLBufferObject_GetError_03(HandleRef pThis);

	/// <summary>
	/// Return a string describing errors.
	/// </summary>
	public string GetError()
	{
		return vtkOpenGLBufferObject_GetError_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLBufferObject_GetHandle_04(HandleRef pThis);

	/// <summary>
	/// Get the handle of the buffer object. 
	/// </summary>
	public int GetHandle()
	{
		return vtkOpenGLBufferObject_GetHandle_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLBufferObject_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLBufferObject_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLBufferObject_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLBufferObject_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ObjectType vtkOpenGLBufferObject_GetType_07(HandleRef pThis);

	/// <summary>
	/// Get the type of the buffer object. 
	/// </summary>
	public ObjectType GetTypeWrapper()
	{
		return vtkOpenGLBufferObject_GetType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLBufferObject_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLBufferObject_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLBufferObject_IsReady_09(HandleRef pThis);

	/// <summary>
	/// Determine if the buffer object is ready to be used. 
	/// </summary>
	public bool IsReady()
	{
		return (vtkOpenGLBufferObject_IsReady_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLBufferObject_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLBufferObject_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLBufferObject_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLBufferObject NewInstance()
	{
		vtkOpenGLBufferObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLBufferObject_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLBufferObject_Release_13(HandleRef pThis);

	/// <summary>
	/// Release the buffer. This should be done after rendering is complete.
	/// </summary>
	public bool Release()
	{
		return (vtkOpenGLBufferObject_Release_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLBufferObject_ReleaseGraphicsResources_14(HandleRef pThis);

	/// <summary>
	/// Release the buffer. This should be done after rendering is complete.
	/// </summary>
	public void ReleaseGraphicsResources()
	{
		vtkOpenGLBufferObject_ReleaseGraphicsResources_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLBufferObject_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLBufferObject SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLBufferObject vtkOpenGLBufferObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLBufferObject_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLBufferObject2 = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLBufferObject2.Register(null);
			}
		}
		return vtkOpenGLBufferObject2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLBufferObject_SetType_16(HandleRef pThis, ObjectType value);

	/// <summary>
	/// Set the type of the buffer object. 
	/// </summary>
	public void SetType(ObjectType value)
	{
		vtkOpenGLBufferObject_SetType_16(GetCppThis(), value);
	}
}
