namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class EditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_JMBG = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.num_behavior = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_students = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_behavior)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(100, 139);
            this.tb_address.MaxLength = 13;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(200, 20);
            this.tb_address.TabIndex = 4;
            // 
            // tb_JMBG
            // 
            this.tb_JMBG.Location = new System.Drawing.Point(100, 111);
            this.tb_JMBG.MaxLength = 13;
            this.tb_JMBG.Name = "tb_JMBG";
            this.tb_JMBG.Size = new System.Drawing.Size(200, 20);
            this.tb_JMBG.TabIndex = 3;
            this.tb_JMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_JMBG_KeyPress);
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(100, 83);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(200, 20);
            this.tb_lastName.TabIndex = 2;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(100, 55);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(200, 20);
            this.tb_firstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "JMBG";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ime";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Lime;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(17, 259);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(281, 50);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(17, 203);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(281, 50);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Spremi";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // num_behavior
            // 
            this.num_behavior.Location = new System.Drawing.Point(100, 167);
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
            this.label7.Location = new System.Drawing.Point(15, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Vladanje";
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(17, 315);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(136, 50);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Nazad";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Lime;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(162, 315);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(136, 50);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Izlaz";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Učenik";
            // 
            // cb_students
            // 
            this.cb_students.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_students.FormattingEnabled = true;
            this.cb_students.Location = new System.Drawing.Point(100, 15);
            this.cb_students.Name = "cb_students";
            this.cb_students.Size = new System.Drawing.Size(200, 21);
            this.cb_students.Sorted = true;
            this.cb_students.TabIndex = 0;
            this.cb_students.SelectedIndexChanged += new System.EventHandler(this.cb_students_SelectedIndexChanged);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(314, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_students);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_exit);
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
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje učenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditStudent_FormClosed);
            this.Load += new System.EventHandler(this.EditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_behavior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_JMBG;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown num_behavior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_students;
    }
}