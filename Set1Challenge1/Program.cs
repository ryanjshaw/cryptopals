using Shared;

var hexString = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
var expected = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

var bytes = Convert.FromHexString(hexString);
var actual = Convert.ToBase64String(bytes);

Challenge.Outcome("Set 1 Challenge 1", actual == expected);