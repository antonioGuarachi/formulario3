/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 15/08/2024
 * Hora: 12:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HerramientasFormularioi
{
	/// <summary>
	/// Description of Ventana2.
	/// </summary>
	public partial class Ventana2 : Form
	{
		public Ventana2()
		{
			
			InitializeComponent();
			
		}
		void Btn_AgregarNombreClick(object sender, EventArgs e)
		{
			cbbx_Nombres.Items.Add(txt_Nombre.Text);
			txt_Nombre.Clear();
			txt_Nombre.Focus();
		}
		void Bnt_AgregarNumerosClick(object sender, EventArgs e)
		{
			 string textoIngresado = txt_Numeros.Text;
    int numero;

    try
    { 
        numero = Convert.ToInt32(textoIngresado);
        lbx_Numeros.Items.Add(numero);
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, ingrese solo números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        txt_Numeros.Clear();
        txt_Numeros.Focus();
    }
		}
		void Btn_MostrarClick(object sender, EventArgs e)
		{
			try{
			short pos = Convert.ToInt16(txt_Numeros.Text);
			if(pos>lbx_Numeros.Items.Count)
				MessageBox.Show("La posicion ingresada no existe");
			else{
				string valor = lbx_Numeros.Items[pos-1].ToString();
				MessageBox.Show("El numero es "+valor);
				}
			}
			catch(Exception x){
				MessageBox.Show(x.Message);
			}
			finally{
			txt_Numeros.Clear();
			txt_Numeros.Focus();
			}
		}
		void Ventana2Load(object sender, EventArgs e)
		{
	
		}
		void Txt_NombreTextChanged(object sender, EventArgs e)
		{
	
		}
		void Lbl_NombreClick(object sender, EventArgs e)
		{
	
		}
	}
}
