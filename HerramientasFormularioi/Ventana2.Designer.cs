/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 15/08/2024
 * Hora: 12:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HerramientasFormularioi
{
	partial class Ventana2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbx_Nombres;
		private System.Windows.Forms.Label lbl_Nombre;
		private System.Windows.Forms.TextBox txt_Nombre;
		private System.Windows.Forms.Button btn_AgregarNombre;
		private System.Windows.Forms.ListBox lbx_Numeros;
		private System.Windows.Forms.Button bnt_AgregarNumeros;
		private System.Windows.Forms.TextBox txt_Numeros;
		private System.Windows.Forms.Label lbl_Numero;
		private System.Windows.Forms.Button btn_Mostrar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.cbbx_Nombres = new System.Windows.Forms.ComboBox();
			this.lbl_Nombre = new System.Windows.Forms.Label();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.btn_AgregarNombre = new System.Windows.Forms.Button();
			this.lbx_Numeros = new System.Windows.Forms.ListBox();
			this.bnt_AgregarNumeros = new System.Windows.Forms.Button();
			this.txt_Numeros = new System.Windows.Forms.TextBox();
			this.lbl_Numero = new System.Windows.Forms.Label();
			this.btn_Mostrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(378, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "LISTAS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cbbx_Nombres
			// 
			this.cbbx_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbx_Nombres.FormattingEnabled = true;
			this.cbbx_Nombres.Items.AddRange(new object[] {
			"Maria ",
			"Luis",
			"Rodrigo",
			"Ramiro",
			"Lucy"});
			this.cbbx_Nombres.Location = new System.Drawing.Point(105, 284);
			this.cbbx_Nombres.Name = "cbbx_Nombres";
			this.cbbx_Nombres.Size = new System.Drawing.Size(175, 28);
			this.cbbx_Nombres.TabIndex = 1;
			// 
			// lbl_Nombre
			// 
			this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombre.Location = new System.Drawing.Point(126, 149);
			this.lbl_Nombre.Name = "lbl_Nombre";
			this.lbl_Nombre.Size = new System.Drawing.Size(100, 23);
			this.lbl_Nombre.TabIndex = 2;
			this.lbl_Nombre.Text = "NOMBRE";
			this.lbl_Nombre.Click += new System.EventHandler(this.Lbl_NombreClick);
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nombre.Location = new System.Drawing.Point(105, 175);
			this.txt_Nombre.Multiline = true;
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(175, 33);
			this.txt_Nombre.TabIndex = 3;
			this.txt_Nombre.TextChanged += new System.EventHandler(this.Txt_NombreTextChanged);
			// 
			// btn_AgregarNombre
			// 
			this.btn_AgregarNombre.BackColor = System.Drawing.Color.Yellow;
			this.btn_AgregarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_AgregarNombre.Location = new System.Drawing.Point(138, 223);
			this.btn_AgregarNombre.Name = "btn_AgregarNombre";
			this.btn_AgregarNombre.Size = new System.Drawing.Size(88, 33);
			this.btn_AgregarNombre.TabIndex = 4;
			this.btn_AgregarNombre.Text = "Agregar";
			this.btn_AgregarNombre.UseVisualStyleBackColor = false;
			this.btn_AgregarNombre.Click += new System.EventHandler(this.Btn_AgregarNombreClick);
			// 
			// lbx_Numeros
			// 
			this.lbx_Numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbx_Numeros.FormattingEnabled = true;
			this.lbx_Numeros.ItemHeight = 24;
			this.lbx_Numeros.Items.AddRange(new object[] {
			"45",
			"70",
			"80",
			"100"});
			this.lbx_Numeros.Location = new System.Drawing.Point(730, 166);
			this.lbx_Numeros.Name = "lbx_Numeros";
			this.lbx_Numeros.Size = new System.Drawing.Size(121, 100);
			this.lbx_Numeros.TabIndex = 5;
			// 
			// bnt_AgregarNumeros
			// 
			this.bnt_AgregarNumeros.BackColor = System.Drawing.Color.Yellow;
			this.bnt_AgregarNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt_AgregarNumeros.Location = new System.Drawing.Point(596, 166);
			this.bnt_AgregarNumeros.Name = "bnt_AgregarNumeros";
			this.bnt_AgregarNumeros.Size = new System.Drawing.Size(88, 33);
			this.bnt_AgregarNumeros.TabIndex = 9;
			this.bnt_AgregarNumeros.Text = "Agregar";
			this.bnt_AgregarNumeros.UseVisualStyleBackColor = false;
			this.bnt_AgregarNumeros.Click += new System.EventHandler(this.Bnt_AgregarNumerosClick);
			// 
			// txt_Numeros
			// 
			this.txt_Numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Numeros.Location = new System.Drawing.Point(378, 166);
			this.txt_Numeros.Multiline = true;
			this.txt_Numeros.Name = "txt_Numeros";
			this.txt_Numeros.Size = new System.Drawing.Size(175, 33);
			this.txt_Numeros.TabIndex = 8;
			// 
			// lbl_Numero
			// 
			this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Numero.Location = new System.Drawing.Point(399, 140);
			this.lbl_Numero.Name = "lbl_Numero";
			this.lbl_Numero.Size = new System.Drawing.Size(100, 23);
			this.lbl_Numero.TabIndex = 7;
			this.lbl_Numero.Text = "NUMEROS";
			// 
			// btn_Mostrar
			// 
			this.btn_Mostrar.BackColor = System.Drawing.Color.Yellow;
			this.btn_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Mostrar.Location = new System.Drawing.Point(596, 233);
			this.btn_Mostrar.Name = "btn_Mostrar";
			this.btn_Mostrar.Size = new System.Drawing.Size(88, 52);
			this.btn_Mostrar.TabIndex = 10;
			this.btn_Mostrar.Text = "Mostrar Numero";
			this.btn_Mostrar.UseVisualStyleBackColor = false;
			this.btn_Mostrar.Click += new System.EventHandler(this.Btn_MostrarClick);
			// 
			// Ventana2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(994, 585);
			this.Controls.Add(this.btn_Mostrar);
			this.Controls.Add(this.bnt_AgregarNumeros);
			this.Controls.Add(this.txt_Numeros);
			this.Controls.Add(this.lbl_Numero);
			this.Controls.Add(this.lbx_Numeros);
			this.Controls.Add(this.btn_AgregarNombre);
			this.Controls.Add(this.txt_Nombre);
			this.Controls.Add(this.lbl_Nombre);
			this.Controls.Add(this.cbbx_Nombres);
			this.Controls.Add(this.label1);
			this.Name = "Ventana2";
			this.Text = "Ventana2";
			this.Load += new System.EventHandler(this.Ventana2Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
