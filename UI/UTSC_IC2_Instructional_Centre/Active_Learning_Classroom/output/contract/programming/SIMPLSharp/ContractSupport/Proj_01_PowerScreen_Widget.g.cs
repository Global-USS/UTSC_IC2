//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3501.16.0
//
//     Project:     Active_Learning_Classroom
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
using Active_Learning_Classroom;

namespace Active_Learning_Classroom
{

    /// <summary>
    /// Proj_01_Power-Screen_Widget
    /// </summary>
    public partial interface IProj_01_PowerScreen_Widget 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event Btn.ProjImageMuteTgl.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnProjImageMuteTgl_PressEvent;

        /// <summary>
        /// Event Btn.ProjPowerOff.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnProjPowerOff_PressEvent;

        /// <summary>
        /// Event Btn.ProjPowerOn.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnProjPowerOn_PressEvent;

        /// <summary>
        /// Event Btn.ScreenDown.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnScreenDown_PressEvent;

        /// <summary>
        /// Event Btn.SrceenUp.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnSrceenUp_PressEvent;

        /// <summary>
        /// Btn.ProjImageMuteTgl.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProjImageMuteTgl_Selected(Proj_01_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.ProjImageMuteTgl.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProjImageMuteTgl_Selected(bool digital);

        /// <summary>
        /// Btn.ProjPowerOff.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProjPowerOff_Selected(Proj_01_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.ProjPowerOff.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProjPowerOff_Selected(bool digital);

        /// <summary>
        /// Btn.ProjPowerOn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProjPowerOn_Selected(Proj_01_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.ProjPowerOn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProjPowerOn_Selected(bool digital);
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="proj_01_powerscreen_widget">The <see cref="IProj_01_PowerScreen_Widget"/> on which to apply the feedback.</param>
    public delegate void Proj_01_PowerScreen_WidgetBoolInputSigDelegate(BoolInputSig boolInputSig, IProj_01_PowerScreen_Widget proj_01_powerscreen_widget);

    /// <summary>
    /// Proj_01_Power-Screen_Widget
    /// </summary>
    internal partial class Proj_01_PowerScreen_Widget : IProj_01_PowerScreen_Widget, IDisposable
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
                /// Output or Event digital joinInfo from panel to Control System: Proj_01_PowerScreen_Widget.BtnProjImageMuteTgl.Press
                /// Btn.ProjImageMuteTgl.Press
                /// </summary>
                public const uint BtnProjImageMuteTgl_PressEvent = 3;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_01_PowerScreen_Widget.BtnProjPowerOff.Press
                /// Btn.ProjPowerOff.Press
                /// </summary>
                public const uint BtnProjPowerOff_PressEvent = 4;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_01_PowerScreen_Widget.BtnProjPowerOn.Press
                /// Btn.ProjPowerOn.Press
                /// </summary>
                public const uint BtnProjPowerOn_PressEvent = 5;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_01_PowerScreen_Widget.BtnScreenDown.Press
                /// Btn.ScreenDown.Press
                /// </summary>
                public const uint BtnScreenDown_PressEvent = 6;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_01_PowerScreen_Widget.BtnSrceenUp.Press
                /// Btn.SrceenUp.Press
                /// </summary>
                public const uint BtnSrceenUp_PressEvent = 7;


                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_01_PowerScreen_Widget.BtnProjImageMuteTgl.Selected
                /// Btn.ProjImageMuteTgl.Selected
                /// </summary>
                public const uint BtnProjImageMuteTgl_SelectedState = 3;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_01_PowerScreen_Widget.BtnProjPowerOff.Selected
                /// Btn.ProjPowerOff.Selected
                /// </summary>
                public const uint BtnProjPowerOff_SelectedState = 4;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_01_PowerScreen_Widget.BtnProjPowerOn.Selected
                /// Btn.ProjPowerOn.Selected
                /// </summary>
                public const uint BtnProjPowerOn_SelectedState = 5;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="Proj_01_PowerScreen_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal Proj_01_PowerScreen_Widget(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proj_01_PowerScreen_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal Proj_01_PowerScreen_Widget(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="Proj_01_PowerScreen_Widget"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProjImageMuteTgl_PressEvent, onBtnProjImageMuteTgl_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProjPowerOff_PressEvent, onBtnProjPowerOff_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProjPowerOn_PressEvent, onBtnProjPowerOn_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnScreenDown_PressEvent, onBtnScreenDown_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnSrceenUp_PressEvent, onBtnSrceenUp_Press);
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
        public event EventHandler<UIEventArgs> BtnProjImageMuteTgl_PressEvent;
        private void onBtnProjImageMuteTgl_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProjImageMuteTgl_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> BtnProjPowerOff_PressEvent;
        private void onBtnProjPowerOff_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProjPowerOff_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> BtnProjPowerOn_PressEvent;
        private void onBtnProjPowerOn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProjPowerOn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> BtnScreenDown_PressEvent;
        private void onBtnScreenDown_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnScreenDown_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> BtnSrceenUp_PressEvent;
        private void onBtnSrceenUp_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnSrceenUp_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public void BtnProjImageMuteTgl_Selected(Proj_01_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProjImageMuteTgl_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void BtnProjImageMuteTgl_Selected(bool digital)
        {
            BtnProjImageMuteTgl_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void BtnProjPowerOff_Selected(Proj_01_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProjPowerOff_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void BtnProjPowerOff_Selected(bool digital)
        {
            BtnProjPowerOff_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void BtnProjPowerOn_Selected(Proj_01_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProjPowerOn_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void BtnProjPowerOn_Selected(bool digital)
        {
            BtnProjPowerOn_Selected((sig, component) => sig.BoolValue = digital);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Proj_01_PowerScreen_Widget", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            BtnProjImageMuteTgl_PressEvent = null;
            BtnProjPowerOff_PressEvent = null;
            BtnProjPowerOn_PressEvent = null;
            BtnScreenDown_PressEvent = null;
            BtnSrceenUp_PressEvent = null;
        }

        #endregion
    }
}
