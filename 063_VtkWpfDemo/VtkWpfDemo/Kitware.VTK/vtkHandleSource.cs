using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHandleSource
/// </summary>
/// <remarks>
///    interface that can be inherited to define handler sources for any kind of interaction.
///
/// vtkHandleSource is a pure abstract class defining an interface for handler sources.
/// Any child of this class is supposed to define an access to its position, size and direction, if
/// any. On this purpose, the internal getters/setters are left to be redefined by the subclasses.
/// It is derived by vtkPointHandleSource for example.
/// </remarks>
/// <seealso>
///
/// vtkPointHandleSource, vtkCameraHandleSource
/// </seealso>
public abstract class vtkHandleSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHandleSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHandleSource()
	{
		MRClassNameKey = "class vtkHandleSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHandleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_DirectionalOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get if the handle should take account on this-&gt;Direction.
	/// The meaning of this direction varies on
	/// the subclasses implementation.
	/// The default value is false.
	/// </summary>
	public virtual void DirectionalOff()
	{
		vtkHandleSource_DirectionalOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_DirectionalOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get if the handle should take account on this-&gt;Direction.
	/// The meaning of this direction varies on
	/// the subclasses implementation.
	/// The default value is false.
	/// </summary>
	public virtual void DirectionalOn()
	{
		vtkHandleSource_DirectionalOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_GetDirection_03(HandleRef pThis, IntPtr dir);

	/// <summary>
	/// Get the direction of the handle.
	/// The direction meaning depends on subclasses implementations.
	/// </summary>
	public void GetDirection(IntPtr dir)
	{
		vtkHandleSource_GetDirection_03(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleSource_GetDirection_04(HandleRef pThis);

	/// <summary>
	/// Get the direction of the handle.
	/// The direction meaning depends on subclasses implementations.
	/// </summary>
	public virtual IntPtr GetDirection()
	{
		return vtkHandleSource_GetDirection_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHandleSource_GetDirectional_05(HandleRef pThis);

	/// <summary>
	/// Set/Get if the handle should take account on this-&gt;Direction.
	/// The meaning of this direction varies on
	/// the subclasses implementation.
	/// The default value is false.
	/// </summary>
	public virtual bool GetDirectional()
	{
		return (vtkHandleSource_GetDirectional_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHandleSource_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHandleSource_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHandleSource_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHandleSource_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_GetPosition_08(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the handle.
	/// </summary>
	public void GetPosition(IntPtr pos)
	{
		vtkHandleSource_GetPosition_08(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleSource_GetPosition_09(HandleRef pThis);

	/// <summary>
	/// Get the position of the handle.
	/// </summary>
	public virtual IntPtr GetPosition()
	{
		return vtkHandleSource_GetPosition_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHandleSource_GetSize_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the handle.
	/// The size use depends on subclasses implementations.
	/// The default value is 0.5.
	/// </summary>
	public virtual double GetSize()
	{
		return vtkHandleSource_GetSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleSource_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHandleSource_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleSource_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHandleSource_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHandleSource NewInstance()
	{
		vtkHandleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleSource_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHandleSource SafeDownCast(vtkObjectBase o)
	{
		vtkHandleSource vtkHandleSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleSource_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleSource2 = (vtkHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleSource2.Register(null);
			}
		}
		return vtkHandleSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_SetDirection_15(HandleRef pThis, IntPtr dir);

	/// <summary>
	/// Set the direction of the handle.
	/// The direction meaning depends on subclasses implementations.
	/// </summary>
	public void SetDirection(IntPtr dir)
	{
		vtkHandleSource_SetDirection_15(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_SetDirection_16(HandleRef pThis, double xDir, double yDir, double zDir);

	/// <summary>
	/// Set the direction of the handle.
	/// The direction meaning depends on subclasses implementations.
	/// </summary>
	public virtual void SetDirection(double xDir, double yDir, double zDir)
	{
		vtkHandleSource_SetDirection_16(GetCppThis(), xDir, yDir, zDir);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_SetDirectional_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the handle should take account on this-&gt;Direction.
	/// The meaning of this direction varies on
	/// the subclasses implementation.
	/// The default value is false.
	/// </summary>
	public virtual void SetDirectional(bool _arg)
	{
		vtkHandleSource_SetDirectional_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_SetPosition_18(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set the position of the handle.
	/// </summary>
	public void SetPosition(IntPtr pos)
	{
		vtkHandleSource_SetPosition_18(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_SetPosition_19(HandleRef pThis, double xPos, double yPos, double zPos);

	/// <summary>
	/// Set the position of the handle.
	/// </summary>
	public virtual void SetPosition(double xPos, double yPos, double zPos)
	{
		vtkHandleSource_SetPosition_19(GetCppThis(), xPos, yPos, zPos);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleSource_SetSize_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the handle.
	/// The size use depends on subclasses implementations.
	/// The default value is 0.5.
	/// </summary>
	public virtual void SetSize(double _arg)
	{
		vtkHandleSource_SetSize_20(GetCppThis(), _arg);
	}
}
