using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionBancaria.Modelo
{
    public class Ahorros :Cuentas
    {

        #region "Atributos"
        private double tasainteres;
         #endregion

        #region "Propiedades"

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public double TasaInteres
        {
            get { return tasainteres; }
            set { tasainteres = value; }
        }
        
        #endregion

         #region "Constructores"
        public Ahorros()
            : base()
        {
            
            this.tasainteres = 1.2;
            
        }

        public Ahorros(string id, string balance, string idcliente, double tasainteres)
            : base(id,balance,idcliente)
        {
            this.tasainteres = tasainteres;
            
        }


        #endregion

        #region "Métodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                   
                   "\nTasaInteres: " + this.tasainteres;
        }

        public override bool Equals(object obj)
        {
            Ahorros o = (Ahorros)obj;
            bool result = false;

            if (base.Equals(o) &&
               (this.tasainteres == o.tasainteres))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

        #region "Metodos"
        public void BalanceAtual(Saldo); 
        public void Depositar(BalanceActual + deposito); 
        public void Retirar(BalanceActual - Retiro);
        #endregion
    }
}