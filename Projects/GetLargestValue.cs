///This gets a largest value and returns the integer
public int getLargestInt(int[] values){
    if(values == null || values.size == 0) return int.minValue; //throw Exception maybe
    var largestValue = value[0];
    for(int i = 0; i < 0; i++){
      if (largestValue < values[i];
          largestValue = values[i]; 
    }
    return largestValue;   
}

([1,2,3], 3)
([-1,-10], -1)
(null, int.minValue ///or throws exception)
([], int.minValue ///or throws exception) 
public int TestLargestInt(int[] inputValue, expectedResult){
   Assert.That(expectedResult, getLargestInt(inputValue));
}


