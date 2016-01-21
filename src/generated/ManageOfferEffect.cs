          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  enum ManageOfferEffect
//  {
//      MANAGE_OFFER_CREATED = 0,
//      MANAGE_OFFER_UPDATED = 1,
//      MANAGE_OFFER_DELETED = 2
//  };

//  ===========================================================================
public class ManageOfferEffect {
  public enum ManageOfferEffectEnum
  {
  MANAGE_OFFER_CREATED = 0,
  MANAGE_OFFER_UPDATED = 1,
  MANAGE_OFFER_DELETED = 2,
  }

  public ManageOfferEffectEnum InnerValue { get; set; } = default(ManageOfferEffectEnum);

  public static ManageOfferEffect Create(ManageOfferEffectEnum v)
  {
    return new ManageOfferEffect {
      InnerValue = v
    };
  }

  public static ManageOfferEffect Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(ManageOfferEffectEnum.MANAGE_OFFER_CREATED);
      case 1: return Create(ManageOfferEffectEnum.MANAGE_OFFER_UPDATED);
      case 2: return Create(ManageOfferEffectEnum.MANAGE_OFFER_DELETED);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, ManageOfferEffect value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
