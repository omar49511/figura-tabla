using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace figuras_examen
{
    class validacion
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
            public void SoloNumeros(KeyPressEventArgs e)
            {
                try
                {
                    if (char.IsNumber(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
    }
}
