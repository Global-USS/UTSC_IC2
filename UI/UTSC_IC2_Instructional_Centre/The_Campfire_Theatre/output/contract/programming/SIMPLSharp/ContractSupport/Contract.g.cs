//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3400.21.0
//
//     Project:     The_Campfire_Theatre
//     Version:     1.0.0.0
//     Sdk:         CH5:2.8.0
//     Strategy:    Classic
//     IndexOnly:   False
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace The_Campfire_Theatre
{
    /// <summary>
    /// Common Interface for Root Contracts.
    /// </summary>
    public interface IContract
    {
        object UserObject { get; set; }
        void AddDevice(BasicTriListWithSmartObject device);
        void RemoveDevice(BasicTriListWithSmartObject device);

        /// <summary>
        /// Fires on ANY activity on the panel.
        /// </summary>
        event EventHandler<EventArgs> Activity;
    }

    /// <summary>
    /// Root contract giving access to top level project items such as Pages and global Widgets.
    /// </summary>
    public sealed class Contract : IContract, IDisposable
    {
        #region Components

        private ComponentMediator ComponentMediator { get; set; }

        public The_Campfire_Theatre.IShutdown_Page Shutdown_Page { get { return (The_Campfire_Theatre.IShutdown_Page)InternalShutdown_Page; } }
        private The_Campfire_Theatre.Shutdown_Page InternalShutdown_Page { get; set; }

        public The_Campfire_Theatre.Main_Page.IMain_Page Main_Page { get { return (The_Campfire_Theatre.Main_Page.IMain_Page)InternalMain_Page; } }
        private The_Campfire_Theatre.Main_Page.Main_Page InternalMain_Page { get; set; }

        public The_Campfire_Theatre.ILogin_Page Login_Page { get { return (The_Campfire_Theatre.ILogin_Page)InternalLogin_Page; } }
        private The_Campfire_Theatre.Login_Page InternalLogin_Page { get; set; }

        public The_Campfire_Theatre.ILogOff_Page LogOff_Page { get { return (The_Campfire_Theatre.ILogOff_Page)InternalLogOff_Page; } }
        private The_Campfire_Theatre.LogOff_Page InternalLogOff_Page { get; set; }

        public The_Campfire_Theatre.IWelcome_Page Welcome_Page { get { return (The_Campfire_Theatre.IWelcome_Page)InternalWelcome_Page; } }
        private The_Campfire_Theatre.Welcome_Page InternalWelcome_Page { get; set; }

        public The_Campfire_Theatre.IVolume_Control_03_Panel_Widget Volume_Control_03_Panel_Widget { get { return (The_Campfire_Theatre.IVolume_Control_03_Panel_Widget)InternalVolume_Control_03_Panel_Widget; } }
        private The_Campfire_Theatre.Volume_Control_03_Panel_Widget InternalVolume_Control_03_Panel_Widget { get; set; }

        public The_Campfire_Theatre.Source_04_Widget.ISource_04_Widget Source_04_Widget { get { return (The_Campfire_Theatre.Source_04_Widget.ISource_04_Widget)InternalSource_04_Widget; } }
        private The_Campfire_Theatre.Source_04_Widget.Source_04_Widget InternalSource_04_Widget { get; set; }

        public The_Campfire_Theatre.ICam_03_ControlPreset_Widget Cam_03_ControlPreset_Widget { get { return (The_Campfire_Theatre.ICam_03_ControlPreset_Widget)InternalCam_03_ControlPreset_Widget; } }
        private The_Campfire_Theatre.Cam_03_ControlPreset_Widget InternalCam_03_ControlPreset_Widget { get; set; }

        public The_Campfire_Theatre.IAdmin_Login_Widget Admin_Login_Widget { get { return (The_Campfire_Theatre.IAdmin_Login_Widget)InternalAdmin_Login_Widget; } }
        private The_Campfire_Theatre.Admin_Login_Widget InternalAdmin_Login_Widget { get; set; }

        public The_Campfire_Theatre.IVidWall_Control_Widget VidWall_Control_Widget { get { return (The_Campfire_Theatre.IVidWall_Control_Widget)InternalVidWall_Control_Widget; } }
        private The_Campfire_Theatre.VidWall_Control_Widget InternalVidWall_Control_Widget { get; set; }

        public The_Campfire_Theatre.Volume_Control_0x_Panel_Widget.IVolume_Control_0x_Panel_Widget Volume_Control_0x_Panel_Widget { get { return (The_Campfire_Theatre.Volume_Control_0x_Panel_Widget.IVolume_Control_0x_Panel_Widget)InternalVolume_Control_0x_Panel_Widget; } }
        private The_Campfire_Theatre.Volume_Control_0x_Panel_Widget.Volume_Control_0x_Panel_Widget InternalVolume_Control_0x_Panel_Widget { get; set; }

        public The_Campfire_Theatre.ICam_03_Control_Widget Cam_03_Control_Widget { get { return (The_Campfire_Theatre.ICam_03_Control_Widget)InternalCam_03_Control_Widget; } }
        private The_Campfire_Theatre.Cam_03_Control_Widget InternalCam_03_Control_Widget { get; set; }

        #endregion

        #region Construction and Initialization

        public Contract()
            : this(new List<BasicTriListWithSmartObject>().ToArray())
        {
        }

        public Contract(BasicTriListWithSmartObject device)
            : this(new [] { device })
        {
        }

        public Contract(BasicTriListWithSmartObject[] devices)
        {
            if (devices == null)
                throw new ArgumentNullException("Devices is null");

            ComponentMediator = new ComponentMediator();
            ComponentMediator.ConfigureActivityEvent(onActivity);

            InternalShutdown_Page = new The_Campfire_Theatre.Shutdown_Page(ComponentMediator, 1);

            InternalMain_Page = new The_Campfire_Theatre.Main_Page.Main_Page(ComponentMediator, 2);

            InternalLogin_Page = new The_Campfire_Theatre.Login_Page(ComponentMediator, 9);

            InternalLogOff_Page = new The_Campfire_Theatre.LogOff_Page(ComponentMediator, 10);

            InternalWelcome_Page = new The_Campfire_Theatre.Welcome_Page(ComponentMediator, 11);

            InternalVolume_Control_03_Panel_Widget = new The_Campfire_Theatre.Volume_Control_03_Panel_Widget(ComponentMediator, 12);

            InternalSource_04_Widget = new The_Campfire_Theatre.Source_04_Widget.Source_04_Widget(ComponentMediator, 13);

            InternalCam_03_ControlPreset_Widget = new The_Campfire_Theatre.Cam_03_ControlPreset_Widget(ComponentMediator, 15);

            InternalAdmin_Login_Widget = new The_Campfire_Theatre.Admin_Login_Widget(ComponentMediator, 16);

            InternalVidWall_Control_Widget = new The_Campfire_Theatre.VidWall_Control_Widget(ComponentMediator, 17);

            InternalVolume_Control_0x_Panel_Widget = new The_Campfire_Theatre.Volume_Control_0x_Panel_Widget.Volume_Control_0x_Panel_Widget(ComponentMediator, 18);

            InternalCam_03_Control_Widget = new The_Campfire_Theatre.Cam_03_Control_Widget(ComponentMediator, 20);


            for (int index = 0; index < devices.Length; index++)
            {
                AddDevice(devices[index]);
            }
        }

        /// <summary>
        /// Fires on ANY activity on the panel.
        /// </summary>
        public event EventHandler<EventArgs> Activity;
        private void onActivity(GenericBase currentDevice, SmartObjectEventArgs args)
        {
            var handler = Activity;
            if (handler != null)
                handler(currentDevice, args);
        }
        #endregion

        #region Standard Contract Members

        public object UserObject { get; set; }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            InternalShutdown_Page.AddDevice(device);
            InternalMain_Page.AddDevice(device);
            InternalLogin_Page.AddDevice(device);
            InternalLogOff_Page.AddDevice(device);
            InternalWelcome_Page.AddDevice(device);
            InternalVolume_Control_03_Panel_Widget.AddDevice(device);
            InternalSource_04_Widget.AddDevice(device);
            InternalCam_03_ControlPreset_Widget.AddDevice(device);
            InternalAdmin_Login_Widget.AddDevice(device);
            InternalVidWall_Control_Widget.AddDevice(device);
            InternalVolume_Control_0x_Panel_Widget.AddDevice(device);
            InternalCam_03_Control_Widget.AddDevice(device);

        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            InternalShutdown_Page.RemoveDevice(device);
            InternalMain_Page.RemoveDevice(device);
            InternalLogin_Page.RemoveDevice(device);
            InternalLogOff_Page.RemoveDevice(device);
            InternalWelcome_Page.RemoveDevice(device);
            InternalVolume_Control_03_Panel_Widget.RemoveDevice(device);
            InternalSource_04_Widget.RemoveDevice(device);
            InternalCam_03_ControlPreset_Widget.RemoveDevice(device);
            InternalAdmin_Login_Widget.RemoveDevice(device);
            InternalVidWall_Control_Widget.RemoveDevice(device);
            InternalVolume_Control_0x_Panel_Widget.RemoveDevice(device);
            InternalCam_03_Control_Widget.RemoveDevice(device);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            InternalShutdown_Page.Dispose();
            InternalMain_Page.Dispose();
            InternalLogin_Page.Dispose();
            InternalLogOff_Page.Dispose();
            InternalWelcome_Page.Dispose();
            InternalVolume_Control_03_Panel_Widget.Dispose();
            InternalSource_04_Widget.Dispose();
            InternalCam_03_ControlPreset_Widget.Dispose();
            InternalAdmin_Login_Widget.Dispose();
            InternalVidWall_Control_Widget.Dispose();
            InternalVolume_Control_0x_Panel_Widget.Dispose();
            InternalCam_03_Control_Widget.Dispose();

            ComponentMediator.Dispose(); 
        }

        #endregion
    }
}
