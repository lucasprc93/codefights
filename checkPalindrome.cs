bool checkPalindrome(string inputString) {
    // put the string into an array
    char[] arg = inputString.ToCharArray();
    
    //reverses array
    Array.Reverse(arg);
   
    /*
    * check palindrome and returns example 1
    *if(inputString == new String (arg) ){
    *    return true;
    *}else{
    *    return false;
    *}
    
    *check palindrome and returns example 2
    *if(inputString.Equals(new String(arg))){
    *    return true;
    *}else{
    *    return false;
    *}
    */
    
    //also you can check and return in one line because the equals method returns a boolean
     return new String(arg).Equals(inputString);
     

}
