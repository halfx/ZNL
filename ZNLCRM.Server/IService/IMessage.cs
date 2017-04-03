using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace ZNLCRM.Server.IService
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IMessageCallback))]
    interface IMessage
    {
        [OperationContract(IsOneWay = false, IsInitiating = true, IsTerminating = false)]
        string[] Join(string name);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void Say(string msg);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void Whisper(string to, string msg);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
        void Leave();
    }

    interface IMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void Receive(string senderName, string message);

        [OperationContract(IsOneWay = true)]
        void ReceiveWhisper(string senderName, string message);

        [OperationContract(IsOneWay = true)]
        void UserEnter(string name);

        [OperationContract(IsOneWay = true)]
        void UserLeave(string name);
    }

    //枚举客户端动作
    public enum MessageType { Receive, UserEnter, UserLeave, ReceiveWhisper };

    //自定义参数类
    public class MessageEventArgs : EventArgs
    {
        public MessageType msgType;
        public string name;
        public string message;
    }
}