          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  struct OfferEntry
//  {
//      AccountID sellerID;
//      uint64 offerID;
//      Asset selling; // A
//      Asset buying;  // B
//      int64 amount;  // amount of A
//  
//      /* price for this offer:
//          price of A in terms of B
//          price=AmountB/AmountA=priceNumerator/priceDenominator
//          price is after fees
//      */
//      Price price;
//      uint32 flags; // see OfferEntryFlags
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
public class OfferEntry {
  public OfferEntry () {}
  public AccountID SellerID { get; set; }
  public Uint64 OfferID { get; set; }
  public Asset Selling { get; set; }
  public Asset Buying { get; set; }
  public Int64 Amount { get; set; }
  public Price Price { get; set; }
  public Uint32 Flags { get; set; }
  public OfferEntryExt Ext { get; set; }
  public static void Encode(IByteWriter stream, OfferEntry encodedOfferEntry) {
    AccountID.Encode(stream, encodedOfferEntry.SellerID);
    Uint64.Encode(stream, encodedOfferEntry.OfferID);
    Asset.Encode(stream, encodedOfferEntry.Selling);
    Asset.Encode(stream, encodedOfferEntry.Buying);
    Int64.Encode(stream, encodedOfferEntry.Amount);
    Price.Encode(stream, encodedOfferEntry.Price);
    Uint32.Encode(stream, encodedOfferEntry.Flags);
    OfferEntryExt.Encode(stream, encodedOfferEntry.Ext);
  }
  public static OfferEntry Decode(IByteReader stream) {
    OfferEntry decodedOfferEntry = new OfferEntry();
    decodedOfferEntry.SellerID = AccountID.Decode(stream);
    decodedOfferEntry.OfferID = Uint64.Decode(stream);
    decodedOfferEntry.Selling = Asset.Decode(stream);
    decodedOfferEntry.Buying = Asset.Decode(stream);
    decodedOfferEntry.Amount = Int64.Decode(stream);
    decodedOfferEntry.Price = Price.Decode(stream);
    decodedOfferEntry.Flags = Uint32.Decode(stream);
    decodedOfferEntry.Ext = OfferEntryExt.Decode(stream);
    return decodedOfferEntry;
  }

  public class OfferEntryExt {
    public OfferEntryExt () {}
    public int Discriminant { get; set; } = new int();
    public static void Encode(IByteWriter stream, OfferEntryExt encodedOfferEntryExt) {
    XdrEncoding.EncodeInt32(encodedOfferEntryExt.Discriminant, stream);
    switch (encodedOfferEntryExt.Discriminant) {
    case 0:
    break;
    }
    }
    public static OfferEntryExt Decode(IByteReader stream) {
      OfferEntryExt decodedOfferEntryExt = new OfferEntryExt();
    decodedOfferEntryExt.Discriminant = XdrEncoding.DecodeInt32(stream);
    switch (decodedOfferEntryExt.Discriminant) {
    case 0:
    break;
    }
      return decodedOfferEntryExt;
    }

  }
}
}
