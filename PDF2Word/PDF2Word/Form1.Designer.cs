
namespace PDF2Word
{
    partial class App
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.btnOutputpath = new System.Windows.Forms.Button();
            this.txtOutpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnInput);
            this.panelInput.Controls.Add(this.txtInput);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1098, 131);
            this.panelInput.TabIndex = 0;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnInput.Location = new System.Drawing.Point(747, 61);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(186, 36);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Choose file";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtInput.Location = new System.Drawing.Point(240, 58);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(452, 27);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(103, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.btnOutputpath);
            this.panelOutput.Controls.Add(this.txtOutpath);
            this.panelOutput.Controls.Add(this.label2);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOutput.Location = new System.Drawing.Point(0, 131);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(1098, 158);
            this.panelOutput.TabIndex = 1;
            // 
            // btnOutputpath
            // 
            this.btnOutputpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnOutputpath.Location = new System.Drawing.Point(747, 69);
            this.btnOutputpath.Name = "btnOutputpath";
            this.btnOutputpath.Size = new System.Drawing.Size(186, 36);
            this.btnOutputpath.TabIndex = 5;
            this.btnOutputpath.Text = "Direct";
            this.btnOutputpath.UseVisualStyleBackColor = true;
            this.btnOutputpath.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutpath
            // 
            this.txtOutpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtOutpath.Location = new System.Drawing.Point(240, 66);
            this.txtOutpath.Name = "txtOutpath";
            this.txtOutpath.ReadOnly = true;
            this.txtOutpath.Size = new System.Drawing.Size(452, 27);
            this.txtOutpath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(103, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output path:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnConvert.Location = new System.Drawing.Point(347, 342);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(287, 87);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 456);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Name = "App";
            this.Text = "Form1";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Button btnOutputpath;
        private System.Windows.Forms.TextBox txtOutpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
    }
}

