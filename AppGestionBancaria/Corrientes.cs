using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionBancaria
{
    public class Corrientes :Cuentas
    {
        #region "Atributos"
        private double limitecredito;
        private double tiefectivo;
        private double tibalance;
        #endregion

        #region "Propiedades"

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public double limitedecredito
        {
            get { return limitecredito; }
            set { limitecredito = value; }
        }

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public double TasaInteresEfectivo
        {
            get { return tiefectivo; }
            set { tiefectivo = value; }
        }

        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public double TasaInteresBalance
        {
            get { return tibalance; }
            set { tibalance = value; }
        }

        #endregion

        #region "Constructores"
        public  Corrientes()
            : base()
        {
            this.limitecredito = 300000;
            this.tiefectivo = 1.2;
            this.tibalance = 1.0;
            
        }

        public Corrientes(string id, string balance, string idcliente, double limitecredito, double tiefectivo, double tibalance)
            : base(id,balance,idcliente)
        {
            this.limitecredito = limitecredito;
            this.tiefectivo = tiefectivo;
            this.tibalance = tibalance;
            
        }
        #endregion

        #region "Métodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                   "\nLimite de credito: " + this.limitecredito +
                   "\nTasa interes efectivo: " + this.tiefectivo +
                   "\nTasa interes blance: " + this.tibalance;
                   
        }

        public override bool Equals(object obj)
        {
            Corrientes o = (Corrientes)obj;
            bool result = false;

            if (base.Equals(o) &&
               (this.limitecredito == o.limitecredito) &&
                (this.tiefectivo == o.tiefectivo) &&
                 (this.tibalance == o.tibalance))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

        #region "Metodos"
       
        #endregion
    }
}
