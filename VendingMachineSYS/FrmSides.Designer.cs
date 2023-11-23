
namespace VendingMachineSYS
{
    partial class FrmSides
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_fries = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nugets = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_nugets);
            this.panel2.Controls.Add(this.btn_fries);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(276, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 544);
            this.panel2.TabIndex = 6;
            // 
            // btn_fries
            // 
            this.btn_fries.BackColor = System.Drawing.Color.DarkGray;
            this.btn_fries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fries.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fries.ForeColor = System.Drawing.Color.White;
            this.btn_fries.Location = new System.Drawing.Point(0, 0);
            this.btn_fries.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fries.Name = "btn_fries";
            this.btn_fries.Size = new System.Drawing.Size(533, 111);
            this.btn_fries.TabIndex = 2;
            this.btn_fries.Text = "Fries";
            this.btn_fries.UseVisualStyleBackColor = false;
            this.btn_fries.Click += new System.EventHandler(this.btn_fries_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Yellow;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(0, 449);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(533, 97);
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
            this.panel1.TabIndex = 7;
            // 
            // btn_nugets
            // 
            this.btn_nugets.BackColor = System.Drawing.Color.DarkGray;
            this.btn_nugets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nugets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_nugets.ForeColor = System.Drawing.Color.White;
            this.btn_nugets.Location = new System.Drawing.Point(0, 230);
            this.btn_nugets.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nugets.Name = "btn_nugets";
            this.btn_nugets.Size = new System.Drawing.Size(533, 111);
            this.btn_nugets.TabIndex = 2;
            this.btn_nugets.Text = "Nugets";
            this.btn_nugets.UseVisualStyleBackColor = false;
            this.btn_nugets.Click += new System.EventHandler(this.btn_nugets_Click);
            // 
            // FrmSides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSides";
            this.Text = "FrmSides";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSides_FormClosed);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_fries;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nugets;
    }
}