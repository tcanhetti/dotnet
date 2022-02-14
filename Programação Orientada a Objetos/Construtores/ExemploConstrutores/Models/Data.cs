namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;


        // Trabalhando com getters e setters e condicionais nos mesmos 
        public int Mes 
        { 
            get
            {
                return this.mes;
            } 
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            } 
        }


        //Equivalente a uma propriedade mas com metodos
        // public int GetMes()
        // {
        //     return this.mes;
        // }

        // public void SetMes(int mes)
        // {
        //     if(mes > 0 && mes <= 12)
        //     {
        //         this.mes = mes;
        //         this.mesValido = true;
        //     }
        // }

        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine($"Mês: {mes}");
            }
            else 
            {
                System.Console.WriteLine("Mês informado é inválido!");
            }
        }
    }
}