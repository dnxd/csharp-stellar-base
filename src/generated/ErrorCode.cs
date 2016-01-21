          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Quasar.Generated
{


// === xdr source ============================================================

//  enum ErrorCode
//  {
//      ERR_MISC = 0, // Unspecific error
//      ERR_DATA = 1, // Malformed data
//      ERR_CONF = 2, // Misconfiguration error
//      ERR_AUTH = 3, // Authentication failure
//      ERR_LOAD = 4  // System overloaded
//  };

//  ===========================================================================
public class ErrorCode {
  public enum ErrorCodeEnum
  {
  ERR_MISC = 0,
  ERR_DATA = 1,
  ERR_CONF = 2,
  ERR_AUTH = 3,
  ERR_LOAD = 4,
  }

  public ErrorCodeEnum InnerValue { get; set; } = default(ErrorCodeEnum);

  public static ErrorCode Create(ErrorCodeEnum v)
  {
    return new ErrorCode {
      InnerValue = v
    };
  }

  public static ErrorCode Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(ErrorCodeEnum.ERR_MISC);
      case 1: return Create(ErrorCodeEnum.ERR_DATA);
      case 2: return Create(ErrorCodeEnum.ERR_CONF);
      case 3: return Create(ErrorCodeEnum.ERR_AUTH);
      case 4: return Create(ErrorCodeEnum.ERR_LOAD);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, ErrorCode value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
