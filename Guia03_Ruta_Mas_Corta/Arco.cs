using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_10_Grafos_Proc
{

public partial class Arco : Form
{
    public bool control; // variable de control
    public int dato; // el dato que almacenara el vertice

    public Arco()
    {
        InitializeComponent();
        control = false;
        dato = 0;
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
        try
        {
            dato = Convert.ToInt16(txtPeso.Text.Trim());
            if (dato < 0)                
                MessageBox.Show("Debes ingresar un valor positivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            else
            {
                control = true;
                Hide();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Debes ingresar un valor numerico");
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        control = false;
        Hide();
    }

    private void Arco_Load(object sender, EventArgs e)
    {
        txtPeso.Focus();
    }


private void Arco_FormClosing(object sender, FormClosingEventArgs e)
{
    this.Hide();
    e.Cancel = true;

}

private void Arco_Shown(object sender, EventArgs e)
{
    txtPeso.Clear();
    txtPeso.Focus();
}

private void txtPeso_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
        btnAceptar_Click(null, null);
}




    } //fin clase Arco

}
