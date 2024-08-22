/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 16/08/2024
 * Hora: 8:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HerramientasFormularioi
{
	partial class Ventana4
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Nombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Apellido;
		private System.Windows.Forms.Label lbl_genero;
		private System.Windows.Forms.RadioButton rbt_Femenino;
		private System.Windows.Forms.RadioButton rbt_Masculino;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_Guardar;
		private System.Windows.Forms.Label lbl_Guardar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana4));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Apellido = new System.Windows.Forms.TextBox();
			this.lbl_genero = new System.Windows.Forms.Label();
			this.rbt_Femenino = new System.Windows.Forms.RadioButton();
			this.rbt_Masculino = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.lbl_Guardar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(366, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "REGISTRO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.UseMnemonic = false;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(95, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE";
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Location = new System.Drawing.Point(95, 172);
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(156, 20);
			this.txt_Nombre.TabIndex = 2;
			this.txt_Nombre.TextChanged += new System.EventHandler(this.Txt_NombreTextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(95, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "APELLIDO";
			// 
			// txt_Apellido
			// 
			this.txt_Apellido.Location = new System.Drawing.Point(95, 260);
			this.txt_Apellido.Name = "txt_Apellido";
			this.txt_Apellido.Size = new System.Drawing.Size(156, 20);
			this.txt_Apellido.TabIndex = 3;
			
			// 
			// lbl_genero
			// 
			this.lbl_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_genero.Location = new System.Drawing.Point(95, 307);
			this.lbl_genero.Name = "lbl_genero";
			this.lbl_genero.Size = new System.Drawing.Size(125, 23);
			this.lbl_genero.TabIndex = 4;
			this.lbl_genero.Text = "GENERO";
			// 
			// rbt_Femenino
			// 
			this.rbt_Femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_Femenino.Location = new System.Drawing.Point(104, 357);
			this.rbt_Femenino.Name = "rbt_Femenino";
			this.rbt_Femenino.Size = new System.Drawing.Size(132, 24);
			this.rbt_Femenino.TabIndex = 5;
			this.rbt_Femenino.TabStop = true;
			this.rbt_Femenino.Text = "Femenino";
			this.rbt_Femenino.UseVisualStyleBackColor = true;
			
			// 
			// rbt_Masculino
			// 
			this.rbt_Masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_Masculino.Location = new System.Drawing.Point(104, 400);
			this.rbt_Masculino.Name = "rbt_Masculino";
			this.rbt_Masculino.Size = new System.Drawing.Size(132, 24);
			this.rbt_Masculino.TabIndex = 6;
			this.rbt_Masculino.TabStop = true;
			this.rbt_Masculino.Text = "Masculino";
			this.rbt_Masculino.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(496, 135);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(303, 305);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Guardar.Location = new System.Drawing.Point(315, 501);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(149, 40);
			this.btn_Guardar.TabIndex = 8;
			this.btn_Guardar.Text = "GUARDAR";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_GuardarClick);
			// 
			// lbl_Guardar
			// 
			this.lbl_Guardar.Location = new System.Drawing.Point(151, 603);
			this.lbl_Guardar.Name = "lbl_Guardar";
			this.lbl_Guardar.Size = new System.Drawing.Size(470, 65);
			this.lbl_Guardar.TabIndex = 9;
			// 
			// Ventana4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 696);
			this.Controls.Add(this.lbl_Guardar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rbt_Masculino);
			this.Controls.Add(this.rbt_Femenino);
			this.Controls.Add(this.lbl_genero);
			this.Controls.Add(this.txt_Apellido);
			this.Controls.Add(this.txt_Nombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Ventana4";
			this.Text = "Ventana4";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
