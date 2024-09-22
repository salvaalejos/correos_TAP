namespace TAP_U1P5_B
{
    partial class CorreosForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelEntrada = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSalida = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.flowLayoutPanelSalida);
            this.tabControl1.Location = new System.Drawing.Point(6, 66);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanelEntrada);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(367, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bandeja de entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelEntrada
            // 
            this.flowLayoutPanelEntrada.AutoScroll = true;
            this.flowLayoutPanelEntrada.AutoSize = true;
            this.flowLayoutPanelEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEntrada.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEntrada.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanelEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelEntrada.Name = "flowLayoutPanelEntrada";
            this.flowLayoutPanelEntrada.Size = new System.Drawing.Size(363, 277);
            this.flowLayoutPanelEntrada.TabIndex = 0;
            // 
            // flowLayoutPanelSalida
            // 
            this.flowLayoutPanelSalida.AutoScroll = true;
            this.flowLayoutPanelSalida.Location = new System.Drawing.Point(4, 22);
            this.flowLayoutPanelSalida.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelSalida.Name = "flowLayoutPanelSalida";
            this.flowLayoutPanelSalida.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelSalida.Size = new System.Drawing.Size(367, 281);
            this.flowLayoutPanelSalida.TabIndex = 1;
            this.flowLayoutPanelSalida.Text = "Bandeja de salida";
            this.flowLayoutPanelSalida.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "✉️ Nuevo correo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.Location = new System.Drawing.Point(280, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar Sesión";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CorreosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 379);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CorreosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correos";
            this.Load += new System.EventHandler(this.CorreosForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnClose;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage flowLayoutPanelSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEntrada;
    }
}