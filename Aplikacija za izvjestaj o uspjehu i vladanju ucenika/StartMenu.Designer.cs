namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btn_newClass = new System.Windows.Forms.Button();
            this.btn_openClass = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_deleteClass = new System.Windows.Forms.Button();
            this.btn_editClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newClass
            // 
            this.btn_newClass.BackColor = System.Drawing.Color.Lime;
            this.btn_newClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_newClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_newClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newClass.Location = new System.Drawing.Point(12, 13);
            this.btn_newClass.Name = "btn_newClass";
            this.btn_newClass.Size = new System.Drawing.Size(220, 50);
            this.btn_newClass.TabIndex = 4;
            this.btn_newClass.Text = "Novi razred";
            this.btn_newClass.UseVisualStyleBackColor = false;
            this.btn_newClass.Click += new System.EventHandler(this.Btn_newClass_Click);
            // 
            // btn_openClass
            // 
            this.btn_openClass.BackColor = System.Drawing.Color.Lime;
            this.btn_openClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_openClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_openClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openClass.Location = new System.Drawing.Point(12, 69);
            this.btn_openClass.Name = "btn_openClass";
            this.btn_openClass.Size = new System.Drawing.Size(220, 50);
            this.btn_openClass.TabIndex = 5;
            this.btn_openClass.Text = "Otvori razred";
            this.btn_openClass.UseVisualStyleBackColor = false;
            this.btn_openClass.Click += new System.EventHandler(this.Btn_openClass_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Lime;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(12, 253);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(220, 50);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Izlaz";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_deleteClass
            // 
            this.btn_deleteClass.BackColor = System.Drawing.Color.Lime;
            this.btn_deleteClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_deleteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_deleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteClass.Location = new System.Drawing.Point(12, 181);
            this.btn_deleteClass.Name = "btn_deleteClass";
            this.btn_deleteClass.Size = new System.Drawing.Size(220, 50);
            this.btn_deleteClass.TabIndex = 8;
            this.btn_deleteClass.Text = "Izbriši razred";
            this.btn_deleteClass.UseVisualStyleBackColor = false;
            this.btn_deleteClass.Click += new System.EventHandler(this.Btn_deleteClass_Click);
            // 
            // btn_editClass
            // 
            this.btn_editClass.BackColor = System.Drawing.Color.Lime;
            this.btn_editClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_editClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_editClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editClass.Location = new System.Drawing.Point(12, 125);
            this.btn_editClass.Name = "btn_editClass";
            this.btn_editClass.Size = new System.Drawing.Size(220, 50);
            this.btn_editClass.TabIndex = 9;
            this.btn_editClass.Text = "Uredi razred";
            this.btn_editClass.UseVisualStyleBackColor = false;
            this.btn_editClass.Click += new System.EventHandler(this.Btn_editClass_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(244, 316);
            this.Controls.Add(this.btn_editClass);
            this.Controls.Add(this.btn_deleteClass);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_openClass);
            this.Controls.Add(this.btn_newClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početni meni";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newClass;
        private System.Windows.Forms.Button btn_openClass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_deleteClass;
        private System.Windows.Forms.Button btn_editClass;
    }
}