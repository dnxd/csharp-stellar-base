          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  enum LedgerEntryType
//  {
//      ACCOUNT = 0,
//      TRUSTLINE = 1,
//      OFFER = 2
//  };

//  ===========================================================================
public class LedgerEntryType {
  public enum LedgerEntryTypeEnum
  {
  ACCOUNT = 0,
  TRUSTLINE = 1,
  OFFER = 2,
  }

  public LedgerEntryTypeEnum InnerValue { get; set; } = default(LedgerEntryTypeEnum);

  public static LedgerEntryType Create(LedgerEntryTypeEnum v)
  {
    return new LedgerEntryType {
      InnerValue = v
    };
  }

  public static LedgerEntryType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(LedgerEntryTypeEnum.ACCOUNT);
      case 1: return Create(LedgerEntryTypeEnum.TRUSTLINE);
      case 2: return Create(LedgerEntryTypeEnum.OFFER);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, LedgerEntryType value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
