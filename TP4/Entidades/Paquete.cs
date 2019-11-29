using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEstado(object sender, EventArgs e);
    public class Paquete: IMostar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        public void MockCicloDeVida()
        {

        }
        public string MostarDatos(IMostar<Paquete>elemento)
        {
            StringBuilder stg = new StringBuilder();
            stg.AppendFormat("{0} para {1}");
            return stg.ToString();
        }
        public static bool operator ==(Paquete p1, Paquete p2)
        { }
        public static bool operator !=(Paquete p1, Paquete p2)
        { }
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }
        public override string ToString()
        {
            return this.MostarDatos(this);
        }
        public event DelegadoEstado InformaEstado;

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
