
namespace VendingMachineSYS
{
    partial class FrmDrinks
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
            this.btn_seven_up = new System.Windows.Forms.Button();
            this.btn_fanta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_coca_cola = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_seven_up
            // 
            this.btn_seven_up.BackColor = System.Drawing.Color.DarkGray;
            this.btn_seven_up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seven_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_seven_up.ForeColor = System.Drawing.Color.White;
            this.btn_seven_up.Location = new System.Drawing.Point(0, 327);
            this.btn_seven_up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seven_up.Name = "btn_seven_up";
            this.btn_seven_up.Size = new System.Drawing.Size(533, 73);
            this.btn_seven_up.TabIndex = 3;
            this.btn_seven_up.Text = "7Up";
            this.btn_seven_up.UseVisualStyleBackColor = false;
            this.btn_seven_up.Click += new System.EventHandler(this.btn_sevenUp_Click);
            // 
            // btn_fanta
            // 
            this.btn_fanta.BackColor = System.Drawing.Color.DarkGray;
            this.btn_fanta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fanta.ForeColor = System.Drawing.Color.White;
            this.btn_fanta.Location = new System.Drawing.Point(0, 160);
            this.btn_fanta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fanta.Name = "btn_fanta";
            this.btn_fanta.Size = new System.Drawing.Size(533, 73);
            this.btn_fanta.TabIndex = 2;
            this.btn_fanta.Text = "Fanta";
            this.btn_fanta.UseVisualStyleBackColor = false;
            this.btn_fanta.Click += new System.EventHandler(this.btn_fanta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_seven_up);
            this.panel2.Controls.Add(this.btn_fanta);
            this.panel2.Controls.Add(this.btn_coca_cola);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(276, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 544);
            this.panel2.TabIndex = 6;
            // 
            // btn_coca_cola
            // 
            this.btn_coca_cola.BackColor = System.Drawing.Color.DarkGray;
            this.btn_coca_cola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_coca_cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_coca_cola.ForeColor = System.Drawing.Color.White;
            this.btn_coca_cola.Location = new System.Drawing.Point(0, 0);
            this.btn_coca_cola.Margin = new System.Windows.Forms.Padding(4);
            this.btn_coca_cola.Name = "btn_coca_cola";
            this.btn_coca_cola.Size = new System.Drawing.Size(533, 73);
            this.btn_coca_cola.TabIndex = 2;
            this.btn_coca_cola.Text = "Coca Cola";
            this.btn_coca_cola.UseVisualStyleBackColor = false;
            this.btn_coca_cola.Click += new System.EventHandler(this.btn_coca_cola_Click);
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
            this.btn_back.Click += new System.EventHandler(this.btnBackDrink_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 550);
            this.panel1.TabIndex = 7;
            // 
            // FrmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDrinks";
            this.Text = "FrmDrinks";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_seven_up;
        private System.Windows.Forms.Button btn_fanta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_coca_cola;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
    }
}