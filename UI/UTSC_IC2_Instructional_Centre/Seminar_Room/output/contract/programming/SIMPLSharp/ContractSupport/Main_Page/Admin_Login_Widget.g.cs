//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3501.16.0
//
//     Project:     Seminar_Room
//     Version:     1.0.0.0
//     Sdk:         CH5:2.11.1
//     Strategy:    Classic
//     IndexOnly:   True
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;
using Seminar_Room;

namespace Seminar_Room.Main_Page
{

    /// <summary>
    /// Admin_Login_Widget
    /// </summary>
    public partial interface IAdmin_Login_Widget 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Admin_Login_Widget.Visibility Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Admin_Login_Widget_Visibility_fb(Admin_Login_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Admin_Login_Widget.Visibility Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Admin_Login_Widget_Visibility_fb(bool digital);
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="admin_login_widget">The <see cref="IAdmin_Login_Widget"/> on which to apply the feedback.</param>
    public delegate void Admin_Login_WidgetBoolInputSigDelegate(BoolInputSig boolInputSig, IAdmin_Login_Widget admin_login_widget);

    /// <summary>
    /// Admin_Login_Widget
    /// </summary>
    internal partial class Admin_Login_Widget : IAdmin_Login_Widget, IDisposable
    {
        #region Standard CH5 Component members

        private ComponentMediator ComponentMediator { get; set; }

        public object UserObject { get; set; }

        /// <summary>
        /// Gets the ControlJoinId a.k.a. SmartObjectId.  This Id identifies the extender symbol.
        /// </summary>
        public uint ControlJoinId { get; private set; }

        private IList<BasicTriListWithSmartObject> _devices;

        /// <summary>
        /// Gets the list of devices.
        /// </summary>
        public IList<BasicTriListWithSmartObject> Devices { get { return _devices; } }

        #endregion

        #region Joins

        private static class Joins
        {
            /// <summary>
            /// Digital signals,
            /// </summary>
            internal static class Booleans
            {

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Main_Page.Admin_Login_Widget.Visibility_fb
                /// Admin_Login_Widget.Visibility
                /// </summary>
                public const uint Admin_Login_Widget_Visibility_fbState = 1;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin_Login_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal Admin_Login_Widget(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin_Login_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal Admin_Login_Widget(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
        {
        }

        /// <summary>
        /// Initializes a new instance with default itemCount.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        private void Initialize(uint controlJoinId)
        {
            Initialize(controlJoinId, null);
        }

        private Dictionary<string, Indexes> _indexLookup = new Dictionary<string, Indexes>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin_Login_Widget"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        #endregion

        #region CH5 Contract

        /// <inheritdoc/>
        public void Admin_Login_Widget_Visibility_fb(Admin_Login_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Admin_Login_Widget_Visibility_fbState], this);
            }
        }

        /// <inheritdoc/>
        public void Admin_Login_Widget_Visibility_fb(bool digital)
        {
            Admin_Login_Widget_Visibility_fb((sig, component) => sig.BoolValue = digital);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Admin_Login_Widget", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

        }

        #endregion
    }
}
