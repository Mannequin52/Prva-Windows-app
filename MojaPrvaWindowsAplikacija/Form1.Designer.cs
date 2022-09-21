
namespace MojaPrvaWindowsAplikacija
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtUnosBrojaA = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtUnosBrojaB = new System.Windows.Forms.TextBox();
            this.txtIspisBroja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnosBrojaA
            // 
            this.txtUnosBrojaA.Location = new System.Drawing.Point(95, 138);
            this.txtUnosBrojaA.Name = "txtUnosBrojaA";
            this.txtUnosBrojaA.Size = new System.Drawing.Size(119, 20);
            this.txtUnosBrojaA.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtUnosBrojaB
            // 
            this.txtUnosBrojaB.Location = new System.Drawing.Point(530, 138);
            this.txtUnosBrojaB.Name = "txtUnosBrojaB";
            this.txtUnosBrojaB.Size = new System.Drawing.Size(119, 20);
            this.txtUnosBrojaB.TabIndex = 2;
            // 
            // txtIspisBroja
            // 
            this.txtIspisBroja.Enabled = false;
            this.txtIspisBroja.Location = new System.Drawing.Point(100, 296);
            this.txtIspisBroja.Name = "txtIspisBroja";
            this.txtIspisBroja.Size = new System.Drawing.Size(113, 20);
            this.txtIspisBroja.TabIndex = 3;
            this.txtIspisBroja.TabStop = false;
            this.txtIspisBroja.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zbroj";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzracunaj.Location = new System.Drawing.Point(530, 287);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(125, 36);
            this.btnIzracunaj.TabIndex = 7;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 528);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIspisBroja);
            this.Controls.Add(this.txtUnosBrojaB);
            this.Controls.Add(this.txtUnosBrojaA);
            this.Name = "Form1";
            this.Text = "Moja prva windows aplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosBrojaA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtUnosBrojaB;
        private System.Windows.Forms.TextBox txtIspisBroja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzracunaj;
    }
}

