package dsahw4;
import java.util.*;


public class CommonElements{
	
private int comparisons = 0;

	public Comparable[] findCommonElements(Object[] collections){
		
		int i = 0;
		int j = 1;
		
		//Typecasting Object[] to Comparable[] and separating Arrays
		Comparable[] queryArray = (Comparable[])collections[i];
		Comparable[] testArray = (Comparable[])collections[j];
		if(testArray.length < queryArray.length){
			i = 1;
			j = 0;
		     queryArray = (Comparable[])collections[i];
			 testArray = (Comparable[])collections[j];
		} 
			
			
		//Converting to ArrayList to use the Iterator
		ArrayList<Comparable> query = new ArrayList<Comparable>(Arrays.asList(queryArray));
		ArrayList<Comparable> test = new ArrayList<Comparable>(Arrays.asList(testArray));
		
		Iterator<Comparable> it = query.iterator();
		
		//This loop basically sets it up to check if something is not in the query array 
		//and if it is not then item is removed
		while(it.hasNext()){
			comparisons++;
				if(!test.contains(it.next())){
					it.remove();
				}
		}
				//Converting Back to Array of Comparable[]
				Comparable[] answer = query.toArray(new Comparable[query.size()]);
				
		return answer;
		}
	
	//This method is used to keep track of the number of times the program
	//goes through the while loop
	public int getComparisons(){
		return comparisons;
		
	}
	
			
	}
		
			
		

