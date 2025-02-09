using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextCodecFactory
/// </summary>
/// <remarks>
///    maintain a list of text codecs and return instances
///
///
/// A single class to hold registered codecs and return instances of them based
/// on either a descriptive name (UTF16 or latin-1) or by asking who can handle a
/// given std::vector&lt;unsigned char&gt;
///
/// @par Thanks:
/// Thanks to Tim Shed from Sandia National Laboratories for his work
/// on the concepts and to Marcus Hanwell and Jeff Baumes of Kitware for
/// keeping me out of the weeds
///
/// </remarks>
/// <seealso>
///
/// vtkTextCodec
///
/// </seealso>
public class vtkTextCodecFactory : vtkObject
{
	/// <summary>
	/// Type for Creation callback.
	/// </summary>
	public delegate IntPtr CreateFunction();

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextCodecFactory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextCodecFactory()
	{
		MRClassNameKey = "class vtkTextCodecFactory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextCodecFactory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextCodecFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextCodecFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextCodecFactory New()
	{
		vtkTextCodecFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextCodecFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTextCodecFactory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextCodecFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextCodecFactory_CodecForName_01(string CodecName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a codec/storage name try to find one of our registered codecs that
	/// can handle it.  This is non-deterministic, very messy and should not be
	/// your first thing to try.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static vtkTextCodec CodecForName(string CodecName)
	{
		vtkTextCodec vtkTextCodec2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextCodecFactory_CodecForName_01(CodecName, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextCodec2 = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextCodec2.Register(null);
			}
		}
		return vtkTextCodec2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextCodecFactory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextCodecFactory_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextCodecFactory_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextCodecFactory_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextCodecFactory_Initialize_04();

	/// <summary>
	/// Initialize core text codecs - needed for the static compilation case.
	/// </summary>
	public static void Initialize()
	{
		vtkTextCodecFactory_Initialize_04();
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextCodecFactory_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextCodecFactory_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextCodecFactory_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextCodecFactory_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextCodecFactory_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextCodecFactory NewInstance()
	{
		vtkTextCodecFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextCodecFactory_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextCodecFactory_RegisterCreateCallback_09(CreateFunction callback);

	/// <summary>
	/// Provides mechanism to register/unregister additional callbacks to create
	/// concrete subclasses of vtkTextCodecFactory to handle different protocols.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static void RegisterCreateCallback(CreateFunction callback)
	{
		vtkTextCodecFactory_RegisterCreateCallback_09(callback);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextCodecFactory_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextCodecFactory SafeDownCast(vtkObjectBase o)
	{
		vtkTextCodecFactory vtkTextCodecFactory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextCodecFactory_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextCodecFactory2 = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextCodecFactory2.Register(null);
			}
		}
		return vtkTextCodecFactory2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextCodecFactory_UnRegisterAllCreateCallbacks_11();

	/// <summary>
	/// Provides mechanism to register/unregister additional callbacks to create
	/// concrete subclasses of vtkTextCodecFactory to handle different protocols.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static void UnRegisterAllCreateCallbacks()
	{
		vtkTextCodecFactory_UnRegisterAllCreateCallbacks_11();
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextCodecFactory_UnRegisterCreateCallback_12(CreateFunction callback);

	/// <summary>
	/// Provides mechanism to register/unregister additional callbacks to create
	/// concrete subclasses of vtkTextCodecFactory to handle different protocols.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static void UnRegisterCreateCallback(CreateFunction callback)
	{
		vtkTextCodecFactory_UnRegisterCreateCallback_12(callback);
	}
}
