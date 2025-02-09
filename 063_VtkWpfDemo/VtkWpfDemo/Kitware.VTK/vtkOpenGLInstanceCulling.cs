using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLInstanceCulling
/// </summary>
/// <remarks>
///    Frustum culling and LOD management.
///
/// This class is used to cull instances based on their transformation matrix.
/// It was designed to improve performances when there is large number of instances
/// in vtkOpenGLGlyph3DMapper.
///
/// Each instance is tested on the GPU through vertex shader to know if it is inside
/// of the frustum view. If it is, the distance to the camera is computed to select
/// and send to the geometry shader the corresponding LOD index.
/// The geometry shader register the instance to the corresponding vertex stream and
/// therefore the corresponding transform feedback buffer in video memory.
///
/// @warning   GL_ARB_gpu_shader5 extension is required.
///
/// @code{.cpp}
///
/// vtkNew&lt;vtkOpenGLInstanceCulling&gt; culling;
/// vtkIdType nbInstances = 1000000;
///
/// // buffer of size 16*nbInstances containing transform matrices.
/// vtkOpenGLBufferObject* bufferMatrix = ...;
///
/// // buffer of size 4*nbInstances containing color buffer to pass through.
/// vtkOpenGLBufferObject* bufferColor = ...;
///
/// // Initialize LODs
/// culling-&gt;InitLOD(polydata); // LOD0 : full geometry
/// culling-&gt;AddLOD(2.0, 0.5); // LOD1 : after 2.0, 50% triangles
/// culling-&gt;AddLOD(5.0, 0.99); // LOD2 : after 5.0, 1% triangles
///
/// // Build shader and binds
/// culling-&gt;BuildCullingShaders(ren, actor, nbInstances);
/// culling-&gt;RunCullingShaders(nbInstances, bufferMatrix, bufferColor);
///
/// // Get number of instances in LOD 0
/// int nbInstInLOD0 = culling-&gt;GetLOD(0).NumberOfInstances;
///
/// // Get VBO and IBO of LOD 1
/// vtkOpenGLBufferObject* VBO1 = culling-&gt;GetLOD(1).PositionVBO;
/// vtkOpenGLBufferObject* IBO1 = culling-&gt;GetLOD(1).IBO;
///
/// // Get instances buffer of LOD 2
/// // buffer is interleaved [ transformMatrix0 color0 transformMatrix1 color1 ... ]
/// vtkOpenGLBufferObject* buffer2 = culling-&gt;GetLODBuffer(2);
///
/// @endcode
/// </remarks>
public class vtkOpenGLInstanceCulling : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLInstanceCulling";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLInstanceCulling()
	{
		MRClassNameKey = "class vtkOpenGLInstanceCulling";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLInstanceCulling"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLInstanceCulling(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLInstanceCulling_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLInstanceCulling New()
	{
		vtkOpenGLInstanceCulling result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLInstanceCulling_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLInstanceCulling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLInstanceCulling()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLInstanceCulling_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLInstanceCulling_AddLOD_01(HandleRef pThis, float distance, float targetReduction);

	/// <summary>
	/// Add a level of detail.
	/// distance is the distance after which LOD is enabled
	/// targetReduction is the reduction factor applied on polydata (vtkDecimatePro is used)
	///
	/// @sa vtkDecimatePro::SetTargetReduction
	/// </summary>
	public void AddLOD(float distance, float targetReduction)
	{
		vtkOpenGLInstanceCulling_AddLOD_01(GetCppThis(), distance, targetReduction);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLInstanceCulling_GetColorLOD_02(HandleRef pThis);

	/// <summary>
	/// Overload color with unique color per LOD.
	/// </summary>
	public virtual bool GetColorLOD()
	{
		return (vtkOpenGLInstanceCulling_GetColorLOD_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLInstanceCulling_GetHelper_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get helper structure.
	/// </summary>
	public vtkOpenGLHelper GetHelper()
	{
		vtkOpenGLHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLInstanceCulling_GetHelper_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLInstanceCulling_GetLODBuffer_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transform feedback buffer generated by the culling program.
	/// </summary>
	public vtkOpenGLBufferObject GetLODBuffer(long index)
	{
		vtkOpenGLBufferObject vtkOpenGLBufferObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLInstanceCulling_GetLODBuffer_04(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLInstanceCulling_GetNumberOfLOD_07(HandleRef pThis);

	/// <summary>
	/// Get number of LOD currently declared.
	/// </summary>
	public long GetNumberOfLOD()
	{
		return vtkOpenGLInstanceCulling_GetNumberOfLOD_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLInstanceCulling_InitLOD_08(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Initialize LOD with a polydata
	/// </summary>
	public void InitLOD(vtkPolyData pd)
	{
		vtkOpenGLInstanceCulling_InitLOD_08(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLInstanceCulling_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLInstanceCulling_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLInstanceCulling_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLInstanceCulling_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLInstanceCulling_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLInstanceCulling NewInstance()
	{
		vtkOpenGLInstanceCulling result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLInstanceCulling_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLInstanceCulling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLInstanceCulling_RunCullingShaders_13(HandleRef pThis, long numInstances, HandleRef matrixBuffer, HandleRef colorBuffer, HandleRef normalBuffer);

	/// <summary>
	/// Run the culling program and generate LOD buffers.
	/// </summary>
	public void RunCullingShaders(long numInstances, vtkOpenGLBufferObject matrixBuffer, vtkOpenGLBufferObject colorBuffer, vtkOpenGLBufferObject normalBuffer)
	{
		vtkOpenGLInstanceCulling_RunCullingShaders_13(GetCppThis(), numInstances, matrixBuffer?.GetCppThis() ?? default(HandleRef), colorBuffer?.GetCppThis() ?? default(HandleRef), normalBuffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLInstanceCulling_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLInstanceCulling SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLInstanceCulling vtkOpenGLInstanceCulling2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLInstanceCulling_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLInstanceCulling2 = (vtkOpenGLInstanceCulling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLInstanceCulling2.Register(null);
			}
		}
		return vtkOpenGLInstanceCulling2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLInstanceCulling_SetColorLOD_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Overload color with unique color per LOD.
	/// </summary>
	public virtual void SetColorLOD(bool _arg)
	{
		vtkOpenGLInstanceCulling_SetColorLOD_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
