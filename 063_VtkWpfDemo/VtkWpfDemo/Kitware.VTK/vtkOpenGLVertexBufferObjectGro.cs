using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLVertexBufferObjectGroup
/// </summary>
/// <remarks>
///    manage vertex buffer objects shared within a mapper
///
/// This class holds onto the VBOs that a mapper is using.
/// The basic operation is that during the render process
/// the mapper may cache a number of dataArrays as VBOs
/// associated with attributes. This class keep track of
/// freeing VBOs no longer used by the mapper and uploading
/// new data as needed.
///
/// When using CacheCataArray the same array can be set
/// each time and this class will not rebuild or upload
/// unless needed.
///
/// When using the AppendDataArray API no caching is done
/// and the VBOs will be rebuilt and uploaded each time.
/// So when appending th emapper need to handle checking
/// if the VBO should be updated.
///
/// Use case:
///   make this an ivar of your mapper
///   vbg-&gt;CacheDataArray("vertexMC", vtkDataArray);
///   vbg-&gt;BuildAllVBOs();
///   if (vbg-&gt;GetMTime() &gt; your VAO update time)
///   {
///     vbg-&gt;AddAllAttributesToVAO(...);
///   }
///
/// Appended Use case:
///   make this an ivar of your mapper
///   if (you need to update your VBOs)
///   {
///     vbg-&gt;ClearAllVBOs();
///     vbg-&gt;AppendDataArray("vertexMC", vtkDataArray1);
///     vbg-&gt;AppendDataArray("vertexMC", vtkDataArray2);
///     vbg-&gt;AppendDataArray("vertexMC", vtkDataArray3);
///     vbg-&gt;BuildAllVBOs();
///     vbg-&gt;AddAllAttributesToVAO(...);
///   }
///
/// use VAO
///
/// </remarks>
public class vtkOpenGLVertexBufferObjectGroup : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLVertexBufferObjectGroup";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLVertexBufferObjectGroup()
	{
		MRClassNameKey = "class vtkOpenGLVertexBufferObjectGroup";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLVertexBufferObjectGroup"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLVertexBufferObjectGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLVertexBufferObjectGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLVertexBufferObjectGroup New()
	{
		vtkOpenGLVertexBufferObjectGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLVertexBufferObjectGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLVertexBufferObjectGroup()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLVertexBufferObjectGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLVertexBufferObjectGroup_AppendDataArray_01(HandleRef pThis, string attribute, HandleRef da, int destType);

	/// <summary>
	/// Append a data array for an attribute in the VBO Group
	/// registers the data array until build is called
	/// </summary>
	public void AppendDataArray(string attribute, vtkDataArray da, int destType)
	{
		vtkOpenGLVertexBufferObjectGroup_AppendDataArray_01(GetCppThis(), attribute, da?.GetCppThis() ?? default(HandleRef), destType);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLVertexBufferObjectGroup_ArrayExists_02(HandleRef pThis, string attribute, HandleRef da, ref long offset, ref long totalOffset);

	/// <summary>
	/// Check if the array already exists.
	/// offset is the index of the first vertex of the array if it exists.
	/// totalOffset is the total number of vertices in the appended arrays.
	/// Note that if the array does not exist, offset is equal to totalOffset.
	/// </summary>
	public bool ArrayExists(string attribute, vtkDataArray da, ref long offset, ref long totalOffset)
	{
		return (vtkOpenGLVertexBufferObjectGroup_ArrayExists_02(GetCppThis(), attribute, da?.GetCppThis() ?? default(HandleRef), ref offset, ref totalOffset) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLVertexBufferObjectGroup_BuildAllVBOs_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// using the data arrays in this group
	/// build all the VBOs, once this has been called the
	/// reference to the data arrays will be freed.
	/// </summary>
	public void BuildAllVBOs(vtkViewport arg0)
	{
		vtkOpenGLVertexBufferObjectGroup_BuildAllVBOs_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLVertexBufferObjectGroup_CacheDataArray_04(HandleRef pThis, string attribute, HandleRef da, HandleRef vp, int destType);

	/// <summary>
	/// Set the data array for an attribute in the VBO Group
	/// registers the data array until build is called
	/// once this is called a valid VBO will exist
	/// </summary>
	public void CacheDataArray(string attribute, vtkDataArray da, vtkViewport vp, int destType)
	{
		vtkOpenGLVertexBufferObjectGroup_CacheDataArray_04(GetCppThis(), attribute, da?.GetCppThis() ?? default(HandleRef), vp?.GetCppThis() ?? default(HandleRef), destType);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLVertexBufferObjectGroup_ClearAllDataArrays_05(HandleRef pThis);

	/// <summary>
	/// Clear all the data arrays. Typically an internal method.
	/// Automatically called at the end of BuildAllVBOs to prepare
	/// for the next set of attributes.
	/// </summary>
	public void ClearAllDataArrays()
	{
		vtkOpenGLVertexBufferObjectGroup_ClearAllDataArrays_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLVertexBufferObjectGroup_ClearAllVBOs_06(HandleRef pThis);

	/// <summary>
	/// Force all the VBOs to be freed from this group.
	/// Call this prior to starting appending operations.
	/// Not needed for single array caching.
	/// </summary>
	public void ClearAllVBOs()
	{
		vtkOpenGLVertexBufferObjectGroup_ClearAllVBOs_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkOpenGLVertexBufferObjectGroup_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Get the mtime of this groups VBOs
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkOpenGLVertexBufferObjectGroup_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLVertexBufferObjectGroup_GetNumberOfComponents_08(HandleRef pThis, string attribute);

	/// <summary>
	/// Returns the number of components for this attribute
	/// zero if the attribute does not exist
	/// </summary>
	public int GetNumberOfComponents(string attribute)
	{
		return vtkOpenGLVertexBufferObjectGroup_GetNumberOfComponents_08(GetCppThis(), attribute);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLVertexBufferObjectGroup_GetNumberOfTuples_11(HandleRef pThis, string attribute);

	/// <summary>
	/// Returns the number of tuples for this attribute
	/// zero if the attribute does not exist
	/// </summary>
	public int GetNumberOfTuples(string attribute)
	{
		return vtkOpenGLVertexBufferObjectGroup_GetNumberOfTuples_11(GetCppThis(), attribute);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLVertexBufferObjectGroup_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLVertexBufferObjectGroup_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLVertexBufferObjectGroup_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLVertexBufferObjectGroup_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLVertexBufferObjectGroup_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLVertexBufferObjectGroup NewInstance()
	{
		vtkOpenGLVertexBufferObjectGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLVertexBufferObjectGroup_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLVertexBufferObjectGroup_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOpenGLVertexBufferObjectGroup_ReleaseGraphicsResources_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLVertexBufferObjectGroup_RemoveAttribute_17(HandleRef pThis, string attribute);

	/// <summary>
	/// used to remove a no longer needed attribute
	/// Calling CacheDataArray with a nullptr
	/// attribute will also work.
	/// </summary>
	public void RemoveAttribute(string attribute)
	{
		vtkOpenGLVertexBufferObjectGroup_RemoveAttribute_17(GetCppThis(), attribute);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLVertexBufferObjectGroup_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLVertexBufferObjectGroup SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLVertexBufferObjectGroup vtkOpenGLVertexBufferObjectGroup2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLVertexBufferObjectGroup_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLVertexBufferObjectGroup2 = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLVertexBufferObjectGroup2.Register(null);
			}
		}
		return vtkOpenGLVertexBufferObjectGroup2;
	}
}
