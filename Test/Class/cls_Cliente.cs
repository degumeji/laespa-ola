using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Class
{
    [Serializable]
    public class cls_Cliente
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string cedula;

        public string CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string nombres;

        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;

        public string APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private Char genero;

        public Char GENERO
        {
            get { return genero; }
            set { genero = value; }
        }

        private int edad;

        public int EDAD
        {
            get { return edad; }
            set { edad = value; }
        }

        private Char estado;

        public Char ESTADO
        {
            get { return estado; }
            set { estado = value; }
        }

        public cls_Cliente() {
            this.id = 0;
            this.cedula = "";
            this.nombres = "";
            this.apellidos = "";
            this.genero = 'M';
            this.edad = 0;
            this.estado = 'A';
        }

        public cls_Cliente( int ID,
                            String CEDULA,
                            String NOMBRES,
                            String APELLIDOS,
                            Char GENERO,
                            int EDAD,
                            Char ESTADO)
        {
            this.id = ID;
            this.cedula = CEDULA;
            this.nombres = NOMBRES;
            this.apellidos = APELLIDOS;
            this.genero = GENERO;
            this.edad = EDAD;
            this.estado = ESTADO;
        }
    }
}