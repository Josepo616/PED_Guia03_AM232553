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
    public partial class Vertice : Form
    {
public bool control; // variable de control
public string dato; // el dato que almacenará el vértice

public Vertice() // metodo constructor
{
    InitializeComponent();

    control = false;
    dato = "";
}

private void Vertice_Load(object sender, EventArgs e)
{
    txtVertice.Focus();
}

private void Vertice_FormClosing(object sender, FormClosingEventArgs e)
{
    this.Hide();
    e.Cancel = true;
}

private void Vertice_Shown(object sender, EventArgs e)
{
    txtVertice.Clear();
    txtVertice.Focus();
}

private void btnAceptar_Click(object sender, EventArgs e)
{
    string valor = txtVertice.Text.Trim();
    if (valor == "")
        MessageBox.Show("Debes ingresar un valor", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    else
    {
        control = true;
        Hide();
    }
}

private void btnCancelar_Click(object sender, EventArgs e)
{
    control = false;
    Hide();
}

private void txtVertice_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
        btnAceptar_Click(null, null);
}
    }
}
