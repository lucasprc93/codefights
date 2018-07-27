bool checkPalindrome(string inputString) {

//one hit K.O, just compare the sequence with reversed string sequence

return inputString.SequenceEqual(inputString.Reverse());
}
