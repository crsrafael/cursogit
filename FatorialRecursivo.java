public class FatorialRecursivo {
	public static int CalcularFatorialRecursivo(int n) throws IllegalArgumentException {
		if(n == 0) {
			return 1;
		}
		return n * CalcularFotrialRecusivo(n-1);
	}

	public static void main(String[] args) {
		System.out.println(CalcularFatorialRecursivo(5));
	}
}