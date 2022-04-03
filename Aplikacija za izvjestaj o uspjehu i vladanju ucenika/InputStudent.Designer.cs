namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class InputStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputStudent));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_JMBG = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.num_behavior = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_behavior)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(19, 161);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(281, 50);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Spremi";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Lime;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(19, 217);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(281, 50);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Očisti";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Lime;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(164, 272);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(136, 50);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Izlaz";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "JMBG";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adresa";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(100, 14);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(200, 20);
            this.tb_firstName.TabIndex = 0;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(100, 42);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(200, 20);
            this.tb_lastName.TabIndex = 1;
            // 
            // tb_JMBG
            // 
            this.tb_JMBG.Location = new System.Drawing.Point(100, 70);
            this.tb_JMBG.MaxLength = 13;
            this.tb_JMBG.Name = "tb_JMBG";
            this.tb_JMBG.Size = new System.Drawing.Size(200, 20);
            this.tb_JMBG.TabIndex = 2;
            this.tb_JMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_JMBG_KeyPress);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(100, 98);
            this.tb_address.MaxLength = 13;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(200, 20);
            this.tb_address.TabIndex = 3;
            // 
            // num_behavior
            // 
            this.num_behavior.Location = new System.Drawing.Point(100, 126);
            this.num_behavior.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_behavior.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_behavior.Name = "num_behavior";
            this.num_behavior.Size = new System.Drawing.Size(200, 20);
            this.num_behavior.TabIndex = 5;
            this.num_behavior.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vladanje";
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(19, 272);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(136, 50);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Nazad";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // InputStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(314, 336);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.num_behavior);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_JMBG);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos učenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputStudent_FormClosed);
            this.Load += new System.EventHandler(this.InputStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_behavior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_JMBG;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.NumericUpDown num_behavior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_return;
    }
}