          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  typedef string string32<32>;

//  ===========================================================================
public class String32 {
  public string InnerValue { get; set; } = default(string);
        
  public String32() { }
  public String32(string String32)
  {
    InnerValue = String32;
  }
  public static void Encode(IByteWriter stream, String32  encodedString32) {
  XdrEncoding.WriteString(stream, encodedString32.InnerValue);
  }
  public static String32 Decode(IByteReader stream) {
    String32 decodedString32 = new String32();
  decodedString32.InnerValue = XdrEncoding.ReadString(stream);
    return decodedString32;
  }
}
}
