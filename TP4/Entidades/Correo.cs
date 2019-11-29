using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Correo: IMostar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquetes = new List<Paquete>();
        }
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }
        public string MostrarDatos(IMostar<List<Paquete>>elementos)
        {
            StringBuilder stg = new StringBuilder();
            stg.AppendFormat("{0} para {1}({2})");
            return stg.ToString();
        }
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.paquetes)
            {
                if (item == p)
                {

                }
            }
            c.paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida); //creo hilo
            c.mockPaquetes.Add(hilo);//lo agrego a mockpaquetes
            hilo.Start();//lo ejecuto
            return c;
        }
    }
}
