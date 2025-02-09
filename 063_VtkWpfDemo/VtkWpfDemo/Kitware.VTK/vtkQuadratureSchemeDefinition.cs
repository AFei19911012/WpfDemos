using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadratureSchemeDefinition
///
/// An Elemental data type that holds a definition of a
/// numerical quadrature scheme. The definition contains
/// the requisite information to interpolate to the so called
/// quadrature points of the specific scheme. namely:
///
/// &lt;pre&gt;
/// 1)
/// A matrix of shape function weights(shape functions evaluated
/// at parametric coordinates of the quadrature points).
///
/// 2)
/// The number of quadrature points and cell nodes. These parameters
/// size the matrix, and allow for convenient evaluation by users
/// of the definition.
/// &lt;/pre&gt;
/// </summary>
public class vtkQuadratureSchemeDefinition : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadratureSchemeDefinition";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadratureSchemeDefinition()
	{
		MRClassNameKey = "class vtkQuadratureSchemeDefinition";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadratureSchemeDefinition"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadratureSchemeDefinition(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// New object in an unusable state. You'll have to call
	/// "Initilaize" to get the definition in to a usable state.
	/// </summary>
	public new static vtkQuadratureSchemeDefinition New()
	{
		vtkQuadratureSchemeDefinition result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadratureSchemeDefinition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// New object in an unusable state. You'll have to call
	/// "Initilaize" to get the definition in to a usable state.
	/// </summary>
	public vtkQuadratureSchemeDefinition()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadratureSchemeDefinition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadratureSchemeDefinition_Clear_01(HandleRef pThis);

	/// <summary>
	/// Release all allocated resources and set the
	/// object to an uninitialized state.
	/// </summary>
	public void Clear()
	{
		vtkQuadratureSchemeDefinition_Clear_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_DICTIONARY_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkInformationQuadratureSchemeDefinitionVectorKey DICTIONARY()
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey vtkInformationQuadratureSchemeDefinitionVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadratureSchemeDefinition_DICTIONARY_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey2 = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationQuadratureSchemeDefinitionVectorKey2.Register(null);
			}
		}
		return vtkInformationQuadratureSchemeDefinitionVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_DeepCopy_03(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Deep copy.
	/// </summary>
	public int DeepCopy(vtkQuadratureSchemeDefinition other)
	{
		return vtkQuadratureSchemeDefinition_DeepCopy_03(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_GetCellType_04(HandleRef pThis);

	/// <summary>
	/// Access the VTK cell type id.
	/// </summary>
	public int GetCellType()
	{
		return vtkQuadratureSchemeDefinition_GetCellType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadratureSchemeDefinition_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_GetNumberOfNodes_07(HandleRef pThis);

	/// <summary>
	/// Get the number of nodes associated with the interpolation.
	/// </summary>
	public int GetNumberOfNodes()
	{
		return vtkQuadratureSchemeDefinition_GetNumberOfNodes_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_GetNumberOfQuadraturePoints_08(HandleRef pThis);

	/// <summary>
	/// Get the number of quadrature points associated with the scheme.
	/// </summary>
	public int GetNumberOfQuadraturePoints()
	{
		return vtkQuadratureSchemeDefinition_GetNumberOfQuadraturePoints_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_GetQuadratureKey_09(HandleRef pThis);

	/// <summary>
	/// Access to an alternative key.
	/// </summary>
	public int GetQuadratureKey()
	{
		return vtkQuadratureSchemeDefinition_GetQuadratureKey_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_GetQuadratureWeights_10(HandleRef pThis);

	/// <summary>
	/// Access to the quadrature weights.
	/// </summary>
	public IntPtr GetQuadratureWeights()
	{
		return vtkQuadratureSchemeDefinition_GetQuadratureWeights_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_11(HandleRef pThis);

	/// <summary>
	/// Get the array of shape function weights. Shape function weights are
	/// the shape functions evaluated at the quadrature points. There are
	/// "NumberOfNodes" weights for each quadrature point.
	/// </summary>
	public IntPtr GetShapeFunctionWeights()
	{
		return vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_12(HandleRef pThis, int quadraturePointId);

	/// <summary>
	/// Get the array of shape function weights associated with a
	/// single quadrature point.
	/// </summary>
	public IntPtr GetShapeFunctionWeights(int quadraturePointId)
	{
		return vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_12(GetCppThis(), quadraturePointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadratureSchemeDefinition_Initialize_13(HandleRef pThis, int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights);

	/// <summary>
	/// Initialize the object allocating resources as needed.
	/// </summary>
	public void Initialize(int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights)
	{
		vtkQuadratureSchemeDefinition_Initialize_13(GetCppThis(), cellType, numberOfNodes, numberOfQuadraturePoints, shapeFunctionWeights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadratureSchemeDefinition_Initialize_14(HandleRef pThis, int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights, IntPtr quadratureWeights);

	/// <summary>
	/// Initialize the object allocating resources as needed.
	/// </summary>
	public void Initialize(int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights, IntPtr quadratureWeights)
	{
		vtkQuadratureSchemeDefinition_Initialize_14(GetCppThis(), cellType, numberOfNodes, numberOfQuadraturePoints, shapeFunctionWeights, quadratureWeights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadratureSchemeDefinition_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadratureSchemeDefinition_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuadratureSchemeDefinition NewInstance()
	{
		vtkQuadratureSchemeDefinition result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadratureSchemeDefinition_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_QUADRATURE_OFFSET_ARRAY_NAME_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkInformationStringKey QUADRATURE_OFFSET_ARRAY_NAME()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadratureSchemeDefinition_QUADRATURE_OFFSET_ARRAY_NAME_19(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_RestoreState_20(HandleRef pThis, HandleRef root);

	/// <summary>
	/// Restore the object from an XML representation.
	/// </summary>
	public int RestoreState(vtkXMLDataElement root)
	{
		return vtkQuadratureSchemeDefinition_RestoreState_20(GetCppThis(), root?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadratureSchemeDefinition_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadratureSchemeDefinition SafeDownCast(vtkObjectBase o)
	{
		vtkQuadratureSchemeDefinition vtkQuadratureSchemeDefinition2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadratureSchemeDefinition_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadratureSchemeDefinition2 = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadratureSchemeDefinition2.Register(null);
			}
		}
		return vtkQuadratureSchemeDefinition2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadratureSchemeDefinition_SaveState_22(HandleRef pThis, HandleRef root);

	/// <summary>
	/// Put the object into an XML representation. The element
	/// passed in is assumed to be empty.
	/// </summary>
	public int SaveState(vtkXMLDataElement root)
	{
		return vtkQuadratureSchemeDefinition_SaveState_22(GetCppThis(), root?.GetCppThis() ?? default(HandleRef));
	}
}
