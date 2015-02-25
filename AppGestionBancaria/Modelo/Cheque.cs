using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionBancaria.Modelo
{
    public class Cheques :Cuentas
    {
        #region "Atributos"
        private string idtalonario;
        #endregion

        #region "Propiedades"

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public string IdeTalonario
        {
            get { return idtalonario; }
            set { idtalonario = value; }
        }

        #endregion

         #region "Constructores"
        public  Cheques()
            : base()
        {
            this.idtalonario ="id001" ;
            
            
        }

        public Cheques(string id, string balance, string idcliente, string idtalonario)
            : base(id,balance,idcliente)
        {
            this.idtalonario = idtalonario;
            
            
        }
        #endregion

        #region "Métodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                   
                   "\nIdentiicacion del talonario: " + this.idtalonario;
        }

        public override bool Equals(object obj)
        {
            Cheques o = (Cheques)obj;
            bool result = false;

            if (base.Equals(o) &&
               
                (this.idtalonario == o.idtalonario))
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
