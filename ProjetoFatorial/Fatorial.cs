namespace ProjetoFatorial
{
    public class Fatorial
    {
        public int CalcularFatorial(int numero) {
            int resultado = 1;

            if(numero <= 0) {
                return 1;
            }

            for (int i = 1; i <= numero; i++){
                resultado *= i;
            }

            return resultado;
        }
    }
}