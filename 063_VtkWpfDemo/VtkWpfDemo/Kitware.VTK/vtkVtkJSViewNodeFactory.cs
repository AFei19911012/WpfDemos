using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVtkJSViewNodeFactory
/// </summary>
/// <remarks>
///    Constructs view nodes for traversing a scene for vtk-js
///
/// vtkVtkJSViewNodeFactory constructs view nodes that are subsequently executed
/// as a scene graph is traversed. The generated view nodes inherit from
/// vtkViewNode and augment the synchronize and render traversal steps to
/// construct Json representations of the scene elements and to update the
/// pipelines associated with the datasets to render, respectively.
///
///
/// </remarks>
/// <seealso>
///
/// vtkVtkJSSceneGraphSerializer
/// </seealso>
public class vtkVtkJSViewNodeFactory : vtkViewNodeFactory
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVtkJSViewNodeFactory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVtkJSViewNodeFactory()
	{
		MRClassNameKey = "class vtkVtkJSViewNodeFactory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVtkJSViewNodeFactory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVtkJSViewNodeFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSViewNodeFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVtkJSViewNodeFactory New()
	{
		vtkVtkJSViewNodeFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSViewNodeFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVtkJSViewNodeFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVtkJSViewNodeFactory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVtkJSViewNodeFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVtkJSViewNodeFactory_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSViewNodeFactory_GetSerializer_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the Serializer object
	/// </summary>
	public virtual vtkVtkJSSceneGraphSerializer GetSerializer()
	{
		vtkVtkJSSceneGraphSerializer vtkVtkJSSceneGraphSerializer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSViewNodeFactory_GetSerializer_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVtkJSViewNodeFactory_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVtkJSViewNodeFactory_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVtkJSViewNodeFactory_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVtkJSViewNodeFactory_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSViewNodeFactory_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVtkJSViewNodeFactory NewInstance()
	{
		vtkVtkJSViewNodeFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSViewNodeFactory_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVtkJSViewNodeFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVtkJSViewNodeFactory_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVtkJSViewNodeFactory SafeDownCast(vtkObjectBase o)
	{
		vtkVtkJSViewNodeFactory vtkVtkJSViewNodeFactory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVtkJSViewNodeFactory_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVtkJSViewNodeFactory2 = (vtkVtkJSViewNodeFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVtkJSViewNodeFactory2.Register(null);
			}
		}
		return vtkVtkJSViewNodeFactory2;
	}

	[DllImport("Kitware.VTK.RenderingVtkJS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVtkJSViewNodeFactory_SetSerializer_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the Serializer object
	/// </summary>
	public void SetSerializer(vtkVtkJSSceneGraphSerializer arg0)
	{
		vtkVtkJSViewNodeFactory_SetSerializer_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
