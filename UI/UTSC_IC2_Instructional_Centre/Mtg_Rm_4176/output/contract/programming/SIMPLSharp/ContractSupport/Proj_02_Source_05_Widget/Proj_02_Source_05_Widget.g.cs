//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3501.16.0
//
//     Project:     Mtg_Rm_4176
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
using Mtg_Rm_4176;

namespace Mtg_Rm_4176.Proj_02_Source_05_Widget
{

    /// <summary>
    /// Proj_02_Source_05_Widget
    /// </summary>
    public partial interface IProj_02_Source_05_Widget 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event Btn.SendToAll.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnSendToAll_PressEvent;

        /// <summary>
        /// Event Btn.SendToProj[1].Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> BtnSendToProj_1__PressEvent;

        /// <summary>
        /// Event btn.SendToProj[2].Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> btnSendToProj_2__PressEvent;

        /// <summary>
        /// Btn.SendToProj[1].Indirect Rich Text Feedback
        /// </summary>
        /// <param name="callback">The <see cref="string"/> delegate to update the panel.</param>
        void BtnSendToProj_1__IndirectRichText(Proj_02_Source_05_WidgetStringInputSigDelegate callback);

        /// <summary>
        /// Btn.SendToProj[1].Indirect Rich Text Feedback
        /// </summary>
        /// <param name="serial">The <see cref="string"/> to update the panel.</param>
        void BtnSendToProj_1__IndirectRichText(string serial);

        /// <summary>
        /// btn.SendToProj[2].Indirect Rich Text Feedback
        /// </summary>
        /// <param name="callback">The <see cref="string"/> delegate to update the panel.</param>
        void btnSendToProj_2__IndirectRichText(Proj_02_Source_05_WidgetStringInputSigDelegate callback);

        /// <summary>
        /// btn.SendToProj[2].Indirect Rich Text Feedback
        /// </summary>
        /// <param name="serial">The <see cref="string"/> to update the panel.</param>
        void btnSendToProj_2__IndirectRichText(string serial);

        /// <summary>
        /// Str.Proj[1]_CurrentSrc.Indirect Feedback
        /// </summary>
        /// <param name="callback">The <see cref="string"/> delegate to update the panel.</param>
        void StrProj_1__CurrentSrc_Indirect(Proj_02_Source_05_WidgetStringInputSigDelegate callback);

        /// <summary>
        /// Str.Proj[1]_CurrentSrc.Indirect Feedback
        /// </summary>
        /// <param name="serial">The <see cref="string"/> to update the panel.</param>
        void StrProj_1__CurrentSrc_Indirect(string serial);

        /// <summary>
        /// Str.Proj[2]_CurrentSrc.Indirect Feedback
        /// </summary>
        /// <param name="callback">The <see cref="string"/> delegate to update the panel.</param>
        void StrProj_2__CurrentSrc_Indirect(Proj_02_Source_05_WidgetStringInputSigDelegate callback);

        /// <summary>
        /// Str.Proj[2]_CurrentSrc.Indirect Feedback
        /// </summary>
        /// <param name="serial">The <see cref="string"/> to update the panel.</param>
        void StrProj_2__CurrentSrc_Indirect(string serial);

        /// <summary>
        /// ComplexComponent BtnList.SrcSelect
        /// </summary>
        Mtg_Rm_4176.Proj_02_Source_05_Widget.IBtnListSrcSelect BtnListSrcSelect { get; }
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="proj_02_source_05_widget">The <see cref="IProj_02_Source_05_Widget"/> on which to apply the feedback.</param>
    public delegate void Proj_02_Source_05_WidgetBoolInputSigDelegate(BoolInputSig boolInputSig, IProj_02_Source_05_Widget proj_02_source_05_widget);
    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="stringInputSig">The <see cref="StringInputSig"/> joinInfo data.</param>
    /// <param name="proj_02_source_05_widget">The <see cref="IProj_02_Source_05_Widget"/> on which to apply the feedback.</param>
    public delegate void Proj_02_Source_05_WidgetStringInputSigDelegate(StringInputSig stringInputSig, IProj_02_Source_05_Widget proj_02_source_05_widget);

    /// <summary>
    /// Proj_02_Source_05_Widget
    /// </summary>
    internal partial class Proj_02_Source_05_Widget : IProj_02_Source_05_Widget, IDisposable
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
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_05_Widget.BtnSendToAll.Press
                /// Btn.SendToAll.Press
                /// </summary>
                public const uint BtnSendToAll_PressEvent = 3;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_05_Widget.BtnSendToProj[1].Press
                /// Btn.SendToProj[1].Press
                /// </summary>
                public const uint BtnSendToProj_1__PressEvent = 4;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: Proj_02_Source_05_Widget.btnSendToProj[2].Press
                /// btn.SendToProj[2].Press
                /// </summary>
                public const uint btnSendToProj_2__PressEvent = 5;


            }
            /// <summary>
            /// Serial signals.
            /// </summary>
            internal static class Strings
            {

                /// <summary>
                /// Input or Feedback serial joinInfo from Control System to panel: Proj_02_Source_05_Widget.BtnSendToProj[1].IndirectRichText
                /// Btn.SendToProj[1].Indirect Rich Text
                /// </summary>
                public const uint BtnSendToProj_1__IndirectRichTextState = 1;
                /// <summary>
                /// Input or Feedback serial joinInfo from Control System to panel: Proj_02_Source_05_Widget.btnSendToProj[2].IndirectRichText
                /// btn.SendToProj[2].Indirect Rich Text
                /// </summary>
                public const uint btnSendToProj_2__IndirectRichTextState = 2;
                /// <summary>
                /// Input or Feedback serial joinInfo from Control System to panel: Proj_02_Source_05_Widget.StrProj[1]_CurrentSrc.Indirect
                /// Str.Proj[1]_CurrentSrc.Indirect
                /// </summary>
                public const uint StrProj_1__CurrentSrc_IndirectState = 3;
                /// <summary>
                /// Input or Feedback serial joinInfo from Control System to panel: Proj_02_Source_05_Widget.StrProj[2]_CurrentSrc.Indirect
                /// Str.Proj[2]_CurrentSrc.Indirect
                /// </summary>
                public const uint StrProj_2__CurrentSrc_IndirectState = 4;
            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="Proj_02_Source_05_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal Proj_02_Source_05_Widget(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proj_02_Source_05_Widget"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal Proj_02_Source_05_Widget(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="Proj_02_Source_05_Widget"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnSendToAll_PressEvent, onBtnSendToAll_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.BtnSendToProj_1__PressEvent, onBtnSendToProj_1__Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.btnSendToProj_2__PressEvent, onbtnSendToProj_2__Press);
            BtnListSrcSelect = new Mtg_Rm_4176.Proj_02_Source_05_Widget.BtnListSrcSelect(ComponentMediator, 14);
        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((Mtg_Rm_4176.Proj_02_Source_05_Widget.BtnListSrcSelect)BtnListSrcSelect).AddDevice(device);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((Mtg_Rm_4176.Proj_02_Source_05_Widget.BtnListSrcSelect)BtnListSrcSelect).RemoveDevice(device);
        }

        #endregion

        #region CH5 Contract

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> BtnSendToAll_PressEvent;
        private void onBtnSendToAll_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnSendToAll_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> BtnSendToProj_1__PressEvent;
        private void onBtnSendToProj_1__Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = BtnSendToProj_1__PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> btnSendToProj_2__PressEvent;
        private void onbtnSendToProj_2__Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = btnSendToProj_2__PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }



        /// <inheritdoc/>
        public void BtnSendToProj_1__IndirectRichText(Proj_02_Source_05_WidgetStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.BtnSendToProj_1__IndirectRichTextState], this);
            }
        }

        /// <inheritdoc/>
        public void BtnSendToProj_1__IndirectRichText(string serial)
        {
            BtnSendToProj_1__IndirectRichText((sig, component) => sig.StringValue = serial);
        }
        /// <inheritdoc/>
        public void btnSendToProj_2__IndirectRichText(Proj_02_Source_05_WidgetStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.btnSendToProj_2__IndirectRichTextState], this);
            }
        }

        /// <inheritdoc/>
        public void btnSendToProj_2__IndirectRichText(string serial)
        {
            btnSendToProj_2__IndirectRichText((sig, component) => sig.StringValue = serial);
        }
        /// <inheritdoc/>
        public void StrProj_1__CurrentSrc_Indirect(Proj_02_Source_05_WidgetStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.StrProj_1__CurrentSrc_IndirectState], this);
            }
        }

        /// <inheritdoc/>
        public void StrProj_1__CurrentSrc_Indirect(string serial)
        {
            StrProj_1__CurrentSrc_Indirect((sig, component) => sig.StringValue = serial);
        }
        /// <inheritdoc/>
        public void StrProj_2__CurrentSrc_Indirect(Proj_02_Source_05_WidgetStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.StrProj_2__CurrentSrc_IndirectState], this);
            }
        }

        /// <inheritdoc/>
        public void StrProj_2__CurrentSrc_Indirect(string serial)
        {
            StrProj_2__CurrentSrc_Indirect((sig, component) => sig.StringValue = serial);
        }

        /// <summary>
        /// ComplexComponent BtnList.SrcSelect
        /// </summary>
        public Mtg_Rm_4176.Proj_02_Source_05_Widget.IBtnListSrcSelect BtnListSrcSelect { get; private set; }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Proj_02_Source_05_Widget", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            BtnSendToAll_PressEvent = null;
            BtnSendToProj_1__PressEvent = null;
            btnSendToProj_2__PressEvent = null;
        }

        #endregion
    }
}