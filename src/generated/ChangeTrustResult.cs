          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  union ChangeTrustResult switch (ChangeTrustResultCode code)
//  {
//  case CHANGE_TRUST_SUCCESS:
//      void;
//  default:
//      void;
//  };

//  ===========================================================================
public class ChangeTrustResult {
  public ChangeTrustResult () {}
  public ChangeTrustResultCode Discriminant { get; set; } = new ChangeTrustResultCode();
  public static void Encode(IByteWriter stream, ChangeTrustResult encodedChangeTrustResult) {
  XdrEncoding.EncodeInt32((int)encodedChangeTrustResult.Discriminant.InnerValue, stream);
  switch (encodedChangeTrustResult.Discriminant.InnerValue) {
  case ChangeTrustResultCode.ChangeTrustResultCodeEnum.CHANGE_TRUST_SUCCESS:
  break;
  default:
  break;
  }
  }
  public static ChangeTrustResult Decode(IByteReader stream) {
    ChangeTrustResult decodedChangeTrustResult = new ChangeTrustResult();
  decodedChangeTrustResult.Discriminant = ChangeTrustResultCode.Decode(stream);
  switch (decodedChangeTrustResult.Discriminant.InnerValue) {
  case ChangeTrustResultCode.ChangeTrustResultCodeEnum.CHANGE_TRUST_SUCCESS:
  break;
  default:
  break;
  }
    return decodedChangeTrustResult;
  }
}
}
