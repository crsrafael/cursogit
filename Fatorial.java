public class Fatorial {
	//versão iterativa do cálculo do fatorial
	public int calcularFatorial(int n) {
		int resultado = 1;
		
		if(n > 0) {
			for(int i = 2; i <= n; i++) {
				resultado *= i;
			}
		}

		return resultado;
	}
}