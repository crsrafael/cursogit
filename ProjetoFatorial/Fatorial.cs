namespace ProjetoFatorial
{
    public class Fatorial
    {
        public int CalculoIterativo(int numero) {
            int resultado = 1;

            if(numero <= 0) {
                return 1;
            }

            for (int i = 1; i <= numero; i++){
                resultado *= i;
            }

            return resultado;
        }
    
        public int CalculoRecursivo(int numero){
            if (numero <= 0){
                return 1;
            }

            return numero * CalculoRecursivo(numero - 1);
        }
    }
}