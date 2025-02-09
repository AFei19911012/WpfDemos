using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLCompositeDataReader
/// </summary>
/// <remarks>
///    Reader for multi-group datasets
///
/// vtkXMLCompositeDataReader reads the VTK XML multi-group data file
/// format. XML multi-group data files are meta-files that point to a list
/// of serial VTK XML files. When reading in parallel, it will distribute
/// sub-blocks among processor. If the number of sub-blocks is less than
/// the number of processors, some processors will not have any sub-blocks
/// for that group. If the number of sub-blocks is larger than the
/// number of processors, each processor will possibly have more than
/// 1 sub-block.
/// </remarks>
public abstract class vtkXMLCompositeDataReader : vtkXMLReader
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum Block_WrapperEnum
	{
		/// <summary>enum member</summary>
		Block,
		/// <summary>enum member</summary>
		Interleave
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLCompositeDataReader()
	{
		MRClassNameKey = "class vtkXMLCompositeDataReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLCompositeDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkCompositeDataSet GetOutput()
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataReader_GetOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataSet2 = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataSet2.Register(null);
			}
		}
		return vtkCompositeDataSet2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataReader_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkCompositeDataSet GetOutput(int arg0)
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataReader_GetOutput_04(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataSet2 = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataSet2.Register(null);
			}
		}
		return vtkCompositeDataSet2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataReader_GetPieceDistribution_05(HandleRef pThis);

	/// <summary>
	/// Set the strategy for assigning files to parallel readers. The default is
	/// @a Block.
	///
	/// Let @a X be the rank of a specific reader, and @a N be the number of
	/// reader, then:
	/// @arg @c Block Each processor is assigned a contiguous block of files,
	///      [@a X * @a N, ( @a X + 1) * @a N ).
	/// @arg @c Interleave The files are interleaved across readers,
	/// @a i * @a N + @a X.
	/// @{
	/// </summary>
	public virtual int GetPieceDistribution()
	{
		return vtkXMLCompositeDataReader_GetPieceDistribution_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataReader_GetPieceDistributionMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set the strategy for assigning files to parallel readers. The default is
	/// @a Block.
	///
	/// Let @a X be the rank of a specific reader, and @a N be the number of
	/// reader, then:
	/// @arg @c Block Each processor is assigned a contiguous block of files,
	///      [@a X * @a N, ( @a X + 1) * @a N ).
	/// @arg @c Interleave The files are interleaved across readers,
	/// @a i * @a N + @a X.
	/// @{
	/// </summary>
	public virtual int GetPieceDistributionMaxValue()
	{
		return vtkXMLCompositeDataReader_GetPieceDistributionMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataReader_GetPieceDistributionMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set the strategy for assigning files to parallel readers. The default is
	/// @a Block.
	///
	/// Let @a X be the rank of a specific reader, and @a N be the number of
	/// reader, then:
	/// @arg @c Block Each processor is assigned a contiguous block of files,
	///      [@a X * @a N, ( @a X + 1) * @a N ).
	/// @arg @c Interleave The files are interleaved across readers,
	/// @a i * @a N + @a X.
	/// @{
	/// </summary>
	public virtual int GetPieceDistributionMinValue()
	{
		return vtkXMLCompositeDataReader_GetPieceDistributionMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataReader_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLCompositeDataReader_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataReader_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLCompositeDataReader_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLCompositeDataReader NewInstance()
	{
		vtkXMLCompositeDataReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLCompositeDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLCompositeDataReader SafeDownCast(vtkObjectBase o)
	{
		vtkXMLCompositeDataReader vtkXMLCompositeDataReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLCompositeDataReader2 = (vtkXMLCompositeDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLCompositeDataReader2.Register(null);
			}
		}
		return vtkXMLCompositeDataReader2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLCompositeDataReader_SetFileName_12(HandleRef pThis, string arg0);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public override void SetFileName(string arg0)
	{
		vtkXMLCompositeDataReader_SetFileName_12(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLCompositeDataReader_SetPieceDistribution_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the strategy for assigning files to parallel readers. The default is
	/// @a Block.
	///
	/// Let @a X be the rank of a specific reader, and @a N be the number of
	/// reader, then:
	/// @arg @c Block Each processor is assigned a contiguous block of files,
	///      [@a X * @a N, ( @a X + 1) * @a N ).
	/// @arg @c Interleave The files are interleaved across readers,
	/// @a i * @a N + @a X.
	/// @{
	/// </summary>
	public virtual void SetPieceDistribution(int _arg)
	{
		vtkXMLCompositeDataReader_SetPieceDistribution_13(GetCppThis(), _arg);
	}
}
