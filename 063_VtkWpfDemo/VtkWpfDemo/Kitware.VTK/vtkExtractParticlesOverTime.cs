using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractParticlesOverTime
/// </summary>
/// <remarks>
///    Extract particles that goes through a given volumic data set.
///
/// vtkExtractParticlesOverTime extracts particles (points) from the first input that goes through
/// the volume of the second input by iterating over time. Both inputs should be vtkDataSet objects.
/// The first input should be temporal (i.e contains time steps), and the second one should be a
/// volumic dataset (i.e contains 3D cells).
///
/// The output is a vtkDataSet that contains points which are subsets of the first input. The points
/// move over time the same way the first input does.
/// </remarks>
public class vtkExtractParticlesOverTime : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractParticlesOverTime";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractParticlesOverTime()
	{
		MRClassNameKey = "class vtkExtractParticlesOverTime";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractParticlesOverTime"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractParticlesOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractParticlesOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static vtkExtractParticlesOverTime New()
	{
		vtkExtractParticlesOverTime result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractParticlesOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractParticlesOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public vtkExtractParticlesOverTime()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractParticlesOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractParticlesOverTime_GetIdChannelArray_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of a scalar array which will be used to fetch
	/// the index of each point. This is necessary only if the particles
	/// change position (Id order) on each time step. The Id can be used
	/// to identify particles at each step and hence track them properly.
	/// If this array is nullptr, the global point ids are used.  If an Id
	/// array cannot otherwise be found, the point index is used as the ID.
	/// </summary>
	public virtual string GetIdChannelArray()
	{
		return Marshal.PtrToStringAnsi(vtkExtractParticlesOverTime_GetIdChannelArray_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractParticlesOverTime_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractParticlesOverTime_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractParticlesOverTime_IsTypeOf_05(string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractParticlesOverTime_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractParticlesOverTime_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new vtkExtractParticlesOverTime NewInstance()
	{
		vtkExtractParticlesOverTime result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractParticlesOverTime_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractParticlesOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractParticlesOverTime_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static vtkExtractParticlesOverTime SafeDownCast(vtkObjectBase o)
	{
		vtkExtractParticlesOverTime vtkExtractParticlesOverTime2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractParticlesOverTime_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractParticlesOverTime2 = (vtkExtractParticlesOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractParticlesOverTime2.Register(null);
			}
		}
		return vtkExtractParticlesOverTime2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractParticlesOverTime_SetIdChannelArray_09(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name of a scalar array which will be used to fetch
	/// the index of each point. This is necessary only if the particles
	/// change position (Id order) on each time step. The Id can be used
	/// to identify particles at each step and hence track them properly.
	/// If this array is nullptr, the global point ids are used.  If an Id
	/// array cannot otherwise be found, the point index is used as the ID.
	/// </summary>
	public virtual void SetIdChannelArray(string arg)
	{
		vtkExtractParticlesOverTime_SetIdChannelArray_09(GetCppThis(), arg);
	}
}
