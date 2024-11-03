
using System.ComponentModel;

#region ImageSignatures
public enum ImageSignatures
{
    /// <summary>
    /// MZ
    /// </summary>
    [Description(" MZ"), Category("Data")]
    IMAGE_DOS_SIGNATURE         = 0x5A4D,

    /// <summary>
    /// NE
    /// </summary>
    [Description("NE"), Category("Data")]
    IMAGE_OS2_SIGNATURE         = 0x454E,

    /// <summary>
    /// LE
    /// </summary>
    [Description("LE"), Category("Data")]
    IMAGE_OS2_SIGNATURE_LE      = 0x454C,

    /// <summary>
    /// LE
    /// </summary>
    [Description("LE"), Category("Data")]
    IMAGE_VXD_SIGNATURE         = 0x454C,

    /// <summary>
    /// PE00
    /// </summary>
    [Description("PE00"), Category("Data")]
    IMAGE_NT_SIGNATURE          = 0x00004550
}
#endregion ImageSignatures

#region MachineTypes
/// <summary>
/// The Machine field has one of the following values, which specify the CPU type. An image file can be run only on the specified machine or on a system that emulates the specified machine.
/// </summary>
[Description("The Machine field has one of the following values, which specify the CPU type. An image file can be run only on the specified machine or on a system that emulates the specified machine."), Category("Data")]
public enum MachineTypes
{
    /// <summary>
    /// The content of this field is assumed to be applicable to any machine type
    /// </summary>
    [Description("The content of this field is assumed to be applicable to any machine type"), Category("Data")]
    IMAGE_FILE_MACHINE_UNKNOWN           = 0,

    /// <summary>
    /// Intel 386 or later processors and compatible processors
    /// </summary>
    [Description("Intel 386 or later processors and compatible processors"), Category("Data")]
    IMAGE_FILE_MACHINE_I386              = 0x014c,

    /// <summary>
    /// MIPS little-endian, 0x160 big-endian
    /// </summary>
    [Description("MIPS little-endian, 0x160 big-endian"), Category("Data")]
    IMAGE_FILE_MACHINE_R3000             = 0x0162,

    /// <summary>
    /// MIPS little-endian
    /// </summary>
    [Description("MIPS little-endian"), Category("Data")]
    IMAGE_FILE_MACHINE_R4000             = 0x0166,

    /// <summary>
    /// MIPS little-endian
    /// </summary>
    [Description("MIPS little-endian"), Category("Data")]
    IMAGE_FILE_MACHINE_R10000            = 0x0168,

    /// <summary>
    /// MIPS little-endian WCE v2
    /// </summary>
    [Description("MIPS little-endian WCE v2"), Category("Data")]
    IMAGE_FILE_MACHINE_WCEMIPSV2         = 0x0169,

    /// <summary>
    /// Alpha AXP, 32-bit address space
    /// </summary>
    [Description("Alpha AXP, 32-bit address space"), Category("Data")]
    IMAGE_FILE_MACHINE_ALPHA             = 0x0184,

    /// <summary>
    /// Hitachi SH3 little-endian
    /// </summary>
    [Description("Hitachi SH3 little-endian"), Category("Data")]
    IMAGE_FILE_MACHINE_SH3               = 0x01a2,

    /// <summary>
    /// Hitachi SH3 DSP
    /// </summary>
    [Description("Hitachi SH3 DSP"), Category("Data")]
    IMAGE_FILE_MACHINE_SH3DSP            = 0x01a3,

    /// <summary>
    /// Hitachi SH3E little-endian
    /// </summary>
    [Description("Hitachi SH3E little-endian"), Category("Data")]
    IMAGE_FILE_MACHINE_SH3E              = 0x01a4,

    /// <summary>
    /// Hitachi SH4 little-endian
    /// </summary>
    [Description("Hitachi SH4 little-endian"), Category("Data")]
    IMAGE_FILE_MACHINE_SH4               = 0x01a6,

    /// <summary>
    /// Hitachi SH5
    /// </summary>
    [Description("Hitachi SH5"), Category("Data")]
    IMAGE_FILE_MACHINE_SH5               = 0x01a8,

    /// <summary>
    /// ARM Little-Endian
    /// </summary>
    [Description("ARM Little-Endian"), Category("Data")]
    IMAGE_FILE_MACHINE_ARM               = 0x01c0,

    /// <summary>
    /// Thumb
    /// </summary>
    [Description("Thumb"), Category("Data")]
    IMAGE_FILE_MACHINE_THUMB             = 0x01c2,

    /// <summary>
    /// ARM Thumb-2 little endian
    /// </summary>
    [Description("ARM Thumb-2 little endian"), Category("Data")]
    IMAGE_FILE_MACHINE_ARMNT             = 0x01c4,

    /// <summary>
    /// Matsushita AM33
    /// </summary>
    [Description("Matsushita AM33"), Category("Data")]
    IMAGE_FILE_MACHINE_AM33              = 0x01d3,

    /// <summary>
    /// IBM PowerPC Little-Endian
    /// </summary>
    [Description("IBM PowerPC Little-Endian"), Category("Data")]
    IMAGE_FILE_MACHINE_POWERPC           = 0x01F0,

    /// <summary>
    /// Power PC with floating point support
    /// </summary>
    [Description("Power PC with floating point support"), Category("Data")]
    IMAGE_FILE_MACHINE_POWERPCFP         = 0x01f1,

    /// <summary>
    /// Intel Itanium processor family
    /// </summary>
    [Description("Intel Itanium processor family"), Category("Data")]
    IMAGE_FILE_MACHINE_IA64              = 0x0200,

    /// <summary>
    /// MIPS16
    /// </summary>
    [Description("MIPS16"), Category("Data")]
    IMAGE_FILE_MACHINE_MIPS16            = 0x0266,

    /// <summary>
    /// Alpha 64, 64-bit address space
    /// </summary>
    [Description("Alpha 64, 64-bit address space"), Category("Data")]
    IMAGE_FILE_MACHINE_ALPHA64           = 0x0284,

    /// <summary>
    /// MIPS with FPU
    /// </summary>
    [Description("MIPS with FPU"), Category("Data")]
    IMAGE_FILE_MACHINE_MIPSFPU           = 0x0366,

    /// <summary>
    /// MIPS
    /// </summary>
    [Description("MIPS16 with FPU"), Category("Data")]
    IMAGE_FILE_MACHINE_MIPSFPU16         = 0x0466,

    /// <summary>
    /// AXP 64 (Same as Alpha 64)
    /// </summary>
    [Description("AXP 64 (Same as Alpha 64)"), Category("Data")]
    IMAGE_FILE_MACHINE_AXP64             = IMAGE_FILE_MACHINE_ALPHA64,

    /// <summary>
    /// Infineon
    /// </summary>
    [Description("Infineon"), Category("Data")]
    IMAGE_FILE_MACHINE_TRICORE           = 0x0520,

    /// <summary>
    /// CEE
    /// </summary>
    [Description("CEE"), Category("Data")]
    IMAGE_FILE_MACHINE_CEF               = 0x0CEF,

    /// <summary>
    /// EFI Byte Code
    /// </summary>
    [Description("EFI Byte Code"), Category("Data")]
    IMAGE_FILE_MACHINE_EBC               = 0x0EBC,

    /// <summary>
    /// RISC-V 32-bit address space
    /// </summary>
    [Description("RISC-V 32-bit address space"), Category("Data")]
    IMAGE_FILE_MACHINE_RISV32            = 0x5032,

    /// <summary>
    /// RISC-V 64-bit address space
    /// </summary>
    [Description("RISC-V 64-bit address space"), Category("Data")]
    IMAGE_FILE_MACHINE_RISV64            = 0x5064,

    /// <summary>
    /// RISC-V 128-bit address space
    /// </summary>
    [Description("RISC-V 128-bit address space"), Category("Data")]
    IMAGE_FILE_MACHINE_RISV128           = 0x5128,

    /// <summary>
    /// LoongArch 32-bit processor family
    /// </summary>
    [Description("LoongArch 32-bit processor family"), Category("Data")]
    IMAGE_FILE_MACHINE_LOONGARCH32       = 0x6232,

    /// <summary>
    /// LoongArch 64-bit processor family
    /// </summary>
    [Description("LoongArch 64-bit processor family"), Category("Data")]
    IMAGE_FILE_MACHINE_LOONGARCH65       = 0x6264,

    /// <summary>
    /// AMD64 (x64)
    /// </summary>
    [Description("AMD64 (x64)"), Category("Data")]
    IMAGE_FILE_MACHINE_AMD64             = 0x8664,

    /// <summary>
    /// Mitsubishi M32R little endian
    /// </summary>
    [Description("Mitsubishi M32R little endian"), Category("Data")]
    IMAGE_FILE_MACHINE_M32R              = 0x9041,

    /// <summary>
    /// ARM64 little endian
    /// </summary>
    [Description("ARM64 little endian"), Category("Data")]
    IMAGE_FILE_MACHINE_ARM64             = 0xaa64,

    /// <summary>
    /// CEE
    /// </summary>
    [Description("CEE"), Category("Data")]
    IMAGE_FILE_MACHINE_CEE               = 0xC0EE,
}
#endregion MachineTypes

#region Characteristics
/// <summary>
/// The Characteristics field contains flags that indicate attributes of the object or image file.
/// </summary>
[Description("The Characteristics field contains flags that indicate attributes of the object or image file."), Category("Data")]
public enum Characteristics
{
    /// <summary>
    /// Image only, Windows CE, and Microsoft Windows NT and later. This indicates that the file does not contain base relocations and must therefore be loaded at its preferred base address. If the base address is not available, the loader reports an error. The default behavior of the linker is to strip base relocations from executable (EXE) files.
    /// </summary>
    [Description("Image only, Windows CE, and Microsoft Windows NT and later. This indicates that the file does not contain base relocations and must therefore be loaded at its preferred base address. If the base address is not available, the loader reports an error. The default behavior of the linker is to strip base relocations from executable (EXE) files."), Category("Data")]
    IMAGE_FILE_RELOCS_STRIPPED           = 0x0001,

    /// <summary>
    /// Image only. This indicates that the image file is valid and can be run. If this flag is not set, it indicates a linker error.
    /// </summary>
    [Description("Image only. This indicates that the image file is valid and can be run. If this flag is not set, it indicates a linker error."), Category("Data")]
    IMAGE_FILE_EXECUTABLE_IMAGE          = 0x0002,

    /// <summary>
    /// COFF line numbers have been removed. This flag is deprecated and should be zero.
    /// </summary>
    [Description("COFF line numbers have been removed. This flag is deprecated and should be zero."), Category("Data")]
    IMAGE_FILE_LINE_NUMS_STRIPPED        = 0x0004,

    /// <summary>
    /// COFF symbol table entries for local symbols have been removed. This flag is deprecated and should be zero.
    /// </summary>
    [Description("COFF symbol table entries for local symbols have been removed. This flag is deprecated and should be zero."), Category("Data")]
    IMAGE_FILE_LOCAL_SYMS_STRIPPED       = 0x0008,

    /// <summary>
    /// Obsolete. Aggressively trim working set. This flag is deprecated for Windows 2000 and later and must be zero.
    /// </summary>
    [Description("Obsolete. Aggressively trim working set. This flag is deprecated for Windows 2000 and later and must be zero."), Category("Data")]
    IMAGE_FILE_AGGRESIVE_WS_TRIM         = 0x0010,

    /// <summary>
    /// Application can handle > 2-GB addresses.
    /// </summary>
    [Description("Application can handle > 2-GB addresses."), Category("Data")]
    IMAGE_FILE_LARGE_ADDRESS_AWARE       = 0x0020,

    /// <summary>
    /// Little endian: the least significant bit (LSB) precedes the most significant bit (MSB) in memory. This flag is deprecated and should be zero.
    /// </summary>
    [Description("Little endian: the least significant bit (LSB) precedes the most significant bit (MSB) in memory. This flag is deprecated and should be zero."), Category("Data")]
    IMAGE_FILE_BYTES_REVERSED_LO         = 0x0080,

    /// <summary>
    /// Machine is based on a 32-bit-word architecture.
    /// </summary>
    [Description("Machine is based on a 32-bit-word architecture."), Category("Data")]
    IMAGE_FILE_32BIT_MACHINE             = 0x0100,

    /// <summary>
    /// Debugging information is removed from the image file.
    /// </summary>
    [Description("Debugging information is removed from the image file."), Category("Data")]
    IMAGE_FILE_DEBUG_STRIPPED            = 0x0200,

    /// <summary>
    /// If the image is on removable media, fully load it and copy it to the swap file.
    /// </summary>
    [Description("If the image is on removable media, fully load it and copy it to the swap file."), Category("Data")]
    IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP   = 0x0400,

    /// <summary>
    /// If the image is on network media, fully load it and copy it to the swap file.
    /// </summary>
    [Description("If the image is on network media, fully load it and copy it to the swap file."), Category("Data")]
    IMAGE_FILE_NET_RUN_FROM_SWAP         = 0x0800,

    /// <summary>
    /// The image file is a system file, not a user program.
    /// </summary>
    [Description("The image file is a system file, not a user program."), Category("Data")]
    IMAGE_FILE_SYSTEM                    = 0x1000,

    /// <summary>
    /// The image file is a dynamic-link library (DLL). Such files are considered executable files for almost all purposes, although they cannot be directly run.
    /// </summary>
    [Description("The image file is a dynamic-link library (DLL). Such files are considered executable files for almost all purposes, although they cannot be directly run."), Category("Data")]
    IMAGE_FILE_DLL                       = 0x2000,

    /// <summary>
    /// The file should be run only on a uniprocessor machine.
    /// </summary>
    [Description("The file should be run only on a uniprocessor machine."), Category("Data")]
    IMAGE_FILE_UP_SYSTEM_ONLY            = 0x4000,

    /// <summary>
    /// Big endian: the MSB precedes the LSB in memory. This flag is deprecated and should be zero.
    /// </summary>
    [Description("Big endian: the MSB precedes the LSB in memory. This flag is deprecated and should be zero."), Category("Data")]
    IMAGE_FILE_BYTES_REVERSED_HI         = 0x8000
}
#endregion Characteristics

#region WindowsSubsystem
/// <summary>
/// The following values defined for the Subsystem field of the optional header determine which Windows subsystem (if any) is required to run the image.
/// </summary>
[Description("The following values defined for the Subsystem field of the optional header determine which Windows subsystem (if any) is required to run the image."), Category("Data")]
public enum WindowsSubsystem
{
    /// <summary>
    /// An unknown subsystem
    /// </summary>
    [Description("An unknown subsystem"), Category("Data")]
    IMAGE_SUBSYSTEM_UNKNOWN                  = 0,

    /// <summary>
    /// Device drivers and native Windows processes
    /// </summary>
    [Description("Device drivers and native Windows processes"), Category("Data")]
    IMAGE_SUBSYSTEM_NATIVE                   = 1,  // Image doesn't require a subsystem.

    /// <summary>
    /// The Windows graphical user interface (GUI) subsystem
    /// </summary>
    [Description("The Windows graphical user interface (GUI) subsystem"), Category("Data")]
    IMAGE_SUBSYSTEM_WINDOWS_GUI              = 2,  // Image runs in the Windows GUI subsystem.

    /// <summary>
    /// The Windows character subsystem
    /// </summary>
    [Description("The Windows character subsystem"), Category("Data")]
    IMAGE_SUBSYSTEM_WINDOWS_CUI              = 3,  // Image runs in the Windows character subsystem.

    /// <summary>
    /// The OS/2 character subsystem
    /// </summary>
    [Description("The OS/2 character subsystem"), Category("Data")]
    IMAGE_SUBSYSTEM_OS2_CUI                  = 5,  // image runs in the OS/2 character subsystem.

    /// <summary>
    /// The Posix character subsystem
    /// </summary>
    [Description("The Posix character subsystem"), Category("Data")]
    IMAGE_SUBSYSTEM_POSIX_CUI                = 7,  // image runs in the Posix character subsystem.

    /// <summary>
    /// Native Win9x driver
    /// </summary>
    [Description("Native Win9x driver"), Category("Data")]
    IMAGE_SUBSYSTEM_NATIVE_WINDOWS           = 8,  // image is a native Win9x driver.

    /// <summary>
    /// Windows CE 
    /// </summary>
    [Description("Windows CE "), Category("Data")]
    IMAGE_SUBSYSTEM_WINDOWS_CE_GUI           = 9,  // Image runs in the Windows CE subsystem.

    /// <summary>
    /// An Extensible Firmware Interface (EFI) application
    /// </summary>
    [Description("An Extensible Firmware Interface (EFI) application"), Category("Data")]
    IMAGE_SUBSYSTEM_EFI_APPLICATION          = 10,  //

    /// <summary>
    /// An EFI driver with boot services
    /// </summary>
    [Description("An EFI driver with boot services"), Category("Data")]
    IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER  = 11,   //

    /// <summary>
    /// An EFI driver with run-time services
    /// </summary>
    [Description("An EFI driver with run-time services"), Category("Data")]
    IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER       = 12,  //

    /// <summary>
    /// An EFI ROM image
    /// </summary>
    [Description("An EFI ROM image"), Category("Data")]
    IMAGE_SUBSYSTEM_EFI_ROM                  = 13,

    /// <summary>
    /// XBOX
    /// </summary>
    [Description("XBOX"), Category("Data")]
    IMAGE_SUBSYSTEM_XBOX                     = 14,

    /// <summary>
    /// Windows boot application.
    /// </summary>
    [Description("Windows boot application."), Category("Data")]
    IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16,
}
#endregion WindowsSubsystem

#region DllCharacteristics
/// <summary>
/// Device drivers and native Windows processes
/// </summary>
[Description(""), Category("Data")]
public enum DllCharacteristics
{

    /// <summary>
    /// Device drivers and native Windows processes
    /// </summary>
    [Description(""), Category("Data")]
}
#endregion DllCharacteristics