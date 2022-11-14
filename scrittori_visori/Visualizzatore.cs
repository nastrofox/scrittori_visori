using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace scrittori_visori
{
    internal class Visualizzatore
    {
        private bool grassetto;
        private bool corsivo;
        private bool sottolineato;
        private Color color;
        private RichTextBox richtextbox;
        public Boolean Grassetto
        {
            set
            {

            }
            get
            {
                return grassetto;
            }
        }
        public Boolean Corsivo
        {
            set
            {
                corsivo = value;
            }
            get
            {
                return corsivo;
            }
        }
        private Boolean Sottolineato
        {
            set
            {
                sottolineato = value;
            }
            get
            {
                return sottolineato;
            }
        }
    }
}
