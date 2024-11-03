namespace PExplorer.PEFile;

/// <summary>
/// DOS .EXE header
/// </summary>
public struct IMAGE_DOS_HEADER
{
    /// <summary>
    /// Magic number
    /// </summary>
    UInt16   e_magic;

    /// <summary>
    /// Bytes on last page of file
    /// </summary>
    UInt16   e_cblp;

    /// <summary>
    /// Pages in file
    /// </summary>
    UInt16   e_cp;

    /// <summary>
    /// Relocations
    /// </summary>
    UInt16   e_crlc;

    /// <summary>
    /// Size of header in paragraphs
    /// </summary>
    UInt16   e_cparhdr;

    /// <summary>
    /// Minimum extra paragraphs needed
    /// </summary>
    UInt16   e_minalloc;

    /// <summary>
    /// Maximum extra paragraphs needed
    /// </summary>
    UInt16   e_maxalloc;

    /// <summary>
    /// Initial (relative) SS value
    /// </summary>
    UInt16   e_ss;

    /// <summary>
    /// Initial SP value
    /// </summary>
    UInt16   e_sp;

    /// <summary>
    /// Checksum
    /// </summary>
    UInt16   e_csum;

    /// <summary>
    /// Initial IP value
    /// </summary>
    UInt16   e_ip;

    /// <summary>
    /// Initial (relative) CS value
    /// </summary>
    UInt16   e_cs;

    /// <summary>
    /// File address of relocation table
    /// </summary>
    UInt16   e_lfarlc;

    /// <summary>
    /// Overlay number
    /// </summary>
    UInt16   e_ovno;

    /// <summary>
    /// Reserved words
    /// </summary>
    UInt16   e_res_0;
    UInt16   e_res_1;
    UInt16   e_res_2;
    UInt16   e_res_3;

    /// <summary>
    /// OEM identifier (for e_oeminfo)
    /// </summary>
    UInt16   e_oemid;

    /// <summary>
    /// OEM information; e_oemid specific
    /// </summary>
    UInt16   e_oeminfo;

    /// <summary>
    /// Reserved words
    /// </summary>
    UInt16   e_res2_0;
    UInt16   e_res2_1;
    UInt16   e_res2_2;
    UInt16   e_res2_3;
    UInt16   e_res2_4;
    UInt16   e_res2_5;
    UInt16   e_res2_6;
    UInt16   e_res2_7;
    UInt16   e_res2_9;

    ///<Summary>
    /// File address of new exe header
    /// </Summary>
    Int32   e_lfanew;
  }
