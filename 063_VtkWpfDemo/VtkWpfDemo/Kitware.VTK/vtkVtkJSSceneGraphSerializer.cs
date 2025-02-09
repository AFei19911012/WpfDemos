using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVtkJSSceneGraphSerializer
/// </summary>
/// <remarks>
///    Converts elements of a VTK scene graph into vtk-js elements
///
/// vtkVtkJSSceneGraphSerializer accepts nodes and their renderables from a scene
/// graph and a) composes the elements' data and topology into a Json data
/// structure and b) correlates unique identifiers for data objects in the Json
/// data structure to the data objects themselves. It is designed to operate with
/// vtkVtkJSViewNodeFactory, which handles the logic for scene graph traversal.
///
/// When constructing the Json description for a single scene graph node and its
/// renderable, the Add(node, renderable) step processes the renderable into its
/// corresponding vtk-js form. For many renderables this is a no-op, but current
/// restrictions in vtk-js (such as the lack of support for composite mappers and
/// the requirement for data conversion to vtkPolyData) require a nontrival
/// conversion step for certain renderable types. The subsequent
/// ToJson(renderable) is a straightforward conversion of the renderable's data
/// members into a vtk-js Json format.
///
///
/// </remarks>
/// <seealso>
///
/// vtkVtkJSViewNodeFactory
/// </seealso>
public class vtkVtkJSSceneGraphSerializer : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVtkJSSceneGraphSerializer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVtkJSSceneGraphSerializer()
	{
		MRClassNameKey = "class vtkVtkJSSceneGraphSerializer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVtkJSSceneGraphSerializer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVtkJSSceneGraphSerializer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSSceneGraphSerializer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVtkJSSceneGraphSerializer New()
	{
		vtkVtkJSSceneGraphSerializer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSSceneGraphSerializer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVtkJSSceneGraphSerializer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVtkJSSceneGraphSerializer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkActor arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_02(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkCompositePolyDataMapper arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_03(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkCompositePolyDataMapper2 arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_04(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkGlyph3DMapper arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_05(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkMapper arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_06(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkRenderer arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Add_07(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Add a scene graph node and its corresponding renderable to the scene.
	/// </summary>
	public virtual void Add(vtkViewNode arg0, vtkRenderWindow arg1)
	{
		vtkVtkJSSceneGraphSerializer_Add_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSSceneGraphSerializer_GetDataArray_08(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the data arrays referenced in the constructed scene.
	/// </summary>
	public vtkDataArray GetDataArray(long arg0)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSSceneGraphSerializer_GetDataArray_08(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkVtkJSSceneGraphSerializer_GetDataArrayId_09(HandleRef pThis, long arg0);

	/// <summary>
	/// Access the data arrays referenced in the constructed scene.
	/// </summary>
	public string GetDataArrayId(long arg0)
	{
		return vtkVtkJSSceneGraphSerializer_GetDataArrayId_09(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSSceneGraphSerializer_GetDataObject_10(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the data objects referenced in the constructed scene.
	/// </summary>
	public vtkDataObject GetDataObject(long arg0)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSSceneGraphSerializer_GetDataObject_10(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVtkJSSceneGraphSerializer_GetDataObjectId_11(HandleRef pThis, long arg0);

	/// <summary>
	/// Access the data objects referenced in the constructed scene.
	/// </summary>
	public uint GetDataObjectId(long arg0)
	{
		return vtkVtkJSSceneGraphSerializer_GetDataObjectId_11(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfDataArrays_12(HandleRef pThis);

	/// <summary>
	/// Access the data arrays referenced in the constructed scene.
	/// </summary>
	public long GetNumberOfDataArrays()
	{
		return vtkVtkJSSceneGraphSerializer_GetNumberOfDataArrays_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfDataObjects_13(HandleRef pThis);

	/// <summary>
	/// Access the data objects referenced in the constructed scene.
	/// </summary>
	public long GetNumberOfDataObjects()
	{
		return vtkVtkJSSceneGraphSerializer_GetNumberOfDataObjects_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVtkJSSceneGraphSerializer_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVtkJSSceneGraphSerializer_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVtkJSSceneGraphSerializer_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVtkJSSceneGraphSerializer_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVtkJSSceneGraphSerializer_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSSceneGraphSerializer_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVtkJSSceneGraphSerializer NewInstance()
	{
		vtkVtkJSSceneGraphSerializer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSSceneGraphSerializer_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSSceneGraphSerializer_Reset_20(HandleRef pThis);

	/// <summary>
	/// Empty the contents of the scene and the reset the unique id generator.
	/// </summary>
	public void Reset()
	{
		vtkVtkJSSceneGraphSerializer_Reset_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSSceneGraphSerializer_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVtkJSSceneGraphSerializer SafeDownCast(vtkObjectBase o)
	{
		vtkVtkJSSceneGraphSerializer vtkVtkJSSceneGraphSerializer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSSceneGraphSerializer_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVtkJSSceneGraphSerializer2 = (vtkVtkJSSceneGraphSerializer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVtkJSSceneGraphSerializer2.Register(null);
			}
		}
		return vtkVtkJSSceneGraphSerializer2;
	}
}
