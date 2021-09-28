
using System;

namespace capaENT
{
    public class perENT
    {
        private int _documento;
        private string _nombre;
        private string _parentezco;
        private string _anfitrion;
        private string _salon;

        // propiedades publicas
        public int Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Parentezco
        {
            get { return _parentezco; }
            set { _parentezco = value; }
        }

        public string Anfitrion
        {
            get { return _anfitrion; }
            set { _anfitrion = value; }
        }

        public string Salon
        {
            get { return _salon; }
            set { _salon = value; }
        }

    }

    public class pacENT
    {
        // atributos privados
        private int documento;
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private string obrsocial;
        private string foto;

        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Obrsocial
        {
            get { return obrsocial; }
            set { obrsocial = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

    }

    class CapaEntidades{}
}

