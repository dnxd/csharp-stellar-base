          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  enum MessageType
//  {
//      ERROR_MSG = 0,
//      AUTH = 2,
//      DONT_HAVE = 3,
//  
//      GET_PEERS = 4, // gets a list of peers this guy knows about
//      PEERS = 5,
//  
//      GET_TX_SET = 6, // gets a particular txset by hash
//      TX_SET = 7,
//  
//      TRANSACTION = 8, // pass on a tx you have heard about
//  
//      // SCP
//      GET_SCP_QUORUMSET = 9,
//      SCP_QUORUMSET = 10,
//      SCP_MESSAGE = 11,
//      GET_SCP_STATE = 12,
//  
//      // new messages
//      HELLO = 13
//  };

//  ===========================================================================
public class MessageType {
  public enum MessageTypeEnum
  {
  ERROR_MSG = 0,
  AUTH = 2,
  DONT_HAVE = 3,
  GET_PEERS = 4,
  PEERS = 5,
  GET_TX_SET = 6,
  TX_SET = 7,
  TRANSACTION = 8,
  GET_SCP_QUORUMSET = 9,
  SCP_QUORUMSET = 10,
  SCP_MESSAGE = 11,
  GET_SCP_STATE = 12,
  HELLO = 13,
  }

  public MessageTypeEnum InnerValue { get; set; } = default(MessageTypeEnum);

  public static MessageType Create(MessageTypeEnum v)
  {
    return new MessageType {
      InnerValue = v
    };
  }

  public static MessageType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(MessageTypeEnum.ERROR_MSG);
      case 2: return Create(MessageTypeEnum.AUTH);
      case 3: return Create(MessageTypeEnum.DONT_HAVE);
      case 4: return Create(MessageTypeEnum.GET_PEERS);
      case 5: return Create(MessageTypeEnum.PEERS);
      case 6: return Create(MessageTypeEnum.GET_TX_SET);
      case 7: return Create(MessageTypeEnum.TX_SET);
      case 8: return Create(MessageTypeEnum.TRANSACTION);
      case 9: return Create(MessageTypeEnum.GET_SCP_QUORUMSET);
      case 10: return Create(MessageTypeEnum.SCP_QUORUMSET);
      case 11: return Create(MessageTypeEnum.SCP_MESSAGE);
      case 12: return Create(MessageTypeEnum.GET_SCP_STATE);
      case 13: return Create(MessageTypeEnum.HELLO);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, MessageType value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
