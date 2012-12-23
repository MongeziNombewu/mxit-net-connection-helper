﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MXitConnectionModule.ExternalAppAPI {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
    [System.SerializableAttribute()]
    public partial class CommsError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServerEventType", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
    public enum ServerEventType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServerIsShuttingDown = 0,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mxit.com/wcf.ExternalAppComms", ConfigurationName="ExternalAppAPI.Comms", CallbackContract=typeof(MXitConnectionModule.ExternalAppAPI.CommsCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface Comms {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/Version", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/VersionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/VersionCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        System.Version Version();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RecommendedSdkVersion", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/RecommendedSdkVersionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RecommendedSdkVersionCommsErrorFau" +
            "lt", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        System.Version RecommendedSdkVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/Connect", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/ConnectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/ConnectCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        void Connect(string externalAppName, string externalAppPassword, MXit.SDK externalAppSdk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/Disconnect", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/DisconnectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/DisconnectCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/IsOnline", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/IsOnlineResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/IsOnlineCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        bool IsOnline();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/KeepAlive", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/KeepAliveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/KeepAliveCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        void KeepAlive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/GetUser", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/GetUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/GetUserCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        MXit.User.UserInfo GetUser(string UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestUserInfo", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestUserInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestUserInfoCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Version))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXitConnectionModule.ExternalAppAPI.ServerEventType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.SDK))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.DeviceInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.ClientType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.GenderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.Presence))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.UserInfoResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.OAuth2.TokenRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.OAuth2.TokenResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.OAuth2.AuthorizationResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageToSend))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.Message))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageReceived))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.FileReceived))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageElements.ImageStripReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageElements.MessageElement))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Navigation.RedirectRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Billing.PaymentRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Billing.PaymentResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Billing.TransactionResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Async.AsyncOperationInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Async.AsyncOperationResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Log.Level))]
        void RequestUserInfo(MXit.User.UserInfoRequest userInfoRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestOAuthToken", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestOAuthTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestOAuthTokenCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Version))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXitConnectionModule.ExternalAppAPI.ServerEventType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.SDK))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.DeviceInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.ClientType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.GenderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.UserInfoRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.Presence))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.User.UserInfoResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.OAuth2.TokenResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.OAuth2.AuthorizationResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageToSend))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.Message))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageReceived))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.FileReceived))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageElements.ImageStripReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Messaging.MessageElements.MessageElement))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Navigation.RedirectRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Billing.PaymentRequest))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Billing.PaymentResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Billing.TransactionResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Async.AsyncOperationInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Async.AsyncOperationResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MXit.Log.Level))]
        void RequestOAuthToken(MXit.OAuth2.TokenRequest oAuthTokenRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/SendMessage", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/SendMessageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/SendMessageCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        void SendMessage(MXit.Messaging.MessageToSend message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RegisterImageStrip", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/RegisterImageStripResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RegisterImageStripCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        MXit.Messaging.MessageElements.ImageStripReference RegisterImageStrip(string name, System.Drawing.Bitmap image, int frameWidth, int frameHeight, int layer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RedirectUser", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/RedirectUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RedirectUserCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        void RedirectUser(MXit.Navigation.RedirectRequest redirectRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestPayment", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestPaymentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/RequestPaymentCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        void RequestPayment(MXit.Billing.PaymentRequest paymentRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/ConfirmPayment", ReplyAction="http://www.mxit.com/wcf.ExternalAppComms/Comms/ConfirmPaymentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MXitConnectionModule.ExternalAppAPI.CommsError), Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/ConfirmPaymentCommsErrorFault", Name="CommsError", Namespace="http://schemas.datacontract.org/2004/07/MXit.ExternalAppAPI")]
        System.Nullable<long> ConfirmPayment(System.Nullable<int> vendorId, string transactionReference);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CommsCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnMessageReceived")]
        void OnMessageReceived(MXit.Messaging.MessageReceived messageReceived);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnFileReceived")]
        void OnFileReceived(MXit.Messaging.FileReceived fileReceived);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnPresenceReceived")]
        void OnPresenceReceived(MXit.User.Presence userPresence);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnPaymentResponseReceived")]
        void OnPaymentResponseReceived(MXit.Billing.PaymentResponse paymentResponse);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnUserInfoResponseReceived")]
        void OnUserInfoResponseReceived(MXit.User.UserInfoResponse userInfoResponse);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnOAuthTokenResponseReceived")]
        void OnOAuthTokenResponseReceived(MXit.OAuth2.TokenResponse oAuthTokenResponse);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnNotificationReceived")]
        void OnNotificationReceived(string message, MXit.Log.Level level);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mxit.com/wcf.ExternalAppComms/Comms/OnServerEvent")]
        void OnServerEvent(MXitConnectionModule.ExternalAppAPI.ServerEventType serverEventType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CommsChannel : MXitConnectionModule.ExternalAppAPI.Comms, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommsClient : System.ServiceModel.DuplexClientBase<MXitConnectionModule.ExternalAppAPI.Comms>, MXitConnectionModule.ExternalAppAPI.Comms {
        
        public CommsClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CommsClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CommsClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CommsClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CommsClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public System.Version Version() {
            return base.Channel.Version();
        }
        
        public System.Version RecommendedSdkVersion() {
            return base.Channel.RecommendedSdkVersion();
        }
        
        public void Connect(string externalAppName, string externalAppPassword, MXit.SDK externalAppSdk) {
            base.Channel.Connect(externalAppName, externalAppPassword, externalAppSdk);
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        public bool IsOnline() {
            return base.Channel.IsOnline();
        }
        
        public void KeepAlive() {
            base.Channel.KeepAlive();
        }
        
        public MXit.User.UserInfo GetUser(string UserId) {
            return base.Channel.GetUser(UserId);
        }
        
        public void RequestUserInfo(MXit.User.UserInfoRequest userInfoRequest) {
            base.Channel.RequestUserInfo(userInfoRequest);
        }
        
        public void RequestOAuthToken(MXit.OAuth2.TokenRequest oAuthTokenRequest) {
            base.Channel.RequestOAuthToken(oAuthTokenRequest);
        }
        
        public void SendMessage(MXit.Messaging.MessageToSend message) {
            base.Channel.SendMessage(message);
        }
        
        public MXit.Messaging.MessageElements.ImageStripReference RegisterImageStrip(string name, System.Drawing.Bitmap image, int frameWidth, int frameHeight, int layer) {
            return base.Channel.RegisterImageStrip(name, image, frameWidth, frameHeight, layer);
        }
        
        public void RedirectUser(MXit.Navigation.RedirectRequest redirectRequest) {
            base.Channel.RedirectUser(redirectRequest);
        }
        
        public void RequestPayment(MXit.Billing.PaymentRequest paymentRequest) {
            base.Channel.RequestPayment(paymentRequest);
        }
        
        public System.Nullable<long> ConfirmPayment(System.Nullable<int> vendorId, string transactionReference) {
            return base.Channel.ConfirmPayment(vendorId, transactionReference);
        }
    }
}
