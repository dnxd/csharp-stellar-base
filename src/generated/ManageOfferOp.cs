          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  struct ManageOfferOp
//  {
//      Asset selling;
//      Asset buying;
//      int64 amount; // amount being sold. if set to 0, delete the offer
//      Price price;  // price of thing being sold in terms of what you are buying
//  
//      // 0=create a new offer, otherwise edit an existing offer
//      uint64 offerID;
//  };

//  ===========================================================================
public class ManageOfferOp {
  public ManageOfferOp () {}
  public Asset Selling { get; set; }
  public Asset Buying { get; set; }
  public Int64 Amount { get; set; }
  public Price Price { get; set; }
  public Uint64 OfferID { get; set; }
  public static void Encode(IByteWriter stream, ManageOfferOp encodedManageOfferOp) {
    Asset.Encode(stream, encodedManageOfferOp.Selling);
    Asset.Encode(stream, encodedManageOfferOp.Buying);
    Int64.Encode(stream, encodedManageOfferOp.Amount);
    Price.Encode(stream, encodedManageOfferOp.Price);
    Uint64.Encode(stream, encodedManageOfferOp.OfferID);
  }
  public static ManageOfferOp Decode(IByteReader stream) {
    ManageOfferOp decodedManageOfferOp = new ManageOfferOp();
    decodedManageOfferOp.Selling = Asset.Decode(stream);
    decodedManageOfferOp.Buying = Asset.Decode(stream);
    decodedManageOfferOp.Amount = Int64.Decode(stream);
    decodedManageOfferOp.Price = Price.Decode(stream);
    decodedManageOfferOp.OfferID = Uint64.Decode(stream);
    return decodedManageOfferOp;
  }
}
}
