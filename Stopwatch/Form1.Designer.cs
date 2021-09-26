
namespace Stopwatch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbCs = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.BackColor = System.Drawing.SystemColors.Control;
            this.lbMin.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(16, 16);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(45, 36);
            this.lbMin.TabIndex = 0;
            this.lbMin.Text = "00";
            // 
            // lbCs
            // 
            this.lbCs.AutoSize = true;
            this.lbCs.BackColor = System.Drawing.SystemColors.Control;
            this.lbCs.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCs.Location = new System.Drawing.Point(118, 21);
            this.lbCs.Name = "lbCs";
            this.lbCs.Size = new System.Drawing.Size(37, 29);
            this.lbCs.TabIndex = 2;
            this.lbCs.Text = "00";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.BackColor = System.Drawing.SystemColors.Control;
            this.lbSec.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(67, 16);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(45, 36);
            this.lbSec.TabIndex = 3;
            this.lbSec.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.Control;
            this.btStart.Location = new System.Drawing.Point(22, 73);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(65, 29);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.Location = new System.Drawing.Point(164, 73);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(65, 29);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.SystemColors.Control;
            this.btStop.Location = new System.Drawing.Point(93, 73);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(65, 29);
            this.btStop.TabIndex = 8;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 148);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lbCs);
            this.Controls.Add(this.lbMin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbCs;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer timer1;
    }
}

