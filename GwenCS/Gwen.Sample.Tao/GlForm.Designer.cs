﻿using Tao.Platform.Windows;
namespace Gwen.Sample.Tao
{
    partial class GlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.glControl = new global::Tao.Platform.Windows.SimpleOpenGlControl();
			this.SuspendLayout();
			// 
			// glControl
			// 
			this.glControl.AccumBits = ((byte)(0));
			this.glControl.AutoCheckErrors = false;
			this.glControl.AutoFinish = false;
			this.glControl.AutoMakeCurrent = true;
			this.glControl.AutoSwapBuffers = true;
			this.glControl.BackColor = System.Drawing.Color.Black;
			this.glControl.ColorBits = ((byte)(32));
			this.glControl.DepthBits = ((byte)(16));
			this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl.Location = new System.Drawing.Point(0, 0);
			this.glControl.Name = "glControl";
			this.glControl.Size = new System.Drawing.Size(763, 527);
			this.glControl.StencilBits = ((byte)(0));
			this.glControl.TabIndex = 0;
			this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
			this.glControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl_KeyDown);
			this.glControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.glControl_KeyPress);
			this.glControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glControl_KeyUp);
			this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
			this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
			this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
			// 
			// GlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 527);
			this.Controls.Add(this.glControl);
			this.Name = "GlForm";
			this.Text = "GWEN.NET - Tao.OpenGL renderer";
			this.Load += new System.EventHandler(this.GlForm_Load);
			this.Resize += new System.EventHandler(this.GlForm_Resize);
			this.ResumeLayout(false);

        }

        #endregion

        private global::Tao.Platform.Windows.SimpleOpenGlControl glControl;
    }
}

