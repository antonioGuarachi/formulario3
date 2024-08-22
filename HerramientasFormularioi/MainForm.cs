/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 15/08/2024
 * Hora: 11:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HerramientasFormularioi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Btn_mostrarParaleloClick(object sender, EventArgs e)
		{
			if(rbt_1A.Checked)
				lbl_paralelo.Text ="1er Año";
			if(rbt_2A.Checked)
				lbl_paralelo.Text ="2do Año";
			if(rbt_3A.Checked)
				lbl_paralelo.Text ="3er Año";
		}
		void Btn_MostrarIdiomaClick(object sender, EventArgs e)
		{
			if(cbx_Castellano.Checked)
				lbl_Idioma.Text = "CASTELLANO";
			if(cbx_Ingles.Checked)
				lbl_Idioma.Text = "INGLES";
			if(cbx_Otro.Checked)
				lbl_Idioma.Text = "OTRO";
			if(cbx_Castellano.Checked & cbx_Ingles.Checked)
				lbl_Idioma.Text = "CASTELLANO - INGLES";
		}
		void Btn_Ventana2Click(object sender, EventArgs e)
		{
			Ventana2 V2 = new Ventana2();// Crear el objeto e instancia 
			this.Hide();// Ocultar la ventana visible (MainForm)
			V2.ShowDialog();// Muestra el formulario nuevo (ventana2)
			this.Show();//Cuando se sierra la ventana anterios (ventana2)
			// Se abrira nuevamente MainForm
		}
		void Ventana3ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ventana3 V3 = new Ventana3();
			this.Hide();
			V3.ShowDialog();
			this.Show();
		}
		void Ventana2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ventana2 V2 = new Ventana2();
			this.Hide();
			V2.ShowDialog();
			this.Show();
		}
		void Ventana4ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ventana4 V4 = new Ventana4();
			this.Hide();
			V4.ShowDialog();
			this.Show();
		}
	}
}
