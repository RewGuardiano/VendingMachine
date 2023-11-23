
namespace VendingMachineSYS
{
    partial class FrmDesserts
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
            this.btn_donuts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_apple_pie = new System.Windows.Forms.Button();
            this.btn_ice_cream = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_donuts
            // 
            this.btn_donuts.BackColor = System.Drawing.Color.DarkGray;
            this.btn_donuts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_donuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_donuts.ForeColor = System.Drawing.Color.White;
            this.btn_donuts.Location = new System.Drawing.Point(0, 327);
            this.btn_donuts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_donuts.Name = "btn_donuts";
            this.btn_donuts.Size = new System.Drawing.Size(533, 73);
            this.btn_donuts.TabIndex = 3;
            this.btn_donuts.Text = "Donuts";
            this.btn_donuts.UseVisualStyleBackColor = false;
            this.btn_donuts.Click += new System.EventHandler(this.btn_donuts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_donuts);
            this.panel2.Controls.Add(this.btn_apple_pie);
            this.panel2.Controls.Add(this.btn_ice_cream);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(276, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 544);
            this.panel2.TabIndex = 4;
            // 
            // btn_apple_pie
            // 
            this.btn_apple_pie.BackColor = System.Drawing.Color.DarkGray;
            this.btn_apple_pie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_apple_pie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_apple_pie.ForeColor = System.Drawing.Color.White;
            this.btn_apple_pie.Location = new System.Drawing.Point(0, 160);
            this.btn_apple_pie.Margin = new System.Windows.Forms.Padding(4);
            this.btn_apple_pie.Name = "btn_apple_pie";
            this.btn_apple_pie.Size = new System.Drawing.Size(533, 73);
            this.btn_apple_pie.TabIndex = 2;
            this.btn_apple_pie.Text = "Apple Pie";
            this.btn_apple_pie.UseVisualStyleBackColor = false;
            this.btn_apple_pie.Click += new System.EventHandler(this.btn_apple_pie_Click);
            // 
            // btn_ice_cream
            // 
            this.btn_ice_cream.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ice_cream.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ice_cream.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ice_cream.ForeColor = System.Drawing.Color.White;
            this.btn_ice_cream.Location = new System.Drawing.Point(0, 0);
            this.btn_ice_cream.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ice_cream.Name = "btn_ice_cream";
            this.btn_ice_cream.Size = new System.Drawing.Size(533, 73);
            this.btn_ice_cream.TabIndex = 2;
            this.btn_ice_cream.Text = "Ice Cream";
            this.btn_ice_cream.UseVisualStyleBackColor = false;
            this.btn_ice_cream.Click += new System.EventHandler(this.btn_ice_cream_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Yellow;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(0, 473);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(533, 73);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btnBackDesserts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 550);
            this.panel1.TabIndex = 5;
            // 
            // FrmDesserts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDesserts";
            this.Text = "FrmDesserts";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_donuts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_apple_pie;
        private System.Windows.Forms.Button btn_ice_cream;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
    }
}