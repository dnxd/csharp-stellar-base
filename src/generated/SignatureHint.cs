          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  typedef opaque SignatureHint[4];

//  ===========================================================================
public class SignatureHint {
  public byte[] InnerValue { get; set; } = default(byte[]);
        
  public SignatureHint() { }
  public SignatureHint(byte[] SignatureHint)
  {
    InnerValue = SignatureHint;
  }
  public static void Encode(IByteWriter stream, SignatureHint  encodedSignatureHint) {
  int SignatureHintSize = encodedSignatureHint.InnerValue.Length;
  XdrEncoding.WriteFixOpaque(stream, (uint)SignatureHintSize, encodedSignatureHint.InnerValue);
  }
  public static SignatureHint Decode(IByteReader stream) {
    SignatureHint decodedSignatureHint = new SignatureHint();
  int SignatureHintsize = 4;
  decodedSignatureHint.InnerValue = XdrEncoding.ReadFixOpaque(stream, (uint)SignatureHintsize);
    return decodedSignatureHint;
  }
}
}
