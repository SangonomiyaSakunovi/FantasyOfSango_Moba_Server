using SangoKCPNet;
using SangoMobaNetProtocol;

//Developer: SangonomiyaSakunovi

namespace FantasyOfSango_Moba_Server.Services.NetService
{
    public class ClientPeer : IClientPeer
    {
        protected override void OnConnected()
        {
            this.LogInfo("A new Client is Connected.");
        }

        protected override void OnDisconnected()
        {
            this.LogInfo("Current Client is DisConnected.");
        }

        protected override void OnReceivedMessage(byte[] byteMessages)
        {
            SangoNetMessage sangoNetMessage = ProtobufTool.DeProtoBytes<SangoNetMessage>(byteMessages);
            switch (sangoNetMessage.MessageHead.MessageCommand)
            {
                case MessageCommand.OperationRequest:
                    {
                        NetService.Instance.OnOperationRequestDistribute(sangoNetMessage, this);
                    }
                    break;
            }
        }

        protected override void OnUpdate(DateTimeOffset now)
        {
            
        }

        public void SendOperationResponse(OperationCode operationCode, string messageString)
        {
            MessageHead messageHead = new()
            {
                OperationCode = operationCode,
                MessageCommand = MessageCommand.OperationResponse
            };
            MessageBody messageBody = new()
            {
                MessageString = messageString
            };
            SangoNetMessage sangoNetMessage = new()
            {
                MessageHead = messageHead,
                MessageBody = messageBody
            };
            SendData(sangoNetMessage);
        }

        public void SendOperationResponse(OperationCode operationCode, ReturnCode returnCode)
        {
            MessageHead messageHead = new()
            {
                OperationCode = operationCode,
                MessageCommand = MessageCommand.OperationResponse
            };
            MessageBody messageBody = new()
            {
                ReturnCode = returnCode
            };
            SangoNetMessage sangoNetMessage = new()
            {
                MessageHead = messageHead,
                MessageBody = messageBody
            };
            SendData(sangoNetMessage);
        }

        public void SendEvent(OperationCode operationCode, string messageString)
        {
            MessageHead messageHead = new()
            {
                OperationCode = operationCode,
                MessageCommand = MessageCommand.EventData
            };
            MessageBody messageBody = new()
            {
                MessageString = messageString
            };
            SangoNetMessage sangoNetMessage = new()
            {
                MessageHead = messageHead,
                MessageBody = messageBody
            };
            SendData(sangoNetMessage);
        }

        private void SendData(SangoNetMessage sangoNetMessage)
        {
            byte[] bytes = ProtobufTool.SetProtoBytes(sangoNetMessage);
            SendMessage(bytes);
        }
    }
}
