using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

public class ConsoleMonitor : IDisposable
{
    const int STD_INPUT_HANDLE = -10;
    const int STD_OUTPUT_HANDLE = -11;
    const int STD_ERROR_HANDLE = -12;

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool WriteConsole(IntPtr hConsoleOutput, string lpBuffer,
           uint nNumberOfCharsToWrite, out uint lpNumberOfCharsWritten,
           IntPtr lpReserved);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool CloseHandle(IntPtr handle);

    private bool disposed = false;
    private IntPtr handle;
    private Component component;

    public ConsoleMonitor()
    {
        handle = GetStdHandle(STD_OUTPUT_HANDLE);
        if (handle == IntPtr.Zero)
            throw new InvalidOperationException("A console handle is not available.");

        component = new Component();

        string output = "The ConsoleMonitor class constructor.\n";
        uint written = 0;
        WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);
    }

    // The destructor calls Object.Finalize.
    ~ConsoleMonitor()
    {
        /*Класс может содержать финализатор и вызывать из него Dispose(bool disposing) 
         * передавая false в качестве параметра
         */
        if (handle != IntPtr.Zero)
        {
            string output = "The ConsoleMonitor finalizer.\n";
            uint written = 0;
            WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);
        }
        else
        {
            Console.Error.WriteLine("Object finalization.");
        }
        // Call Dispose with disposing = false.
        Dispose(false);
    }

    public void Write()
    {
        string output = "The Write method.\n";
        uint written = 0;
        WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);
    }

    public void Dispose()
    {
        string output = "The Dispose method.\n";
        uint written = 0;
        WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);

        Dispose(true);
        GC.SuppressFinalize(this); // предотвращает вызов финализатора
    }

    private void Dispose(bool disposing) // параметр disposing говорит о том, вызывается ли этот метод из метода Dispose или из финализатора (деструктора)
    {

        /*Метод Dispose(bool disposing) содержит две части:
         * 1) если этот метод вызван из метода Dispose (т.е. параметр disposing равен true), то мы освобождаем управляемые и неуправляемые ресурсы
         * 2) если метод вызван из финализатора во время сборки мусора (параметр disposing равен false), то мы освобождаем только неуправляемые ресурсы*/

        string output = String.Format("The Dispose({0}) method.\n", disposing);
        uint written = 0;
        WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);

        // Execute if resources have not already been disposed.
       // поле disposed говорит о том, что ресурсы объекта уже освобождены. 
        if (!disposed)
        {
            // If the call is from Dispose, free managed resources.
            if (disposing)
            {
                Console.Error.WriteLine("Disposing of managed resources.");
                if (component != null)
                    component.Dispose();
            }
            // Free unmanaged resources.
            output = "Disposing of unmanaged resources.\n";
            WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);

            if (handle != IntPtr.Zero)
            {
                if (!CloseHandle(handle))
                    Console.Error.WriteLine("Handle cannot be closed.\n");
            }
        }
        disposed = true;
    }
}

public class Example
{
    public static void Main()
    {
        ConsoleMonitor monitor = null;
        
        try
        {
            monitor = new ConsoleMonitor();
            monitor.Write();
        }
        catch
        { }
        finally
        {
            if (monitor != null)
                monitor.Dispose();
        }

        //using (ConsoleMonitor monitor2 = new ConsoleMonitor())
        //{
        //    monitor2.Write();
        //}
    }
}

