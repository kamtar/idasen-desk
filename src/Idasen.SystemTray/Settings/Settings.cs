﻿using Idasen.SystemTray.Interfaces ;
using Idasen.SystemTray.Utils ;

namespace Idasen.SystemTray.Settings
{
    public class Settings : ISettings
    {
        public uint   StandingHeightInCm      { get ; set ; } = Constants.DefaultHeightStandingInCm ;
        public uint   SeatingHeightInCm       { get ; set ; } = Constants.DefaultHeightSeatingInCm ;
        public uint   DeskMinHeightInCm       { get;  set; }  = Constants.DefaultDeskMinHeightInCm;
        public uint   DeskMaxHeightInCm       { get;  set; }  = Constants.DefaultDeskMaxHeightInCm;
        public string DeviceName              { get ; set ; } = Constants.DefaultDeviceName ;
        public ulong  DeviceAddress           { get ; set ; } = Constants.DefaultDeviceAddress ;
        public uint   DeviceMonitoringTimeout { get ; set ; } = Constants.DefaultDeviceMonitoringTimeout ;
        public bool   DeviceLocked            { get ; set ; } = Constants.DefaultLocked ;
        public bool   NotificationsEnabled    { get ; set ; } = Constants.NotificationsEnabled;
        public ulong DailyStandingMinutes { get; set; }
        public ulong DailySittingMinutes { get; set; }
        public ulong WeeklyStandingMinutes { get; set; }
        public ulong WeeklySittingMinutes { get; set; }

        public override string ToString ( )
        {
            return $"{nameof ( StandingHeightInCm )} = {StandingHeightInCm}, "           +
                   $"{nameof ( SeatingHeightInCm )} = {SeatingHeightInCm}, "             +
                   $"{nameof ( DeviceName )} = {DeviceName}, "                           +
                   $"{nameof ( DeviceAddress )} = {DeviceAddress}, "                     +
                   $"{nameof ( DeviceMonitoringTimeout )} = {DeviceMonitoringTimeout}, " +
                   $"{nameof(DeviceLocked)} = {DeviceLocked}" +
                   $"{nameof(DailyStandingMinutes)} = {DailyStandingMinutes}, " +
                   $"{nameof(DailySittingMinutes)} = {DailySittingMinutes}, " +
                   $"{nameof(WeeklyStandingMinutes)} = {WeeklyStandingMinutes}, " +
                   $"{nameof(WeeklySittingMinutes)} = {WeeklySittingMinutes}, ";
        }
    }
}