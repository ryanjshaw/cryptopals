using Shared;

var expected = "746865206b696420646f6e277420706c6179".ToUpper();

var value = Convert.FromHexString("1c0111001f010100061a024b53535009181c");
var key = Convert.FromHexString("686974207468652062756c6c277320657965");
for (var i = 0; i < key.Length; i++)
    value[i] ^= key[i];

var actual = Convert.ToHexString(value);
Challenge.Outcome("Set 1 Challenge 2", actual == expected);