//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3300.16.0
//
//     Project:     Standard_Classroom
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
using Standard_Classroom;

namespace Standard_Classroom
{

    /// <summary>
    /// Proj_02_Power-Screen_Widget
    /// </summary>
    public partial interface IProj_02_PowerScreen_Widget 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Btn.Proj[1]_ImageMuteTgl.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnProj_1__ImageMuteTgl_PressEvent;

        /// <summary>
        /// Btn.Proj[1]_PowerOff.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnProj_1__PowerOff_PressEvent;

        /// <summary>
        /// Btn.Proj[1]_PowerOn.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnProj_1__PowerOn_PressEvent;

        /// <summary>
        /// Btn.Proj[2]_ImageMuteTgl.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnProj_2__ImageMuteTgl_PressEvent;

        /// <summary>
        /// Btn.Proj[2]_PowerOff.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnProj_2__PowerOff_PressEvent;

        /// <summary>
        /// Btn.Proj[2]_PowerOn.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnProj_2__PowerOn_PressEvent;

        /// <summary>
        /// Btn.Screen[1]_Down.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnScreen_1__Down_PressEvent;

        /// <summary>
        /// Btn.Screen[2]_Down.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnScreen_2__Down_PressEvent;

        /// <summary>
        /// Btn.Screen[2]_Up.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnScreen_2__Up_PressEvent;

        /// <summary>
        /// Btn.Srceen[1]_Up.Press
        /// </summary>
        event EventHandler<UIEventArgs> BtnSrceen_1__Up_PressEvent;

        /// <summary>
        /// Btn.Proj[1]_ImageMuteTgl.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProj_1__ImageMuteTgl_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.Proj[1]_ImageMuteTgl.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProj_1__ImageMuteTgl_Selected(bool digital);

        /// <summary>
        /// Btn.Proj[1]_PowerOff.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProj_1__PowerOff_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.Proj[1]_PowerOff.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProj_1__PowerOff_Selected(bool digital);

        /// <summary>
        /// Btn.Proj[1]_PowerOn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProj_1__PowerOn_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.Proj[1]_PowerOn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProj_1__PowerOn_Selected(bool digital);

        /// <summary>
        /// Btn.Proj[2]_ImageMuteTgl.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProj_2__ImageMuteTgl_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.Proj[2]_ImageMuteTgl.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProj_2__ImageMuteTgl_Selected(bool digital);

        /// <summary>
        /// Btn.Proj[2]_PowerOff.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProj_2__PowerOff_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.Proj[2]_PowerOff.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProj_2__PowerOff_Selected(bool digital);

        /// <summary>
        /// Btn.Proj[2]_PowerOn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void BtnProj_2__PowerOn_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback);

        /// <summary>
        /// Btn.Proj[2]_PowerOn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void BtnProj_2__PowerOn_Selected(bool digital);
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> signal data.</param>
    /// <param name="proj_02_powerscreen_widget">The <see cref="IProj_02_PowerScreen_Widget"/> on which to apply the feedback.</param>
    public delegate void Proj_02_PowerScreen_WidgetBoolInputSigDelegate(BoolInputSig boolInputSig, IProj_02_PowerScreen_Widget proj_02_powerscreen_widget);

    /// <summary>
    /// Proj_02_Power-Screen_Widget
    /// </summary>
    internal partial class Proj_02_PowerScreen_Widget : IProj_02_PowerScreen_Widget, IDisposable
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
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnProj[1]_ImageMuteTgl.Press
                /// Btn.Proj[1]_ImageMuteTgl.Press
                /// </summary>
                public const uint BtnProj_1__ImageMuteTgl_PressEvent = 3;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnProj[1]_PowerOff.Press
                /// Btn.Proj[1]_PowerOff.Press
                /// </summary>
                public const uint BtnProj_1__PowerOff_PressEvent = 4;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnProj[1]_PowerOn.Press
                /// Btn.Proj[1]_PowerOn.Press
                /// </summary>
                public const uint BtnProj_1__PowerOn_PressEvent = 5;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnProj[2]_ImageMuteTgl.Press
                /// Btn.Proj[2]_ImageMuteTgl.Press
                /// </summary>
                public const uint BtnProj_2__ImageMuteTgl_PressEvent = 6;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnProj[2]_PowerOff.Press
                /// Btn.Proj[2]_PowerOff.Press
                /// </summary>
                public const uint BtnProj_2__PowerOff_PressEvent = 7;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnProj[2]_PowerOn.Press
                /// Btn.Proj[2]_PowerOn.Press
                /// </summary>
                public const uint BtnProj_2__PowerOn_PressEvent = 8;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnScreen[1]_Down.Press
                /// Btn.Screen[1]_Down.Press
                /// </summary>
                public const uint BtnScreen_1__Down_PressEvent = 9;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnScreen[2]_Down.Press
                /// Btn.Screen[2]_Down.Press
                /// </summary>
                public const uint BtnScreen_2__Down_PressEvent = 10;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnScreen[2]_Up.Press
                /// Btn.Screen[2]_Up.Press
                /// </summary>
                public const uint BtnScreen_2__Up_PressEvent = 11;

                /// <summary>
                /// Output or Event digital signal from panel to Control System: Proj_02_PowerScreen_Widget.BtnSrceen[1]_Up.Press
                /// Btn.Srceen[1]_Up.Press
                /// </summary>
                public const uint BtnSrceen_1__Up_PressEvent = 12;


                /// <summary>
                /// Input or Feedback digital signal from Control System to panel: Proj_02_PowerScreen_Widget.BtnProj[1]_ImageMuteTgl.Selected
                /// Btn.Proj[1]_ImageMuteTgl.Selected
                /// </summary>
                public const uint BtnProj_1__ImageMuteTgl_SelectedState = 3;

                /// <summary>
                /// Input or Feedback digital signal from Control System to panel: Proj_02_PowerScreen_Widget.BtnProj[1]_PowerOff.Selected
                /// Btn.Proj[1]_PowerOff.Selected
                /// </summary>
                public const uint BtnProj_1__PowerOff_SelectedState = 4;

                /// <summary>
                /// Input or Feedback digital signal from Control System to panel: Proj_02_PowerScreen_Widget.BtnProj[1]_PowerOn.Selected
                /// Btn.Proj[1]_PowerOn.Selected
                /// </summary>
                public const uint BtnProj_1__PowerOn_SelectedState = 5;

                /// <summary>
                /// Input or Feedback digital signal from Control System to panel: Proj_02_PowerScreen_Widget.BtnProj[2]_ImageMuteTgl.Selected
                /// Btn.Proj[2]_ImageMuteTgl.Selected
                /// </summary>
                public const uint BtnProj_2__ImageMuteTgl_SelectedState = 6;

                /// <summary>
                /// Input or Feedback digital signal from Control System to panel: Proj_02_PowerScreen_Widget.BtnProj[2]_PowerOff.Selected
                /// Btn.Proj[2]_PowerOff.Selected
                /// </summary>
                public const uint BtnProj_2__PowerOff_SelectedState = 7;

                /// <summary>
                /// Input or Feedback digital signal from Control System to panel: Proj_02_PowerScreen_Widget.BtnProj[2]_PowerOn.Selected
                /// Btn.Proj[2]_PowerOn.Selected
                /// </summary>
                public const uint BtnProj_2__PowerOn_SelectedState = 8;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="Proj_02_PowerScreen_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal Proj_02_PowerScreen_Widget(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proj_02_PowerScreen_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal Proj_02_PowerScreen_Widget(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="Proj_02_PowerScreen_Widget"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProj_1__ImageMuteTgl_PressEvent, onBtnProj_1__ImageMuteTgl_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProj_1__PowerOff_PressEvent, onBtnProj_1__PowerOff_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProj_1__PowerOn_PressEvent, onBtnProj_1__PowerOn_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProj_2__ImageMuteTgl_PressEvent, onBtnProj_2__ImageMuteTgl_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProj_2__PowerOff_PressEvent, onBtnProj_2__PowerOff_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnProj_2__PowerOn_PressEvent, onBtnProj_2__PowerOn_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnScreen_1__Down_PressEvent, onBtnScreen_1__Down_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnScreen_2__Down_PressEvent, onBtnScreen_2__Down_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnScreen_2__Up_PressEvent, onBtnScreen_2__Up_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnSrceen_1__Up_PressEvent, onBtnSrceen_1__Up_Press);
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

        /// <summary>
        /// Event Btn.Proj[1]_ImageMuteTgl.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnProj_1__ImageMuteTgl_PressEvent;
        private void onBtnProj_1__ImageMuteTgl_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProj_1__ImageMuteTgl_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Proj[1]_PowerOff.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnProj_1__PowerOff_PressEvent;
        private void onBtnProj_1__PowerOff_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProj_1__PowerOff_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Proj[1]_PowerOn.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnProj_1__PowerOn_PressEvent;
        private void onBtnProj_1__PowerOn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProj_1__PowerOn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Proj[2]_ImageMuteTgl.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnProj_2__ImageMuteTgl_PressEvent;
        private void onBtnProj_2__ImageMuteTgl_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProj_2__ImageMuteTgl_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Proj[2]_PowerOff.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnProj_2__PowerOff_PressEvent;
        private void onBtnProj_2__PowerOff_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProj_2__PowerOff_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Proj[2]_PowerOn.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnProj_2__PowerOn_PressEvent;
        private void onBtnProj_2__PowerOn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnProj_2__PowerOn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Screen[1]_Down.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnScreen_1__Down_PressEvent;
        private void onBtnScreen_1__Down_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnScreen_1__Down_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Screen[2]_Down.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnScreen_2__Down_PressEvent;
        private void onBtnScreen_2__Down_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnScreen_2__Down_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Screen[2]_Up.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnScreen_2__Up_PressEvent;
        private void onBtnScreen_2__Up_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnScreen_2__Up_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Event Btn.Srceen[1]_Up.Press (from panel to Control System)
        /// </summary>
        public event EventHandler<UIEventArgs> BtnSrceen_1__Up_PressEvent;
        private void onBtnSrceen_1__Up_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnSrceen_1__Up_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[1]_ImageMuteTgl.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_1__ImageMuteTgl_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProj_1__ImageMuteTgl_SelectedState], this);
            }
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[1]_ImageMuteTgl.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_1__ImageMuteTgl_Selected(bool digital)
        {
            BtnProj_1__ImageMuteTgl_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <summary>
        /// Boolean feedback Btn.Proj[1]_PowerOff.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_1__PowerOff_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProj_1__PowerOff_SelectedState], this);
            }
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[1]_PowerOff.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_1__PowerOff_Selected(bool digital)
        {
            BtnProj_1__PowerOff_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <summary>
        /// Boolean feedback Btn.Proj[1]_PowerOn.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_1__PowerOn_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProj_1__PowerOn_SelectedState], this);
            }
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[1]_PowerOn.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_1__PowerOn_Selected(bool digital)
        {
            BtnProj_1__PowerOn_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <summary>
        /// Boolean feedback Btn.Proj[2]_ImageMuteTgl.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_2__ImageMuteTgl_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProj_2__ImageMuteTgl_SelectedState], this);
            }
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[2]_ImageMuteTgl.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_2__ImageMuteTgl_Selected(bool digital)
        {
            BtnProj_2__ImageMuteTgl_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <summary>
        /// Boolean feedback Btn.Proj[2]_PowerOff.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_2__PowerOff_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProj_2__PowerOff_SelectedState], this);
            }
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[2]_PowerOff.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_2__PowerOff_Selected(bool digital)
        {
            BtnProj_2__PowerOff_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <summary>
        /// Boolean feedback Btn.Proj[2]_PowerOn.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_2__PowerOn_Selected(Proj_02_PowerScreen_WidgetBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.BtnProj_2__PowerOn_SelectedState], this);
            }
        }

        /// <summary>
        /// Boolean feedback Btn.Proj[2]_PowerOn.Selected (from Control System to Panel)
        /// </summary>
        public void BtnProj_2__PowerOn_Selected(bool digital)
        {
            BtnProj_2__PowerOn_Selected((sig, component) => sig.BoolValue = digital);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Proj_02_PowerScreen_Widget", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            BtnProj_1__ImageMuteTgl_PressEvent = null;
            BtnProj_1__PowerOff_PressEvent = null;
            BtnProj_1__PowerOn_PressEvent = null;
            BtnProj_2__ImageMuteTgl_PressEvent = null;
            BtnProj_2__PowerOff_PressEvent = null;
            BtnProj_2__PowerOn_PressEvent = null;
            BtnScreen_1__Down_PressEvent = null;
            BtnScreen_2__Down_PressEvent = null;
            BtnScreen_2__Up_PressEvent = null;
            BtnSrceen_1__Up_PressEvent = null;
        }

        #endregion
    }
}