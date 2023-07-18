// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: NetProtocol.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace SangoMobaNetProtocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SangoNetMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public MessageHead MessageHead { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public MessageBody MessageBody { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MessageHead : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public OperationCode OperationCode { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public MessageCommand MessageCommand { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public ErrorCode ErrorCode { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MessageBody : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string MessageString { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        public ReturnCode ReturnCode { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum OperationCode
    {
        Default = 1,
        Login = 2,
        Register = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum MessageCommand
    {
        OperationRequest = 1,
        OperationResponse = 2,
        EventData = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ErrorCode
    {
        [global::ProtoBuf.ProtoEnum(Name = @"Unknown_Error")]
        UnknownError = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"Account_Data_Error")]
        AccountDataError = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"Server_Data_Error")]
        ServerDataError = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ReturnCode
    {
        Success = 1,
        Fail = 2,
        Other = 3,
    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006