
using System;
using System.Data;
using capaDAT;
using capaENT;

namespace capaNEG
{
    public class capaLogica
    {

        public void llevare(ref pacENT ee)
        {
            capaDatos xx = new capaDatos();
            xx.lleve(ref ee);
        }

        public DataSet listar()
        {
            capaDatos xx = new capaDatos();
            return xx.Listk();
        }

        public void llevar_visita(ref perENT tt)
        {
            capaDatos jj = new capaDatos();
            jj.lleve_v(ref tt);
        }

        public DataTable cargarPersonal()
        {
            capaDatos xx = new capaDatos();
            return xx.personal();
        }

        public DataTable cargarLugar()
        {
            capaDatos xx = new capaDatos();
            return xx.lugar();
        }

    }
}

