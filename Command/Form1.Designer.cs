
namespace Command
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingCanvas1 = new DrawingCanvas();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawingCanvas1
            // 
            this.drawingCanvas1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingCanvas1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drawingCanvas1.Location = new System.Drawing.Point(60, 51);
            this.drawingCanvas1.Name = "drawingCanvas1";
            this.drawingCanvas1.Size = new System.Drawing.Size(675, 326);
            this.drawingCanvas1.TabIndex = 0;
            this.drawingCanvas1.Load += new System.EventHandler(this.drawingCanvas1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawingCanvas1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DrawingCanvas drawingCanvas1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

