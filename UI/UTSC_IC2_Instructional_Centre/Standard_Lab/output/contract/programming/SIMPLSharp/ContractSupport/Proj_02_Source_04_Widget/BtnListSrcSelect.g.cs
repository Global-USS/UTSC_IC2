//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3501.13.0
//
//     Project:     Standard_Lab
//     Version:     1.0.0.0
//     Sdk:         CH5:2.10.0
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
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;
using Standard_Lab;

namespace Standard_Lab.Proj_02_Source_04_Widget
{

    /// <summary>
    /// Allow events by list item and states (feedbacks) to be set by item index.
    /// </summary>
    public partial interface IBtnListSrcSelectByItem
    {
        /// <summary>
        /// Fires on button list presses.  Event carries <see="IndexedButtonEventArgs"/> with ButtonIndex property (0 based).
        /// </summary>
        event EventHandler<IndexedButtonEventArgs> Button_PressEvent;

        /// <summary>
        /// Button1.ItemSelected Feedback
        /// </summary>
        /// <param name="buttonIndex">The index of the button (0 based).</param>
        /// <param name="callback">The delegate to set the feedback.</param>
        void Button_Selected(ushort buttonIndex, BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Helper Button1.ItemSelected Feedback
        /// </summary>
        /// <param name="buttonIndex">The index of the button (0 based).</param>
        /// <param name="digital">The <see="bool"/> value to set on the panel.</param>
        void Button_Selected(ushort buttonIndex, bool digital);

        /// <summary>
        /// Button1.Visible Feedback
        /// </summary>
        /// <param name="buttonIndex">The index of the button (0 based).</param>
        /// <param name="callback">The delegate to set the feedback.</param>
        void Button_Visible(ushort buttonIndex, BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Helper Button1.Visible Feedback
        /// </summary>
        /// <param name="buttonIndex">The index of the button (0 based).</param>
        /// <param name="digital">The <see="bool"/> value to set on the panel.</param>
        void Button_Visible(ushort buttonIndex, bool digital);
    }


    /// <summary>
    /// Search List
    /// </summary>
    internal partial class BtnListSrcSelect
    {
        #region CH5 Contract
        /// <inheritdoc/>
        public event EventHandler<IndexedButtonEventArgs> Button_PressEvent;
        private void onButton_Press(IndexedEventArgs eventArgs)
        {
            EventHandler<IndexedButtonEventArgs> handler = Button_PressEvent;
            if (handler != null)
                handler(this, new IndexedButtonEventArgs((SmartObjectEventArgs)eventArgs.SigArgs, eventArgs.JoinIndex));
        }
                
        /// <inheritdoc/>
        public void Button_Selected(ushort buttonIndex, BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_1_Button_SelectedState + (uint) buttonIndex], this);
            }
        }

        /// <inheritdoc/>
        public void Button_Selected(ushort buttonIndex, bool digital)
        {
            Button_Selected(buttonIndex, (sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_Visible(ushort buttonIndex, BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_1_Button_VisibleState + (uint) buttonIndex], this);
            }
        }

        /// <inheritdoc/>
        public void Button_Visible(ushort buttonIndex, bool digital)
        {
            Button_Visible(buttonIndex, (sig, component) => sig.BoolValue = digital);
        }

        #endregion
    }

    /// <summary>
    /// BtnList.SrcSelect
    /// </summary>
    public partial interface IBtnListSrcSelect : IBtnListSrcSelectByItem
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event Button1.ItemPress (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Button_1_Button_PressEvent;

        /// <summary>
        /// Event Button2.ItemPress (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Button_2_Button_PressEvent;

        /// <summary>
        /// Event Button3.ItemPress (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Button_3_Button_PressEvent;

        /// <summary>
        /// Event Button4.ItemPress (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Button_4_Button_PressEvent;

        /// <summary>
        /// Button1.ItemSelected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_1_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button1.ItemSelected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_1_Button_Selected(bool digital);

        /// <summary>
        /// Button2.ItemSelected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_2_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button2.ItemSelected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_2_Button_Selected(bool digital);

        /// <summary>
        /// Button3.ItemSelected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_3_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button3.ItemSelected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_3_Button_Selected(bool digital);

        /// <summary>
        /// Button4.ItemSelected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_4_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button4.ItemSelected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_4_Button_Selected(bool digital);

        /// <summary>
        /// Button1.Visible Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_1_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button1.Visible Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_1_Button_Visible(bool digital);

        /// <summary>
        /// Button2.Visible Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_2_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button2.Visible Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_2_Button_Visible(bool digital);

        /// <summary>
        /// Button3.Visible Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_3_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button3.Visible Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_3_Button_Visible(bool digital);

        /// <summary>
        /// Button4.Visible Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void Button_4_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback);

        /// <summary>
        /// Button4.Visible Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void Button_4_Button_Visible(bool digital);
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="btnlistsrcselect">The <see cref="IBtnListSrcSelect"/> on which to apply the feedback.</param>
    public delegate void BtnListSrcSelectBoolInputSigDelegate(BoolInputSig boolInputSig, IBtnListSrcSelect btnlistsrcselect);

    /// <summary>
    /// BtnList.SrcSelect
    /// </summary>
    internal partial class BtnListSrcSelect : IBtnListSrcSelect, IDisposable
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
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_04_Widget.BtnListSrcSelect.Button1ItemPress
                /// Button1.ItemPress
                /// </summary>
                public const uint Button_1_Button_PressEvent = 1001;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_04_Widget.BtnListSrcSelect.Button2ItemPress
                /// Button2.ItemPress
                /// </summary>
                public const uint Button_2_Button_PressEvent = 1002;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_04_Widget.BtnListSrcSelect.Button3ItemPress
                /// Button3.ItemPress
                /// </summary>
                public const uint Button_3_Button_PressEvent = 1003;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_04_Widget.BtnListSrcSelect.Button4ItemPress
                /// Button4.ItemPress
                /// </summary>
                public const uint Button_4_Button_PressEvent = 1004;


                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button1ItemSelected
                /// Button1.ItemSelected
                /// </summary>
                public const uint Button_1_Button_SelectedState = 1001;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button2ItemSelected
                /// Button2.ItemSelected
                /// </summary>
                public const uint Button_2_Button_SelectedState = 1002;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button3ItemSelected
                /// Button3.ItemSelected
                /// </summary>
                public const uint Button_3_Button_SelectedState = 1003;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button4ItemSelected
                /// Button4.ItemSelected
                /// </summary>
                public const uint Button_4_Button_SelectedState = 1004;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button1Visible
                /// Button1.Visible
                /// </summary>
                public const uint Button_1_Button_VisibleState = 1501;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button2Visible
                /// Button2.Visible
                /// </summary>
                public const uint Button_2_Button_VisibleState = 1502;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button3Visible
                /// Button3.Visible
                /// </summary>
                public const uint Button_3_Button_VisibleState = 1503;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: Proj_02_Source_04_Widget.BtnListSrcSelect.Button4Visible
                /// Button4.Visible
                /// </summary>
                public const uint Button_4_Button_VisibleState = 1504;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="BtnListSrcSelect"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal BtnListSrcSelect(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BtnListSrcSelect"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal BtnListSrcSelect(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="BtnListSrcSelect"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Button_1_Button_PressEvent, onButton_1_Button_Press);
            ComponentMediator.ConfigureBooleanItemEvent(controlJoinId, Joins.Booleans.Button_1_Button_PressEvent, GetIndexes, onButton_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Button_2_Button_PressEvent, onButton_2_Button_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Button_3_Button_PressEvent, onButton_3_Button_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Button_4_Button_PressEvent, onButton_4_Button_Press);
        }

        /// <summary>
        /// Get the offset when using indexed complex components.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId of the component.</param>
        /// <param name="join">The join offset.</param>
        /// <param name="eSigType">The join data type.</param>
        private Indexes GetIndexes(uint controlJoinId, uint join, eSigType eSigType)
        {
            if (controlJoinId == ControlJoinId &&
                join >= Joins.Booleans.Button_1_Button_PressEvent &&
                join <= 1004)
            {
                return new Indexes(0, (ushort)(join - Joins.Booleans.Button_1_Button_PressEvent), false);
            }

            return new Indexes(0, 0, true);
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
        public event EventHandler<UIEventArgs> Button_1_Button_PressEvent;
        private void onButton_1_Button_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Button_1_Button_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Button_2_Button_PressEvent;
        private void onButton_2_Button_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Button_2_Button_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Button_3_Button_PressEvent;
        private void onButton_3_Button_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Button_3_Button_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Button_4_Button_PressEvent;
        private void onButton_4_Button_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Button_4_Button_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public void Button_1_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_1_Button_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_1_Button_Selected(bool digital)
        {
            Button_1_Button_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_1_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_1_Button_VisibleState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_1_Button_Visible(bool digital)
        {
            Button_1_Button_Visible((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_2_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_2_Button_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_2_Button_Selected(bool digital)
        {
            Button_2_Button_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_2_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_2_Button_VisibleState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_2_Button_Visible(bool digital)
        {
            Button_2_Button_Visible((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_3_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_3_Button_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_3_Button_Selected(bool digital)
        {
            Button_3_Button_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_3_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_3_Button_VisibleState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_3_Button_Visible(bool digital)
        {
            Button_3_Button_Visible((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_4_Button_Selected(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_4_Button_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_4_Button_Selected(bool digital)
        {
            Button_4_Button_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void Button_4_Button_Visible(BtnListSrcSelectBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Button_4_Button_VisibleState], this);
            }
        }

        /// <inheritdoc/>
        public void Button_4_Button_Visible(bool digital)
        {
            Button_4_Button_Visible((sig, component) => sig.BoolValue = digital);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "BtnListSrcSelect", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Button_1_Button_PressEvent = null;
            Button_PressEvent = null;
            Button_2_Button_PressEvent = null;
            Button_3_Button_PressEvent = null;
            Button_4_Button_PressEvent = null;
        }

        #endregion
    }
}