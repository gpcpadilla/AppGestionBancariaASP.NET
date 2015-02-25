using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionBancaria
{
    public class Cuentas
    {
        #region "Atributos"
        private string ide;
        private string balance;
        private string idcliente;
        #endregion

        #region "Propiedades"

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public string identificacion
        {
            get { return ide; }
            set { ide = value; }
        }
        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public string IDcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }



        #endregion

        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Personas
        ///</summary>
        public Cuentas()
        {
            this.ide = "1047424720";
            this.balance = "150234";
            this.idcliente = "00001";
        }

        ///<summary>
        ///Contructor de inicialización Personas
        ///</summary>
        ///<param name="ide"> Identificacion de  la Personas</param>
        ///<param name="balance"> Nombres y Apaellidos de Persona</param>
        /// ///<param name="idcliente"> Nombres y Apaellidos de Persona</param>
        ///
        public Cuentas(string ide, string balance, string idcliente)
        {
            this.ide = ide;
            this.balance = balance;
            this.idcliente = idcliente;
        }
        #endregion

        #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Identificación:  " + this.ide + "\n" +
                     "Balance:  " + this.balance + "\n" +
                     "IdCliente:  " + this.idcliente;
        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            Cuentas o = (Cuentas)obj;
            bool result = false;

            if (base.Equals(o) &&
                (this.ide == o.ide) &&
                 (this.balance == o.balance) &&
                 (this.idcliente == o.idcliente))
                result = true;

            return result;
        }

        /// <summary>
        /// Devuelve la identificación del objecto
        /// </summary>
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