/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 16/08/2024
 * Hora: 8:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HerramientasFormularioi
{
	partial class Ventana3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana3));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(49, 55);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(692, 341);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(298, 424);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 1;
			// 
			// Ventana3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(799, 729);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Ventana3";
			this.Text = "Ventana3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
