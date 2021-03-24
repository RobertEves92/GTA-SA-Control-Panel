using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace GTASAControlPanel.Modules
{
    /// <summary>
    /// Class for handling reading and writing to a processes memory
    /// Modified version of code found at https://stackoverflow.com/questions/50672268/c-sharp-reading-another-process-memory
    /// </summary>
    public static class Memory
    {
        private static Process m_Process;
        private static IntPtr m_pProcessHandle;

        private static int m_iNumberOfBytesRead = 0;
        private static int m_iNumberOfBytesWritten = 0;

        private static bool isConnected = false;

        /// <summary>
        /// Checks if this program is connected to the gta process
        /// </summary>
        public static bool IsConnected
        {
            get
            {
                //should return false if not connected or of process has ended for whatever reason
                if (isConnected)
                {
                    return !m_Process.HasExited;
                }

                return isConnected;
            }
        }

        /// <summary>
        /// Sets up the connection to a specified process
        /// </summary>
        /// <param name="ProcessName"></param>
        public static void Initialize(string ProcessName)
        {
            // Check if process is running
            if (Process.GetProcessesByName(ProcessName).Length > 0)
            {
                m_Process = Process.GetProcessesByName(ProcessName)[0];
            }
            else
            {
                throw new ArgumentException("Couldn't find " + ProcessName);
            }

            m_pProcessHandle = OpenProcess(PROCESS_VM_OPERATION | PROCESS_VM_READ | PROCESS_VM_WRITE, false, m_Process.Id); // Sets Our ProcessHandle
            isConnected = true;
        }

        /// <summary>
        /// Gets the address of a specified module
        /// </summary>
        /// <param name="ModuleName">Name of the module to get the address of</param>
        /// <returns>memory address as int</returns>
        public static int GetModuleAddress(string ModuleName)
        {
            try
            {
                foreach (ProcessModule ProcMod in m_Process.Modules)
                {
                    if (!ModuleName.Contains(".dll"))
                    {
                        ModuleName = ModuleName.Insert(ModuleName.Length, ".dll");
                    }

                    if (ModuleName == ProcMod.ModuleName)
                    {
                        return (int)ProcMod.BaseAddress;
                    }
                }
            }
            catch
            {/*
                    * Ignored catch: needs to exist for code to compile,
                    * but return line needs to be outside of catch for method to compile
                    */
            }
            return -1;
        }

        #region Read

        /// <summary>
        /// Reads data from a specified memory address
        /// </summary>
        /// <typeparam name="T">Type of data to return</typeparam>
        /// <param name="Address">Address (as long) to read from</param>
        /// <returns>Stored memory data in specified data type</returns>
        public static T ReadMemory<T>(long Address) where T : struct
        {
            return ReadMemory<T>(Convert.ToInt32(Address));
        }

        private static T ReadMemory<T>(int Address) where T : struct
        {
            int ByteSize = Marshal.SizeOf(typeof(T)); // Get ByteSize Of DataType
            byte[] buffer = new byte[ByteSize]; // Create A Buffer With Size Of ByteSize
            ReadProcessMemory((int)m_pProcessHandle, Address, buffer, buffer.Length, ref m_iNumberOfBytesRead); // Read Value From Memory

            return ByteArrayToStructure<T>(buffer); // Transform the ByteArray to The Desired DataType
        }

        private static float[] ReadMatrix<T>(int Address, int MatrixSize) where T : struct
        {
            int ByteSize = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[ByteSize * MatrixSize]; // Create A Buffer With Size Of ByteSize * MatrixSize
            ReadProcessMemory((int)m_pProcessHandle, Address, buffer, buffer.Length, ref m_iNumberOfBytesRead);

            return ConvertToFloatArray(buffer); // Transform the ByteArray to A Float Array (PseudoMatrix ;P)
        }

        #endregion Read

        #region Write

        /// <summary>
        /// Writes data to a specified memory arrdress
        /// </summary>
        /// <typeparam name="T">Data type that is being written</typeparam>
        /// <param name="Address">Memory address (as int) to write to</param>
        /// <param name="Value">Data to write</param>
        public static void WriteMemory<T>(int Address, object Value)
        {
            byte[] buffer = StructureToByteArray(Value); // Transform Data To ByteArray

            WriteProcessMemory((int)m_pProcessHandle, Address, buffer, buffer.Length, out m_iNumberOfBytesWritten);
        }

        private static void WriteMemory<T>(int Address, char[] Value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(Value);

            WriteProcessMemory((int)m_pProcessHandle, Address, buffer, buffer.Length, out m_iNumberOfBytesWritten);
        }

        private static void WriteMemory<T>(string Address, char[] Value)
        {
            WriteMemory<T>(int.Parse(Address, System.Globalization.NumberStyles.HexNumber), Value);
        }

        #endregion Write

        #region Transformation

        private static float[] ConvertToFloatArray(byte[] bytes)
        {
            if (bytes.Length % 4 != 0)
            {
                throw new ArgumentException("Invalid data length");
            }

            float[] floats = new float[bytes.Length / 4];

            for (int i = 0; i < floats.Length; i++)
            {
                floats[i] = BitConverter.ToSingle(bytes, i * 4);
            }

            return floats;
        }

        private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                handle.Free();
            }
        }

        private static byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);

            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        #endregion Transformation

        #region DllImports

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesWritten);

        #endregion DllImports

        #region Constants

        private const int PROCESS_VM_OPERATION = 0x0008;
        private const int PROCESS_VM_READ = 0x0010;
        private const int PROCESS_VM_WRITE = 0x0020;

        #endregion Constants
    }
}