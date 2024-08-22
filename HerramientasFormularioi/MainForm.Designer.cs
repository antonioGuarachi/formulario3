/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 15/08/2024
 * Hora: 11:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HerramientasFormularioi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_Idioma;
		private System.Windows.Forms.RadioButton rbt_1A;
		private System.Windows.Forms.RadioButton rbt_2A;
		private System.Windows.Forms.RadioButton rbt_3A;
		private System.Windows.Forms.Button btn_mostrarParalelo;
		private System.Windows.Forms.Label lbl_paralelo;
		private System.Windows.Forms.CheckBox cbx_Castellano;
		private System.Windows.Forms.CheckBox cbx_Ingles;
		private System.Windows.Forms.CheckBox cbx_Otro;
		private System.Windows.Forms.Button btn_MostrarIdioma;
		private System.Windows.Forms.Label lbl_Idioma;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Ventana2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana4ToolStripMenuItem;
		
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
			this.rbt_1A = new System.Windows.Forms.RadioButton();
			this.btn_Idioma = new System.Windows.Forms.Label();
			this.rbt_2A = new System.Windows.Forms.RadioButton();
			this.rbt_3A = new System.Windows.Forms.RadioButton();
			this.btn_mostrarParalelo = new System.Windows.Forms.Button();
			this.lbl_paralelo = new System.Windows.Forms.Label();
			this.cbx_Castellano = new System.Windows.Forms.CheckBox();
			this.cbx_Ingles = new System.Windows.Forms.CheckBox();
			this.cbx_Otro = new System.Windows.Forms.CheckBox();
			this.btn_MostrarIdioma = new System.Windows.Forms.Button();
			this.lbl_Idioma = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Ventana2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbt_1A
			// 
			this.rbt_1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_1A.Location = new System.Drawing.Point(168, 103);
			this.rbt_1A.Name = "rbt_1A";
			this.rbt_1A.Size = new System.Drawing.Size(129, 24);
			this.rbt_1A.TabIndex = 0;
			this.rbt_1A.TabStop = true;
			this.rbt_1A.Text = "1er Año";
			this.rbt_1A.UseVisualStyleBackColor = true;
			// 
			// btn_Idioma
			// 
			this.btn_Idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Idioma.Location = new System.Drawing.Point(424, 39);
			this.btn_Idioma.Name = "btn_Idioma";
			this.btn_Idioma.Size = new System.Drawing.Size(204, 23);
			this.btn_Idioma.TabIndex = 1;
			this.btn_Idioma.Text = "IDIOMA";
			// 
			// rbt_2A
			// 
			this.rbt_2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_2A.Location = new System.Drawing.Point(168, 133);
			this.rbt_2A.Name = "rbt_2A";
			this.rbt_2A.Size = new System.Drawing.Size(129, 24);
			this.rbt_2A.TabIndex = 0;
			this.rbt_2A.TabStop = true;
			this.rbt_2A.Text = "2do Año";
			this.rbt_2A.UseVisualStyleBackColor = true;
			this.rbt_2A.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// rbt_3A
			// 
			this.rbt_3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_3A.Location = new System.Drawing.Point(168, 163);
			this.rbt_3A.Name = "rbt_3A";
			this.rbt_3A.Size = new System.Drawing.Size(129, 24);
			this.rbt_3A.TabIndex = 0;
			this.rbt_3A.TabStop = true;
			this.rbt_3A.Text = "3ro Año";
			this.rbt_3A.UseVisualStyleBackColor = true;
			this.rbt_3A.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// btn_mostrarParalelo
			// 
			this.btn_mostrarParalelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_mostrarParalelo.Location = new System.Drawing.Point(168, 208);
			this.btn_mostrarParalelo.Name = "btn_mostrarParalelo";
			this.btn_mostrarParalelo.Size = new System.Drawing.Size(86, 33);
			this.btn_mostrarParalelo.TabIndex = 2;
			this.btn_mostrarParalelo.Text = "Mostrar";
			this.btn_mostrarParalelo.UseVisualStyleBackColor = true;
			this.btn_mostrarParalelo.Click += new System.EventHandler(this.Btn_mostrarParaleloClick);
			// 
			// lbl_paralelo
			// 
			this.lbl_paralelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_paralelo.Location = new System.Drawing.Point(154, 264);
			this.lbl_paralelo.Name = "lbl_paralelo";
			this.lbl_paralelo.Size = new System.Drawing.Size(100, 23);
			this.lbl_paralelo.TabIndex = 3;
			// 
			// cbx_Castellano
			// 
			this.cbx_Castellano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Castellano.Location = new System.Drawing.Point(434, 102);
			this.cbx_Castellano.Name = "cbx_Castellano";
			this.cbx_Castellano.Size = new System.Drawing.Size(122, 24);
			this.cbx_Castellano.TabIndex = 4;
			this.cbx_Castellano.Text = "Castellano";
			this.cbx_Castellano.UseVisualStyleBackColor = true;
			// 
			// cbx_Ingles
			// 
			this.cbx_Ingles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Ingles.Location = new System.Drawing.Point(434, 134);
			this.cbx_Ingles.Name = "cbx_Ingles";
			this.cbx_Ingles.Size = new System.Drawing.Size(104, 24);
			this.cbx_Ingles.TabIndex = 4;
			this.cbx_Ingles.Text = "Ingles";
			this.cbx_Ingles.UseVisualStyleBackColor = true;
			// 
			// cbx_Otro
			// 
			this.cbx_Otro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Otro.Location = new System.Drawing.Point(434, 164);
			this.cbx_Otro.Name = "cbx_Otro";
			this.cbx_Otro.Size = new System.Drawing.Size(104, 24);
			this.cbx_Otro.TabIndex = 4;
			this.cbx_Otro.Text = "Otro";
			this.cbx_Otro.UseVisualStyleBackColor = true;
			// 
			// btn_MostrarIdioma
			// 
			this.btn_MostrarIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_MostrarIdioma.Location = new System.Drawing.Point(424, 208);
			this.btn_MostrarIdioma.Name = "btn_MostrarIdioma";
			this.btn_MostrarIdioma.Size = new System.Drawing.Size(86, 33);
			this.btn_MostrarIdioma.TabIndex = 2;
			this.btn_MostrarIdioma.Text = "Mostrar";
			this.btn_MostrarIdioma.UseVisualStyleBackColor = true;
			this.btn_MostrarIdioma.Click += new System.EventHandler(this.Btn_mostrarParaleloClick);
			// 
			// lbl_Idioma
			// 
			this.lbl_Idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Idioma.Location = new System.Drawing.Point(424, 264);
			this.lbl_Idioma.Name = "lbl_Idioma";
			this.lbl_Idioma.Size = new System.Drawing.Size(100, 23);
			this.lbl_Idioma.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(154, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "PARALELO";
			// 
			// btn_Ventana2
			// 
			this.btn_Ventana2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Ventana2.Location = new System.Drawing.Point(669, 43);
			this.btn_Ventana2.Name = "btn_Ventana2";
			this.btn_Ventana2.Size = new System.Drawing.Size(111, 29);
			this.btn_Ventana2.TabIndex = 5;
			this.btn_Ventana2.Text = "Ventana 2";
			this.btn_Ventana2.UseVisualStyleBackColor = true;
			this.btn_Ventana2.Click += new System.EventHandler(this.Btn_Ventana2Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem,
			this.ventanaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(969, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.abrirToolStripMenuItem,
			this.nuevoToolStripMenuItem,
			this.guardarToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.abrirToolStripMenuItem.Text = "Abrir";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.guardarComoToolStripMenuItem});
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.guardarToolStripMenuItem.Text = "Guardar";
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.guardarComoToolStripMenuItem.Text = "Guardar como ";
			// 
			// ventanaToolStripMenuItem
			// 
			this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ventana1ToolStripMenuItem,
			this.ventana2ToolStripMenuItem,
			this.ventana3ToolStripMenuItem,
			this.ventana4ToolStripMenuItem});
			this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
			this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.ventanaToolStripMenuItem.Text = "Ventana";
			// 
			// ventana1ToolStripMenuItem
			// 
			this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
			this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ventana1ToolStripMenuItem.Text = "Ventana 1";
			// 
			// ventana2ToolStripMenuItem
			// 
			this.ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
			this.ventana2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ventana2ToolStripMenuItem.Text = "Ventana 2";
			this.ventana2ToolStripMenuItem.Click += new System.EventHandler(this.Ventana2ToolStripMenuItemClick);
			// 
			// ventana3ToolStripMenuItem
			// 
			this.ventana3ToolStripMenuItem.Name = "ventana3ToolStripMenuItem";
			this.ventana3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ventana3ToolStripMenuItem.Text = "Ventana 3";
			this.ventana3ToolStripMenuItem.Click += new System.EventHandler(this.Ventana3ToolStripMenuItemClick);
			// 
			// ventana4ToolStripMenuItem
			// 
			this.ventana4ToolStripMenuItem.Name = "ventana4ToolStripMenuItem";
			this.ventana4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ventana4ToolStripMenuItem.Text = "Ventana 4";
			this.ventana4ToolStripMenuItem.Click += new System.EventHandler(this.Ventana4ToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(969, 610);
			this.Controls.Add(this.btn_Ventana2);
			this.Controls.Add(this.cbx_Otro);
			this.Controls.Add(this.cbx_Ingles);
			this.Controls.Add(this.cbx_Castellano);
			this.Controls.Add(this.lbl_Idioma);
			this.Controls.Add(this.lbl_paralelo);
			this.Controls.Add(this.btn_MostrarIdioma);
			this.Controls.Add(this.btn_mostrarParalelo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Idioma);
			this.Controls.Add(this.rbt_3A);
			this.Controls.Add(this.rbt_2A);
			this.Controls.Add(this.rbt_1A);
			this.Controls.Add(this.menuStrip1);
			this.Name = "MainForm";
			this.Text = "HerramientasFormularioi";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
