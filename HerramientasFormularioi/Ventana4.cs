/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 16/08/2024
 * Hora: 8:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HerramientasFormularioi
{
	/// <summary>
	/// Description of Ventana4.
	/// </summary>
	public partial class Ventana4 : Form
	{
		public Ventana4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		void Txt_NombreTextChanged(object sender, EventArgs e)
		{
			string genero = txt_Nombre.Text;
		}
		void Btn_GuardarClick(object sender, EventArgs e)
		{
			string genero = "";

			if (rbt_Femenino.Checked){
            {
                genero = "Femenino";
            }
			else if (rbt_Masculino.Checked){
				genero = "Masculino";
			lbl_Guardar.Text = "Nombre"+(txt_Nombre.Text)+"Apellido: " +(txt_Apellido.Text)+"Genero: "+genero;
				}
			
			
				public void limpiar(){
				txt_Nombre.Clear();
				txt_Apellido.Clear();
				txt_Apellido.Focus();
				}
				
			
   		 	}
		}
