package dsahw4;

public class Hw4Driver {

	
	//This is the driver for the CommonElements Class
	
	

	
	public static void main(String[] args) {
		
		//Generating Arrays to use/test class with
		String array1[] = {"A", "B", "C", "D", "E", "F", "G", "H", "I"};
		String array2[] = {"J", "K", "L", "M", "N", "O", "P", "Q", "R", "S","T"};
		String array3[] = {"U", "V", "W", "X", "Y", "Z"};
		
		String array4[] = {"1", "2", "3", "4", "5", "6"};
		String array5[] = {"7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17"};
		
		String Qarray6[] = {"C", "F", "J", "1", "4", "5", "7", "9"};
		String Qarray7[] = {"U", "V", "5", "3"};
		String Qarray8[] = {""};
		
		//Making a collection of arrays
		Object[] collection1 = {Qarray6, array1};
		Object[] collection2 = {Qarray7, array3};
		Object[] collection3 = {Qarray8, array2};
		
		//New instance of CommonElements class
		CommonElements C = new CommonElements();
		
		//Passing collection3 over
		Comparable answers[] = C.findCommonElements(collection2);
		
		//Printing out the answers
		for(int i = 0; i<answers.length;i++){
			System.out.println(answers[i]);
		}
		
		//Checks how many times program runs through while loop
		System.out.println("Number of Comparisons: " + C.getComparisons());
		
	}

}
