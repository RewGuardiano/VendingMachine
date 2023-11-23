
namespace VendingMachineSYS
{
    partial class FrmWraps
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
            this.btn_salad_chicken_wrap = new System.Windows.Forms.Button();
            this.btn_crispy = new System.Windows.Forms.Button();
            this.btn_grilled = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salad_chicken_wrap
            // 
            this.btn_salad_chicken_wrap.BackColor = System.Drawing.Color.DarkGray;
            this.btn_salad_chicken_wrap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salad_chicken_wrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_salad_chicken_wrap.ForeColor = System.Drawing.Color.White;
            this.btn_salad_chicken_wrap.Location = new System.Drawing.Point(0, 327);
            this.btn_salad_chicken_wrap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salad_chicken_wrap.Name = "btn_salad_chicken_wrap";
            this.btn_salad_chicken_wrap.Size = new System.Drawing.Size(533, 73);
            this.btn_salad_chicken_wrap.TabIndex = 3;
            this.btn_salad_chicken_wrap.Text = "Salad Chicken Wrap";
            this.btn_salad_chicken_wrap.UseVisualStyleBackColor = false;
            this.btn_salad_chicken_wrap.Click += new System.EventHandler(this.btn_salad_chicken_wrap_Click);
            // 
            // btn_crispy
            // 
            this.btn_crispy.BackColor = System.Drawing.Color.DarkGray;
            this.btn_crispy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_crispy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_crispy.ForeColor = System.Drawing.Color.White;
            this.btn_crispy.Location = new System.Drawing.Point(0, 160);
            this.btn_crispy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crispy.Name = "btn_crispy";
            this.btn_crispy.Size = new System.Drawing.Size(533, 73);
            this.btn_crispy.TabIndex = 2;
            this.btn_crispy.Text = "Crispy";
            this.btn_crispy.UseVisualStyleBackColor = false;
            this.btn_crispy.Click += new System.EventHandler(this.btn_crispy_Click);
            // 
            // btn_grilled
            // 
            this.btn_grilled.BackColor = System.Drawing.Color.DarkGray;
            this.btn_grilled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_grilled.ForeColor = System.Drawing.Color.White;
            this.btn_grilled.Location = new System.Drawing.Point(0, 0);
            this.btn_grilled.Margin = new System.Windows.Forms.Padding(4);
            this.btn_grilled.Name = "btn_grilled";
            this.btn_grilled.Size = new System.Drawing.Size(533, 73);
            this.btn_grilled.TabIndex = 2;
            this.btn_grilled.Text = "Grilled";
            this.btn_grilled.UseVisualStyleBackColor = false;
            this.btn_grilled.Click += new System.EventHandler(this.btn_grilled_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_salad_chicken_wrap);
            this.panel2.Controls.Add(this.btn_crispy);
            this.panel2.Controls.Add(this.btn_grilled);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(276, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 544);
            this.panel2.TabIndex = 8;
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
            this.panel1.TabIndex = 9;
            // 
            // FrmWraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmWraps";
            this.Text = "FrmWraps";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salad_chicken_wrap;
        private System.Windows.Forms.Button btn_crispy;
        private System.Windows.Forms.Button btn_grilled;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
    }
}