using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
    /// <summary>
    ///    vtk3DSImporter
    /// </summary>
    /// <remarks>
    ///    imports 3D Studio files.
    ///
    /// vtk3DSImporter imports 3D Studio files into vtk.
    ///
    /// </remarks>
    /// <seealso>
    ///
    /// vtkImporter
    /// </seealso>
    public class vtk3DSImporter : vtkImporter
    {
        /// <summary>
        /// Automatically generated type registration mechanics.
        /// </summary>
        public new const string MRFullTypeName = "Kitware.VTK.vtk3DSImporter";

        /// <summary>
        /// Automatically generated type registration mechanics.
        /// </summary>
        public new static readonly string MRClassNameKey;

        /// <summary>
        /// Automatically generated type registration mechanics.
        /// </summary>
        static vtk3DSImporter()
        {
            MRClassNameKey = "class vtk3DSImporter";
            Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DSImporter"));
        }

        /// <summary>
        /// Automatically generated constructor - called from generated code.
        /// DO NOT call directly.
        /// </summary>
        public vtk3DSImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
            : base(rawCppThis, callDisposalMethod, strong)
        {
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr vtk3DSImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public new static vtk3DSImporter New()
        {
            vtk3DSImporter result = null;
            uint mteStatus = 0u;
            uint mteIndex = uint.MaxValue;
            uint rawRefCount = 0u;
            IntPtr intPtr = vtk3DSImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
            if (IntPtr.Zero != intPtr)
            {
                result = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
            }
            return result;
        }

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public vtk3DSImporter()
            : base(IntPtr.Zero, callDisposalMethod: false, strong: false)
        {
            uint mteStatus = 0u;
            uint mteIndex = uint.MaxValue;
            uint rawRefCount = 0u;
            IntPtr rawCppThis = vtk3DSImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void vtk3DSImporter_ComputeNormalsOff_01(HandleRef pThis);

        /// <summary>
        /// Set/Get the computation of normals. If on, imported geometry will
        /// be run through vtkPolyDataNormals.
        /// </summary>
        public virtual void ComputeNormalsOff()
        {
            vtk3DSImporter_ComputeNormalsOff_01(GetCppThis());
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void vtk3DSImporter_ComputeNormalsOn_02(HandleRef pThis);

        /// <summary>
        /// Set/Get the computation of normals. If on, imported geometry will
        /// be run through vtkPolyDataNormals.
        /// </summary>
        public virtual void ComputeNormalsOn()
        {
            vtk3DSImporter_ComputeNormalsOn_02(GetCppThis());
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int vtk3DSImporter_GetComputeNormals_03(HandleRef pThis);

        /// <summary>
        /// Set/Get the computation of normals. If on, imported geometry will
        /// be run through vtkPolyDataNormals.
        /// </summary>
        public virtual int GetComputeNormals()
        {
            return vtk3DSImporter_GetComputeNormals_03(GetCppThis());
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr vtk3DSImporter_GetFileName_04(HandleRef pThis);

        /// <summary>
        /// Specify the name of the file to read.
        /// </summary>
        public virtual string GetFileName()
        {
            return Marshal.PtrToStringAnsi(vtk3DSImporter_GetFileName_04(GetCppThis()));
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern long vtk3DSImporter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public override long GetNumberOfGenerationsFromBase(string type)
        {
            return vtk3DSImporter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern long vtk3DSImporter_GetNumberOfGenerationsFromBaseType_06(string type);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public new static long GetNumberOfGenerationsFromBaseType(string type)
        {
            return vtk3DSImporter_GetNumberOfGenerationsFromBaseType_06(type);
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern string vtk3DSImporter_GetOutputsDescription_07(HandleRef pThis);

        /// <summary>
        /// Get a printable string describing the outputs
        /// </summary>
        public override string GetOutputsDescription()
        {
            return vtk3DSImporter_GetOutputsDescription_07(GetCppThis());
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int vtk3DSImporter_IsA_08(HandleRef pThis, string type);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public override int IsA(string type)
        {
            return vtk3DSImporter_IsA_08(GetCppThis(), type);
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int vtk3DSImporter_IsTypeOf_09(string type);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public new static int IsTypeOf(string type)
        {
            return vtk3DSImporter_IsTypeOf_09(type);
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr vtk3DSImporter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public new vtk3DSImporter NewInstance()
        {
            vtk3DSImporter result = null;
            uint mteStatus = 0u;
            uint mteIndex = uint.MaxValue;
            uint rawRefCount = 0u;
            IntPtr intPtr = vtk3DSImporter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
            if (IntPtr.Zero != intPtr)
            {
                result = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
            }
            return result;
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr vtk3DSImporter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

        /// <summary>
        ///             Undocumented Block
        /// </summary>
        public new static vtk3DSImporter SafeDownCast(vtkObjectBase o)
        {
            vtk3DSImporter vtk3DSImporter2 = null;
            uint mteStatus = 0u;
            uint mteIndex = uint.MaxValue;
            uint rawRefCount = 0u;
            IntPtr intPtr = vtk3DSImporter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
            if (IntPtr.Zero != intPtr)
            {
                vtk3DSImporter2 = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
                if (found)
                {
                    vtk3DSImporter2.Register(null);
                }
            }
            return vtk3DSImporter2;
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void vtk3DSImporter_SetComputeNormals_13(HandleRef pThis, int _arg);

        /// <summary>
        /// Set/Get the computation of normals. If on, imported geometry will
        /// be run through vtkPolyDataNormals.
        /// </summary>
        public virtual void SetComputeNormals(int _arg)
        {
            vtk3DSImporter_SetComputeNormals_13(GetCppThis(), _arg);
        }

        [DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void vtk3DSImporter_SetFileName_14(HandleRef pThis, string _arg);

        /// <summary>
        /// Specify the name of the file to read.
        /// </summary>
        public virtual void SetFileName(string _arg)
        {
            vtk3DSImporter_SetFileName_14(GetCppThis(), _arg);
        }
    }
}
