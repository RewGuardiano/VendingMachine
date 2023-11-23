
namespace VendingMachineSYS
{
    partial class FrmBurgers
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
            this.btn_ham_and_beef = new System.Windows.Forms.Button();
            this.btn_ham_and_sweetcorn = new System.Windows.Forms.Button();
            this.btn_chicken_and_salad = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_ham_and_beef);
            this.panel2.Controls.Add(this.btn_ham_and_sweetcorn);
            this.panel2.Controls.Add(this.btn_chicken_and_salad);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(276, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 544);
            this.panel2.TabIndex = 2;
            // 
            // btn_ham_and_beef
            // 
            this.btn_ham_and_beef.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ham_and_beef.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ham_and_beef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ham_and_beef.ForeColor = System.Drawing.Color.White;
            this.btn_ham_and_beef.Location = new System.Drawing.Point(0, 327);
            this.btn_ham_and_beef.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ham_and_beef.Name = "btn_ham_and_beef";
            this.btn_ham_and_beef.Size = new System.Drawing.Size(533, 73);
            this.btn_ham_and_beef.TabIndex = 3;
            this.btn_ham_and_beef.Text = "Ham and Beef";
            this.btn_ham_and_beef.UseVisualStyleBackColor = false;
            this.btn_ham_and_beef.Click += new System.EventHandler(this.btn_ham_and_beef_Click);
            // 
            // btn_ham_and_sweetcorn
            // 
            this.btn_ham_and_sweetcorn.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ham_and_sweetcorn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ham_and_sweetcorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ham_and_sweetcorn.ForeColor = System.Drawing.Color.White;
            this.btn_ham_and_sweetcorn.Location = new System.Drawing.Point(0, 160);
            this.btn_ham_and_sweetcorn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ham_and_sweetcorn.Name = "btn_ham_and_sweetcorn";
            this.btn_ham_and_sweetcorn.Size = new System.Drawing.Size(533, 73);
            this.btn_ham_and_sweetcorn.TabIndex = 2;
            this.btn_ham_and_sweetcorn.Text = "Ham and Sweetcorn";
            this.btn_ham_and_sweetcorn.UseVisualStyleBackColor = false;
            this.btn_ham_and_sweetcorn.Click += new System.EventHandler(this.btn_ham_and_sweetcorn_Click);
            // 
            // btn_chicken_and_salad
            // 
            this.btn_chicken_and_salad.BackColor = System.Drawing.Color.DarkGray;
            this.btn_chicken_and_salad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_chicken_and_salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_chicken_and_salad.ForeColor = System.Drawing.Color.White;
            this.btn_chicken_and_salad.Location = new System.Drawing.Point(0, 0);
            this.btn_chicken_and_salad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chicken_and_salad.Name = "btn_chicken_and_salad";
            this.btn_chicken_and_salad.Size = new System.Drawing.Size(533, 73);
            this.btn_chicken_and_salad.TabIndex = 2;
            this.btn_chicken_and_salad.Text = "Chicken and Salad";
            this.btn_chicken_and_salad.UseVisualStyleBackColor = false;
            this.btn_chicken_and_salad.Click += new System.EventHandler(this.btn_chicken_and_salad_Click);
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
            this.btn_back.Click += new System.EventHandler(this.back_onClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 550);
            this.panel1.TabIndex = 3;
            // 
            // FrmBurgers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBurgers";
            this.Text = "FrmBurgers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBurgers_FormClosed);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ham_and_beef;
        private System.Windows.Forms.Button btn_ham_and_sweetcorn;
        private System.Windows.Forms.Button btn_chicken_and_salad;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
    }
}