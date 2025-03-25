using System.ComponentModel;
using Haley.Models;

namespace Haley.Enums {
    public enum AssetType {
        [Description("win32_baseboard")]
        MotherBoard,
        [Description("win32_bios")]
        BIOS,
        [Description("win32_logicaldisk")]
        LogicalDisk,
        [Description("win32_physicalmedia")]
        PhysicalMedia,
        [Description("win32_diskdrive")]
        DiskDrive,
        [Description("win32_physicalmemory")]
        RAM,
        //[Description("win32_desktopmonitor")]
        //DesktopMonitor,
        [Description("win32_computersystem")]
        Computer,
        [Description("win32_operatingsystem")]
        OS,
        [Scope("root\\cimv2")]
        [Description("win32_keyboard")]
        Keyboard,
        [Scope("root\\cimv2")]
        [Description("win32_sounddevice")]
        SoundDevice,
        [Scope("root\\cimv2")]
        [Description("win32_pointingdevice")]
        PointingDevice,
        [Scope("root\\wmi")]
        [Description("WmiMonitorID")]
        Monitor,
        [Description("win32_processor")]
        Processor
    }
}
